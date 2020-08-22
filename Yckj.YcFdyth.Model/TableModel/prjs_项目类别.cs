namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prjs_项目类别
    {
        [Key]
        public int 标识码 { get; set; }

        [StringLength(20)]
        public string 项目类别ID { get; set; }

        [StringLength(20)]
        public string 行业类别ID { get; set; }

        [StringLength(50)]
        public string 项目类别 { get; set; }

        public string 备注 { get; set; }
    }
}
