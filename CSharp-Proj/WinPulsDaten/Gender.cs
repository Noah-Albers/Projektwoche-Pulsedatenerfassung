using System.Data;

namespace WinPulsDaten
{
    public class Gender
    {
        public int ID;
        public string Name;

        public override string ToString() => this.Name;

        public static Gender Create(DataRow row)
        => new Gender
        {
            ID = (int)row["ID"],
            Name = (string)row["Geschlecht"]
        };
    }
}
