namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C
    {
        [Key]
        public int OBJECTID { get; set; }

        [StringLength(20)]
        public string CH { get; set; }

        [StringLength(20)]
        public string ZRZH { get; set; }

        [StringLength(20)]
        public string LJZH { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        public int? SJC { get; set; }

        [StringLength(50)]
        public string MYC { get; set; }

        public double? CJZMJ { get; set; }

        public double? CTNJZMJ { get; set; }

        public double? CYTMJ { get; set; }

        public double? CGYJZMJ { get; set; }

        public double? CFTJZMJ { get; set; }

        public double? CBQMJ { get; set; }

        public double? CG { get; set; }

        public double? SPTYMJ { get; set; }
    }
}
