using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotation;


namespace GameStore.API.Entity
{
    public class Game
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(1,100, ErrorMessage="Price must be between 1 and 100")]
        public required decimal Price { get; set; }
        [Required(ErrorMessage = "Genre is required")]
        [StringLength(20)]
        public required string Genre { get; set; }
        [Required(ErrorMessage = "Image is required")]
        [Url]
        [StringLength(100)]
        public required string ImageUri { get; set; }
    }
}