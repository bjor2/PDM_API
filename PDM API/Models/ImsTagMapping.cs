using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("IMS_TAG_MAPPING", Schema = "PDM")]
    public class ImsTagMapping
    {
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
        [JsonProperty("DATA_CLASS")]
        public string DATA_CLASS { get; set; }
        [JsonProperty("DATA_ATTR_NAME")]
        public string DATA_ATTR_NAME { get; set; }
        [JsonProperty("OBJECT_TYPE")]
        public string OBJECT_TYPE { get; set; }
        [JsonProperty("OBJECT_NAME")]
        public string OBJECT_NAME { get; set; }
        [JsonProperty("OBJECT_CODE")]
        public string OBJECT_CODE { get; set; }
        [JsonProperty("SOURCE_ID")]
        public string SOURCE_ID { get; set; }
        [JsonProperty("TAG_ID")]
        public string TAG_ID { get; set; }
        [JsonProperty("TEMPLATE_CODE")]
        public string TEMPLATE_CODE { get; set; }
        [JsonProperty("FROM_UNIT")]
        public string FROM_UNIT { get; set; }
        [JsonProperty("TO_UNIT")]
        public string TO_UNIT { get; set; }
        [JsonProperty("ACTIVE")]
        public string ACTIVE { get; set; }
        [JsonProperty("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("DBSOURCE")]
        public string DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string DBSOURCE_ID { get; set; }
    }
}