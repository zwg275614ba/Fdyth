namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("表27房地产权（多幢）FDCQ1")]
    public partial class 表27房地产权_多幢_FDCQ1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OBJECTID { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(28)]
        public string BDCDYH { get; set; }

        [StringLength(20)]
        public string YWH { get; set; }

        [StringLength(2)]
        public string QLLX { get; set; }

        [StringLength(6)]
        public string DJLX { get; set; }

        public string DJYY { get; set; }

        [StringLength(200)]
        public string FDZL { get; set; }

        public string TDSYQR { get; set; }

        public float? DYTDMJ { get; set; }

        public float? FTYDMJ { get; set; }

        public DateTime? TDSYQSSJ { get; set; }

        public DateTime? TDSYJSSJ { get; set; }

        public float? FDCJYJG { get; set; }

        public string BDCQZH { get; set; }

        [StringLength(20)]
        public string QXDM { get; set; }

        [StringLength(200)]
        public string DJJG { get; set; }

        [StringLength(50)]
        public string DBR { get; set; }

        public DateTime? DJSJ { get; set; }

        public string FJ { get; set; }

        [StringLength(2)]
        public string QSZT { get; set; }
    }
}
