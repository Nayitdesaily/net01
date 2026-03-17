using System.ComponentModel.DataAnnotations;

namespace net01.WEBAPI.DTOs.Consultorio
{
    public class CreateConsultorioDTO
    {
        [Required]
        [StringLength(150)]
        public required string Nombre { get; set; }
    }
}
