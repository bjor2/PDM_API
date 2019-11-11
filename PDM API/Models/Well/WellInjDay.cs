using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("WELL_INJ_DAY", Schema = "PDM")]
    public class WellInjDay
    {
        [JsonProperty("PROD_MONTH")]
        public DateTime? PROD_MONTH { get; set; }
        [JsonProperty("PROD_MONTH_SHORT")]
        public string PROD_MONTH_SHORT { get { return PROD_MONTH != null ? ((DateTime)PROD_MONTH).ToString("yyyy-MM-dd") : null; } }

        [JsonProperty("PROD_DAY")]
        public DateTime PROD_DAY { get; set; }
        [JsonProperty("PROD_DAY_SHORT")]
        public string PROD_DAY_SHORT { get { return PROD_DAY.ToString("yyyy-MM-dd"); } }

        [JsonProperty("COUNTRY")]
        public string COUNTRY { get; set; }
        [JsonProperty("BA_CODE")]
        public string BA_CODE { get; set; }
        [JsonProperty("RA_CODE")]
        public string RA_CODE { get; set; }
        [JsonProperty("RU_CODE")]
        public string RU_CODE { get; set; }
        [JsonProperty("FCTY_CODE")]
        public string FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public string GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public string GOV_FIELD_NAME { get; set; }
        [JsonProperty("COMMERCIAL_ENTITY")]
        public string COMMERCIAL_ENTITY { get; set; }
        [JsonProperty("GOV_LICENSE_CODE")]
        public int? GOV_LICENSE_CODE { get; set; }
        [JsonProperty("WELL_NAME")]
        public string WELL_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public string WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public string WELL_UWI { get; set; }
        [JsonProperty("WELL_HOOKUP")]
        public string WELL_HOOKUP { get; set; }
        [JsonProperty("SUBSEA_TEMPLATE_CODE")]
        public string SUBSEA_TEMPLATE_CODE { get; set; }
        [JsonProperty("FLOWLINE")]
        public string FLOWLINE { get; set; }
        [JsonProperty("WELL_CLASS")]
        public string WELL_CLASS { get; set; }
        [JsonProperty("WELL_TYPE")]
        public string WELL_TYPE { get; set; }
        [JsonProperty("WELL_ID_EC")]
        public string WELL_ID_EC { get; set; }
        [JsonProperty("INJ_TYPE")]
        public string INJ_TYPE { get; set; }
        [JsonProperty("WELL_STATUS")]
        public string WELL_STATUS { get; set; }
        [JsonProperty("PROD_METHOD")]
        public string PROD_METHOD { get; set; }
        [JsonProperty("DETAILED_PROD_METHOD")]
        public string DETAILED_PROD_METHOD { get; set; }
        [JsonProperty("CALC_GAS_INJ_METHOD")]
        public string CALC_GAS_INJ_METHOD { get; set; }
        [JsonProperty("CALC_WATER_INJ_METHOD")]
        public string CALC_WATER_INJ_METHOD { get; set; }
        [JsonProperty("CALC_CO2_INJ_METHOD")]
        public string CALC_CO2_INJ_METHOD { get; set; }
        [JsonProperty("ON_STREAM_HRS")]
        public double? ON_STREAM_HRS { get; set; }
        [JsonProperty("CHOKE_OPENING")]
        public double? CHOKE_OPENING { get; set; }
        [JsonProperty("CHOKE_UOM")]
        public string CHOKE_UOM { get; set; }
        [JsonProperty("CHOKE_OPENING_2")]
        public double? CHOKE_OPENING_2 { get; set; }
        [JsonProperty("CHOKE_UOM_02")]
        public string CHOKE_UOM_02 { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public string CHOKE_CODE { get; set; }
        [JsonProperty("WH_PRESS_BARG")]
        public double? WH_PRESS_BARG { get; set; }
        [JsonProperty("WH_TEMP_C")]
        public double? WH_TEMP_C { get; set; }
        [JsonProperty("ANNULUS_PRESS_BARG")]
        public double? ANNULUS_PRESS_BARG { get; set; }
        [JsonProperty("ANNULUS_TEMP_C")]
        public double? ANNULUS_TEMP_C { get; set; }
        [JsonProperty("DH_PRESS_BARG")]
        public double? DH_PRESS_BARG { get; set; }
        [JsonProperty("DH_TEMP_C")]
        public double? DH_TEMP_C { get; set; }
        [JsonProperty("WH_USC_PRESS_BARG")]
        public double? WH_USC_PRESS_BARG { get; set; }
        [JsonProperty("WH_USC_TEMP_C")]
        public double? WH_USC_TEMP_C { get; set; }
        [JsonProperty("WH_DSC_PRESS_BARG")]
        public double? WH_DSC_PRESS_BARG { get; set; }
        [JsonProperty("WH_DSC_TEMP_C")]
        public double? WH_DSC_TEMP_C { get; set; }
        [JsonProperty("DP_TUBING_BARA")]
        public double? DP_TUBING_BARA { get; set; }
        [JsonProperty("DP_CHOKE_BARA")]
        public double? DP_CHOKE_BARA { get; set; }
        [JsonProperty("ALLOC_GAS_INJ_VOL_SM3")]
        public double? ALLOC_GAS_INJ_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_WATER_INJ_VOL_M3")]
        public double? ALLOC_WATER_INJ_VOL_M3 { get; set; }
        [JsonProperty("ALLOC_CO2_INJ_VOL_SM3")]
        public double? ALLOC_CO2_INJ_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_FACTOR")]
        public double? ALLOC_FACTOR { get; set; }
        [JsonProperty("THEOR_GAS_INJ_VOL_SM3")]
        public double? THEOR_GAS_INJ_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_WATER_INJ_VOL_M3")]
        public double? THEOR_WATER_INJ_VOL_M3 { get; set; }
        [JsonProperty("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public double? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public double? FACILITY_LON { get; set; }
        [JsonProperty("WELL_LAT")]
        public double? WELL_LAT { get; set; }
        [JsonProperty("WELL_LON")]
        public double? WELL_LON { get; set; }
        [JsonProperty("WELL_START_DATE")]
        public DateTime? WELL_START_DATE { get; set; }
        [JsonProperty("WELL_END_DATE")]
        public DateTime? WELL_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}