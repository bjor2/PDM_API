using Microsoft.EntityFrameworkCore;
using System;
using PDM_API.Models;
using Microsoft.Extensions.Configuration;

namespace PDM_API
{
    public class PDMContext : DbContext
    {
        IConfiguration _config;

        public PDMContext(DbContextOptions<PDMContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sets up the connection to the SQL server
            optionsBuilder.UseSqlServer(_config.GetConnectionString("pdmDatabase"),
                opts => {
                    opts.EnableRetryOnFailure();
                    // Changes the timeout period to one minute instead of the default 30 seconds
                    opts.CommandTimeout((int)TimeSpan.FromMinutes(1).TotalSeconds); }
              );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DefermentDay>().HasKey(e => new { e.PROD_DAY, e.EVENT_ID, e.STARTDAY, e.GOV_FCTY_CODE });
            modelBuilder.Entity<FacilityMaster>().HasKey(e => new { e.FCTY_CODE, e.FCTY_NAME, e.FCTY_V_START_DATE });
            modelBuilder.Entity<FacilityOpComments>().HasKey(e => new { e.FCTY_CODE, e.COMMENT_DAYTIME, e.COMMENT_ID, e.DBSOURCE_ID });
            modelBuilder.Entity<FieldMaster>().HasKey(e => new { e.FIELD_ID_EC, e.FIELD_V_START_DATE, e.DBSOURCE_ID });
            modelBuilder.Entity<FlowlineMaster>().HasKey(e => new { e.FCTY_CODE, e.FLW_CODE, e.FLW_V_START_DATE, e.DBSOURCE_ID });
            modelBuilder.Entity<FlwInjDay>().HasKey(e => new { e.PROD_MONTH, e.PROD_DAY, e.FCTY_CODE, e.FLW_CODE, e.FLW_TYPE });
            modelBuilder.Entity<FlwProdDay>().HasKey(e => new { e.PROD_MONTH, e.PROD_DAY, e.FCTY_CODE, e.FLW_CODE, e.FLW_TYPE });
            modelBuilder.Entity<ImsTagMapping>().HasKey(e => new { e.TAG_ID, e.SOURCE_ID, e.DBSOURCE_ID });
            modelBuilder.Entity<Ion>().HasKey(e => new { e.DATEPRD, e.WELL_BORE_CODE });
            modelBuilder.Entity<PressureTest>().HasKey(e => new { e.WELL_BORE_CODE, e.DATEPRD, e.TEST_TYPE });
            modelBuilder.Entity<StreamAccMonth>().HasKey(e => new { e.PROD_MONTH, e.FACILITY_CODE, e.STREAM_CODE, e.COMMERCIAL_ENTITY_CODE });
            modelBuilder.Entity<StreamAllocDay>().HasKey(e => new { e.PROD_DAY, e.FCTY_CODE, e.STREAM_ID_EC, e.DBDATA_CLASS, e.DBSOURCE_ID });
            modelBuilder.Entity<StreamAnalysisComp>().HasKey(e => new { /*e.PRODUCTION_DAY,*/ e.VALID_FROM_DATE, e.FACILITY_CODE, e.CODE, e.PHASE, e.ANALYSIS_TYPE, e.SAMPLING_METHOD, e.ANALYSIS_STATUS });
            modelBuilder.Entity<StreamMaster>().HasKey(e => new { e.FCTY_CODE, e.STREAM_CODE, e.STREAM_V_START_DATE, e.DBSOURCE_ID });
            modelBuilder.Entity<StreamMeasDay>().HasKey(e => new { e.PROD_DAY, e.FCTY_CODE, /*e.STREAM_ID_EC,*/ e.DBDATA_CLASS, e.DBSOURCE_ID });
            modelBuilder.Entity<StreamPcAllocDay>().HasKey(e => new { e.PROD_DAY, e.PROFIT_CENTRE, e.STREAM_ID_EC, e.DBDATA_CLASS, e.DBSOURCE_ID });
            modelBuilder.Entity<TracerInj>().HasKey(e => new { e.DATEPRD, e.WELL_BORE_CODE });
            modelBuilder.Entity<TracerProd>().HasKey(e => new { e.DATEPRD, e.WELL_BORE_CODE });
            modelBuilder.Entity<TracerProdComb>().HasKey(e => new { e.DATEPRD, e.WELL_BORE_CODE, e.FACILITY });
            modelBuilder.Entity<WellBoreInjDay>().HasKey(e => new { e.PROD_DAY, e.PERF_CODE, e.WB_V_START_DATE, e.DBSOURCE_ID });
            modelBuilder.Entity<WellBoreProdDay>().HasKey(e => new { e.PROD_DAY, e.PERF_CODE, e.WB_V_START_DATE, e.DBSOURCE_ID });
            modelBuilder.Entity<WellEvent>().HasKey(e => new { e.WELL_CODE, e.WELL_BORE_CODE });
            modelBuilder.Entity<WellInjDay>().HasKey(e => new { e.PROD_DAY, e.WELL_ID_EC, e.INJ_TYPE, e.DBSOURCE_ID });
            modelBuilder.Entity<WellMaster>().HasKey(e => new { e.WELL_OFFICIAL_NAME, e.WELL_CODE, e.WELL_START_DATE });
            modelBuilder.Entity<WellPerformanceCurve>().HasKey(e => new { e.WELL_OFFICIAL_NAME, e.VALID_FROM_DATE, e.PERF_CURVE_ID, e.SEQ });
            modelBuilder.Entity<WellProdDay>().HasKey(e => new { e.PROD_DAY, e.WELL_ID_EC, e.DBSOURCE_ID});
            modelBuilder.Entity<WellBoreMaster>().HasKey(e => new { /*e.UNIQUE_WB_ID,*/ e.WB_V_START_DATE, e.DBSOURCE_ID });

            // New 2019-09-06
            modelBuilder.Entity<IonComb>().HasKey(e => new { e.DATEPRD, e.FIELD, e.WELL, e.WELL_BORE_CODE, e.WELLBORE_S });
            modelBuilder.Entity<StreamAllocBalanceDay>().HasKey(e => new { e.PROD_DAY, e.FCTY_CODE, e.DBDATA_CLASS, e.DBSOURCE_ID });
            modelBuilder.Entity<WellActivity>().HasKey(e => new { e.WELL_BORE_CODE, e.DAYTIME, e.ACTIVITY_CODE, e.PTYPE });
            modelBuilder.Entity<WellTestResult>().HasKey(e => new { e.DATEPRD, e.RESULT_NO });
        }


        public DbSet<DefermentDay> DefermentDay { get; set; }
        public DbSet<FacilityMaster> FacilityMaster { get; set; }
        public DbSet<FacilityOpComments> FacilityOpComments { get; set; }
        public DbSet<FieldMaster> FieldMaster { get; set; }
        public DbSet<FlowlineMaster> FlowlineMaster { get; set; }
        public DbSet<FlwInjDay> FlwInjDay { get; set; }
        public DbSet<FlwProdDay> FlwProdDay { get; set; }
        public DbSet<ImsTagMapping> ImsTagMapping { get; set; }
        public DbSet<Ion> Ion { get; set; }
        public DbSet<PressureTest> PressureTest { get; set; }
        public DbSet<StreamAccMonth> StreamAccMonth { get; set; }
        public DbSet<StreamAllocDay> StreamAllocDay { get; set; }
        public DbSet<StreamAnalysisComp> StreamAnalysisComp { get; set; }
        public DbSet<StreamMaster> StreamMaster { get; set; }
        public DbSet<StreamMeasDay> StreamMeasDay { get; set; }
        public DbSet<StreamPcAllocDay> StreamPcAllocDay { get; set; }
        public DbSet<TracerInj> TracerInj { get; set; }
        public DbSet<TracerProd> TracerProd { get; set; }
        public DbSet<TracerProdComb> TracerProdComb { get; set; }
        public DbSet<WellBoreInjDay> WellBoreInjDay { get; set; }
        public DbSet<WellBoreProdDay> WellBoreProdDay { get; set; }
        public DbSet<WellEvent> WellEvent { get; set; }
        public DbSet<WellInjDay> WellInjDay { get; set; }
        public DbSet<WellMaster> WellMaster { get; set; }
        public DbSet<WellPerformanceCurve> WellPerformanceCurve { get; set; }
        public DbSet<WellProdDay> WellProdDay { get; set; }
        public DbSet<WellBoreMaster> WellBoreMaster { get; set; }

        // New 2019-09-06
        public DbSet<IonComb> IonComb { get; set; }
        public DbSet<StreamAllocBalanceDay> StreamAllocBalanceDay { get; set; }
        public DbSet<WellActivity> WellActivity { get; set; }
        public DbSet<WellTestResult> WellTestResult { get; set; }
    }
}