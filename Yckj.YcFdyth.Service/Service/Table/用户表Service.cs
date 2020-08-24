using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yckj.YcFdyth.IRepository.IRepository.Table;
using Yckj.YcFdyth.IService.IService.Table;
using Yckj.YcFdyth.Model;
using Yckj.YcFdyth.Service.BaseService;

namespace Yckj.YcFdyth.Service.Service.Table
{
    public class 用户表Service : BaseService<用户表>, I用户表Service
    {
        public I用户表Repository I用户表Repository { get; set; }
        public 用户表Service(I用户表Repository Repository)
        {
            I用户表Repository = Repository;
            CurrentRepository = Repository;
        }
    }
}
