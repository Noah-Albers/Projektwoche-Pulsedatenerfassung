using System.Data;

namespace WinPulsDaten
{
    class TrainingCondtion
    {
        public int ID;
        public string Typ;

        public override string ToString() => this.Typ;

        public static Gender Create(DataRow row)
        => new Gender
        {
            ID = (int)row["ID"],
            Name = (string)row["Typ"]
        };
    }
}
