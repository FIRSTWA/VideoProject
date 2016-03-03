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
        private string GETMatchSchedule(string level, string regional)
        {

            string sURL;
            sURL = "https://frc-api.firstinspires.org/v2.0/2016/schedule/scmb/qual/hybrid";
            //sURL = "https://frc-api.firstinspires.org/v2.0/2016/schedule/" + regional + "/" + level + "/hybrid";
            //sURL = "https://private-anon-bebf16478-frcevents2.apiary-mock.com/v2.0/2016/schedule/" + regional + "/" + level + "/hybrid";
            //return sURL;
            //sURL = "https://frc-api.firstinspires.org/v2.0/2016/events?districtCode=PNW";
            //sURL = "https://frc-api.firstinspires.org/v2.0/2016/matches/SCMB?tournamentLevel=qual&matchNumber=6";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);

            //wrGETURL.Headers.Add(HttpRequestHeader.Accept, "application/json");
            wrGETURL.Headers.Add("Authorization", "Basic XXXX");

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
            decimal[] values = { 123m, new decimal(123000, 0, 0, false, 3),
                           123.999m, 4294967295.999m, 4294967296m,
                           4294967296m, 2147483647.999m, 2147483648m,
                           -0.999m, -1m, -2147483648.999m, -2147483649m };

            string schedule = GETMatchSchedule("qual", "SCMB");
            int MatchNumber = 1;
            MatchNumber = (int)Match.Value;
            JToken match = GetMatchFromSchedule(schedule, MatchNumber);
            Clipboard.SetText(schedule);
            richTextBox1.Text = match.ToString();
        }

        private void Match_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
