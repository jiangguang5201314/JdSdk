#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.17979 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// QueryPlanReturnInfo 属性
    /// </summary>
    [Serializable]
    public class QueryPlanReturnInfo : JdObject
    {
        /// <summary>
        /// 计划Id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        /// <summary>
        /// 推广计划名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 所在的广告位Id
        /// </summary>
        [XmlElement("space_id")]
        [JsonProperty("space_id")]
        public Nullable<Int64> SpaceId
        {
            get;
            set;
        }

        /// <summary>
        /// 计划类型1:频道页投放 2:搜索页投放
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Int64> Type
        {
            get;
            set;
        }

        /// <summary>
        /// 日预算
        /// </summary>
        [XmlElement("budget")]
        [JsonProperty("budget")]
        public Nullable<Decimal> Budget
        {
            get;
            set;
        }

        /// <summary>
        /// 计划预算总价
        /// </summary>
        [XmlElement("total_budget")]
        [JsonProperty("total_budget")]
        public Nullable<Decimal> TotalBudget
        {
            get;
            set;
        }

        /// <summary>
        /// 投放模式1：cpd 按日2：cpc    按点击
        /// </summary>
        [XmlElement("mode")]
        [JsonProperty("mode")]
        public Nullable<Decimal> Mode
        {
            get;
            set;
        }

        /// <summary>
        /// 状态1:未提交 2:待审核    3:未通 4:申请失败 5:审核通过6:竞投中    7:暂停 8:终止 9:已结束
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }

        /// <summary>
        /// 状态的名称
        /// </summary>
        [XmlElement("status_name")]
        [JsonProperty("status_name")]
        public String StatusName
        {
            get;
            set;
        }

        /// <summary>
        /// 出现竞价失败的情况，是否放弃之后排期的所有竞价，以便释放被冻结的资金
        /// </summary>
        [XmlElement("allow_split")]
        [JsonProperty("allow_split")]
        public Nullable<Decimal> AllowSplit
        {
            get;
            set;
        }

        /// <summary>
        /// 排期开始时间
        /// </summary>
        [XmlElement("schedule_start")]
        [JsonProperty("schedule_start")]
        public String ScheduleStart
        {
            get;
            set;
        }

        /// <summary>
        /// 排期结束时间
        /// </summary>
        [XmlElement("schedule_end")]
        [JsonProperty("schedule_end")]
        public String ScheduleEnd
        {
            get;
            set;
        }

        /// <summary>
        /// 计划创建时间
        /// </summary>
        [XmlElement("insert_time")]
        [JsonProperty("insert_time")]
        public String InsertTime
        {
            get;
            set;
        }

        /// <summary>
        /// 计划更新时间
        /// </summary>
        [XmlElement("update_time")]
        [JsonProperty("update_time")]
        public String UpdateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 计划提交时间
        /// </summary>
        [XmlElement("submit_time")]
        [JsonProperty("submit_time")]
        public String SubmitTime
        {
            get;
            set;
        }

        /// <summary>
        /// 播放展示方式1:轮播2:自定义
        /// </summary>
        [XmlElement("show_type")]
        [JsonProperty("show_type")]
        public Nullable<Int64> ShowType
        {
            get;
            set;
        }

        /// <summary>
        /// 当天的竞价状态：1竞价成功，2:竞价失败,3:未排期
        /// </summary>
        [XmlElement("bid_status")]
        [JsonProperty("bid_status")]
        public Nullable<Decimal> BidStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 投放广告位名称
        /// </summary>
        [XmlElement("ad_space_name")]
        [JsonProperty("ad_space_name")]
        public String AdSpaceName
        {
            get;
            set;
        }

    }
}
