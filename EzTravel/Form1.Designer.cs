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
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.lbox_Destination = new System.Windows.Forms.ListBox();
            this.lbox_Departure = new System.Windows.Forms.ListBox();
            this.dtg_Table = new System.Windows.Forms.DataGridView();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.lbl_Tafel = new System.Windows.Forms.Label();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pb_TwoArrows = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.web_Gmap = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Table)).BeginInit();
            this.tab_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TwoArrows)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Search.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(335, 53);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(153, 114);
            this.btn_Search.TabIndex = 5;
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
            this.txt_Departure.Location = new System.Drawing.Point(14, 53);
            this.txt_Departure.Name = "txt_Departure";
            this.txt_Departure.Size = new System.Drawing.Size(300, 26);
            this.txt_Departure.TabIndex = 1;
            this.txt_Departure.Text = "Abfahrtsort";
            this.txt_Departure.TextChanged += new System.EventHandler(this.txt_Departure_TextChanged);
            this.txt_Departure.Enter += new System.EventHandler(this.txt_Departure_Enter);
            this.txt_Departure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Departure_KeyDown);
            this.txt_Departure.Leave += new System.EventHandler(this.txt_Departure_Leave);
            // 
            // txt_Destination
            // 
            this.txt_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Destination.ForeColor = System.Drawing.Color.Gray;
            this.txt_Destination.Location = new System.Drawing.Point(14, 141);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(300, 26);
            this.txt_Destination.TabIndex = 2;
            this.txt_Destination.Text = "Zielort";
            this.txt_Destination.TextChanged += new System.EventHandler(this.txt_Destination_TextChanged);
            this.txt_Destination.Enter += new System.EventHandler(this.txt_Destination_Enter);
            this.txt_Destination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Destination_KeyDown);
            this.txt_Destination.Leave += new System.EventHandler(this.txt_Destination_Leave);
            // 
            // dtg_Plan
            // 
            this.dtg_Plan.AllowUserToAddRows = false;
            this.dtg_Plan.AllowUserToDeleteRows = false;
            this.dtg_Plan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Plan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Plan.Location = new System.Drawing.Point(522, 49);
            this.dtg_Plan.Name = "dtg_Plan";
            this.dtg_Plan.Size = new System.Drawing.Size(445, 143);
            this.dtg_Plan.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(892, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Drucken";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(762, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "E-Mail";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtp_Date.CustomFormat = "ddMMMMyyyy";
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(14, 225);
            this.dtp_Date.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtp_Date.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(175, 26);
            this.dtp_Date.TabIndex = 3;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(202, 26);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(100, 64);
            this.pb_Logo.TabIndex = 12;
            this.pb_Logo.TabStop = false;
            // 
            // dtp_Time
            // 
            this.dtp_Time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Time.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtp_Time.Checked = false;
            this.dtp_Time.CustomFormat = "HH:mm";
            this.dtp_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Time.Location = new System.Drawing.Point(229, 225);
            this.dtp_Time.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtp_Time.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.ShowUpDown = true;
            this.dtp_Time.Size = new System.Drawing.Size(85, 26);
            this.dtp_Time.TabIndex = 4;
            // 
            // lbox_Destination
            // 
            this.lbox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_Destination.FormattingEnabled = true;
            this.lbox_Destination.ItemHeight = 16;
            this.lbox_Destination.Location = new System.Drawing.Point(14, 166);
            this.lbox_Destination.Name = "lbox_Destination";
            this.lbox_Destination.Size = new System.Drawing.Size(300, 196);
            this.lbox_Destination.TabIndex = 14;
            this.lbox_Destination.Visible = false;
            this.lbox_Destination.DoubleClick += new System.EventHandler(this.lbox_Destination_DoubleClick);
            // 
            // lbox_Departure
            // 
            this.lbox_Departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_Departure.FormattingEnabled = true;
            this.lbox_Departure.ItemHeight = 16;
            this.lbox_Departure.Location = new System.Drawing.Point(78, 225);
            this.lbox_Departure.Name = "lbox_Departure";
            this.lbox_Departure.Size = new System.Drawing.Size(300, 196);
            this.lbox_Departure.TabIndex = 15;
            this.lbox_Departure.Visible = false;
            this.lbox_Departure.DoubleClick += new System.EventHandler(this.lbox_Departure_DoubleClick);
            // 
            // dtg_Table
            // 
            this.dtg_Table.AllowUserToAddRows = false;
            this.dtg_Table.AllowUserToDeleteRows = false;
            this.dtg_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Table.Location = new System.Drawing.Point(522, 242);
            this.dtg_Table.Name = "dtg_Table";
            this.dtg_Table.Size = new System.Drawing.Size(445, 344);
            this.dtg_Table.TabIndex = 16;
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.AutoSize = true;
            this.lbl_Plan.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Plan.Location = new System.Drawing.Point(516, 14);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(82, 32);
            this.lbl_Plan.TabIndex = 17;
            this.lbl_Plan.Text = "Fahrplan";
            // 
            // lbl_Tafel
            // 
            this.lbl_Tafel.AutoSize = true;
            this.lbl_Tafel.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Tafel.Location = new System.Drawing.Point(516, 207);
            this.lbl_Tafel.Name = "lbl_Tafel";
            this.lbl_Tafel.Size = new System.Drawing.Size(121, 32);
            this.lbl_Tafel.TabIndex = 18;
            this.lbl_Tafel.Text = "Abfahrtstafel";
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.tabPage1);
            this.tab_Main.Controls.Add(this.tabPage2);
            this.tab_Main.Location = new System.Drawing.Point(12, 96);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(988, 682);
            this.tab_Main.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbox_Departure);
            this.tabPage1.Controls.Add(this.lbox_Destination);
            this.tabPage1.Controls.Add(this.lbl_Plan);
            this.tabPage1.Controls.Add(this.lbl_Tafel);
            this.tabPage1.Controls.Add(this.dtp_Date);
            this.tabPage1.Controls.Add(this.dtg_Table);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dtp_Time);
            this.tabPage1.Controls.Add(this.txt_Destination);
            this.tabPage1.Controls.Add(this.dtg_Plan);
            this.tabPage1.Controls.Add(this.txt_Departure);
            this.tabPage1.Controls.Add(this.btn_Search);
            this.tabPage1.Controls.Add(this.pb_TwoArrows);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindung Suchen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pb_TwoArrows
            // 
            this.pb_TwoArrows.Image = ((System.Drawing.Image)(resources.GetObject("pb_TwoArrows.Image")));
            this.pb_TwoArrows.Location = new System.Drawing.Point(163, 85);
            this.pb_TwoArrows.Name = "pb_TwoArrows";
            this.pb_TwoArrows.Size = new System.Drawing.Size(48, 50);
            this.pb_TwoArrows.TabIndex = 19;
            this.pb_TwoArrows.TabStop = false;
            this.pb_TwoArrows.Click += new System.EventHandler(this.pb_TwoArrows_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.web_Gmap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auf Google Maps anschauen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // web_Gmap
            // 
            this.web_Gmap.Location = new System.Drawing.Point(-4, 0);
            this.web_Gmap.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_Gmap.Name = "web_Gmap";
            this.web_Gmap.Size = new System.Drawing.Size(984, 660);
            this.web_Gmap.TabIndex = 21;
            this.web_Gmap.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1012, 790);
            this.Controls.Add(this.tab_Main);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EzTravel";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Table)).EndInit();
            this.tab_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TwoArrows)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.ListBox lbox_Destination;
        private System.Windows.Forms.ListBox lbox_Departure;
        private System.Windows.Forms.DataGridView dtg_Table;
        private System.Windows.Forms.Label lbl_Plan;
        private System.Windows.Forms.Label lbl_Tafel;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser web_Gmap;
        private System.Windows.Forms.PictureBox pb_TwoArrows;
    }
}

