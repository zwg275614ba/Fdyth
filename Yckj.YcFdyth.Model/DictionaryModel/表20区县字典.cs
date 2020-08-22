namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表20区县字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OBJECTID { get; set; }

        [StringLength(255)]
        public string QXDM { get; set; }

        [StringLength(255)]
        public string 省 { get; set; }

        [StringLength(255)]
        public string 州 { get; set; }

        [StringLength(255)]
        public string 区县 { get; set; }
    }
}
