using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Multi_Ping_Tester
{
    public partial class frmPingSetting : Form
    {
        public frmPingSetting()
        {
            InitializeComponent();
        }

        private void frmPingSetting_Load(object sender, EventArgs e)
        {
            txtInterval.Text = frmMain.settings.getInterval().ToString();
            txtTimeout.Text = frmMain.settings.getTimeout().ToString();
            txtPayload.Text = frmMain.settings.getPayload().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain.settings.setInterval(int.Parse(txtInterval.Text));
            frmMain.settings.setTimeout(int.Parse(txtTimeout.Text));
            frmMain.settings.setPayload(int.Parse(txtPayload.Text));

            StreamWriter s = new StreamWriter(Environment.GetEnvironmentVariable("LocalAppData") + "\\Multi Ping\\settings.ini", false);

            s.WriteLine("interval={0}", frmMain.settings.getInterval());
            s.WriteLine("timeout={0}", frmMain.settings.getTimeout());
            s.WriteLine("payload={0}", frmMain.settings.getPayload());
            s.WriteLine("sound={0}", frmMain.settings.getSound());
            s.WriteLine("isalarm={0}", frmMain.settings.getAlarm());

            s.Close();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
