using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("STREAM_ACC_MONTH", Schema = "PDM")]
    public class StreamAccMonth
    {
        [JsonProperty("PROD_MONTH")]
        public DateTime? PROD_MONTH { get; set; }
        [JsonProperty("FACILITY_CODE")]
        public string FACILITY_CODE { get; set; }
        [JsonProperty("GOV_FACILITY_CODE")]
        public string GOV_FACILITY_CODE { get; set; }
        [JsonProperty("GOV_FACILITY_NAME")]
        public string GOV_FACILITY_NAME { get; set; }
        [JsonProperty("GOV_FIELD_CODE")]
        public string GOV_FIELD_CODE { get; set; }
        [JsonProperty("GOV_FIELD_NAME")]
        public string GOV_FIELD_NAME { get; set; }
        [JsonProperty("COMMERCIAL_ENTITY_CODE")]
        public string COMMERCIAL_ENTITY_CODE { get; set; }
        [JsonProperty("STREAM_CODE")]
        public string STREAM_CODE { get; set; }
        [JsonProperty("STREAM_NAME")]
        public string STREAM_NAME { get; set; }
        [JsonProperty("STREAM_CATEGORY")]
        public string STREAM_CATEGORY { get; set; }
        [JsonProperty("NET_VOL_SM3")]
        public double? NET_VOL_SM3 { get; set; }
        [JsonProperty("NET_MASS_KG")]
        public double? NET_MASS_KG { get; set; }
        [JsonProperty("ENERGY_MJ")]
        public double? ENERGY_MJ { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
    }
}