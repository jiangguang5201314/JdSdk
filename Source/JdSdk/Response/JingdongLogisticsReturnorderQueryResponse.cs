#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:53.22761 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 退货入库单查询 Response
    /// </summary>
    public class JingdongLogisticsReturnorderQueryResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("response_return_order")]
        [JsonProperty("response_return_order")]
        public ResponseReturnOrder ResponseReturnOrder
        {
            get;
            set;
        }

    }
}
