using EntityLayer.concrete;

namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        public int WriterID { get; set; }

        public string WriterName { get; set; }

        public IFormFile writerImage { get; set; }

        public string WriterAbout { get; set; }
        public bool WriterStatus { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
