using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class Donation
    {

        #region VARIABLES AND PROPERTIES

        private string categoryName;
        private float weight;
        private DateTime dateDonationReceived;

        public string Category { get => categoryName; set => categoryName = value; }
        public float Weight { get => weight; set => weight = value; }
        public DateTime DateDonationReceived { get => dateDonationReceived; set => dateDonationReceived = value; }

        #endregion

        //test edit
        public Donation()
        {
            Category = "";
            Weight = 0;
            DateDonationReceived = DateTime.Now;
        }

    }
}
