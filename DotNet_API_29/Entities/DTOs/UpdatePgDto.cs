using System.ComponentModel.DataAnnotations;

namespace DotNet_API_29.Entities.DTOs
{
    public class UpdatePgDto
    {
        [Required]
        [MaxLength(100)]
        public string PgName { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string PgDescription { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string PgLocation { get; set; } = string.Empty;
        [Required]
        [Phone]
        public string PgContact { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string PgOwner { get; set; } = string.Empty;
    }
}
