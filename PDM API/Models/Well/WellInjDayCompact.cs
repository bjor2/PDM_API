using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace PDM_API.Models
{
    [Table("WELL_INJ_DAY", Schema = "PDM")]
    public class WellInjDayCompact
    {
        [JsonProperty("PROD_MONTH")]
        public IEnumerable<DateTime?> PROD_MONTH { get; set; }
        [JsonProperty("PROD_MONTH_SHORT")]
        public IEnumerable<string> PROD_MONTH_SHORT { get { return PROD_MONTH != null ? ((IEnumerable<DateTime>)PROD_MONTH).ToList().Select(e => e.ToString("yyyy-MM-dd")) : null; } }

        [JsonProperty("PROD_DAY")]
        public IEnumerable<DateTime> PROD_DAY { get; set; }
        [JsonProperty("PROD_DAY_SHORT")]
        public IEnumerable<string> PROD_DAY_SHORT { get { return PROD_DAY.ToList().Select(e => e.ToString("yyyy-MM-dd")); } }

        [JsonProperty("COUNTRY")]
        public IEnumerable<string> COUNTRY { get; set; }
        [JsonProperty("BA_CODE")]
        public IEnumerable<string> BA_CODE { get; set; }
        [JsonProperty("RA_CODE")]
        public IEnumerable<string> RA_CODE { get; set; }
        [JsonProperty("RU_CODE")]
        public IEnumerable<string> RU_CODE { get; set; }
        [JsonProperty("FCTY_CODE")]
        public IEnumerable<string> FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public IEnumerable<string> GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public IEnumerable<string> GOV_FCTY_NAME { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public IEnumerable<string> GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public IEnumerable<string> GOV_FIELD_NAME { get; set; }
        [JsonProperty("COMMERCIAL_ENTITY")]
        public IEnumerable<string> COMMERCIAL_ENTITY { get; set; }
        [JsonProperty("GOV_LICENSE_CODE")]
        public IEnumerable<int?> GOV_LICENSE_CODE { get; set; }
        [JsonProperty("WELL_NAME")]
        public IEnumerable<string> WELL_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public IEnumerable<string> WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public IEnumerable<string> WELL_UWI { get; set; }
        [JsonProperty("WELL_HOOKUP")]
        public IEnumerable<string> WELL_HOOKUP { get; set; }
        [JsonProperty("SUBSEA_TEMPLATE_CODE")]
        public IEnumerable<string> SUBSEA_TEMPLATE_CODE { get; set; }
        [JsonProperty("FLOWLINE")]
        public IEnumerable<string> FLOWLINE { get; set; }
        [JsonProperty("WELL_CLASS")]
        public IEnumerable<string> WELL_CLASS { get; set; }
        [JsonProperty("WELL_TYPE")]
        public IEnumerable<string> WELL_TYPE { get; set; }
        [JsonProperty("INJ_TYPE")]
        public IEnumerable<string> INJ_TYPE { get; set; }
        [JsonProperty("WELL_STATUS")]
        public IEnumerable<string> WELL_STATUS { get; set; }
        [JsonProperty("PROD_METHOD")]
        public IEnumerable<string> PROD_METHOD { get; set; }
        [JsonProperty("DETAILED_PROD_METHOD")]
        public IEnumerable<string> DETAILED_PROD_METHOD { get; set; }
        [JsonProperty("CALC_GAS_INJ_METHOD")]
        public IEnumerable<string> CALC_GAS_INJ_METHOD { get; set; }
        [JsonProperty("CALC_WATER_INJ_METHOD")]
        public IEnumerable<string> CALC_WATER_INJ_METHOD { get; set; }
        [JsonProperty("CALC_CO2_INJ_METHOD")]
        public IEnumerable<string> CALC_CO2_INJ_METHOD { get; set; }
        [JsonProperty("ON_STREAM_HRS")]
        public IEnumerable<double?> ON_STREAM_HRS { get; set; }
        [JsonProperty("CHOKE_OPENING")]
        public IEnumerable<double?> CHOKE_OPENING { get; set; }
        [JsonProperty("CHOKE_UOM")]
        public IEnumerable<string> CHOKE_UOM { get; set; }
        [JsonProperty("CHOKE_OPENING_2")]
        public IEnumerable<double?> CHOKE_OPENING_2 { get; set; }
        [JsonProperty("CHOKE_UOM_02")]
        public IEnumerable<string> CHOKE_UOM_02 { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public IEnumerable<string> CHOKE_CODE { get; set; }
        [JsonProperty("WH_PRESS_BARG")]
        public IEnumerable<double?> WH_PRESS_BARG { get; set; }
        [JsonProperty("WH_TEMP_C")]
        public IEnumerable<double?> WH_TEMP_C { get; set; }
        [JsonProperty("ANNULUS_PRESS_BARG")]
        public IEnumerable<double?> ANNULUS_PRESS_BARG { get; set; }
        [JsonProperty("ANNULUS_TEMP_C")]
        public IEnumerable<double?> ANNULUS_TEMP_C { get; set; }
        [JsonProperty("DH_PRESS_BARG")]
        public IEnumerable<double?> DH_PRESS_BARG { get; set; }
        [JsonProperty("DH_TEMP_C")]
        public IEnumerable<double?> DH_TEMP_C { get; set; }
        [JsonProperty("WH_USC_PRESS_BARG")]
        public IEnumerable<double?> WH_USC_PRESS_BARG { get; set; }
        [JsonProperty("WH_USC_TEMP_C")]
        public IEnumerable<double?> WH_USC_TEMP_C { get; set; }
        [JsonProperty("WH_DSC_PRESS_BARG")]
        public IEnumerable<double?> WH_DSC_PRESS_BARG { get; set; }
        [JsonProperty("WH_DSC_TEMP_C")]
        public IEnumerable<double?> WH_DSC_TEMP_C { get; set; }
        [JsonProperty("DP_TUBING_BARA")]
        public IEnumerable<double?> DP_TUBING_BARA { get; set; }
        [JsonProperty("DP_CHOKE_BARA")]
        public IEnumerable<double?> DP_CHOKE_BARA { get; set; }
        [JsonProperty("ALLOC_GAS_INJ_VOL_SM3")]
        public IEnumerable<double?> ALLOC_GAS_INJ_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_WATER_INJ_VOL_M3")]
        public IEnumerable<double?> ALLOC_WATER_INJ_VOL_M3 { get; set; }
        [JsonProperty("ALLOC_CO2_INJ_VOL_SM3")]
        public IEnumerable<double?> ALLOC_CO2_INJ_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_FACTOR")]
        public IEnumerable<double?> ALLOC_FACTOR { get; set; }
        [JsonProperty("THEOR_GAS_INJ_VOL_SM3")]
        public IEnumerable<double?> THEOR_GAS_INJ_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_WATER_INJ_VOL_M3")]
        public IEnumerable<double?> THEOR_WATER_INJ_VOL_M3 { get; set; }
        [JsonProperty("DESCRIPTION")]
        public IEnumerable<string> DESCRIPTION { get; set; }
        [JsonProperty("COMMENTS")]
        public IEnumerable<string> COMMENTS { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public IEnumerable<double?> FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public IEnumerable<double?> FACILITY_LON { get; set; }
        [JsonProperty("WELL_LAT")]
        public IEnumerable<double?> WELL_LAT { get; set; }
        [JsonProperty("WELL_LON")]
        public IEnumerable<double?> WELL_LON { get; set; }
        [JsonProperty("WELL_START_DATE")]
        public IEnumerable<DateTime?> WELL_START_DATE { get; set; }
        [JsonProperty("WELL_END_DATE")]
        public IEnumerable<DateTime?> WELL_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public IEnumerable<DateTime?> LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public IEnumerable<string> DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public IEnumerable<string> DBSOURCE_ID { get; set; }
    }
}