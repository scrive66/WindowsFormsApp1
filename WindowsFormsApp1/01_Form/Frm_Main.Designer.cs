namespace WindowsFormsApp1._01_Form
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsm_Process = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Password = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Single = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_EndSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rtb_Log = new System.Windows.Forms.RichTextBox();
            this.Lbl_DateTime = new System.Windows.Forms.Label();
            this.Lbl_State = new System.Windows.Forms.Label();
            this.Lbl_MachineName = new System.Windows.Forms.Label();
            this.Pnl_Ucls = new System.Windows.Forms.Panel();
            this.Ucl_SettingObj = new WindowsFormsApp1._04_Ucl_Other.Ucl_Setting();
            this.Ucl_ProcessObj = new WindowsFormsApp1._02_Ucl_Multi.Ucl_Process();
            this.Ucl_SingleObj = new WindowsFormsApp1._03_Ucl_Single.Ucl_Single();
            this.Tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_Ucls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Process,
            this.Tsm_Password,
            this.Tsm_Single,
            this.Tsm_Setting,
            this.Tsm_EndSoftware});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_Process
            // 
            this.Tsm_Process.Name = "Tsm_Process";
            this.Tsm_Process.Size = new System.Drawing.Size(43, 20);
            this.Tsm_Process.Text = "生産";
            this.Tsm_Process.Click += new System.EventHandler(this.Tsm_Process_Click);
            // 
            // Tsm_Password
            // 
            this.Tsm_Password.Name = "Tsm_Password";
            this.Tsm_Password.Size = new System.Drawing.Size(63, 20);
            this.Tsm_Password.Text = "パスワード";
            this.Tsm_Password.Click += new System.EventHandler(this.Tsm_Password_Click);
            // 
            // Tsm_Single
            // 
            this.Tsm_Single.Name = "Tsm_Single";
            this.Tsm_Single.Size = new System.Drawing.Size(43, 20);
            this.Tsm_Single.Text = "単動";
            this.Tsm_Single.Click += new System.EventHandler(this.Tsm_Single_Click);
            // 
            // Tsm_Setting
            // 
            this.Tsm_Setting.Name = "Tsm_Setting";
            this.Tsm_Setting.Size = new System.Drawing.Size(43, 20);
            this.Tsm_Setting.Text = "設定";
            this.Tsm_Setting.Visible = false;
            this.Tsm_Setting.Click += new System.EventHandler(this.Tsm_Setting_Click);
            // 
            // Tsm_EndSoftware
            // 
            this.Tsm_EndSoftware.Name = "Tsm_EndSoftware";
            this.Tsm_EndSoftware.Size = new System.Drawing.Size(43, 20);
            this.Tsm_EndSoftware.Text = "終了";
            this.Tsm_EndSoftware.Click += new System.EventHandler(this.Tsm_EndSoftware_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Rtb_Log);
            this.panel1.Controls.Add(this.Lbl_DateTime);
            this.panel1.Controls.Add(this.Lbl_State);
            this.panel1.Controls.Add(this.Lbl_MachineName);
            this.panel1.Location = new System.Drawing.Point(610, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 488);
            this.panel1.TabIndex = 1;
            // 
            // Rtb_Log
            // 
            this.Rtb_Log.Location = new System.Drawing.Point(0, 79);
            this.Rtb_Log.Name = "Rtb_Log";
            this.Rtb_Log.ReadOnly = true;
            this.Rtb_Log.Size = new System.Drawing.Size(200, 231);
            this.Rtb_Log.TabIndex = 1;
            this.Rtb_Log.Text = "";
            // 
            // Lbl_DateTime
            // 
            this.Lbl_DateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_DateTime.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_DateTime.Location = new System.Drawing.Point(0, 313);
            this.Lbl_DateTime.Name = "Lbl_DateTime";
            this.Lbl_DateTime.Size = new System.Drawing.Size(200, 60);
            this.Lbl_DateTime.TabIndex = 0;
            this.Lbl_DateTime.Text = "2020/08/02\r\n12:34:56";
            this.Lbl_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_State
            // 
            this.Lbl_State.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_State.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_State.Location = new System.Drawing.Point(0, 38);
            this.Lbl_State.Name = "Lbl_State";
            this.Lbl_State.Size = new System.Drawing.Size(200, 38);
            this.Lbl_State.TabIndex = 0;
            this.Lbl_State.Text = "状態遷移";
            this.Lbl_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_MachineName
            // 
            this.Lbl_MachineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_MachineName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_MachineName.Location = new System.Drawing.Point(0, 0);
            this.Lbl_MachineName.Name = "Lbl_MachineName";
            this.Lbl_MachineName.Size = new System.Drawing.Size(200, 38);
            this.Lbl_MachineName.TabIndex = 0;
            this.Lbl_MachineName.Text = "設備名";
            this.Lbl_MachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Ucls
            // 
            this.Pnl_Ucls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Ucls.Controls.Add(this.Ucl_SettingObj);
            this.Pnl_Ucls.Controls.Add(this.Ucl_ProcessObj);
            this.Pnl_Ucls.Controls.Add(this.Ucl_SingleObj);
            this.Pnl_Ucls.Location = new System.Drawing.Point(0, 27);
            this.Pnl_Ucls.Name = "Pnl_Ucls";
            this.Pnl_Ucls.Size = new System.Drawing.Size(604, 488);
            this.Pnl_Ucls.TabIndex = 2;
            // 
            // Ucl_SettingObj
            // 
            this.Ucl_SettingObj.Location = new System.Drawing.Point(194, 180);
            this.Ucl_SettingObj.Name = "Ucl_SettingObj";
            this.Ucl_SettingObj.Size = new System.Drawing.Size(226, 68);
            this.Ucl_SettingObj.TabIndex = 2;
            // 
            // Ucl_ProcessObj
            // 
            this.Ucl_ProcessObj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ucl_ProcessObj.Location = new System.Drawing.Point(12, 17);
            this.Ucl_ProcessObj.Name = "Ucl_ProcessObj";
            this.Ucl_ProcessObj.Size = new System.Drawing.Size(184, 76);
            this.Ucl_ProcessObj.TabIndex = 0;
            // 
            // Ucl_SingleObj
            // 
            this.Ucl_SingleObj.Location = new System.Drawing.Point(103, 99);
            this.Ucl_SingleObj.Name = "Ucl_SingleObj";
            this.Ucl_SingleObj.Size = new System.Drawing.Size(214, 75);
            this.Ucl_SingleObj.TabIndex = 1;
            this.Ucl_SingleObj.Trd_DioObj = null;
            // 
            // Tmr_Update
            // 
            this.Tmr_Update.Enabled = true;
            this.Tmr_Update.Tick += new System.EventHandler(this.Tmr_Update_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 527);
            this.Controls.Add(this.Pnl_Ucls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "メインウインドウ";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Pnl_Ucls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Process;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Password;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Single;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Setting;
        private System.Windows.Forms.ToolStripMenuItem Tsm_EndSoftware;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Rtb_Log;
        private System.Windows.Forms.Label Lbl_State;
        private System.Windows.Forms.Label Lbl_MachineName;
        private System.Windows.Forms.Panel Pnl_Ucls;
        private _02_Ucl_Multi.Ucl_Process Ucl_ProcessObj;
        private _03_Ucl_Single.Ucl_Single Ucl_SingleObj;
        private System.Windows.Forms.Label Lbl_DateTime;
        private System.Windows.Forms.Timer Tmr_Update;
        private _04_Ucl_Other.Ucl_Setting Ucl_SettingObj;
    }
}

