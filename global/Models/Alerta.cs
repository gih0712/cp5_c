using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace global.Models
{
    [Table("ALERTA")]
    public class Alerta
    {
        [Key]
        [Column("ID_ALERTA")]
        public int? Id { get; set; }  // nullable identity

        [Column("ID_USUARIO")]
        public int? UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario? Usuario { get; set; }

        [Column("ID_SENSOR")]
        public int? SensorId { get; set; }
        [ForeignKey("SensorId")]
        public virtual Sensor? Sensor { get; set; }

        [Column("ID_PREVISAO_TEMPO")]
        public int? PrevisaoTempoId { get; set; }
        [ForeignKey("PrevisaoTempoId")]
        public virtual PrevisaoTempo? PrevisaoTempo { get; set; }

        [Column("TIPO_ALERTA")]
        [Required]
        public string Tipo { get; set; } = string.Empty;

        [Column("MENSAGEM")]
        [Required]
        public string Descricao { get; set; } = string.Empty;

        [Column("DATA_HORA")]
        public DateTime? DataAlerta { get; set; }

        [Column("ENVIADO")]
        [StringLength(1)]
        public string? Confirmado { get; set; }
    }
}
