namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表26建设用地使用权JSYDSYQ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OBJECTID { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(19)]
        public string ZDDM { get; set; }

        [StringLength(28)]
        public string BDCDYH { get; set; }

        [StringLength(20)]
        public string YWH { get; set; }

        [StringLength(2)]
        public string QLLX { get; set; }

        [StringLength(6)]
        public string DJLX { get; set; }

        public string DJYY { get; set; }

        public float? SYQMJ { get; set; }

        public DateTime? SYQQSSJ { get; set; }

        public DateTime? SYQJSSJ { get; set; }

        public float? QDJG { get; set; }

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
