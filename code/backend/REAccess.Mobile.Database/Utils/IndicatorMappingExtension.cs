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
                case "辖区土地面积":
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
                case "高等级铁路车站":
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
                case "商办用地平均出让价格":
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
                case "每十万人K12教育学校数量":
                    value = entity.NumberOfK12EducationSchoolsPer10kPplRatio ?? 0;
                    break;
                case "每十万人国际学校数量":
                    value = entity.NumberOfInternationalSchoolsPer10kPplRatio ?? 0;
                    break;
                case "每十万人国际高等级酒店数量":
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
                case "空气质量指数":
                    value = entity.AirQualityRatio ?? 0;
                    break;
                case "信贷对经济支撑度":
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
                case "财政自给度":
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
                case "银行贷款余额":
                    value = entity.BankLoanBalanceRatio ?? 0;
                    break;
                case "航空班次":
                    value = entity.AirlineYearlyTakeoffLandingTimesRatio ?? 0;
                    break;
                case "高铁班次":
                    value = entity.TrainYearlyDepartTimesRatio ?? 0;
                    break;
                case "公路班次":
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
                case "K12教育学校数量":
                    value = entity.K12CountRatio ?? 0;
                    break;
                case "国际学校数量":
                    value = entity.InternationSchoolCountRatio ?? 0;
                    break;
                case "轨道交通站点数量":
                    value = entity.RailwayStationCountRatio ?? 0;
                    break;
                case "超市便利店数量":
                    value = entity.SupermarketAndStoreCountRatio ?? 0;
                    break;
                case "国际高等级酒店数量":
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
                case "辖区土地面积":
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
                case "高等级铁路车站":
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
                case "商办用地平均出让价格":
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
                case "每十万人K12教育学校数量":
                    value = entity.NumberOfK12EducationSchoolsPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人国际学校数量":
                    value = entity.NumberOfInternationalSchoolsPer10kPpl ?? (decimal)-999999.0;
                    break;
                case "每十万人国际高等级酒店数量":
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
                case "空气质量指数":
                    value = entity.AirQuality ?? (decimal)-999999.0;
                    break;
                case "信贷对经济支撑度":
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
                case "财政自给度":
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
                case "银行贷款余额":
                    value = entity.BankLoanBalance ?? (decimal)-999999.0;
                    break;
                case "航空班次":
                    value = entity.AirlineYearlyTakeoffLandingTimes ?? (decimal)-999999.0;
                    break;
                case "高铁班次":
                    value = entity.TrainYearlyDepartTimes ?? (decimal)-999999.0;
                    break;
                case "公路班次":
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
                case "K12教育学校数量":
                    value = entity.K12Count ?? (decimal)-999999.0;
                    break;
                case "国际学校数量":
                    value = entity.InternationSchoolCount ?? (decimal)-999999.0;
                    break;
                case "轨道交通站点数量":
                    value = entity.RailwayStationCount ?? (decimal)-999999.0;
                    break;
                case "超市便利店数量":
                    value = entity.SupermarketAndStoreCount ?? (decimal)-999999.0;
                    break;
                case "国际高等级酒店数量":
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
            }


            //如果value是空就返回0；该方法内的null代表数据库没有对应的该字段。后期可以有相应的不同处理。
            value ??= 0;

            return value;
        }

    }
}
