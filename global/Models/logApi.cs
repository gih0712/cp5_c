using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace global.Models
{
    [Table("LOG_API")]
    public class LogApi
    {
        [Key]
        [Column("ID_LOG")]
        public int Id { get; set; }

        [Column("TIPO")]
        public string Tipo { get; set; } = string.Empty;

        [Column("ENDPOINT")]
        public string Endpoint { get; set; } = string.Empty;

        [Column("PAYLOAD")]
        public string Payload { get; set; } = string.Empty;

        [Column("RESPOSTA")]
        public string Resposta { get; set; } = string.Empty;

        [Column("DATA_HORA")]
        public DateTime? DataHora { get; set; }
    }
}
