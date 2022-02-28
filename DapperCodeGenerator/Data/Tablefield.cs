namespace DapperCodeGenerator.Data
{
    public class Tablefield
    {
        // Auto-implemented properties.
        public string Fieldname { get; set; } = String.Empty;
        public string SQLtype { get; set; } = String.Empty;
        public string Codetype { get; set; } = String.Empty;
        public string DBtype { get; set; } = String.Empty;
        public int Length { get; set; }
        public bool IsRequired { get; set; }

        public Tablefield()
        {

        }

        public Tablefield(string fieldname, string sqltype, string codetype, string dbtype, int length, bool isrequired)
        {
            this.Fieldname = fieldname;
            this.SQLtype = sqltype;
            this.Codetype = codetype;
            this.DBtype = dbtype;
            this.Length = length;
            this.IsRequired = isrequired;
        }
    }
}
