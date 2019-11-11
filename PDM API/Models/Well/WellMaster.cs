using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("WELL_MASTER", Schema = "PDM")]
    public class WellMaster
    {
        [JsonProperty("WELL_GUID")]
        public double? WELL_GUID { get; set; }
        [JsonProperty("COUNTRY")]
        public string COUNTRY { get; set; }
        [JsonProperty("COUNTRY_NAME")]
        public string COUNTRY_NAME { get; set; }
        [JsonProperty("BA_CODE")]
        public string BA_CODE { get; set; }
        [JsonProperty("RA_CODE")]
        public string RA_CODE { get; set; }
        [JsonProperty("BU_CODE")]
        public string BU_CODE { get; set; }
        [JsonProperty("PC_CODE")]
        public string PC_CODE { get; set; }
        [JsonProperty("PLAN_ENTITY")]
        public string PLAN_ENTITY { get; set; }
        [JsonProperty("WELL_UWI")]
        public string WELL_UWI { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public string WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_ID_EC")]
        public string WELL_ID_EC { get; set; }
        [JsonProperty("WELL_NAME")]
        public string WELL_NAME { get; set; }
        [JsonProperty("WELL_CODE")]
        public string WELL_CODE { get; set; }
        [JsonProperty("FCTY_CODE")]
        public string FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("FIELD_CODE")]
        public string FIELD_CODE { get; set; }
        [JsonProperty("FIELD_NAME")]
        public string FIELD_NAME { get; set; }
        [JsonProperty("GEO_FIELD_CODE")]
        public string GEO_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public string GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public string GOV_FIELD_NAME { get; set; }
        [JsonProperty("SMDA_FCTY_ID")]
        public string SMDA_FCTY_ID { get; set; }
        [JsonProperty("SMDA_FIELD_ID")]
        public string SMDA_FIELD_ID { get; set; }
        [JsonProperty("SMDA_LICENSE_ID")]
        public string SMDA_LICENSE_ID { get; set; }
        [JsonProperty("PARTNER_STATUS")]
        public string PARTNER_STATUS { get; set; }
        [JsonProperty("COMM_ENT_ID_EC")]
        public string COMM_ENT_ID_EC { get; set; }
        [JsonProperty("COMMERCIAL_ENTITY")]
        public string COMMERCIAL_ENTITY { get; set; }
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
        [JsonProperty("PROD_METHOD")]
        public string PROD_METHOD { get; set; }
        [JsonProperty("PROD_METHOD_DET")]
        public string PROD_METHOD_DET { get; set; }
        [JsonProperty("GAS_LIFT_METHOD")]
        public string GAS_LIFT_METHOD { get; set; }
        [JsonProperty("CALC_OIL_METHOD")]
        public string CALC_OIL_METHOD { get; set; }
        [JsonProperty("CALC_GAS_METHOD")]
        public string CALC_GAS_METHOD { get; set; }
        [JsonProperty("CALC_WATER_METHOD")]
        public string CALC_WATER_METHOD { get; set; }
        [JsonProperty("CALC_COND_METHOD")]
        public string CALC_COND_METHOD { get; set; }
        [JsonProperty("CALC_GAS_INJ_METHOD")]
        public string CALC_GAS_INJ_METHOD { get; set; }
        [JsonProperty("CALC_WATER_INJ_METHOD")]
        public string CALC_WATER_INJ_METHOD { get; set; }
        [JsonProperty("CALC_CO2_INJ_METHOD")]
        public string CALC_CO2_INJ_METHOD { get; set; }
        [JsonProperty("POTENTIAL_METHOD")]
        public string POTENTIAL_METHOD { get; set; }
        [JsonProperty("CHOKE_CODE")]
        public string CHOKE_CODE { get; set; }
        [JsonProperty("CHOKE_UOM")]
        public string CHOKE_UOM { get; set; }
        [JsonProperty("BLOCK_IDENTIFIER")]
        public string BLOCK_IDENTIFIER { get; set; }
        [JsonProperty("WATER_DEPTH")]
        public double? WATER_DEPTH { get; set; }
        [JsonProperty("WATER_DEPTH_UNIT")]
        public string WATER_DEPTH_UNIT { get; set; }
        [JsonProperty("GEOGRAPHIC_COORDINATE_SYSTEM")]
        public string GEOGRAPHIC_COORDINATE_SYSTEM { get; set; }
        [JsonProperty("WELL_LAT")]
        public double? WELL_LAT { get; set; }
        [JsonProperty("WELL_LON")]
        public double? WELL_LON { get; set; }
        [JsonProperty("EASTING")]
        public double? EASTING { get; set; }
        [JsonProperty("NORTHING")]
        public double? NORTHING { get; set; }
        [JsonProperty("PROJECTED_COORDINATE_SYSTEM")]
        public string PROJECTED_COORDINATE_SYSTEM { get; set; }
        [JsonProperty("WELL_LAT_WGS84")]
        public double? WELL_LAT_WGS84 { get; set; }
        [JsonProperty("WELL_LON_WGS84")]
        public double? WELL_LON_WGS84 { get; set; }
        [JsonProperty("SPUD_DATE")]
        public DateTime? SPUD_DATE { get; set; }
        [JsonProperty("WELL_START_DATE")]
        public DateTime? WELL_START_DATE { get; set; }
        [JsonProperty("WELL_END_DATE")]
        public DateTime? WELL_END_DATE { get; set; }
        [JsonProperty("WELL_V_START_DATE")]
        public DateTime? WELL_V_START_DATE { get; set; }
        [JsonProperty("WELL_V_END_DATE")]
        public DateTime? WELL_V_END_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}