using System;
using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class WorkspaceRepo(AppDbContext _context, IUserWorkspaceRepo _userWorkspaceRepo) : BaseRepo<Workspace>(_context), IWorkspaceRepo
    {
        private readonly DbSet<Workspace> _workspaces = _context.Set<Workspace>();
        public override async Task<Workspace> AddAsync(Workspace entity)
        {
            await _workspaces.AddAsync(entity);
            await _userWorkspaceRepo.AssignRoleToUserInWorkspace(entity.OwnerId, entity.Id, Role.WorkspaceOwner);
            await _context.SaveChangesAsync();
            return entity;
        }
        
    }
}