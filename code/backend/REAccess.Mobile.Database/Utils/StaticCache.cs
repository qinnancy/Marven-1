using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using REAccess.Mobile.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static REAccess.Mobile.Database.Utils.DbConstants;

namespace REAccess.Mobile.Database.Utils
{
    public static class StaticCache
    {
        public static void RefreshCache(params CacheEnum[] targetCaches)
        {
            //不传参就全部刷新
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                // 建立刷新所有指标的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.Indicators))
                {
                    Indicators = databaseContext.IndicatorInstruction.Where(x => x.Valid == DbYesOrNo.Yes).AsNoTracking().ToList();
                }
                // 建立刷新所有区域信息的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.Districts))
                {
                    Districts = databaseContext.DdsDDistrict.Where(x => x.DistrictSk != DistrictData.ChinaSkId).AsNoTracking().ToList();
                }
                // 建立刷新所有指标得分的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.IndicatorScore))
                {
                    IndicatorScore = databaseContext.DdsSDataIndicatorRank.AsNoTracking().ToList();
                }
                // 建立刷新所有指标原始数据的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.IndicatorScore))
                {
                    IndicatorOriginalScore = databaseContext.DdsSDataIndicatorFixed.AsNoTracking().ToList();
                }
                // 建立刷新所有开发区数据的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DevDistricts))
                {
                    DevDistricts = databaseContext.DevelopmentDistrict.AsNoTracking().ToList();
                }
                // 建立刷新系统配置项的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.AppConfigs))
                {
                    AppConfigs = databaseContext.AppConfig.AsNoTracking().ToList();
                }
                //建立刷新所有产业园区的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaIndustrialPark))
                {
                    DsaIndustrialPark = databaseContext.DsaIndustrialPark.AsNoTracking().ToList();
                }
                //建立刷新所有投资信息的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaListedCompanyInvestment))
                {
                    DsaListedCompanyInvestment = databaseContext.DsaListedCompanyInvestment.AsNoTracking().ToList();
                }
                //建立刷新所以产业图谱的缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaIndustryChain))
                {
                    DsaIndustryChain = databaseContext.DsaIndustryChains.AsNoTracking().ToList();
                }
                //建立刷新IndustryCategorys得缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.IndustryCategorys))
                {
                    IndustryCategorys = databaseContext.IndustryCategory.Where(x => x.IsValid == DbYesOrNo.Yes).ToList();
                }
                //建立刷新DsaInvestedProject得缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaInvestedProject))
                {
                    DsaInvestedProject = databaseContext.DsaInvestedProjects.ToList();
                }
                //建立刷新DsaIndustryLand得缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaIndustryLand))
                {
                    DsaIndustryLand = databaseContext.DsaIndustryLand.ToList();
                }
                //建立刷新DsaDistrict得缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaDistrict))
                {
                    DsaDistrict = databaseContext.DsaDistricts.ToList();
                }
                //建立刷新DsaListedCompany得缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaListedCompany))
                {
                    DsaListedCompany = databaseContext.DsaListedCompanies.ToList();
                }
                //建立刷新DsaSolidSmallMediumCompany得缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaSolidSmallMediumCompany))
                {
                    DsaSolidSmallMediumCompany = databaseContext.DsaSolidSmallMediumCompanies.ToList();
                }
                //建立刷新政策数据得缓存
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaPolicyIndustryFieldTagRelation))
                {
                    DsaPolicyIndustryFieldTagRelation = databaseContext.DsaPolicyIndustryFieldTagRelation.Include(x => x.IndustryFieldTag).Include(x => x.Policy).ToList();
                }
                //政策文件
                if (targetCaches == null || targetCaches.Contains(CacheEnum.DsaPolicyFile))
                {
                    DsaPolicyFile = databaseContext.DsaPolicyFiles.ToList();
                }
                //政策文件
                if (targetCaches == null || targetCaches.Contains(CacheEnum.News))
                {
                    DdsNews = databaseContext.DdsNews.ToList();
                }
            }
        }
        public static List<IndicatorInstruction> Indicators { get; set; }
        public static List<DdsDDistrict> Districts { get; set; }
        public static List<DdsSDataIndicatorRank> IndicatorScore { get; set; }
        public static List<DdsSDataIndicatorFixed> IndicatorOriginalScore { get; set; }
        public static List<DevelopmentDistrict> DevDistricts { get; set; }
        public static List<AppConfig> AppConfigs { get; set; }
        public static List<DsaIndustrialPark> DsaIndustrialPark { get; set; }
        public static List<DsaListedCompanyInvestment> DsaListedCompanyInvestment { get; set; }
        public static List<DsaIndustryChains> DsaIndustryChain { get; set; }
        public static List<IndustryCategory> IndustryCategorys { get; set; }
        public static List<DsaInvestedProjects> DsaInvestedProject { get; set; }
        public static List<DsaIndustryLand> DsaIndustryLand { get; set; }
        public static List<DsaDistricts> DsaDistrict { get; set; }
        public static List<DsaListedCompanies> DsaListedCompany { get; set; }
        public static List<DsaSolidSmallMediumCompanies> DsaSolidSmallMediumCompany { get; set; }
        public static List<DsaPolicyIndustryFieldTagRelation> DsaPolicyIndustryFieldTagRelation { get; set; }
        public static List<DsaPolicyFiles> DsaPolicyFile { get; set; }
        public static List<DdsNews> DdsNews { get; set; }
    }
    public enum CacheEnum
    {
        Indicators,
        Districts,
        IndicatorScore,
        DevDistricts,
        AppConfigs,
        IndexScoreList,
        DsaIndustrialPark,
        DsaListedCompanyInvestment,
        DsaIndustryChain,
        IndustryCategorys,
        DsaInvestedProject,
        DsaIndustryLand,
        DsaDistrict,
        DsaListedCompany,
        DsaSolidSmallMediumCompany,
        DsaPolicyIndustryFieldTagRelation,
        DsaPolicyFile,
        News
    }
}
