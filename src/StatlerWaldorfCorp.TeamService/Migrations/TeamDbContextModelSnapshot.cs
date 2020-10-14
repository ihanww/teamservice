using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using StatlerWaldorfCorp.TeamService.Persistence;
using System;

namespace StatlerWaldorfCorp.TeamService.Migrations
{
    [DbContext(typeof(TeamDbContext))]
    partial class TeamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder) {
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:.uuid-ossp", "'uuid-ossp', '', ''")
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("StatlerWaldorfCorp.TeamService.Models.Member", b => {
                b.Property<Guid>("ID").ValueGeneratedOnAdd();
                b.Property<string>("FirstName");
                b.Property<string>("LastName");
                b.Property<Guid?>("TeamID");
                b.HasKey("ID");
                b.HasIndex("TeamID");
                b.ToTable("Members");
            });

            modelBuilder.Entity("StatlerWaldorfCorp.TeamService.Models.Team", b => {
                b.Property<Guid>("ID").ValueGeneratedOnAdd();
                b.Property<string>("Name");
                b.HasKey("ID");
                b.ToTable("Teams");
            });

            modelBuilder.Entity("StatlerWaldorfCorp.TeamService.Models.Member", b => {
                b.HasOne("StatlerWaldorfCorp.TeamService.Models.Team")
                    .WithMany("Members")
                    .HasForeignKey("TeamID");
            });
        }
    }
}
