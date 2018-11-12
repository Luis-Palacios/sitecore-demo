using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDemo.Web.Models
{
    public class Team: BaseModel
    {
        [SitecoreQuery("/sitecore/content/Team/*")]
        public virtual IEnumerable<Staff> OurTeam { get; set; }
    }
}