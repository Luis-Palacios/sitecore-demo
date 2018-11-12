using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace SitecoreDemo.Web.Models
{
    public class Staff: BaseModel
    {
        [SitecoreField("Name")]
        public virtual string Name { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual Image Picture { get; set; }
    }
}