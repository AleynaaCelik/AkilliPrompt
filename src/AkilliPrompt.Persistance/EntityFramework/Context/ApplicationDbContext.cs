﻿using AkilliPrompt.Domain.Entities;
using AkilliPrompt.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AkilliPrompt.Persistence.EntityFramework.Contexts;

public sealed class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApllicationRole, long, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<PlaceHolder> PlaceHolders { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Prompt> Prompts { get; set; }
    public DbSet<PromptCategory> PromptCategories { get; set; }
    public DbSet<UserSocialMediaAccount> UserSocialMediaAccounts { get; set; }
    public DbSet<UserPromptComment> UserPromptComments { get; set; }
    public DbSet<UserFavoritePrompt> UserFavoritePrompts { get; set; }
    public DbSet<UserLikePrompt> UserLikePrompts { get; set; }

    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //    builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

    //    //builder.ToSnakeCaseNames();
    //}
}