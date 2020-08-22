namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_500_01_BDC户型表
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 标识码 { get; set; }

        [StringLength(20)]
        public string 自然幢号 { get; set; }

        [StringLength(20)]
        public string 逻辑幢号 { get; set; }

        [StringLength(20)]
        public string 层号 { get; set; }

        public int? 实际层 { get; set; }

        [StringLength(10)]
        public string 户型 { get; set; }

        [StringLength(10)]
        public string 功能 { get; set; }

        [StringLength(50)]
        public string 功能名称 { get; set; }

        public decimal? 套内面积 { get; set; }

        public int? 层数 { get; set; }

        public int? 户数 { get; set; }

        public decimal? 主体面积合计 { get; set; }
    }
}
