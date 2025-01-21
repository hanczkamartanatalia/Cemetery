using EntitiesLib.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Config
{
    public class AppDbContext : DbContext
    {
        public DbSet<Dead> Deads { get; set; }
        public DbSet<DeadSquare> DeadSquares { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Funeral> Funerals { get; set; }
        public DbSet<FuneralEmployee> FuneralEmployees { get; set; }
        public DbSet<Hire> Hires { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<OwnerHire> OwnerHires { get; set; }
        public DbSet<Square> Squares { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabaseConfig.CONNECTING_STRING);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(Entity).IsAssignableFrom(entityType.ClrType))
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(Entity.IsDeleted))
                        .HasDefaultValue(false);
                    modelBuilder.Entity(entityType.ClrType)
                      .HasQueryFilter(ConvertFilterExpression(entityType.ClrType));
                }

                var idProperty = entityType.FindProperty("Id");
                if (idProperty != null)
                {
                    modelBuilder.Entity(entityType.ClrType).HasKey("Id");
                }
            }
            //modelBuilder.Entity<VisitType>()
            //    .Property(v => v.Price)
            //    .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<FuneralEmployee>()
                .HasOne(fe => fe.Employee)
                .WithMany()
                .HasForeignKey(fe => fe.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction

            modelBuilder.Entity<FuneralEmployee>()
                .HasOne(fe => fe.Funeral)
                .WithMany()
                .HasForeignKey(fe => fe.FuneralId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction


        }

        private static LambdaExpression ConvertFilterExpression(Type entityType)
        {
            var parameter = Expression.Parameter(entityType, "e");
            var isDeletedProperty = Expression.Property(parameter, nameof(Entity.IsDeleted));
            var notDeleted = Expression.Not(isDeletedProperty);
            return Expression.Lambda(notDeleted, parameter);
        }
    }
}
