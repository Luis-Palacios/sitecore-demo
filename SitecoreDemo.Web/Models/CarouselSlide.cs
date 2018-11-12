using Glass.Mapper.Sc.Fields;

namespace SitecoreDemo.Web.Models
{
    public class CarouselSlide: BaseTitleModel
    {
        public virtual Image Image { get; set; }
        public virtual string Caption { get; set; }
    }
}