using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEduCampusJobdeliverModifyResponse.
    /// </summary>
    public class AlipayEcoEduCampusJobdeliverModifyResponse : AopResponse
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 返回code编码;成功返回SUCCESS
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }
    }
}
