using System.ComponentModel.DataAnnotations.Schema;

namespace AffilateSource.Data.DataEntity.Entities
{
    [Table("Contacts")]
    public partial class Contact
    {
        public int ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public bool? Status { get; set; }
    }
}
