using Glass.Mapper.Sc.Fields;

namespace SitecoreDemo.Web.Models
{
    public class DefaultBoxContent: BaseTitleModel
    {
        public virtual string Content { get; set; }
        public virtual Image Image { get; set; }
    }
}