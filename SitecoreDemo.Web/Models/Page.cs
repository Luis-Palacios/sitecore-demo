namespace SitecoreDemo.Web.Models
{
    public class Page: BaseModel
    {
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
    }
}