﻿using System;
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
        private int TwoArrowsCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //Events
        private void btn_Search_Click(object sender, EventArgs e)
        {
            hideListbox();
            if (txt_Departure.Text != "Abfahrtsort" && txt_Destination.Text != "Ankunftsort" && txt_Departure.Text != "" && txt_Destination.Text != "")
            {
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
            if (txt_Destination.Text != "" && txt_Destination.Text != "Ankunftsort")
            {
                lbox_Destination.Items.Clear();
                Stations stations = Transport.GetStations(txt_Destination.Text);
                foreach (Station station in stations.StationList)
                {
                    lbox_Destination.Items.Add(station.Name);
                    lbox_Destination.Visible = true;
                }
                if (txt_Destination.Text != "" && txt_Destination.Text != "Ankunftsort" && lbox_Destination != null &&
                    TwoArrowsCounter == 0)
                {
                    lbox_Destination.Visible = true;
                }
                else
                {
                    TwoArrowsCounter = 0;
                }
            }
        }
        private void lbox_Departure_DoubleClick(object sender, EventArgs e)
        {
            txt_Departure.ForeColor = Color.Black;
            txt_Departure.Text = Convert.ToString(lbox_Departure.SelectedItem);
            hideListbox();
        }

        private void lbox_Destination_DoubleClick(object sender, EventArgs e)
        {
            txt_Departure.ForeColor = Color.Black;
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
            dt_Connections.Columns.Add("AbfahrtsOrt");
            dt_Connections.Columns.Add("Zielort");
            dt_Connections.Columns.Add("Abfahrtszeit");
            dt_Connections.Columns.Add("Zielzeit");
            dt_Connections.Columns.Add("Reisedauer");
            
            
            //Verbindungen auslesen
            Connections stb = Transport.GetConnections(txt_Departure.Text, txt_Destination.Text);
            
            //Verbindungen in DataTAble speichern
            
            foreach (Connection station in stb.ConnectionList)//.Where((ConvertTimetoInt((ConvertDateToTime(station.From.Departure))) >= Convertdtp_TimetointTime(""))))
            {
                if (((ConvertTimetoInt((ConvertDateToTime(station.From.Departure))) >= Convertdtp_TimetointTime(""))))
                    {
                        dt_Connections.Rows.Add(station.From.Station.Name, station.To.Station.Name,
                        ConvertDateToTime(station.From.Departure), ConvertDateToTime(station.To.Arrival),TimeShortener(station.Duration));
                        CreateGmap(Convert.ToString(station.From.Station.Coordinate.XCoordinate), Convert.ToString(station.From.Station.Coordinate.YCoordinate));
                }
               
            }

            //DatatAble in DataGrdid hinzufühen
            dtg_Plan.DataSource = dt_Connections;
        }

        private void createTable(TextBox txt_Departure)
        {
            string stationId;
            Stations st_Departure = Transport.GetStations(txt_Departure.Text);

            //DataTable erstellen
            DataTable dt_DepartureBoard = new DataTable();
            dt_DepartureBoard.Columns.Add("Abfahrtzeit");
            dt_DepartureBoard.Columns.Add("Zielort");
            dt_DepartureBoard.Columns.Add("Abfahrtsort");

            stationId = st_Departure.StationList[0].Id;
            StationBoardRoot stbRoot = Transport.GetStationBoard(txt_Departure.Text, stationId);

            foreach (StationBoard s_Board in stbRoot.Entries)
            {
                //StationBoard in Datatable speichern
                dt_DepartureBoard.Rows.Add(ConvertDateToTime(Convert.ToString(s_Board.Stop.Departure)), s_Board.To, s_Board.Name);
            }

            dtg_Table.DataSource = dt_DepartureBoard;
        }
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

        private int ConvertTimetoInt(string string_Time)
        {
            int int_Time=0;
            string_Time=string_Time.Replace(":","");
            int_Time = Convert.ToInt32(string_Time);
            return int_Time;

        }
        //formatiert die anzeige Zeit des Timepickers zu einem int
        private int Convertdtp_TimetointTime(string string_Time)
        {
            int int_Time;
            string dtp_time = Convert.ToString(this.dtp_Time.Value.Hour) + Convert.ToString(this.dtp_Time.Value.Minute);
            int_Time = Convert.ToInt32(dtp_time);
            return int_Time;
        }
        //Ergänzt die Zeit mit "h" und "m"
        private string TimeShortener(string longTime)
        {
            string shortTime = longTime.Remove(0, 3);
            shortTime = shortTime.Remove(shortTime.Length - 3);
            shortTime = shortTime.Replace(":", " h ");
            shortTime = "" + shortTime + " m";
            return shortTime;
        }

        private string CreateGmap(string x, string y)
        {
            web_Gmap.Visible = true;
            string xy="https://www.google.ch/maps/place/"  + x + ", " + y;
            web_Gmap.Navigate(""+xy);
            return "";
        }
        //Vertausch die beiden Textboxen miteinander
        private void pb_TwoArrows_Click(object sender, EventArgs e)
        {
            hideListbox();
            if (txt_Departure.Text!= "Abfahrtsort"||txt_Destination.Text!= "Ankunftsort")
            {
                TwoArrowsCounter = 1;
                txt_Destination.ForeColor = Color.Black;
                txt_Departure.ForeColor = Color.Black;
                string oldtxt_Departure = txt_Departure.Text;
                string oldtxt_Destination = txt_Destination.Text;
                txt_Departure.Text = oldtxt_Destination;
                txt_Destination.Text = oldtxt_Departure;
                hideListbox();
            }
        }

        private void txt_Departure_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbox_Departure.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (lbox_Departure.SelectedIndex != lbox_Departure.Items.Count-1)
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
                    txt_Departure.Text = lbox_Departure.SelectedItem.ToString();
                    hideListbox();
                }
            }
        }
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
                    txt_Departure.Text = lbox_Destination.SelectedItem.ToString();
                    hideListbox();
                }
            }
        }
    }
}
