namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_01_02_套内附属建筑面积详表统计
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 标识码 { get; set; }

        [StringLength(20)]
        public string ZRZ号 { get; set; }

        [StringLength(20)]
        public string LJZ号 { get; set; }

        [StringLength(20)]
        public string C号 { get; set; }

        [StringLength(10)]
        public string H型ID { get; set; }

        [StringLength(50)]
        public string 附属建筑类别 { get; set; }

        public decimal? 附属建筑面积 { get; set; }

        public int? 层数 { get; set; }

        public int? 户数 { get; set; }

        public decimal? 计算比例 { get; set; }

        public decimal? 套内附属面积合计 { get; set; }

        public int? 附属个数 { get; set; }

        [StringLength(50)]
        public string 功能分类 { get; set; }

        [StringLength(50)]
        public string 分摊方式 { get; set; }
    }
}
