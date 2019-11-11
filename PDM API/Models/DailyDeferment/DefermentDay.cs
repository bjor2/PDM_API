using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("DEFERMENT_DAY", Schema = "PDM")]
    public class DefermentDay
    {
        [JsonProperty("COUNTRY")]
        public int? COUNTRY { get; set; }
        [JsonProperty("BA_CODE")]
        public int? BA_CODE { get; set; }
        [JsonProperty("RA_CODE")]
        public int? RA_CODE { get; set; }
        [JsonProperty("RU_CODE")]
        public int? RU_CODE { get; set; }
        [JsonProperty("FCTY_CODE")]
        public string FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_CODE")]
        public string GOV_FCTY_CODE { get; set; }
        [JsonProperty("GOV_FCTY_NAME")]
        public string GOV_FCTY_NAME { get; set; }
        [JsonProperty("WELL_NAME")]
        public string WELL_NAME { get; set; }
        [JsonProperty("WELL_OFFICIAL_NAME")]
        public string WELL_OFFICIAL_NAME { get; set; }
        [JsonProperty("WELL_UWI")]
        public int? WELL_UWI { get; set; }
        [JsonProperty("WELL_HOOKUP")]
        public string WELL_HOOKUP { get; set; }
        [JsonProperty("ASSET_CODE")]
        public string ASSET_CODE { get; set; }
        [JsonProperty("ASSET_TYPE")]
        public string ASSET_TYPE { get; set; }
        [JsonProperty("EVENT_ID")]
        public double? EVENT_ID { get; set; }
        [JsonProperty("PROD_DAY")]
        public DateTime? PROD_DAY { get; set; }
        [JsonProperty("STARTDAY")]
        public DateTime? STARTDAY { get; set; }
        [JsonProperty("ENDDAY")]
        public DateTime? ENDDAY { get; set; }
        [JsonProperty("DUR_HRS")]
        public double? DUR_HRS { get; set; }
        [JsonProperty("DEF_OIL")]
        public double? DEF_OIL { get; set; }
        [JsonProperty("DEF_COND")]
        public double? DEF_COND { get; set; }
        [JsonProperty("DEF_GAS")]
        public double? DEF_GAS { get; set; }
        [JsonProperty("REASON_CODE")]
        public string REASON_CODE { get; set; }
        [JsonProperty("SYSTEM_CODE")]
        public string SYSTEM_CODE { get; set; }
        [JsonProperty("TAG_NO")]
        public string TAG_NO { get; set; }
        [JsonProperty("INSTR_TAG_NO")]
        public string INSTR_TAG_NO { get; set; }
        [JsonProperty("COMMENTS")]
        public string COMMENTS { get; set; }
        [JsonProperty("FACILITY_LAT")]
        public int? FACILITY_LAT { get; set; }
        [JsonProperty("FACILITY_LON")]
        public int? FACILITY_LON { get; set; }
        [JsonProperty("WELL_LAT")]
        public int? WELL_LAT { get; set; }
        [JsonProperty("WELL_LON")]
        public int? WELL_LON { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}