#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.77027 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ResultInfoDTO 属性
    /// </summary>
    [Serializable]
    public class ResultInfoDTO : JdObject
    {
        /// <summary>
        /// 结果编码
        /// </summary>
        /// <example>100</example>
        [XmlElement("code")]
        [JsonProperty("code")]
        public String Code
        {
            get;
            set;
        }

        /// <summary>
        /// 结果描述
        /// </summary>
        /// <example>成功</example>
        [XmlElement("message")]
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        /// <summary>
        /// 商家订单号
        /// </summary>
        /// <example>658898</example>
        [XmlElement("orderId")]
        [JsonProperty("orderId")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 京东运单号.
        /// </summary>
        /// <example>000989987688</example>
        [XmlElement("deliveryId")]
        [JsonProperty("deliveryId")]
        public String DeliveryId
        {
            get;
            set;
        }

    }
}
