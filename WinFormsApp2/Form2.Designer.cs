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
            this.btnSizeUp = new System.Windows.Forms.Button();
            this.buttonSIzeDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSizeUp
            // 
            this.btnSizeUp.Location = new System.Drawing.Point(12, 12);
            this.btnSizeUp.Name = "btnSizeUp";
            this.btnSizeUp.Size = new System.Drawing.Size(402, 47);
            this.btnSizeUp.TabIndex = 0;
            this.btnSizeUp.Text = "Увеличить размер окна";
            this.btnSizeUp.UseVisualStyleBackColor = true;
            this.btnSizeUp.Click += new System.EventHandler(this.btnSizeUp_Click);
            // 
            // buttonSIzeDown
            // 
            this.buttonSIzeDown.Location = new System.Drawing.Point(12, 65);
            this.buttonSIzeDown.Name = "buttonSIzeDown";
            this.buttonSIzeDown.Size = new System.Drawing.Size(402, 51);
            this.buttonSIzeDown.TabIndex = 1;
            this.buttonSIzeDown.Text = "Уменьшить размер окна";
            this.buttonSIzeDown.UseVisualStyleBackColor = true;
            this.buttonSIzeDown.Click += new System.EventHandler(this.buttonSIzeDown_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 121);
            this.Controls.Add(this.buttonSIzeDown);
            this.Controls.Add(this.btnSizeUp);
            this.Name = "ParentForm";
            this.Text = "Созданное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSizeUp;
        private Button buttonSIzeDown;
    }
}