using System.Collections.Generic;

namespace LinkManager.Models
{
    public class DocumentList
    {
        public int ID { get; set; }
        public virtual ICollection<Document>? Documents { get; set; }
        public virtual ICollection<DataItem>? DataItems { get; set; }
    }
}