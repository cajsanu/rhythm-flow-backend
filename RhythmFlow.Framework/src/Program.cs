using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.IdentityModel.Tokens;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.Authorization;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Controller.src.Middleware;
using RhythmFlow.Controller.src.RouteTransformer;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;
using RhythmFlow.Framework.src.Repo;
using RhythmFlow.Framework.src.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure lowercase URLs
builder.Services.AddRouting(options => options.LowercaseUrls = true);
// builder.Services.AddSingleton<AppDbContext>();
builder.Services.AddDbContext<AppDbContext>();

// Add Repo to scope
builder.Services.AddScoped<IBaseRepo<Project>, ProjectRepo>();
builder.Services.AddScoped<IProjectRepo, ProjectRepo>();
builder.Services.AddScoped<IBaseRepo<Ticket>, TicketRepo>();
builder.Services.AddScoped<ITicketRepo, TicketRepo>();
builder.Services.AddScoped<IBaseRepo<User>, UserRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IBaseRepo<Workspace>, WorkspaceRepo>();
builder.Services.AddScoped<IWorkspaceRepo, WorkspaceRepo>();

// Add Factory
builder.Services.AddScoped<IDtoFactory<Ticket, TicketReadDto>, TicketDtoFactory>();
builder.Services.AddScoped<IDtoFactory<User, UserReadDto>, UserDtoFactory>();
builder.Services.AddScoped<IDtoFactory<Project, ProjectReadDto>, ProjectDtoFactory>();
builder.Services.AddScoped<IDtoFactory<Workspace, WorkspaceReadDto>, WorkspaceDtoFactory>();

// add assignmentService to scope
builder.Services.AddScoped<AssignmentService<Project, ProjectReadDto>>();
builder.Services.AddScoped<AssignmentService<Ticket, TicketReadDto>>();
builder.Services.AddScoped<AssignmentService<Workspace, WorkspaceReadDto>>();

// Add services to scope
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IWorkspaceService, WorkspaceService>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

// Add controller
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new RouteTokenTransformerConvention(new SpinCaseTransformer()));
});

// add authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
#pragma warning disable CS8604 // Possible null reference argument.
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Secret"]))
    };
#pragma warning restore CS8604 // Possible null reference argument.
});

// add authorization
builder.Services.AddAuthorizationBuilder()
        .AddPolicy("WorkspaceDeveloperPolicy", policy => policy.Requirements.Add(new RoleInWorkspaceRequirement([Role.Developer, Role.ProjectManager, Role.WorkspaceOwner])))
        .AddPolicy("WorkspaceProjectManagerPolicy", policy => policy.Requirements.Add(new RoleInWorkspaceRequirement([Role.ProjectManager, Role.WorkspaceOwner])))
        .AddPolicy("WorkspaceOwnerPolicy", policy => policy.Requirements.Add(new RoleInWorkspaceRequirement([Role.WorkspaceOwner])))
        .AddPolicy("UserInProjectPolicy", policy => policy.Requirements.Add(new UserInProjectRequirement()));

// add exception handling middleware
builder.Services.AddTransient<ExceptionHandlerMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    // putting this here since this can hide errors during development
    app.UseMiddleware<ExceptionHandlerMiddleware>();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
