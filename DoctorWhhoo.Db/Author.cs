
namespace DoctorWhhoo.Db
{
    public class Author
    {
        public Author()
        {
            EpAuthor = new List<Episode>();
        }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public List<Episode> EpAuthor { get; set; }
    }
}
