namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_500_02_BDC附属建筑记录表
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
        public string 附属建筑类别 { get; set; }

        [StringLength(50)]
        public string 附属建筑类别名称 { get; set; }

        [StringLength(10)]
        public string 分摊方式 { get; set; }

        [StringLength(50)]
        public string 分摊方式名称 { get; set; }

        public decimal? 附属建筑面积 { get; set; }

        public int? 层数 { get; set; }

        public int? 个数 { get; set; }

        public decimal? 计算比例 { get; set; }

        public decimal? 附属建筑面积合计 { get; set; }

        public string 备注 { get; set; }

        [StringLength(20)]
        public string 附属建筑ID { get; set; }
    }
}
