using System.ComponentModel.DataAnnotations;

namespace LinkManager.Models
{
    public class DataItem
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? SourceSystem { get; set; }
        public string? TargetSystem { get; set; }
        public string? LinkType { get; set; }
        public string? Protocol { get; set; }
        public string? ScheduleInfo { get; set; }
        public string? AuthenticationMethod { get; set; }
        public string? EndpointURL { get; set; }
        public string? DataFormat { get; set; }
        public int DocumentListID { get; set; }
        public string? Status { get; set; }
        public string? Version { get; set; }
        public DateTime LastMutationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Owner { get; set; }
        public string? Supplier { get; set; }
        public string? TechnicalManagement { get; set; }
        public virtual DocumentList? DocumentList { get; set; }
    }
}