using System;
using System.Data;

namespace WinPulsDaten.data
{
    public class Person
    {
        public int Id;
        public string Firstname;
        public string Lastname;
        public int Weight;
        public float Size;
        public int Gender;
        public DateTime Birth;
        public float HpMax;
        public bool isSup;


        /// <summary>
        /// Method to load a person from a Datarow that got retreived from a database
        /// </summary>
        public static Person Create(DataRow row)
        => new Person
        {
            Id = (int)row["id"],
            Firstname = (string)row["fname"],
            Lastname = (string)row["lname"],
            Birth = (DateTime)row["birthday"],
            Gender = (int)row["gender"],
            HpMax = (int)row["hfmax"],
            Size = (float)(decimal)row["size"],
            Weight = (int)row["weight"],
            isSup = (ulong)row["isSup"] == 1
        };
    }
}
