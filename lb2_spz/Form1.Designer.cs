
namespace lb2_spz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_fee = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_students = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_staff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_rooms = new System.Windows.Forms.NumericUpDown();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_annual = new System.Windows.Forms.TextBox();
            this.textBox_semi = new System.Windows.Forms.TextBox();
            this.textBox_monthly = new System.Windows.Forms.TextBox();
            this.numericUpDown_evict = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_settle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_increaseRooms = new System.Windows.Forms.NumericUpDown();
            this.button_increaseRooms = new System.Windows.Forms.Button();
            this.button_settle = new System.Windows.Forms.Button();
            this.button_evict = new System.Windows.Forms.Button();
            this.button_monthlyIncome = new System.Windows.Forms.Button();
            this.button_semiIncome = new System.Windows.Forms.Button();
            this.button_annualIncome = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_createCopy = new System.Windows.Forms.Button();
            this.button_addCanteen = new System.Windows.Forms.Button();
            this.button_outputData = new System.Windows.Forms.Button();
            this.button_inputData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rooms)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_evict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_settle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_increaseRooms)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_fee, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_students, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_staff, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_rooms, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_address, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDown_fee
            // 
            this.numericUpDown_fee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_fee.DecimalPlaces = 2;
            this.numericUpDown_fee.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_fee.Location = new System.Drawing.Point(204, 304);
            this.numericUpDown_fee.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_fee.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown_fee.Name = "numericUpDown_fee";
            this.numericUpDown_fee.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown_fee.TabIndex = 5;
            this.numericUpDown_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_fee.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // numericUpDown_students
            // 
            this.numericUpDown_students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_students.Location = new System.Drawing.Point(204, 245);
            this.numericUpDown_students.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown_students.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_students.Name = "numericUpDown_students";
            this.numericUpDown_students.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown_students.TabIndex = 4;
            this.numericUpDown_students.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_students.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_staff
            // 
            this.numericUpDown_staff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_staff.Location = new System.Drawing.Point(204, 188);
            this.numericUpDown_staff.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_staff.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_staff.Name = "numericUpDown_staff";
            this.numericUpDown_staff.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown_staff.TabIndex = 3;
            this.numericUpDown_staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_staff.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_rooms
            // 
            this.numericUpDown_rooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_rooms.Location = new System.Drawing.Point(204, 131);
            this.numericUpDown_rooms.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown_rooms.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_rooms.Name = "numericUpDown_rooms";
            this.numericUpDown_rooms.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown_rooms.TabIndex = 1;
            this.numericUpDown_rooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_rooms.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_name.Location = new System.Drawing.Point(206, 17);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 23);
            this.textBox_name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Accommodation fee";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Number of students";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of staff";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of rooms";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "University name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_address.Location = new System.Drawing.Point(206, 74);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 23);
            this.textBox_address.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_annual, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox_semi, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox_monthly, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_evict, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_settle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_increaseRooms, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_increaseRooms, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_settle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_evict, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_monthlyIncome, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_semiIncome, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_annualIncome, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(498, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 346);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox_annual
            // 
            this.textBox_annual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_annual.Location = new System.Drawing.Point(169, 304);
            this.textBox_annual.Name = "textBox_annual";
            this.textBox_annual.ReadOnly = true;
            this.textBox_annual.Size = new System.Drawing.Size(100, 23);
            this.textBox_annual.TabIndex = 11;
            this.textBox_annual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_semi
            // 
            this.textBox_semi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_semi.Location = new System.Drawing.Point(169, 245);
            this.textBox_semi.Name = "textBox_semi";
            this.textBox_semi.ReadOnly = true;
            this.textBox_semi.Size = new System.Drawing.Size(100, 23);
            this.textBox_semi.TabIndex = 10;
            this.textBox_semi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_monthly
            // 
            this.textBox_monthly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_monthly.Location = new System.Drawing.Point(169, 188);
            this.textBox_monthly.Name = "textBox_monthly";
            this.textBox_monthly.ReadOnly = true;
            this.textBox_monthly.Size = new System.Drawing.Size(100, 23);
            this.textBox_monthly.TabIndex = 9;
            this.textBox_monthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_evict
            // 
            this.numericUpDown_evict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_evict.Location = new System.Drawing.Point(167, 131);
            this.numericUpDown_evict.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_evict.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_evict.Name = "numericUpDown_evict";
            this.numericUpDown_evict.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown_evict.TabIndex = 8;
            this.numericUpDown_evict.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_evict.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_settle
            // 
            this.numericUpDown_settle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_settle.Location = new System.Drawing.Point(167, 74);
            this.numericUpDown_settle.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown_settle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_settle.Name = "numericUpDown_settle";
            this.numericUpDown_settle.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown_settle.TabIndex = 7;
            this.numericUpDown_settle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_settle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_increaseRooms
            // 
            this.numericUpDown_increaseRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_increaseRooms.Location = new System.Drawing.Point(167, 17);
            this.numericUpDown_increaseRooms.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_increaseRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_increaseRooms.Name = "numericUpDown_increaseRooms";
            this.numericUpDown_increaseRooms.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown_increaseRooms.TabIndex = 6;
            this.numericUpDown_increaseRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_increaseRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_increaseRooms
            // 
            this.button_increaseRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_increaseRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_increaseRooms.Location = new System.Drawing.Point(3, 3);
            this.button_increaseRooms.Name = "button_increaseRooms";
            this.button_increaseRooms.Size = new System.Drawing.Size(158, 51);
            this.button_increaseRooms.TabIndex = 0;
            this.button_increaseRooms.Text = "Increase the number of rooms";
            this.button_increaseRooms.UseVisualStyleBackColor = true;
            this.button_increaseRooms.Click += new System.EventHandler(this.button_increaseRooms_Click);
            // 
            // button_settle
            // 
            this.button_settle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_settle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_settle.Location = new System.Drawing.Point(3, 60);
            this.button_settle.Name = "button_settle";
            this.button_settle.Size = new System.Drawing.Size(158, 51);
            this.button_settle.TabIndex = 1;
            this.button_settle.Text = "Settle student";
            this.button_settle.UseVisualStyleBackColor = true;
            this.button_settle.Click += new System.EventHandler(this.button_settle_Click);
            // 
            // button_evict
            // 
            this.button_evict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_evict.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_evict.Location = new System.Drawing.Point(3, 117);
            this.button_evict.Name = "button_evict";
            this.button_evict.Size = new System.Drawing.Size(158, 51);
            this.button_evict.TabIndex = 2;
            this.button_evict.Text = "Evict a student";
            this.button_evict.UseVisualStyleBackColor = true;
            this.button_evict.Click += new System.EventHandler(this.button_evict_Click);
            // 
            // button_monthlyIncome
            // 
            this.button_monthlyIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_monthlyIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_monthlyIncome.Location = new System.Drawing.Point(3, 174);
            this.button_monthlyIncome.Name = "button_monthlyIncome";
            this.button_monthlyIncome.Size = new System.Drawing.Size(158, 51);
            this.button_monthlyIncome.TabIndex = 3;
            this.button_monthlyIncome.Text = "Monthly income";
            this.button_monthlyIncome.UseVisualStyleBackColor = true;
            this.button_monthlyIncome.Click += new System.EventHandler(this.button_monthlyIncome_Click);
            // 
            // button_semiIncome
            // 
            this.button_semiIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_semiIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_semiIncome.Location = new System.Drawing.Point(3, 231);
            this.button_semiIncome.Name = "button_semiIncome";
            this.button_semiIncome.Size = new System.Drawing.Size(158, 51);
            this.button_semiIncome.TabIndex = 4;
            this.button_semiIncome.Text = "Semi-annual income";
            this.button_semiIncome.UseVisualStyleBackColor = true;
            this.button_semiIncome.Click += new System.EventHandler(this.button_semiIncome_Click);
            // 
            // button_annualIncome
            // 
            this.button_annualIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_annualIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_annualIncome.Location = new System.Drawing.Point(3, 290);
            this.button_annualIncome.Name = "button_annualIncome";
            this.button_annualIncome.Size = new System.Drawing.Size(158, 51);
            this.button_annualIncome.TabIndex = 5;
            this.button_annualIncome.Text = "Annual income";
            this.button_annualIncome.UseVisualStyleBackColor = true;
            this.button_annualIncome.Click += new System.EventHandler(this.button_annualIncome_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button_createCopy, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_addCanteen, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button_outputData, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_inputData, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(338, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(157, 341);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button_createCopy
            // 
            this.button_createCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_createCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_createCopy.Location = new System.Drawing.Point(24, 276);
            this.button_createCopy.Name = "button_createCopy";
            this.button_createCopy.Size = new System.Drawing.Size(108, 44);
            this.button_createCopy.TabIndex = 3;
            this.button_createCopy.Text = "Create copy";
            this.button_createCopy.UseVisualStyleBackColor = true;
            this.button_createCopy.Click += new System.EventHandler(this.button_createCopy_Click);
            // 
            // button_addCanteen
            // 
            this.button_addCanteen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_addCanteen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_addCanteen.Location = new System.Drawing.Point(24, 190);
            this.button_addCanteen.Name = "button_addCanteen";
            this.button_addCanteen.Size = new System.Drawing.Size(108, 44);
            this.button_addCanteen.TabIndex = 2;
            this.button_addCanteen.Text = "Add canteen";
            this.button_addCanteen.UseVisualStyleBackColor = true;
            this.button_addCanteen.Click += new System.EventHandler(this.button_addCanteen_Click);
            // 
            // button_outputData
            // 
            this.button_outputData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_outputData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_outputData.Location = new System.Drawing.Point(24, 105);
            this.button_outputData.Name = "button_outputData";
            this.button_outputData.Size = new System.Drawing.Size(108, 44);
            this.button_outputData.TabIndex = 1;
            this.button_outputData.Text = "Output data";
            this.button_outputData.UseVisualStyleBackColor = true;
            this.button_outputData.Click += new System.EventHandler(this.button_outputData_Click);
            // 
            // button_inputData
            // 
            this.button_inputData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_inputData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_inputData.Location = new System.Drawing.Point(24, 20);
            this.button_inputData.Name = "button_inputData";
            this.button_inputData.Size = new System.Drawing.Size(108, 44);
            this.button_inputData.TabIndex = 0;
            this.button_inputData.Text = "Input data";
            this.button_inputData.UseVisualStyleBackColor = true;
            this.button_inputData.Click += new System.EventHandler(this.button_inputData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(760, 171);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(3, 0);
            this.Name = "Form1";
            this.Text = "lb2_spz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rooms)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_evict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_settle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_increaseRooms)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.NumericUpDown numericUpDown_fee;
        private System.Windows.Forms.NumericUpDown numericUpDown_students;
        private System.Windows.Forms.NumericUpDown numericUpDown_staff;
        private System.Windows.Forms.NumericUpDown numericUpDown_rooms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_annual;
        private System.Windows.Forms.TextBox textBox_semi;
        private System.Windows.Forms.TextBox textBox_monthly;
        private System.Windows.Forms.NumericUpDown numericUpDown_evict;
        private System.Windows.Forms.NumericUpDown numericUpDown_settle;
        private System.Windows.Forms.NumericUpDown numericUpDown_increaseRooms;
        private System.Windows.Forms.Button button_increaseRooms;
        private System.Windows.Forms.Button button_settle;
        private System.Windows.Forms.Button button_evict;
        private System.Windows.Forms.Button button_monthlyIncome;
        private System.Windows.Forms.Button button_semiIncome;
        private System.Windows.Forms.Button button_annualIncome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_createCopy;
        private System.Windows.Forms.Button button_addCanteen;
        private System.Windows.Forms.Button button_outputData;
        private System.Windows.Forms.Button button_inputData;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

