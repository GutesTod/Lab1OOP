namespace WinFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private TabControl tabControl1;
        private TabPage tab_page1;
        private TabPage tab_page2;
        private Button btn_prev;
        private Button btn_next;
        private Label infoTextSave;
        private TextBox textBoxSave;
        private Label label_page1;
        private Label label_page2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createNewWindowToolStripMenuItem;
        private CheckBox showProgressBar;
        private ProgressBar progressBarShow;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}