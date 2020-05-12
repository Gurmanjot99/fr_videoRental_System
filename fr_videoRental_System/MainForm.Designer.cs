namespace fr_videoRental_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fr_btnCustomerUpdate = new System.Windows.Forms.Button();
            this.fr_btnCustomerSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fr_CustomerMObile = new System.Windows.Forms.TextBox();
            this.fr_CustomerAddress = new System.Windows.Forms.TextBox();
            this.fr_CustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.fr_btnCustomerDElete = new System.Windows.Forms.Button();
            this.fr_btnVideoDelete = new System.Windows.Forms.Button();
            this.fr_btnVideoUpdate = new System.Windows.Forms.Button();
            this.fr_btnVideoSAve = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fr_VideoCopies = new System.Windows.Forms.TextBox();
            this.fr_VideoPlot = new System.Windows.Forms.TextBox();
            this.fr_VideoGenre = new System.Windows.Forms.TextBox();
            this.fr_VideoTitle = new System.Windows.Forms.TextBox();
            this.fr_VideoYear = new System.Windows.Forms.TextBox();
            this.fr_VideoRatting = new System.Windows.Forms.TextBox();
            this.fr_VideoCost = new System.Windows.Forms.TextBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.fr_btnRentalDelete = new System.Windows.Forms.Button();
            this.fr_btnRentalReturn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fr_btnRentalBooking = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fr_Return = new System.Windows.Forms.DateTimePicker();
            this.fr_Booking = new System.Windows.Forms.DateTimePicker();
            this.fr_VideoId = new System.Windows.Forms.TextBox();
            this.fr_CustomerId = new System.Windows.Forms.TextBox();
            this.fr_RentId = new System.Windows.Forms.TextBox();
            this.lblRental = new System.Windows.Forms.Label();
            this.recordTable = new System.Windows.Forms.DataGridView();
            this.fr_show_video = new System.Windows.Forms.Button();
            this.fr_show_customer = new System.Windows.Forms.Button();
            this.fr_show_rentals = new System.Windows.Forms.Button();
            this.fr_btnMostMovie = new System.Windows.Forms.Button();
            this.fr_btnMostCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordTable)).BeginInit();
            this.SuspendLayout();
            // 
            // fr_btnCustomerUpdate
            // 
            this.fr_btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnCustomerUpdate.Location = new System.Drawing.Point(115, 251);
            this.fr_btnCustomerUpdate.Name = "fr_btnCustomerUpdate";
            this.fr_btnCustomerUpdate.Size = new System.Drawing.Size(102, 33);
            this.fr_btnCustomerUpdate.TabIndex = 45;
            this.fr_btnCustomerUpdate.Text = "Update";
            this.fr_btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.fr_btnCustomerUpdate.Click += new System.EventHandler(this.fr_btnCustomerUpdate_Click);
            // 
            // fr_btnCustomerSave
            // 
            this.fr_btnCustomerSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnCustomerSave.Location = new System.Drawing.Point(12, 248);
            this.fr_btnCustomerSave.Name = "fr_btnCustomerSave";
            this.fr_btnCustomerSave.Size = new System.Drawing.Size(80, 33);
            this.fr_btnCustomerSave.TabIndex = 44;
            this.fr_btnCustomerSave.Text = "Save Data";
            this.fr_btnCustomerSave.UseVisualStyleBackColor = true;
            this.fr_btnCustomerSave.Click += new System.EventHandler(this.fr_btnCustomerSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mobile No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Customer Name";
            // 
            // fr_CustomerMObile
            // 
            this.fr_CustomerMObile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_CustomerMObile.Location = new System.Drawing.Point(182, 151);
            this.fr_CustomerMObile.Name = "fr_CustomerMObile";
            this.fr_CustomerMObile.Size = new System.Drawing.Size(140, 31);
            this.fr_CustomerMObile.TabIndex = 40;
            // 
            // fr_CustomerAddress
            // 
            this.fr_CustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_CustomerAddress.Location = new System.Drawing.Point(182, 214);
            this.fr_CustomerAddress.Name = "fr_CustomerAddress";
            this.fr_CustomerAddress.Size = new System.Drawing.Size(140, 31);
            this.fr_CustomerAddress.TabIndex = 39;
            // 
            // fr_CustomerName
            // 
            this.fr_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_CustomerName.Location = new System.Drawing.Point(182, 90);
            this.fr_CustomerName.Name = "fr_CustomerName";
            this.fr_CustomerName.Size = new System.Drawing.Size(140, 31);
            this.fr_CustomerName.TabIndex = 38;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(23, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(350, 36);
            this.lblCustomer.TabIndex = 37;
            this.lblCustomer.Text = "Enter Customer Record";
            // 
            // fr_btnCustomerDElete
            // 
            this.fr_btnCustomerDElete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnCustomerDElete.Location = new System.Drawing.Point(223, 251);
            this.fr_btnCustomerDElete.Name = "fr_btnCustomerDElete";
            this.fr_btnCustomerDElete.Size = new System.Drawing.Size(99, 33);
            this.fr_btnCustomerDElete.TabIndex = 46;
            this.fr_btnCustomerDElete.Text = "Delete";
            this.fr_btnCustomerDElete.UseVisualStyleBackColor = true;
            this.fr_btnCustomerDElete.Click += new System.EventHandler(this.fr_btnCustomerDElete_Click);
            // 
            // fr_btnVideoDelete
            // 
            this.fr_btnVideoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnVideoDelete.Location = new System.Drawing.Point(579, 372);
            this.fr_btnVideoDelete.Name = "fr_btnVideoDelete";
            this.fr_btnVideoDelete.Size = new System.Drawing.Size(95, 36);
            this.fr_btnVideoDelete.TabIndex = 64;
            this.fr_btnVideoDelete.Text = "Delete";
            this.fr_btnVideoDelete.UseVisualStyleBackColor = true;
            this.fr_btnVideoDelete.Click += new System.EventHandler(this.fr_btnVideoDelete_Click);
            // 
            // fr_btnVideoUpdate
            // 
            this.fr_btnVideoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnVideoUpdate.Location = new System.Drawing.Point(434, 372);
            this.fr_btnVideoUpdate.Name = "fr_btnVideoUpdate";
            this.fr_btnVideoUpdate.Size = new System.Drawing.Size(95, 36);
            this.fr_btnVideoUpdate.TabIndex = 63;
            this.fr_btnVideoUpdate.Text = "Update";
            this.fr_btnVideoUpdate.UseVisualStyleBackColor = true;
            this.fr_btnVideoUpdate.Click += new System.EventHandler(this.fr_btnVideoUpdate_Click);
            // 
            // fr_btnVideoSAve
            // 
            this.fr_btnVideoSAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnVideoSAve.Location = new System.Drawing.Point(326, 372);
            this.fr_btnVideoSAve.Name = "fr_btnVideoSAve";
            this.fr_btnVideoSAve.Size = new System.Drawing.Size(74, 36);
            this.fr_btnVideoSAve.TabIndex = 62;
            this.fr_btnVideoSAve.Text = "Save Data";
            this.fr_btnVideoSAve.UseVisualStyleBackColor = true;
            this.fr_btnVideoSAve.Click += new System.EventHandler(this.fr_btnVideoSAve_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(361, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 21);
            this.label13.TabIndex = 61;
            this.label13.Text = "Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 60;
            this.label12.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 59;
            this.label11.Text = "Ratting";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(361, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Copies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Cost";
            // 
            // fr_VideoCopies
            // 
            this.fr_VideoCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoCopies.Location = new System.Drawing.Point(534, 261);
            this.fr_VideoCopies.Name = "fr_VideoCopies";
            this.fr_VideoCopies.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoCopies.TabIndex = 54;
            // 
            // fr_VideoPlot
            // 
            this.fr_VideoPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoPlot.Location = new System.Drawing.Point(534, 298);
            this.fr_VideoPlot.Name = "fr_VideoPlot";
            this.fr_VideoPlot.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoPlot.TabIndex = 53;
            // 
            // fr_VideoGenre
            // 
            this.fr_VideoGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoGenre.Location = new System.Drawing.Point(534, 335);
            this.fr_VideoGenre.Name = "fr_VideoGenre";
            this.fr_VideoGenre.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoGenre.TabIndex = 52;
            // 
            // fr_VideoTitle
            // 
            this.fr_VideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoTitle.Location = new System.Drawing.Point(534, 63);
            this.fr_VideoTitle.Name = "fr_VideoTitle";
            this.fr_VideoTitle.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoTitle.TabIndex = 51;
            // 
            // fr_VideoYear
            // 
            this.fr_VideoYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoYear.Location = new System.Drawing.Point(534, 172);
            this.fr_VideoYear.Name = "fr_VideoYear";
            this.fr_VideoYear.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoYear.TabIndex = 50;
            this.fr_VideoYear.TextChanged += new System.EventHandler(this.fr_VideoYear_TextChanged);
            // 
            // fr_VideoRatting
            // 
            this.fr_VideoRatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoRatting.Location = new System.Drawing.Point(534, 120);
            this.fr_VideoRatting.Name = "fr_VideoRatting";
            this.fr_VideoRatting.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoRatting.TabIndex = 49;
            // 
            // fr_VideoCost
            // 
            this.fr_VideoCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoCost.Location = new System.Drawing.Point(534, 214);
            this.fr_VideoCost.Name = "fr_VideoCost";
            this.fr_VideoCost.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoCost.TabIndex = 48;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(385, 9);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(295, 36);
            this.lblVideo.TabIndex = 47;
            this.lblVideo.Text = "Enter Video Record";
            // 
            // fr_btnRentalDelete
            // 
            this.fr_btnRentalDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnRentalDelete.Location = new System.Drawing.Point(914, 298);
            this.fr_btnRentalDelete.Name = "fr_btnRentalDelete";
            this.fr_btnRentalDelete.Size = new System.Drawing.Size(96, 31);
            this.fr_btnRentalDelete.TabIndex = 78;
            this.fr_btnRentalDelete.Text = "Delete";
            this.fr_btnRentalDelete.UseVisualStyleBackColor = true;
            this.fr_btnRentalDelete.Click += new System.EventHandler(this.fr_btnRentalDelete_Click);
            // 
            // fr_btnRentalReturn
            // 
            this.fr_btnRentalReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnRentalReturn.Location = new System.Drawing.Point(804, 298);
            this.fr_btnRentalReturn.Name = "fr_btnRentalReturn";
            this.fr_btnRentalReturn.Size = new System.Drawing.Size(92, 31);
            this.fr_btnRentalReturn.TabIndex = 77;
            this.fr_btnRentalReturn.Text = "Return";
            this.fr_btnRentalReturn.UseVisualStyleBackColor = true;
            this.fr_btnRentalReturn.Click += new System.EventHandler(this.fr_btnRentalReturn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(715, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 21);
            this.label18.TabIndex = 76;
            this.label18.Text = "Return Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(715, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 21);
            this.label17.TabIndex = 75;
            this.label17.Text = "Booking Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(715, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 21);
            this.label16.TabIndex = 74;
            this.label16.Text = "Video ID";
            // 
            // fr_btnRentalBooking
            // 
            this.fr_btnRentalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnRentalBooking.Location = new System.Drawing.Point(705, 298);
            this.fr_btnRentalBooking.Name = "fr_btnRentalBooking";
            this.fr_btnRentalBooking.Size = new System.Drawing.Size(81, 31);
            this.fr_btnRentalBooking.TabIndex = 73;
            this.fr_btnRentalBooking.Text = "Book";
            this.fr_btnRentalBooking.UseVisualStyleBackColor = true;
            this.fr_btnRentalBooking.Click += new System.EventHandler(this.fr_btnRentalBooking_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(715, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 21);
            this.label15.TabIndex = 72;
            this.label15.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(715, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 21);
            this.label14.TabIndex = 71;
            this.label14.Text = "ID";
            // 
            // fr_Return
            // 
            this.fr_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fr_Return.Location = new System.Drawing.Point(870, 266);
            this.fr_Return.Name = "fr_Return";
            this.fr_Return.Size = new System.Drawing.Size(140, 26);
            this.fr_Return.TabIndex = 70;
            // 
            // fr_Booking
            // 
            this.fr_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_Booking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fr_Booking.Location = new System.Drawing.Point(870, 223);
            this.fr_Booking.Name = "fr_Booking";
            this.fr_Booking.Size = new System.Drawing.Size(140, 26);
            this.fr_Booking.TabIndex = 69;
            // 
            // fr_VideoId
            // 
            this.fr_VideoId.Enabled = false;
            this.fr_VideoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_VideoId.Location = new System.Drawing.Point(870, 172);
            this.fr_VideoId.Name = "fr_VideoId";
            this.fr_VideoId.Size = new System.Drawing.Size(140, 31);
            this.fr_VideoId.TabIndex = 68;
            // 
            // fr_CustomerId
            // 
            this.fr_CustomerId.Enabled = false;
            this.fr_CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_CustomerId.Location = new System.Drawing.Point(870, 123);
            this.fr_CustomerId.Name = "fr_CustomerId";
            this.fr_CustomerId.Size = new System.Drawing.Size(140, 31);
            this.fr_CustomerId.TabIndex = 67;
            // 
            // fr_RentId
            // 
            this.fr_RentId.Enabled = false;
            this.fr_RentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_RentId.Location = new System.Drawing.Point(870, 66);
            this.fr_RentId.Name = "fr_RentId";
            this.fr_RentId.Size = new System.Drawing.Size(140, 31);
            this.fr_RentId.TabIndex = 66;
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(776, 13);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(190, 32);
            this.lblRental.TabIndex = 65;
            this.lblRental.Text = "Rental Details";
            // 
            // recordTable
            // 
            this.recordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordTable.Location = new System.Drawing.Point(29, 455);
            this.recordTable.Name = "recordTable";
            this.recordTable.Size = new System.Drawing.Size(867, 194);
            this.recordTable.TabIndex = 79;
            this.recordTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordTable_CellClick);
            // 
            // fr_show_video
            // 
            this.fr_show_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_show_video.Location = new System.Drawing.Point(7, 413);
            this.fr_show_video.Name = "fr_show_video";
            this.fr_show_video.Size = new System.Drawing.Size(103, 36);
            this.fr_show_video.TabIndex = 80;
            this.fr_show_video.Text = "Videos";
            this.fr_show_video.UseVisualStyleBackColor = true;
            this.fr_show_video.Click += new System.EventHandler(this.fr_show_video_Click);
            // 
            // fr_show_customer
            // 
            this.fr_show_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_show_customer.Location = new System.Drawing.Point(116, 413);
            this.fr_show_customer.Name = "fr_show_customer";
            this.fr_show_customer.Size = new System.Drawing.Size(113, 36);
            this.fr_show_customer.TabIndex = 81;
            this.fr_show_customer.Text = "Customers";
            this.fr_show_customer.UseVisualStyleBackColor = true;
            this.fr_show_customer.Click += new System.EventHandler(this.fr_show_customer_Click);
            // 
            // fr_show_rentals
            // 
            this.fr_show_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_show_rentals.Location = new System.Drawing.Point(235, 414);
            this.fr_show_rentals.Name = "fr_show_rentals";
            this.fr_show_rentals.Size = new System.Drawing.Size(103, 36);
            this.fr_show_rentals.TabIndex = 82;
            this.fr_show_rentals.Text = "Rentals";
            this.fr_show_rentals.UseVisualStyleBackColor = true;
            this.fr_show_rentals.Click += new System.EventHandler(this.fr_show_rentals_Click);
            // 
            // fr_btnMostMovie
            // 
            this.fr_btnMostMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnMostMovie.Location = new System.Drawing.Point(16, 304);
            this.fr_btnMostMovie.Name = "fr_btnMostMovie";
            this.fr_btnMostMovie.Size = new System.Drawing.Size(293, 45);
            this.fr_btnMostMovie.TabIndex = 84;
            this.fr_btnMostMovie.Text = "Most Popular Movie";
            this.fr_btnMostMovie.UseVisualStyleBackColor = true;
            this.fr_btnMostMovie.Click += new System.EventHandler(this.fr_btnMostMovie_Click);
            // 
            // fr_btnMostCustomer
            // 
            this.fr_btnMostCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr_btnMostCustomer.Location = new System.Drawing.Point(18, 355);
            this.fr_btnMostCustomer.Name = "fr_btnMostCustomer";
            this.fr_btnMostCustomer.Size = new System.Drawing.Size(291, 45);
            this.fr_btnMostCustomer.TabIndex = 83;
            this.fr_btnMostCustomer.Text = "Good customer";
            this.fr_btnMostCustomer.UseVisualStyleBackColor = true;
            this.fr_btnMostCustomer.Click += new System.EventHandler(this.fr_btnMostCustomer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 653);
            this.Controls.Add(this.fr_btnMostMovie);
            this.Controls.Add(this.fr_btnMostCustomer);
            this.Controls.Add(this.fr_show_rentals);
            this.Controls.Add(this.fr_show_customer);
            this.Controls.Add(this.fr_show_video);
            this.Controls.Add(this.recordTable);
            this.Controls.Add(this.fr_btnRentalDelete);
            this.Controls.Add(this.fr_btnRentalReturn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.fr_btnRentalBooking);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fr_Return);
            this.Controls.Add(this.fr_Booking);
            this.Controls.Add(this.fr_VideoId);
            this.Controls.Add(this.fr_CustomerId);
            this.Controls.Add(this.fr_RentId);
            this.Controls.Add(this.lblRental);
            this.Controls.Add(this.fr_btnVideoDelete);
            this.Controls.Add(this.fr_btnVideoUpdate);
            this.Controls.Add(this.fr_btnVideoSAve);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fr_VideoCopies);
            this.Controls.Add(this.fr_VideoPlot);
            this.Controls.Add(this.fr_VideoGenre);
            this.Controls.Add(this.fr_VideoTitle);
            this.Controls.Add(this.fr_VideoYear);
            this.Controls.Add(this.fr_VideoRatting);
            this.Controls.Add(this.fr_VideoCost);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.fr_btnCustomerDElete);
            this.Controls.Add(this.fr_btnCustomerUpdate);
            this.Controls.Add(this.fr_btnCustomerSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fr_CustomerMObile);
            this.Controls.Add(this.fr_CustomerAddress);
            this.Controls.Add(this.fr_CustomerName);
            this.Controls.Add(this.lblCustomer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.recordTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fr_btnCustomerUpdate;
        private System.Windows.Forms.Button fr_btnCustomerSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fr_CustomerMObile;
        private System.Windows.Forms.TextBox fr_CustomerAddress;
        private System.Windows.Forms.TextBox fr_CustomerName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button fr_btnCustomerDElete;
        private System.Windows.Forms.Button fr_btnVideoDelete;
        private System.Windows.Forms.Button fr_btnVideoUpdate;
        private System.Windows.Forms.Button fr_btnVideoSAve;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fr_VideoCopies;
        private System.Windows.Forms.TextBox fr_VideoPlot;
        private System.Windows.Forms.TextBox fr_VideoGenre;
        private System.Windows.Forms.TextBox fr_VideoTitle;
        private System.Windows.Forms.TextBox fr_VideoYear;
        private System.Windows.Forms.TextBox fr_VideoRatting;
        private System.Windows.Forms.TextBox fr_VideoCost;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Button fr_btnRentalDelete;
        private System.Windows.Forms.Button fr_btnRentalReturn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button fr_btnRentalBooking;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker fr_Return;
        private System.Windows.Forms.DateTimePicker fr_Booking;
        private System.Windows.Forms.TextBox fr_VideoId;
        private System.Windows.Forms.TextBox fr_CustomerId;
        private System.Windows.Forms.TextBox fr_RentId;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.DataGridView recordTable;
        private System.Windows.Forms.Button fr_show_video;
        private System.Windows.Forms.Button fr_show_customer;
        private System.Windows.Forms.Button fr_show_rentals;
        private System.Windows.Forms.Button fr_btnMostMovie;
        private System.Windows.Forms.Button fr_btnMostCustomer;
    }
}