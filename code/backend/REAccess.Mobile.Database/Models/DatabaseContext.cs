using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace REAccess.Mobile.Database.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppAccessLog> AppAccessLog { get; set; }
        public virtual DbSet<AppConfig> AppConfig { get; set; }
        public virtual DbSet<AppDictGroup> AppDictGroup { get; set; }
        public virtual DbSet<AppDictItem> AppDictItem { get; set; }
        public virtual DbSet<AppDistrict> AppDistrict { get; set; }
        public virtual DbSet<AppFeedback> AppFeedback { get; set; }
        public virtual DbSet<AppFunction> AppFunction { get; set; }
        public virtual DbSet<AppHomepageCityContrast> AppHomepageCityContrast { get; set; }
        public virtual DbSet<AppHomepageCityRanking> AppHomepageCityRanking { get; set; }
        public virtual DbSet<AppHomepageCityRankingDetail> AppHomepageCityRankingDetail { get; set; }
        public virtual DbSet<AppHomepageInformation> AppHomepageInformation { get; set; }
        public virtual DbSet<AppHomepageInformationDetail> AppHomepageInformationDetail { get; set; }
        public virtual DbSet<AppHomepageInvestmentProjects> AppHomepageInvestmentProjects { get; set; }
        public virtual DbSet<AppHomepageMacroData> AppHomepageMacroData { get; set; }
        public virtual DbSet<AppHomepageMacroDataDetail> AppHomepageMacroDataDetail { get; set; }
        public virtual DbSet<AppLimitFunctionid> AppLimitFunctionid { get; set; }
        public virtual DbSet<AppRankingList> AppRankingList { get; set; }
        public virtual DbSet<AppRankingListDetail> AppRankingListDetail { get; set; }
        public virtual DbSet<AppRole> AppRole { get; set; }
        public virtual DbSet<AppRoleConfig> AppRoleConfig { get; set; }
        public virtual DbSet<AppRoleFunction> AppRoleFunction { get; set; }
        public virtual DbSet<AppSurvey> AppSurvey { get; set; }
        public virtual DbSet<AppSurveyAnswer> AppSurveyAnswer { get; set; }
        public virtual DbSet<AppSurveyQuestion> AppSurveyQuestion { get; set; }
        public virtual DbSet<AppSurveyUserAnswer> AppSurveyUserAnswer { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<AppUserLimitLog> AppUserLimitLog { get; set; }
        public virtual DbSet<AppUserLoginSession> AppUserLoginSession { get; set; }
        public virtual DbSet<AppUserPageLimittimes> AppUserPageLimittimes { get; set; }
        public virtual DbSet<AppUserPreference> AppUserPreference { get; set; }
        public virtual DbSet<AppUserRole> AppUserRole { get; set; }
        public virtual DbSet<CityGroup> CityGroup { get; set; }
        public virtual DbSet<DdsDDistrict> DdsDDistrict { get; set; }
        public virtual DbSet<DdsFCostData> DdsFCostData { get; set; }
        public virtual DbSet<DdsFFacility> DdsFFacility { get; set; }
        public virtual DbSet<DdsFFinance> DdsFFinance { get; set; }
        public virtual DbSet<DdsFGaodeDrivingTime> DdsFGaodeDrivingTime { get; set; }
        public virtual DbSet<DdsFGaodePoiCount> DdsFGaodePoiCount { get; set; }
        public virtual DbSet<DdsFIndustryData> DdsFIndustryData { get; set; }
        public virtual DbSet<DdsFInnovationData> DdsFInnovationData { get; set; }
        public virtual DbSet<DdsFMacroData> DdsFMacroData { get; set; }
        public virtual DbSet<DdsFRailwayClass> DdsFRailwayClass { get; set; }
        public virtual DbSet<DdsFTransit> DdsFTransit { get; set; }
        public virtual DbSet<DdsNews> DdsNews { get; set; }
        public virtual DbSet<DdsSDataIndicator> DdsSDataIndicator { get; set; }
        public virtual DbSet<DdsSDataIndicatorFixed> DdsSDataIndicatorFixed { get; set; }
        public virtual DbSet<DdsSDataIndicatorRank> DdsSDataIndicatorRank { get; set; }
        public virtual DbSet<DdsSIndexSystem> DdsSIndexSystem { get; set; }
        public virtual DbSet<DevelopmentDistrict> DevelopmentDistrict { get; set; }
        public virtual DbSet<DsaAirportsThroughput> DsaAirportsThroughput { get; set; }
        public virtual DbSet<DsaAnjukeResidentialPrice> DsaAnjukeResidentialPrice { get; set; }
        public virtual DbSet<DsaAnjukeResidentialRent> DsaAnjukeResidentialRent { get; set; }
        public virtual DbSet<DsaDistricts> DsaDistricts { get; set; }
        public virtual DbSet<DsaDrivingTime> DsaDrivingTime { get; set; }
        public virtual DbSet<DsaGanjiIndustrialRent> DsaGanjiIndustrialRent { get; set; }
        public virtual DbSet<DsaGdcGeneralData> DsaGdcGeneralData { get; set; }
        public virtual DbSet<DsaGdcIndustryData> DsaGdcIndustryData { get; set; }
        public virtual DbSet<DsaGdcInvestedCompanies> DsaGdcInvestedCompanies { get; set; }
        public virtual DbSet<DsaHospitalBeds> DsaHospitalBeds { get; set; }
        public virtual DbSet<DsaIfindLandSales> DsaIfindLandSales { get; set; }
        public virtual DbSet<DsaIndustrialPark> DsaIndustrialPark { get; set; }
        public virtual DbSet<DsaIndustryChains> DsaIndustryChains { get; set; }
        public virtual DbSet<DsaIndustryFieldTag> DsaIndustryFieldTag { get; set; }
        public virtual DbSet<DsaIndustryLand> DsaIndustryLand { get; set; }
        public virtual DbSet<DsaInvestedProjects> DsaInvestedProjects { get; set; }
        public virtual DbSet<DsaLianjiaCommercialRent> DsaLianjiaCommercialRent { get; set; }
        public virtual DbSet<DsaListedCompanies> DsaListedCompanies { get; set; }
        public virtual DbSet<DsaListedCompanyInvestment> DsaListedCompanyInvestment { get; set; }
        public virtual DbSet<DsaMainIndustryConfiguration> DsaMainIndustryConfiguration { get; set; }
        public virtual DbSet<DsaParkGov> DsaParkGov { get; set; }
        public virtual DbSet<DsaParkGovBak> DsaParkGovBak { get; set; }
        public virtual DbSet<DsaParkGovWebsite> DsaParkGovWebsite { get; set; }
        public virtual DbSet<DsaParkGovWebsiteBak> DsaParkGovWebsiteBak { get; set; }
        public virtual DbSet<DsaParkInfo> DsaParkInfo { get; set; }
        public virtual DbSet<DsaParkInfoBak> DsaParkInfoBak { get; set; }
        public virtual DbSet<DsaParkMainIndustry> DsaParkMainIndustry { get; set; }
        public virtual DbSet<DsaParkMainIndustryBak> DsaParkMainIndustryBak { get; set; }
        public virtual DbSet<DsaParkWebsites> DsaParkWebsites { get; set; }
        public virtual DbSet<DsaParkWebsitesBak> DsaParkWebsitesBak { get; set; }
        public virtual DbSet<DsaPolicyFiles> DsaPolicyFiles { get; set; }
        public virtual DbSet<DsaPolicyIndustryFieldTagRelation> DsaPolicyIndustryFieldTagRelation { get; set; }
        public virtual DbSet<DsaRailwayClass> DsaRailwayClass { get; set; }
        public virtual DbSet<DsaReaIndustryMapping> DsaReaIndustryMapping { get; set; }
        public virtual DbSet<DsaSolidSmallMediumCompanies> DsaSolidSmallMediumCompanies { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<Geo> Geo { get; set; }
        public virtual DbSet<IndicatorInstruction> IndicatorInstruction { get; set; }
        public virtual DbSet<IndustryCategory> IndustryCategory { get; set; }
        public virtual DbSet<Sor12306TrainScheduleDetail> Sor12306TrainScheduleDetail { get; set; }
        public virtual DbSet<SorAirportsThroughput> SorAirportsThroughput { get; set; }
        public virtual DbSet<SorAnjukeResidentialData> SorAnjukeResidentialData { get; set; }
        public virtual DbSet<SorDistrictMaster> SorDistrictMaster { get; set; }
        public virtual DbSet<SorDistrictMasterBackup> SorDistrictMasterBackup { get; set; }
        public virtual DbSet<SorGanjiIndustrialRent> SorGanjiIndustrialRent { get; set; }
        public virtual DbSet<SorGaode4aScenicSpot> SorGaode4aScenicSpot { get; set; }
        public virtual DbSet<SorGaodeDrivingTime> SorGaodeDrivingTime { get; set; }
        public virtual DbSet<SorGaodePoiDetailData> SorGaodePoiDetailData { get; set; }
        public virtual DbSet<SorGdcCostData> SorGdcCostData { get; set; }
        public virtual DbSet<SorGdcFinancialData> SorGdcFinancialData { get; set; }
        public virtual DbSet<SorGdcIndustryData> SorGdcIndustryData { get; set; }
        public virtual DbSet<SorGdcInnovationData> SorGdcInnovationData { get; set; }
        public virtual DbSet<SorGdcInvestmentData> SorGdcInvestmentData { get; set; }
        public virtual DbSet<SorGdcMacroScaleData> SorGdcMacroScaleData { get; set; }
        public virtual DbSet<SorIfindLandSales> SorIfindLandSales { get; set; }
        public virtual DbSet<SorLianjiaCommercialRent> SorLianjiaCommercialRent { get; set; }
        public virtual DbSet<SorQicheBusScheduleDetail> SorQicheBusScheduleDetail { get; set; }
        public virtual DbSet<SorReaIndustryMapping> SorReaIndustryMapping { get; set; }
        public virtual DbSet<VcityParkList> VcityParkList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                var sqlServerDb = Configuration.GetSection("SqlServerDb").Value;
                optionsBuilder.UseSqlServer(sqlServerDb);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppAccessLog>(entity =>
            {
                entity.ToTable("app_access_log");

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

                entity.HasOne(d => d.AccessFunction)
                    .WithMany(p => p.AppAccessLog)
                    .HasForeignKey(d => d.AccessFunctionId)
                    .HasConstraintName("FK_app_access_log_app_function");

                entity.HasOne(d => d.AccessUser)
                    .WithMany(p => p.AppAccessLog)
                    .HasForeignKey(d => d.AccessUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_access_log_app_user");
            });

            modelBuilder.Entity<AppConfig>(entity =>
            {
                entity.ToTable("app_config");

                entity.HasComment("?????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.ConfigName)
                    .IsRequired()
                    .HasColumnName("config_name")
                    .HasMaxLength(1024)
                    .HasComment("?????");

                entity.Property(e => e.ConfigType)
                    .IsRequired()
                    .HasColumnName("config_type")
                    .HasMaxLength(1024)
                    .HasComment("????");

                entity.Property(e => e.ConfigValue)
                    .IsRequired()
                    .HasColumnName("config_value")
                    .HasMaxLength(1024)
                    .HasComment("????");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasComment("???");

                entity.Property(e => e.LastUpdatedAt)
                    .HasColumnName("last_updated_at")
                    .HasColumnType("date")
                    .HasComment("??????");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("last_updated_by")
                    .HasComment("?????");
            });

            modelBuilder.Entity<AppDictGroup>(entity =>
            {
                entity.ToTable("app_dict_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AppDictItem>(entity =>
            {
                entity.ToTable("app_dict_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppDictGroupId).HasColumnName("app_dict_group_id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.HasOne(d => d.AppDictGroup)
                    .WithMany(p => p.AppDictItem)
                    .HasForeignKey(d => d.AppDictGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_dict_item_app_dict_item");
            });

            modelBuilder.Entity<AppDistrict>(entity =>
            {
                entity.ToTable("app_district");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DistrictId)
                    .HasColumnName("district_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvId)
                    .HasColumnName("prov_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AppFeedback>(entity =>
            {
                entity.ToTable("app_feedback");

                entity.HasComment("???????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CompanyAdress)
                    .HasColumnName("company_adress")
                    .HasMaxLength(3072);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("contact_email")
                    .HasMaxLength(1024)
                    .HasComment("??");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("contact_name")
                    .HasMaxLength(1024)
                    .HasComment("??");

                entity.Property(e => e.ContactPhone)
                    .HasColumnName("contact_phone")
                    .HasMaxLength(1024)
                    .HasComment("????");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.IsProcessed)
                    .IsRequired()
                    .HasColumnName("is_processed")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .HasComment("????");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(3072)
                    .HasComment("??");

                entity.Property(e => e.ProcessedAt)
                    .HasColumnName("processed_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.ProcessedBy)
                    .HasColumnName("processed_by")
                    .HasComment("???");

                entity.Property(e => e.ProcessedMessage)
                    .HasColumnName("processed_message")
                    .HasMaxLength(3072)
                    .HasComment("????");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("???");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppFeedback)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_af_au_id");
            });

            modelBuilder.Entity<AppFunction>(entity =>
            {
                entity.ToTable("app_function");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Page)
                    .HasColumnName("page")
                    .HasMaxLength(255);

                entity.Property(e => e.Route)
                    .HasColumnName("route")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AppHomepageCityContrast>(entity =>
            {
                entity.ToTable("app_homepage_city_contrast");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContrastCityOne)
                    .HasColumnName("contrast_city_one")
                    .HasMaxLength(1024);

                entity.Property(e => e.ContrastCityOneData)
                    .HasColumnName("contrast_city_one_data")
                    .HasMaxLength(1024);

                entity.Property(e => e.ContrastCityTwo)
                    .HasColumnName("contrast_city_two")
                    .HasMaxLength(1024);

                entity.Property(e => e.ContrastCityTwoData)
                    .HasColumnName("contrast_city_two_data")
                    .HasMaxLength(1024);

                entity.Property(e => e.ContrastIndicatorName)
                    .HasColumnName("contrast_indicator_name")
                    .HasMaxLength(1024);

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.Isvalid)
                    .HasColumnName("isvalid")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppHomepageCityRanking>(entity =>
            {
                entity.ToTable("app_homepage_city_ranking");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(1024);

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.Isvalid)
                    .HasColumnName("isvalid")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppHomepageCityRankingDetail>(entity =>
            {
                entity.ToTable("app_homepage_city_ranking_detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityRankingId).HasColumnName("city_ranking_id");

                entity.Property(e => e.DispalyOrder).HasColumnName("dispaly_order");

                entity.Property(e => e.IndicatorName)
                    .HasColumnName("indicator_name")
                    .HasMaxLength(1024);

                entity.Property(e => e.IndicatorPlace)
                    .HasColumnName("indicator_place")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CityRanking)
                    .WithMany(p => p.AppHomepageCityRankingDetail)
                    .HasForeignKey(d => d.CityRankingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_homepage_city_ranking");
            });

            modelBuilder.Entity<AppHomepageInformation>(entity =>
            {
                entity.ToTable("app_homepage_information");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HomepageIndicator)
                    .IsRequired()
                    .HasColumnName("homepage_indicator")
                    .HasMaxLength(1024);

                entity.Property(e => e.HomepageIndicatorCity)
                    .IsRequired()
                    .HasColumnName("homepage_indicator_city")
                    .HasMaxLength(1024);

                entity.Property(e => e.HomepageIndicatorContrast)
                    .IsRequired()
                    .HasColumnName("homepage_indicator_contrast")
                    .HasMaxLength(1024);

                entity.Property(e => e.HomepageProjectId).HasColumnName("homepage_project_id");
            });

            modelBuilder.Entity<AppHomepageInformationDetail>(entity =>
            {
                entity.ToTable("app_homepage_information_detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(225);

                entity.Property(e => e.ContrastCity1)
                    .IsRequired()
                    .HasColumnName("contrast_city1")
                    .HasMaxLength(225);

                entity.Property(e => e.ContrastCity2)
                    .IsRequired()
                    .HasColumnName("contrast_city2")
                    .HasMaxLength(225);

                entity.Property(e => e.HomepageId).HasColumnName("homepage_id");

                entity.HasOne(d => d.Homepage)
                    .WithMany(p => p.AppHomepageInformationDetail)
                    .HasForeignKey(d => d.HomepageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_homepage_information");
            });

            modelBuilder.Entity<AppHomepageInvestmentProjects>(entity =>
            {
                entity.ToTable("app_homepage_investment_projects");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.InvestmentArea)
                    .HasColumnName("investment_area")
                    .HasMaxLength(1024);

                entity.Property(e => e.InvestmentScale)
                    .HasColumnName("investment_scale")
                    .HasMaxLength(1024);

                entity.Property(e => e.InvestmentScaleUnit)
                    .HasColumnName("investment_scale_unit")
                    .HasMaxLength(1024);

                entity.Property(e => e.Isvalid)
                    .HasColumnName("isvalid")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OutputValue)
                    .HasColumnName("output_value")
                    .HasMaxLength(1024);

                entity.Property(e => e.OutputValueUnit)
                    .HasColumnName("output_value_unit")
                    .HasMaxLength(1024);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(2048);

                entity.Property(e => e.SharesName)
                    .HasColumnName("shares_name")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<AppHomepageMacroData>(entity =>
            {
                entity.ToTable("app_homepage_macro_data");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.Isvalid)
                    .HasColumnName("isvalid")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KpiName)
                    .HasColumnName("kpi_name")
                    .HasMaxLength(1024);

                entity.Property(e => e.KpiUnit)
                    .HasColumnName("kpi_unit")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<AppHomepageMacroDataDetail>(entity =>
            {
                entity.ToTable("app_homepage_macro_data_detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MacroDataId).HasColumnName("macro_data_id");

                entity.Property(e => e.ParticularYear)
                    .HasColumnName("particular_year")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularYearData)
                    .HasColumnName("particular_year_data")
                    .HasMaxLength(1024);

                entity.HasOne(d => d.MacroData)
                    .WithMany(p => p.AppHomepageMacroDataDetail)
                    .HasForeignKey(d => d.MacroDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_homepage_macro_data");
            });

            modelBuilder.Entity<AppLimitFunctionid>(entity =>
            {
                entity.ToTable("app_limit_functionid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LimitCount).HasColumnName("limit_count");

                entity.Property(e => e.LimitFunctionId).HasColumnName("limit_Function_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<AppRankingList>(entity =>
            {
                entity.ToTable("app_ranking_list");

                entity.HasComment("?????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.Algorithm)
                    .HasColumnName("algorithm")
                    .HasMaxLength(3072);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.ListDesc)
                    .HasColumnName("list_desc")
                    .HasMaxLength(3072)
                    .HasComment("????");

                entity.Property(e => e.ListDisplayOrder)
                    .HasColumnName("list_display_order")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnName("list_name")
                    .HasMaxLength(128)
                    .HasComment("????");

                entity.Property(e => e.ListOwnerId)
                    .HasColumnName("list_owner_id")
                    .HasComment("??????id");

                entity.Property(e => e.ListType)
                    .IsRequired()
                    .HasColumnName("list_type")
                    .HasMaxLength(32)
                    .HasComment("????");

                entity.HasOne(d => d.ListOwner)
                    .WithMany(p => p.AppRankingList)
                    .HasForeignKey(d => d.ListOwnerId)
                    .HasConstraintName("fk_arl_au_id");
            });

            modelBuilder.Entity<AppRankingListDetail>(entity =>
            {
                entity.ToTable("app_ranking_list_detail");

                entity.HasComment("?????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.IndicatorClass3Id)
                    .HasColumnName("indicator_class3_id")
                    .HasComment("???");

                entity.Property(e => e.IndicatorDisplay)
                    .HasColumnName("indicator_display")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndicatorWeight)
                    .HasColumnName("indicator_weight")
                    .HasColumnType("decimal(32, 10)")
                    .HasComment("????");

                entity.Property(e => e.RankingListId)
                    .HasColumnName("ranking_list_id")
                    .HasComment("??Id");

                entity.HasOne(d => d.IndicatorClass3)
                    .WithMany(p => p.AppRankingListDetail)
                    .HasForeignKey(d => d.IndicatorClass3Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_ranking_list_detail_indicator_instruction");

                entity.HasOne(d => d.RankingList)
                    .WithMany(p => p.AppRankingListDetail)
                    .HasForeignKey(d => d.RankingListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_arld_arl_id");
            });

            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.ToTable("app_role");

                entity.HasComment("?????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasComment("???");

                entity.Property(e => e.RoleDesc)
                    .HasColumnName("role_desc")
                    .HasMaxLength(3072)
                    .HasComment("????");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(128)
                    .HasComment("????");
            });

            modelBuilder.Entity<AppRoleConfig>(entity =>
            {
                entity.ToTable("app_role_config");

                entity.HasComment("???????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CanRead)
                    .IsRequired()
                    .HasColumnName("can_read")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("???");

                entity.Property(e => e.CanWrite)
                    .IsRequired()
                    .HasColumnName("can_write")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("???");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasComment("???");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasMaxLength(128)
                    .HasComment("??????");

                entity.Property(e => e.ModuleType)
                    .HasColumnName("module_type")
                    .HasMaxLength(128)
                    .HasComment("??????");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasComment("??id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppRoleConfig)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_arc_ar_id");
            });

            modelBuilder.Entity<AppRoleFunction>(entity =>
            {
                entity.ToTable("app_role_function");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FunctionId).HasColumnName("function_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.AppRoleFunction)
                    .HasForeignKey(d => d.FunctionId)
                    .HasConstraintName("FK_app_role_function_app_function");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppRoleFunction)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_app_role_function_app_role_function");
            });

            modelBuilder.Entity<AppSurvey>(entity =>
            {
                entity.ToTable("app_survey");

                entity.HasComment("???????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasComment("???");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .HasComment("????");

                entity.Property(e => e.Question1Id)
                    .HasColumnName("question1_id")
                    .HasComment("??1id");

                entity.Property(e => e.Question2Id)
                    .HasColumnName("question2_id")
                    .HasComment("??2id");

                entity.Property(e => e.Question3Id)
                    .HasColumnName("question3_id")
                    .HasComment("??3id");

                entity.Property(e => e.Question4Id)
                    .HasColumnName("question4_id")
                    .HasComment("??4id");

                entity.Property(e => e.Question5Id)
                    .HasColumnName("question5_id")
                    .HasComment("??5id");

                entity.HasOne(d => d.Question1)
                    .WithMany(p => p.AppSurveyQuestion1)
                    .HasForeignKey(d => d.Question1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_as_asq_id1");

                entity.HasOne(d => d.Question2)
                    .WithMany(p => p.AppSurveyQuestion2)
                    .HasForeignKey(d => d.Question2Id)
                    .HasConstraintName("fk_as_asq_id2");

                entity.HasOne(d => d.Question3)
                    .WithMany(p => p.AppSurveyQuestion3)
                    .HasForeignKey(d => d.Question3Id)
                    .HasConstraintName("fk_as_asq_id3");

                entity.HasOne(d => d.Question4)
                    .WithMany(p => p.AppSurveyQuestion4)
                    .HasForeignKey(d => d.Question4Id)
                    .HasConstraintName("fk_as_asq_id4");

                entity.HasOne(d => d.Question5)
                    .WithMany(p => p.AppSurveyQuestion5)
                    .HasForeignKey(d => d.Question5Id)
                    .HasConstraintName("fk_as_asq_id5");
            });

            modelBuilder.Entity<AppSurveyAnswer>(entity =>
            {
                entity.ToTable("app_survey_answer");

                entity.HasComment("??????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.Question1Answer)
                    .IsRequired()
                    .HasColumnName("question1_answer")
                    .HasMaxLength(3072)
                    .HasComment("??1??");

                entity.Property(e => e.Question2Answer)
                    .HasColumnName("question2_answer")
                    .HasMaxLength(3072)
                    .HasComment("??1??");

                entity.Property(e => e.Question3Answer)
                    .HasColumnName("question3_answer")
                    .HasMaxLength(3072)
                    .HasComment("??1??");

                entity.Property(e => e.Question4Answer)
                    .HasColumnName("question4_answer")
                    .HasMaxLength(3072)
                    .HasComment("??1??");

                entity.Property(e => e.Question5Answer)
                    .HasColumnName("question5_answer")
                    .HasMaxLength(3072)
                    .HasComment("??1??");

                entity.Property(e => e.SurveyId)
                    .HasColumnName("survey_id")
                    .HasComment("??id");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("??id");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.AppSurveyAnswer)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_asa_as_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppSurveyAnswer)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_asa_au_id");
            });

            modelBuilder.Entity<AppSurveyQuestion>(entity =>
            {
                entity.ToTable("app_survey_question");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(32);

                entity.Property(e => e.IsValid)
                    .IsRequired()
                    .HasColumnName("isValid")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mandatory)
                    .IsRequired()
                    .HasColumnName("mandatory")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OptionalCounts).HasColumnName("optional_counts");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasMaxLength(3072);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .HasMaxLength(3072);

                entity.Property(e => e.QuestionOrder).HasColumnName("question_order");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(128);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnName("user_type")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<AppSurveyUserAnswer>(entity =>
            {
                entity.ToTable("app_survey_user_answer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.UserAnswer).HasColumnName("user_answer");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.AppSurveyUserAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("app_survey_question1");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("app_user");

                entity.HasComment("?????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailReminder)
                    .HasColumnName("email_reminder")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Isvalid)
                    .HasColumnName("isvalid")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JupiterCode)
                    .HasColumnName("jupiter_code")
                    .HasMaxLength(1024);

                entity.Property(e => e.LastUpdatedAt)
                    .HasColumnName("last_updated_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.PrimeMoverIndustry)
                    .HasColumnName("prime_mover_industry")
                    .HasMaxLength(2048);

                entity.Property(e => e.RegTime)
                    .HasColumnName("reg_time")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.SigningEndTime)
                    .HasColumnName("signing_end_time")
                    .HasColumnType("date");

                entity.Property(e => e.SigningStartTime)
                    .HasColumnName("signing_start_time")
                    .HasColumnType("date");

                entity.Property(e => e.UseCounts).HasColumnName("use_counts");

                entity.Property(e => e.UserApproved)
                    .HasColumnName("user_approved")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserCity)
                    .HasColumnName("user_city")
                    .HasMaxLength(1024);

                entity.Property(e => e.UserDistrict)
                    .HasColumnName("user_district")
                    .HasMaxLength(1024);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(1024)
                    .HasComment("????");

                entity.Property(e => e.UserIndustry)
                    .HasColumnName("user_industry")
                    .HasMaxLength(1024);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(128)
                    .HasComment("???");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(1024)
                    .HasComment("????");

                entity.Property(e => e.UserPhone)
                    .HasColumnName("user_phone")
                    .HasMaxLength(1024)
                    .HasComment("????");

                entity.Property(e => e.UserPosition)
                    .HasColumnName("user_position")
                    .HasMaxLength(1024);

                entity.Property(e => e.UserProvince)
                    .HasColumnName("user_province")
                    .HasMaxLength(1024);

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasMaxLength(255);

                entity.Property(e => e.UserZone)
                    .HasColumnName("user_zone")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<AppUserLimitLog>(entity =>
            {
                entity.ToTable("app_user_limit_log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessDate)
                    .HasColumnName("access_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FunctionName)
                    .HasColumnName("function_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AppUserLoginSession>(entity =>
            {
                entity.ToTable("app_user_login_session");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessDate)
                    .HasColumnName("access_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsValid)
                    .HasColumnName("isValid")
                    .HasMaxLength(1);

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AppUserPageLimittimes>(entity =>
            {
                entity.ToTable("app_user_page_limittimes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.FunctionId).HasColumnName("function_id");

                entity.Property(e => e.Isvalid)
                    .IsRequired()
                    .HasColumnName("isvalid")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.AppUserPageLimittimes)
                    .HasForeignKey(d => d.FunctionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_function");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserPageLimittimes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_app_user");
            });

            modelBuilder.Entity<AppUserPreference>(entity =>
            {
                entity.ToTable("app_user_preference");

                entity.HasComment("?????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.PrefType)
                    .IsRequired()
                    .HasColumnName("pref_type")
                    .HasMaxLength(1024)
                    .HasComment("?????");

                entity.Property(e => e.PrefValue)
                    .IsRequired()
                    .HasColumnName("pref_value")
                    .HasMaxLength(1024)
                    .HasComment("????");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("??id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserPreference)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aup_au_id");
            });

            modelBuilder.Entity<AppUserRole>(entity =>
            {
                entity.ToTable("app_user_role");

                entity.HasComment("???????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasComment("????");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasComment("???");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasComment("??id");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("??id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aur_ar_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppUserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aur_au_id");
            });

            modelBuilder.Entity<CityGroup>(entity =>
            {
                entity.ToTable("city_group");

                entity.HasComment("???");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.CitySk)
                    .HasColumnName("city_sk")
                    .HasComment("??sk??");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(1024)
                    .HasComment("?????");

                entity.HasOne(d => d.CitySkNavigation)
                    .WithMany(p => p.CityGroup)
                    .HasForeignKey(d => d.CitySk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_cg_dd_sk");
            });

            modelBuilder.Entity<DdsDDistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictSk);

                entity.ToTable("dds_d_district", "dds");

                entity.Property(e => e.DistrictSk)
                    .HasColumnName("district_sk")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityAdCode)
                    .IsRequired()
                    .HasColumnName("city_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CityCenterCoords)
                    .IsRequired()
                    .HasColumnName("city_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.CityCode)
                    .HasColumnName("city_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CityLevel)
                    .HasColumnName("city_level")
                    .HasMaxLength(255);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictAdCode)
                    .IsRequired()
                    .HasColumnName("district_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictCenterCoords)
                    .IsRequired()
                    .HasColumnName("district_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.GdpRank).HasColumnName("gdp_rank");

                entity.Property(e => e.ProjectPhase)
                    .HasColumnName("project_phase")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvAdCode)
                    .IsRequired()
                    .HasColumnName("prov_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.ProvCenterCoords)
                    .IsRequired()
                    .HasColumnName("prov_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RankingOfCities).HasColumnName("ranking_of_cities");

                entity.Property(e => e.RankingOfProvinces).HasColumnName("ranking_of_provinces");
            });

            modelBuilder.Entity<DdsFCostData>(entity =>
            {
                entity.ToTable("dds_f_cost_data", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageCommercialLandArea)
                    .HasColumnName("average_commercial_land_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageCommercialLandPrice)
                    .HasColumnName("average_commercial_land_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageCommercialRentArea)
                    .HasColumnName("average_commercial_rent_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageCommercialRentRate)
                    .HasColumnName("average_commercial_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageIndustrialLandArea)
                    .HasColumnName("average_industrial_land_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageIndustrialLandPrice)
                    .HasColumnName("average_industrial_land_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageIndustrialRentArea)
                    .HasColumnName("average_industrial_rent_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageIndustrialRentRate)
                    .HasColumnName("average_industrial_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.IndustrialElectricityPrice)
                    .HasColumnName("industrial_electricity_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IndustrialGasPrice)
                    .HasColumnName("industrial_gas_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IndustrialHeatPrice)
                    .HasColumnName("industrial_heat_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IndustrialWaterPrice)
                    .HasColumnName("industrial_water_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrginaryLabourSalary)
                    .HasColumnName("orginary_labour_salary")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.RelativeLabourCost)
                    .HasColumnName("relative_labour_cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DdsFFacility>(entity =>
            {
                entity.ToTable("dds_f_facility", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirQuality)
                    .HasColumnName("air_quality")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ArtGalleryCount).HasColumnName("art_gallery_count");

                entity.Property(e => e.AvgHousePrice).HasColumnName("avg_house_price");

                entity.Property(e => e.AvgRent).HasColumnName("avg_rent");

                entity.Property(e => e.CinemaCount).HasColumnName("cinema_count");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(6);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.GreenCoverageRatioHectare)
                    .HasColumnName("green_coverage_ratio_hectare")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GreenCoverageRatioPercentage)
                    .HasColumnName("green_coverage_ratio_percentage")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HospitalBedsCount).HasColumnName("hospital_beds_count");

                entity.Property(e => e.HospitalCount).HasColumnName("hospital_count");

                entity.Property(e => e.HotelCount).HasColumnName("hotel_count");

                entity.Property(e => e.InternationalSchoolCount).HasColumnName("international_school_count");

                entity.Property(e => e.K12Count).HasColumnName("K12_count");

                entity.Property(e => e.LibraryCount).HasColumnName("library_count");

                entity.Property(e => e.MuseumCount).HasColumnName("museum_count");

                entity.Property(e => e.RailwayStationCount).HasColumnName("railway_station_count");

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.ScenicSpotCount).HasColumnName("scenic_spot_count");

                entity.Property(e => e.StarbucksCount).HasColumnName("starbucks_count");

                entity.Property(e => e.StoreCount).HasColumnName("store_count");

                entity.Property(e => e.SupermarketCount).HasColumnName("supermarket_count");

                entity.Property(e => e.TheaterCount).HasColumnName("theater_count");

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DdsFFinance>(entity =>
            {
                entity.ToTable("dds_f_finance", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankCount).HasColumnName("bank_count");

                entity.Property(e => e.BankLoanBalance).HasColumnName("bank_loan_balance");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(6);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.FicisalBudget).HasColumnName("ficisal_budget");

                entity.Property(e => e.InsuranceCompanyCount).HasColumnName("insurance_company_count");

                entity.Property(e => e.LocalGovernmentDebt).HasColumnName("local_government_debt");

                entity.Property(e => e.PevcCount).HasColumnName("PEVC_count");

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.SecurityCompanyCount).HasColumnName("security_company_count");

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DdsFGaodeDrivingTime>(entity =>
            {
                entity.ToTable("dds_f_gaode_driving_time", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationName)
                    .IsRequired()
                    .HasColumnName("destination_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationType)
                    .IsRequired()
                    .HasColumnName("destination_type")
                    .HasMaxLength(50);

                entity.Property(e => e.DistanceEstimation).HasColumnName("distance_estimation");

                entity.Property(e => e.DistrictCenterCoords)
                    .IsRequired()
                    .HasColumnName("district_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.DrivingTimeEstimation).HasColumnName("driving_time_estimation");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxiCostEstimation).HasColumnName("taxi_cost_estimation");
            });

            modelBuilder.Entity<DdsFGaodePoiCount>(entity =>
            {
                entity.ToTable("dds_f_gaode_poi_count", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.IndicatorType)
                    .IsRequired()
                    .HasColumnName("indicator_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PoiCount).HasColumnName("poi_count");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DdsFIndustryData>(entity =>
            {
                entity.ToTable("dds_f_industry_data", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.GovernmentFundsSize)
                    .HasColumnName("government_funds_size")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(100);

                entity.Property(e => e.InvestedCompaniesCount)
                    .HasColumnName("invested_companies_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestedCompaniesInvestedAmount)
                    .HasColumnName("invested_companies_invested_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LargeEnterprisesAssets)
                    .HasColumnName("large_enterprises_assets")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LargeEnterprisesCount).HasColumnName("large_enterprises_count");

                entity.Property(e => e.LargeEnterprisesProduction)
                    .HasColumnName("large_enterprises_production")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LargeEnterprisesStaffCount).HasColumnName("large_enterprises_staff_count");

                entity.Property(e => e.ListedCompaniesCount)
                    .HasColumnName("listed_companies_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesEbit)
                    .HasColumnName("listed_companies_ebit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesIncome)
                    .HasColumnName("listed_companies_income")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesMarketValue)
                    .HasColumnName("listed_companies_market_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Market)
                    .HasColumnName("market")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalInvestedCompaniesCount).HasColumnName("national_invested_companies_count");

                entity.Property(e => e.NationalInvestedCompaniesInvestedAmount)
                    .HasColumnName("national_invested_companies_invested_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NationalLargeEnterprisesAssets)
                    .HasColumnName("national_large_enterprises_assets")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NationalUnicornsCount).HasColumnName("national_unicorns_count");

                entity.Property(e => e.NationalUnicornsEstimatedValue)
                    .HasColumnName("national_unicorns_estimated_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);

                entity.Property(e => e.UnicornsCount).HasColumnName("unicorns_count");

                entity.Property(e => e.UnicornsEstimatedValue)
                    .HasColumnName("unicorns_estimated_value")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DdsFInnovationData>(entity =>
            {
                entity.ToTable("dds_f_innovation_data", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.College211985).HasColumnName("college_211_985");

                entity.Property(e => e.DataPeriod)
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.GraduatesAtSchoolCount).HasColumnName("graduates_at_school_count");

                entity.Property(e => e.HighTechEnterprises).HasColumnName("high_tech_enterprises");

                entity.Property(e => e.InventionPatentsPer10kPpl).HasColumnName("invention_patents_per_10k_ppl");

                entity.Property(e => e.ListedCompaniesResearchBudget)
                    .HasColumnName("listed_companies_research_budget")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NationalEnterpriseTechCenters).HasColumnName("national_enterprise_tech_centers");

                entity.Property(e => e.NationalResearchLabs).HasColumnName("national_research_labs");

                entity.Property(e => e.PostdoctoralResearchStation).HasColumnName("postdoctoral_research_station");

                entity.Property(e => e.RegionalLevel)
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TechBasedSme).HasColumnName("tech_based_sme");

                entity.Property(e => e.UndergraduateAndAcademy).HasColumnName("undergraduate_and_academy");

                entity.Property(e => e.UndergraduatesAtSchoolCount).HasColumnName("undergraduates_at_school_count");
            });

            modelBuilder.Entity<DdsFMacroData>(entity =>
            {
                entity.ToTable("dds_f_macro_data", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConsumerGoodsRetailSales)
                    .HasColumnName("consumer_goods_retail_sales")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DataPeriod)
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DevelopmentAreaCount).HasColumnName("development_area_count");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.FixedAssetsInvestment)
                    .HasColumnName("fixed_assets_investment")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gdp)
                    .HasColumnName("gdp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HouesholdPopulation)
                    .HasColumnName("houeshold_population")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImportAndExport)
                    .HasColumnName("import_and_export")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LandSize)
                    .HasColumnName("land_size")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PermenantResidents)
                    .HasColumnName("permenant_residents")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegionalLevel)
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.RegisteredCompanies)
                    .HasColumnName("registered_companies")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DdsFRailwayClass>(entity =>
            {
                entity.ToTable("dds_f_railway_class", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StationClass)
                    .IsRequired()
                    .HasColumnName("station_class")
                    .HasMaxLength(50);

                entity.Property(e => e.StationCount).HasColumnName("station_count");
            });

            modelBuilder.Entity<DdsFTransit>(entity =>
            {
                entity.ToTable("dds_f_transit", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirlineYearlyTakeoffLandingTimes).HasColumnName("airline_yearly_takeoff_landing_times");

                entity.Property(e => e.BusYearlyDepartTimes).HasColumnName("bus_yearly_depart_times");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(6);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.HighwayEntriesCount).HasColumnName("highway_entries_count");

                entity.Property(e => e.LogisticsStationCount).HasColumnName("logistics_station_count");

                entity.Property(e => e.NearestAirport)
                    .HasColumnName("nearest_airport")
                    .HasMaxLength(50);

                entity.Property(e => e.NearestAirportDrivingTime).HasColumnName("nearest_airport_driving_time");

                entity.Property(e => e.NearestRailwayStation)
                    .HasColumnName("nearest_railway_station")
                    .HasMaxLength(50);

                entity.Property(e => e.NearestRailwayStationDrivingTime).HasColumnName("nearest_railway_station_driving_time");

                entity.Property(e => e.RailwayFirstClassCount).HasColumnName("railway_first_class_count");

                entity.Property(e => e.RailwaySecondClassCount).HasColumnName("railway_second_class_count");

                entity.Property(e => e.RailwaySpecialClassCount).HasColumnName("railway_special_class_count");

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);

                entity.Property(e => e.TrainYearlyDepartTimes).HasColumnName("train_yearly_depart_times");
            });

            modelBuilder.Entity<DdsNews>(entity =>
            {
                entity.ToTable("dds_news", "dds");

                entity.HasIndex(e => new { e.Title, e.Category, e.ReleaseTime, e.Content })
                    .HasName("unique_news")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(300);

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasMaxLength(100);

                entity.Property(e => e.IsHot).HasColumnName("is_hot");

                entity.Property(e => e.IsTop).HasColumnName("is_top");

                entity.Property(e => e.IsValid).HasColumnName("is_valid");

                entity.Property(e => e.ReleaseTime)
                    .HasColumnName("release_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasMaxLength(200);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DdsSDataIndicator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dds_s_data_indicator", "dds");

                entity.Property(e => e.AirQuality)
                    .HasColumnName("air_quality")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageCommercialLandArea)
                    .HasColumnName("average_commercial_land_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageCommercialLandPrice)
                    .HasColumnName("average_commercial_land_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageCommercialRentArea)
                    .HasColumnName("average_commercial_rent_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageCommercialRentRate)
                    .HasColumnName("average_commercial_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageIndustrialLandPrice)
                    .HasColumnName("average_industrial_land_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageIndustrialRentRate)
                    .HasColumnName("average_industrial_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvgHousePrice)
                    .HasColumnName("avg_house_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvgRent)
                    .HasColumnName("avg_rent")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankCount)
                    .HasColumnName("bank_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankLoanBalance)
                    .HasColumnName("bank_loan_balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.College211985)
                    .HasColumnName("college_211_985")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsumerGoodsRetailSales)
                    .HasColumnName("consumer_goods_retail_sales")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditSupportsTheRealEconomy)
                    .HasColumnName("credit_supports_the_real_economy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.ExternalTrafficConnection)
                    .HasColumnName("external_traffic_connection")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FicisalBudget)
                    .HasColumnName("ficisal_budget")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FixedAssetsInvestment)
                    .HasColumnName("fixed_assets_investment")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gdp)
                    .HasColumnName("gdp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GdpPerCapitaHouseholdPopulation)
                    .HasColumnName("gdp_per_capita_household_population")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GdpPerCapitaPermenantResident)
                    .HasColumnName("gdp_per_capita_permenant_resident")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GdpPerUnitArea)
                    .HasColumnName("gdp_per_unit_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GdpYoy)
                    .HasColumnName("gdp_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HighTechEnterprises)
                    .HasColumnName("high_tech_enterprises")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HighwayEntriesCount)
                    .HasColumnName("highway_entries_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HospitalCount)
                    .HasColumnName("hospital_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HousePriceIncomeRatio)
                    .HasColumnName("house_price_income_ratio")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HouseholdDensity)
                    .HasColumnName("household_density")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HouseholdPopulation)
                    .HasColumnName("household_population")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HouseholdPopulationYoy)
                    .HasColumnName("household_population_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ImportAndExport)
                    .HasColumnName("import_and_export")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IndustrialAverageCost)
                    .HasColumnName("industrial_average_cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsuranceCompanyCount)
                    .HasColumnName("insurance_company_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InventionPatentsPer10kPpl)
                    .HasColumnName("invention_patents_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LandSize)
                    .HasColumnName("land_size")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LargeEnterprisesAssets)
                    .HasColumnName("large_enterprises_assets")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LargeEnterprisesCount)
                    .HasColumnName("large_enterprises_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LargeEnterprisesProduction)
                    .HasColumnName("large_enterprises_production")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesCount)
                    .HasColumnName("listed_companies_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesEbit)
                    .HasColumnName("listed_companies_ebit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesIncome)
                    .HasColumnName("listed_companies_income")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesResearchBudget)
                    .HasColumnName("listed_companies_research_budget")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ListedCompaniesYoy)
                    .HasColumnName("listed_companies_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LocalGovernmentDebtPressureByFisicalBudget)
                    .HasColumnName("local_government_debt_pressure_by_fisical_budget")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LocalGovernmentDebtPressureByGdp)
                    .HasColumnName("local_government_debt_pressure_by_gdp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LogisticsStationCount)
                    .HasColumnName("logistics_station_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NationalPlatforms)
                    .HasColumnName("national_platforms")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NearestAirportDrivingTime)
                    .HasColumnName("nearest_airport_driving_time")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NearestRailwayStationDrivingTime)
                    .HasColumnName("nearest_railway_station_driving_time")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumberOfBedsPerThousand)
                    .HasColumnName("number_of_beds_per_thousand")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumberOfCinemasPer10kPpl)
                    .HasColumnName("number_of_cinemas_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumberOfCultureFacilitiesPer10kPpl)
                    .HasColumnName("number_of_culture_facilities_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumberOfHotelsPer10kPpl)
                    .HasColumnName("number_of_hotels_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumberOfInternationalSchoolsPer10kPpl)
                    .HasColumnName("number_of_international_schools_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumberOfK12EducationSchoolsPer10kPpl)
                    .HasColumnName("number_of_K12_education_schools_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumberOfSupermarketConvenienceStoresPer10kPpl)
                    .HasColumnName("number_of_supermarket_convenience_stores_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrdinaryLabourCost)
                    .HasColumnName("ordinary_labour_cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PermanentPopulationDensity)
                    .HasColumnName("permanent_population_density")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PermenantResidents)
                    .HasColumnName("permenant_residents")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PermenantResidentsYoy)
                    .HasColumnName("permenant_residents_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PevcCount)
                    .HasColumnName("PEVC_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostdoctoralResearchStation)
                    .HasColumnName("postdoctoral_research_station")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RailwayFirstClassCount)
                    .HasColumnName("railway_first_class_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RailwaySecondClassCount)
                    .HasColumnName("railway_second_class_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RailwaySpecialClassCount)
                    .HasColumnName("railway_special_class_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RailwayStationCount)
                    .HasColumnName("railway_station_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegisteredBusinessDensity)
                    .HasColumnName("registered_business_density")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegisteredCompanies)
                    .HasColumnName("registered_companies")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegisteredCompaniesYoy)
                    .HasColumnName("registered_companies_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RelativeLabourCost)
                    .HasColumnName("relative_labour_cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RentToIncomeRatio)
                    .HasColumnName("rent_to_income_ratio")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScenicSpotCount)
                    .HasColumnName("scenic_spot_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecurityCompanyCount)
                    .HasColumnName("security_company_count")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SnapshotPeriod)
                    .IsRequired()
                    .HasColumnName("snapshot_period")
                    .HasMaxLength(50);

                entity.Property(e => e.StarbucksPer10kPpl)
                    .HasColumnName("starbucks_per_10k_ppl")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TechBasedSme)
                    .HasColumnName("tech_based_sme")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UndergraduateAndAcademy)
                    .HasColumnName("undergraduate_and_academy")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DdsSDataIndicatorFixed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dds_s_data_indicator_fixed", "dds");

                entity.Property(e => e.AirQuality)
                    .HasColumnName("air_quality")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AirlineYearlyTakeoffLandingTimes)
                    .HasColumnName("airline_yearly_takeoff_landing_times")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AverageCommercialLandArea)
                    .HasColumnName("average_commercial_land_area")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageCommercialLandPrice)
                    .HasColumnName("average_commercial_land_price")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageCommercialRentRate)
                    .HasColumnName("average_commercial_rent_rate")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageIndustrialLandPrice)
                    .HasColumnName("average_industrial_land_price")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageIndustrialRentRate)
                    .HasColumnName("average_industrial_rent_rate")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageIndustryCarrierCost)
                    .HasColumnName("average_industry_carrier_cost")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AvgHousePrice)
                    .HasColumnName("avg_house_price")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AvgRent)
                    .HasColumnName("avg_rent")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BankLoanBalance)
                    .HasColumnName("bank_loan_balance")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BankingFinancialInstitutionCount)
                    .HasColumnName("banking_financial_institution_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BankingFinancialInstitutionLegalEntityCount)
                    .HasColumnName("banking_financial_institution_legal_entity_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BondedLogisticsCenterBAmount)
                    .HasColumnName("bonded_logistics_center_B_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.BusYearlyDepartTimes)
                    .HasColumnName("bus_yearly_depart_times")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CinemaCount)
                    .HasColumnName("cinema_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.College211985)
                    .HasColumnName("college_211_985")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ConsumerGoodsRetailSales)
                    .HasColumnName("consumer_goods_retail_sales")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.CreditSupportsTheRealEconomy)
                    .HasColumnName("credit_supports_the_real_economy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.CultureFacilitiesCount)
                    .HasColumnName("culture_facilities_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DirectUseOfForeignCapital)
                    .HasColumnName("direct_use_of_foreign_capital")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DirectUseOfForeignCapitalYoy)
                    .HasColumnName("direct_use_of_foreign_capital_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DisposableIncome)
                    .HasColumnName("disposable_income")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.ExternalTrafficConnection)
                    .HasColumnName("external_traffic_connection")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FinancialCompanyCount)
                    .HasColumnName("financial_company_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FiscalSelfSuppliment)
                    .HasColumnName("fiscal_self_suppliment")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FisicalBudgetExpenditure)
                    .HasColumnName("fisical_budget_expenditure")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FisicalBudgetRevenue)
                    .HasColumnName("fisical_budget_revenue")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FixedAssetsInvestment)
                    .HasColumnName("fixed_assets_investment")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FuturesCompanyLegalEntityCount)
                    .HasColumnName("futures_company_legal_entity_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Gdp)
                    .HasColumnName("gdp")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GdpPerCapitaPermenantResident)
                    .HasColumnName("gdp_per_capita_permenant_resident")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GdpPerUnitArea)
                    .HasColumnName("gdp_per_unit_area")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GdpYoy)
                    .HasColumnName("gdp_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GraduatesAtSchoolCount)
                    .HasColumnName("graduates_at_school_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HighLevelRailwayStationCount)
                    .HasColumnName("high_level_railway_station_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HighTechEnterprises)
                    .HasColumnName("high_tech_enterprises")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HighwayEntriesCount)
                    .HasColumnName("highway_entries_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HospitalBedsCount)
                    .HasColumnName("hospital_beds_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HospitalCount)
                    .HasColumnName("hospital_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HotelCount)
                    .HasColumnName("hotel_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HousePriceIncomeRatio)
                    .HasColumnName("house_price_income_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ImportAndExport)
                    .HasColumnName("import_and_export")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialAverageCost)
                    .HasColumnName("industrial_average_cost")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialElectricityConsumption)
                    .HasColumnName("industrial_electricity_consumption")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialValueAdded)
                    .HasColumnName("industrial_value_added")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialValueAddedYoy)
                    .HasColumnName("industrial_value_added_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustryInvestmentCostEffective)
                    .HasColumnName("industry_investment_cost_effective")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InsuranceInstitutionCount)
                    .HasColumnName("insurance_institution_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InsuranceInstitutionLegalEntityCount)
                    .HasColumnName("insurance_institution_legal_entity_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InternalTrafficConnection)
                    .HasColumnName("internal_traffic_connection")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InternationSchoolCount)
                    .HasColumnName("internation_school_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InventionPatentsPer10kPpl)
                    .HasColumnName("invention_patents_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesCount)
                    .HasColumnName("invested_companies_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesCountRatio)
                    .HasColumnName("invested_companies_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesCountYoy)
                    .HasColumnName("invested_companies_count_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesInvestedAmount)
                    .HasColumnName("invested_companies_invested_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesInvestedAmountRatio)
                    .HasColumnName("invested_companies_invested_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesInvestedAmountYoy)
                    .HasColumnName("invested_companies_invested_amount_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestmentCompanyCount)
                    .HasColumnName("investment_company_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.K12Count)
                    .HasColumnName("K12_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LabourOutputEfficiency)
                    .HasColumnName("labour_output_efficiency")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LandSize)
                    .HasColumnName("land_size")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeCompanyTotalAsset)
                    .HasColumnName("large_company_total_asset")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeEnterprisesStaffCount)
                    .HasColumnName("large_enterprises_staff_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyAverageAsset)
                    .HasColumnName("large_industrial_company_average_asset")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyAverageProduction)
                    .HasColumnName("large_industrial_company_average_production")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyCountYoy)
                    .HasColumnName("large_industrial_company_count_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyProductionPerCapita)
                    .HasColumnName("large_industrial_company_production_per_capita")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyTotalAssetRatio)
                    .HasColumnName("large_industrial_company_total_asset_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyTotalProduction)
                    .HasColumnName("large_industrial_company_total_production")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyTotalProductionYoy)
                    .HasColumnName("large_industrial_company_total_production_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyUnitAreaProduction)
                    .HasColumnName("large_industrial_company_unit_area_production")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyValueAdded)
                    .HasColumnName("large_industrial_company_value_added")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialEnterprisesAssets)
                    .HasColumnName("large_industrial_enterprises_assets")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialEnterprisesCount)
                    .HasColumnName("large_industrial_enterprises_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompaniesResearchBudget)
                    .HasColumnName("listed_companies_research_budget")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompaniesResearchInvest)
                    .HasColumnName("listed_companies_research_invest")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyCount)
                    .HasColumnName("listed_company_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyEbit)
                    .HasColumnName("listed_company_ebit")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyEbitYoy)
                    .HasColumnName("listed_company_ebit_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyIncome)
                    .HasColumnName("listed_company_income")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyIncomeYoy)
                    .HasColumnName("listed_company_income_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyMarketValue)
                    .HasColumnName("listed_company_market_value")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedRate)
                    .HasColumnName("listed_rate")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LocalGovernmentDebt)
                    .HasColumnName("local_government_debt")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LocalGovernmentDebtPressureByGdp)
                    .HasColumnName("local_government_debt_pressure_by_gdp")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LogisticsStationCount)
                    .HasColumnName("logistics_station_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalAdvancedManufacturingIndustryAmount)
                    .HasColumnName("national_advanced_manufacturing_industry_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalEcoDevelopmentZoneAmount)
                    .HasColumnName("national_eco_development_zone_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalEnterpriseTechCenters)
                    .HasColumnName("national_enterprise_tech_centers")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalHighTechIndustrialDevelopmentZoneAmount)
                    .HasColumnName("national_high_tech_industrial_development_zone_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalPlatforms)
                    .HasColumnName("national_platforms")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalResearchLabs)
                    .HasColumnName("national_research_labs")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalTechBusinessIncubatorAmount)
                    .HasColumnName("national_tech_business_incubator_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NewEmployment)
                    .HasColumnName("new_employment")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NewEmploymentRate)
                    .HasColumnName("new_employment_rate")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NewPermenantResidents)
                    .HasColumnName("new_permenant_residents")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfBedsPerThousand)
                    .HasColumnName("number_of_beds_per_thousand")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfCinemasPer10kPpl)
                    .HasColumnName("number_of_cinemas_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfCultureFacilitiesPer10kPpl)
                    .HasColumnName("number_of_culture_facilities_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfHotelsPer10kPpl)
                    .HasColumnName("number_of_hotels_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfInternationalSchoolsPer10kPpl)
                    .HasColumnName("number_of_international_schools_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfK12EducationSchoolsPer10kPpl)
                    .HasColumnName("number_of_K12_education_schools_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfSupermarketConvenienceStoresPer10kPpl)
                    .HasColumnName("number_of_supermarket_convenience_stores_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrdinaryLabourCost)
                    .HasColumnName("ordinary_labour_cost")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrdinaryLabourMonthlyCost)
                    .HasColumnName("ordinary_labour_monthly_cost")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PermanentPopulationDensity)
                    .HasColumnName("permanent_population_density")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PermenantResidents)
                    .HasColumnName("permenant_residents")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PermenantResidentsYoy)
                    .HasColumnName("permenant_residents_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PopulationNetInflow)
                    .HasColumnName("population_net_inflow")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PostdoctoralResearchStation)
                    .HasColumnName("postdoctoral_research_station")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryIndustryValueAdded)
                    .HasColumnName("primary_industry_value_added")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryIndustryValueAddedYoy)
                    .HasColumnName("primary_industry_value_added_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProvincialDevelopmentZoneAmount)
                    .HasColumnName("provincial_development_zone_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PublicFundInstitutionLegalEntityCount)
                    .HasColumnName("public_fund_institution_legal_entity_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RailwayStationCount)
                    .HasColumnName("railway_station_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RailwayStationCountRatio)
                    .HasColumnName("railway_station_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RegisteredBusinessDensity)
                    .HasColumnName("registered_business_density")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RegisteredCompanies)
                    .HasColumnName("registered_companies")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RegisteredCompaniesYoy)
                    .HasColumnName("registered_companies_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RelativeLabourCost)
                    .HasColumnName("relative_labour_cost")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RentToHousePriceRatio)
                    .HasColumnName("rent_to_house_price_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RentToIncomeRatio)
                    .HasColumnName("rent_to_income_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ResidentExpenditurePerCapita)
                    .HasColumnName("resident_expenditure_per_capita")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ScenicSpotCount)
                    .HasColumnName("scenic_spot_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ScenicSpotCountPer100kPpl)
                    .HasColumnName("scenic_spot_count_per_100k_ppl")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SecondaryIndustryValueAdded)
                    .HasColumnName("secondary_industry_value_added")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SecondaryIndustryValueAddedYoy)
                    .HasColumnName("secondary_industry_value_added_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SecurityCompanyLegalEntityCount)
                    .HasColumnName("security_company_legal_entity_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SnapshotPeriod)
                    .IsRequired()
                    .HasColumnName("snapshot_period")
                    .HasMaxLength(50);

                entity.Property(e => e.SolidSmallMediumEnterprisesAmount)
                    .HasColumnName("solid_small_medium_enterprises_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SpecialCustomsControllingZoneAmount)
                    .HasColumnName("special_customs_controlling_zone_amount")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.StarbucksCount)
                    .HasColumnName("starbucks_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StarbucksPer10kPpl)
                    .HasColumnName("starbucks_per_10k_ppl")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SupermarketAndStoreCount)
                    .HasColumnName("supermarket_and_store_count")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TechBasedSme)
                    .HasColumnName("tech_based_sme")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TertiaryIndustryValueAdded)
                    .HasColumnName("tertiary_industry_value_added")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TertiaryIndustryValueAddedYoy)
                    .HasColumnName("tertiary_industry_value_added_yoy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TrainYearlyDepartTimes)
                    .HasColumnName("train_yearly_depart_times")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UndergraduateAndAcademy)
                    .HasColumnName("undergraduate_and_academy")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UndergraduatesAtSchoolCount)
                    .HasColumnName("undergraduates_at_school_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsCount)
                    .HasColumnName("unicorns_count")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsCountRatio)
                    .HasColumnName("unicorns_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsEstimatedValue)
                    .HasColumnName("unicorns_estimated_value")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsEstimatedValueRatio)
                    .HasColumnName("unicorns_estimated_value_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitGdpElectricityConsumption)
                    .HasColumnName("unit_gdp_electricity_consumption")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UrbanResidentExpenditurePerCapita)
                    .HasColumnName("urban_resident_expenditure_per_capita")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UrbanResidentsDisposableIncome)
                    .HasColumnName("urban_residents_disposable_income")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WholeSocietyElectricityConsumption)
                    .HasColumnName("whole_society_electricity_consumption")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.WholeSocietyElectricityConsumptionYoy)
                    .HasColumnName("whole_society_electricity_consumption_yoy")
                    .HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<DdsSDataIndicatorRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dds_s_data_indicator_rank", "dds");

                entity.Property(e => e.AirQualityRatio)
                    .HasColumnName("air_quality_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AirlineYearlyTakeoffLandingTimesRatio)
                    .HasColumnName("airline_yearly_takeoff_landing_times_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AverageCommercialLandAreaRatio)
                    .HasColumnName("average_commercial_land_area_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageCommercialLandPriceRatio)
                    .HasColumnName("average_commercial_land_price_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageCommercialRentRateRatio)
                    .HasColumnName("average_commercial_rent_rate_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageIndustrialLandPriceRatio)
                    .HasColumnName("average_industrial_land_price_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageIndustrialRentRateRatio)
                    .HasColumnName("average_industrial_rent_rate_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AverageIndustryCarrierCostRatio)
                    .HasColumnName("average_industry_carrier_cost_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.AvgHousePriceRatio)
                    .HasColumnName("avg_house_price_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AvgRentRatio)
                    .HasColumnName("avg_rent_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BankLoanBalanceRatio)
                    .HasColumnName("bank_loan_balance_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BankingFinancialInstitutionCountRatio)
                    .HasColumnName("banking_financial_institution_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BankingFinancialInstitutionLegalEntityCountRatio)
                    .HasColumnName("banking_financial_institution_legal_entity_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BondedLogisticsCenterBAmountRatio)
                    .HasColumnName("bonded_logistics_center_B_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.BusYearlyDepartTimesRatio)
                    .HasColumnName("bus_yearly_depart_times_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CinemaCountRatio)
                    .HasColumnName("cinema_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.College211985Ratio)
                    .HasColumnName("college_211_985_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ConsumerGoodsRetailSalesRatio)
                    .HasColumnName("consumer_goods_retail_sales_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.CreditSupportsTheRealEconomyRatio)
                    .HasColumnName("credit_supports_the_real_economy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.CultureFacilitiesCountRatio)
                    .HasColumnName("culture_facilities_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DirectUseOfForeignCapitalRatio)
                    .HasColumnName("direct_use_of_foreign_capital_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DirectUseOfForeignCapitalYoyRatio)
                    .HasColumnName("direct_use_of_foreign_capital_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DisposableIncomeRatio)
                    .HasColumnName("disposable_income_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.ExternalTrafficConnectionRatio)
                    .HasColumnName("external_traffic_connection_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FinancialCompanyCountRatio)
                    .HasColumnName("financial_company_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FiscalSelfSupplimentRatio)
                    .HasColumnName("fiscal_self_suppliment_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FisicalBudgetExpenditureRatio)
                    .HasColumnName("fisical_budget_expenditure_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FisicalBudgetRevenueRatio)
                    .HasColumnName("fisical_budget_revenue_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FixedAssetsInvestmentRatio)
                    .HasColumnName("fixed_assets_investment_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.FuturesCompanyLegalEntityCountRatio)
                    .HasColumnName("futures_company_legal_entity_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GdpPerCapitaPermenantResidentRatio)
                    .HasColumnName("gdp_per_capita_permenant_resident_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GdpPerUnitAreaRatio)
                    .HasColumnName("gdp_per_unit_area_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GdpRatio)
                    .HasColumnName("gdp_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GdpYoyRatio)
                    .HasColumnName("gdp_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.GraduatesAtSchoolCountRatio)
                    .HasColumnName("graduates_at_school_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HighLevelRailwayStationCountRatio)
                    .HasColumnName("high_level_railway_station_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HighTechEnterprisesRatio)
                    .HasColumnName("high_tech_enterprises_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HighwayEntriesCountRatio)
                    .HasColumnName("highway_entries_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HospitalBedsCountRatio)
                    .HasColumnName("hospital_beds_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HospitalCountRatio)
                    .HasColumnName("hospital_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.HotelCountRatio)
                    .HasColumnName("hotel_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HousePriceIncomeRatioRatio)
                    .HasColumnName("house_price_income_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ImportAndExportRatio)
                    .HasColumnName("import_and_export_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialAverageCostRatio)
                    .HasColumnName("industrial_average_cost_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialElectricityConsumptionRatio)
                    .HasColumnName("industrial_electricity_consumption_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialValueAddedRatio)
                    .HasColumnName("industrial_value_added_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustrialValueAddedYoyRatio)
                    .HasColumnName("industrial_value_added_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.IndustryInvestmentCostEffectiveRatio)
                    .HasColumnName("industry_investment_cost_effective_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InsuranceInstitutionCountRatio)
                    .HasColumnName("insurance_institution_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InsuranceInstitutionLegalEntityCountRatio)
                    .HasColumnName("insurance_institution_legal_entity_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InternalTrafficConnectionRatio)
                    .HasColumnName("internal_traffic_connection_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InternationSchoolCountRatio)
                    .HasColumnName("internation_school_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InventionPatentsPer10kPplRatio)
                    .HasColumnName("invention_patents_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesCountRatio)
                    .HasColumnName("invested_companies_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesCountRatioRatio)
                    .HasColumnName("invested_companies_count_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesCountYoyRatio)
                    .HasColumnName("invested_companies_count_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesInvestedAmountRatio)
                    .HasColumnName("invested_companies_invested_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesInvestedAmountRatioRatio)
                    .HasColumnName("invested_companies_invested_amount_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestedCompaniesInvestedAmountYoyRatio)
                    .HasColumnName("invested_companies_invested_amount_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.InvestmentCompanyCountRatio)
                    .HasColumnName("investment_company_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.K12CountRatio)
                    .HasColumnName("K12_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LabourOutputEfficiencyRatio)
                    .HasColumnName("labour_output_efficiency_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LandSizeRatio)
                    .HasColumnName("land_size_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeCompanyTotalAssetRatio)
                    .HasColumnName("large_company_total_asset_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeEnterprisesStaffCountRatio)
                    .HasColumnName("large_enterprises_staff_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyAverageAssetRatio)
                    .HasColumnName("large_industrial_company_average_asset_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyAverageProductionRatio)
                    .HasColumnName("large_industrial_company_average_production_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyCountYoyRatio)
                    .HasColumnName("large_industrial_company_count_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyProductionPerCapitaRatio)
                    .HasColumnName("large_industrial_company_production_per_capita_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyTotalAssetRatioRatio)
                    .HasColumnName("large_industrial_company_total_asset_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyTotalProductionRatio)
                    .HasColumnName("large_industrial_company_total_production_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyTotalProductionYoyRatio)
                    .HasColumnName("large_industrial_company_total_production_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyUnitAreaProductionRatio)
                    .HasColumnName("large_industrial_company_unit_area_production_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialCompanyValueAddedRatio)
                    .HasColumnName("large_industrial_company_value_added_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialEnterprisesAssetsRatio)
                    .HasColumnName("large_industrial_enterprises_assets_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LargeIndustrialEnterprisesCountRatio)
                    .HasColumnName("large_industrial_enterprises_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompaniesResearchBudgetRatio)
                    .HasColumnName("listed_companies_research_budget_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompaniesResearchInvestRatio)
                    .HasColumnName("listed_companies_research_invest_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyCountRatio)
                    .HasColumnName("listed_company_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyEbitRatio)
                    .HasColumnName("listed_company_ebit_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyEbitYoyRatio)
                    .HasColumnName("listed_company_ebit_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyIncomeRatio)
                    .HasColumnName("listed_company_income_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyIncomeYoyRatio)
                    .HasColumnName("listed_company_income_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedCompanyMarketValueRatio)
                    .HasColumnName("listed_company_market_value_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ListedRateRatio)
                    .HasColumnName("listed_rate_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LocalGovernmentDebtPressureByGdpRatio)
                    .HasColumnName("local_government_debt_pressure_by_gdp_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.LocalGovernmentDebtRatio)
                    .HasColumnName("local_government_debt_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LogisticsStationCountRatio)
                    .HasColumnName("logistics_station_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalAdvancedManufacturingIndustryAmountRatio)
                    .HasColumnName("national_advanced_manufacturing_industry_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalEcoDevelopmentZoneAmountRatio)
                    .HasColumnName("national_eco_development_zone_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalEnterpriseTechCentersRatio)
                    .HasColumnName("national_enterprise_tech_centers_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalHighTechIndustrialDevelopmentZoneAmountRatio)
                    .HasColumnName("national_high_tech_industrial_development_zone_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalPlatformsRatio)
                    .HasColumnName("national_platforms_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalResearchLabsRatio)
                    .HasColumnName("national_research_labs_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NationalTechBusinessIncubatorAmountRatio)
                    .HasColumnName("national_tech_business_incubator_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NewEmploymentRateRatio)
                    .HasColumnName("new_employment_rate_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NewEmploymentRatio)
                    .HasColumnName("new_employment_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NewPermenantResidentsRatio)
                    .HasColumnName("new_permenant_residents_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfBedsPerThousandRatio)
                    .HasColumnName("number_of_beds_per_thousand_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfCinemasPer10kPplRatio)
                    .HasColumnName("number_of_cinemas_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfCultureFacilitiesPer10kPplRatio)
                    .HasColumnName("number_of_culture_facilities_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfHotelsPer10kPplRatio)
                    .HasColumnName("number_of_hotels_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfInternationalSchoolsPer10kPplRatio)
                    .HasColumnName("number_of_international_schools_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfK12EducationSchoolsPer10kPplRatio)
                    .HasColumnName("number_of_K12_education_schools_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.NumberOfSupermarketConvenienceStoresPer10kPplRatio)
                    .HasColumnName("number_of_supermarket_convenience_stores_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.OrdinaryLabourCostRatio)
                    .HasColumnName("ordinary_labour_cost_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PermanentPopulationDensityRatio)
                    .HasColumnName("permanent_population_density_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PermenantResidentsRatio)
                    .HasColumnName("permenant_residents_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PermenantResidentsYoyRatio)
                    .HasColumnName("permenant_residents_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PopulationNetInflowRatio)
                    .HasColumnName("population_net_inflow_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PostdoctoralResearchStationRatio)
                    .HasColumnName("postdoctoral_research_station_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryIndustryValueAddedRatio)
                    .HasColumnName("primary_industry_value_added_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PrimaryIndustryValueAddedYoyRatio)
                    .HasColumnName("primary_industry_value_added_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProvincialDevelopmentZoneAmountRatio)
                    .HasColumnName("provincial_development_zone_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.PublicFundInstitutionLegalEntityCountRatio)
                    .HasColumnName("public_fund_institution_legal_entity_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RailwayStationCountRatio)
                    .HasColumnName("railway_station_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RailwayStationCountRatioRatio)
                    .HasColumnName("railway_station_count_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RegisteredBusinessDensityRatio)
                    .HasColumnName("registered_business_density_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RegisteredCompaniesRatio)
                    .HasColumnName("registered_companies_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RegisteredCompaniesYoyRatio)
                    .HasColumnName("registered_companies_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RelativeLabourCostRatio)
                    .HasColumnName("relative_labour_cost_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RentToHousePriceRatioRatio)
                    .HasColumnName("rent_to_house_price_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RentToIncomeRatioRatio)
                    .HasColumnName("rent_to_income_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ResidentExpenditurePerCapitaRatio)
                    .HasColumnName("resident_expenditure_per_capita_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ScenicSpotCountPer100kPplRatio)
                    .HasColumnName("scenic_spot_count_per_100k_ppl_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ScenicSpotCountRatio)
                    .HasColumnName("scenic_spot_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SecondaryIndustryValueAddedRatio)
                    .HasColumnName("secondary_industry_value_added_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SecondaryIndustryValueAddedYoyRatio)
                    .HasColumnName("secondary_industry_value_added_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SecurityCompanyLegalEntityCountRatio)
                    .HasColumnName("security_company_legal_entity_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SnapshotPeriod)
                    .IsRequired()
                    .HasColumnName("snapshot_period")
                    .HasMaxLength(50);

                entity.Property(e => e.SolidSmallMediumEnterprisesAmountRatio)
                    .HasColumnName("solid_small_medium_enterprises_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SpecialCustomsControllingZoneAmountRatio)
                    .HasColumnName("special_customs_controlling_zone_amount_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.StarbucksCountRatio)
                    .HasColumnName("starbucks_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StarbucksPer10kPplRatio)
                    .HasColumnName("starbucks_per_10k_ppl_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SupermarketAndStoreCountRatio)
                    .HasColumnName("supermarket_and_store_count_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TechBasedSmeRatio)
                    .HasColumnName("tech_based_sme_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TertiaryIndustryValueAddedRatio)
                    .HasColumnName("tertiary_industry_value_added_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TertiaryIndustryValueAddedYoyRatio)
                    .HasColumnName("tertiary_industry_value_added_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.TrainYearlyDepartTimesRatio)
                    .HasColumnName("train_yearly_depart_times_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UndergraduateAndAcademyRatio)
                    .HasColumnName("undergraduate_and_academy_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UndergraduatesAtSchoolCountRatio)
                    .HasColumnName("undergraduates_at_school_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsCountRatio)
                    .HasColumnName("unicorns_count_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsCountRatioRatio)
                    .HasColumnName("unicorns_count_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsEstimatedValueRatio)
                    .HasColumnName("unicorns_estimated_value_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnicornsEstimatedValueRatioRatio)
                    .HasColumnName("unicorns_estimated_value_ratio_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UnitGdpElectricityConsumptionRatio)
                    .HasColumnName("unit_gdp_electricity_consumption_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.UrbanResidentExpenditurePerCapitaRatio)
                    .HasColumnName("urban_resident_expenditure_per_capita_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UrbanResidentsDisposableIncomeRatio)
                    .HasColumnName("urban_residents_disposable_income_ratio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WholeSocietyElectricityConsumptionRatio)
                    .HasColumnName("whole_society_electricity_consumption_ratio")
                    .HasColumnType("decimal(18, 8)");

                entity.Property(e => e.WholeSocietyElectricityConsumptionYoyRatio)
                    .HasColumnName("whole_society_electricity_consumption_yoy_ratio")
                    .HasColumnType("decimal(18, 8)");
            });

            modelBuilder.Entity<DdsSIndexSystem>(entity =>
            {
                entity.ToTable("dds_s_index_system", "dds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.RegionalCompetitiveness)
                    .HasColumnName("regional_competitiveness")
                    .HasColumnType("decimal(30, 10)");

                entity.Property(e => e.SnapshotPeriod)
                    .IsRequired()
                    .HasColumnName("snapshot_period")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<DevelopmentDistrict>(entity =>
            {
                entity.ToTable("development_district");

                entity.HasComment("??????");

                entity.Property(e => e.Id).HasComment("ID");

                entity.Property(e => e.Coords)
                    .IsRequired()
                    .HasColumnName("coords")
                    .HasMaxLength(1024)
                    .HasComment("??");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(3072)
                    .HasComment("?????");

                entity.Property(e => e.DistrictSk)
                    .HasColumnName("district_sk")
                    .HasComment("??????");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(1024)
                    .HasComment("?????");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1024)
                    .HasComment("?????");

                entity.HasOne(d => d.DistrictSkNavigation)
                    .WithMany(p => p.DevelopmentDistrict)
                    .HasForeignKey(d => d.DistrictSk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dd_dd_sk");
            });

            modelBuilder.Entity<DsaAirportsThroughput>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_airports_throughput", "dsa");

                entity.Property(e => e.AirportName)
                    .HasColumnName("airport_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CargoThroughput).HasColumnName("cargo_throughput");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PassengerThroughput).HasColumnName("passenger_throughput");

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TakeoffLanding).HasColumnName("takeoff_landing");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<DsaAnjukeResidentialPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_anjuke_residential_price", "dsa");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Fangjia).HasColumnName("fangjia");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<DsaAnjukeResidentialRent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_anjuke_residential_rent", "dsa");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2);

                entity.Property(e => e.NoOfRooms)
                    .HasColumnName("no_of_rooms")
                    .HasMaxLength(10);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Rent).HasColumnName("rent");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<DsaDistricts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_districts", "dsa");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(500);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(500);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.Prov)
                    .HasColumnName("prov")
                    .HasMaxLength(500);

                entity.Property(e => e.RankOfCities).HasColumnName("rank_of_cities");

                entity.Property(e => e.RankOfDistricts).HasColumnName("rank_of_districts");

                entity.Property(e => e.RankOfProvinces).HasColumnName("rank_of_provinces");
            });

            modelBuilder.Entity<DsaDrivingTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_driving_time", "dsa");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationAddress)
                    .IsRequired()
                    .HasColumnName("destination_address")
                    .HasMaxLength(100);

                entity.Property(e => e.DestinationCoords)
                    .IsRequired()
                    .HasColumnName("destination_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationName)
                    .IsRequired()
                    .HasColumnName("destination_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationType)
                    .IsRequired()
                    .HasColumnName("destination_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.DistrictCenterCoords)
                    .IsRequired()
                    .HasColumnName("district_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DrivingTimeMinutes).HasColumnName("driving_time_minutes");

                entity.Property(e => e.DrivingTimeSeconds).HasColumnName("driving_time_seconds");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxiCost).HasColumnName("taxi_cost");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DsaGanjiIndustrialRent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_ganji_industrial_rent", "dsa");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaUnit)
                    .HasColumnName("area_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessArea)
                    .HasColumnName("business_area")
                    .HasMaxLength(50);

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DayRentRate)
                    .HasColumnName("day_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthRentRate)
                    .HasColumnName("month_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DsaGdcGeneralData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_gdc_general_data", "dsa");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DsaGdcIndustryData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_gdc_industry_data", "dsa");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(100);

                entity.Property(e => e.Market)
                    .HasColumnName("market")
                    .HasMaxLength(100);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DsaGdcInvestedCompanies>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_gdc_invested_companies", "dsa");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(100);

                entity.Property(e => e.InvestedCompanyKey).HasColumnName("invested_company_key");

                entity.Property(e => e.InvestedCompanyName)
                    .HasColumnName("invested_company_name")
                    .HasMaxLength(200);

                entity.Property(e => e.InvestedMonth)
                    .HasColumnName("invested_month")
                    .HasMaxLength(6);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalInvestedAmount)
                    .HasColumnName("total_invested_amount")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DsaHospitalBeds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_hospital_beds", "dsa");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataStatus)
                    .HasColumnName("data_status")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.HospitalClass)
                    .HasColumnName("hospital_class")
                    .HasMaxLength(50);

                entity.Property(e => e.HospitalCode)
                    .HasColumnName("hospital_code")
                    .HasMaxLength(50);

                entity.Property(e => e.HospitalName)
                    .HasColumnName("hospital_name")
                    .HasMaxLength(100);

                entity.Property(e => e.NoOfBeds)
                    .HasColumnName("no_of_beds")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceUrl)
                    .HasColumnName("reference_url")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DsaIfindLandSales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_ifind_land_sales", "dsa");

                entity.Property(e => e.BidEndTime)
                    .HasColumnName("bid_end_time")
                    .HasMaxLength(100);

                entity.Property(e => e.BidFinalPrice)
                    .HasColumnName("bid_final_price")
                    .HasMaxLength(100);

                entity.Property(e => e.BidStartPrice)
                    .HasColumnName("bid_start_price")
                    .HasMaxLength(100);

                entity.Property(e => e.BidStatus)
                    .HasColumnName("bid_status")
                    .HasMaxLength(100);

                entity.Property(e => e.BuildingArea)
                    .HasColumnName("building_area")
                    .HasMaxLength(100);

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ConstructionArea)
                    .HasColumnName("construction_area")
                    .HasMaxLength(100);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.LandAddress)
                    .HasColumnName("land_address")
                    .HasMaxLength(200);

                entity.Property(e => e.LandName)
                    .HasColumnName("land_name")
                    .HasMaxLength(200);

                entity.Property(e => e.PlannedUsage)
                    .HasColumnName("planned_usage")
                    .HasMaxLength(200);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesType)
                    .HasColumnName("sales_type")
                    .HasMaxLength(100);

                entity.Property(e => e.TotalLandArea)
                    .HasColumnName("total_land_area")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DsaIndustrialPark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_industrial_park", "dsa");

                entity.Property(e => e.ApprovalDate).HasColumnName("approval_date");

                entity.Property(e => e.ApprovedArea).HasColumnName("approved_area");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LeadingIndustry)
                    .HasColumnName("leading_industry")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZoneLevel)
                    .HasColumnName("zone_level")
                    .HasMaxLength(255);

                entity.Property(e => e.ZoneName)
                    .HasColumnName("zone_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ZoneType)
                    .HasColumnName("zone_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DsaIndustryChains>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_industry_chains", "dsa");

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(255);

                entity.Property(e => e.IndustryChainDesc)
                    .HasColumnName("industry_chain_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.IndustryChainName)
                    .HasColumnName("industry_chain_name")
                    .HasMaxLength(255);

                entity.Property(e => e.IndustryChainPosition)
                    .HasColumnName("industry_chain_position")
                    .HasMaxLength(255);

                entity.Property(e => e.InvestedEnterpriseCount).HasColumnName("invested_enterprise_count");

                entity.Property(e => e.ListedEnterpriseCount).HasColumnName("listed_enterprise_count");

                entity.Property(e => e.MainEnterprise1)
                    .HasColumnName("main_enterprise_1")
                    .HasMaxLength(255);

                entity.Property(e => e.MainEnterprise2)
                    .HasColumnName("main_enterprise_2")
                    .HasMaxLength(255);

                entity.Property(e => e.MainEnterprise3)
                    .HasColumnName("main_enterprise_3")
                    .HasMaxLength(255);

                entity.Property(e => e.MainEnterpriseCount).HasColumnName("main_enterprise_count");
            });

            modelBuilder.Entity<DsaIndustryFieldTag>(entity =>
            {
                entity.ToTable("dsa_industry_field_tag", "dsa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderNum).HasColumnName("order_num");
            });

            modelBuilder.Entity<DsaIndustryLand>(entity =>
            {
                entity.ToTable("dsa_industry_land", "dsa");

                entity.HasIndex(e => new { e.BuyerName, e.DistrictSk, e.BuyerIndustrySecondaryClassKey, e.LandPrice, e.LandTotalArea, e.LandClosingTime })
                    .HasName("land_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuyerBusiness).HasColumnName("buyer_business");

                entity.Property(e => e.BuyerCity)
                    .HasColumnName("buyer_city")
                    .HasMaxLength(100);

                entity.Property(e => e.BuyerDistrict)
                    .HasColumnName("buyer_district")
                    .HasMaxLength(100);

                entity.Property(e => e.BuyerIndustryPrimaryClassKey)
                    .IsRequired()
                    .HasColumnName("buyer_industry_primary_class_key")
                    .HasMaxLength(100);

                entity.Property(e => e.BuyerIndustrySecondaryClassKey)
                    .IsRequired()
                    .HasColumnName("buyer_industry_secondary_class_key")
                    .HasMaxLength(100);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasColumnName("buyer_name")
                    .HasMaxLength(200);

                entity.Property(e => e.CitySk).HasColumnName("city_sk");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.LandClosingTime)
                    .HasColumnName("land_closing_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LandFloorPrice)
                    .HasColumnName("land_floor_price")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LandIndex)
                    .HasColumnName("land_index")
                    .HasMaxLength(100);

                entity.Property(e => e.LandLocation)
                    .HasColumnName("land_location")
                    .HasMaxLength(100);

                entity.Property(e => e.LandName)
                    .HasColumnName("land_name")
                    .HasMaxLength(200);

                entity.Property(e => e.LandPlanningArea)
                    .HasColumnName("land_planning_area")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LandPrice)
                    .HasColumnName("land_price")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LandTotalArea)
                    .HasColumnName("land_total_area")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LandUnitPrice)
                    .HasColumnName("land_unit_price")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LandUse)
                    .HasColumnName("land_use")
                    .HasMaxLength(100);

                entity.Property(e => e.ProvinceSk).HasColumnName("province_sk");
            });

            modelBuilder.Entity<DsaInvestedProjects>(entity =>
            {
                entity.ToTable("dsa_invested_projects", "dsa");

                entity.HasIndex(e => new { e.InvestCompany, e.ProjectName, e.InvestDate, e.InvestAmount10k })
                    .HasName("project_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CitySk).HasColumnName("city_sk");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.IndustryPrimaryClassKey)
                    .IsRequired()
                    .HasColumnName("industry_primary_class_key")
                    .HasMaxLength(100);

                entity.Property(e => e.IndustrySecondaryClassKey)
                    .IsRequired()
                    .HasColumnName("industry_secondary_class_key")
                    .HasMaxLength(100);

                entity.Property(e => e.InvestAmount10k)
                    .HasColumnName("invest_amount_10k")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvestCompany)
                    .HasColumnName("invest_company")
                    .HasMaxLength(100);

                entity.Property(e => e.InvestDate)
                    .HasColumnName("invest_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LandSize)
                    .HasColumnName("land_size")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.ProjectAnnualProduction10k)
                    .HasColumnName("project_annual_production_10k")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectAnnualTax10k)
                    .HasColumnName("project_annual_tax_10k")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectCapacity).HasColumnName("project_capacity");

                entity.Property(e => e.ProjectContent).HasColumnName("project_content");

                entity.Property(e => e.ProjectLocation)
                    .HasColumnName("project_location")
                    .HasMaxLength(100);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(500);

                entity.Property(e => e.ProvinceSk).HasColumnName("province_sk");
            });

            modelBuilder.Entity<DsaLianjiaCommercialRent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_lianjia_commercial_rent", "dsa");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BizcircleName)
                    .HasColumnName("bizcircle_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingId)
                    .HasColumnName("building_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Fitment)
                    .HasColumnName("fitment")
                    .HasMaxLength(50);

                entity.Property(e => e.FloorPosition)
                    .HasColumnName("floor_position")
                    .HasMaxLength(50);

                entity.Property(e => e.Furniture)
                    .HasColumnName("furniture")
                    .HasMaxLength(50);

                entity.Property(e => e.HasMeetingRoom)
                    .HasColumnName("has_meeting_room")
                    .HasMaxLength(50);

                entity.Property(e => e.HouseCode)
                    .HasColumnName("house_code")
                    .HasMaxLength(50);

                entity.Property(e => e.HousedelCode)
                    .HasColumnName("housedel_code")
                    .HasMaxLength(50);

                entity.Property(e => e.IsNearSubway)
                    .HasColumnName("is_near_subway")
                    .HasMaxLength(50);

                entity.Property(e => e.IsRegistered)
                    .HasColumnName("is_registered")
                    .HasMaxLength(50);

                entity.Property(e => e.PriceRange)
                    .HasColumnName("price_range")
                    .HasMaxLength(100);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RentPrice)
                    .HasColumnName("rent_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ResblockName)
                    .HasColumnName("resblock_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ResultCount).HasColumnName("result_count");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StreetName)
                    .HasColumnName("street_name")
                    .HasMaxLength(200);

                entity.Property(e => e.SubwayDistance)
                    .HasColumnName("subway_distance")
                    .HasMaxLength(200);

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasMaxLength(200);

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnitMonthRentPrice)
                    .HasColumnName("unit_month_rent_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitRentPrice)
                    .HasColumnName("unit_rent_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DsaListedCompanies>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_listed_companies", "dsa");

                entity.Property(e => e.CitySk).HasColumnName("city_sk");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(500);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LaunchDate)
                    .HasColumnName("launch_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(500);

                entity.Property(e => e.MarketValue)
                    .HasColumnName("market_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarketValueYoy)
                    .HasColumnName("market_value_yoy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.NetProfit)
                    .HasColumnName("net_profit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetProfitYoy)
                    .HasColumnName("net_profit_yoy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrimaryIndustryKey).HasColumnName("primary_industry_key");

                entity.Property(e => e.PrimaryProducts)
                    .HasColumnName("primary_products")
                    .HasMaxLength(500);

                entity.Property(e => e.ProvinceSk).HasColumnName("province_sk");

                entity.Property(e => e.Revenue)
                    .HasColumnName("revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenueYoy)
                    .HasColumnName("revenue_yoy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RndCost)
                    .HasColumnName("rnd_cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RndCostYoy)
                    .HasColumnName("rnd_cost_yoy")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondaryIndustryKey).HasColumnName("secondary_industry_key");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxYoy)
                    .HasColumnName("tax_yoy")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DsaListedCompanyInvestment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_listed_company_investment", "dsa");

                entity.Property(e => e.CompanyCode)
                    .HasColumnName("company_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IndustrialPark)
                    .HasColumnName("industrial_park")
                    .HasMaxLength(255);

                entity.Property(e => e.InvestAmount100m).HasColumnName("invest_amount_100m");

                entity.Property(e => e.InvestAmount10k).HasColumnName("invest_amount_10k");

                entity.Property(e => e.InvestCompany)
                    .HasColumnName("invest_company")
                    .HasMaxLength(255);

                entity.Property(e => e.InvestDate)
                    .HasColumnName("invest_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LandSize)
                    .HasColumnName("land_size")
                    .HasMaxLength(255);

                entity.Property(e => e.Market)
                    .HasColumnName("market")
                    .HasMaxLength(255);

                entity.Property(e => e.NationalIndustriesClass)
                    .HasColumnName("national_industries_class")
                    .HasMaxLength(255);

                entity.Property(e => e.NationalIndustriesClassLevel)
                    .HasColumnName("national_industries_class_level")
                    .HasMaxLength(255);

                entity.Property(e => e.NationalIndustriesSecondaryClass)
                    .HasColumnName("national_industries_secondary_class")
                    .HasMaxLength(255);

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.ProjectAnnualTax)
                    .HasColumnName("project_annual_tax")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectCapacity)
                    .HasColumnName("project_capacity")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectCity)
                    .HasColumnName("project_city")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectContent).HasColumnName("project_content");

                entity.Property(e => e.ProjectDistrict)
                    .HasColumnName("project_district")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectProduction).HasColumnName("project_production");

                entity.Property(e => e.ProjectProv)
                    .HasColumnName("project_prov")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectType)
                    .HasColumnName("project_type")
                    .HasMaxLength(255);

                entity.Property(e => e.WindCategoryLevel1)
                    .HasColumnName("wind_category_level_1")
                    .HasMaxLength(255);

                entity.Property(e => e.WindCategoryLevel2)
                    .HasColumnName("wind_category_level_2")
                    .HasMaxLength(255);

                entity.Property(e => e.WindCategoryLevel3)
                    .HasColumnName("wind_category_level_3")
                    .HasMaxLength(255);

                entity.Property(e => e.WindCategoryLevel4)
                    .HasColumnName("wind_category_level_4")
                    .HasMaxLength(255);

                entity.Property(e => e.WindCategoryLevelLeaf)
                    .HasColumnName("wind_category_level_leaf")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DsaMainIndustryConfiguration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_main_industry_configuration", "dsa");

                entity.Property(e => e.MainIndustry).HasMaxLength(1000);

                entity.Property(e => e.ParkIndustryDesc).HasMaxLength(1000);
            });

            modelBuilder.Entity<DsaParkGov>(entity =>
            {
                entity.ToTable("dsa_park_gov", "dsa");

                entity.Property(e => e.City).HasMaxLength(1000);

                entity.Property(e => e.CityFullName).HasMaxLength(1000);

                entity.Property(e => e.CityLevel).HasMaxLength(1000);

                entity.Property(e => e.District).HasMaxLength(1000);

                entity.Property(e => e.DistrictFullName).HasMaxLength(1000);

                entity.Property(e => e.Prov).HasMaxLength(1000);
            });

            modelBuilder.Entity<DsaParkGovBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_park_gov_bak", "dsa");

                entity.Property(e => e.City).HasMaxLength(1000);

                entity.Property(e => e.CityFullName).HasMaxLength(1000);

                entity.Property(e => e.CityLevel).HasMaxLength(1000);

                entity.Property(e => e.District).HasMaxLength(1000);

                entity.Property(e => e.DistrictFullName).HasMaxLength(1000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Prov).HasMaxLength(1000);
            });

            modelBuilder.Entity<DsaParkGovWebsite>(entity =>
            {
                entity.ToTable("dsa_park_gov_website", "dsa");

                entity.Property(e => e.GovName).HasMaxLength(1000);

                entity.Property(e => e.Website).HasMaxLength(2000);

                entity.HasOne(d => d.Gov)
                    .WithMany(p => p.DsaParkGovWebsite)
                    .HasForeignKey(d => d.GovId)
                    .HasConstraintName("FK__dsa_park___GovId__116138B1");
            });

            modelBuilder.Entity<DsaParkGovWebsiteBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_park_gov_website_bak", "dsa");

                entity.Property(e => e.GovName).HasMaxLength(1000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Website).HasMaxLength(2000);
            });

            modelBuilder.Entity<DsaParkInfo>(entity =>
            {
                entity.ToTable("dsa_park_info", "dsa");

                entity.Property(e => e.City).HasMaxLength(1000);

                entity.Property(e => e.Prov).HasMaxLength(1000);

                entity.Property(e => e.ZoneClass).HasMaxLength(1000);

                entity.Property(e => e.ZoneName).HasMaxLength(1000);

                entity.Property(e => e.ZoneType).HasMaxLength(1000);
            });

            modelBuilder.Entity<DsaParkInfoBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_park_info_bak", "dsa");

                entity.Property(e => e.City).HasMaxLength(1000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Prov).HasMaxLength(1000);

                entity.Property(e => e.ZoneClass).HasMaxLength(1000);

                entity.Property(e => e.ZoneName).HasMaxLength(1000);

                entity.Property(e => e.ZoneType).HasMaxLength(1000);
            });

            modelBuilder.Entity<DsaParkMainIndustry>(entity =>
            {
                entity.ToTable("dsa_park_main_industry", "dsa");

                entity.Property(e => e.MainIndustry).HasMaxLength(1000);

                entity.HasOne(d => d.Park)
                    .WithMany(p => p.DsaParkMainIndustry)
                    .HasForeignKey(d => d.ParkId)
                    .HasConstraintName("FK__dsa_park___ParkI__1625EDCE");
            });

            modelBuilder.Entity<DsaParkMainIndustryBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_park_main_industry_bak", "dsa");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MainIndustry).HasMaxLength(1000);
            });

            modelBuilder.Entity<DsaParkWebsites>(entity =>
            {
                entity.ToTable("dsa_park_websites", "dsa");

                entity.Property(e => e.GovName).HasMaxLength(1000);

                entity.Property(e => e.Website).HasMaxLength(2000);

                entity.HasOne(d => d.Park)
                    .WithMany(p => p.DsaParkWebsites)
                    .HasForeignKey(d => d.ParkId)
                    .HasConstraintName("FK__dsa_park___ParkI__19025A79");
            });

            modelBuilder.Entity<DsaParkWebsitesBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_park_websites_bak", "dsa");

                entity.Property(e => e.GovName).HasMaxLength(1000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Website).HasMaxLength(2000);
            });

            modelBuilder.Entity<DsaPolicyFiles>(entity =>
            {
                entity.ToTable("dsa_policy_files", "dsa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(100);

                entity.Property(e => e.ExpireTime)
                    .HasColumnName("expire_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fields).HasColumnName("fields");

                entity.Property(e => e.FileCode)
                    .IsRequired()
                    .HasColumnName("file_code")
                    .HasMaxLength(100);

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasMaxLength(100);

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Organization)
                    .HasColumnName("organization")
                    .HasMaxLength(100);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasColumnName("province")
                    .HasMaxLength(100);

                entity.Property(e => e.ReleaseTime)
                    .HasColumnName("release_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DsaPolicyIndustryFieldTagRelation>(entity =>
            {
                entity.ToTable("dsa_policy_industry_field_tag_relation", "dsa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IndustryFieldTagId).HasColumnName("industry_field_tag_id");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.HasOne(d => d.IndustryFieldTag)
                    .WithMany(p => p.DsaPolicyIndustryFieldTagRelation)
                    .HasForeignKey(d => d.IndustryFieldTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_industry_field_tag");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.DsaPolicyIndustryFieldTagRelation)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_policy_file");
            });

            modelBuilder.Entity<DsaRailwayClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_railway_class", "dsa");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RailwayCompanyName)
                    .HasColumnName("railway_company_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StationClass)
                    .HasColumnName("station_class")
                    .HasMaxLength(50);

                entity.Property(e => e.StationName)
                    .HasColumnName("station_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DsaReaIndustryMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dsa_rea_industry_mapping", "dsa");

                entity.Property(e => e.IndustryName1)
                    .HasColumnName("industry_name_1")
                    .HasMaxLength(100);

                entity.Property(e => e.IndustryName2)
                    .HasColumnName("industry_name_2")
                    .HasMaxLength(100);

                entity.Property(e => e.IndustryName3)
                    .HasColumnName("industry_name_3")
                    .HasMaxLength(100);

                entity.Property(e => e.IndustryName4)
                    .HasColumnName("industry_name_4")
                    .HasMaxLength(100);

                entity.Property(e => e.MasterIndustryName)
                    .HasColumnName("master_industry_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DsaSolidSmallMediumCompanies>(entity =>
            {
                entity.ToTable("dsa_solid_small_medium_companies", "dsa");

                entity.HasIndex(e => e.Name)
                    .HasName("unique_solid_small_medium_company_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Batch)
                    .HasColumnName("batch")
                    .HasMaxLength(500);

                entity.Property(e => e.CitySk).HasColumnName("city_sk");

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.PrimaryIndustryKey)
                    .IsRequired()
                    .HasColumnName("primary_industry_key")
                    .HasMaxLength(500);

                entity.Property(e => e.PrimaryProducts)
                    .HasColumnName("primary_products")
                    .HasMaxLength(500);

                entity.Property(e => e.ProvinceSk).HasColumnName("province_sk");

                entity.Property(e => e.SecondaryIndustryKey)
                    .IsRequired()
                    .HasColumnName("secondary_industry_key")
                    .HasMaxLength(500);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.ToTable("email_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailBody).HasColumnName("email_body");

                entity.Property(e => e.EmailCcList).HasColumnName("email_cc_list");

                entity.Property(e => e.EmailSentTime)
                    .HasColumnName("email_sent_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailSubject).HasColumnName("email_subject");

                entity.Property(e => e.EmailToList)
                    .IsRequired()
                    .HasColumnName("email_to_list");

                entity.Property(e => e.EmailType)
                    .HasColumnName("email_type")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<Geo>(entity =>
            {
                entity.ToTable("geo");

                entity.HasComment("?????");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.AdCode)
                    .IsRequired()
                    .HasColumnName("ad_code")
                    .HasMaxLength(128)
                    .HasComment("??????");

                entity.Property(e => e.GeoJson)
                    .IsRequired()
                    .HasColumnName("geo_json")
                    .HasColumnType("ntext")
                    .HasComment("????");
            });

            modelBuilder.Entity<IndicatorInstruction>(entity =>
            {
                entity.ToTable("indicator_instruction");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Class1Id).HasColumnName("class1_id");

                entity.Property(e => e.Class2Id).HasColumnName("class2_id");

                entity.Property(e => e.ComentsRemarks)
                    .HasColumnName("coments_remarks")
                    .HasMaxLength(3072);

                entity.Property(e => e.ComentsUpdateDate)
                    .HasColumnName("coments_update_date")
                    .HasMaxLength(3072);

                entity.Property(e => e.DataSource)
                    .HasColumnName("data_source")
                    .HasMaxLength(1024);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(3072);

                entity.Property(e => e.DisplayDataUnit)
                    .HasColumnName("display_data_unit")
                    .HasMaxLength(1024);

                entity.Property(e => e.Formula)
                    .HasColumnName("formula")
                    .HasMaxLength(1024);

                entity.Property(e => e.MinimumDisplayDecimal)
                    .HasColumnName("minimum_display_decimal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(1024);

                entity.Property(e => e.NumberOfDecimalPlaces).HasColumnName("number_of_decimal_places");

                entity.Property(e => e.RankForIndicator).HasColumnName("rank_for_indicator");

                entity.Property(e => e.RankingRules)
                    .HasColumnName("ranking_rules")
                    .HasMaxLength(1024);

                entity.Property(e => e.UnderlyingDataUnit)
                    .HasColumnName("underlying_data_unit")
                    .HasMaxLength(1024);

                entity.Property(e => e.Valid)
                    .IsRequired()
                    .HasColumnName("valid")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<IndustryCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("industry_category");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Class1Id).HasColumnName("class1_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IndustryName)
                    .HasColumnName("industry_name")
                    .HasMaxLength(512);

                entity.Property(e => e.IndustryOrder).HasColumnName("industry_order");

                entity.Property(e => e.IsValid)
                    .HasColumnName("is_valid")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sor12306TrainScheduleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_12306_train_schedule_detail", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartStationTime)
                    .IsRequired()
                    .HasColumnName("depart_station_time")
                    .HasMaxLength(50);

                entity.Property(e => e.EndStation)
                    .IsRequired()
                    .HasColumnName("end_station")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StartStation)
                    .IsRequired()
                    .HasColumnName("start_station")
                    .HasMaxLength(50);

                entity.Property(e => e.StationName)
                    .IsRequired()
                    .HasColumnName("station_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TrainCode)
                    .IsRequired()
                    .HasColumnName("train_code")
                    .HasMaxLength(50);

                entity.Property(e => e.TrainType)
                    .IsRequired()
                    .HasColumnName("train_type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorAirportsThroughput>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_airports_throughput", "sor");

                entity.Property(e => e.AirportName)
                    .IsRequired()
                    .HasColumnName("airport_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CargoThroughput).HasColumnName("cargo_throughput");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PassengerThroughput).HasColumnName("passenger_throughput");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TakeoffLanding).HasColumnName("takeoff_landing");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<SorAnjukeResidentialData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_anjuke_residential_data", "sor");

                entity.Property(e => e.AveragePrice).HasColumnName("average_price");

                entity.Property(e => e.AverageRent).HasColumnName("average_rent");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthYyyymm)
                    .IsRequired()
                    .HasColumnName("month_yyyymm")
                    .HasMaxLength(6);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorDistrictMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_district_master", "sor");

                entity.Property(e => e.CityAdCode)
                    .IsRequired()
                    .HasColumnName("city_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CityCenterCoords)
                    .IsRequired()
                    .HasColumnName("city_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.CityCode)
                    .HasColumnName("city_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictAdCode)
                    .IsRequired()
                    .HasColumnName("district_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictCenterCoords)
                    .IsRequired()
                    .HasColumnName("district_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk)
                    .HasColumnName("district_sk")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProjectPhase)
                    .HasColumnName("project_phase")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvAdCode)
                    .IsRequired()
                    .HasColumnName("prov_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.ProvCenterCoords)
                    .IsRequired()
                    .HasColumnName("prov_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorDistrictMasterBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_district_master_backup", "sor");

                entity.Property(e => e.CityAdCode)
                    .IsRequired()
                    .HasColumnName("city_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CityCenterCoords)
                    .IsRequired()
                    .HasColumnName("city_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasColumnName("city_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictAdCode)
                    .IsRequired()
                    .HasColumnName("district_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictCenterCoords)
                    .IsRequired()
                    .HasColumnName("district_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.ProjectPhase)
                    .HasColumnName("project_phase")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvAdCode)
                    .IsRequired()
                    .HasColumnName("prov_ad_code")
                    .HasMaxLength(10);

                entity.Property(e => e.ProvCenterCoords)
                    .IsRequired()
                    .HasColumnName("prov_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGanjiIndustrialRent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_ganji_industrial_rent", "sor");

                entity.Property(e => e.AverageArea)
                    .HasColumnName("average_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageDayRentRate)
                    .HasColumnName("average_day_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageMonthRentRate)
                    .HasColumnName("average_month_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGaode4aScenicSpot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gaode_4A_scenic_spot", "sor");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictSk).HasColumnName("district_sk");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ScenicSpotName)
                    .IsRequired()
                    .HasColumnName("scenic_spot_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGaodeDrivingTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gaode_driving_time", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationAddress)
                    .IsRequired()
                    .HasColumnName("destination_address")
                    .HasMaxLength(100);

                entity.Property(e => e.DestinationCoords)
                    .IsRequired()
                    .HasColumnName("destination_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationName)
                    .IsRequired()
                    .HasColumnName("destination_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationType)
                    .IsRequired()
                    .HasColumnName("destination_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.DistrictCenterCoords)
                    .IsRequired()
                    .HasColumnName("district_center_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DrivingTimeMinutes).HasColumnName("driving_time_minutes");

                entity.Property(e => e.DrivingTimeSeconds).HasColumnName("driving_time_seconds");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxiCost).HasColumnName("taxi_cost");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SorGaodePoiDetailData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gaode_poi_detail_data", "sor");

                entity.Property(e => e.AdCode)
                    .IsRequired()
                    .HasColumnName("ad_code")
                    .HasMaxLength(50);

                entity.Property(e => e.AdName)
                    .IsRequired()
                    .HasColumnName("ad_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessArea)
                    .HasColumnName("business_area")
                    .HasMaxLength(50);

                entity.Property(e => e.GridCode)
                    .IsRequired()
                    .HasColumnName("grid_code")
                    .HasMaxLength(50);

                entity.Property(e => e.IndicatorType)
                    .HasColumnName("indicator_type")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationCoords)
                    .IsRequired()
                    .HasColumnName("location_coords")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentCode)
                    .HasColumnName("parent_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentName)
                    .HasColumnName("parent_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PoiAddress)
                    .HasColumnName("poi_address")
                    .HasMaxLength(50);

                entity.Property(e => e.PoiId)
                    .IsRequired()
                    .HasColumnName("poi_id")
                    .HasMaxLength(50);

                entity.Property(e => e.PoiName)
                    .HasColumnName("poi_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PoiType)
                    .IsRequired()
                    .HasColumnName("poi_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PoiTypeCode)
                    .IsRequired()
                    .HasColumnName("poi_type_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PotentialPoiCount)
                    .IsRequired()
                    .HasColumnName("potential_poi_count")
                    .HasMaxLength(50);

                entity.Property(e => e.SearchKeywords)
                    .HasColumnName("search_keywords")
                    .HasMaxLength(50);

                entity.Property(e => e.SearchPoiTypeCode)
                    .IsRequired()
                    .HasColumnName("search_poi_type_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGdcCostData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gdc_cost_data", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .IsRequired()
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .IsRequired()
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGdcFinancialData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gdc_financial_data", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .IsRequired()
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .IsRequired()
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGdcIndustryData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gdc_industry_data", "sor");

                entity.HasIndex(e => new { e.DataName, e.ProvName, e.CityName, e.DistrictName, e.DataPeriod })
                    .HasName("idx_c_sor_gdc_industry_data")
                    .IsClustered();

                entity.HasIndex(e => new { e.DataName, e.ProvName, e.CityName, e.DistrictName, e.DataPeriod, e.Industry, e.Market })
                    .HasName("idx_un_sor_gdc_industry_data")
                    .IsUnique();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .IsRequired()
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .IsRequired()
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(100);

                entity.Property(e => e.Market)
                    .HasColumnName("market")
                    .HasMaxLength(100);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGdcInnovationData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gdc_innovation_data", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .IsRequired()
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .IsRequired()
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGdcInvestmentData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gdc_investment_data", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .IsRequired()
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .IsRequired()
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(100);

                entity.Property(e => e.Market)
                    .HasColumnName("market")
                    .HasMaxLength(100);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorGdcMacroScaleData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_gdc_macro_scale_data", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCategory)
                    .IsRequired()
                    .HasColumnName("data_category")
                    .HasMaxLength(50);

                entity.Property(e => e.DataCollectedAt)
                    .HasColumnName("data_collected_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataName)
                    .IsRequired()
                    .HasColumnName("data_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataNotes).HasColumnName("data_notes");

                entity.Property(e => e.DataPeriod)
                    .IsRequired()
                    .HasColumnName("data_period")
                    .HasMaxLength(50);

                entity.Property(e => e.DataSource).HasColumnName("data_source");

                entity.Property(e => e.DataUnit)
                    .HasColumnName("data_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionalLevel)
                    .IsRequired()
                    .HasColumnName("regional_level")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeGranularity)
                    .IsRequired()
                    .HasColumnName("time_granularity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorIfindLandSales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_ifind_land_sales", "sor");

                entity.Property(e => e.AverageBidFinalPrice)
                    .HasColumnName("average_bid_final_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageLandArea)
                    .HasColumnName("average_land_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UsageFilter)
                    .IsRequired()
                    .HasColumnName("usage_filter")
                    .HasMaxLength(2);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<SorLianjiaCommercialRent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_lianjia_commercial_rent", "sor");

                entity.Property(e => e.AverageArea)
                    .HasColumnName("average_area")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageMonthRentRate)
                    .HasColumnName("average_month_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageUnitMonthRentRate)
                    .HasColumnName("average_unit_month_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageUnitRentRate)
                    .HasColumnName("average_unit_rent_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorQicheBusScheduleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_qiche_bus_schedule_detail", "sor");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DepartStation)
                    .IsRequired()
                    .HasColumnName("depart_station")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationStation)
                    .IsRequired()
                    .HasColumnName("destination_station")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnName("prov_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnName("time")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SorReaIndustryMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sor_rea_industry_mapping", "sor");

                entity.Property(e => e.IndustryName1)
                    .HasColumnName("industry_name_1")
                    .HasMaxLength(100);

                entity.Property(e => e.IndustryName2)
                    .HasColumnName("industry_name_2")
                    .HasMaxLength(100);

                entity.Property(e => e.IndustryName3)
                    .HasColumnName("industry_name_3")
                    .HasMaxLength(100);

                entity.Property(e => e.IndustryName4)
                    .HasColumnName("industry_name_4")
                    .HasMaxLength(100);

                entity.Property(e => e.MasterIndustryName)
                    .IsRequired()
                    .HasColumnName("master_industry_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VcityParkList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VCityParkList");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(500);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(500);

                entity.Property(e => e.MainIndustry).HasMaxLength(1000);

                entity.Property(e => e.Prov)
                    .HasColumnName("prov")
                    .HasMaxLength(500);

                entity.Property(e => e.ZoneClass).HasMaxLength(1000);

                entity.Property(e => e.ZoneName).HasMaxLength(1000);

                entity.Property(e => e.ZoneType).HasMaxLength(1000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
