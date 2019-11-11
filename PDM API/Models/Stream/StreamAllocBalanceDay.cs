﻿using Newtonsoft.Json;using System;
using System.ComponentModel.DataAnnotations.Schema;namespace PDM_API.Models{    [Table("STREAM_ALLOC_BALANCE_DAY", Schema = "PDM")]    public class StreamAllocBalanceDay    {        [JsonProperty("PROD_MONTH")]        public DateTime? PROD_MONTH { get; set; }        [JsonProperty("PROD_DAY")]        public DateTime? PROD_DAY { get; set; }        [JsonProperty("COUNTRY")]        public string COUNTRY { get; set; }        [JsonProperty("COUNTRY_NAME")]        public string COUNTRY_NAME { get; set; }        [JsonProperty("BA_CODE")]        public string BA_CODE { get; set; }        [JsonProperty("RA_CODE")]        public string RA_CODE { get; set; }        [JsonProperty("BU_CODE")]        public string BU_CODE { get; set; }        [JsonProperty("GOV_FCTY_CODE")]        public string GOV_FCTY_CODE { get; set; }        [JsonProperty("GOV_FCTY_NAME")]        public string GOV_FCTY_NAME { get; set; }        [JsonProperty("GOV_FIELD_CODE")]        public string GOV_FIELD_CODE { get; set; }        [JsonProperty("GOV_FIELD_NAME")]        public string GOV_FIELD_NAME { get; set; }        [JsonProperty("COMMERCIAL_ENTITY")]        public string COMMERCIAL_ENTITY { get; set; }        [JsonProperty("STREAM_CODE")]        public string STREAM_CODE { get; set; }        [JsonProperty("STREAM_NAME")]        public string STREAM_NAME { get; set; }        [JsonProperty("STREAM_PHASE")]        public string STREAM_PHASE { get; set; }        [JsonProperty("STREAM_CATEGORY")]        public string STREAM_CATEGORY { get; set; }        [JsonProperty("STREAM_TYPE")]        public string STREAM_TYPE { get; set; }        [JsonProperty("FLOW_KIND")]        public string FLOW_KIND { get; set; }        [JsonProperty("QUALIFIER")]        public string QUALIFIER { get; set; }        [JsonProperty("PRODUCT")]        public string PRODUCT { get; set; }        [JsonProperty("GRS_VOL_METHOD")]        public string GRS_VOL_METHOD { get; set; }        [JsonProperty("NET_VOL_METHOD")]        public string NET_VOL_METHOD { get; set; }        [JsonProperty("GRS_MASS_METHOD")]        public string GRS_MASS_METHOD { get; set; }        [JsonProperty("NET_MASS_METHOD")]        public string NET_MASS_METHOD { get; set; }        [JsonProperty("STD_DENSITY_METHOD")]        public string STD_DENSITY_METHOD { get; set; }        [JsonProperty("ENERGY_METHOD")]        public string ENERGY_METHOD { get; set; }        [JsonProperty("HC_LIQ_PHASE")]        public string HC_LIQ_PHASE { get; set; }        [JsonProperty("FCTY_CODE")]        public string FCTY_CODE { get; set; }        [JsonProperty("FCTY_NAME")]        public string FCTY_NAME { get; set; }        [JsonProperty("RG_CODE")]        public string RG_CODE { get; set; }        [JsonProperty("RG_name")]        public string RG_name { get; set; }        [JsonProperty("REPORT_NAME")]        public string REPORT_NAME { get; set; }        [JsonProperty("BUSINESS_AREA")]        public string BUSINESS_AREA { get; set; }        [JsonProperty("description")]        public string description { get; set; }        [JsonProperty("sort_order")]        public double? sort_order { get; set; }        [JsonProperty("rg_start_date")]        public DateTime? rg_start_date { get; set; }        [JsonProperty("rg_end_date")]        public DateTime? rg_end_date { get; set; }        [JsonProperty("conn_start_date")]        public DateTime? conn_start_date { get; set; }        [JsonProperty("conn_end_date")]        public DateTime? conn_end_date { get; set; }        [JsonProperty("GRS_VOL")]        public double? GRS_VOL { get; set; }        [JsonProperty("GRS_VOL_UOM")]        public string GRS_VOL_UOM { get; set; }        [JsonProperty("THEOR_NET_VOL")]        public double? THEOR_NET_VOL { get; set; }        [JsonProperty("THEOR_NET_MASS_KG")]        public double? THEOR_NET_MASS_KG { get; set; }        [JsonProperty("NET_VOL")]        public double? NET_VOL { get; set; }        [JsonProperty("NET_VOL_UOM")]        public string NET_VOL_UOM { get; set; }        [JsonProperty("GRS_MASS_KG")]        public double? GRS_MASS_KG { get; set; }        [JsonProperty("NET_MASS_KG")]        public double? NET_MASS_KG { get; set; }        [JsonProperty("ENERGY_MJ")]        public double? ENERGY_MJ { get; set; }        [JsonProperty("DENSITY_KGPERSM3")]        public double? DENSITY_KGPERSM3 { get; set; }        [JsonProperty("REF_STREAM_ANAL_CODE")]        public string REF_STREAM_ANAL_CODE { get; set; }        [JsonProperty("REF_STREAM_ALLOC_CODE")]        public string REF_STREAM_ALLOC_CODE { get; set; }        [JsonProperty("FACILITY_LAT")]        public double? FACILITY_LAT { get; set; }        [JsonProperty("FACILITY_LON")]        public double? FACILITY_LON { get; set; }        [JsonProperty("STREAM_START_DATE")]        public DateTime? STREAM_START_DATE { get; set; }        [JsonProperty("STREAM_END_DATE")]        public DateTime? STREAM_END_DATE { get; set; }        [JsonProperty("LAST_CHANGED")]        public DateTime? LAST_CHANGED { get; set; }        [JsonProperty("DBDATA_CLASS")]        public string DBDATA_CLASS { get; set; }        [JsonProperty("DBSOURCE")]        public string DBSOURCE { get; set; }        [JsonProperty("DBSOURCE_ID")]        public string DBSOURCE_ID { get; set; }    }}