using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace global.Models
{
    [Table("SENSORES")]
    public class Sensor
    {
        [Key]
        [Column("ID_SENSOR")]
        public int IdSensor { get; set; }

        [Column("NOME")]
        public string Nome { get; set; } = string.Empty;

        [Column("LOCALIZACAO_SENSOR")]
        public string? LocalizacaoSensor { get; set; }

        [Column("ALCANCE_ALERTA")]
        public string? AlcanceAlerta { get; set; }

        [Column("DATA_INSTALACAO")]
        public DateTime? DataInstalacao { get; set; }
    }
}
