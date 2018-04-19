using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    class Donation
    {

        #region VARIABLES AND PROPERTIES

        private string categoryName;
        private string itemName;
        private float weight;
        private DateTime DateDonationReceived;

        public string Category { get => categoryName; set => categoryName = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public float Weight { get => weight; set => weight = value; }
        public DateTime DateDonationReceived1 { get => DateDonationReceived; set => DateDonationReceived = value; }

        #endregion

        public Donation()
        {
            Category = "";
            ItemName = "";
            weight = 0;
            DateDonationReceived = DateTime.Now;
        }

    }
}
