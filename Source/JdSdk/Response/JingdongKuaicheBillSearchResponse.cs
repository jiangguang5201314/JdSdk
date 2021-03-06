#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.95866 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取商家每月消费账单 Response
    /// </summary>
    public class JingdongKuaicheBillSearchResponse : JdResponse
    {
        /// <summary>
        /// 结果集合
        /// </summary>
        [XmlElement("list")]
        [JsonProperty("list")]
        public BillVO[] List
        {
            get;
            set;
        }

    }
}
