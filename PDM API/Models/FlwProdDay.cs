using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("FLW_PROD_DAY", Schema = "PDM")]
    public class FlwProdDay
    {
        [JsonProperty("PROD_MONTH")]
        public DateTime? PROD_MONTH { get; set; }
        [JsonProperty("PROD_DAY")]
        public DateTime? PROD_DAY { get; set; }
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
        [JsonProperty("FLW_NAME")]
        public string FLW_NAME { get; set; }
        [JsonProperty("FLW_CODE")]
        public string FLW_CODE { get; set; }
        [JsonProperty("FLW_TYPE")]
        public string FLW_TYPE { get; set; }
        [JsonProperty("FLW_SIZE_M")]
        public double? FLW_SIZE_M { get; set; }
        [JsonProperty("SS_TEMPLATE")]
        public string SS_TEMPLATE { get; set; }
        [JsonProperty("TM")]
        public string TM { get; set; }
        [JsonProperty("PM1")]
        public string PM1 { get; set; }
        [JsonProperty("PM2")]
        public string PM2 { get; set; }
        [JsonProperty("CALC_OIL_METHOD")]
        public string CALC_OIL_METHOD { get; set; }
        [JsonProperty("CALC_COND_METHOD")]
        public string CALC_COND_METHOD { get; set; }
        [JsonProperty("CALC_GAS_METHOD")]
        public string CALC_GAS_METHOD { get; set; }
        [JsonProperty("CALC_WATER_METHOD")]
        public string CALC_WATER_METHOD { get; set; }
        [JsonProperty("CALC_GAS_LIFT_MTD")]
        public string CALC_GAS_LIFT_MTD { get; set; }
        [JsonProperty("ON_STREAM_HRS")]
        public double? ON_STREAM_HRS { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public string CHOKE_CODE { get; set; }
        [JsonProperty("CHOKE_OPENING")]
        public double? CHOKE_OPENING { get; set; }
        [JsonProperty("CHOKE_OPENING_2")]
        public double? CHOKE_OPENING_2 { get; set; }
        [JsonProperty("CHOKE_UOM")]
        public string CHOKE_UOM { get; set; }
        [JsonProperty("CHOKE_MM")]
        public double? CHOKE_MM { get; set; }
        [JsonProperty("FLWL_PRESS_BARG")]
        public double? FLWL_PRESS_BARG { get; set; }
        [JsonProperty("FLWL_TEMP_C")]
        public double? FLWL_TEMP_C { get; set; }
        [JsonProperty("INLET_PRESS_BARG")]
        public double? INLET_PRESS_BARG { get; set; }
        [JsonProperty("INLET_TEMP_C")]
        public double? INLET_TEMP_C { get; set; }
        [JsonProperty("FLWL_USC_PRESS")]
        public double? FLWL_USC_PRESS { get; set; }
        [JsonProperty("FLWL_USC_TEMP")]
        public double? FLWL_USC_TEMP { get; set; }
        [JsonProperty("FLWL_DSC_PRESS")]
        public double? FLWL_DSC_PRESS { get; set; }
        [JsonProperty("FLWL_DSC_TEMP")]
        public double? FLWL_DSC_TEMP { get; set; }
        [JsonProperty("OUTLET_PRESS_BARG")]
        public double? OUTLET_PRESS_BARG { get; set; }
        [JsonProperty("OUTLET_TEMP_C")]
        public double? OUTLET_TEMP_C { get; set; }
        [JsonProperty("SS_PRESS_BARG")]
        public double? SS_PRESS_BARG { get; set; }
        [JsonProperty("SS_TEMP_C")]
        public double? SS_TEMP_C { get; set; }
        [JsonProperty("DP_VENTURI_BARA")]
        public double? DP_VENTURI_BARA { get; set; }
        [JsonProperty("DP_WEDGE_BARA")]
        public double? DP_WEDGE_BARA { get; set; }
        [JsonProperty("SAND_RATE")]
        public double? SAND_RATE { get; set; }
        [JsonProperty("MAX_SAND_RATE")]
        public double? MAX_SAND_RATE { get; set; }
        [JsonProperty("SAND_UOM")]
        public string SAND_UOM { get; set; }
        [JsonProperty("CORROSION_RATE")]
        public double? CORROSION_RATE { get; set; }
        [JsonProperty("CORROSION_UOM")]
        public string CORROSION_UOM { get; set; }
        [JsonProperty("ALLOC_OIL_VOL_SM3")]
        public double? ALLOC_OIL_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_COND_VOL_SM3")]
        public double? ALLOC_COND_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_GAS_VOL_SM3")]
        public double? ALLOC_GAS_VOL_SM3 { get; set; }
        [JsonProperty("ALLOC_WATER_VOL_M3")]
        public double? ALLOC_WATER_VOL_M3 { get; set; }
        [JsonProperty("THEOR_OIL_VOL_SM3")]
        public double? THEOR_OIL_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_COND_VOL_SM3")]
        public double? THEOR_COND_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_GAS_VOL_SM3")]
        public double? THEOR_GAS_VOL_SM3 { get; set; }
        [JsonProperty("THEOR_WATER_VOL_M3")]
        public double? THEOR_WATER_VOL_M3 { get; set; }
        [JsonProperty("GAS_VOL_SM3")]
        public double? GAS_VOL_SM3 { get; set; }
        [JsonProperty("LIQ_VOL_SM3")]
        public double? LIQ_VOL_SM3 { get; set; }
        [JsonProperty("MPM_PRESS_BARG")]
        public double? MPM_PRESS_BARG { get; set; }
        [JsonProperty("MPM_TEMP_C")]
        public double? MPM_TEMP_C { get; set; }
        [JsonProperty("MPM_OIL_VOL_SM3")]
        public double? MPM_OIL_VOL_SM3 { get; set; }
        [JsonProperty("MPM_COND_VOL_SM3")]
        public double? MPM_COND_VOL_SM3 { get; set; }
        [JsonProperty("MPM_GAS_VOL_SM3")]
        public double? MPM_GAS_VOL_SM3 { get; set; }
        [JsonProperty("MPM_WATER_VOL_M3")]
        public double? MPM_WATER_VOL_M3 { get; set; }
        [JsonProperty("MPM_OIL_MASS_KG")]
        public double? MPM_OIL_MASS_KG { get; set; }
        [JsonProperty("MPM_COND_MASS_KG")]
        public double? MPM_COND_MASS_KG { get; set; }
        [JsonProperty("MPM_GAS_MASS_KG")]
        public double? MPM_GAS_MASS_KG { get; set; }
        [JsonProperty("MPM_WATER_MASS_KG")]
        public double? MPM_WATER_MASS_KG { get; set; }
        [JsonProperty("MPM_HC_MASS_KG")]
        public double? MPM_HC_MASS_KG { get; set; }
        [JsonProperty("MPM_OIL_MASS_ADJ_KG")]
        public double? MPM_OIL_MASS_ADJ_KG { get; set; }
        [JsonProperty("MPM_COND_MASS_ADJ_KG")]
        public double? MPM_COND_MASS_ADJ_KG { get; set; }
        [JsonProperty("MPM_GAS_MASS_ADJ_KG")]
        public double? MPM_GAS_MASS_ADJ_KG { get; set; }
        [JsonProperty("MPM_WATER_MASS_ADJ_KG")]
        public double? MPM_WATER_MASS_ADJ_KG { get; set; }
        [JsonProperty("MPM_MIX_DENSITY_KGPERM3")]
        public double? MPM_MIX_DENSITY_KGPERM3 { get; set; }
        [JsonProperty("MPM_OIL_DENSITY_KGPERM3")]
        public double? MPM_OIL_DENSITY_KGPERM3 { get; set; }
        [JsonProperty("MPM_COND_DENSITY_KGPERM3")]
        public double? MPM_COND_DENSITY_KGPERM3 { get; set; }
        [JsonProperty("MPM_GAS_DENSITY_KGPERM3")]
        public double? MPM_GAS_DENSITY_KGPERM3 { get; set; }
        [JsonProperty("MPM_WATER_DENSITY_KGPERM3")]
        public double? MPM_WATER_DENSITY_KGPERM3 { get; set; }
        [JsonProperty("MPM_WC_PCT")]
        public double? MPM_WC_PCT { get; set; }
        [JsonProperty("MPM_GOR")]
        public double? MPM_GOR { get; set; }
        [JsonProperty("HC_MASS_KG")]
        public double? HC_MASS_KG { get; set; }
        [JsonProperty("TOT_MASS_KG")]
        public double? TOT_MASS_KG { get; set; }
        [JsonProperty("GL_USC_PRESS_BARG")]
        public double? GL_USC_PRESS_BARG { get; set; }
        [JsonProperty("GL_DSC_PRESS_BARG")]
        public double? GL_DSC_PRESS_BARG { get; set; }
        [JsonProperty("GL_DSC_TEMP_C")]
        public double? GL_DSC_TEMP_C { get; set; }
        [JsonProperty("GL_RATE_SM3")]
        public double? GL_RATE_SM3 { get; set; }
        [JsonProperty("GL_CHOKE_DP_BARA")]
        public double? GL_CHOKE_DP_BARA { get; set; }
        [JsonProperty("WELLS_ON_FLOWLINE")]
        public string WELLS_ON_FLOWLINE { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public double? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public double? FACILITY_LON { get; set; }
        [JsonProperty("FLW_START_DATE")]
        public DateTime? FLW_START_DATE { get; set; }
        [JsonProperty("FLW_END_DATE")]
        public DateTime? FLW_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}