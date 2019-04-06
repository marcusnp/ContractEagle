using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Domain.Entities
{
    [Table("Document", Schema = "dbo")]
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Document Id")]
        public int DocumentId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        [Display(Name = "Name of Company")]
        public string CompanyOwner { get; set; }

        [Required]
        [Column(TypeName = "DateTime")]
        [Display(Name = "Date of Creation")]
        public DateTime DateCreated { get; set; }
    }
}
