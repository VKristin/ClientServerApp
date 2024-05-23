namespace ServerApp
{
    partial class MainFormClient
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbDialog = new RichTextBox();
            menuStrip1 = new MenuStrip();
            choseFilePathBtn = new ToolStripMenuItem();
            startBtn = new ToolStripMenuItem();
            clearBtn = new ToolStripMenuItem();
            lblFilePath = new Label();
            panel1 = new Panel();
            lblFilePathValue = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rtbDialog
            // 
            rtbDialog.Dock = DockStyle.Fill;
            rtbDialog.Location = new Point(0, 81);
            rtbDialog.Margin = new Padding(5);
            rtbDialog.Name = "rtbDialog";
            rtbDialog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbDialog.Size = new Size(784, 380);
            rtbDialog.TabIndex = 2;
            rtbDialog.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { choseFilePathBtn, startBtn, clearBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // choseFilePathBtn
            // 
            choseFilePathBtn.Name = "choseFilePathBtn";
            choseFilePathBtn.Size = new Size(149, 20);
            choseFilePathBtn.Text = "Выбрать путь к файлам";
            choseFilePathBtn.Click += choseFilePathBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(113, 20);
            startBtn.Text = "Запуск проверки";
            startBtn.Visible = false;
            startBtn.Click += startBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(112, 20);
            clearBtn.Text = "Очистить диалог";
            clearBtn.Visible = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(15, 21);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(92, 15);
            lblFilePath.TabIndex = 4;
            lblFilePath.Text = "Путь к файлам:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFilePathValue);
            panel1.Controls.Add(lblFilePath);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(784, 57);
            panel1.TabIndex = 5;
            // 
            // lblFilePathValue
            // 
            lblFilePathValue.AutoSize = true;
            lblFilePathValue.ForeColor = Color.Red;
            lblFilePathValue.Location = new Point(113, 21);
            lblFilePathValue.Name = "lblFilePathValue";
            lblFilePathValue.Size = new Size(65, 15);
            lblFilePathValue.TabIndex = 5;
            lblFilePathValue.Text = "не выбран";
            // 
            // MainFormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(rtbDialog);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "MainFormClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клиент";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem choseFilePathBtn;
        private ToolStripMenuItem startBtn;
        private Label lblFilePath;
        private Panel panel1;
        private Label lblFilePathValue;
        public RichTextBox rtbDialog;
        private ToolStripMenuItem clearBtn;
    }
}
