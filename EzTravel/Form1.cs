using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace EzTravel
{
    public partial class Form1 : Form
    {
        Transport Transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }
        //Events
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Departure.Text != "Abfahrtsort" && txt_Destination.Text != "Ankunftsort")
            {
                //hideListbox();
                createPlan();
                createTable(txt_Departure);
            }
        }

        //Leert das Eingabe feld und ändert die Schrift farbe zu schwarz
        private void txt_Departure_Enter(object sender, EventArgs e)
        {
            setDefaulttxt();
        }

        //Falls das Eingabe Feld leer ist, wird darin der Hinweis in Grauer schrift angezeigt
        private void txt_Departure_Leave(object sender, EventArgs e)
        {
            setDefaulttxt();
        }

        //Leert das Eingabe feld und ändert die Schrift farbe zu schwarz
        private void txt_Destination_Enter(object sender, EventArgs e)
        {
            setDefaulttxt();
        }

        //Falls das Eingabe Feld leer ist, wird darin der Hinweis in Grauer schrift angezeigt
        private void txt_Destination_Leave(object sender, EventArgs e)
        {
            setDefaulttxt();
        }
        //Füllt die ListBox mit Vorschläge
        private void txt_Departure_TextChanged(object sender, EventArgs e)
        {
            lbox_Departure.Items.Clear();
            Stations stations = Transport.GetStations(txt_Departure.Text);
            foreach (Station station in stations.StationList)
                {
                    lbox_Departure.Items.Add(station.Name);
                }
            if (txt_Departure.Text != "" && txt_Departure.Text != "Abfahrtsort" && lbox_Departure != null)
            {
                lbox_Departure.Visible = true;
            }
        }
        //Füllt die ListBox mit Vorschläge
        private void txt_Destination_TextChanged(object sender, EventArgs e)
        {
            lbox_Destination.Items.Clear();
            Stations stations = Transport.GetStations(txt_Destination.Text);
            foreach (Station station in stations.StationList)
                {
                    lbox_Destination.Items.Add(station.Name);
                    lbox_Destination.Visible = true;
                }
            if (txt_Destination.Text!=""&& txt_Destination.Text != "Ankunftsort"&&lbox_Destination!=null)
                {
                    lbox_Destination.Visible = true;
                }
        }
        private void lbox_Departure_DoubleClick(object sender, EventArgs e)
        {
            txt_Departure.Text = Convert.ToString(lbox_Departure.SelectedItem);
            hideListbox();
        }

        private void lbox_Destination_DoubleClick(object sender, EventArgs e)
        {
            txt_Destination.Text = Convert.ToString(lbox_Destination.SelectedItem);
            hideListbox();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            hideListbox();
        }
        //Methoden
        void setDefaulttxt()
        {
            if (txt_Departure.Focused)
            {
                hideListbox();
                txt_Departure.Clear();
                txt_Departure.ForeColor = Color.Black;
                txt_Departure.Clear();
            }
            else
            {
                if (txt_Departure.Text == "" || txt_Departure.Text == " ")
                {
                    hideListbox();
                    txt_Departure.ForeColor = Color.Gray;
                    txt_Departure.Text = "Abfahrtsort";
                }
            }
            if (txt_Destination.Focused)
            {
                hideListbox();
                txt_Destination.Clear();
                txt_Destination.ForeColor = Color.Black;
                txt_Destination.Clear();
            }
            else
            {
                if (txt_Destination.Text == "" || txt_Destination.Text == " ")
                {
                    hideListbox();
                    txt_Destination.ForeColor = Color.Gray;
                    txt_Destination.Text = "Ankunftsort";
                }
            }
        }
        private void hideListbox()
        {
            lbox_Departure.Visible = false;
            lbox_Destination.Visible = false;
        }
        private void createPlan()
        {
            //DataTable erstellen
            DataTable dt_Connections = new DataTable();
            dt_Connections.Columns.Add("Abfahrtszeit");
            dt_Connections.Columns.Add("AbfahrtsOrt");
            dt_Connections.Columns.Add("Zielort");
            dt_Connections.Columns.Add("Zielzeit");

            //Verbindungen auslesen
            Connections stb = Transport.GetConnections(txt_Departure.Text, txt_Destination.Text);
            
            //Verbindungen in DataTAble speichern
            foreach (Connection station in stb.ConnectionList)
            {
                dt_Connections.Rows.Add(ConvertDateToTime(station.From.Departure), station.From.Station.Name, station.To.Station.Name,
                    ConvertDateToTime(station.To.Arrival));
            }
            //DatatAble in DataGrdid hinzufühen
            dtg_Plan.DataSource = dt_Connections;
        }
        private string ConvertDateToTime(string dateTime_str)
        {
            //Time zum zurück geben
            string time = string.Empty;

            //DateTime parsen
            DateTime dateTime;
            DateTime.TryParse(dateTime_str, out dateTime);

            //Nur Zeit zum string
            time = dateTime.ToString("HH:mm");

            //Zeit zurück geben
            return time;
        }
        private void createTable(TextBox txt_Departure)
        {
            string stationDepartureName;
            string stationId;
            Stations st_Departure = Transport.GetStations(txt_Departure.Text);

            //DataTable erstellen
            DataTable dt_DepartureBoard = new DataTable();
            dt_DepartureBoard.Columns.Add("Abfahrtzeit");
            dt_DepartureBoard.Columns.Add("Abfahrtsort");
            dt_DepartureBoard.Columns.Add("Zielort");

           
            stationId = st_Departure.StationList[0].Id;
            StationBoardRoot stbRoot = Transport.GetStationBoard(txt_Departure.Text, stationId);

            foreach (StationBoard s in stbRoot.Entries)
            {
                //StationBoard in Datatable speichern
                dt_DepartureBoard.Rows.Add(s.Stop.Departure, s.Name, s.To);
            }

            dtg_Table.DataSource = dt_DepartureBoard;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txt_Departure.Select();
        }
    }
}
