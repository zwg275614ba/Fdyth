namespace Yckj.YcFdyth.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 用户表
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string LoginPwd { get; set; }
    }
}
