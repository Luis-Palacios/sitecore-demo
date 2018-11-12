using System.Collections.Generic;

namespace SitecoreDemo.Web.Models
{
    public class Carousel: BaseTitleModel
    {
        public virtual string Intro { get; set; }
        public virtual string AdditionalText { get; set; }
        public virtual IEnumerable<CarouselSlide> Images { get; set; }
    }
}