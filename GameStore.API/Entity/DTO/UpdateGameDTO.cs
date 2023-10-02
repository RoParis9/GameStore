using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Entity.DTO
{
    public record UpdateGameDTO(
        string? Name, 
        string? Genre, 
        decimal? Price, 
        string? ImageUri
        );

}