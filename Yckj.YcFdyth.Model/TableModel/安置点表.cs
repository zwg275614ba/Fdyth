namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 安置点表
    {
        [Key]
        public int OBJECTID { get; set; }

        [StringLength(50)]
        public string 乡镇代码 { get; set; }

        [StringLength(50)]
        public string 乡镇名称 { get; set; }

        [StringLength(50)]
        public string 村委会代码 { get; set; }

        [StringLength(50)]
        public string 村委会名称 { get; set; }

        [StringLength(50)]
        public string 安置点代码 { get; set; }

        [StringLength(100)]
        public string 安置点名 { get; set; }

        public string 备注 { get; set; }
    }
}
