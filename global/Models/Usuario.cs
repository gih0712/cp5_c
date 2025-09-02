using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace global.Models
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }  // nullable, gerado pelo banco

        [Column("NOME")]
        public string Nome { get; set; } = string.Empty;

        [Column("EMAIL")]
        public string Email { get; set; } = string.Empty;

        [Column("LOCALIZACAO_USUARIO")]
        public string? LocalizacaoUsuario { get; set; }

        [Column("RECEBER_ALERTAS")]
        [StringLength(1)]
        public string? ReceberAlertas { get; set; }
    }
}
