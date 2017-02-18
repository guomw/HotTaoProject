using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTaoCore.Models
{
    /// <summary>
    /// 任务计划实体
    /// </summary>
    public class TaskPlanModel
    {
        public int id { get; set; }

        public int userid { get; set; }

        public string title { get; set; }

        public int status { get; set; }

        public string statusText { get; set; }
        public DateTime startTime { get; set; }
        public string goodsText { get; set; }

        public string pidsText { get; set; }

        public DateTime createTime { get; set; }
    }


    /// <summary>
    /// 任务计划推广位实体
    /// </summary>
    public class TaskPidModel
    {
        public int pid { get; set; }
    }


    /// <summary>
    /// 任务计划商品和推广位日志
    /// </summary>
    public class TaskGoodsPidLogModel
    {
        public int id { get; set; }

        public int userid { get; set; }

        public int taskid { get; set; }

        public int goodsid { get; set; }


        public int pid { get; set; }

        public DateTime createtime { get; set; }

        /// <summary>
        /// 生成淘口令分享文本
        /// </summary>
        public string shareText { get; set; }

    }

}
