using System.Data;

namespace WinPulsDaten.data
{
    public class Trainingcondition
    {
        public int ID;
        public string Name;

        public override string ToString() => this.Name;


        // Hardcoded values to check for different conditions
        public bool IsOverweight => this.ID == 3;
        public bool IsUntrained => this.ID == 2;
        public bool IsTrained => this.ID == 1;



        /// <summary>
        /// Method to load a training-condition from a Datarow that got retreived from a database
        /// </summary>
        public static Trainingcondition Create(DataRow row)
        => new Trainingcondition
        {
            ID = (int)row["id"],
            Name = (string)row["name"]
        };
    }
}
