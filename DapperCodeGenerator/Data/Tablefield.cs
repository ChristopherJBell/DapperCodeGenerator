namespace DapperCodeGenerator.Data
{
    public class Tablefield
    {
        // Auto-implemented properties.
        public string Fieldname { get; set; } = null!;
        public string SQLtype { get; set; } = null!;
        public string Codetype { get; set; } = null!;
        public string DBtype { get; set; } = null!;
        public int Length { get; set; }
        public bool IsRequired { get; set; }

        public Tablefield()
        {

        }

        public Tablefield(string fieldname, string sqlytpe, string codetype, string dbtype, int length, bool isrequired)
        {
            this.Fieldname = fieldname;
            this.SQLtype = sqlytpe;
            this.Codetype = codetype;
            this.DBtype = dbtype;
            this.Length = length;
            this.IsRequired = isrequired;
        }
    }
}
