namespace WinFormsApp2
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioShowTrack = new System.Windows.Forms.RadioButton();
            this.trackBarSizeForm = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // radioShowTrack
            // 
            this.radioShowTrack.AutoCheck = false;
            this.radioShowTrack.AutoSize = true;
            this.radioShowTrack.Location = new System.Drawing.Point(12, 12);
            this.radioShowTrack.Name = "radioShowTrack";
            this.radioShowTrack.Size = new System.Drawing.Size(163, 24);
            this.radioShowTrack.TabIndex = 0;
            this.radioShowTrack.TabStop = true;
            this.radioShowTrack.Text = "Показать ползунок";
            this.radioShowTrack.UseVisualStyleBackColor = true;
            this.radioShowTrack.CheckedChanged += new System.EventHandler(this.radioShowTrack_CheckedChanged);
            // 
            // trackBarSizeForm
            // 
            this.trackBarSizeForm.Location = new System.Drawing.Point(0, 109);
            this.trackBarSizeForm.Name = "trackBarSizeForm";
            this.trackBarSizeForm.Size = new System.Drawing.Size(488, 56);
            this.trackBarSizeForm.TabIndex = 1;
            this.trackBarSizeForm.Visible = false;
            this.trackBarSizeForm.Scroll += new System.EventHandler(this.trackBarSizeForm_Scroll);
            this.trackBarSizeForm.ValueChanged += new System.EventHandler(this.trackBarSizeForm_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(181, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 161);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.trackBarSizeForm);
            this.Controls.Add(this.radioShowTrack);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ParentForm";
            this.Text = "Созданное окно";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioShowTrack;
        private TrackBar trackBarSizeForm;
        private CheckBox checkBox1;
    }
}