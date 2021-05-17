namespace Multi_Ping_Tester
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrBanner = new System.Windows.Forms.Timer(this.components);
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPingSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotifySetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tstMain = new System.Windows.Forms.ToolStrip();
            this.tbtSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtAdd = new System.Windows.Forms.ToolStripButton();
            this.tbtRemove = new System.Windows.Forms.ToolStripButton();
            this.tbtStart = new System.Windows.Forms.ToolStripButton();
            this.tbtSvchk = new System.Windows.Forms.ToolStripButton();
            this.tbtStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtClearList = new System.Windows.Forms.ToolStripButton();
            this.tbtClearLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtPingSetting = new System.Windows.Forms.ToolStripButton();
            this.tbtNotifySetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtAbout = new System.Windows.Forms.ToolStripButton();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dlgSaveLog = new System.Windows.Forms.SaveFileDialog();
            this.elhMain = new System.Windows.Forms.Integration.ElementHost();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lvwLog = new System.Windows.Forms.ListView();
            this.chdTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwIPList = new System.Windows.Forms.ListView();
            this.chdIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdRTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdRTT2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdRTT3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdRTT4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdRTT5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dlgSaveResult = new System.Windows.Forms.SaveFileDialog();
            this.mstMain.SuspendLayout();
            this.tstMain.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Location = new System.Drawing.Point(12, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(457, 51);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Multi Ping Tester v0.1";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrBanner
            // 
            this.tmrBanner.Tick += new System.EventHandler(this.tmrBanner_Tick);
            // 
            // mstMain
            // 
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSetting,
            this.mnuHelp});
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(481, 24);
            this.mstMain.TabIndex = 8;
            this.mstMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(57, 20);
            this.mnuFile.Text = "파일(&F)";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(139, 22);
            this.mnuSave.Text = "로그 저장(&S)";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(139, 22);
            this.mnuExit.Text = "나가기(&X)";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPingSetting,
            this.mnuNotifySetting});
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(59, 20);
            this.mnuSetting.Text = "설정(&C)";
            // 
            // mnuPingSetting
            // 
            this.mnuPingSetting.Name = "mnuPingSetting";
            this.mnuPingSetting.Size = new System.Drawing.Size(122, 22);
            this.mnuPingSetting.Text = "Ping설정";
            this.mnuPingSetting.Click += new System.EventHandler(this.mnuPingSetting_Click);
            // 
            // mnuNotifySetting
            // 
            this.mnuNotifySetting.Name = "mnuNotifySetting";
            this.mnuNotifySetting.Size = new System.Drawing.Size(122, 22);
            this.mnuNotifySetting.Text = "알림설정";
            this.mnuNotifySetting.Click += new System.EventHandler(this.mnuNotifySetting_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(72, 20);
            this.mnuHelp.Text = "도움말(&H)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(119, 22);
            this.mnuAbout.Text = "대하여...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tstMain
            // 
            this.tstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtSave,
            this.toolStripSeparator1,
            this.tbtAdd,
            this.tbtRemove,
            this.tbtStart,
            this.tbtSvchk,
            this.tbtStop,
            this.toolStripSeparator4,
            this.tbtClearList,
            this.tbtClearLog,
            this.toolStripSeparator2,
            this.tbtPingSetting,
            this.tbtNotifySetting,
            this.toolStripSeparator3,
            this.tbtAbout});
            this.tstMain.Location = new System.Drawing.Point(0, 24);
            this.tstMain.Name = "tstMain";
            this.tstMain.Size = new System.Drawing.Size(481, 25);
            this.tstMain.TabIndex = 9;
            this.tstMain.Text = "toolStrip1";
            // 
            // tbtSave
            // 
            this.tbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtSave.Image")));
            this.tbtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtSave.Name = "tbtSave";
            this.tbtSave.Size = new System.Drawing.Size(23, 22);
            this.tbtSave.Text = "로그 저장(&S)";
            this.tbtSave.Click += new System.EventHandler(this.tbtSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtAdd
            // 
            this.tbtAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtAdd.Image")));
            this.tbtAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtAdd.Name = "tbtAdd";
            this.tbtAdd.Size = new System.Drawing.Size(23, 22);
            this.tbtAdd.Text = "호스트 추가";
            this.tbtAdd.Click += new System.EventHandler(this.tbtAdd_Click);
            // 
            // tbtRemove
            // 
            this.tbtRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtRemove.Enabled = false;
            this.tbtRemove.Image = global::Multi_Ping_Tester.Properties.Resources.icoRemove;
            this.tbtRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtRemove.Name = "tbtRemove";
            this.tbtRemove.Size = new System.Drawing.Size(23, 22);
            this.tbtRemove.Text = "호스트 삭제";
            this.tbtRemove.Click += new System.EventHandler(this.tbtRemove_Click);
            // 
            // tbtStart
            // 
            this.tbtStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtStart.Image = global::Multi_Ping_Tester.Properties.Resources.icoStart;
            this.tbtStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtStart.Name = "tbtStart";
            this.tbtStart.Size = new System.Drawing.Size(23, 22);
            this.tbtStart.Text = "Ping시작";
            this.tbtStart.Click += new System.EventHandler(this.tbtStart_Click);
            // 
            // tbtSvchk
            // 
            this.tbtSvchk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtSvchk.Image = global::Multi_Ping_Tester.Properties.Resources.icoChk;
            this.tbtSvchk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtSvchk.Name = "tbtSvchk";
            this.tbtSvchk.Size = new System.Drawing.Size(23, 22);
            this.tbtSvchk.Text = "서비스체크";
            this.tbtSvchk.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbtStop
            // 
            this.tbtStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtStop.Enabled = false;
            this.tbtStop.Image = global::Multi_Ping_Tester.Properties.Resources.icoStop;
            this.tbtStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtStop.Name = "tbtStop";
            this.tbtStop.Size = new System.Drawing.Size(23, 22);
            this.tbtStop.Text = "Ping정지";
            this.tbtStop.Click += new System.EventHandler(this.tbtStop_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtClearList
            // 
            this.tbtClearList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtClearList.Image = global::Multi_Ping_Tester.Properties.Resources.icoClear;
            this.tbtClearList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtClearList.Name = "tbtClearList";
            this.tbtClearList.Size = new System.Drawing.Size(23, 22);
            this.tbtClearList.Text = "Ping 목록 삭제";
            this.tbtClearList.Click += new System.EventHandler(this.tbtClearList_Click);
            // 
            // tbtClearLog
            // 
            this.tbtClearLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtClearLog.Image = global::Multi_Ping_Tester.Properties.Resources.icoClearLog;
            this.tbtClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtClearLog.Name = "tbtClearLog";
            this.tbtClearLog.Size = new System.Drawing.Size(23, 22);
            this.tbtClearLog.Text = "Log 삭제";
            this.tbtClearLog.Click += new System.EventHandler(this.tbtClearLog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtPingSetting
            // 
            this.tbtPingSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtPingSetting.Image = global::Multi_Ping_Tester.Properties.Resources.icoPingSetting;
            this.tbtPingSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtPingSetting.Name = "tbtPingSetting";
            this.tbtPingSetting.Size = new System.Drawing.Size(23, 22);
            this.tbtPingSetting.Text = "Ping설정";
            this.tbtPingSetting.Click += new System.EventHandler(this.tbtPingSetting_Click);
            // 
            // tbtNotifySetting
            // 
            this.tbtNotifySetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtNotifySetting.Image = global::Multi_Ping_Tester.Properties.Resources.icoNotifySetting;
            this.tbtNotifySetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtNotifySetting.Name = "tbtNotifySetting";
            this.tbtNotifySetting.Size = new System.Drawing.Size(23, 22);
            this.tbtNotifySetting.Text = "알림설정";
            this.tbtNotifySetting.Click += new System.EventHandler(this.tbtNotifySetting_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtAbout
            // 
            this.tbtAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtAbout.Image = global::Multi_Ping_Tester.Properties.Resources.icoAbout;
            this.tbtAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtAbout.Name = "tbtAbout";
            this.tbtAbout.Size = new System.Drawing.Size(23, 22);
            this.tbtAbout.Text = "대하여...";
            this.tbtAbout.Click += new System.EventHandler(this.tbtAbout_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.txtNote);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.txtIP);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Location = new System.Drawing.Point(0, 51);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(481, 31);
            this.pnlAdd.TabIndex = 10;
            this.pnlAdd.Visible = false;
            this.pnlAdd.VisibleChanged += new System.EventHandler(this.pnlAdd_VisibleChanged);
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(207, 5);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(181, 21);
            this.txtNote.TabIndex = 9;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "설명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(34, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(132, 21);
            this.txtIP.TabIndex = 6;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(394, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dlgSaveLog
            // 
            this.dlgSaveLog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
            // 
            // elhMain
            // 
            this.elhMain.Location = new System.Drawing.Point(458, 0);
            this.elhMain.Name = "elhMain";
            this.elhMain.Size = new System.Drawing.Size(23, 21);
            this.elhMain.TabIndex = 11;
            this.elhMain.Text = "elementHost1";
            this.elhMain.Visible = false;
            this.elhMain.Child = null;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwLog);
            this.pnlMain.Controls.Add(this.lvwIPList);
            this.pnlMain.Location = new System.Drawing.Point(12, 105);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(457, 380);
            this.pnlMain.TabIndex = 12;
            // 
            // lvwLog
            // 
            this.lvwLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdTimestamp,
            this.chdMessage});
            this.lvwLog.FullRowSelect = true;
            this.lvwLog.GridLines = true;
            this.lvwLog.HideSelection = false;
            this.lvwLog.Location = new System.Drawing.Point(0, 293);
            this.lvwLog.Name = "lvwLog";
            this.lvwLog.Size = new System.Drawing.Size(457, 87);
            this.lvwLog.TabIndex = 8;
            this.lvwLog.UseCompatibleStateImageBehavior = false;
            this.lvwLog.View = System.Windows.Forms.View.Details;
            // 
            // chdTimestamp
            // 
            this.chdTimestamp.Text = "Time";
            // 
            // chdMessage
            // 
            this.chdMessage.Text = "Message";
            // 
            // lvwIPList
            // 
            this.lvwIPList.CheckBoxes = true;
            this.lvwIPList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIP,
            this.chdNote,
            this.chdRTT,
            this.chdRTT2,
            this.chdRTT3,
            this.chdRTT4,
            this.chdRTT5});
            this.lvwIPList.FullRowSelect = true;
            this.lvwIPList.GridLines = true;
            this.lvwIPList.HideSelection = false;
            this.lvwIPList.Location = new System.Drawing.Point(0, 0);
            this.lvwIPList.MultiSelect = false;
            this.lvwIPList.Name = "lvwIPList";
            this.lvwIPList.Size = new System.Drawing.Size(457, 287);
            this.lvwIPList.TabIndex = 7;
            this.lvwIPList.UseCompatibleStateImageBehavior = false;
            this.lvwIPList.View = System.Windows.Forms.View.Details;
            this.lvwIPList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwIPList_ItemChecked);
            this.lvwIPList.DoubleClick += new System.EventHandler(this.lvwIPList_DoubleClick);
            // 
            // chdIP
            // 
            this.chdIP.Text = "IP";
            this.chdIP.Width = 76;
            // 
            // chdNote
            // 
            this.chdNote.Text = "설명";
            // 
            // chdRTT
            // 
            this.chdRTT.Text = "RTT";
            this.chdRTT.Width = 81;
            // 
            // chdRTT2
            // 
            this.chdRTT2.Text = "RTT#2";
            this.chdRTT2.Width = 0;
            // 
            // chdRTT3
            // 
            this.chdRTT3.Text = "RTT#3";
            this.chdRTT3.Width = 0;
            // 
            // chdRTT4
            // 
            this.chdRTT4.Text = "RTT#4";
            this.chdRTT4.Width = 0;
            // 
            // chdRTT5
            // 
            this.chdRTT5.Text = "RTT#5";
            this.chdRTT5.Width = 0;
            // 
            // dlgSaveResult
            // 
            this.dlgSaveResult.Filter = "XLSX 파일(*.xlsx)|*.xlsx|모든 파일|*.*";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(481, 497);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.elhMain);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.tstMain);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.mstMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Multi Ping Tester v0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            this.tstMain.ResumeLayout(false);
            this.tstMain.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrBanner;
        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStrip tstMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuPingSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuNotifySetting;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripButton tbtSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtAdd;
        private System.Windows.Forms.ToolStripButton tbtStart;
        private System.Windows.Forms.ToolStripButton tbtStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtPingSetting;
        private System.Windows.Forms.ToolStripButton tbtNotifySetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtAbout;
        private System.Windows.Forms.ToolStripButton tbtRemove;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog dlgSaveLog;
        private System.Windows.Forms.Integration.ElementHost elhMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView lvwLog;
        private System.Windows.Forms.ColumnHeader chdTimestamp;
        private System.Windows.Forms.ColumnHeader chdMessage;
        private System.Windows.Forms.ListView lvwIPList;
        private System.Windows.Forms.ColumnHeader chdIP;
        private System.Windows.Forms.ColumnHeader chdNote;
        private System.Windows.Forms.ColumnHeader chdRTT;
        private System.Windows.Forms.ToolStripButton tbtSvchk;
        private System.Windows.Forms.ColumnHeader chdRTT2;
        private System.Windows.Forms.ColumnHeader chdRTT3;
        private System.Windows.Forms.ColumnHeader chdRTT4;
        private System.Windows.Forms.ColumnHeader chdRTT5;
        private System.Windows.Forms.SaveFileDialog dlgSaveResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtClearList;
        private System.Windows.Forms.ToolStripButton tbtClearLog;
    }
}

