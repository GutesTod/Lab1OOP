namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_page1 = new System.Windows.Forms.TabPage();
            this.tab_page2 = new System.Windows.Forms.TabPage();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_page1);
            this.tabControl1.Controls.Add(this.tab_page2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 176);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_page1
            // 
            this.tab_page1.Location = new System.Drawing.Point(4, 24);
            this.tab_page1.Name = "tab_page1";
            this.tab_page1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page1.Size = new System.Drawing.Size(292, 148);
            this.tab_page1.TabIndex = 0;
            this.tab_page1.Text = "Page 1";
            this.tab_page1.UseVisualStyleBackColor = true;
            // 
            // tab_page2
            // 
            this.tab_page2.Location = new System.Drawing.Point(4, 24);
            this.tab_page2.Name = "tab_page2";
            this.tab_page2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page2.Size = new System.Drawing.Size(292, 148);
            this.tab_page2.TabIndex = 1;
            this.tab_page2.Text = "Page 2";
            this.tab_page2.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(4, 178);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 32);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(225, 178);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 32);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(873, 417);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex++;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex--;
            }
        }
    }
}