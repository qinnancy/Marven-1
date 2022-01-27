using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace REAccess.Mobile.Database.LogModels
{
    public partial class LogDatabaseContext : DbContext
    {
        public LogDatabaseContext()
        {
        }

        public LogDatabaseContext(DbContextOptions<LogDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppAccessLog> AppAccessLog { get; set; }
        public virtual DbSet<ReaMobileSysLog> ReaMobileSysLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("LogDatabaseConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "reaccess");

            modelBuilder.Entity<AppAccessLog>(entity =>
            {
                entity.ToTable("app_access_log", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessDate)
                    .HasColumnName("access_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccessFunctionId).HasColumnName("access_function_id");

                entity.Property(e => e.AccessUserId).HasColumnName("access_user_id");

                entity.Property(e => e.HeartbeatDate)
                    .HasColumnName("heartbeat_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestData).HasColumnName("request_data");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasMaxLength(1024);

                entity.Property(e => e.UserSource)
                    .HasColumnName("user_source")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<ReaMobileSysLog>(entity =>
            {
                entity.ToTable("rea_mobile_sys_log", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BrowseType)
                    .HasColumnName("browse_type")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CityIndexPolicyIndustryParamName)
                    .HasColumnName("city_index_policy_industry_param_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Entered)
                    .HasColumnName("entered")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpDetail)
                    .HasColumnName("ip_detail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.PageName)
                    .HasColumnName("page_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousPage)
                    .HasColumnName("previous_page")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RawUrl)
                    .IsRequired()
                    .HasColumnName("raw_url")
                    .HasMaxLength(2048);

                entity.Property(e => e.SectionName)
                    .HasColumnName("section_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StackTrace).HasColumnName("stack_trace");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(2048);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
