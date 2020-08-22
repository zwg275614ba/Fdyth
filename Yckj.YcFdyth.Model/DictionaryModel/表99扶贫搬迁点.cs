namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表99扶贫搬迁点
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OBJECTID { get; set; }

        [StringLength(255)]
        public string SHAPE { get; set; }

        [StringLength(255)]
        public string 乡镇代码 { get; set; }

        [StringLength(255)]
        public string 乡镇名称 { get; set; }

        [StringLength(255)]
        public string 村委会代码 { get; set; }

        [StringLength(255)]
        public string 村委会名称 { get; set; }

        [StringLength(255)]
        public string 安置点代码 { get; set; }

        [StringLength(255)]
        public string 安置点名 { get; set; }

        [StringLength(255)]
        public string 入驻时间 { get; set; }

        [StringLength(255)]
        public string 实施年代 { get; set; }

        [StringLength(255)]
        public string 备注 { get; set; }
    }
}
