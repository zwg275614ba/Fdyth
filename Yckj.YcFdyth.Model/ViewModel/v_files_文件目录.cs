namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_files_文件目录
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 标识码 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 编号 { get; set; }

        public int? 上级编号 { get; set; }

        [StringLength(200)]
        public string 目录名称 { get; set; }

        [StringLength(30)]
        public string 目录编码 { get; set; }

        public int? 存储级别 { get; set; }

        [StringLength(20)]
        public string 项目类别 { get; set; }

        [StringLength(50)]
        public string 项目类别名称 { get; set; }

        public string 备注 { get; set; }
    }
}
