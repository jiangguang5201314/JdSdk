#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.80327 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SafWorkPage 属性
    /// </summary>
    [Serializable]
    public class SafWorkPage : JdObject
    {
        /// <summary>
        /// 工单号
        /// </summary>
        [XmlElement("work_id")]
        [JsonProperty("work_id")]
        public Int64 WorkId
        {
            get;
            set;
        }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public Int64 OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 工单状态名
        /// </summary>
        [XmlElement("status_name")]
        [JsonProperty("status_name")]
        public String StatusName
        {
            get;
            set;
        }

        /// <summary>
        /// 工单创建时间
        /// </summary>
        [XmlElement("create_date")]
        [JsonProperty("create_date")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

        /// <summary>
        /// 工单发起内容
        /// </summary>
        [XmlElement("content")]
        [JsonProperty("content")]
        public String Content
        {
            get;
            set;
        }

    }
}
