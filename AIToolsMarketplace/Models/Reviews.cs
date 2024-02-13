using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AIToolsMarketplace.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewId { get; set; }
        
        [Required]
        public string UserId { get; set; }   //foreign key
        [ForeignKey("UserId")]
        public ApplicationUser Users { get; set; }//navigation property

        [Required]
        public int ProductId { get; set; }  //foreign key
        [ForeignKey("ProductId")]
        public Product Product { get; set; } //navigation property


       
        [Required]
        [StringLength(1000, ErrorMessage = "the message cannot excceed 1000 chars")]
        public string Content { get; set; }

        [Range(1,5,ErrorMessage = "rating must be between 1 and 5")]
        public int Rating { get; set; }

        public DateTime DatePosted { get; set; } = DateTime.UtcNow;




    }
}