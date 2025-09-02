using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace global.Models
{
    [Table("PREVISAO_TEMPO")]
    public class PrevisaoTempo
    {
        [Key]
        [Column("ID_PREVISAO_TEMPO")]
        public int? Id { get; set; }  // nullable, gerado pelo banco

        [Column("LOCALIZACAO")]
        public string Localizacao { get; set; } = string.Empty;

        [Column("DATA_HORA")]
        public DateTime? DataHora { get; set; }

        [Column("TEMPERATURA")]
        public string? Temperatura { get; set; }

        [Column("CONDICAO")]
        public string? Condicao { get; set; }

        [Column("CHUVA_MM")]
        public string? Precipitacao { get; set; }

        [Column("VENTO_KMH")]
        public string? Vento { get; set; }

        [Column("UMIDADE")]
        public string? Umidade { get; set; }
    }
}
