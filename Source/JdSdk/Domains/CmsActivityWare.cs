#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.79927 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// CmsActivityWare属性
    /// </summary>
    [Serializable]
    public class CmsActivityWare : JdObject
    {
        /// <summary>
        /// 广告词
        /// </summary>
        [XmlElement("adWord")]
        [JsonProperty("adWord")]
        public String AdWord
        {
            get;
            set;
        }

        /// <summary>
        /// 是否为图书
        /// </summary>
        [XmlElement("isBook")]
        [JsonProperty("isBook")]
        public Nullable<Boolean> IsBook
        {
            get;
            set;
        }

        /// <summary>
        /// 是否免费阅读
        /// </summary>
        [XmlElement("canFreeRead")]
        [JsonProperty("canFreeRead")]
        public Nullable<Boolean> CanFreeRead
        {
            get;
            set;
        }

        /// <summary>
        /// 秒杀离结束时间
        /// </summary>
        [XmlElement("endRemainTime")]
        [JsonProperty("endRemainTime")]
        public String EndRemainTime
        {
            get;
            set;
        }

        /// <summary>
        /// 商品图片url
        /// </summary>
        [XmlElement("imageUrl")]
        [JsonProperty("imageUrl")]
        public String ImageUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价
        /// </summary>
        [XmlElement("jdPrice")]
        [JsonProperty("jdPrice")]
        public Int64 JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 市场价
        /// </summary>
        [XmlElement("martPrice")]
        [JsonProperty("martPrice")]
        public Int64 MartPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 秒杀离开始时间
        /// </summary>
        [XmlElement("startRemainTime")]
        [JsonProperty("startRemainTime")]
        public String StartRemainTime
        {
            get;
            set;
        }

        /// <summary>
        /// 商品编号
        /// </summary>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("wareName")]
        [JsonProperty("wareName")]
        public String WareName
        {
            get;
            set;
        }

    }
}
