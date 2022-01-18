using REAccess_Mobile_Api.Interfaces;
using REAccess_Mobile_Api.Utils;
using REAccess_Mobile_Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using static REAccess_Mobile_Common.Constants;

namespace REAccess_Mobile_Api.Services
{
    public class IndustryService : ServiceBase, IIndustryService
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //产业投资--企业投资--活跃区域
        //筛选规则：全部产业/投资项目数量/全国/最新年份的排名
        public List<RankModel> GetActiveAreaRank()
        {
            List<RankModel> model = new List<RankModel>();
            //获取所有产业项目
            var industryProject = StaticCache.DsaInvestedProject;
            //获取产业项目中所有的城市ID
            var areaIds = industryProject.Where(x => x.CitySk != null).Select(x => x.CitySk).Distinct().ToList();
            //根据获取到的ID查询对应的城市列表
            var areaList = StaticCache.DsaDistrict.Where(x => areaIds.Contains(x.DistrictSk)).ToList();
            //获取最新年份的数据
            var year = industryProject.Where(x => x.InvestDate != null).Select(x => x.InvestDate.Value.Year).Distinct().Max();
            industryProject = industryProject.Where(x => x.InvestDate != null && x.InvestDate.Value.Year == year).ToList();

            foreach(var area in areaList)
            {
                if(industryProject.Count(x => x.CitySk == area.DistrictSk) > 0)
                {
                    RankModel rankModel = new RankModel()
                    {
                        DistrictSk = (int)area.DistrictSk,
                        CityName = area.City,
                        ProvinceName = area.Prov,
                        Unit = IndustryRankUnit.ByCounts,
                        RankValue = industryProject.Count(x => x.CitySk == area.DistrictSk).ToString()
                    };
                    model.Add(rankModel);
                }
            }
            model = model.OrderByDescending(x => float.Parse(x.RankValue)).Take(5).ToList();
            //根据项目个数排名--个数相同则名次相同
            for(var i = 0; i < model.Count(); i++)
            {
                if(i == 0)
                {
                    model[i].RankPlace = 1;
                }
                else
                {
                    if(model[i].RankValue == model[i - 1].RankValue)
                    {
                        model[i].RankPlace = model[i - 1].RankPlace;
                    }
                    else
                    {
                        model[i].RankPlace = i + 1;
                    }
                }
            }


            return model;
        }

        //产业投资--企业投资--热点产业
        //筛选规则：全国/投资项目数量/国民经济行业门类/最新年份的排名
        public List<CityRank> GetHotIndustryRank()
        {
            List<CityRank> model = new List<CityRank>();
            //获取所有产业项目
            var industryProject = StaticCache.DsaInvestedProject.Where(x => x.CitySk != null).ToList();
            //获取最新年份的数据
            var year = industryProject.Where(x => x.InvestDate != null).Select(x => x.InvestDate.Value.Year).Distinct().Max();
            industryProject = industryProject.Where(x => x.InvestDate != null && x.InvestDate.Value.Year == year).ToList();
            //获取所有产业类型--国民经济产业门类
            var industryTypeList = StaticCache.IndustryCategorys.Where(x => x.Class == 1).ToList();

            foreach(var industry in industryTypeList)
            {
                var industryList = industryProject.Where(x => x.IndustryPrimaryClassKey == industry.Id.ToString()).ToList();
                if(industryList.Count() > 0)
                {
                    CityRank indusryRank = new CityRank()
                    {
                        IndexId = industry.Id,
                        IndexName = industry.IndustryName,
                        IndexValue = industryList.Count().ToString(),
                        Unit = IndustryRankUnit.ByCounts
                    };
                    model.Add(indusryRank);
                }
            }
            model = model.OrderByDescending(x => float.Parse(x.IndexValue)).Take(5).ToList();
            //根据项目个数排名--个数相同则名次相同
            for (var i = 0; i < model.Count(); i++)
            {
                if(i == 0)
                {
                    model[i].RankPlace = 1;
                }
                else
                {
                    if(model[i] == model[i - 1])
                    {
                        model[i].RankPlace = model[i - 1].RankPlace;
                    }
                    else
                    {
                        model[i].RankPlace = i + 1;
                    }
                }
            }

            return model;
        }

        //产业投资-产业用地-活跃区域
        //筛选条件：全部产业/土地成交笔数/全国/最新年份
        public List<RankModel> GetIndusrtyActiveRegion()
        {
            List<RankModel> model = new List<RankModel>();
            //获取所有产业用地数据
            var industryLand = StaticCache.DsaIndustryLand.Where(x => x.CitySk != null).ToList();
            //获取最新年份的数据
            var year = industryLand.Where(x => x.LandClosingTime != null).Select(x => x.LandClosingTime.Value.Year).Distinct().Max();
            industryLand = industryLand.Where(x => x.LandClosingTime != null && x.LandClosingTime.Value.Year == year).ToList();
            //获取产业用地城市ID
            var cityIdList = industryLand.Where(x => x.CitySk != null).Select(x => x.CitySk).Distinct().ToList();
            //获取城市ID对应的城市
            var landCityList = StaticCache.DsaDistrict.Where(x => cityIdList.Contains(x.DistrictSk)).ToList();

            if(industryLand.Count() > 0)
            {
                foreach(var city in landCityList)
                {
                    RankModel rankModel = new RankModel()
                    {
                        DistrictSk = (int)city.DistrictSk,
                        CityName = city.City,
                        ProvinceName = city.Prov,
                        Unit = LandRankUnit.TransactionSumUnit,
                        RankValue = industryLand.Count(x => x.CitySk == city.DistrictSk).ToString()
                    };
                    model.Add(rankModel);
                }
                model = model.OrderByDescending(x => float.Parse(x.RankValue)).Take(5).ToList();
                //根据土地成交笔数排名--笔数相同则名次相同
                for (var i = 0; i < model.Count(); i++)
                {
                    if (i == 0)
                    {
                        model[i].RankPlace = 1;
                    }
                    else
                    {
                        if (model[i] == model[i - 1])
                        {
                            model[i].RankPlace = model[i - 1].RankPlace;
                        }
                        else
                        {
                            model[i].RankPlace = i + 1;
                        }
                    }
                }
            }

            return model;
        }

        //产业投资-产业用地-看热点产业
        //筛选规则：全国/土地成交笔数/国民经济行业门类/最新年份的排名
        public List<CityRank> GetLandHotIndustryRank()
        {
            List<CityRank> model = new List<CityRank>();
            //获取所有产业用地数据
            var industryLand = StaticCache.DsaIndustryLand.Where(x => x.CitySk != null).ToList();
            //获取最新年份的数据
            var year = industryLand.Where(x => x.LandClosingTime != null).Select(x => x.LandClosingTime.Value.Year).Distinct().Max();
            industryLand = industryLand.Where(x => x.LandClosingTime != null && x.LandClosingTime.Value.Year == year).ToList();
            //获取产业类型
            var industryType = StaticCache.IndustryCategorys.Where(x => x.Class == 1).ToList();

            foreach(var industry in industryType)
            {
                CityRank cityRank = new CityRank()
                {
                    IndexId = industry.Id,
                    IndexName = industry.IndustryName,
                    Unit = LandRankUnit.TransactionSumUnit,
                    IndexValue = industryLand.Count(x => x.BuyerIndustryPrimaryClassKey == industry.Id.ToString()).ToString()
                };
                model.Add(cityRank);
            }
            model = model.OrderByDescending(x => float.Parse(x.IndexValue)).Take(5).ToList();
            //根据土地成交笔数排名--笔数相同则名次相同
            for (var i = 0; i < model.Count(); i++)
            {
                if (i == 0)
                {
                    model[i].RankPlace = 1;
                }
                else
                {
                    if (model[i] == model[i - 1])
                    {
                        model[i].RankPlace = model[i - 1].RankPlace;
                    }
                    else
                    {
                        model[i].RankPlace = i + 1;
                    }
                }
            }

            return model;
        }

        //获取项目信息
        public IndustryModel GetIndustryProject(string primaryCategory,string secondaryCategory,string currentId)
        {
            IndustryModel model = new IndustryModel();
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            //获取产业类型
            var industryTypeList = StaticCache.IndustryCategorys.ToList();
            if (primaryCategory == Industrycategory.EnterpriseInvestment)//企业投资
            {
                //获取所有产业项目
                var industryProject = StaticCache.DsaInvestedProject;
                //获取最新年份的数据
                var year = industryProject.Where(x => x.InvestDate != null).Select(x => x.InvestDate.Value.Year).Distinct().Max();
                industryProject = industryProject.Where(x => x.InvestDate != null && x.InvestDate.Value.Year == year).ToList();

                if (secondaryCategory == Industrycategory.ActiveRegion)
                {
                    industryProject = industryProject.Where(x => x.CitySk == long.Parse(currentId)).ToList();
                    model.PrimaryName = StaticCache.DsaDistrict.FirstOrDefault(x => x.DistrictSk == long.Parse(currentId)).City;
                }
                else
                {
                    industryProject = industryProject.Where(x => x.IndustryPrimaryClassKey == currentId).ToList();
                    model.PrimaryName = industryTypeList.FirstOrDefault(x => x.Id.ToString() == currentId).IndustryName;
                }
                model.InvestProjectCount = industryProject.Count().ToString() + LandRankUnit.TransactionSumUnit;
                model.InvestProjectAmount = ((double)industryProject.Sum(x => x.InvestAmount10k / 10000)).ToString("N0") + IndustryRankUnit.ByAmount;
                industryProject = industryProject.OrderByDescending(x => x.InvestAmount10k).Take(8).ToList();
                model.ProjectList = industryProject.Select(x => new ProjectDetail()
                {
                    InvestmentCompany = x.InvestCompany == null ? IndustryRankUnit.NullVaule : x.InvestCompany,
                    ProjectLocation = x.ProjectLocation == null ? IndustryRankUnit.NullVaule : x.ProjectLocation,
                    ProjectIndustry = industryTypeList.FirstOrDefault(a => a.Id.ToString() == x.IndustrySecondaryClassKey).IndustryName,
                    ProjectCapacity = x.ProjectCapacity == null ? IndustryRankUnit.NullVaule : x.ProjectCapacity,
                    AreaCovered = x.LandSize == null ? IndustryRankUnit.NullVaule : ((double)x.LandSize).ToString("N0") + IndustryRankUnit.ByLandSize,
                    TransactionAmount = x.InvestAmount10k == null ? IndustryRankUnit.NullVaule : ((double)x.InvestAmount10k).ToString("N0") + IndustryRankUnit.ByAmount,
                    AnnualOutput = x.ProjectAnnualProduction10k == null ? IndustryRankUnit.NullVaule : ((double)x.ProjectAnnualProduction10k).ToString("N0") + IndustryRankUnit.ByAmount,
                    AnnualTax = x.ProjectAnnualTax10k == null ? IndustryRankUnit.NullVaule : ((double)x.ProjectAnnualTax10k).ToString("N0") + IndustryRankUnit.ByAmount,
                }).ToList();
            }
            else   //产业用地
            {
                //获取所有产业用地数据
                var industryLand = StaticCache.DsaIndustryLand.Where(x => x.CitySk != null).ToList();
                //获取最新年份的数据
                var year = industryLand.Where(x => x.LandClosingTime != null).Select(x => x.LandClosingTime.Value.Year).Distinct().Max();
                industryLand = industryLand.Where(x => x.LandClosingTime != null && x.LandClosingTime.Value.Year == year).ToList();
                
                if (secondaryCategory == Industrycategory.ActiveRegion)
                {
                    industryLand = industryLand.Where(x => x.CitySk == long.Parse(currentId)).ToList();
                    model.PrimaryName = StaticCache.DsaDistrict.FirstOrDefault(x => x.DistrictSk == long.Parse(currentId)).City;
                }
                else
                {
                    industryLand = industryLand.Where(x => x.BuyerIndustryPrimaryClassKey == currentId).ToList();
                    model.PrimaryName = industryTypeList.FirstOrDefault(x => x.Id.ToString() == currentId).IndustryName;
                }
                model.InvestProjectCount = industryLand.Count().ToString("N0") + LandRankUnit.TransactionSumUnit;
                model.InvestProjectAmount = ((double)industryLand.Sum(x => x.LandPrice / 10000)).ToString("N0") + LandRankUnit.TransactionAmountUnit;
                industryLand = industryLand.OrderByDescending(x => x.LandPrice).Take(8).ToList();
                model.ProjectList = industryLand.Select(x => new ProjectDetail()
                {
                    ProjectLocation = x.LandLocation == null ? IndustryRankUnit.NullVaule : x.LandLocation,
                    ProjectIndustry = industryTypeList.FirstOrDefault(a => a.Id.ToString() == x.BuyerIndustryPrimaryClassKey).IndustryName,
                    AreaCovered = x.LandTotalArea == null ? IndustryRankUnit.NullVaule : ((double)x.LandTotalArea).ToString("N0") + LandRankUnit.TransactionAreaUnit,
                    TransactionAmount = x.LandPrice == null ? IndustryRankUnit.NullVaule : ((double)x.LandPrice).ToString("N0") + LandRankUnit.TransactionAmountUnitOfTable,
                    TransferDate = x.LandClosingTime == null ? IndustryRankUnit.NullVaule : Convert.ToDateTime(x.LandClosingTime,dtFormat).ToString("yyyy-MM-dd")
                }).ToList();
            }

            return model;
        }

    }
}
