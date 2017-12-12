using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web.UI.WebControls;
using SwissTransport;
using TextBox = System.Windows.Forms.TextBox;

namespace EzTravel
{
    public partial class Form1 : Form
    {
        Transport Transport = new Transport();
        private int TwoArrowsCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------Start-Events--------------------------------------------------------------------
        private void btn_Search_Click(object sender, EventArgs e)
        {
            HideListbox();
            if (txt_Departure.Text != "Abfahrtsort" && txt_Destination.Text != "Ankunftsort" && txt_Departure.Text != "" && txt_Destination.Text != "")
                {
                    CreatePlan();
                }
        }

        //Leert das Eingabe feld und ändert die Schrift farbe zu schwarz
        private void txt_Departure_Enter(object sender, EventArgs e)
        {
            HideListbox();
            SetDefaulttxt();
        }

        //Falls das Eingabe Feld leer ist, wird darin der Hinweis in Grauer schrift angezeigt
        private void txt_Departure_Leave(object sender, EventArgs e)
        {
            SetDefaulttxt();
        }

        //Leert das Eingabe feld und ändert die Schrift farbe zu schwarz
        private void txt_Destination_Enter(object sender, EventArgs e)
        {   
            HideListbox();
            SetDefaulttxt();
        }

        //Falls das Eingabe Feld leer ist, wird darin der Hinweis in Grauer schrift angezeigt
        private void txt_Destination_Leave(object sender, EventArgs e)
        {
            SetDefaulttxt();
            
        }
        //Füllt die ListBox mit Vorschläge
        private void txt_Departure_TextChanged(object sender, EventArgs e)
        {
            if (txt_Departure.Text != "" && txt_Departure.Text != "Abfahrtsort")
            {
                lbox_Departure.Items.Clear();
                Stations stations = Transport.GetStations(txt_Departure.Text);
                foreach (Station station in stations.StationList)
                {
                    lbox_Departure.Items.Add(station.Name);
                }
                if (txt_Departure.Text != "" && txt_Departure.Text != "Abfahrtsort" && lbox_Departure != null &&
                    TwoArrowsCounter == 0)
                {
                    txt_Departure.ForeColor = Color.Black;
                    lbox_Destination.Visible = false;
                    lbox_Departure.Visible = true;
                }
                else
                {
                    TwoArrowsCounter = 0;
                }
            }
        }
        //Füllt die ListBox mit Vorschläge
        private void txt_Destination_TextChanged(object sender, EventArgs e)
        {
            if (txt_Destination.Text != "" && txt_Destination.Text != "Zielort")
            {
                lbox_Destination.Items.Clear();
                Stations stations = Transport.GetStations(txt_Destination.Text);
                foreach (Station station in stations.StationList)
                {
                    lbox_Destination.Items.Add(station.Name);
                    lbox_Destination.Visible = true;
                }
                if (txt_Destination.Text != "" && txt_Destination.Text != "Zielort" && lbox_Destination != null &&
                    TwoArrowsCounter == 0)
                {
                    txt_Destination.ForeColor = Color.Black;
                    lbox_Departure.Visible = false;
                    lbox_Destination.Visible = true;
                }
                else
                {
                    TwoArrowsCounter = 0;
                }
            }
        }
        //Überschreibt die Textbox mit dem Ausgewälten item der Listbox
        private void lbox_Departure_DoubleClick(object sender, EventArgs e)
        {
            txt_Departure.ForeColor = Color.Black;
            txt_Departure.Text = Convert.ToString(lbox_Departure.SelectedItem);
            HideListbox();
        }

        private void lbox_Destination_DoubleClick(object sender, EventArgs e)
        {
            txt_Departure.ForeColor = Color.Black;
            txt_Destination.Text = Convert.ToString(lbox_Destination.SelectedItem);
            HideListbox();
        }
        //Überschreibt die Textbox mit dem Ausgewälten item der Listbox
        private void Form1_Click(object sender, EventArgs e)
        {
            HideListbox();
        }
        //Erlaubt die Navigierung durch die Listbox mit den Pfeiltasten und der Entertaste
        private void txt_Departure_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbox_Departure.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (lbox_Departure.SelectedIndex != lbox_Departure.Items.Count - 1)
                    {
                        lbox_Departure.SelectedIndex += 1;
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (lbox_Departure.SelectedIndex != 0)
                    {
                        lbox_Departure.SelectedIndex -= 1;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (lbox_Departure.Visible)
                    {
                        txt_Departure.ForeColor = Color.Black;
                        txt_Departure.Text = Convert.ToString(lbox_Departure.SelectedItem);
                        HideListbox();
                    }
                }
            }
        }
        //Erlaubt die Navigierung durch die Listbox mit den Pfeiltasten und der Entertaste
        private void txt_Destination_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbox_Destination.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (lbox_Destination.SelectedIndex != lbox_Destination.Items.Count - 1)
                    {
                        lbox_Destination.SelectedIndex += 1;
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (lbox_Destination.SelectedIndex != 0)
                    {
                        lbox_Destination.SelectedIndex -= 1;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (lbox_Destination.Visible)
                    {
                        txt_Destination.ForeColor = Color.Black;
                        txt_Destination.Text = Convert.ToString(lbox_Destination.SelectedItem);
                        HideListbox();
                    }
                }
            }
        }
        //Versteckt die Listboxen, falls auf das Form geklickt wurde. Siht vorerst nutzlos aus, doch verhindert einige Bugs
        private void tabPage1_Click(object sender, EventArgs e)
        {
            HideListbox();
        }
        //Erlaubt die Navigierung durch die Listbox mit den Pfeiltasten und der Entertaste
        private void btn_Mail_Click(object sender, EventArgs e)
        {
            SendMail();
        }
        //Vertausch die beiden Textboxen miteinander
        private void pb_TwoArrows_Click(object sender, EventArgs e)
        {
            ChangeTextboxes();
        }
        //-----------------------------------------------------Start-Methoden--------------------------------------------------------------------
        //Standart Methode, füllt die Leeren Text Boxen und ändert deren Schriftfarbe falls nötig
        void SetDefaulttxt()
        {
            if (txt_Departure.Text == "" || txt_Departure.Text == " ")
                {
                    HideListbox();
                    txt_Departure.ForeColor = Color.Gray;
                    txt_Departure.Text = "Abfahrtsort";
                }
            if (txt_Departure.Focused&&txt_Departure.Text == "Abfahrtsort")
            {
                HideListbox();
                txt_Departure.Clear();
                txt_Departure.ForeColor = Color.Black;
            }
            if (txt_Destination.Text == "" || txt_Destination.Text == " ")
                {
                    HideListbox();
                    txt_Destination.ForeColor = Color.Gray;
                    txt_Destination.Text = "Zielort";
                }
            if (txt_Destination.Focused && txt_Destination.Text == "Zielort")
            {
                HideListbox();
                txt_Destination.Clear();
                txt_Destination.ForeColor = Color.Black;
            }
        }
        //Versteckt beide Listboxen mit deren Vorschläge
        private void HideListbox()
        {
            lbox_Departure.Visible = false;
            lbox_Destination.Visible = false;
        }
        //Erstellt und füllt das DataGrid Plan mit Resultaten
        private void CreatePlan()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //DataTable erstellen
                DataTable dt_Connections = new DataTable();
                dt_Connections.Columns.Add("Abfahrtsort");
                dt_Connections.Columns.Add("Zielort");
                dt_Connections.Columns.Add("Abfahrtszeit");
                dt_Connections.Columns.Add("Zielzeit");
                dt_Connections.Columns.Add("Reisedauer");
                dt_Connections.Columns.Add("Abfahrtsdatum");


                //Verbindungen auslesen
                Connections stb = Transport.GetConnections(txt_Departure.Text, txt_Destination.Text, dtp_Time.Text, dtp_Date.Value.ToString("yyyy-MM-dd"));
    ;
                //Verbindungen in DataTAble speichern
                foreach (Connection station in stb.ConnectionList)

                {
                    dt_Connections.Rows.Add(station.From.Station.Name, station.To.Station.Name,
                    ConvertDateToTime(station.From.Departure), ConvertDateToTime(station.To.Arrival),TimeShortener(station.Duration), ConvertTimetoDate(station.To.Arrival));
                }
            
                //DatatAble in DataGrdid hinzufühen
                dtg_Plan.DataSource = dt_Connections;
                //Erstellt die GoogleMap

                CreateGmap(Convert.ToString(stb.ConnectionList[0].From.Station.Coordinate.XCoordinate), Convert.ToString(stb.ConnectionList[0].From.Station.Coordinate.YCoordinate), Convert.ToString(stb.ConnectionList[0].To.Station.Coordinate.XCoordinate), Convert.ToString(stb.ConnectionList[0].To.Station.Coordinate.YCoordinate));
                CreateTable(txt_Departure); //Musste ich hier reinnehmen um eine Exception zu verhindern, wenn ungültige Werte eingegeben werden

            }
            catch
            {
                if (txt_Departure.Text==txt_Destination.Text)
                {
                    MessageBox.Show("Sie haben den gleichen Abfahrtsort und Zielort eingegeben, bitte ändern Sie Ihre eingaben!", "Ups, da ist ein Fehler aufgetreten!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sie haben mindestens einen ungültigen Wert eingegeben, bitte ändern Sie Ihre eingaben!", "Ups, da ist ein Fehler aufgetreten!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }
        //Erstellt die Abfahrtstafel
        private void CreateTable(TextBox txt_Departure)
        {
            Cursor.Current = Cursors.WaitCursor;
            string stationId;
            Stations st_Departure = Transport.GetStations(txt_Departure.Text);

            //DataTable erstellen
            DataTable dt_DepartureBoard = new DataTable();
            dt_DepartureBoard.Columns.Add("Abfahrtzeit");
            dt_DepartureBoard.Columns.Add("Zielort");
            dt_DepartureBoard.Columns.Add("Station");

            stationId = st_Departure.StationList[0].Id;
            StationBoardRoot stbRoot = Transport.GetStationBoard(txt_Departure.Text, stationId);

            foreach (StationBoard s_Board in stbRoot.Entries)
            {
                //StationBoard in Datatable speichern
                dt_DepartureBoard.Rows.Add(s_Board.Stop.Departure.ToString("HH:mm"), s_Board.To, s_Board.Number);
            }

            dtg_Table.DataSource = dt_DepartureBoard;
        }
        //Ändert das Format des Datum zu einer Zeit für die Grafische Darstellung
        private string ConvertDateToTime(string str_dateTime)
        {
            //Time zum zurück geben
            string time = string.Empty;

            //DateTime parsen
            DateTime dateTime;
            DateTime.TryParse(str_dateTime, out dateTime);

            //Nur Zeit zum string
            time = dateTime.ToString("HH:mm");

            //Zeit zurück geben
            return time;
            
        }
        //Kürzt das Datum Format auf nur die Zeit
        private string ConvertTimetoDate(string str_dateTime)
        {
            string time = str_dateTime.Substring(0, 10);
            return time;
        }
        //Ergänzt die Zeit mit "Stunden" und "Minuten" und kürzt unnötige nullen raus
        private string TimeShortener(string longTime)
        {
            string shortTime = longTime.Remove(0, 3);
            shortTime = shortTime.Remove(shortTime.Length - 3);
            shortTime = shortTime + " Minuten";
            shortTime = shortTime.Replace(":", " Stunden ");
            shortTime = shortTime.Replace("00 Stunden 00 Minuten", "<1 Minute");
            shortTime = shortTime.Replace(" 00 Minuten", "");
            shortTime = shortTime.Replace("01 Minuten", "1 Minute");
            shortTime = shortTime.Replace("02 Minuten", "2 Minuten");
            shortTime = shortTime.Replace("03 Minuten", "3 Minuten");
            shortTime = shortTime.Replace("04 Minuten", "4 Minuten");
            shortTime = shortTime.Replace("05 Minuten", "5 Minuten");
            shortTime = shortTime.Replace("06 Minuten", "6 Minuten");
            shortTime = shortTime.Replace("07 Minuten", "7 Minuten");
            shortTime = shortTime.Replace("08 Minuten", "8 Minuten");
            shortTime = shortTime.Replace("09 Minuten", "9 Minuten");
            shortTime = shortTime.Replace("00 Stunden ", "");
            shortTime = shortTime.Replace("01 Stunden", "1 Stunde");
            shortTime = shortTime.Replace("02 Stunden", "2 Stunden");
            shortTime = shortTime.Replace("03 Stunden", "3 Stunden");
            shortTime = shortTime.Replace("04 Stunden", "4 Stunden");
            shortTime = shortTime.Replace("05 Stunden", "5 Stunden");
            shortTime = shortTime.Replace("06 Stunden", "6 Stunden");
            shortTime = shortTime.Replace("07 Stunden", "7 Stunden");
            shortTime = shortTime.Replace("08 Stunden", "8 Stunden");
            shortTime = shortTime.Replace("09 Stunden", "9 Stunden");

            return shortTime;
        }
        //Erstellt die Googlemap mit hilfe einer URL
        private void CreateGmap(string x1, string y1, string x2, string y2)
        {
            web_Gmap.AllowNavigation = true;
            web_Gmap.Visible = true;
            string xy="https://www.google.ch/maps/dir/"  + x1 + ", " + y1 + "/" + x2 + ", "+ y2;
            web_Gmap.Navigate(xy);
        }
        //Vertausch die beiden Textboxen miteinander
        private void ChangeTextboxes()
        {
            if (txt_Departure.Text != "Abfahrtsort" && txt_Destination.Text != "Zielort")
                {
                    TwoArrowsCounter = 1;
                    txt_Destination.ForeColor = Color.Black;
                    txt_Departure.ForeColor = Color.Black;
                    string oldtxt_Departure = txt_Departure.Text;
                    string oldtxt_Destination = txt_Destination.Text;
                    txt_Departure.Text = oldtxt_Destination;
                    txt_Destination.Text = oldtxt_Departure;
                    HideListbox();
                }
        }
        //Sendet eine E-Mail mit dem DataGrid Plan als Inhalt
        private void SendMail()
        {
            string textToPrint = "";
            for (int row = 0; row < dtg_Plan.Rows.Count; row++)
            {
                textToPrint +=
                    dtg_Plan.Rows[row].Cells[0].Value.ToString() + "    " +
                    dtg_Plan.Rows[row].Cells[1].Value.ToString() + "    " +
                    dtg_Plan.Rows[row].Cells[2].Value.ToString() + "    " +
                    dtg_Plan.Rows[row].Cells[3].Value.ToString() + "    " +
                    dtg_Plan.Rows[row].Cells[4].Value.ToString() + "    " +
                    dtg_Plan.Rows[row].Cells[5].Value.ToString() + "    " + "%0D%0A";
            }
            var url = "mailto:?subject=Meine" + " Verbindungen&body=" + textToPrint;
            Process.Start(url);
        }
        //-----------------------------------------------------Ende-Methoden--------------------------------------------------------------------
    }
}
