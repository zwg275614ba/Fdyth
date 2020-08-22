namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FDCQ2
    {
        [Key]
        public int OBJECTID { get; set; }

        [StringLength(255)]
        public string YSDM { get; set; }

        [StringLength(255)]
        public string BDCDYH_ZD { get; set; }

        [StringLength(255)]
        public string BDCDYH { get; set; }

        [StringLength(255)]
        public string YWH { get; set; }

        [StringLength(255)]
        public string QLLX { get; set; }

        [StringLength(255)]
        public string DJLX { get; set; }

        [StringLength(255)]
        public string DJYY { get; set; }

        [StringLength(255)]
        public string FDZL { get; set; }

        [StringLength(255)]
        public string TDSYQR { get; set; }

        [StringLength(255)]
        public string DYTDMJ { get; set; }

        [StringLength(255)]
        public string FTTDMJ { get; set; }

        [StringLength(255)]
        public string TDSYQSSJ { get; set; }

        [StringLength(255)]
        public string TDSYJSSJ { get; set; }

        [StringLength(255)]
        public string FDCJYJG { get; set; }

        [StringLength(255)]
        public string GHYT { get; set; }

        [StringLength(255)]
        public string FWXZ { get; set; }

        [StringLength(255)]
        public string FWJG { get; set; }

        [StringLength(255)]
        public string SZC { get; set; }

        [StringLength(255)]
        public string ZCS { get; set; }

        public double? JZMJ { get; set; }

        [StringLength(255)]
        public string ZYJZMJ { get; set; }

        [StringLength(255)]
        public string FTJZMJ { get; set; }

        public DateTime? JGSJ { get; set; }

        [StringLength(255)]
        public string BDCQZH { get; set; }

        [StringLength(255)]
        public string QXDM { get; set; }

        [StringLength(255)]
        public string DJJG { get; set; }

        [StringLength(255)]
        public string DBR { get; set; }

        [StringLength(255)]
        public string DJSJ { get; set; }

        [StringLength(255)]
        public string FJ { get; set; }

        [StringLength(255)]
        public string QSZT { get; set; }
    }
}
