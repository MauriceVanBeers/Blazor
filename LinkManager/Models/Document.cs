namespace LinkManager.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public int DocumentListID { get; set; }
        public virtual DocumentList? DocumentList { get; set; }
    }
}