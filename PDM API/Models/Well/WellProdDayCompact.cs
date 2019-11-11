using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace PDM_API.Models
{
    [Table("WELL_PROD_DAY", Schema = "PDM")]
    public class WellProdDayCompact
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
        [JsonProperty("WELL_ID_EC")]
        public IEnumerable<string> WELL_ID_EC { get; set; }
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
        [JsonProperty("WELL_NAME")]
        public IEnumerable<string> WELL_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public IEnumerable<string> WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public IEnumerable<string> WELL_UWI { get; set; }
        [JsonProperty("WELL_HOOKUP")]
        public IEnumerable<string> WELL_HOOKUP { get; set; }
        [JsonProperty("SS_TEMPLATE")]
        public IEnumerable<string> SS_TEMPLATE { get; set; }
        [JsonProperty("FLOWLINE")]
        public IEnumerable<string> FLOWLINE { get; set; }
        [JsonProperty("WELL_CLASS")]
        public IEnumerable<string> WELL_CLASS { get; set; }
        [JsonProperty("WELL_TYPE")]
        public IEnumerable<string> WELL_TYPE { get; set; }
        [JsonProperty("WELL_STATUS")]
        public IEnumerable<string> WELL_STATUS { get; set; }
        [JsonProperty("PROD_METHOD")]
        public IEnumerable<string> PROD_METHOD { get; set; }
        [JsonProperty("PROD_METHOD_DET")]
        public IEnumerable<string> PROD_METHOD_DET { get; set; }
        [JsonProperty("CALC_OIL_METHOD")]
        public IEnumerable<string> CALC_OIL_METHOD { get; set; }
        [JsonProperty("CALC_GAS_METHOD")]
        public IEnumerable<string> CALC_GAS_METHOD { get; set; }
        [JsonProperty("CALC_WATER_METHOD")]
        public IEnumerable<string> CALC_WATER_METHOD { get; set; }
        [JsonProperty("CALC_COND_METHOD")]
        public IEnumerable<string> CALC_COND_METHOD { get; set; }
        [JsonProperty("CALC_DILUENT_METHOD")]
        public IEnumerable<string> CALC_DILUENT_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_OIL_METHOD")]
        public IEnumerable<string> CALC_SUB_DAY_OIL_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_GAS_METHOD")]
        public IEnumerable<string> CALC_SUB_DAY_GAS_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_WATER_METHOD")]
        public IEnumerable<string> CALC_SUB_DAY_WATER_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_COND_METHOD")]
        public IEnumerable<string> CALC_SUB_DAY_COND_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_DILUENT_METHOD")]
        public IEnumerable<string> CALC_SUB_DAY_DILUENT_METHOD { get; set; }
        [JsonProperty("GAS_LIFT_METHOD")]
        public IEnumerable<string> GAS_LIFT_METHOD { get; set; }
        [JsonProperty("POTENTIAL_METHOD")]
        public IEnumerable<string> POTENTIAL_METHOD { get; set; }
        [JsonProperty("FLUID_QUALITY")]
        public IEnumerable<string> FLUID_QUALITY { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public IEnumerable<string> CHOKE_CODE { get; set; }
        [JsonProperty("CHOKE_PROD")]
        public IEnumerable<string> CHOKE_PROD { get; set; }
        [JsonProperty("CHOKE_PROD_DATE")]
        public IEnumerable<DateTime?> CHOKE_PROD_DATE { get; set; }
        [JsonProperty("ON_STREAM_HRS")]
        public IEnumerable<double?> ON_STREAM_HRS { get; set; }
        [JsonProperty("CHOKE_SIZE")]
        public IEnumerable<double?> CHOKE_SIZE { get; set; }
        [JsonProperty("CHOKE_UOM")]
        public IEnumerable<string> CHOKE_UOM { get; set; }
        [JsonProperty("CHOKE_SIZE_2")]
        public IEnumerable<double?> CHOKE_SIZE_2 { get; set; }
        [JsonProperty("CHOKE_UOM_02")]
        public IEnumerable<string> CHOKE_UOM_02 { get; set; }
        [JsonProperty("CHOKE_MM")]
        public IEnumerable<double?> CHOKE_MM { get; set; }
        [JsonProperty("CHOKE_MM_02")]
        public IEnumerable<double?> CHOKE_MM_02 { get; set; }
        [JsonProperty("WH_PRESS_BARG")]
        public IEnumerable<double?> WH_PRESS_BARG { get; set; }
        [JsonProperty("WH_TEMP_C")]
        public IEnumerable<double?> WH_TEMP_C { get; set; }
        [JsonProperty("ANNULUS_PRESS_BARG")]
        public IEnumerable<double?> ANNULUS_PRESS_BARG { get; set; }
        [JsonProperty("ANNULUS_PRESS_2_BARG")]
        public IEnumerable<double?> ANNULUS_PRESS_2_BARG { get; set; }
        [JsonProperty("ANNULUS_PRESS_3_BARG")]
        public IEnumerable<double?> ANNULUS_PRESS_3_BARG { get; set; }
        [JsonProperty("ANNULUS_PRESS_4_BARG")]
        public IEnumerable<double?> ANNULUS_PRESS_4_BARG { get; set; }
        [JsonProperty("ANNULUS_TEMP_C")]
        public IEnumerable<double?> ANNULUS_TEMP_C { get; set; }
        [JsonProperty("ALLOC_OIL_VOL_SM3")]
        public IEnumerable<double?> ALLOC_OIL_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_COND_VOL_SM3")]
        public IEnumerable<double?> ALLOC_COND_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_GAS_VOL_SM3")]
        public IEnumerable<double?> ALLOC_GAS_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_WATER_VOL_M3")]
        public IEnumerable<double?> ALLOC_WATER_VOL_M3 { get; set; }
        [JsonProperty("ALLOC_GL_VOL_SM3")]
        public IEnumerable<double?> ALLOC_GL_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_OIL_MASS_KG")]
        public IEnumerable<double?> ALLOC_OIL_MASS_KG { get; set; }
        [JsonProperty("ALLOC_GAS_MASS_KG")]
        public IEnumerable<double?> ALLOC_GAS_MASS_KG { get; set; }
        [JsonProperty("ALLOC_GOR")]
        public IEnumerable<double?> ALLOC_GOR { get; set; }
        [JsonProperty("ALLOC_GCR")]
        public IEnumerable<double?> ALLOC_GCR { get; set; }
        [JsonProperty("ALLOC_WGR")]
        public IEnumerable<double?> ALLOC_WGR { get; set; }
        [JsonProperty("ALLOC_WCR")]
        public IEnumerable<double?> ALLOC_WCR { get; set; }
        [JsonProperty("ALLOC_WC_PCT")]
        public IEnumerable<double?> ALLOC_WC_PCT { get; set; }
        [JsonProperty("ALLOC_OIL_FACTOR")]
        public IEnumerable<double?> ALLOC_OIL_FACTOR { get; set; }
        [JsonProperty("ALLOC_COND_FACTOR")]
        public IEnumerable<double?> ALLOC_COND_FACTOR { get; set; }
        [JsonProperty("ALLOC_GAS_FACTOR")]
        public IEnumerable<double?> ALLOC_GAS_FACTOR { get; set; }
        [JsonProperty("ALLOC_WATER_FACTOR")]
        public IEnumerable<double?> ALLOC_WATER_FACTOR { get; set; }
        [JsonProperty("BH_PRESS_BARG")]
        public IEnumerable<double?> BH_PRESS_BARG { get; set; }
        [JsonProperty("BH_PRESS_2_BARG")]
        public IEnumerable<double?> BH_PRESS_2_BARG { get; set; }
        [JsonProperty("BH_TEMP_C")]
        public IEnumerable<double?> BH_TEMP_C { get; set; }
        [JsonProperty("BH_TEMP_2_C")]
        public IEnumerable<double?> BH_TEMP_2_C { get; set; }
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
        [JsonProperty("DP_VENTURI_BARA")]
        public IEnumerable<double?> DP_VENTURI_BARA { get; set; }
        [JsonProperty("DP_CHOKE_BARA")]
        public IEnumerable<double?> DP_CHOKE_BARA { get; set; }
        [JsonProperty("SAND_RAW")]
        public IEnumerable<double?> SAND_RAW { get; set; }
        [JsonProperty("SAND_RAW_2")]
        public IEnumerable<double?> SAND_RAW_2 { get; set; }
        [JsonProperty("SAND_RATE")]
        public IEnumerable<double?> SAND_RATE { get; set; }
        [JsonProperty("SAND_UOM")]
        public IEnumerable<string> SAND_UOM { get; set; }
        [JsonProperty("SAND_RATE_2")]
        public IEnumerable<double?> SAND_RATE_2 { get; set; }
        [JsonProperty("SAND_2_UOM")]
        public IEnumerable<string> SAND_2_UOM { get; set; }
        [JsonProperty("MAX_SAND_RATE")]
        public IEnumerable<double?> MAX_SAND_RATE { get; set; }
        [JsonProperty("EROSION_RATE")]
        public IEnumerable<double?> EROSION_RATE { get; set; }
        [JsonProperty("EROSION_UOM")]
        public IEnumerable<string> EROSION_UOM { get; set; }
        [JsonProperty("GL_ON_STRM_HRS")]
        public IEnumerable<double?> GL_ON_STRM_HRS { get; set; }
        [JsonProperty("GL_CHOKE_SIZE")]
        public IEnumerable<double?> GL_CHOKE_SIZE { get; set; }
        [JsonProperty("GL_MF_PRESS_BARG")]
        public IEnumerable<double?> GL_MF_PRESS_BARG { get; set; }
        [JsonProperty("GL_DIFF_PRESS_BARA")]
        public IEnumerable<double?> GL_DIFF_PRESS_BARA { get; set; }
        [JsonProperty("GL_PRESS_BARG")]
        public IEnumerable<double?> GL_PRESS_BARG { get; set; }
        [JsonProperty("GL_TEMP_C")]
        public IEnumerable<double?> GL_TEMP_C { get; set; }
        [JsonProperty("GL_RATE_SM3")]
        public IEnumerable<double?> GL_RATE_SM3 { get; set; }
        [JsonProperty("ESP_IN_PRESS_BARG")]
        public IEnumerable<double?> ESP_IN_PRESS_BARG { get; set; }
        [JsonProperty("ESP_IN_TEMP_C")]
        public IEnumerable<double?> ESP_IN_TEMP_C { get; set; }
        [JsonProperty("ESP_OUT_PRESS_BARG")]
        public IEnumerable<double?> ESP_OUT_PRESS_BARG { get; set; }
        [JsonProperty("ESP_OUT_TEMP_C")]
        public IEnumerable<double?> ESP_OUT_TEMP_C { get; set; }
        [JsonProperty("ESP_AC_FREQ_HZ")]
        public IEnumerable<double?> ESP_AC_FREQ_HZ { get; set; }
        [JsonProperty("ESP_PHASE_CURR_AMP")]
        public IEnumerable<double?> ESP_PHASE_CURR_AMP { get; set; }
        [JsonProperty("ESP_PHASE_VOLT_VOLT")]
        public IEnumerable<double?> ESP_PHASE_VOLT_VOLT { get; set; }
        [JsonProperty("ESP_PUMP_POWER_KW")]
        public IEnumerable<double?> ESP_PUMP_POWER_KW { get; set; }
        [JsonProperty("ESP_PUMP_SPEED_RPM")]
        public IEnumerable<double?> ESP_PUMP_SPEED_RPM { get; set; }
        [JsonProperty("MPM_PRESS_BARG")]
        public IEnumerable<double?> MPM_PRESS_BARG { get; set; }
        [JsonProperty("MPM_TEMP_C")]
        public IEnumerable<double?> MPM_TEMP_C { get; set; }
        [JsonProperty("MPM_OIL_RATE_SM3")]
        public IEnumerable<double?> MPM_OIL_RATE_SM3 { get; set; }
        [JsonProperty("MPM_COND_RATE_SM3")]
        public IEnumerable<double?> MPM_COND_RATE_SM3 { get; set; }
        [JsonProperty("MPM_GAS_RATE_SM3")]
        public IEnumerable<double?> MPM_GAS_RATE_SM3 { get; set; }
        [JsonProperty("MPM_WATER_RATE_M3")]
        public IEnumerable<double?> MPM_WATER_RATE_M3 { get; set; }
        [JsonProperty("MPM2_COND_RATE_SM3")]
        public IEnumerable<double?> MPM2_COND_RATE_SM3 { get; set; }
        [JsonProperty("MPM2_GAS_RATE_SM3")]
        public IEnumerable<double?> MPM2_GAS_RATE_SM3 { get; set; }
        [JsonProperty("MPM2_WATER_RATE_M3")]
        public IEnumerable<double?> MPM2_WATER_RATE_M3 { get; set; }
        [JsonProperty("MPM_OIL_MASS_RATE_KG")]
        public IEnumerable<double?> MPM_OIL_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_COND_MASS_RATE_KG")]
        public IEnumerable<double?> MPM_COND_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_GAS_MASS_RATE_KG")]
        public IEnumerable<double?> MPM_GAS_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_WAT_MASS_RATE_KG")]
        public IEnumerable<double?> MPM_WAT_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_HC_MASS_RATE_KG")]
        public IEnumerable<double?> MPM_HC_MASS_RATE_KG { get; set; }
        [JsonProperty("HC_MASS_RATE_KG")]
        public IEnumerable<double?> HC_MASS_RATE_KG { get; set; }
        [JsonProperty("TOT_MASS_RATE_KG")]
        public IEnumerable<double?> TOT_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_OIL_DENS_KGPERM3")]
        public IEnumerable<double?> MPM_OIL_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_COND_DENS_KGPERM3")]
        public IEnumerable<double?> MPM_COND_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_GAS_DENS_KGPERM3")]
        public IEnumerable<double?> MPM_GAS_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_WATER_DENS_KGPERM3")]
        public IEnumerable<double?> MPM_WATER_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_GOR")]
        public IEnumerable<double?> MPM_GOR { get; set; }
        [JsonProperty("MPM_GCR")]
        public IEnumerable<double?> MPM_GCR { get; set; }
        [JsonProperty("MPM_VELOCITY_GAS")]
        public IEnumerable<double?> MPM_VELOCITY_GAS { get; set; }
        [JsonProperty("MPM_VELOCITY_LIQUID")]
        public IEnumerable<double?> MPM_VELOCITY_LIQUID { get; set; }
        [JsonProperty("MPM_DIFF_PRESS")]
        public IEnumerable<double?> MPM_DIFF_PRESS { get; set; }
        [JsonProperty("MPM_WC_PCT")]
        public IEnumerable<double?> MPM_WC_PCT { get; set; }
        [JsonProperty("MPM_CONDUCT_MS")]
        public IEnumerable<double?> MPM_CONDUCT_MS { get; set; }
        [JsonProperty("WELL_TEST_DATE")]
        public IEnumerable<string> WELL_TEST_DATE { get; set; }
        [JsonProperty("WELL_TEST_CHOKE")]
        public IEnumerable<double?> WELL_TEST_CHOKE { get; set; }
        [JsonProperty("WELL_TEST_WHP_BARG")]
        public IEnumerable<double?> WELL_TEST_WHP_BARG { get; set; }
        [JsonProperty("WELL_TEST_OIL_SM3")]
        public IEnumerable<double?> WELL_TEST_OIL_SM3 { get; set; }
        [JsonProperty("WELL_TEST_COND_SM3")]
        public IEnumerable<double?> WELL_TEST_COND_SM3 { get; set; }
        [JsonProperty("WELL_TEST_GAS_SM3")]
        public IEnumerable<double?> WELL_TEST_GAS_SM3 { get; set; }
        [JsonProperty("WELL_TEST_WAT_SM3")]
        public IEnumerable<double?> WELL_TEST_WAT_SM3 { get; set; }
        [JsonProperty("WELL_TEST_WC")]
        public IEnumerable<double?> WELL_TEST_WC { get; set; }
        [JsonProperty("WELL_TEST_WGR")]
        public IEnumerable<double?> WELL_TEST_WGR { get; set; }
        [JsonProperty("METER1_FACTOR_HCLIQ")]
        public IEnumerable<double?> METER1_FACTOR_HCLIQ { get; set; }
        [JsonProperty("METER1_FACTOR_GAS")]
        public IEnumerable<double?> METER1_FACTOR_GAS { get; set; }
        [JsonProperty("METER1_FACTOR_GL")]
        public IEnumerable<double?> METER1_FACTOR_GL { get; set; }
        [JsonProperty("METER1_FACTOR_WAT")]
        public IEnumerable<double?> METER1_FACTOR_WAT { get; set; }
        [JsonProperty("METER1_FACTOR_HCMASS")]
        public IEnumerable<double?> METER1_FACTOR_HCMASS { get; set; }
        [JsonProperty("METER2_FACTOR_HCLIQ")]
        public IEnumerable<double?> METER2_FACTOR_HCLIQ { get; set; }
        [JsonProperty("METER2_FACTOR_GAS")]
        public IEnumerable<double?> METER2_FACTOR_GAS { get; set; }
        [JsonProperty("METER2_FACTOR_WAT")]
        public IEnumerable<double?> METER2_FACTOR_WAT { get; set; }
        [JsonProperty("THEOR_OIL_VOL_SM3")]
        public IEnumerable<double?> THEOR_OIL_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_COND_VOL_SM3")]
        public IEnumerable<double?> THEOR_COND_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_GAS_VOL_SM3")]
        public IEnumerable<double?> THEOR_GAS_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_WATER_VOL_M3")]
        public IEnumerable<double?> THEOR_WATER_VOL_M3 { get; set; }
        [JsonProperty("THEOR_GL_VOL_SM3")]
        public IEnumerable<double?> THEOR_GL_VOL_SM3 { get; set; }
        [JsonProperty("HC_LIQ_PHASE")]
        public IEnumerable<string> HC_LIQ_PHASE { get; set; }
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
        [JsonProperty("OBJECT_START_DATE")]
        public IEnumerable<DateTime?> OBJECT_START_DATE { get; set; }
        [JsonProperty("OBJECT_END_DATE")]
        public IEnumerable<DateTime?> OBJECT_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public IEnumerable<DateTime?> LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public IEnumerable<string> DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public IEnumerable<string> DBSOURCE_ID { get; set; }
    }
}