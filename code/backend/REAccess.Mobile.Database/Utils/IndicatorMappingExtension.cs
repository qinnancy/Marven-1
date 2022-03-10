using REAccess.Mobile.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace REAccess.Mobile.Database.Utils
{
    public static class IndicatorMappingExtension
    {
        public static decimal? GetValueByName(this DdsSDataIndicatorRank entity, string indicatorClass3Name)
        {
            decimal? value = null;
            switch (indicatorClass3Name)
            {
                case "GDP总量":
                    value = entity.GdpRatio ?? 0;
                    break;
                case "单位面积GDP":
                    value = entity.GdpPerUnitAreaRatio ?? 0;
                    break;
                case "人均GDP":
                    value = entity.GdpPerCapitaPermenantResidentRatio ?? 0;
                    break;
                case "GDP增速":
                    value = entity.GdpYoyRatio ?? 0;
                    break;
                case "固定资产投资":
                    value = entity.FixedAssetsInvestmentRatio ?? 0;
                    break;
                case "进出口总额":
                    value = entity.ImportAndExportRatio ?? 0;
                    break;
                case "社会消费品零售总额":
                    value = entity.ConsumerGoodsRetailSalesRatio ?? 0;
                    break;
                case "一般公共预算收入":
                    value = entity.FisicalBudgetRevenueRatio ?? 0;
                    break;
                case "地方政府债务压力":
                    value = entity.LocalGovernmentDebtPressureByGdpRatio ?? 0;
                    break;
                case "城镇化率":
                    value = null;
                    break;
                case "行政区域土地面积（全市）":
                    value = entity.LandSizeRatio ?? 0;
                    break;
                case "建成区比例":
                    value = null;
                    break;
                case "开发强度":
                    value = null;
                    break;
                case "常住人口":
                    value = entity.PermenantResidentsRatio ?? 0;
                    break;
                case "户籍人口":
                    value = null;
                    break;
                case "常住人口增速":
                    value = entity.PermenantResidentsYoyRatio ?? 0;
                    break;
                case "户籍人口增速":
                    value = null;
                    break;
                case "常住人口密度":
                    value = entity.PermanentPopulationDensityRatio ?? 0;
                    break;
                case "户籍人口密度":
                    value = null;
                    break;
                case "注册企业数量":
                    value = entity.RegisteredCompaniesRatio ?? 0;
                    break;
                case "注册企业数量增速":
                    value = entity.RegisteredCompaniesYoyRatio ?? 0;
                    break;
                case "注册企业密度":
                    value = entity.RegisteredBusinessDensityRatio ?? 0;
                    break;
                case "内部交通联系度":
                    value = entity.InternalTrafficConnectionRatio ?? 0;
                    break;
                case "对外交通联系度":
                    value = entity.ExternalTrafficConnectionRatio ?? 0;
                    break;
                case "二等站及以上铁路车站":
                    value = entity.HighLevelRailwayStationCountRatio ?? 0;
                    break;
                case "干线高速出入口数量":
                    value = entity.HighwayEntriesCountRatio ?? 0;
                    break;
                case "物流站点数量":
                    value = entity.LogisticsStationCountRatio ?? 0;
                    break;
                case "规上企业数量":
                    value = null;
                    break;
                case "规上企业数量增速":
                    value = null;
                    break;
                case "规上企业总资产":
                    value = null;
                    break;
                case "规上企业总资产份额":
                    value = null;
                    break;
                case "规上企业平均资产":
                    value = null;
                    break;
                case "规上企业总产值":
                    value = null;
                    break;
                case "规上企业总产值增速":
                    value = null;
                    break;
                case "规上企业平均产值":
                    value = null;
                    break;
                case "规上企业人均产值":
                    value = null;
                    break;
                case "规上企业单位面积产值":
                    value = null;
                    break;
                case "上市企业数量":
                    value = entity.ListedCompanyCountRatio ?? 0;
                    break;
                case "企业上市率":
                    value = entity.ListedRateRatio ?? 0;
                    break;
                case "上市企业市值":
                    value = entity.ListedCompanyMarketValueRatio ?? 0;
                    break;
                case "上市企业营业收入":
                    value = entity.ListedCompanyIncomeRatio ?? 0;
                    break;
                case "上市企业营业收入增速":
                    value = entity.ListedCompanyIncomeYoyRatio ?? 0;
                    break;
                case "上市企业净利润":
                    value = entity.ListedCompanyEbitRatio ?? 0;
                    break;
                case "上市企业净利润增速":
                    value = entity.ListedCompanyEbitYoyRatio ?? 0;
                    break;
                case "获投企业数量":
                    value = entity.InvestedCompaniesCountRatio ?? 0;
                    break;
                case "获投企业数量增速":
                    value = entity.InvestedCompaniesCountYoyRatio ?? 0;
                    break;
                case "获投企业数量占比":
                    value = entity.InvestedCompaniesCountRatioRatio ?? 0;
                    break;
                case "获投金额":
                    value = entity.InvestedCompaniesInvestedAmountRatio ?? 0;
                    break;
                case "获投金额增速":
                    value = entity.InvestedCompaniesInvestedAmountYoyRatio ?? 0;
                    break;
                case "获投金额占比":
                    value = entity.InvestedCompaniesInvestedAmountRatioRatio ?? 0;
                    break;
                case "独角兽企业数量":
                    value = entity.UnicornsCountRatio ?? 0;
                    break;
                case "独角兽企业数量占比":
                    value = entity.UnicornsCountRatioRatio ?? 0;
                    break;
                case "独角兽企业估值":
                    value = entity.UnicornsEstimatedValueRatio ?? 0;
                    break;
                case "独角兽企业估值占比":
                    value = entity.UnicornsEstimatedValueRatioRatio ?? 0;
                    break;
                case "科技型中小企业数量":
                    value = entity.TechBasedSmeRatio ?? 0;
                    break;
                case "高新技术企业数量":
                    value = entity.HighTechEnterprisesRatio ?? 0;
                    break;
                case "国家级平台数量":
                    value = entity.NationalPlatformsRatio ?? 0;
                    break;
                case "博士后科研工作站数量":
                    value = entity.PostdoctoralResearchStationRatio ?? 0;
                    break;
                case "双一流院校数量":
                    value = entity.College211985Ratio ?? 0;
                    break;
                case "在校研究生数量":
                    value = entity.GraduatesAtSchoolCountRatio ?? 0;
                    break;
                case "高等院校在读学生数量":
                    value = entity.UndergraduatesAtSchoolCountRatio ?? 0;
                    break;
                case "大专院校数量":
                    value = entity.UndergraduateAndAcademyRatio ?? 0;
                    break;
                case "R&D支出占GDP比重":
                    value = null;
                    break;
                case "万人发明专利拥有量":
                    value = entity.InventionPatentsPer10kPplRatio ?? 0;
                    break;
                case "上市企业研发费用":
                    value = entity.ListedCompaniesResearchBudgetRatio ?? 0;
                    break;
                case "上市企业研发投入占比":
                    value = entity.ListedCompaniesResearchInvestRatio ?? 0;
                    break;
                case "工业用地平均出让价格":
                    value = entity.AverageIndustrialLandPriceRatio ?? 0;
                    break;
                case "工业载体出租成本":
                    value = entity.AverageIndustrialRentRateRatio ?? 0;
                    break;
                case "商业用地平均出让价格":
                    value = entity.AverageCommercialLandPriceRatio ?? 0;
                    break;
                case "商办载体出租成本":
                    value = entity.AverageCommercialRentRateRatio ?? 0;
                    break;
                case "甲级写字楼供应面积":
                    value = entity.AverageCommercialLandAreaRatio ?? 0;
                    break;
                case "平均产业载体成本":
                    value = decimal.Round((entity.AverageIndustrialRentRateRatio ?? 0 + entity.AverageCommercialRentRateRatio ?? 0) / 2, 2);
                    break;
                case "相对劳动力成本":
                    value = entity.RelativeLabourCostRatio ?? 0;
                    break;
                case "普通劳动力平均年薪":
                    value = entity.OrdinaryLabourCostRatio ?? 0;
                    break;
                case "水电气热平均成本":
                    value = entity.IndustrialAverageCostRatio ?? 0;
                    break;
                case "轨道交通站点密度":
                    value = entity.RailwayStationCountRatioRatio ?? 0;
                    break;
                case "每千人二三甲医院床位数":
                    value = entity.NumberOfBedsPerThousandRatio ?? 0;
                    break;
                case "优质医院数量":
                    value = entity.HospitalCountRatio ?? 0;
                    break;
                case "每十万人基础教育学校数量":
                    value = entity.NumberOfK12EducationSchoolsPer10kPplRatio ?? 0;
                    break;
                case "每十万人国际学校数量":
                    value = entity.NumberOfInternationalSchoolsPer10kPplRatio ?? 0;
                    break;
                case "每十万人高等级酒店数量":
                    value = entity.NumberOfHotelsPer10kPplRatio ?? 0;
                    break;
                case "每十万人电影院数量":
                    value = entity.NumberOfCinemasPer10kPplRatio ?? 0;
                    break;
                case "每十万人超市便利店数量":
                    value = entity.NumberOfSupermarketConvenienceStoresPer10kPplRatio ?? 0;
                    break;
                case "每十万人星巴克数量":
                    value = entity.StarbucksPer10kPplRatio ?? 0;
                    break;
                case "每十万人文化设施数量":
                    value = entity.NumberOfCultureFacilitiesPer10kPplRatio ?? 0;
                    break;
                case "4A级以上景区数量":
                    value = entity.ScenicSpotCountRatio ?? 0;
                    break;
                case "房价收入比":
                    value = entity.HousePriceIncomeRatioRatio ?? 0;
                    break;
                case "房租收入比":
                    value = entity.RentToIncomeRatioRatio ?? 0;
                    break;
                case "PM2.5年均浓度":
                    value = entity.AirQualityRatio ?? 0;
                    break;
                case "本外币各项贷款余额占GDP比重":
                    value = entity.CreditSupportsTheRealEconomyRatio ?? 0;
                    break;
                case "金融机构数量":
                    value = entity.FinancialCompanyCountRatio ?? 0;
                    break;
                case "投资机构数量":
                    value = entity.InvestmentCompanyCountRatio ?? 0;
                    break;
                case "政府引导基金总规模":
                    value = null;
                    break;
                case "城市租售比":
                    value = entity.RentToHousePriceRatioRatio ?? 0;
                    break;
                case "劳动力产出效率":
                    value = entity.LabourOutputEfficiencyRatio ?? 0;
                    break;
                case "人口净流入率":
                    value = entity.PopulationNetInflowRatio ?? 0;
                    break;
                case "单位GDP耗电量":
                    value = entity.UnitGdpElectricityConsumptionRatio ?? 0;
                    break;
                case "一般公共预算自给率":
                    value = entity.FiscalSelfSupplimentRatio ?? 0;
                    break;
                case "产业投资性价比":
                    value = entity.IndustryInvestmentCostEffectiveRatio ?? 0;
                    break;
                case "一般公共预算支出":
                    value = entity.FisicalBudgetExpenditureRatio ?? 0;
                    break;
                case "实际利用外资":
                    value = entity.DirectUseOfForeignCapitalRatio ?? 0;
                    break;
                case "实际利用外资增速":
                    value = entity.DirectUseOfForeignCapitalYoyRatio ?? 0;
                    break;
                case "全市居民人均消费支出":
                    value = entity.ResidentExpenditurePerCapitaRatio ?? 0;
                    break;
                case "新增就业人口":
                    value = entity.NewEmploymentRatio ?? 0;
                    break;
                case "新增就业人口比率":
                    value = entity.NewEmploymentRateRatio ?? 0;
                    break;
                case "规上工业企业数量":
                    value = entity.LargeIndustrialEnterprisesCountRatio ?? 0;
                    break;
                case "规上工业企业数量增速":
                    value = entity.LargeIndustrialCompanyCountYoyRatio ?? 0;
                    break;
                case "规上工业企业总资产份额":
                    value = entity.LargeIndustrialCompanyTotalAssetRatioRatio ?? 0;
                    break;
                case "规上工业企业平均资产":
                    value = entity.LargeIndustrialCompanyAverageAssetRatio ?? 0;
                    break;
                case "规上工业企业总产值":
                    value = entity.LargeIndustrialCompanyTotalProductionRatio ?? 0;
                    break;
                case "规上工业企业总产值增速":
                    value = entity.LargeIndustrialCompanyTotalProductionYoyRatio ?? 0;
                    break;
                case "规上工业企业平均产值":
                    value = entity.LargeIndustrialCompanyAverageProductionRatio ?? 0;
                    break;
                case "规上工业企业人均产值":
                    value = entity.LargeIndustrialCompanyProductionPerCapitaRatio ?? 0;
                    break;
                case "规上工业企业单位面积产值":
                    value = entity.LargeIndustrialCompanyUnitAreaProductionRatio ?? 0;
                    break;
                case "规上工业企业工业增加值":
                    value = entity.LargeIndustrialCompanyValueAddedRatio ?? 0;
                    break;
                case "规上工业企业总资产":
                    value = entity.LargeIndustrialEnterprisesAssetsRatio ?? 0;
                    break;
                case "规上工业企业员工总数":
                    value = entity.LargeEnterprisesStaffCountRatio ?? 0;
                    break;
                case "第一产业增加值":
                    value = entity.PrimaryIndustryValueAddedRatio ?? 0;
                    break;
                case "第一产业增加值增速":
                    value = entity.PrimaryIndustryValueAddedYoyRatio ?? 0;
                    break;
                case "第二产业增加值":
                    value = entity.SecondaryIndustryValueAddedRatio ?? 0;
                    break;
                case "第二产业增加值增速":
                    value = entity.SecondaryIndustryValueAddedYoyRatio ?? 0;
                    break;
                case "第三产业增加值":
                    value = entity.TertiaryIndustryValueAddedRatio ?? 0;
                    break;
                case "工业增加值":
                    value = entity.IndustrialValueAddedRatio ?? 0;
                    break;
                case "工业增加值增速":
                    value = entity.IndustrialValueAddedYoyRatio ?? 0;
                    break;
                case "第三产业增加值增速":
                    value = entity.TertiaryIndustryValueAddedYoyRatio ?? 0;
                    break;
                case "全社会用电量":
                    value = entity.WholeSocietyElectricityConsumptionRatio ?? 0;
                    break;
                case "全社会用电量增速":
                    value = entity.WholeSocietyElectricityConsumptionYoyRatio ?? 0;
                    break;
                case "工业用电量":
                    value = entity.IndustrialElectricityConsumptionRatio ?? 0;
                    break;
                case "本专科院校数量":
                    value = entity.UndergraduateAndAcademyRatio ?? 0;
                    break;
                case "全市居民人均可支配收入":
                    value = entity.DisposableIncomeRatio ?? 0;
                    break;
                case "新增常住人口":
                    value = entity.NewPermenantResidentsRatio ?? 0;
                    break;
                case "B型保税物流中心数量":
                    value = entity.BondedLogisticsCenterBAmountRatio ?? 0;
                    break;
                case "海关特殊监管区数量":
                    value = entity.SpecialCustomsControllingZoneAmountRatio ?? 0;
                    break;
                case "国家级先进制造业集群数量":
                    value = entity.NationalAdvancedManufacturingIndustryAmountRatio ?? 0;
                    break;
                case "专精特新“小巨人”企业数量":
                    value = entity.SolidSmallMediumEnterprisesAmountRatio ?? 0;
                    break;
                case "国家级科技企业孵化器数量":
                    value = entity.NationalTechBusinessIncubatorAmountRatio ?? 0;
                    break;
                case "国家级经开区数量":
                    value = entity.NationalEcoDevelopmentZoneAmountRatio ?? 0;
                    break;
                case "国家级高新区数量":
                    value = entity.NationalHighTechIndustrialDevelopmentZoneAmountRatio ?? 0;
                    break;
                case "省级开发区数量":
                    value = entity.ProvincialDevelopmentZoneAmountRatio ?? 0;
                    break;
                ///
                case "地方政府债务余额":
                    value = entity.LocalGovernmentDebtRatio ?? 0;
                    break;
                case "本外币各项贷款余额":
                    value = entity.BankLoanBalanceRatio ?? 0;
                    break;
                case "航班起降架次":
                    value = entity.AirlineYearlyTakeoffLandingTimesRatio ?? 0;
                    break;
                case "旅客列车车次总量":
                    value = entity.TrainYearlyDepartTimesRatio ?? 0;
                    break;
                case "汽车客运站发出车次总量":
                    value = entity.BusYearlyDepartTimesRatio ?? 0;
                    break;
                case "银行业金融机构法人数量":
                    value = entity.BankingFinancialInstitutionLegalEntityCountRatio ?? 0;
                    break;
                case "银行业金融机构数量":
                    value = entity.BankingFinancialInstitutionCountRatio ?? 0;
                    break;
                case "保险机构法人数量":
                    value = entity.InsuranceInstitutionLegalEntityCountRatio ?? 0;
                    break;
                case "保险机构数量":
                    value = entity.InsuranceInstitutionCountRatio ?? 0;
                    break;
                case "证券公司法人数量":
                    value = entity.SecurityCompanyLegalEntityCountRatio ?? 0;
                    break;
                case "期货公司法人数量":
                    value = entity.FuturesCompanyLegalEntityCountRatio ?? 0;
                    break;
                case "公募基金管理机构法人数量":
                    value = entity.PublicFundInstitutionLegalEntityCountRatio ?? 0;
                    break;
                case "平均住房租金":
                    value = entity.AvgRentRatio ?? 0;
                    break;
                case "城镇居民人均可支配收入":
                    value = entity.UrbanResidentsDisposableIncomeRatio ?? 0;
                    break;
                case "城镇居民人均消费支出":
                    value = entity.UrbanResidentExpenditurePerCapitaRatio ?? 0;
                    break;
                case "二三甲医院床位数量":
                    value = entity.HospitalBedsCountRatio ?? 0;
                    break;
                case "基础教育学校数量":
                    value = entity.K12CountRatio ?? 0;
                    break;
                case "国际学校数量":
                    value = entity.InternationSchoolCountRatio ?? 0;
                    break;
                case "地铁站点数量":
                    value = entity.RailwayStationCountRatio ?? 0;
                    break;
                case "超市便利店数量":
                    value = entity.SupermarketAndStoreCountRatio ?? 0;
                    break;
                case "高等级酒店数量":
                    value = entity.HotelCountRatio ?? 0;
                    break;
                case "星巴克数量":
                    value = entity.StarbucksCountRatio ?? 0;
                    break;
                case "电影院数量":
                    value = entity.CinemaCountRatio ?? 0;
                    break;
                case "文化设施数量":
                    value = entity.CultureFacilitiesCountRatio ?? 0;
                    break;
                case "每十万人4A级以上景区数量":
                    value = entity.ScenicSpotCountPer100kPplRatio ?? 0;
                    break;
                case "平均购房价格":
                    value = entity.AvgHousePriceRatio ?? 0;
                    break;
                case "地方政府负债率":
                    value = entity.LocalGovernmentDebtPressureByGdpRatio ?? 0;
                    break;
                case "规上工业增加值":
                    value = entity.LargeIndustrialCompanyValueAddedRatio ?? 0;
                    break;
                case "保税物流中心（B型）数量":
                    value = entity.BondedLogisticsCenterBAmountRatio ?? 0;
                    break;
                case "国家重点实验室数量":
                    value = entity.NationalResearchLabsRatio ?? 0;
                    break;
                case "国家企业技术中心数量":
                    value = entity.NationalEnterpriseTechCentersRatio ?? 0;
                    break;
                case "普通高等学校数量":
                    value = entity.UndergraduateAndAcademyRatio ?? 0;
                    break;
                case "二三甲医院数量":
                    value = entity.HospitalCountRatio ?? 0;
                    break;
                case "获投企业融资额":
                    value = entity.InvestedCompaniesInvestedAmountRatio ?? 0;
                    break;

                //20220129insert
                case "年均空气质量指数(AQI)":
                    value = entity.AqiRatio ?? 0;
                    break;
                case "4A级景区数量":
                    value = entity.NumberOf4aRatio ?? 0;
                    break;
                case "5A级景区数量":
                    value = entity.NumberOf5aRatio ?? 0;
                    break;
                case "城镇居民消费意愿指数":
                    value = entity.ConsumptionIntentionIndexTownRatio ?? 0;
                    break;
                case "港口货物吞吐量":
                    value = entity.PortGoodsCapacityRatio ?? 0;
                    break;
                case "港口集装箱吞吐量":
                    value = entity.PortContainerCapacityRatio ?? 0;
                    break;
                //已存在但归于新增
                /*case "公募基金管理机构法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "货物运输周转量":
                    value = entity.GoodsTurnoverTotalAmountRatio ?? 0;
                    break;
                case "货物运输总量":
                    value = entity.GoodsTransportTotalAmountRatio ?? 0;
                    break;
                case "机场货邮吞吐量":
                    value = entity.AirportGoodsCapacityRatio ?? 0;
                    break;
                case "机场旅客吞吐量":
                    value = entity.AirportPassengerCapacityRatio ?? 0;
                    break;
                case "建成区绿化覆盖率（市辖区）":
                    value = entity.BuildUpGreenCoverageCityRatio ?? 0;
                    break;
                case "建成区面积（市辖区）":
                    value = entity.BuildUpAreaCityRatio ?? 0;
                    break;
                //当前数据库无该指标，但excel归于更新指标，按新增指标处理
                ///
                /*case "旅客列车车次总量":
                    value = entity.InvestedCompaniesInvestedAmount ?? (decimal)-999999.0;
                    break;*/
                case "绿地面积（市辖区）":
                    value = entity.BuildUpGreenLandAreaRatio ?? 0;
                    break;
                case "每千人医疗机构床位数量":
                    value = entity.BedsPerThousandInHospitalCountRatio ?? 0;
                    break;
                case "普通小学数量":
                    value = entity.NumberOfPrimarySchoolRatio ?? 0;
                    break;
                case "普通中学数量":
                    value = entity.NumberOfMiddleSchoolRatio ?? 0;
                    break;
                //已存在但归于新增
                /*case "期货公司法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "全市居民消费意愿指数":
                    value = entity.ConsumptionIntentionIndexCityRatio ?? 0;
                    break;
                case "双一流学科数量":
                    value = entity.DoubleFirstClassDisciplineCountRatio ?? 0;
                    break;
                case "水资源总量":
                    value = entity.TotalWaterResourceRatio ?? 0;
                    break;
                ///
                case "私募基金管理人数量":
                    value = entity.PrivateFundManagerCountRatio ?? (decimal)-999999.0;
                    break;
                case "医疗机构床位数量":
                    value = entity.NumberOfBedsInHospitalRatio ?? 0;
                    break;
                case "医疗机构数量":
                    value = entity.NumberOfMedicalInstitutionRatio ?? 0;
                    break;
                //已存在但归于新增
                /*case "银行业金融机构法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                //已存在但归于新增
                /*case "银行业金融机构数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "幼儿园数量":
                    value = entity.NumberOfKindergardenRatio ?? 0;
                    break;
                //已存在但归于新增
                /*case "证券公司法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "每十万人地铁站点数量":
                    value = entity.NumberOfRailwayStationPer10kPplRatio ?? 0;
                    break;
            }


            //如果value是空就返回0；该方法内的null代表数据库没有对应的该字段。后期可以有相应的不同处理。
            value ??= 0;

            return value;
        }
        public static decimal? GetOriginalValueByName(this DdsSDataIndicatorFixed entity, string indicatorClass3Name)
        {
            decimal? value = null;
            switch (indicatorClass3Name)
            {
                case "GDP总量":
                    value = entity.Gdp ?? (decimal)-999999.0;
                    break;
                case "单位面积GDP":
                    value = entity.GdpPerUnitArea ?? (decimal)-999999.0;
                    break;
                case "人均GDP":
                    value = entity.GdpPerCapitaPermenantResident ?? (decimal)-999999.0;
                    break;
                case "GDP增速":
                    value = entity.GdpYoy ?? (decimal)-999999.0;
                    break;
                case "固定资产投资":
                    value = entity.FixedAssetsInvestment ?? (decimal)-999999.0;
                    break;
                case "进出口总额":
                    value = entity.ImportAndExport ?? (decimal)-999999.0;
                    break;
                case "社会消费品零售总额":
                    value = entity.ConsumerGoodsRetailSales ?? (decimal)-999999.0;
                    break;
                case "一般公共预算收入":
                    value = entity.FisicalBudgetRevenue ?? (decimal)-999999.0;
                    break;
                case "地方政府债务压力":
                    value = entity.LocalGovernmentDebtPressureByGdp ?? (decimal)-999999.0;
                    break;
                case "城镇化率":
                    value = null;
                    break;
                case "行政区域土地面积（全市）":
                    value = entity.LandSize ?? (decimal)-999999.0;
                    break;
                case "建成区比例":
                    value = null;
                    break;
                case "开发强度":
                    value = null;
                    break;
                case "常住人口":
                    value = entity.PermenantResidents ?? (decimal)-999999.0;
                    break;
                case "户籍人口":
                    value = null;
                    break;
                case "常住人口增速":
                    value = entity.PermenantResidentsYoy ?? (decimal)-999999.0;
                    break;
                case "户籍人口增速":
                    value = null;
                    break;
                case "常住人口密度":
                    value = entity.PermanentPopulationDensity ?? (decimal)-999999.0;
                    break;
                case "户籍人口密度":
                    value = null;
                    break;
                case "注册企业数量":
                    value = entity.RegisteredCompanies ?? (decimal)-999999.0;
                    break;
                case "注册企业数量增速":
                    value = entity.RegisteredCompaniesYoy ?? (decimal)-999999.0;
                    break;
                case "注册企业密度":
                    value = entity.RegisteredBusinessDensity ?? (decimal)-999999.0;
                    break;
                case "内部交通联系度":
                    value = entity.InternalTrafficConnection ?? (decimal)-999999.0;
                    break;
                case "对外交通联系度":
                    value = entity.ExternalTrafficConnection ?? (decimal)-999999.0;
                    break;
                case "二等站及以上铁路车站":
                    value = entity.HighLevelRailwayStationCount ?? (decimal)-999999.0;
                    break;
                case "干线高速出入口数量":
                    value = entity.HighwayEntriesCount ?? (decimal)-999999.0;
                    break;
                case "物流站点数量":
                    value = entity.LogisticsStationCount ?? (decimal)-999999.0;
                    break;
                case "规上企业数量":
                    value = null;
                    break;
                case "规上企业数量增速":
                    value = null;
                    break;
                case "规上企业总资产":
                    value = null;
                    break;
                case "规上企业总资产份额":
                    value = null;
                    break;
                case "规上企业平均资产":
                    value = null;
                    break;
                case "规上企业总产值":
                    value = null;
                    break;
                case "规上企业总产值增速":
                    value = null;
                    break;
                case "规上企业平均产值":
                    value = null;
                    break;
                case "规上企业人均产值":
                    value = null;
                    break;
                case "规上企业单位面积产值":
                    value = null;
                    break;
                case "上市企业数量":
                    value = entity.ListedCompanyCount ?? (decimal)-999999.0;
                    break;
                case "企业上市率":
                    value = entity.ListedRate ?? (decimal)-999999.0;
                    break;
                case "上市企业市值":
                    value = entity.ListedCompanyMarketValue ?? (decimal)-999999.0;
                    break;
                case "上市企业营业收入":
                    value = entity.ListedCompanyIncome;
                    break;
                case "上市企业营业收入增速":
                    value = entity.ListedCompanyIncomeYoy ?? (decimal)-999999.0;
                    break;
                case "上市企业净利润":
                    value = entity.ListedCompanyEbit ?? (decimal)-999999.0;
                    break;
                case "上市企业净利润增速":
                    value = entity.ListedCompanyEbitYoy ?? (decimal)-999999.0;
                    break;
                case "获投企业数量":
                    value = entity.InvestedCompaniesCount ?? (decimal)-999999.0;
                    break;
                case "获投企业数量增速":
                    value = entity.InvestedCompaniesCountYoy ?? (decimal)-999999.0;
                    break;
                case "获投企业数量占比":
                    value = entity.InvestedCompaniesCountRatio ?? (decimal)-999999.0;
                    break;
                case "获投金额":
                    value = entity.InvestedCompaniesInvestedAmount ?? (decimal)-999999.0;
                    break;
                case "获投金额增速":
                    value = entity.InvestedCompaniesInvestedAmountYoy ?? (decimal)-999999.0;
                    break;
                case "获投金额占比":
                    value = entity.InvestedCompaniesInvestedAmountRatio ?? (decimal)-999999.0;
                    break;
                case "独角兽企业数量":
                    value = entity.UnicornsCount ?? (decimal)-999999.0;
                    break;
                case "独角兽企业数量占比":
                    value = entity.UnicornsCountRatio ?? (decimal)-999999.0;
                    break;
                case "独角兽企业估值":
                    value = entity.UnicornsEstimatedValue ?? (decimal)-999999.0;
                    break;
                case "独角兽企业估值占比":
                    value = entity.UnicornsEstimatedValueRatio ?? (decimal)-999999.0;
                    break;
                case "科技型中小企业数量":
                    value = entity.TechBasedSme ?? (decimal)-999999.0;
                    break;
                case "高新技术企业数量":
                    value = entity.HighTechEnterprises ?? (decimal)-999999.0;
                    break;
                case "国家级平台数量":
                    value = entity.NationalPlatforms ?? (decimal)-999999.0;
                    break;
                case "博士后科研工作站数量":
                    value = entity.PostdoctoralResearchStation ?? (decimal)-999999.0;
                    break;
                case "双一流院校数量":
                    value = entity.College211985 ?? (decimal)-999999.0;
                    break;
                case "在校研究生数量":
                    value = entity.GraduatesAtSchoolCount ?? (decimal)-999999.0;
                    break;
                case "高等院校在读学生数量":
                    value = entity.UndergraduatesAtSchoolCount ?? (decimal)-999999.0;
                    break;
                case "大专院校数量":
                    value = entity.UndergraduateAndAcademy ?? (decimal)-999999.0;
                    break;
                case "R&D支出占GDP比重":
                    value = null;
                    break;
                case "万人发明专利拥有量":
                    value = entity.InventionPatentsPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "上市企业研发费用":
                    value = entity.ListedCompaniesResearchBudget ?? (decimal)-999999.0;
                    break;
                case "上市企业研发投入占比":
                    value = entity.ListedCompaniesResearchInvest ?? (decimal)-999999.0;
                    break;
                case "工业用地平均出让价格":
                    value = entity.AverageIndustrialLandPrice ?? (decimal)-999999.0;
                    break;
                case "工业载体出租成本":
                    value = entity.AverageIndustrialRentRate ?? (decimal)-999999.0;
                    break;
                case "商业用地平均出让价格":
                    value = entity.AverageCommercialLandPrice ?? (decimal)-999999.0;
                    break;
                case "商办载体出租成本":
                    value = entity.AverageCommercialRentRate ?? (decimal)-999999.0;
                    break;
                case "甲级写字楼供应面积":
                    value = entity.AverageCommercialLandArea ?? (decimal)-999999.0;
                    break;
                case "平均产业载体成本":
                    value = decimal.Round((entity.AverageIndustrialRentRate ?? 0 + entity.AverageCommercialRentRate ?? 0) / 2, 2);
                    break;
                case "相对劳动力成本":
                    value = entity.RelativeLabourCost ?? (decimal)-999999.0;
                    break;
                case "普通劳动力平均年薪":
                    value = entity.OrdinaryLabourCost ?? (decimal)-999999.0;
                    break;
                case "水电气热平均成本":
                    value = entity.IndustrialAverageCost ?? (decimal)-999999.0;
                    break;
                case "轨道交通站点密度":
                    value = entity.RailwayStationCountRatio ?? (decimal)-999999.0;
                    break;
                case "每千人二三甲医院床位数":
                    value = entity.NumberOfBedsPerThousand ?? (decimal)-999999.0;
                    break;
                case "优质医院数量":
                    value = entity.HospitalCount ?? (decimal)-999999.0;
                    break;
                case "每十万人基础教育学校数量":
                    value = entity.NumberOfK12EducationSchoolsPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人国际学校数量":
                    value = entity.NumberOfInternationalSchoolsPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人高等级酒店数量":
                    value = entity.NumberOfHotelsPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人电影院数量":
                    value = entity.NumberOfCinemasPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人超市便利店数量":
                    value = entity.NumberOfSupermarketConvenienceStoresPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人星巴克数量":
                    value = entity.StarbucksPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人文化设施数量":
                    value = entity.NumberOfCultureFacilitiesPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "4A级以上景区数量":
                    value = entity.ScenicSpotCount ?? (decimal)-999999.0;
                    break;
                case "房价收入比":
                    value = entity.HousePriceIncomeRatio ?? (decimal)-999999.0;
                    break;
                case "房租收入比":
                    value = entity.RentToIncomeRatio ?? (decimal)-999999.0;
                    break;
                case "PM2.5年均浓度":
                    value = entity.AirQuality ?? (decimal)-999999.0;
                    break;
                case "本外币各项贷款余额占GDP比重":
                    value = entity.CreditSupportsTheRealEconomy ?? (decimal)-999999.0;
                    break;
                case "金融机构数量":
                    value = entity.FinancialCompanyCount ?? (decimal)-999999.0;
                    break;
                case "投资机构数量":
                    value = entity.InvestmentCompanyCount ?? (decimal)-999999.0;
                    break;
                case "政府引导基金总规模":
                    value = null;
                    break;
                case "城市租售比":
                    value = entity.RentToHousePriceRatio ?? (decimal)-999999.0;
                    break;
                case "劳动力产出效率":
                    value = entity.LabourOutputEfficiency ?? (decimal)-999999.0;
                    break;
                case "人口净流入率":
                    value = entity.PopulationNetInflow ?? (decimal)-999999.0;
                    break;
                case "单位GDP耗电量":
                    value = entity.UnitGdpElectricityConsumption ?? (decimal)-999999.0;
                    break;
                case "一般公共预算自给率":
                    value = entity.FiscalSelfSuppliment ?? (decimal)-999999.0;
                    break;
                case "产业投资性价比":
                    value = entity.IndustryInvestmentCostEffective ?? (decimal)-999999.0;
                    break;
                case "一般公共预算支出":
                    value = entity.FisicalBudgetExpenditure ?? (decimal)-999999.0;
                    break;
                case "实际利用外资":
                    value = entity.DirectUseOfForeignCapital ?? (decimal)-999999.0;
                    break;
                case "实际利用外资增速":
                    value = entity.DirectUseOfForeignCapitalYoy ?? (decimal)-999999.0;
                    break;
                case "全市居民人均消费支出":
                    value = entity.ResidentExpenditurePerCapita ?? (decimal)-999999.0;
                    break;
                case "新增就业人口":
                    value = entity.NewEmployment ?? (decimal)-999999.0;
                    break;
                case "新增就业人口比率":
                    value = entity.NewEmploymentRate ?? (decimal)-999999.0;
                    break;
                case "规上工业企业数量":
                    value = entity.LargeIndustrialEnterprisesCount ?? (decimal)-999999.0;
                    break;
                case "规上工业企业数量增速":
                    value = entity.LargeIndustrialCompanyCountYoy ?? (decimal)-999999.0;
                    break;
                case "规上工业企业总资产份额":
                    value = entity.LargeIndustrialCompanyTotalAssetRatio ?? (decimal)-999999.0;
                    break;
                case "规上工业企业平均资产":
                    value = entity.LargeIndustrialCompanyAverageAsset ?? (decimal)-999999.0;
                    break;
                case "规上工业企业总产值":
                    value = entity.LargeIndustrialCompanyTotalProduction ?? (decimal)-999999.0;
                    break;
                case "规上工业企业总产值增速":
                    value = entity.LargeIndustrialCompanyTotalProductionYoy ?? (decimal)-999999.0;
                    break;
                case "规上工业企业平均产值":
                    value = entity.LargeIndustrialCompanyAverageProduction ?? (decimal)-999999.0;
                    break;
                case "规上工业企业人均产值":
                    value = entity.LargeIndustrialCompanyProductionPerCapita ?? (decimal)-999999.0;
                    break;
                case "规上工业企业单位面积产值":
                    value = entity.LargeIndustrialCompanyUnitAreaProduction ?? (decimal)-999999.0;
                    break;
                case "规上工业企业工业增加值":
                    value = entity.LargeIndustrialCompanyValueAdded ?? (decimal)-999999.0;
                    break;
                case "规上工业企业总资产":
                    value = entity.LargeIndustrialEnterprisesAssets ?? (decimal)-999999.0;
                    break;
                case "规上工业企业员工总数":
                    value = entity.LargeEnterprisesStaffCount ?? (decimal)-999999.0;
                    break;
                case "第一产业增加值":
                    value = entity.PrimaryIndustryValueAdded ?? (decimal)-999999.0;
                    break;
                case "第一产业增加值增速":
                    value = entity.PrimaryIndustryValueAddedYoy ?? (decimal)-999999.0;
                    break;
                case "第二产业增加值":
                    value = entity.SecondaryIndustryValueAdded ?? (decimal)-999999.0;
                    break;
                case "第二产业增加值增速":
                    value = entity.SecondaryIndustryValueAddedYoy ?? (decimal)-999999.0;
                    break;
                case "第三产业增加值":
                    value = entity.TertiaryIndustryValueAdded ?? (decimal)-999999.0;
                    break;
                case "工业增加值":
                    value = entity.IndustrialValueAdded ?? (decimal)-999999.0;
                    break;
                case "工业增加值增速":
                    value = entity.IndustrialValueAddedYoy ?? (decimal)-999999.0;
                    break;
                case "第三产业增加值增速":
                    value = entity.TertiaryIndustryValueAddedYoy ?? (decimal)-999999.0;
                    break;
                case "全社会用电量":
                    value = entity.WholeSocietyElectricityConsumption ?? (decimal)-999999.0;
                    break;
                case "全社会用电量增速":
                    value = entity.WholeSocietyElectricityConsumptionYoy ?? (decimal)-999999.0;
                    break;
                case "工业用电量":
                    value = entity.IndustrialElectricityConsumption ?? (decimal)-999999.0;
                    break;
                case "本专科院校数量":
                    value = entity.UndergraduateAndAcademy ?? (decimal)-999999.0;
                    break;
                case "全市居民人均可支配收入":
                    value = entity.DisposableIncome ?? (decimal)-999999.0;
                    break;
                case "新增常住人口":
                    value = entity.NewPermenantResidents ?? (decimal)-999999.0;
                    break;
                case "平均房价":
                    value = entity.AvgHousePrice ?? (decimal)-999999.0;
                    break;
                case "普通劳动力平均月薪":
                    value = entity.OrdinaryLabourMonthlyCost ?? (decimal)-999999.0;
                    break;
                case "B型保税物流中心数量":
                    value = entity.BondedLogisticsCenterBAmount ?? (decimal)-999999.0;
                    break;
                case "海关特殊监管区数量":
                    value = entity.SpecialCustomsControllingZoneAmount ?? (decimal)-999999.0;
                    break;
                case "国家级先进制造业集群数量":
                    value = entity.NationalAdvancedManufacturingIndustryAmount ?? (decimal)-999999.0;
                    break;
                case "专精特新“小巨人”企业数量":
                    value = entity.SolidSmallMediumEnterprisesAmount ?? (decimal)-999999.0;
                    break;
                case "国家级科技企业孵化器数量":
                    value = entity.NationalTechBusinessIncubatorAmount ?? (decimal)-999999.0;
                    break;
                case "国家级经开区数量":
                    value = entity.NationalEcoDevelopmentZoneAmount ?? (decimal)-999999.0;
                    break;
                case "国家级高新区数量":
                    value = entity.NationalHighTechIndustrialDevelopmentZoneAmount ?? (decimal)-999999.0;
                    break;
                case "省级开发区数量":
                    value = entity.ProvincialDevelopmentZoneAmount ?? (decimal)-999999.0;
                    break;
                ///
                case "地方政府债务余额":
                    value = entity.LocalGovernmentDebt ?? (decimal)-999999.0;
                    break;
                case "本外币各项贷款余额":
                    value = entity.BankLoanBalance ?? (decimal)-999999.0;
                    break;
                case "航班起降架次":
                    value = entity.AirlineYearlyTakeoffLandingTimes ?? (decimal)-999999.0;
                    break;
                case "旅客列车车次总量":
                    value = entity.TrainYearlyDepartTimes ?? (decimal)-999999.0;
                    break;
                case "汽车客运站发出车次总量":
                    value = entity.BusYearlyDepartTimes ?? (decimal)-999999.0;
                    break;
                case "银行业金融机构法人数量":
                    value = entity.BankingFinancialInstitutionLegalEntityCount ?? (decimal)-999999.0;
                    break;
                case "银行业金融机构数量":
                    value = entity.BankingFinancialInstitutionCount ?? (decimal)-999999.0;
                    break;
                case "保险机构法人数量":
                    value = entity.InsuranceInstitutionLegalEntityCount ?? (decimal)-999999.0;
                    break;
                case "保险机构数量":
                    value = entity.InsuranceInstitutionCount ?? (decimal)-999999.0;
                    break;
                case "证券公司法人数量":
                    value = entity.SecurityCompanyLegalEntityCount ?? (decimal)-999999.0;
                    break;
                case "期货公司法人数量":
                    value = entity.FuturesCompanyLegalEntityCount ?? (decimal)-999999.0;
                    break;
                case "公募基金管理机构法人数量":
                    value = entity.PublicFundInstitutionLegalEntityCount ?? (decimal)-999999.0;
                    break;
                case "平均住房租金":
                    value = entity.AvgRent ?? (decimal)-999999.0;
                    break;
                case "城镇居民人均可支配收入":
                    value = entity.UrbanResidentsDisposableIncome ?? (decimal)-999999.0;
                    break;
                case "城镇居民人均消费支出":
                    value = entity.UrbanResidentExpenditurePerCapita ?? (decimal)-999999.0;
                    break;
                case "二三甲医院床位数量":
                    value = entity.HospitalBedsCount ?? (decimal)-999999.0;
                    break;
                case "基础教育学校数量":
                    value = entity.K12Count ?? (decimal)-999999.0;
                    break;
                case "国际学校数量":
                    value = entity.InternationSchoolCount ?? (decimal)-999999.0;
                    break;
                case "地铁站点数量":
                    value = entity.RailwayStationCount ?? (decimal)-999999.0;
                    break;
                case "超市便利店数量":
                    value = entity.SupermarketAndStoreCount ?? (decimal)-999999.0;
                    break;
                case "高等级酒店数量":
                    value = entity.HotelCount ?? (decimal)-999999.0;
                    break;
                case "星巴克数量":
                    value = entity.StarbucksCount ?? (decimal)-999999.0;
                    break;
                case "电影院数量":
                    value = entity.CinemaCount ?? (decimal)-999999.0;
                    break;
                case "文化设施数量":
                    value = entity.CultureFacilitiesCount ?? (decimal)-999999.0;
                    break;
                case "每十万人4A级以上景区数量":
                    value = entity.ScenicSpotCountPer100kPpl ?? (decimal)-999999.0;
                    break;
                case "平均购房价格":
                    value = entity.AvgHousePrice ?? (decimal)-999999.0;
                    break;
                case "地方政府负债率":
                    value = entity.LocalGovernmentDebtPressureByGdp ?? (decimal)-999999.0;
                    break;
                case "规上工业增加值":
                    value = entity.LargeIndustrialCompanyValueAdded ?? (decimal)-999999.0;
                    break;
                case "保税物流中心（B型）数量":
                    value = entity.BondedLogisticsCenterBAmount ?? (decimal)-999999.0;
                    break;
                case "国家重点实验室数量":
                    value = entity.NationalResearchLabs ?? (decimal)-999999.0;
                    break;
                case "国家企业技术中心数量":
                    value = entity.NationalEnterpriseTechCenters ?? (decimal)-999999.0;
                    break;
                case "普通高等学校数量":
                    value = entity.UndergraduateAndAcademy ?? (decimal)-999999.0;
                    break;
                case "二三甲医院数量":
                    value = entity.HospitalCount ?? (decimal)-999999.0;
                    break;
                case "获投企业融资额":
                    value = entity.InvestedCompaniesInvestedAmount ?? (decimal)-999999.0;
                    break;

                //20220129insert
                case "年均空气质量指数(AQI)":
                    value = entity.Aqi ?? (decimal)-999999.0;
                    break;
                case "4A级景区数量":
                    value = entity.NumberOf4a ?? (decimal)-999999.0;
                    break;
                case "5A级景区数量":
                    value = entity.NumberOf5a ?? (decimal)-999999.0;
                    break;
                case "城镇居民消费意愿指数":
                    value = entity.ConsumptionIntentionIndexTown ?? (decimal)-999999.0;
                    break;
                case "港口货物吞吐量":
                    value = entity.PortGoodsCapacity ?? (decimal)-999999.0;
                    break;
                case "港口集装箱吞吐量":
                    value = entity.PortContainerCapacity ?? (decimal)-999999.0;
                    break;
                //已存在但归于新增
                /*case "公募基金管理机构法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "货物运输周转量":
                    value = entity.GoodsTurnoverTotalAmount ?? (decimal)-999999.0;
                    break;
                case "货物运输总量":
                    value = entity.GoodsTransportTotalAmount ?? (decimal)-999999.0;
                    break;
                case "机场货邮吞吐量":
                    value = entity.AirportGoodsCapacity ?? (decimal)-999999.0;
                    break;
                case "机场旅客吞吐量":
                    value = entity.AirportPassengerCapacity ?? (decimal)-999999.0;
                    break;
                case "建成区绿化覆盖率（市辖区）":
                    value = entity.BuildUpGreenCoverageCity ?? (decimal)-999999.0;
                    break;
                case "建成区面积（市辖区）":
                    value = entity.BuildUpAreaCity ?? (decimal)-999999.0;
                    break;
                //当前数据库无该指标，但excel归于更新指标，按新增指标处理
                ///
                /*case "旅客列车车次总量":
                    value = entity.InvestedCompaniesInvestedAmount ?? (decimal)-999999.0;
                    break;*/
                case "绿地面积（市辖区）":
                    value = entity.BuildUpGreenLandArea ?? (decimal)-999999.0;
                    break;
                case "每千人医疗机构床位数量":
                    value = entity.BedsPerThousandInHospitalCount ?? (decimal)-999999.0;
                    break;
                case "普通小学数量":
                    value = entity.NumberOfPrimarySchool ?? (decimal)-999999.0;
                    break;
                case "普通中学数量":
                    value = entity.NumberOfMiddleSchool ?? (decimal)-999999.0;
                    break;
                //已存在但归于新增
                /*case "期货公司法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "全市居民消费意愿指数":
                    value = entity.ConsumptionIntentionIndexCity ?? (decimal)-999999.0;
                    break;
                case "双一流学科数量":
                    value = entity.DoubleFirstClassDisciplineCount ?? (decimal)-999999.0;
                    break;
                case "水资源总量":
                    value = entity.TotalWaterResource ?? (decimal)-999999.0;
                    break;
                ///
                case "私募基金管理人数量":
                    value = entity.PrivateFundManagerCount ?? (decimal)-999999.0;
                    break;
                case "医疗机构床位数量":
                    value = entity.NumberOfBedsInHospital ?? (decimal)-999999.0;
                    break;
                case "医疗机构数量":
                    value = entity.NumberOfMedicalInstitution ?? (decimal)-999999.0;
                    break;
                //已存在但归于新增
                /*case "银行业金融机构法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                //已存在但归于新增
                /*case "银行业金融机构数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "幼儿园数量":
                    value = entity.NumberOfKindergarden ?? (decimal)-999999.0;
                    break;
                //已存在但归于新增
                /*case "证券公司法人数量":
                    value = (decimal)-999999.0;;
                    break;*/
                case "每十万人地铁站点数量":
                    value = entity.NumberOfRailwayStationPer10kPpl ?? (decimal)-999999.0;
                    break;
            }


            //如果value是空就返回0；该方法内的null代表数据库没有对应的该字段。后期可以有相应的不同处理。
            value ??= (decimal)-999999.0;

            return value;
        }
        public static string GetIndexName(string indicatorClass3Name)
        {
            string indexName = "";
            switch (indicatorClass3Name)
            {
                case "GDP总量":
                    indexName = "GdpRatio";
                    break;
                case "单位面积GDP":
                    indexName = "GdpPerUnitAreaRatio";
                    break;
                case "人均GDP":
                    indexName = "GdpPerCapitaPermenantResidentRatio";
                    break;
                case "GDP增速":
                    indexName = "GdpYoyRatio";
                    break;
                case "固定资产投资":
                    indexName = "FixedAssetsInvestmentRatio";
                    break;
                case "进出口总额":
                    indexName = "ImportAndExportRatio";
                    break;
                case "社会消费品零售总额":
                    indexName = "ConsumerGoodsRetailSalesRatio";
                    break;
                case "一般公共预算收入":
                    indexName = "FisicalBudgetRevenueRatio";
                    break;
                case "地方政府债务压力":
                    indexName = "LocalGovernmentDebtPressureByGdpRatio";
                    break;
                case "城镇化率":
                    indexName = "";
                    break;
                case "行政区域土地面积（全市）":
                    indexName = "LandSizeRatio";
                    break;
                case "建成区比例":
                    indexName = "";
                    break;
                case "开发强度":
                    indexName = "";
                    break;
                case "常住人口":
                    indexName = "PermenantResidentsRatio";
                    break;
                case "户籍人口":
                    indexName = "HouseholdPopulationRatio";
                    break;
                case "常住人口增速":
                    indexName = "PermenantResidentsYoyRatio";
                    break;
                case "户籍人口增速":
                    indexName = "HouseholdPopulationYoyRatio";
                    break;
                case "常住人口密度":
                    indexName = "PermanentPopulationDensityRatio";
                    break;
                case "户籍人口密度":
                    indexName = "HouseholdDensityRatio";
                    break;
                case "注册企业数量":
                    indexName = "RegisteredCompaniesRatio";
                    break;
                case "注册企业数量增速":
                    indexName = "RegisteredCompaniesYoyRatio";
                    break;
                case "注册企业密度":
                    indexName = "RegisteredBusinessDensityRatio";
                    break;
                case "内部交通联系度":
                    indexName = "InternalTrafficConnectionRatio";
                    break;
                case "对外交通联系度":
                    indexName = "ExternalTrafficConnectionRatio";
                    break;
                case "二等站及以上铁路车站":
                    indexName = "HighLevelRailwayStationCountRatio";
                    break;
                case "干线高速出入口数量":
                    indexName = "HighwayEntriesCountRatio";
                    break;
                case "物流站点数量":
                    indexName = "LogisticsStationCountRatio";
                    break;
                case "规上企业数量":
                    indexName = "LargeCompanyCountRatio";
                    break;
                case "规上企业数量增速":
                    indexName = "LargeCompanyCountYoyRatio";
                    break;
                case "规上企业总资产":
                    indexName = "LargeCompanyTotalAssetRatio";
                    break;
                case "规上企业总资产份额":
                    indexName = "LargeCompanyTotalAssetRatioRatio";
                    break;
                case "规上企业平均资产":
                    indexName = "LargeCompanyAverageAssetRatio";
                    break;
                case "规上企业总产值":
                    indexName = "LargeCompanyTotalProductionRatio";
                    break;
                case "规上企业总产值增速":
                    indexName = "LargeCompanyTotalProductionYoyRatio";
                    break;
                case "规上企业平均产值":
                    indexName = "LargeCompanyAverageProductionRatio";
                    break;
                case "规上企业人均产值":
                    indexName = "LargeCompanyProductionPerCapitaRatio";
                    break;
                case "规上企业单位面积产值":
                    indexName = "LargeCompanyUnitAreaProductionRatio";
                    break;
                case "规上工业增加值":
                    indexName = "LargeIndustrialCompanyValueAddedRatio";
                    break;
                case "上市企业数量":
                    indexName = "ListedCompanyCountRatio";
                    break;
                case "企业上市率":
                    indexName = "ListedRateRatio";
                    break;
                case "上市企业市值":
                    indexName = "ListedCompanyMarketValueRatio";
                    break;
                case "上市企业营业收入":
                    indexName = "ListedCompanyIncomeRatio";
                    break;
                case "上市企业营业收入增速":
                    indexName = "ListedCompanyIncomeYoyRatio";
                    break;
                case "上市企业净利润":
                    indexName = "ListedCompanyEbitRatio";
                    break;
                case "上市企业净利润增速":
                    indexName = "ListedCompanyEbitYoyRatio";
                    break;
                case "获投企业数量":
                    indexName = "InvestedCompaniesCountRatio";
                    break;
                case "获投企业数量增速":
                    indexName = "InvestedCompaniesCountYoyRatio";
                    break;
                case "获投企业数量占比":
                    indexName = "InvestedCompaniesCountRatioRatio";
                    break;
                case "获投金额":
                    indexName = "InvestedCompaniesInvestedAmountRatio";
                    break;
                case "获投金额增速":
                    indexName = "InvestedCompaniesInvestedAmountYoyRatio";
                    break;
                case "获投金额占比":
                    indexName = "InvestedCompaniesInvestedAmountRatioRatio";
                    break;
                case "独角兽企业数量":
                    indexName = "UnicornsCountRatio";
                    break;
                case "独角兽企业数量占比":
                    indexName = "UnicornsCountRatioRatio";
                    break;
                case "独角兽企业估值":
                    indexName = "UnicornsEstimatedValueRatio";
                    break;
                case "独角兽企业估值占比":
                    indexName = "UnicornsEstimatedValueRatioRatio";
                    break;
                case "科技型中小企业数量":
                    indexName = "TechBasedSmeRatio";
                    break;
                case "高新技术企业数量":
                    indexName = "HighTechEnterprisesRatio";
                    break;
                case "国家级平台数量":
                    indexName = "NationalPlatformsRatio";
                    break;
                case "博士后科研工作站数量":
                    indexName = "PostdoctoralResearchStationRatio";
                    break;
                case "双一流院校数量":
                    indexName = "College211985Ratio";
                    break;
                case "在校研究生数量":
                    indexName = "GraduatesAtSchoolCountRatio";
                    break;
                case "高等院校在读学生数量":
                    indexName = "UndergraduatesAtSchoolCountRatio";
                    break;
                case "大专院校数量":
                    indexName = "UndergraduateAndAcademyRatio";
                    break;
                case "R&D支出占GDP比重":
                    indexName = "";
                    break;
                case "万人发明专利拥有量":
                    indexName = "InventionPatentsPer10kPplRatio";
                    break;
                case "上市企业研发费用":
                    indexName = "ListedCompaniesResearchBudgetRatio";
                    break;
                case "上市企业研发投入占比":
                    indexName = "ListedCompaniesResearchInvestRatio";
                    break;
                case "工业用地平均出让价格":
                    indexName = "AverageIndustrialLandPriceRatio";
                    break;
                case "工业载体出租成本":
                    indexName = "AverageIndustrialRentRateRatio";
                    break;
                case "商业用地平均出让价格":
                    indexName = "AverageCommercialLandPriceRatio";
                    break;
                case "商办载体出租成本":
                    indexName = "AverageCommercialRentRateRatio";
                    break;
                case "甲级写字楼供应面积":
                    indexName = "AverageCommercialLandAreaRatio";
                    break;
                case "平均产业载体成本":
                    indexName = "";
                    break;
                case "相对劳动力成本":
                    indexName = "RelativeLabourCostRatio";
                    break;
                case "普通劳动力平均年薪":
                    indexName = "OrdinaryLabourCostRatio";
                    break;
                case "水电气热平均成本":
                    indexName = "IndustrialAverageCostRatio";
                    break;
                case "轨道交通站点密度":
                    indexName = "RailwayStationCountRatioRatio";
                    break;
                case "每千人二三甲医院床位数":
                    indexName = "NumberOfBedsPerThousandRatio";
                    break;
                case "优质医院数量":
                    indexName = "HospitalCountRatio";
                    break;
                case "每十万人基础教育学校数量":
                    indexName = "NumberOfK12EducationSchoolsPer10kPplRatio";
                    break;
                case "每十万人国际学校数量":
                    indexName = "NumberOfInternationalSchoolsPer10kPplRatio";
                    break;
                case "每十万人高等级酒店数量":
                    indexName = "NumberOfHotelsPer10kPplRatio";
                    break;
                case "每十万人电影院数量":
                    indexName = "NumberOfCinemasPer10kPplRatio";
                    break;
                case "每十万人超市便利店数量":
                    indexName = "NumberOfSupermarketConvenienceStoresPer10kPplRatio";
                    break;
                case "每十万人星巴克数量":
                    indexName = "StarbucksPer10kPplRatio";
                    break;
                case "每十万人文化设施数量":
                    indexName = "NumberOfCultureFacilitiesPer10kPplRatio";
                    break;
                case "每十万人4A级以上景区数量":
                    indexName = "ScenicSpotCountPer100kPplRatio";
                    break;
                case "房价收入比":
                    indexName = "HousePriceIncomeRatioRatio";
                    break;
                case "房租收入比":
                    indexName = "RentToIncomeRatioRatio";
                    break;
                case "PM2.5年均浓度":
                    indexName = "AirQualityRatio";
                    break;
                case "本外币各项贷款余额占GDP比重":
                    indexName = "CreditSupportsTheRealEconomyRatio";
                    break;
                case "金融机构数量":
                    indexName = "FinancialCompanyCountRatio";
                    break;
                case "投资机构数量":
                    indexName = "InvestmentCompanyCountRatio";
                    break;
                case "政府引导基金总规模":
                    indexName = "";
                    break;
                case "城市租售比":
                    indexName = "RentToHousePriceRatioRatio";
                    break;
                case "劳动力产出效率":
                    indexName = "LabourOutputEfficiencyRatio";
                    break;
                case "人口净流入率":
                    indexName = "PopulationNetInflowRatio";
                    break;
                case "一般公共预算自给率":
                    indexName = "FiscalSelfSupplimentRatio";
                    break;
                case "产业投资性价比":
                    indexName = "IndustryInvestmentCostEffectiveRatio";
                    break;
                case "一般公共预算支出":
                    indexName = "FisicalBudgetExpenditureRatio";
                    break;
                case "实际利用外资":
                    indexName = "DirectUseOfForeignCapitalRatio";
                    break;
                case "实际利用外资增速":
                    indexName = "DirectUseOfForeignCapitalYoyRatio";
                    break;
                case "全市居民人均消费支出":
                    indexName = "ResidentExpenditurePerCapitaRatio";
                    break;
                case "新增就业人口":
                    indexName = "NewEmploymentRatio";
                    break;
                case "新增就业人口比率":
                    indexName = "NewEmploymentRateRatio";
                    break;
                case "规上工业企业数量":
                    indexName = "LargeIndustrialEnterprisesCountRatio";
                    break;
                case "规上工业企业数量增速":
                    indexName = "LargeIndustrialCompanyCountYoyRatio";
                    break;
                case "规上工业企业总资产份额":
                    indexName = "LargeIndustrialCompanyTotalAssetRatioRatio";
                    break;
                case "规上工业企业平均资产":
                    indexName = "LargeIndustrialCompanyAverageAssetRatio";
                    break;
                case "规上工业企业总产值":
                    indexName = "LargeIndustrialCompanyTotalProductionRatio";
                    break;
                case "规上工业企业总产值增速":
                    indexName = "LargeIndustrialCompanyTotalProductionYoyRatio";
                    break;
                case "规上工业企业平均产值":
                    indexName = "LargeIndustrialCompanyAverageProductionRatio";
                    break;
                case "规上工业企业人均产值":
                    indexName = "LargeIndustrialCompanyProductionPerCapitaRatio";
                    break;
                case "规上工业企业单位面积产值":
                    indexName = "LargeIndustrialCompanyUnitAreaProductionRatio";
                    break;
                case "规上工业企业工业增加值":
                    indexName = "LargeIndustrialCompanyValueAddedRatio";
                    break;
                case "规上工业企业总资产":
                    indexName = "LargeIndustrialEnterprisesAssetsRatio";
                    break;
                case "规上工业企业员工总数":
                    indexName = "LargeEnterprisesStaffCountRatio";
                    break;
                case "第一产业增加值":
                    indexName = "PrimaryIndustryValueAddedRatio";
                    break;
                case "第一产业增加值增速":
                    indexName = "PrimaryIndustryValueAddedYoyRatio";
                    break;
                case "第二产业增加值":
                    indexName = "SecondaryIndustryValueAddedRatio";
                    break;
                case "第二产业增加值增速":
                    indexName = "SecondaryIndustryValueAddedYoyRatio";
                    break;
                case "第三产业增加值":
                    indexName = "TertiaryIndustryValueAddedRatio";
                    break;
                case "工业增加值":
                    indexName = "IndustrialValueAddedRatio";
                    break;
                case "工业增加值增速":
                    indexName = "IndustrialValueAddedYoyRatio";
                    break;
                case "第三产业增加值增速":
                    indexName = "TertiaryIndustryValueAddedYoyRatio";
                    break;
                case "全社会用电量":
                    indexName = "WholeSocietyElectricityConsumptionRatio";
                    break;
                case "全社会用电量增速":
                    indexName = "WholeSocietyElectricityConsumptionYoyRatio";
                    break;
                case "工业用电量":
                    indexName = "IndustrialElectricityConsumptionRatio";
                    break;
                case "本专科院校数量":
                    indexName = "UndergraduateAndAcademyRatio";
                    break;
                case "全市居民人均可支配收入":
                    indexName = "DisposableIncomeRatio";
                    break;
                case "新增常住人口":
                    indexName = "NewPermenantResidentsRatio";
                    break;
                case "单位GDP耗电量":
                    indexName = "UnitGdpElectricityConsumptionRatio";
                    break;
                case "国家企业技术中心数量":
                    indexName = "NationalEnterpriseTechCentersRatio";
                    break;
                case "国家重点实验室数量":
                    indexName = "NationalResearchLabsRatio";
                    break;
                case "保税物流中心（B型）数量":
                    indexName = "BondedLogisticsCenterBAmountRatio";
                    break;
                case "海关特殊监管区数量":
                    indexName = "SpecialCustomsControllingZoneAmountRatio";
                    break;
                case "国家级先进制造业集群数量":
                    indexName = "NationalAdvancedManufacturingIndustryAmountRatio";
                    break;
                case "专精特新“小巨人”企业数量":
                    indexName = "SolidSmallMediumEnterprisesAmountRatio";
                    break;
                case "国家级科技企业孵化器数量":
                    indexName = "NationalTechBusinessIncubatorAmountRatio";
                    break;
                case "国家级经开区数量":
                    indexName = "NationalEcoDevelopmentZoneAmountRatio";
                    break;
                case "国家级高新区数量":
                    indexName = "NationalHighTechIndustrialDevelopmentZoneAmountRatio";
                    break;
                case "省级开发区数量":
                    indexName = "ProvincialDevelopmentZoneAmountRatio";
                    break;
                case "地方政府债务余额":
                    indexName = "LocalGovernmentDebtRatio";
                    break;
                case "银行贷款余额":
                    indexName = "BankLoanBalanceRatio";
                    break;
                case "航空班次":
                    indexName = "AirlineYearlyTakeoffLandingTimesRatio";
                    break;
                case "旅客列车车次总量":
                    indexName = "TrainYearlyDepartTimesRatio";
                    break;
                case "汽车客运站发出车次总量":
                    indexName = "BusYearlyDepartTimesRatio";
                    break;
                case "银行业金融机构法人数量":
                    indexName = "BankingFinancialInstitutionLegalEntityCountRatio";
                    break;
                case "银行业金融机构数量":
                    indexName = "BankingFinancialInstitutionCountRatio";
                    break;
                case "保险机构法人数量":
                    indexName = "InsuranceInstitutionLegalEntityCountRatio";
                    break;
                case "保险机构数量":
                    indexName = "InsuranceInstitutionCountRatio";
                    break;
                case "证券公司法人数量":
                    indexName = "SecurityCompanyLegalEntityCountRatio";
                    break;
                case "期货公司法人数量":
                    indexName = "FuturesCompanyLegalEntityCountRatio";
                    break;
                case "公募基金管理机构法人数量":
                    indexName = "PublicFundInstitutionLegalEntityCountRatio";
                    break;
                case "平均住房租金":
                    indexName = "AvgRentRatio";
                    break;
                case "城镇居民人均可支配收入":
                    indexName = "UrbanResidentsDisposableIncomeRatio";
                    break;
                case "城镇居民人均消费支出":
                    indexName = "UrbanResidentExpenditurePerCapitaRatio";
                    break;
                case "二三甲医院床位数量":
                    indexName = "HospitalBedsCountRatio";
                    break;
                case "K12教育学校数量":
                    indexName = "K12CountRatio";
                    break;
                case "国际学校数量":
                    indexName = "InternationSchoolCountRatio";
                    break;
                case "地铁站点数量":
                    indexName = "RailwayStationCountRatio";
                    break;
                case "超市便利店数量":
                    indexName = "SupermarketAndStoreCountRatio";
                    break;
                case "高等级酒店数量":
                    indexName = "HotelCountRatio";
                    break;
                case "星巴克数量":
                    indexName = "StarbucksCountRatio";
                    break;
                case "电影院数量":
                    indexName = "CinemaCountRatio";
                    break;
                case "文化设施数量":
                    indexName = "CultureFacilitiesCountRatio";
                    break;
                case "平均购房价格":
                    indexName = "AvgHousePriceRatio";
                    break;
                case "年均空气质量指数(AQI)":
                    indexName = "AqiRatio";
                    break;
                case "建成区绿化覆盖率（市辖区）":
                    indexName = "BuildUpGreenCoverageCityRatio";
                    break;
                case "水资源总量":
                    indexName = "TotalWaterResourceRatio";
                    break;
                case "建成区面积（市辖区）":
                    indexName = "BuildUpAreaCityRatio";
                    break;
                case "双一流学科数量":
                    indexName = "DoubleFirstClassDisciplineCountRatio";
                    break;
                case "绿地面积（市辖区）":
                    indexName = "BuildUpGreenLandAreaRatio";
                    break;
                case "医疗机构数量":
                    indexName = "NumberOfMedicalInstitutionRatio";
                    break;
                case "医疗机构床位数量":
                    indexName = "NumberOfBedsInHospitalRatio";
                    break;
                case "幼儿园数量":
                    indexName = "NumberOfKindergardenRatio";
                    break;
                case "普通小学数量":
                    indexName = "NumberOfPrimarySchoolRatio";
                    break;
                case "普通中学数量":
                    indexName = "NumberOfMiddleSchoolRatio";
                    break;
                case "5A级景区数量":
                    indexName = "NumberOf5aRatio";
                    break;
                case "4A级景区数量":
                    indexName = "NumberOf4aRatio";
                    break;
                case "全市居民消费意愿指数":
                    indexName = "ConsumptionIntentionIndexCityRatio";
                    break;
                case "城镇居民消费意愿指数":
                    indexName = "ConsumptionIntentionIndexTownRatio";
                    break;
                case "机场旅客吞吐量":
                    indexName = "AirportPassengerCapacityRatio";
                    break;
                case "机场货邮吞吐量":
                    indexName = "AirportGoodsCapacityRatio";
                    break;
                case "港口货物吞吐量":
                    indexName = "PortGoodsCapacityRatio";
                    break;
                case "港口集装箱吞吐量":
                    indexName = "PortContainerCapacityRatio";
                    break;
                case "货物运输总量":
                    indexName = "GoodsTransportTotalAmountRatio";
                    break;
                case "货物运输周转量":
                    indexName = "GoodsTurnoverTotalAmountRatio";
                    break;
                case "每千人医疗机构床位数量":
                    indexName = "BedsPerThousandInHospitalCountRatio";
                    break;
                case "获投企业融资额":
                    indexName = "InvestedCompaniesInvestedAmountRatio";
                    break;
                case "本外币各项贷款余额":
                    indexName = "BankLoanBalanceRatio";
                    break;
                case "普通高等学校数量":
                    indexName = "UndergraduateAndAcademyRatio";
                    break;
                case "航班起降架次":
                    indexName = "AirlineYearlyTakeoffLandingTimesRatio";
                    break;
                case "二三甲医院数量":
                    indexName = "HospitalCountRatio";
                    break;
                case "基础教育学校数量":
                    indexName ="K12CountRatio";
                    break;
                case "每十万人地铁站点数量":
                    indexName = "NumberOfRailwayStationPer10kPplRatio";
                    break;
                case "私募基金管理人数量":
                    indexName = "PrivateFundManagerCountRatio";
                    break;
                case "地方政府负债率":
                    indexName = "LocalGovernmentDebtPressureByGdpRatio";
                    break;
            }

            //如果value是空就返回0；该方法内的null代表数据库没有对应的该字段。后期可以有相应的不同处理。
            indexName ??= "";

            return indexName;
        }
    }
}
