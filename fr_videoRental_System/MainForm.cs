using fr_videoRental_System.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fr_videoRental_System
{
    public partial class MainForm : Form
    {
        operations instance_obj = new operations();
        int choice = 0;

        public MainForm()
        {
            
            InitializeComponent();
            fr_RentId.Text = instance_obj.getId().ToString();

        }

        private void fr_VideoYear_TextChanged(object sender, EventArgs e)
        {
            try {
                fr_VideoCost.Text = "" + instance_obj.findcost(Convert.ToInt32(fr_VideoYear.Text.ToString()));
            }
            catch (Exception ex) {

            }
            

        }

        private void fr_btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (instance_obj.add_Customer(fr_CustomerName.Text, fr_CustomerMObile.Text, fr_CustomerAddress.Text))
            {
                MessageBox.Show("Customer details is sucessfully stored ");
            }
            else {
                MessageBox.Show("there is some mistake check once again ");
            }
            //empty the textboxes 
            fr_CustomerAddress.Text = "";
            fr_CustomerMObile.Text = "";
            fr_CustomerName.Text = "";
        }

        private void fr_btnCustomerDElete_Click(object sender, EventArgs e)
        {
            if (instance_obj.del_Customer(Convert.ToInt32(fr_CustomerId.Text)))
            {
                MessageBox.Show("customer reocrd is deleted from the table ");
            }
            else {
                MessageBox.Show("you already issued an movie ");
            }
            //empty the textboxes 
            fr_CustomerId.Text = "";
            fr_CustomerAddress.Text = "";
            fr_CustomerMObile.Text = "";
            fr_CustomerName.Text = "";
        }

        private void fr_btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (instance_obj.update_Customer(Convert.ToInt32(fr_CustomerId.Text),fr_CustomerName.Text, fr_CustomerMObile.Text, fr_CustomerAddress.Text)) {
                MessageBox.Show("Record is Updated sucessfully ");
            }
            else {
                MessageBox.Show("Check your details once ");
            }
            //empty the textboxes 
            fr_CustomerId.Text = "";
            fr_CustomerAddress.Text = "";
            fr_CustomerMObile.Text = "";
            fr_CustomerName.Text = "";
        }

        private void fr_btnRentalBooking_Click(object sender, EventArgs e)
        {
            if (instance_obj.Book_Movie(Convert.ToInt32(fr_CustomerId.Text), Convert.ToInt32(fr_VideoId.Text), fr_Booking.Text))
            {
                MessageBox.Show("Movie is issued on rent ");
            }

            //empty the textboxes 
            fr_CustomerId.Text = "";
            fr_CustomerAddress.Text = "";
            fr_CustomerMObile.Text = "";
            fr_CustomerName.Text = "";

            fr_VideoId.Text = "";
            fr_VideoTitle.Text = "";
            fr_VideoRatting.Text = "";
            fr_VideoYear.Text = "";
            fr_VideoCopies.Text = "";
            fr_VideoCost.Text = "";
            fr_VideoPlot.Text = "";
            fr_VideoGenre.Text = "";



            fr_RentId.Text = instance_obj.getId().ToString();
        }


        //delete the  movie which is bymistake booked 
        private void fr_btnRentalDelete_Click(object sender, EventArgs e)
        {
            if (instance_obj.Del_BookMovie(Convert.ToInt32(fr_RentId.Text)))
            {
                MessageBox.Show("Movie is deleted ");
            }
            else {
                MessageBox.Show("Check the id ");
            }

            //empty the textboxes 
            fr_CustomerId.Text = "";
            fr_CustomerAddress.Text = "";
            fr_CustomerMObile.Text = "";
            fr_CustomerName.Text = "";

            fr_VideoId.Text = "";
            fr_VideoTitle.Text = "";
            fr_VideoRatting.Text = "";
            fr_VideoYear.Text = "";
            fr_VideoCopies.Text = "";
            fr_VideoCost.Text = "";
            fr_VideoPlot.Text = "";
            fr_VideoGenre.Text = "";

            fr_RentId.Text = instance_obj.getId().ToString();
        }

        private void fr_btnRentalReturn_Click(object sender, EventArgs e)
        {

            if(instance_obj.Return_Movie(Convert.ToInt32(fr_RentId.Text), Convert.ToInt32(fr_CustomerId.Text), Convert.ToInt32(fr_VideoId.Text),fr_Booking.Text,fr_Return.Text)) {

            }
            else {
                MessageBox.Show(" Check the details ");
            }


            //empty the textboxes 
            fr_CustomerId.Text = "";
            fr_CustomerAddress.Text = "";
            fr_CustomerMObile.Text = "";
            fr_CustomerName.Text = "";

            fr_VideoId.Text = "";
            fr_VideoTitle.Text = "";
            fr_VideoRatting.Text = "";
            fr_VideoYear.Text = "";
            fr_VideoCopies.Text = "";
            fr_VideoCost.Text = "";
            fr_VideoPlot.Text = "";
            fr_VideoGenre.Text = "";

            fr_RentId.Text = instance_obj.getId().ToString();

        }

        private void fr_btnVideoSAve_Click(object sender, EventArgs e)
        {
            if (instance_obj.add_Movie(fr_VideoTitle.Text,fr_VideoRatting.Text,Convert.ToInt32(fr_VideoYear.Text), Convert.ToInt32(fr_VideoCost.Text), Convert.ToInt32(fr_VideoCopies.Text),fr_VideoPlot.Text,fr_VideoGenre.Text)) {
                MessageBox.Show("Movie details are saved in the table sucessfully ");
            }
            else {
                MessageBox.Show("Check details once Again ");
            }

            fr_VideoId.Text = "";
            fr_VideoTitle.Text = "";
            fr_VideoRatting.Text = "";
            fr_VideoYear.Text = "";
            fr_VideoCopies.Text = "";
            fr_VideoCost.Text = "";
            fr_VideoPlot.Text = "";
            fr_VideoGenre.Text = "";

        }

        private void fr_btnVideoDelete_Click(object sender, EventArgs e)
        {

            if (instance_obj.del_Movie(Convert.ToInt32(fr_VideoId.Text))) {
                MessageBox.Show("Movie is deleted ");
            }
            else {
                MessageBox.Show(" Movie check once again ");
            }

            fr_VideoId.Text = "";
            fr_VideoTitle.Text = "";
            fr_VideoRatting.Text = "";
            fr_VideoYear.Text = "";
            fr_VideoCopies.Text = "";
            fr_VideoCost.Text = "";
            fr_VideoPlot.Text = "";
            fr_VideoGenre.Text = "";


        }

        private void fr_btnVideoUpdate_Click(object sender, EventArgs e)
        {
            if (instance_obj.Update_Movie(Convert.ToInt32(fr_VideoId.Text), fr_VideoTitle.Text, fr_VideoRatting.Text, Convert.ToInt32(fr_VideoYear.Text), Convert.ToInt32(fr_VideoCost.Text), Convert.ToInt32(fr_VideoCopies.Text), fr_VideoPlot.Text, fr_VideoGenre.Text)) {
                MessageBox.Show("Video is updated Sucessfully  ");
            }
            else {
                MessageBox.Show("Check details once again ");
            }


            fr_VideoId.Text = "";
            fr_VideoTitle.Text = "";
            fr_VideoRatting.Text = "";
            fr_VideoYear.Text = "";
            fr_VideoCopies.Text = "";
            fr_VideoCost.Text = "";
            fr_VideoPlot.Text = "";
            fr_VideoGenre.Text = "";

        }

        private void fr_show_video_Click(object sender, EventArgs e)
        {
            choice = 1;
            DataTable tbl = new DataTable();
            tbl = instance_obj.all_Movies();
            recordTable.DataSource = tbl;
        }

        private void fr_show_customer_Click(object sender, EventArgs e)
        {
            choice = 2;
            DataTable tbl = new DataTable();
            tbl = instance_obj.all_Customer();
            recordTable.DataSource = tbl;

        }

        private void fr_show_rentals_Click(object sender, EventArgs e)
        {
            choice = 3;
            DataTable tbl = new DataTable();
            tbl = instance_obj.all_Booked();
            recordTable.DataSource = tbl;
        }

        private void recordTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (choice == 1) {
                fr_VideoId.Text = recordTable.CurrentRow.Cells[0].Value.ToString(); ;
                fr_VideoTitle.Text = recordTable.CurrentRow.Cells[1].Value.ToString(); ;
                fr_VideoRatting.Text = recordTable.CurrentRow.Cells[2].Value.ToString(); ;
                fr_VideoYear.Text = recordTable.CurrentRow.Cells[3].Value.ToString(); ;
                fr_VideoCopies.Text = recordTable.CurrentRow.Cells[4].Value.ToString(); ;
                fr_VideoCost.Text = recordTable.CurrentRow.Cells[5].Value.ToString(); ;
                fr_VideoPlot.Text = recordTable.CurrentRow.Cells[6].Value.ToString(); ;
                fr_VideoGenre.Text = recordTable.CurrentRow.Cells[7].Value.ToString(); ;


            }
            else if (choice == 2) {
                fr_CustomerId.Text = recordTable.CurrentRow.Cells[0].Value.ToString();
                fr_CustomerName.Text = recordTable.CurrentRow.Cells[1].Value.ToString();
                fr_CustomerMObile.Text = recordTable.CurrentRow.Cells[2].Value.ToString();
                fr_CustomerAddress.Text = recordTable.CurrentRow.Cells[3].Value.ToString();
            }
            else if (choice==3) {
                fr_RentId.Text = recordTable.CurrentRow.Cells[0].Value.ToString();
                fr_CustomerId.Text= recordTable.CurrentRow.Cells[1].Value.ToString();
                fr_VideoId.Text= recordTable.CurrentRow.Cells[2].Value.ToString();
                fr_Booking.Text= recordTable.CurrentRow.Cells[3].Value.ToString();

            }
            choice = 0;
        }

        private void fr_btnMostMovie_Click(object sender, EventArgs e)
        {
            //get the name of the famous Movie in the store
            MessageBox.Show("The Most Ranked Movie is " + instance_obj.ToprankedMovie());
        }

        private void fr_btnMostCustomer_Click(object sender, EventArgs e)
        {
            //get the name of the famous cusotmer in the store
            MessageBox.Show("The Most Ranked Movie is " + instance_obj.ToprankedCustomer());
        }
    }
}
