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
    public partial class frmNotifySetting : Form
    {
        public frmNotifySetting()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpensound.ShowDialog();
        }

        private void dlgOpensound_FileOk(object sender, CancelEventArgs e)
        {
            txtPath.Text = dlgOpensound.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNotifySetting_Load(object sender, EventArgs e)
        {
            chkSound.Checked = frmMain.settings.getAlarm();
            txtPath.Text = frmMain.settings.getSound();

            if (chkSound.Checked == false)
            {
                btnOpen.Enabled = false;
            }
        }

        private void chkSound_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSound.Checked == false)
            {
                btnOpen.Enabled = false;
            }
            else
            {
                btnOpen.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkSound.Checked == true && txtPath.Text == "")
            {
                MessageBox.Show("사운드 알림 설정 시 재생할 파일을 지정하여야 합니다.", "Multi Ping Tester", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmMain.settings.setAlarm(chkSound.Checked);
                frmMain.settings.setSound(txtPath.Text);

                StreamWriter s = new StreamWriter(Environment.GetEnvironmentVariable("LocalAppData") + "\\Multi Ping\\settings.ini", false);

                s.WriteLine("interval={0}", frmMain.settings.getInterval());
                s.WriteLine("timeout={0}", frmMain.settings.getTimeout());
                s.WriteLine("payload={0}", frmMain.settings.getPayload());
                s.WriteLine("sound={0}", frmMain.settings.getSound());
                s.WriteLine("isalarm={0}", frmMain.settings.getAlarm());

                s.Close();
                this.Close();
            }

        }
    }
}
