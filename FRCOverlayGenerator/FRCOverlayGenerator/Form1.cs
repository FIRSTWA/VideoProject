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

namespace FRCOverlayGenerator
{
    public partial class FRCOverlayController : Form
    {
        private string GETMatchSchedule()
        {

            string sURL;
            sURL = "https://private-anon-bebf16478-frcevents2.apiary-mock.com/v2.0/2016/schedule/CMP/tournamentLevel/hybrid?";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);

            wrGETURL.Headers.Add("Authorization", "c2FtcGxldXNlcjo3ZWFhNjMzOC1hMDk3LTQyMjEtYWMwNC1iNjEyMGZjYzRkNDk=");

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();


            StreamReader objReader = new StreamReader(objStream);

            string XML = "";
            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    //DrawStrings(sLine,0,0);
                    //richTextBox1.Text = sLine;
                    if (XML != "")
                    {
                        XML = XML + "\n" + sLine;
                    }
                    else
                    {
                        XML = XML + sLine;
                    }
            }
            return XML;
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

        }
    }
}
