using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace SitecoreDemo.Web.Models
{
    public class Header: BaseTitleModel
    {
        public virtual string ContactInfo { get; set; }

        [SitecoreQuery("/sitecore/content//*[@@templateName='DefaultPage']")]
        public virtual IEnumerable<Page> Pages { get; set; }
    }
}