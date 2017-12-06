namespace EzTravel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Departure = new System.Windows.Forms.TextBox();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.dtg_Plan = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbox_Destination = new System.Windows.Forms.ListBox();
            this.lbox_Departure = new System.Windows.Forms.ListBox();
            this.dtg_Table = new System.Windows.Forms.DataGridView();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.lbl_Tafel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Search.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(378, 105);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 102);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Suchen";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "EzTravel";
            // 
            // txt_Departure
            // 
            this.txt_Departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Departure.ForeColor = System.Drawing.Color.Gray;
            this.txt_Departure.Location = new System.Drawing.Point(42, 105);
            this.txt_Departure.Name = "txt_Departure";
            this.txt_Departure.Size = new System.Drawing.Size(312, 26);
            this.txt_Departure.TabIndex = 3;
            this.txt_Departure.Text = "Abfahrtsort";
            this.txt_Departure.TextChanged += new System.EventHandler(this.txt_Departure_TextChanged);
            this.txt_Departure.Enter += new System.EventHandler(this.txt_Departure_Enter);
            this.txt_Departure.Leave += new System.EventHandler(this.txt_Departure_Leave);
            // 
            // txt_Destination
            // 
            this.txt_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Destination.ForeColor = System.Drawing.Color.Gray;
            this.txt_Destination.Location = new System.Drawing.Point(42, 181);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(312, 26);
            this.txt_Destination.TabIndex = 4;
            this.txt_Destination.Text = "Zielort";
            this.txt_Destination.TextChanged += new System.EventHandler(this.txt_Destination_TextChanged);
            this.txt_Destination.Enter += new System.EventHandler(this.txt_Destination_Enter);
            this.txt_Destination.Leave += new System.EventHandler(this.txt_Destination_Leave);
            // 
            // dtg_Plan
            // 
            this.dtg_Plan.AllowUserToAddRows = false;
            this.dtg_Plan.AllowUserToDeleteRows = false;
            this.dtg_Plan.AllowUserToResizeColumns = false;
            this.dtg_Plan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Plan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Plan.Location = new System.Drawing.Point(563, 105);
            this.dtg_Plan.Name = "dtg_Plan";
            this.dtg_Plan.Size = new System.Drawing.Size(445, 143);
            this.dtg_Plan.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(957, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Drucken";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(804, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "E-Mail";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CustomFormat = "ddMMMMyyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 235);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 235);
            this.dateTimePicker2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 26);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // lbox_Destination
            // 
            this.lbox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_Destination.FormattingEnabled = true;
            this.lbox_Destination.ItemHeight = 16;
            this.lbox_Destination.Location = new System.Drawing.Point(42, 206);
            this.lbox_Destination.Name = "lbox_Destination";
            this.lbox_Destination.Size = new System.Drawing.Size(312, 164);
            this.lbox_Destination.TabIndex = 14;
            this.lbox_Destination.Visible = false;
            this.lbox_Destination.DoubleClick += new System.EventHandler(this.lbox_Destination_DoubleClick);
            // 
            // lbox_Departure
            // 
            this.lbox_Departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_Departure.FormattingEnabled = true;
            this.lbox_Departure.ItemHeight = 16;
            this.lbox_Departure.Location = new System.Drawing.Point(42, 130);
            this.lbox_Departure.Name = "lbox_Departure";
            this.lbox_Departure.Size = new System.Drawing.Size(312, 164);
            this.lbox_Departure.TabIndex = 15;
            this.lbox_Departure.Visible = false;
            this.lbox_Departure.DoubleClick += new System.EventHandler(this.lbox_Departure_DoubleClick);
            // 
            // dtg_Table
            // 
            this.dtg_Table.AllowUserToAddRows = false;
            this.dtg_Table.AllowUserToDeleteRows = false;
            this.dtg_Table.AllowUserToOrderColumns = true;
            this.dtg_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Table.Location = new System.Drawing.Point(563, 300);
            this.dtg_Table.Name = "dtg_Table";
            this.dtg_Table.Size = new System.Drawing.Size(445, 238);
            this.dtg_Table.TabIndex = 16;
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.AutoSize = true;
            this.lbl_Plan.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Plan.Location = new System.Drawing.Point(558, 70);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(82, 32);
            this.lbl_Plan.TabIndex = 17;
            this.lbl_Plan.Text = "Fahrplan";
            // 
            // lbl_Tafel
            // 
            this.lbl_Tafel.AutoSize = true;
            this.lbl_Tafel.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Tafel.Location = new System.Drawing.Point(558, 265);
            this.lbl_Tafel.Name = "lbl_Tafel";
            this.lbl_Tafel.Size = new System.Drawing.Size(121, 32);
            this.lbl_Tafel.TabIndex = 18;
            this.lbl_Tafel.Text = "Abfahrtstafel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1074, 617);
            this.Controls.Add(this.lbox_Destination);
            this.Controls.Add(this.lbox_Departure);
            this.Controls.Add(this.lbl_Tafel);
            this.Controls.Add(this.lbl_Plan);
            this.Controls.Add(this.dtg_Table);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtg_Plan);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.txt_Departure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EzTravel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Departure;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.DataGridView dtg_Plan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox lbox_Destination;
        private System.Windows.Forms.ListBox lbox_Departure;
        private System.Windows.Forms.DataGridView dtg_Table;
        private System.Windows.Forms.Label lbl_Plan;
        private System.Windows.Forms.Label lbl_Tafel;
    }
}

