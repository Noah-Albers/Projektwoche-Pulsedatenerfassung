using System.Data;

namespace WinPulsDaten.data
{
    public class Gender
    {
        public int ID;
        public string Name;

        public override string ToString() => this.Name;


        /// <summary>
        /// Method to load a gender from a Datarow that got retreived from a database
        /// </summary>
        public static Gender Create(DataRow row)
        => new Gender
        {
            ID = (int)row["id"],
            Name = (string)row["name"]
        };
    }
}
