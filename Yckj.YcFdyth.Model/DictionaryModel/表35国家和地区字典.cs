namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 表35国家和地区字典
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OBJECTID { get; set; }

        [StringLength(255)]
        public string GJ { get; set; }

        [StringLength(255)]
        public string 国家和地区 { get; set; }
    }
}
