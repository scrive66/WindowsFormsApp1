namespace WindowsFormsApp1._03_Ucl_Single
{
    partial class Ucl_Dio
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Chl_DioInState = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Chl_DioOutState = new System.Windows.Forms.CheckedListBox();
            this.Tmr_Polling = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN";
            // 
            // Chl_DioInState
            // 
            this.Chl_DioInState.FormattingEnabled = true;
            this.Chl_DioInState.Location = new System.Drawing.Point(0, 15);
            this.Chl_DioInState.Name = "Chl_DioInState";
            this.Chl_DioInState.Size = new System.Drawing.Size(176, 144);
            this.Chl_DioInState.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "OUT";
            // 
            // Chl_DioOutState
            // 
            this.Chl_DioOutState.CheckOnClick = true;
            this.Chl_DioOutState.FormattingEnabled = true;
            this.Chl_DioOutState.Location = new System.Drawing.Point(0, 177);
            this.Chl_DioOutState.Name = "Chl_DioOutState";
            this.Chl_DioOutState.Size = new System.Drawing.Size(176, 144);
            this.Chl_DioOutState.TabIndex = 1;
            this.Chl_DioOutState.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Chl_DioOutState_ItemCheck);
            // 
            // Tmr_Polling
            // 
            this.Tmr_Polling.Enabled = true;
            this.Tmr_Polling.Tick += new System.EventHandler(this.Tmr_Polling_Tick);
            // 
            // Ucl_Dio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Chl_DioOutState);
            this.Controls.Add(this.Chl_DioInState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ucl_Dio";
            this.Size = new System.Drawing.Size(236, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Chl_DioInState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Chl_DioOutState;
        private System.Windows.Forms.Timer Tmr_Polling;
    }
}
