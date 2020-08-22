namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_01_01_套内主体面积统计表
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

        [StringLength(10)]
        public string 功能分类ID { get; set; }

        [StringLength(50)]
        public string 功能分类 { get; set; }

        public decimal? 套内面积 { get; set; }

        public int? 层数 { get; set; }

        public int? 户数 { get; set; }

        public decimal? 主体面积合计 { get; set; }
    }
}
