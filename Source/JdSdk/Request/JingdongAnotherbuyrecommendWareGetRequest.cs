#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:22.72164 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取购买此商品的用户还购买的商品 Request
    /// </summary>
    public class JingdongAnotherbuyrecommendWareGetRequest : JdRequestBase<JingdongAnotherbuyrecommendWareGetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.anotherbuyrecommend.ware.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("ware_id", this.WareId);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
        }

    }
}
