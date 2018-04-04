using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Inventory_Management
{
    class RequestModel
    {

        #region VARIABLES AND PROPERTIES

        private string tNumber;
        private string notes;
        private int familySize;
        private DateTime dateRequested;
        private DateTime dateFilled;
        private DateTime datePickedUp;
        
        public string TNumber { get => tNumber; set => tNumber = value; }
        public string Notes { get => notes; set => notes = value; }
        public int FamilySize { get => familySize; set => familySize = value; }
        public DateTime DateRequested { get => dateRequested; set => dateRequested = value; }
        public DateTime DateFilled { get => dateFilled; set => dateFilled = value; }
        public DateTime DatePickedUp { get => datePickedUp; set => datePickedUp = value; }

        #endregion

        public SQLiteConnection GetDBConnection()
        {
            // create a new database connection:
            SQLiteConnection sqlite_conn =
              new SQLiteConnection("Data Source=database.sqlite;Version=3;");

            // open the connection:
            sqlite_conn.Open();
            sqlite_conn.Close();

            return sqlite_conn;
        }

        public bool StoreRequest()
        {
            bool result = true;

            SQLiteConnection connection = GetDBConnection();

            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = 

            return result;
        }

    }
}
