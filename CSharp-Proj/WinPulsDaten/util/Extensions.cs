using System;
using System.Data;
using System.Windows.Forms;

namespace WinPulsDaten
{
    public static class Extensions
    {
        /// <summary>
        /// Loads a datatable into a combobox
        /// </summary>
        /// <param name="cb">The combobox to load the table into.</param>
        /// <param name="table">The table that shall be loaded</param>
        /// <param name="mapper">(Optional) A function that maps the single rows to the objects that shall be used</param>
        /// <param name="autoSelect">(Default to true) if the first item should be autoselected if it exists</param>
        public static void LoadFromTable(this ComboBox cb, DataTable table,Func<DataRow,object> mapper = null, bool autoSelect = true)
        {
            // Clears previous data
            cb.Items.Clear();

            // Fills in the rows
            if(mapper != null)
                foreach (DataRow row in table.Rows)
                    cb.Items.Add(mapper(row));

            // Automatically selects the first index (if it exists)
            if (autoSelect && cb.Items.Count > 0)
                cb.SelectedIndex = 0;
        }

    }
}
