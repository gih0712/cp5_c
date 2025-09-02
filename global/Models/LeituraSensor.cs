using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace global.Models
{
    [Table("LEITURA_SENSOR")]
    public class LeituraSensor
    {
        [Key]
        [Column("ID_LEITURA_SENSOR")]
        public int? Id { get; set; }  // nullable, gerado pelo banco

        [Column("ID_SENSOR")]
        public int SensorId { get; set; }  // obrigatório, FK

        [ForeignKey("SensorId")]
        public virtual Sensor? Sensor { get; set; }

        [Column("NIVEL_AGUA")]
        public string? Valor { get; set; }

        [Column("DATA_HORA")]
        public DateTime? DataHora { get; set; }
    }
}
