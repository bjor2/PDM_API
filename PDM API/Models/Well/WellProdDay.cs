using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PDM_API.Models
{
    [Table("WELL_PROD_DAY", Schema = "PDM")]
    public class WellProdDay
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
        [JsonProperty("WELL_ID_EC")]
        public string WELL_ID_EC { get; set; }
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
        [JsonProperty("WELL_NAME")]
        public string WELL_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public string WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public string WELL_UWI { get; set; }
        [JsonProperty("WELL_HOOKUP")]
        public string WELL_HOOKUP { get; set; }
        [JsonProperty("SS_TEMPLATE")]
        public string SS_TEMPLATE { get; set; }
        [JsonProperty("FLOWLINE")]
        public string FLOWLINE { get; set; }
        [JsonProperty("WELL_CLASS")]
        public string WELL_CLASS { get; set; }
        [JsonProperty("WELL_TYPE")]
        public string WELL_TYPE { get; set; }
        [JsonProperty("WELL_STATUS")]
        public string WELL_STATUS { get; set; }
        [JsonProperty("PROD_METHOD")]
        public string PROD_METHOD { get; set; }
        [JsonProperty("PROD_METHOD_DET")]
        public string PROD_METHOD_DET { get; set; }
        [JsonProperty("CALC_OIL_METHOD")]
        public string CALC_OIL_METHOD { get; set; }
        [JsonProperty("CALC_GAS_METHOD")]
        public string CALC_GAS_METHOD { get; set; }
        [JsonProperty("CALC_WATER_METHOD")]
        public string CALC_WATER_METHOD { get; set; }
        [JsonProperty("CALC_COND_METHOD")]
        public string CALC_COND_METHOD { get; set; }
        [JsonProperty("CALC_DILUENT_METHOD")]
        public string CALC_DILUENT_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_OIL_METHOD")]
        public string CALC_SUB_DAY_OIL_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_GAS_METHOD")]
        public string CALC_SUB_DAY_GAS_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_WATER_METHOD")]
        public string CALC_SUB_DAY_WATER_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_COND_METHOD")]
        public string CALC_SUB_DAY_COND_METHOD { get; set; }
        [JsonProperty("CALC_SUB_DAY_DILUENT_METHOD")]
        public string CALC_SUB_DAY_DILUENT_METHOD { get; set; }
        [JsonProperty("GAS_LIFT_METHOD")]
        public string GAS_LIFT_METHOD { get; set; }
        [JsonProperty("POTENTIAL_METHOD")]
        public string POTENTIAL_METHOD { get; set; }
        [JsonProperty("FLUID_QUALITY")]
        public string FLUID_QUALITY { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public string CHOKE_CODE { get; set; }
        [JsonProperty("CHOKE_PROD")]
        public string CHOKE_PROD { get; set; }
        [JsonProperty("CHOKE_PROD_DATE")]
        public DateTime? CHOKE_PROD_DATE { get; set; }
        [JsonProperty("ON_STREAM_HRS")]
        public double? ON_STREAM_HRS { get; set; }
        [JsonProperty("CHOKE_SIZE")]
        public double? CHOKE_SIZE { get; set; }
        [JsonProperty("CHOKE_UOM")]
        public string CHOKE_UOM { get; set; }
        [JsonProperty("CHOKE_SIZE_2")]
        public double? CHOKE_SIZE_2 { get; set; }
        [JsonProperty("CHOKE_UOM_02")]
        public string CHOKE_UOM_02 { get; set; }
        [JsonProperty("CHOKE_MM")]
        public double? CHOKE_MM { get; set; }
        [JsonProperty("CHOKE_MM_02")]
        public double? CHOKE_MM_02 { get; set; }
        [JsonProperty("WH_PRESS_BARG")]
        public double? WH_PRESS_BARG { get; set; }
        [JsonProperty("WH_TEMP_C")]
        public double? WH_TEMP_C { get; set; }
        [JsonProperty("ANNULUS_PRESS_BARG")]
        public double? ANNULUS_PRESS_BARG { get; set; }
        [JsonProperty("ANNULUS_PRESS_2_BARG")]
        public double? ANNULUS_PRESS_2_BARG { get; set; }
        [JsonProperty("ANNULUS_PRESS_3_BARG")]
        public double? ANNULUS_PRESS_3_BARG { get; set; }
        [JsonProperty("ANNULUS_PRESS_4_BARG")]
        public double? ANNULUS_PRESS_4_BARG { get; set; }
        [JsonProperty("ANNULUS_TEMP_C")]
        public double? ANNULUS_TEMP_C { get; set; }
        [JsonProperty("ALLOC_OIL_VOL_SM3")]
        public double? ALLOC_OIL_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_COND_VOL_SM3")]
        public double? ALLOC_COND_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_GAS_VOL_SM3")]
        public double? ALLOC_GAS_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_WATER_VOL_M3")]
        public double? ALLOC_WATER_VOL_M3 { get; set; }
        [JsonProperty("ALLOC_GL_VOL_SM3")]
        public double? ALLOC_GL_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_OIL_MASS_KG")]
        public double? ALLOC_OIL_MASS_KG { get; set; }
        [JsonProperty("ALLOC_GAS_MASS_KG")]
        public double? ALLOC_GAS_MASS_KG { get; set; }
        [JsonProperty("ALLOC_GOR")]
        public double? ALLOC_GOR { get; set; }
        [JsonProperty("ALLOC_GCR")]
        public double? ALLOC_GCR { get; set; }
        [JsonProperty("ALLOC_WGR")]
        public double? ALLOC_WGR { get; set; }
        [JsonProperty("ALLOC_WCR")]
        public double? ALLOC_WCR { get; set; }
        [JsonProperty("ALLOC_WC_PCT")]
        public double? ALLOC_WC_PCT { get; set; }
        [JsonProperty("ALLOC_OIL_FACTOR")]
        public double? ALLOC_OIL_FACTOR { get; set; }
        [JsonProperty("ALLOC_COND_FACTOR")]
        public double? ALLOC_COND_FACTOR { get; set; }
        [JsonProperty("ALLOC_GAS_FACTOR")]
        public double? ALLOC_GAS_FACTOR { get; set; }
        [JsonProperty("ALLOC_WATER_FACTOR")]
        public double? ALLOC_WATER_FACTOR { get; set; }
        [JsonProperty("BH_PRESS_BARG")]
        public double? BH_PRESS_BARG { get; set; }
        [JsonProperty("BH_PRESS_2_BARG")]
        public double? BH_PRESS_2_BARG { get; set; }
        [JsonProperty("BH_TEMP_C")]
        public double? BH_TEMP_C { get; set; }
        [JsonProperty("BH_TEMP_2_C")]
        public double? BH_TEMP_2_C { get; set; }
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
        [JsonProperty("DP_VENTURI_BARA")]
        public double? DP_VENTURI_BARA { get; set; }
        [JsonProperty("DP_CHOKE_BARA")]
        public double? DP_CHOKE_BARA { get; set; }
        [JsonProperty("SAND_RAW")]
        public double? SAND_RAW { get; set; }
        [JsonProperty("SAND_RAW_2")]
        public double? SAND_RAW_2 { get; set; }
        [JsonProperty("SAND_RATE")]
        public double? SAND_RATE { get; set; }
        [JsonProperty("SAND_UOM")]
        public string SAND_UOM { get; set; }
        [JsonProperty("SAND_RATE_2")]
        public double? SAND_RATE_2 { get; set; }
        [JsonProperty("SAND_2_UOM")]
        public string SAND_2_UOM { get; set; }
        [JsonProperty("MAX_SAND_RATE")]
        public double? MAX_SAND_RATE { get; set; }
        [JsonProperty("EROSION_RATE")]
        public double? EROSION_RATE { get; set; }
        [JsonProperty("EROSION_UOM")]
        public string EROSION_UOM { get; set; }
        [JsonProperty("GL_ON_STRM_HRS")]
        public double? GL_ON_STRM_HRS { get; set; }
        [JsonProperty("GL_CHOKE_SIZE")]
        public double? GL_CHOKE_SIZE { get; set; }
        [JsonProperty("GL_MF_PRESS_BARG")]
        public double? GL_MF_PRESS_BARG { get; set; }
        [JsonProperty("GL_DIFF_PRESS_BARA")]
        public double? GL_DIFF_PRESS_BARA { get; set; }
        [JsonProperty("GL_PRESS_BARG")]
        public double? GL_PRESS_BARG { get; set; }
        [JsonProperty("GL_TEMP_C")]
        public double? GL_TEMP_C { get; set; }
        [JsonProperty("GL_RATE_SM3")]
        public double? GL_RATE_SM3 { get; set; }
        [JsonProperty("ESP_IN_PRESS_BARG")]
        public double? ESP_IN_PRESS_BARG { get; set; }
        [JsonProperty("ESP_IN_TEMP_C")]
        public double? ESP_IN_TEMP_C { get; set; }
        [JsonProperty("ESP_OUT_PRESS_BARG")]
        public double? ESP_OUT_PRESS_BARG { get; set; }
        [JsonProperty("ESP_OUT_TEMP_C")]
        public double? ESP_OUT_TEMP_C { get; set; }
        [JsonProperty("ESP_AC_FREQ_HZ")]
        public double? ESP_AC_FREQ_HZ { get; set; }
        [JsonProperty("ESP_PHASE_CURR_AMP")]
        public double? ESP_PHASE_CURR_AMP { get; set; }
        [JsonProperty("ESP_PHASE_VOLT_VOLT")]
        public double? ESP_PHASE_VOLT_VOLT { get; set; }
        [JsonProperty("ESP_PUMP_POWER_KW")]
        public double? ESP_PUMP_POWER_KW { get; set; }
        [JsonProperty("ESP_PUMP_SPEED_RPM")]
        public double? ESP_PUMP_SPEED_RPM { get; set; }
        [JsonProperty("MPM_PRESS_BARG")]
        public double? MPM_PRESS_BARG { get; set; }
        [JsonProperty("MPM_TEMP_C")]
        public double? MPM_TEMP_C { get; set; }
        [JsonProperty("MPM_OIL_RATE_SM3")]
        public double? MPM_OIL_RATE_SM3 { get; set; }
        [JsonProperty("MPM_COND_RATE_SM3")]
        public double? MPM_COND_RATE_SM3 { get; set; }
        [JsonProperty("MPM_GAS_RATE_SM3")]
        public double? MPM_GAS_RATE_SM3 { get; set; }
        [JsonProperty("MPM_WATER_RATE_M3")]
        public double? MPM_WATER_RATE_M3 { get; set; }
        [JsonProperty("MPM2_COND_RATE_SM3")]
        public double? MPM2_COND_RATE_SM3 { get; set; }
        [JsonProperty("MPM2_GAS_RATE_SM3")]
        public double? MPM2_GAS_RATE_SM3 { get; set; }
        [JsonProperty("MPM2_WATER_RATE_M3")]
        public double? MPM2_WATER_RATE_M3 { get; set; }
        [JsonProperty("MPM_OIL_MASS_RATE_KG")]
        public double? MPM_OIL_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_COND_MASS_RATE_KG")]
        public double? MPM_COND_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_GAS_MASS_RATE_KG")]
        public double? MPM_GAS_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_WAT_MASS_RATE_KG")]
        public double? MPM_WAT_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_HC_MASS_RATE_KG")]
        public double? MPM_HC_MASS_RATE_KG { get; set; }
        [JsonProperty("HC_MASS_RATE_KG")]
        public double? HC_MASS_RATE_KG { get; set; }
        [JsonProperty("TOT_MASS_RATE_KG")]
        public double? TOT_MASS_RATE_KG { get; set; }
        [JsonProperty("MPM_OIL_DENS_KGPERM3")]
        public double? MPM_OIL_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_COND_DENS_KGPERM3")]
        public double? MPM_COND_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_GAS_DENS_KGPERM3")]
        public double? MPM_GAS_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_WATER_DENS_KGPERM3")]
        public double? MPM_WATER_DENS_KGPERM3 { get; set; }
        [JsonProperty("MPM_GOR")]
        public double? MPM_GOR { get; set; }
        [JsonProperty("MPM_GCR")]
        public double? MPM_GCR { get; set; }
        [JsonProperty("MPM_VELOCITY_GAS")]
        public double? MPM_VELOCITY_GAS { get; set; }
        [JsonProperty("MPM_VELOCITY_LIQUID")]
        public double? MPM_VELOCITY_LIQUID { get; set; }
        [JsonProperty("MPM_DIFF_PRESS")]
        public double? MPM_DIFF_PRESS { get; set; }
        [JsonProperty("MPM_WC_PCT")]
        public double? MPM_WC_PCT { get; set; }
        [JsonProperty("MPM_CONDUCT_MS")]
        public double? MPM_CONDUCT_MS { get; set; }
        [JsonProperty("WELL_TEST_DATE")]
        public string WELL_TEST_DATE { get; set; }
        [JsonProperty("WELL_TEST_CHOKE")]
        public double? WELL_TEST_CHOKE { get; set; }
        [JsonProperty("WELL_TEST_WHP_BARG")]
        public double? WELL_TEST_WHP_BARG { get; set; }
        [JsonProperty("WELL_TEST_OIL_SM3")]
        public double? WELL_TEST_OIL_SM3 { get; set; }
        [JsonProperty("WELL_TEST_COND_SM3")]
        public double? WELL_TEST_COND_SM3 { get; set; }
        [JsonProperty("WELL_TEST_GAS_SM3")]
        public double? WELL_TEST_GAS_SM3 { get; set; }
        [JsonProperty("WELL_TEST_WAT_SM3")]
        public double? WELL_TEST_WAT_SM3 { get; set; }
        [JsonProperty("WELL_TEST_WC")]
        public double? WELL_TEST_WC { get; set; }
        [JsonProperty("WELL_TEST_WGR")]
        public double? WELL_TEST_WGR { get; set; }
        [JsonProperty("METER1_FACTOR_HCLIQ")]
        public double? METER1_FACTOR_HCLIQ { get; set; }
        [JsonProperty("METER1_FACTOR_GAS")]
        public double? METER1_FACTOR_GAS { get; set; }
        [JsonProperty("METER1_FACTOR_GL")]
        public double? METER1_FACTOR_GL { get; set; }
        [JsonProperty("METER1_FACTOR_WAT")]
        public double? METER1_FACTOR_WAT { get; set; }
        [JsonProperty("METER1_FACTOR_HCMASS")]
        public double? METER1_FACTOR_HCMASS { get; set; }
        [JsonProperty("METER2_FACTOR_HCLIQ")]
        public double? METER2_FACTOR_HCLIQ { get; set; }
        [JsonProperty("METER2_FACTOR_GAS")]
        public double? METER2_FACTOR_GAS { get; set; }
        [JsonProperty("METER2_FACTOR_WAT")]
        public double? METER2_FACTOR_WAT { get; set; }
        [JsonProperty("THEOR_OIL_VOL_SM3")]
        public double? THEOR_OIL_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_COND_VOL_SM3")]
        public double? THEOR_COND_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_GAS_VOL_SM3")]
        public double? THEOR_GAS_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_WATER_VOL_M3")]
        public double? THEOR_WATER_VOL_M3 { get; set; }
        [JsonProperty("THEOR_GL_VOL_SM3")]
        public double? THEOR_GL_VOL_SM3 { get; set; }
        [JsonProperty("HC_LIQ_PHASE")]
        public string HC_LIQ_PHASE { get; set; }
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
        [JsonProperty("OBJECT_START_DATE")]
        public DateTime? OBJECT_START_DATE { get; set; }
        [JsonProperty("OBJECT_END_DATE")]
        public DateTime? OBJECT_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }



    }
}