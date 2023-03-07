using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_page1 = new System.Windows.Forms.TabPage();
            this.label_page1 = new System.Windows.Forms.Label();
            this.tab_page2 = new System.Windows.Forms.TabPage();
            this.label_page2 = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.infoTextSave = new System.Windows.Forms.Label();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProgressBar = new System.Windows.Forms.CheckBox();
            this.progressBarShow = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_page1.SuspendLayout();
            this.tab_page2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_page1);
            this.tabControl1.Controls.Add(this.tab_page2);
            this.tabControl1.Location = new System.Drawing.Point(2, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 159);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_page1
            // 
            this.tab_page1.Controls.Add(this.label_page1);
            this.tab_page1.Location = new System.Drawing.Point(4, 29);
            this.tab_page1.Name = "tab_page1";
            this.tab_page1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page1.Size = new System.Drawing.Size(250, 126);
            this.tab_page1.TabIndex = 0;
            this.tab_page1.Text = "Page 1";
            this.tab_page1.UseVisualStyleBackColor = true;
            // 
            // label_page1
            // 
            this.label_page1.AutoSize = true;
            this.label_page1.Location = new System.Drawing.Point(3, 3);
            this.label_page1.MaximumSize = new System.Drawing.Size(250, 131);
            this.label_page1.Name = "label_page1";
            this.label_page1.Size = new System.Drawing.Size(0, 20);
            this.label_page1.TabIndex = 0;
            // 
            // tab_page2
            // 
            this.tab_page2.Controls.Add(this.label_page2);
            this.tab_page2.Location = new System.Drawing.Point(4, 29);
            this.tab_page2.Name = "tab_page2";
            this.tab_page2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page2.Size = new System.Drawing.Size(250, 126);
            this.tab_page2.TabIndex = 1;
            this.tab_page2.Text = "Page 2";
            this.tab_page2.UseVisualStyleBackColor = true;
            // 
            // label_page2
            // 
            this.label_page2.AutoSize = true;
            this.label_page2.Location = new System.Drawing.Point(3, 3);
            this.label_page2.MaximumSize = new System.Drawing.Size(250, 131);
            this.label_page2.Name = "label_page2";
            this.label_page2.Size = new System.Drawing.Size(0, 20);
            this.label_page2.TabIndex = 0;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(6, 200);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 32);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(185, 200);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 32);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // infoTextSave
            // 
            this.infoTextSave.AutoSize = true;
            this.infoTextSave.Location = new System.Drawing.Point(280, 58);
            this.infoTextSave.Name = "infoTextSave";
            this.infoTextSave.Size = new System.Drawing.Size(89, 20);
            this.infoTextSave.TabIndex = 2;
            this.infoTextSave.Text = "Ввод текста";
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(280, 83);
            this.textBoxSave.Multiline = true;
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(252, 134);
            this.textBoxSave.TabIndex = 3;
            this.textBoxSave.TextChanged += new System.EventHandler(this.textBoxSave_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewWindowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createNewWindowToolStripMenuItem
            // 
            this.createNewWindowToolStripMenuItem.Name = "createNewWindowToolStripMenuItem";
            this.createNewWindowToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.createNewWindowToolStripMenuItem.Text = "Создание нового окна";
            this.createNewWindowToolStripMenuItem.Click += new System.EventHandler(this.createNewWindowToolStripMenuItem_Click);
            // 
            // showProgressBar
            // 
            this.showProgressBar.AutoSize = true;
            this.showProgressBar.Location = new System.Drawing.Point(576, 91);
            this.showProgressBar.Name = "showProgressBar";
            this.showProgressBar.Size = new System.Drawing.Size(161, 24);
            this.showProgressBar.TabIndex = 5;
            this.showProgressBar.Text = "Запустить загрузку";
            this.showProgressBar.UseVisualStyleBackColor = true;
            this.showProgressBar.CheckedChanged += new System.EventHandler(this.showProgressBar_CheckedChanged);
            // 
            // progressBarShow
            // 
            this.progressBarShow.Location = new System.Drawing.Point(576, 132);
            this.progressBarShow.Name = "progressBarShow";
            this.progressBarShow.Size = new System.Drawing.Size(125, 29);
            this.progressBarShow.Step = 5;
            this.progressBarShow.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarShow.TabIndex = 6;
            this.progressBarShow.Visible = false;
            this.progressBarShow.Minimum = 0;
            this.progressBarShow.Maximum = 20;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 10;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1018, 417);
            this.Controls.Add(this.progressBarShow);
            this.Controls.Add(this.showProgressBar);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.infoTextSave);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Первая программа";
            this.tabControl1.ResumeLayout(false);
            this.tab_page1.ResumeLayout(false);
            this.tab_page1.PerformLayout();
            this.tab_page2.ResumeLayout(false);
            this.tab_page2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void textBoxSave_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                label_page1.Text = textBoxSave.Text;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                label_page2.Text = textBoxSave.Text;
            }
        }

        private void createNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentForm form = new ParentForm();
            form.Show();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (progressBarShow.Visible)
            {
                if (progressBarShow.Value < progressBarShow.Maximum)
                {
                    progressBarShow.Increment(5);
                }
                else
                {
                    timerProgressBar.Stop();
                }
            }
        }

        private void showProgressBar_CheckedChanged(object sender, EventArgs e)
        {
            if (showProgressBar.Checked)
            {
                progressBarShow.Visible = true;
                timerProgressBar.Start();
            }
            else
            {
                progressBarShow.Visible = false;
            }
        }
    }
}