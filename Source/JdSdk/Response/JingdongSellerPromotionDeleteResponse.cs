#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:55.85876 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 删除促销，只能删除未审核、已驳回、已生效、已暂停等状态的促销 Response
    /// </summary>
    public class JingdongSellerPromotionDeleteResponse : JdResponse
    {
        /// <summary>
        /// 影响的条数
        /// </summary>
        /// <example>1</example>
        [XmlElement("count")]
        [JsonProperty("count")]
        public Int64 Count
        {
            get;
            set;
        }

    }
}