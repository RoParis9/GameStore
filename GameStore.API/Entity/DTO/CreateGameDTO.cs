using System.ComponentModel.DataAnnotations;

namespace GameStore.API.Entity.DTO
{
    public record CreateGameDTO(

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        string Name,

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(20)]
        string Genre, 

        [Required(ErrorMessage = "Price is required")]
        [Range(1,100, ErrorMessage="Price must be between 1 and 100")]
        decimal Price, 
        
        [Required(ErrorMessage = "Image is required")]
        [Url]
        [StringLength(100)]
        string ImageUri

    ){};
   
}
