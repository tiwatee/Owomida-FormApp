using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwomidaForm
{
    public partial class Owomida : Form
    {
        public Owomida()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double membership;

                if (tbYes.Checked == true)
                {
                    membership = 0.7;
                }
                else if (tbNo.Checked == true)
                {
                    membership = 1;
                }
                else
                {
                    membership = 0;
                }

                string vehicle = tbVehicle.GetItemText(tbVehicle.SelectedItem);
                double tripFee = Fee(vehicle);
                var trip = Int32.Parse(tbTrip.Text);

                var amount = TollFee(trip, tripFee, membership);
                tbTollFee.Text = $"Collect {amount.ToString()} naira";
            }
            catch (Exception ex)
            {
                tbTollFee.Text = "Something is not right!! Check your input.";
            }
        }

        //Retrieve fee based on vehicle type
        public double Fee(string vehicle)
        {
            if (vehicle == "Korope")
            {
                return 100;
            }
            else if (vehicle == "Okada")
            {
                return 30;
            }
            else if (vehicle == "Big Bus")
            {
                return 200;
            }
            else if (vehicle == "Maruwa")
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }

        //Calculate total toll fee for a driver
        public double TollFee(int trip, double vehicleFee, double membership )
        {
            return trip*vehicleFee*membership;
        }
    }
}
