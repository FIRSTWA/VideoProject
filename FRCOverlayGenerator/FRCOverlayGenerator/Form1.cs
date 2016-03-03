using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FRCOverlayGenerator
{
    public partial class FRCOverlayController : Form
    {
        public string SCHED = "";
        private string GETMatchSchedule(string level, string regional)
        {

            string sURL;
            sURL = "https://frc-api.firstinspires.org/v2.0/2016/schedule/" + regional + "/" + level + "/hybrid";
            //sURL = "https://frc-api.firstinspires.org/v2.0/2016/schedule/" + regional + "/" + level + "/hybrid";
            //sURL = "https://private-anon-bebf16478-frcevents2.apiary-mock.com/v2.0/2016/schedule/" + regional + "/" + level + "/hybrid";
            //return sURL;
            //sURL = "https://frc-api.firstinspires.org/v2.0/2016/events?districtCode=PNW";
            //sURL = "https://frc-api.firstinspires.org/v2.0/2016/matches/SCMB?tournamentLevel=qual&matchNumber=6";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);

            //wrGETURL.Headers.Add(HttpRequestHeader.Accept, "application/json");
            wrGETURL.Headers.Add("Authorization", "Basic XXXXX");

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);

            string JSON = "";
            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    //DrawStrings(sLine,0,0);
                    //richTextBox1.Text = sLine;

                        JSON = sLine;
            }
            return JSON;
        }

        private JToken GetMatchFromSchedule(string JSON, int match)
        {
            match = match - 1;
            JObject schedule = JObject.Parse(JSON);
            return schedule["Schedule"][match];//.SelectToken("schedule").ToString();//["description"].ToString();//["description"].ToString();

            /*
            using (XmlReader reader = XmlReader.Create(new StringReader(JSON)))
            {

                reader.ReadToFollowing("matchNumber");
                richTextBox1.Text = "2222";
                matchnumber = reader.ReadElementContentAsString();
                //matchnumber = matchnumber + matchnumber;
                return matchnumber;
            }
            */
        }

        private void DrawStrings(string draw, float x1, float y1)
        {
            string drawString = draw;
            float x = x1;
            float y = y1;
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 8);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }

        public FRCOverlayController()
        {
            InitializeComponent();
        }

        private void FRCOverlayController_Load(object sender, EventArgs e)
        {
            /*
            string schedule = GETMatchSchedule("qual","SCMB");
            JToken match = GetMatchFromSchedule(schedule, 1);
            Clipboard.SetText(schedule);
            richTextBox1.Text = schedule;
            */

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetMatch_Click(object sender, EventArgs e)
        {
            if (SCHED=="")
            {
                //SCHED = GETMatchSchedule(Level.SelectedItem.ToString(), Regional.Text);
            }
            int MatchNumber = 1;
            MatchNumber = (int)Match.Value;
            JToken match = GetMatchFromSchedule(SCHED, MatchNumber);
            Clipboard.SetText(match.ToString());
            richTextBox1.Text = match["Teams"][1]["teamNumber"].ToString();
            DrawStrings(match["Teams"][1]["teamNumber"].ToString(), 325, 100);
            DrawStrings(match["Teams"][1]["station"].ToString(), 325, 125);
            DrawStrings(match["Teams"][1]["surrogate"].ToString(), 325, 150);
            DrawStrings(match["Teams"][1]["dq"].ToString(), 325, 175);
            DrawStrings(match["scoreRedFinal"].ToString(), 325, 200);
        }


        private void Match_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Regional_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SCHED = GETMatchSchedule(Level.SelectedItem.ToString(), Regional.Text);
        }
    }
}
