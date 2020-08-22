namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表54定着物物特征码字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OBJECTID { get; set; }

        [StringLength(255)]
        public string DZWTZM { get; set; }

        [StringLength(255)]
        public string 定着物特征码 { get; set; }
    }
}
