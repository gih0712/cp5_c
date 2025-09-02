namespace global.Migrations
{
    public static class DbConstants
    {
        // Tipos de coluna
        public const string Number10 = "NUMBER(10)";
        public const string NVarChar2000 = "NVARCHAR2(2000)";
        public const string NVarChar1 = "NVARCHAR2(1)";
        public const string Timestamp7 = "TIMESTAMP(7)";

        // Identity
        public const string OracleIdentity = "Oracle:Identity";
        public const string StartIncrement = "START WITH 1 INCREMENT BY 1";

        // Nomes de tabelas
        public const string LogApi = "LOG_API";
        public const string PrevisaoTempo = "PREVISAO_TEMPO";
        public const string Sensores = "SENSORES";
        public const string Usuarios = "USUARIOS";
        public const string LeituraSensor = "LEITURA_SENSOR";
        public const string Alerta = "ALERTA";

        // Colunas FK
        public const string IdSensor = "ID_SENSOR";
        public const string IdUsuario = "ID_USUARIO";
        public const string IdPrevisaoTempo = "ID_PREVISAO_TEMPO";
    }
}
