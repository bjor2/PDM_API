﻿using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDM_API.Models
{
    [Table("ION", Schema = "PDM")]
    public class Ion
    {
        [JsonProperty("WELL_BORE_CODE")]
        public string WELL_BORE_CODE { get; set; }
        [JsonProperty("DATEPRD")]
        public DateTime? DATEPRD { get; set; }
        [JsonProperty("FIELD")]
        public string FIELD { get; set; }
        [JsonProperty("WELL")]
        public string WELL { get; set; }
        [JsonProperty("SAMPLING_PT")]
        public string SAMPLING_PT { get; set; }
        [JsonProperty("FACILITY")]
        public string FACILITY { get; set; }
        [JsonProperty("PROSTY")]
        public string PROSTY { get; set; }
        [JsonProperty("PTYPE")]
        public string PTYPE { get; set; }
        [JsonProperty("NA")]
        public double? NA { get; set; }
        [JsonProperty("K")]
        public double? K { get; set; }
        [JsonProperty("CA")]
        public double? CA { get; set; }
        [JsonProperty("MG")]
        public double? MG { get; set; }
        [JsonProperty("BA")]
        public double? BA { get; set; }
        [JsonProperty("SR")]
        public double? SR { get; set; }
        [JsonProperty("CL")]
        public double? CL { get; set; }
        [JsonProperty("S")]
        public double? S { get; set; }
        [JsonProperty("SO4")]
        public double? SO4 { get; set; }
        [JsonProperty("FE")]
        public double? FE { get; set; }
        [JsonProperty("H2O")]
        public double? H2O { get; set; }
        [JsonProperty("P")]
        public double? P { get; set; }
        [JsonProperty("FE_TOT")]
        public double? FE_TOT { get; set; }
        [JsonProperty("LI")]
        public double? LI { get; set; }
        [JsonProperty("SI")]
        public double? SI { get; set; }
        [JsonProperty("AL")]
        public double? AL { get; set; }
        [JsonProperty("B")]
        public double? B { get; set; }
        [JsonProperty("BICARBONATE")]
        public double? BICARBONATE { get; set; }
        [JsonProperty("CARBONATE")]
        public double? CARBONATE { get; set; }
        [JsonProperty("BR")]
        public double? BR { get; set; }
        [JsonProperty("TOT_ALCALINITY")]
        public double? TOT_ALCALINITY { get; set; }
        [JsonProperty("ORGANIC_ACID")]
        public double? ORGANIC_ACID { get; set; }
        [JsonProperty("SPECIFIC_GRAVITY")]
        public double? SPECIFIC_GRAVITY { get; set; }
        [JsonProperty("RESISTIVITY")]
        public double? RESISTIVITY { get; set; }
        [JsonProperty("DIONEX_SULPHATE")]
        public double? DIONEX_SULPHATE { get; set; }
        [JsonProperty("PH")]
        public double? PH { get; set; }
        [JsonProperty("FORMATE")]
        public double? FORMATE { get; set; }
        [JsonProperty("ACETATE")]
        public double? ACETATE { get; set; }
        [JsonProperty("PROPIONATE")]
        public double? PROPIONATE { get; set; }
        [JsonProperty("BUTYRATE")]
        public double? BUTYRATE { get; set; }
        [JsonProperty("SUSPENDED_SOLIDS")]
        public double? SUSPENDED_SOLIDS { get; set; }
        [JsonProperty("VALERIC")]
        public double? VALERIC { get; set; }
        [JsonProperty("HEXANOIC")]
        public double? HEXANOIC { get; set; }
        [JsonProperty("TDS")]
        public double? TDS { get; set; }
        [JsonProperty("AL_WT")]
        public double? AL_WT { get; set; }
        [JsonProperty("BA_WT")]
        public double? BA_WT { get; set; }
        [JsonProperty("CA_WT")]
        public double? CA_WT { get; set; }
        [JsonProperty("CR_WT")]
        public double? CR_WT { get; set; }
        [JsonProperty("CU_WT")]
        public double? CU_WT { get; set; }
        [JsonProperty("FE_WT")]
        public double? FE_WT { get; set; }
        [JsonProperty("K_WT")]
        public double? K_WT { get; set; }
        [JsonProperty("MG_WT")]
        public double? MG_WT { get; set; }
        [JsonProperty("MN_WT")]
        public double? MN_WT { get; set; }
        [JsonProperty("NA_WT")]
        public double? NA_WT { get; set; }
        [JsonProperty("NI_WT")]
        public double? NI_WT { get; set; }
        [JsonProperty("P_WT")]
        public double? P_WT { get; set; }
        [JsonProperty("PB_WT")]
        public double? PB_WT { get; set; }
        [JsonProperty("SI_WT")]
        public double? SI_WT { get; set; }
        [JsonProperty("SR_WT")]
        public double? SR_WT { get; set; }
        [JsonProperty("TI_WT")]
        public double? TI_WT { get; set; }
        [JsonProperty("ZN_WT")]
        public double? ZN_WT { get; set; }
        [JsonProperty("S_WT")]
        public double? S_WT { get; set; }
        [JsonProperty("CL_WT")]
        public double? CL_WT { get; set; }
        [JsonProperty("DEPTH_MD")]
        public double? DEPTH_MD { get; set; }
        [JsonProperty("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
        [JsonProperty("INHIBITOR")]
        public double? INHIBITOR { get; set; }
        [JsonProperty("SWMG")]
        public double? SWMG { get; set; }
        [JsonProperty("SWSO4")]
        public double? SWSO4 { get; set; }
        [JsonProperty("LABORATORY")]
        public string LABORATORY { get; set; }
        [JsonProperty("WELLBORE_PART_SORT")]
        public string WELLBORE_PART_SORT { get; set; }
        [JsonProperty("WELLBORE_S")]
        public string WELLBORE_S { get; set; }
        [JsonProperty("WELLBORE_PART_S")]
        public string WELLBORE_PART_S { get; set; }
        [JsonProperty("WELL_SORTNAME")]
        public string WELL_SORTNAME { get; set; }
        [JsonProperty("WELL_S")]
        public string WELL_S { get; set; }
        [JsonProperty("ROW_CREATOR")]
        public string ROW_CREATOR { get; set; }
        [JsonProperty("ROW_CREATE_DATE")]
        public DateTime? ROW_CREATE_DATE { get; set; }
        [JsonProperty("UPDATOR")]
        public string UPDATOR { get; set; }
        [JsonProperty("UPDATE_DATE")]
        public DateTime? UPDATE_DATE { get; set; }
        [JsonProperty("WATER_SAMPLE_S")]
        public string WATER_SAMPLE_S { get; set; }
        [JsonProperty("GENERAL_INHIBITOR")]
        public double? GENERAL_INHIBITOR { get; set; }
        [JsonProperty("SA_1360")]
        public double? SA_1360 { get; set; }
        [JsonProperty("SA_1650")]
        public double? SA_1650 { get; set; }
        [JsonProperty("SA_1820")]
        public double? SA_1820 { get; set; }
        [JsonProperty("SA_3050")]
        public double? SA_3050 { get; set; }
        [JsonProperty("SA_3070")]
        public double? SA_3070 { get; set; }
        [JsonProperty("SA_3110")]
        public double? SA_3110 { get; set; }
        [JsonProperty("SA_3120")]
        public double? SA_3120 { get; set; }
        [JsonProperty("SA_3130")]
        public double? SA_3130 { get; set; }
        [JsonProperty("SA_3190")]
        public double? SA_3190 { get; set; }
        [JsonProperty("SA_3200")]
        public double? SA_3200 { get; set; }
        [JsonProperty("SD_250")]
        public double? SD_250 { get; set; }
        [JsonProperty("SD_4108")]
        public double? SD_4108 { get; set; }
        [JsonProperty("SI_4262")]
        public double? SI_4262 { get; set; }
        [JsonProperty("SI_4470")]
        public double? SI_4470 { get; set; }
        [JsonProperty("SI_4516")]
        public double? SI_4516 { get; set; }
        [JsonProperty("SI_4544")]
        public double? SI_4544 { get; set; }
        [JsonProperty("SI_4569")]
        public double? SI_4569 { get; set; }
        [JsonProperty("SI_4573")]
        public double? SI_4573 { get; set; }
        [JsonProperty("SI_4610")]
        public double? SI_4610 { get; set; }
        [JsonProperty("ST_8057")]
        public double? ST_8057 { get; set; }
        [JsonProperty("ST_8061")]
        public double? ST_8061 { get; set; }
        [JsonProperty("ST_8199C")]
        public double? ST_8199C { get; set; }
        [JsonProperty("ST_8217")]
        public double? ST_8217 { get; set; }
        [JsonProperty("ST_852NW")]
        public double? ST_852NW { get; set; }
        [JsonProperty("EPT_2447")]
        public double? EPT_2447 { get; set; }
        [JsonProperty("EC6660")]
        public double? EC6660 { get; set; }
        [JsonProperty("SA1110N")]
        public double? SA1110N { get; set; }
        [JsonProperty("ST_888")]
        public double? ST_888 { get; set; }
        [JsonProperty("SI_4584")]
        public double? SI_4584 { get; set; }
        [JsonProperty("SI_4485")]
        public double? SI_4485 { get; set; }
        [JsonProperty("SI_4520")]
        public double? SI_4520 { get; set; }
        [JsonProperty("ST_TP_8385")]
        public double? ST_TP_8385 { get; set; }
        [JsonProperty("SI_4133")]
        public double? SI_4133 { get; set; }
        [JsonProperty("SI_440")]
        public double? SI_440 { get; set; }
        [JsonProperty("SI_4001")]
        public double? SI_4001 { get; set; }
        [JsonProperty("SI_400_R")]
        public double? SI_400_R { get; set; }
        [JsonProperty("SI_400_T")]
        public double? SI_400_T { get; set; }
        [JsonProperty("SI_4041")]
        public double? SI_4041 { get; set; }
        [JsonProperty("SI_4123")]
        public double? SI_4123 { get; set; }
        [JsonProperty("SI_4471")]
        public double? SI_4471 { get; set; }
        [JsonProperty("SI_4503")]
        public double? SI_4503 { get; set; }
        [JsonProperty("SI_4536")]
        public double? SI_4536 { get; set; }
        [JsonProperty("SI_4538")]
        public double? SI_4538 { get; set; }
        [JsonProperty("SI_4613")]
        public double? SI_4613 { get; set; }
        [JsonProperty("SI_4634")]
        public double? SI_4634 { get; set; }
        [JsonProperty("LAB_REF_NUMBER")]
        public string LAB_REF_NUMBER { get; set; }
        [JsonProperty("EC6660A")]
        public double? EC6660A { get; set; }
        [JsonProperty("EPT_2736")]
        public double? EPT_2736 { get; set; }
        [JsonProperty("EPT_2790")]
        public double? EPT_2790 { get; set; }
        [JsonProperty("FX2504")]
        public double? FX2504 { get; set; }
        [JsonProperty("INITIAL_WELL_ID")]
        public string INITIAL_WELL_ID { get; set; }
        [JsonProperty("KI_3775")]
        public double? KI_3775 { get; set; }
        [JsonProperty("KI_3837")]
        public double? KI_3837 { get; set; }
        [JsonProperty("KI_3993")]
        public double? KI_3993 { get; set; }
        [JsonProperty("KI_3343")]
        public double? KI_3343 { get; set; }
        [JsonProperty("RN_467")]
        public double? RN_467 { get; set; }
        [JsonProperty("SA_1470")]
        public double? SA_1470 { get; set; }
        [JsonProperty("SA_3760")]
        public double? SA_3760 { get; set; }
        [JsonProperty("SA_3800")]
        public double? SA_3800 { get; set; }
        [JsonProperty("SA_3880")]
        public double? SA_3880 { get; set; }
        [JsonProperty("SI_4130")]
        public double? SI_4130 { get; set; }
        [JsonProperty("SI_4134")]
        public double? SI_4134 { get; set; }
        [JsonProperty("SI_4136")]
        public double? SI_4136 { get; set; }
        [JsonProperty("SI_4142")]
        public double? SI_4142 { get; set; }
        [JsonProperty("SI_4489")]
        public double? SI_4489 { get; set; }
        [JsonProperty("SI_4575")]
        public double? SI_4575 { get; set; }
        [JsonProperty("ST8241")]
        public double? ST8241 { get; set; }
        [JsonProperty("STTP8441")]
        public double? STTP8441 { get; set; }
        [JsonProperty("FWMG")]
        public double? FWMG { get; set; }
        [JsonProperty("FWSO4")]
        public double? FWSO4 { get; set; }
        [JsonProperty("FWBA")]
        public double? FWBA { get; set; }
        [JsonProperty("FWSR")]
        public double? FWSR { get; set; }
        [JsonProperty("WELLBORE_PART_ID")]
        public string WELLBORE_PART_ID { get; set; }
    }
}