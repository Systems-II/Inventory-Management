using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Inventory_Management
{
    class DonationModel
    {
        #region VARIABLES AND PROPERTIES

        private Donation donation;
        private List<Category> categories;
        private List<string> item;
        private List<Donation> donations;

        public Donation Donation { get => donation; set => donation = value; }
        public List<Category> Categories { get => categories; set => categories = value; }
        public List<string> Item { get => item; set => item = value; }
        public List<Donation> Donations { get => donations; set => donations = value; }

        #endregion

        DonationModel()
        {
            Donation = new Donation();
            Donations = new List<Donation>();
            Categories = new List<Category>();
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

        public void GetItems()
        {
            //SQL goes here to get all category and food names from DB
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GetDBConnection();
            command.CommandText = 
                "SELECT DISTINCT category_name " +
                "FROM category " +
                ";"
                ;
            SQLiteDataReader reader = command.ExecuteReader();
            List<string> items = new List<string>();

            while (reader.Read())
            {
                Categories.Add(new Category(reader.GetString(0)));
            }

            reader.Close();

            string tempCategory;
            //command.Parameters.Add("@Category", tempCategory); //Is this out of order or something?
            command.CommandText =
                "SELECT item " +
                "FROM category " +
                "WHERE category = @Category " +
                ";"
                ;


            for (int i = 0; i < Categories.Count; i++)
            {
                tempCategory = Categories[i].Name;
                command.ExecuteReader();
                reader.Read();

            }
        }
    }
}
