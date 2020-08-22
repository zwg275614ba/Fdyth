namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表99建筑面积计算比例
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BSM { get; set; }

        [StringLength(4)]
        public string JSBH { get; set; }

        [StringLength(255)]
        public string JZWMC { get; set; }

        public double? JSBL { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }
    }
}
