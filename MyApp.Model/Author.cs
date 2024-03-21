using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Model
{
    [Table("Authors")]
    //[Index(nameof(AuthorEmail), IsUnique = true)]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   

        public int AuthorId { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage ="Author name is requried")]

        public string AuthorName { get; set; } = string.Empty;
        [MaxLength(50)]
        [Required(ErrorMessage = "Author Email is requried")]
        public string AuthorEmail { get; set; }=string.Empty;
    }
}
