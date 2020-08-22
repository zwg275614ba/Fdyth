namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 安置点关联表
    {
        [Key]
        public int OBJECTID { get; set; }

        [StringLength(50)]
        public string 安置点代码 { get; set; }

        [StringLength(100)]
        public string BDCDYH { get; set; }

        [StringLength(50)]
        public string ZDDM { get; set; }

        [StringLength(50)]
        public string ZRZH { get; set; }
    }
}
