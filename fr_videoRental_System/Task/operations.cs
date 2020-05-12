using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fr_videoRental_System;
using fr_videoRental_System.Folder;

namespace fr_videoRental_System.Task
{
  public  class operations
    {
        DatabaseConnection obj = new DatabaseConnection();

        public Boolean add_Customer(String Name,String Mobile,String Address) {
            if (!Name.ToString().Equals("") && !Mobile.ToString().Equals("") && !Address.ToString().Equals(""))
            {
                String cmd = "insert into tblcustomer(Name,Mobile,Address)values('" + Name + "','" + Mobile + "','" + Address + "')";
                obj.SqlOperation(cmd);
                return true;
            }
            else {
                return false;
            }

        }

        //count that the cutomer is already booked a  movie on rent or not 
        public int Count_Cutomer(int Id_Pk)
        {
            DataTable table = new DataTable();
            String cmd = "select * from tblRental where Cid_Fk=" + Id_Pk + " and  mReturnDate='Book'";
            table = obj.searchOperation(cmd);
            return table.Rows.Count;
        }

        //paramterized mehod to delete the details of the customer 
        public Boolean del_Customer(int Id_Pk)
        {
            if (Id_Pk>0)
            {
                if (Count_Cutomer(Id_Pk) == 0)
                {
                    String cmd = "delete from tblcustomer where Id_Pk=" + Id_Pk + "";
                    obj.SqlOperation(cmd);
                    return true;
                }
                else {
                    return false;
                }
                
            }
            else
            {
                return false;
            }

        }

        //paramterized mehod to delete the details of the customer 
        public Boolean update_Customer(int Id_Pk, String Name, String Mobile, String Address)
        {
            if (Id_Pk > 0 && !Name.ToString().Equals("") && !Mobile.ToString().Equals("") && !Address.ToString().Equals(""))
            {
                String cmd = "update tblcustomer set Name='"+Name+"',Mobile='"+Mobile+"',Address='"+Address+"' where Id_Pk=" + Id_Pk + "";
                obj.SqlOperation(cmd);
                return true;
            }
            else
            {
                return false;
            }

        }

        //return the details of all the customer in the form of table 
        public DataTable all_Customer() {
            String cmd = "select * from tblCustomer";
            DataTable table = new DataTable();
            table = obj.searchOperation(cmd);
            return table;
        }

        //return the details of all the Movie in the form of table 
        public DataTable all_Movies()
        {
            String cmd = "select * from tblMovie";
            DataTable table = new DataTable();
            table = obj.searchOperation(cmd);
            return table;
        }

        //return the details of all the customer in the form of table 
        public DataTable all_Booked()
        {
            String cmd = "select * from tblRental";
            DataTable table = new DataTable();
            table = obj.searchOperation(cmd);
            return table;
        }


        //get the Copies of the Movie from the movie table 
        public int getCopies(int Id_Pk)
        {
            String cmd = "select * from tblMovie where Id_Pk="+Id_Pk+"";
            DataTable table = new DataTable();
            table = obj.searchOperation(cmd);
            return Convert.ToInt32(table.Rows[0]["Copies"].ToString());
        }

        //get the Cost of the Movie from the movie table 
        public int getCost(int Id_Pk)
        {
            String cmd = "select * from tblMovie where Id_Pk=" + Id_Pk + "";
            DataTable table = new DataTable();
            table = obj.searchOperation(cmd);
            return Convert.ToInt32(table.Rows[0]["Cost"].ToString());
        }


        //get how much movies is already booked from the store 
        public int getBooked(int Id_Pk)
        {
            String cmd = "select * from tblRental where Mid_Fk=" + Id_Pk + " and mReturnDate='Book'";
            DataTable table = new DataTable();
            table = obj.searchOperation(cmd);
            return table.Rows.Count;
        }


        //get how much movies is already booked from the store 
        public int getCustomerBooking(int Id_Pk)
        {
            String cmd = "select * from tblRental where Cid_Fk=" + Id_Pk + " and mReturnDate='Book'";
            DataTable table = new DataTable();
            table = obj.searchOperation(cmd);
            return table.Rows.Count;
        }







        //this method is used to book a movie on rent by the customer 
        public Boolean Book_Movie(int Cid_Fk,int Mid_Fk,String MissueDate) {

            if (Cid_Fk > 0 && Mid_Fk > 0 && !MissueDate.ToString().Equals(""))
            {
                if (getBooked(Mid_Fk) < getCopies(Mid_Fk))
                {
                    if (getCustomerBooking(Cid_Fk) < 2)
                    {

                        String cmd = "insert into tblRental(Cid_Fk,Mid_Fk,MissueDate,mReturnDate)values (" + Cid_Fk + "," + Mid_Fk + ",'" + MissueDate + "','Book')";
                        obj.SqlOperation(cmd);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("You already have 2 movie on rent ");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("All sample of Movie is Already booked ");
                    return false;
                }
            }
            else {
                MessageBox.Show("Check details once again ");
                return false;
            }
        }
        
        //this parameterized method is used to pas the values to the database to store in the table
        public Boolean add_Movie(String Title,String Ranking,int Year,int Cost,int copies,String Plot,String Genre) {
            if (!Title.ToString().Equals("") && !Ranking.ToString().Equals("") && Year>0 && Cost>0 && copies>0 && !Plot.ToString().Equals("") && !Genre.ToString().Equals("")) {

                String cmd = "insert into tblMovie(Title,Ranking,Year,Cost,Copies,Plot,Genre) values('"+Title+"','"+Ranking+"',"+Year+","+Cost+","+copies+",'"+Plot+"','"+Genre+"')";
                obj.SqlOperation(cmd);
                return true;
            }
            else {
                return false;
            }

        }


        //this parameterized method is used to pas the values to the database to store in the table
        public Boolean Update_Movie(int Id_Pk, String Title, String Ranking, int Year, int Cost, int copies, String Plot, String Genre)
        {
            if (Id_Pk>0 && !Title.ToString().Equals("") && !Ranking.ToString().Equals("") && Year > 0 && Cost > 0 && copies > 0 && !Plot.ToString().Equals("") && !Genre.ToString().Equals(""))
            {

                String cmd = "Update tblMovie set Title='"+Title+"',Ranking='"+Ranking+"',Year="+Year+",Cost="+Cost+",Copies="+copies+",Plot='"+Plot+"',Genre='"+Genre+"' where Id_Pk="+Id_Pk+"";
                obj.SqlOperation(cmd);
                return true;
            }
            else
            {
                return false;
            }
        }


        //count the movie is it already booked or not
        public int Count_Movie(int Id_Pk){
            DataTable table = new DataTable();
            String cmd = "select * from tblRental where Mid_Fk="+Id_Pk+" && mReturnDate='Book'";
            table = obj.searchOperation(cmd);
            return table.Rows.Count;
        }



        //this parameterized method is used to pas the values to the database to delete from  the table
        public Boolean del_Movie(int Id_Pk)
        {
            if (Id_Pk>0)
            {
                if (Count_Movie(Id_Pk) == 0)
                {
                    String cmd = "delete from tblMovie where Id_Pk=" + Id_Pk + "";
                    obj.SqlOperation(cmd);
                    return true;
                }
                else {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        //this method is used to book a movie on rent by the customer 
        public Boolean Del_BookMovie(int Id_Pk)
        {

            if (Id_Pk > 0)
            {
                String cmd = "delete from tblRental where Id_Pk="+Id_Pk+"";
                obj.SqlOperation(cmd);
                return true;
            }
            else
            {
                return false;
            }
        }


        //return the id to display in the textbox
        public int getId() {
            DataTable table = new DataTable();
            table = obj.searchOperation("select * from tblRental");
            if (table.Rows.Count > 0)
            {
                return table.Rows.Count;
            }
            else {
                return 1;
            }
        }

        //calcualte the cost of the movie 
        public int findcost(int  year) {

            //dislay the cost of the price of the video after adding the year of the video
            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - year;
            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                return 2;
            }
            else if (diffYear >= 0 && diffYear < 5)
            {
                return 5;
            }
            else {
                return 0;
            }

        }

        //this method is used to book a movie on rent by the customer 
        public Boolean Return_Movie(int Id_Pk,int Cid_Fk, int Mid_Fk, String MissueDate,String mReturnDate)
        {

            if (Id_Pk>0 && Cid_Fk > 0 && Mid_Fk > 0 && !MissueDate.ToString().Equals(""))
            {
                int cost = getCost(Mid_Fk);
                DateTime new_date = DateTime.Now;



                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(MissueDate);


                //get the difference in the days fromat
                String Daysdiff = (new_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


                



                int Price = Convert.ToInt32(DaysInterval) * cost;




                String cmd = "Update  tblRental set Cid_Fk="+Cid_Fk+",Mid_Fk="+Mid_Fk+",MissueDate='"+MissueDate+"',mReturnDate='"+mReturnDate+ "' where  Id_Pk=" + Id_Pk + "";
                obj.SqlOperation(cmd);

                MessageBox.Show("You have to Pay: $"+Price);
                return true;
            }
            else
            {
                return false;
            }
        }

        //get the name of the movie which is booked mostly using the concept of count sort 
        public String ToprankedMovie() {
            DataTable tblData = new DataTable();
            tblData = obj.searchOperation("select * from tblMovie");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = obj.searchOperation("select * from tblRental where Mid_Fk=" + Convert.ToInt32(tblData.Rows[x]["Id_Pk"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Title"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }


            return Title;

        }

        //get the name of the movie which is booked mostly using the concept of count sort 
        public String ToprankedCustomer()
        {
            DataTable tblData = new DataTable();
            tblData = obj.searchOperation("select * from tblcustomer");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = obj.searchOperation("select * from tblRental where Cid_Fk=" + Convert.ToInt32(tblData.Rows[x]["Id_Pk"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }


            return Title;

        }



    }
}
