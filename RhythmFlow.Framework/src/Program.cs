using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.IdentityModel.Tokens;
using RhythmFlow.Application.src.Authorization;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Controller.src.Middleware;
using RhythmFlow.Controller.src.RouteTransformer;
using RhythmFlow.Framework.src.Data;
using RhythmFlow.Framework.src.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure lowercase URLs
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddScoped<AppDbContext>();

// add services to scope
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IWorkspaceService, WorkspaceService>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

// add controller
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
});

// add authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("WorkspaceProjectManagerPolicy", policy =>
        policy.Requirements.Add(new RoleInWorkspaceRequirement("ProjectManager")));
    options.AddPolicy("WorkspaceDeveloperPolicy", policy =>
        policy.Requirements.Add(new RoleInWorkspaceRequirement("Developer")));
    options.AddPolicy("WorkspaceOwnerPolicy", policy =>
        policy.Requirements.Add(new RoleInWorkspaceRequirement("WorkspaceOwner")));
    options.AddPolicy("ProjectManagerPolicy", policy =>
        policy.Requirements.Add(new ManagerInProjectRequirement("ProjectManager")));
});

// add exception handling middleware
builder.Services.AddTransient<ExceptionHandlerMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.MapControllers();
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.Run();
