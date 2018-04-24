using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Inventory_Management
{
    public class DonationModel
    {
        #region VARIABLES AND PROPERTIES

        private Donation donation;
        private List<string> categories;
        private List<Donation> donations;

        public Donation Donation { get => donation; set => donation = value; }
        public List<String> Categories { get => categories; set => categories = value; }
        public List<Donation> Donations { get => donations; set => donations = value; }

        #endregion

        public DonationModel()
        {
            Donation = new Donation();
            Donations = new List<Donation>();
            Categories = new List<string>();
            GetCategories();
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

        public void GetCategories() //This whole function needs to be fixed because Category.cs is gone now. Except it might be fixed now
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
                Categories.Add(reader.GetString(0));
            }
            reader.Close();
            command.Connection.Close();
        }

        public void AddDonationToDonations()
        {
            Donations.Add(Donation);
        }

        public void StoreDonations()
        {
            //SQL goes here to store Donations to database
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = GetDBConnection();
            command.Parameters.AddWithValue("@Category", Donations[0].Category);
            command.Parameters.AddWithValue("@Weight", Donations[0].Weight);
            command.Parameters.AddWithValue("DateDonationReceived", Donations[0].DateDonationReceived);
            for (int i = 0; i < Donations.Count; i++)
            {
                command.CommandText =
                    "INSERT INTO inventory (item_name, category_name, weight, date_donation_received) VALUES ('Jeff', @Category, @Weight, @DateDonationReceived)";
            }

            command.Connection.Close();
        }
    }
}
