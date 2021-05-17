using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;


namespace Multi_Ping_Tester
{
    public partial class frmMain : Form
    {
        List<Thread> pingThreads = new List<Thread>();
        List<Boolean> pingStatus = new List<bool>();
        int lastidx = -1; //Log List Index
        public static SettingData settings = new SettingData();
        System.Windows.Media.MediaPlayer player = new System.Windows.Media.MediaPlayer();
        bool ischk = false;
        bool isadd = true;
        int itercnt = 0;

        private void doPing(object args)
        {
            Ping pingsender = new Ping();
            PingReply pingres;

            int idx = int.Parse(((List<string>)args)[0]);
            string addr = ((List<string>)args)[1];
            int interval = int.Parse(((List<string>)args)[2]);
            int timeout = int.Parse(((List<string>)args)[3]);

            int downcount = 0;
            string timestamp = DateTime.Now.ToString();

            byte[] payload = new byte[settings.getPayload()];

            for (int i = 0; i < payload.Length; i++)
                payload[i] = byte.MaxValue;

            do
            {
                try
                {
                    pingres = pingsender.Send(addr, settings.getTimeout(), payload);
                }
                catch (Exception)
                {
                    break;
                }


                this.Invoke(new MethodInvoker(delegate()
                {
                    lvwIPList.Items[idx].SubItems[3].Text = "";
                    lvwIPList.Items[idx].SubItems[4].Text = "";
                    lvwIPList.Items[idx].SubItems[5].Text = "";
                    lvwIPList.Items[idx].SubItems[6].Text = "";

                    if (pingres.Status == IPStatus.Success)
                    {
                        lvwIPList.Items[idx].SubItems[2].Text = pingres.RoundtripTime.ToString() + "ms";
                        lvwIPList.Items[idx].BackColor = Color.LightGreen;
                        pingStatus[idx] = true;

                        if (downcount > 5)
                        {
                            lvwLog.Items.Add(timestamp);
                            lastidx++;
                            lvwLog.Items[lastidx].SubItems.Add(addr + " is going up");
                        }

                        downcount = 0;
                    }
                    else
                    {
                        lvwIPList.Items[idx].SubItems[2].Text = "Down";
                        lvwIPList.Items[idx].BackColor = Color.LightPink;
                        pingStatus[idx] = false;

                        if (downcount == 6)
                        {
                            lvwLog.Items.Add(timestamp);
                            lastidx++;
                            lvwLog.Items[lastidx].SubItems.Add(addr + " is going down");

                            if (settings.getAlarm() == true)
                            {
                                player.Play();
                            }

                        }

                        downcount++;
                    }

                }));
                Thread.Sleep(interval * 1000);

            } while (true);
        }

        private void doCheck(object args)
        {
            Ping pingsender = new Ping();
            PingReply pingres;

            int idx = int.Parse(((List<string>)args)[0]);
            string addr = ((List<string>)args)[1];
            int interval = int.Parse(((List<string>)args)[2]);
            int timeout = int.Parse(((List<string>)args)[3]);
            int count = int.Parse(((List<string>)args)[4]);

            int downcount = 0;
            string timestamp = DateTime.Now.ToString();

            byte[] payload = new byte[settings.getPayload()];

            for (int i = 0; i < payload.Length; i++)
                payload[i] = byte.MaxValue;

            int current = 0;

            do
            {
                try
                {
                    pingres = pingsender.Send(addr, settings.getTimeout(), payload);
                }
                catch (Exception)
                {
                    break;
                }


                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (pingres.Status == IPStatus.Success)
                    {
                        lvwIPList.Items[idx].SubItems[2+current].Text = pingres.RoundtripTime.ToString() + "ms";
                        lvwIPList.Items[idx].BackColor = Color.LightGreen;
                        pingStatus[idx] = true;

                        if (downcount > 5)
                        {
                            lvwLog.Items.Add(timestamp);
                            lastidx++;
                            lvwLog.Items[lastidx].SubItems.Add(addr + " is going up");
                        }

                        downcount = 0;
                    }
                    else
                    {
                        lvwIPList.Items[idx].SubItems[2+current].Text = "Down";
                        lvwIPList.Items[idx].BackColor = Color.LightPink;
                        pingStatus[idx] = false;

                        if (downcount == 6)
                        {
                            lvwLog.Items.Add(timestamp);
                            lastidx++;
                            lvwLog.Items[lastidx].SubItems.Add(addr + " is going down");

                            if (settings.getAlarm() == true)
                            {
                                player.Play();
                            }

                        }

                        downcount++;
                    }

                }));
                Thread.Sleep(interval * 1000);

                current++;

            } while (current < count);
        }

        private void ResizeCol(int flag)
        {
            switch (flag)
            {
                case 0:
                    chdIP.Width = (int)((lvwIPList.Width - 6) * 0.3);
                    chdNote.Width = (int)((lvwIPList.Width - 6) * 0.5);
                    chdRTT.Width = (int)((lvwIPList.Width - 6) * 0.2);
                    chdRTT2.Width = 0;
                    chdRTT3.Width = 0;
                    chdRTT4.Width = 0;
                    chdRTT5.Width = 0;
                    break;
                case 1:
                    chdTimestamp.Width = (int)((lvwLog.Width - 6) * 0.3);
                    chdMessage.Width = (int)((lvwLog.Width - 6) * 0.7);
                    break;
                case 2:
                    chdNote.Width = (int)(lvwIPList.Width - 6 - chdIP.Width - chdRTT.Width);
                    chdMessage.Width = (int)(lvwLog.Width - 6 - chdTimestamp.Width);
                    break;
                case 3:
                    chdIP.Width = (int)((lvwIPList.Width - 6) * 0.3);
                    chdNote.Width = (int)((lvwIPList.Width - 6) * 0.2);
                    chdRTT.Width = (int)((lvwIPList.Width - 6) * 0.1);
                    chdRTT2.Width = (int)((lvwIPList.Width - 6) * 0.1);
                    chdRTT3.Width = (int)((lvwIPList.Width - 6) * 0.1);
                    chdRTT4.Width = (int)((lvwIPList.Width - 6) * 0.1);
                    chdRTT5.Width = (int)((lvwIPList.Width - 6) * 0.1);
                    break;
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ResizeCol(0);
            ResizeCol(1);

            lvwIPList.Height = (int)(pnlMain.Height * 0.8);
            lvwLog.Height = pnlMain.Height - (lvwIPList.Height + 6);

            lvwLog.Location = new Point(0, lvwIPList.Height + 6);

            if (File.Exists(Environment.GetEnvironmentVariable("LocalAppData") + "\\Multi Ping\\settings.ini"))
            {
                StreamReader s = new StreamReader(Environment.GetEnvironmentVariable("LocalAppData") + "\\Multi Ping\\settings.ini");

                settings.setInterval(int.Parse(s.ReadLine().Split('=')[1]));
                settings.setTimeout(int.Parse(s.ReadLine().Split('=')[1]));
                settings.setPayload(int.Parse(s.ReadLine().Split('=')[1]));
                settings.setSound(s.ReadLine().Split('=')[1]);
                settings.setAlarm(Boolean.Parse(s.ReadLine().Split('=')[1]));

                if (!(settings.getSound().Equals(string.Empty)) && !(File.Exists(settings.getSound()))) {
                    MessageBox.Show("Alarm 사운드 파일이 존재하지 않습니다!\r\n소리 알람이 비활성화 됩니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    settings.setAlarm(false);
                }

                s.Close();
            }
            else
            {
                System.IO.Directory.CreateDirectory(Environment.GetEnvironmentVariable("LocalAppData") + "\\Multi Ping");
                StreamWriter s = new StreamWriter(Environment.GetEnvironmentVariable("LocalAppData") + "\\Multi Ping\\settings.ini");

                settings.setInterval(5);
                settings.setTimeout(2000);
                settings.setPayload(32);
                settings.setSound(string.Empty);

                s.WriteLine("interval=5");
                s.WriteLine("timeout=2000");
                s.WriteLine("payload=32");
                s.WriteLine("sound=");
                s.WriteLine("isalarm=false");

                s.Close();
            }

            chdRTT2.Width = 0;
            chdRTT3.Width = 0;
            chdRTT4.Width = 0;
            chdRTT5.Width = 0;
        }

        private void tmrBanner_Tick(object sender, EventArgs e)
        {
            if (pingStatus.Contains(false))
            {
                lblStatus.BackColor = Color.Red;
                lblStatus.ForeColor = Color.White;
                lblStatus.Text = pingStatus.FindAll(delegate(Boolean b) { return b == false; }).Count.ToString() + " host(s) down!";
            }
            else
            {
                lblStatus.BackColor = Color.Green;
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = pingThreads.Count.ToString() + " host(s) alive!";
            }

            if (ischk)
            {
                int endcnt = 0;
                foreach (Thread t in pingThreads)
                {
                    if (!t.IsAlive)
                        endcnt++;
                }

                if (endcnt == pingThreads.Count) {
                    tbtStop_Click(sender, e);
                }
                else
                {
                    itercnt++;

                    lvwLog.Items.Add(DateTime.Now.ToString());
                    lastidx++;
                    lvwLog.Items[lastidx].SubItems.Add("Iteration : " + itercnt.ToString());
                }
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Multi Ping Tester v0.1\r\nkamome74@lgcns.com", "대하여...");
        }

        private void tbtAbout_Click(object sender, EventArgs e)
        {
            mnuAbout_Click(sender, e);
        }

        private void tbtAdd_Click(object sender, EventArgs e)
        {
            isadd = true;
            if (pnlAdd.Visible == false)
            {
                pnlAdd.Visible = true;
                txtIP.Enabled = true;
                txtNote.Enabled = true;
                btnAdd.Enabled = true;

            }
            else
            {
                pnlAdd.Visible = false;
                txtIP.Enabled = false;
                txtNote.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "")
            {
                MessageBox.Show("IP를 입력하십시오.", "Multi Ping Tester",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!isadd)
            {
                ListView.SelectedListViewItemCollection selectedIP = lvwIPList.SelectedItems;
                int idx = lvwIPList.Items.IndexOf(selectedIP[0]);

                lvwIPList.Items[idx].SubItems[0].Text = txtIP.Text;
                lvwIPList.Items[idx].SubItems[1].Text = txtNote.Text;
                txtIP.Text = "";
                txtNote.Text = "";
                txtIP.Enabled = false;
                txtNote.Enabled = false;
                btnAdd.Enabled = false;
                pnlAdd.Visible = false;
            }
            else
            {
                lvwIPList.Items.Add(txtIP.Text);
                lvwIPList.FindItemWithText(txtIP.Text).SubItems.Add(txtNote.Text);
                lvwIPList.FindItemWithText(txtIP.Text).SubItems.Add("");
                lvwIPList.FindItemWithText(txtIP.Text).SubItems.Add("");
                lvwIPList.FindItemWithText(txtIP.Text).SubItems.Add("");
                lvwIPList.FindItemWithText(txtIP.Text).SubItems.Add("");
                lvwIPList.FindItemWithText(txtIP.Text).SubItems.Add("");
                txtIP.Text = "";
                txtNote.Text = "";
                txtIP.Enabled = false;
                txtNote.Enabled = false;
                btnAdd.Enabled = false;
                pnlAdd.Visible = false;
            }
        }

        private void tbtStart_Click(object sender, EventArgs e)
        {
            if (lvwIPList.Items.Count == 0)
            {
                MessageBox.Show("IP 목록이 비어있습니다.", "Multi Ping Tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResizeCol(0);

                pingThreads.Clear();
                pingStatus.Clear();
                int idx = 0;

                string timestamp = DateTime.Now.ToString();

                lvwLog.Items.Add(timestamp);
                lastidx++;
                lvwLog.Items[lastidx].SubItems.Add("Ping Started");


                foreach (ListViewItem i in lvwIPList.Items)
                {
                    List<string> args = new List<string>();

                    pingThreads.Add(new Thread(new ParameterizedThreadStart(doPing)));
                    pingThreads[idx].IsBackground = true;
                    pingStatus.Add(true);

                    args.Add(idx.ToString());
                    args.Add(i.Text);
                    args.Add(settings.getInterval().ToString());
                    args.Add(settings.getTimeout().ToString());

                    pingThreads[idx].Start(args);
                    idx++;
                }

                ischk = false;
                tmrBanner.Interval = settings.getInterval() * 1000;
                tmrBanner.Start();
                tbtStart.Enabled = false;
                tbtSvchk.Enabled = false;
                tbtStop.Enabled = true;
                tbtAdd.Enabled = false;
            }

            if (settings.getSound() != "")
            {
                player.Open(new Uri(settings.getSound()));
            }

        }

        private void tbtStop_Click(object sender, EventArgs e)
        {
            foreach (Thread t in pingThreads)
            {
                try
                {
                    t.Abort();
                }
                catch (Exception)
                {

                }
            }
            pingThreads.Clear();
            pingStatus.Clear();

            string timestamp = DateTime.Now.ToString();

            lvwLog.Items.Add(timestamp);
            lastidx++;

            tmrBanner.Stop();

            lvwLog.Items[lastidx].SubItems.Add("Ping Stop");

            tbtStart.Enabled = true;
            tbtSvchk.Enabled = true;
            tbtStop.Enabled = false;
            tbtAdd.Enabled = true;

            player.Close();

            if(ischk)
            {

            }
        }

        private void lvwIPList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvwIPList.CheckedItems.Count == 0)
            {
                tbtRemove.Enabled = false;
            }
            else
            {
                tbtRemove.Enabled = true;
            }
        }

        private void tbtRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvwIPList.CheckedItems)
            {
                lvwIPList.Items.Remove(i);
            }

            tbtRemove.Enabled = false;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.Height < 535) this.Height = 535;
            if (this.Width < 497) this.Width = 497;

            pnlAdd.Width = this.Width;
            lblStatus.Width = this.Width - 40;
            lvwIPList.Width = lblStatus.Width;
            lvwLog.Width = lblStatus.Width;
            pnlMain.Width = lblStatus.Width;

            ResizeCol(2);

            if (chdRTT2.Width != 0)
                ResizeCol(3);
            else
                ResizeCol(0);

            pnlMain.Height = this.ClientSize.Height - mstMain.Height - tstMain.Height - lblStatus.Height - 20;
            lvwIPList.Height = (int)(pnlMain.Height * 0.8);
            lvwLog.Height = pnlMain.Height - (lvwIPList.Height + 6);

            lvwLog.Location = new Point(0, lvwIPList.Height + 6);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "Multi Ping Tester", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuPingSetting_Click(object sender, EventArgs e)
        {
            Form f = new frmPingSetting();
            f.ShowDialog();
        }

        private void tbtPingSetting_Click(object sender, EventArgs e)
        {
            mnuPingSetting_Click(sender, e);
        }

        private void mnuNotifySetting_Click(object sender, EventArgs e)
        {
            Form f = new frmNotifySetting();
            f.ShowDialog();
        }

        private void tbtNotifySetting_Click(object sender, EventArgs e)
        {
            mnuNotifySetting_Click(sender, e);
        }

        private void tbtSave_Click(object sender, EventArgs e)
        {
            mnuSave_Click(sender, e);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            dlgSaveLog.ShowDialog();

            if (dlgSaveLog.FileName != "")
            {
                
                StreamWriter logFile = new StreamWriter(dlgSaveLog.OpenFile());
                string logLine;

                foreach (ListViewItem i in lvwLog.Items)
                {
                    logLine = i.Text + " " + i.SubItems[1].Text;
                    logFile.WriteLine(logLine);
                }

                logFile.Close();
            }

        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (lvwIPList.Items.Count == 0)
            {
                MessageBox.Show("IP 목록이 비어있습니다.", "Multi Ping Tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResizeCol(3);

                pingThreads.Clear();
                pingStatus.Clear();
                int idx = 0;

                string timestamp = DateTime.Now.ToString();

                lvwLog.Items.Add(timestamp);
                lastidx++;
                lvwLog.Items[lastidx].SubItems.Add("Ping Started");


                foreach (ListViewItem i in lvwIPList.Items)
                {
                    List<string> args = new List<string>();

                    pingThreads.Add(new Thread(new ParameterizedThreadStart(doCheck)));
                    pingThreads[idx].IsBackground = true;
                    pingStatus.Add(true);

                    args.Add(idx.ToString());
                    args.Add(i.Text);
                    args.Add(settings.getInterval().ToString());
                    args.Add(settings.getTimeout().ToString());
                    args.Add("5");

                    pingThreads[idx].Start(args);
                    idx++;
                }

                ischk = true;
                itercnt = 0;
                tmrBanner.Interval = settings.getInterval() * 1000;
                tmrBanner.Start();
                tbtStart.Enabled = false;
                tbtSvchk.Enabled = false;
                tbtStop.Enabled = true;
                tbtAdd.Enabled = false;
            }
        }

        private void tbtClearList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ping 목록을 비우시겠습니까?", "Multi Ping Tester", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach(ListViewItem i in lvwIPList.Items)
                {
                    lvwIPList.Items.Remove(i);
                }
            }
        }

        private void tbtClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log 이력을 비우시겠습니까?", "Multi Ping Tester", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (ListViewItem i in lvwLog.Items)
                {
                    lvwLog.Items.Remove(i);
                }
                lastidx = -1;
            }
        }

        private void lvwIPList_DoubleClick(object sender, EventArgs e)
        {
            if (lvwIPList.Items.Count != 0)
            {
                ListView.SelectedListViewItemCollection selectedIP = lvwIPList.SelectedItems;
                string IP = selectedIP[0].SubItems[0].Text;
                string context = selectedIP[0].SubItems[1].Text;

                isadd = false;
                txtIP.Text = IP;
                txtNote.Text = context;
                pnlAdd.Visible = true;
            }
        }

        private void pnlAdd_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlAdd.Visible)
            {
                if (isadd)
                {
                    btnAdd.Text = "추가";
                }
                else
                {
                    btnAdd.Text = "수정";
                    txtIP.Enabled = true;
                    txtNote.Enabled = true;
                    btnAdd.Enabled = true;
                }
            }
        }
    }
}
