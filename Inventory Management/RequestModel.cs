using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
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
        private bool preExistingStudent;
        
        public string TNumber { get => tNumber; set => tNumber = value; }
        public string Notes { get => notes; set => notes = value; }
        public int FamilySize { get => familySize; set => familySize = value; }
        public DateTime DateRequested { get => dateRequested; set => dateRequested = value; }
        public DateTime DateFilled { get => dateFilled; set => dateFilled = value; }
        public DateTime DatePickedUp { get => datePickedUp; set => datePickedUp = value; }
        public bool PreExistingStudent { get => preExistingStudent; set => preExistingStudent = value; }

        #endregion

        public RequestModel()
        {
            TNumber = "";
            Notes = "";
            FamilySize = 0;
            DateRequested = DateTime.Now;
            DateFilled = DateTime.Now;
            DatePickedUp = DateTime.Now;
            PreExistingStudent = false;
        }

        public void ClearRequestModel()
        {
            TNumber = null;
            Notes = null;
            FamilySize = 0;
            DateRequested = DateTime.Now;
            DateFilled = DateTime.Now;
            DatePickedUp = DateTime.Now;
            PreExistingStudent = false;
        }

        public SQLiteConnection GetDBConnection()
        {
            // create a new database connection:
            SQLiteConnection sqlite_conn =
              new SQLiteConnection("Data Source=InventoryDatabase.sqlite;Version=3;");

            // open the connection:
            sqlite_conn.Open();

            return sqlite_conn;
        }

        public bool PullStudentInfo()
        {
            bool result = true; //Change this to false later. Hopefully there's a bool function that tells if query was without error.


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GetDBConnection();
            command.CommandText =
                "SELECT notes, family_size " +
                "FROM student " +
                "WHERE t_number = '" + TNumber + "'" +
                ";"
                ;
            //Notes = (String)(command.ExecuteScalar());

            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                Notes = reader.GetString(0);
                FamilySize = reader.GetInt32(1);
                PreExistingStudent = true;
            }
            else
            {
                PreExistingStudent = false;
            }
            reader.Close();
            command.Connection.Close();
            return result;
        }

        public bool StoreRequest()
        {
            bool result = true; //Change this to false later. Hopefully there's a bool function that tells if query was without error.

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GetDBConnection();

            command.Parameters.AddWithValue("@TNumber", TNumber);
            command.Parameters.AddWithValue("@Notes", notes);

            if (PreExistingStudent)
            {
                command.CommandText = 
                    "UPDATE student " +
                    "SET notes = @Notes " +
                    "WHERE t_number = @TNumber " +
                    ";"
                    ;
            }
            else
            {
                command.CommandText =
                    "INSERT INTO student (t_number, notes, family_size, date_requested, date_filled, date_picked_up) " + 
                    "VALUES ('" + TNumber + "', '" + Notes + "', '" + FamilySize + "', '" + DateRequested + "', '" + DateFilled + "', '" + DatePickedUp + "')" +
                    ";"
                    ;
            }

            command.ExecuteNonQuery();

            command.Connection.Close();
            return result;
        }

    }
}
