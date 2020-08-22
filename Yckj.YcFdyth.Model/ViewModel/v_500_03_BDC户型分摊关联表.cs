namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_500_03_BDC户型分摊关联表
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 标识码 { get; set; }

        public int? 户型标识码 { get; set; }

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

        public int? 附属建筑标识码 { get; set; }

        [StringLength(10)]
        public string 附属建筑类别 { get; set; }

        [StringLength(50)]
        public string 附属建筑类别名称 { get; set; }

        [StringLength(10)]
        public string 分摊方式 { get; set; }

        [StringLength(50)]
        public string 分摊方式名称 { get; set; }

        public decimal? 附属建筑面积 { get; set; }

        public int? 附属层数 { get; set; }

        public int? 附属个数 { get; set; }

        public decimal? 计算比例 { get; set; }

        public decimal? 附属建筑面积合计 { get; set; }

        [StringLength(20)]
        public string 附属建筑ID { get; set; }
    }
}
