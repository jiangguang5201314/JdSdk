#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.75827 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ItemInfo结构（针对赠品、加价购 会出现相同的item）
    /// </summary>
    [Serializable]
    public class ItemInfoitem : JdObject
    {
        /// <summary>
        /// 京东内部SKU的ID
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// SKU外部ID
        /// </summary>
        [XmlElement("outer_sku_id")]
        [JsonProperty("outer_sku_id")]
        public String OuterSkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的名称+SKU规格（比如 艾米AMII2013秋装撞色休闲个性立体挖袋中长款T恤11300247 灰色 S）
        /// </summary>
        [XmlElement("sku_name")]
        [JsonProperty("sku_name")]
        public String SkuName
        {
            get;
            set;
        }

        /// <summary>
        /// SKU的京东价，优惠之前的
        /// </summary>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 赠送积分
        /// </summary>
        [XmlElement("gift_point")]
        [JsonProperty("gift_point")]
        public String GiftPoint
        {
            get;
            set;
        }

        /// <summary>
        /// 京东内部商品ID
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("item_total")]
        [JsonProperty("item_total")]
        public Int64 ItemTotal
        {
            get;
            set;
        }

    }
}
