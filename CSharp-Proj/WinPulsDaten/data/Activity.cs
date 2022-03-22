using System;
using System.Data;

namespace WinPulsDaten.data
{
    public class Activity
    {
        public string Art;
        public int Id;
        public float? Factor;

        public override string ToString() => this.Art;


        /// <summary>
        /// Method to load an activity from a Datarow that got retreived from a database
        /// </summary>
        public static Activity Create(DataRow row)
        => new Activity
        {
            Factor = row["factor"] is DBNull ? (float?)null : (float)((decimal)row["factor"]),
            Id = (int)row["id"],
            Art = (string)row["name"]
        };
    }
}
