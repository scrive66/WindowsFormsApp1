namespace WindowsFormsApp1._02_Ucl_Multi
{
    partial class Ucl_Process
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_State = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "状態";
            // 
            // Lbl_State
            // 
            this.Lbl_State.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_State.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_State.Location = new System.Drawing.Point(5, 12);
            this.Lbl_State.Name = "Lbl_State";
            this.Lbl_State.Size = new System.Drawing.Size(576, 39);
            this.Lbl_State.TabIndex = 0;
            this.Lbl_State.Text = "状態";
            this.Lbl_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "作業指示";
            // 
            // Lbl_Operation
            // 
            this.Lbl_Operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Operation.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Operation.Location = new System.Drawing.Point(5, 75);
            this.Lbl_Operation.Name = "Lbl_Operation";
            this.Lbl_Operation.Size = new System.Drawing.Size(576, 105);
            this.Lbl_Operation.TabIndex = 0;
            this.Lbl_Operation.Text = "作業指示\r\n";
            // 
            // Ucl_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Operation);
            this.Controls.Add(this.Lbl_State);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Ucl_Process";
            this.Size = new System.Drawing.Size(604, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Operation;
        private System.Windows.Forms.Label Lbl_State;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
