namespace ServerApp
{
    partial class MainFormServer
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
            lbServerStatus = new Label();
            lblServerStatusValue = new Label();
            dgvClientQueries = new DataGridView();
            TimeOfQuery = new DataGridViewTextBoxColumn();
            Query = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            gbStatus = new GroupBox();
            lblMaxNumQueries = new Label();
            lblMaxNumQueriesValue = new Label();
            menuStrip1 = new MenuStrip();
            startServerTsm = new ToolStripMenuItem();
            остановитьСерверToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvClientQueries).BeginInit();
            gbStatus.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbServerStatus
            // 
            lbServerStatus.AutoSize = true;
            lbServerStatus.Location = new Point(6, 19);
            lbServerStatus.Name = "lbServerStatus";
            lbServerStatus.Size = new Size(93, 15);
            lbServerStatus.TabIndex = 0;
            lbServerStatus.Text = "Статус сервера:";
            // 
            // lblServerStatusValue
            // 
            lblServerStatusValue.AutoSize = true;
            lblServerStatusValue.Location = new Point(105, 19);
            lblServerStatusValue.Name = "lblServerStatusValue";
            lblServerStatusValue.Size = new Size(73, 15);
            lblServerStatusValue.TabIndex = 1;
            lblServerStatusValue.Text = "Не запущен";
            // 
            // dgvClientQueries
            // 
            dgvClientQueries.AllowUserToAddRows = false;
            dgvClientQueries.AllowUserToDeleteRows = false;
            dgvClientQueries.BackgroundColor = SystemColors.Control;
            dgvClientQueries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientQueries.Columns.AddRange(new DataGridViewColumn[] { TimeOfQuery, Query, Answer });
            dgvClientQueries.Dock = DockStyle.Fill;
            dgvClientQueries.GridColor = SystemColors.ScrollBar;
            dgvClientQueries.Location = new Point(0, 75);
            dgvClientQueries.Name = "dgvClientQueries";
            dgvClientQueries.ReadOnly = true;
            dgvClientQueries.Size = new Size(784, 216);
            dgvClientQueries.TabIndex = 2;
            // 
            // TimeOfQuery
            // 
            TimeOfQuery.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeOfQuery.HeaderText = "Время";
            TimeOfQuery.Name = "TimeOfQuery";
            TimeOfQuery.ReadOnly = true;
            // 
            // Query
            // 
            Query.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Query.HeaderText = "Запрос";
            Query.Name = "Query";
            Query.ReadOnly = true;
            // 
            // Answer
            // 
            Answer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Answer.HeaderText = "Ответ";
            Answer.Name = "Answer";
            Answer.ReadOnly = true;
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(lblMaxNumQueries);
            gbStatus.Controls.Add(lblMaxNumQueriesValue);
            gbStatus.Controls.Add(lbServerStatus);
            gbStatus.Controls.Add(lblServerStatusValue);
            gbStatus.Dock = DockStyle.Top;
            gbStatus.Location = new Point(0, 24);
            gbStatus.Margin = new Padding(0);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(784, 51);
            gbStatus.TabIndex = 3;
            gbStatus.TabStop = false;
            // 
            // lblMaxNumQueries
            // 
            lblMaxNumQueries.AutoSize = true;
            lblMaxNumQueries.Location = new Point(234, 19);
            lblMaxNumQueries.Name = "lblMaxNumQueries";
            lblMaxNumQueries.Size = new Size(215, 15);
            lblMaxNumQueries.TabIndex = 2;
            lblMaxNumQueries.Text = "Максимальное количество запросов:";
            // 
            // lblMaxNumQueriesValue
            // 
            lblMaxNumQueriesValue.AutoSize = true;
            lblMaxNumQueriesValue.Location = new Point(455, 19);
            lblMaxNumQueriesValue.Name = "lblMaxNumQueriesValue";
            lblMaxNumQueriesValue.Size = new Size(13, 15);
            lblMaxNumQueriesValue.TabIndex = 3;
            lblMaxNumQueriesValue.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { startServerTsm, остановитьСерверToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // startServerTsm
            // 
            startServerTsm.Name = "startServerTsm";
            startServerTsm.Size = new Size(115, 20);
            startServerTsm.Text = "Запустить сервер";
            startServerTsm.Click += startServerTsm_Click;
            // 
            // остановитьСерверToolStripMenuItem
            // 
            остановитьСерверToolStripMenuItem.Name = "остановитьСерверToolStripMenuItem";
            остановитьСерверToolStripMenuItem.Size = new Size(124, 20);
            остановитьСерверToolStripMenuItem.Text = "Остановить сервер";
            остановитьСерверToolStripMenuItem.Visible = false;
            // 
            // MainFormServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 291);
            Controls.Add(dgvClientQueries);
            Controls.Add(gbStatus);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(800, 330);
            Name = "MainFormServer";
            Text = "Сервер";
            ((System.ComponentModel.ISupportInitialize)dgvClientQueries).EndInit();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbServerStatus;
        private Label lblServerStatusValue;
        private DataGridView dgvClientQueries;
        private GroupBox gbStatus;
        private DataGridViewTextBoxColumn TimeOfQuery;
        private DataGridViewTextBoxColumn Query;
        private DataGridViewTextBoxColumn Answer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startServerTsm;
        private Label lblMaxNumQueries;
        private Label lblMaxNumQueriesValue;
        private ToolStripMenuItem остановитьСерверToolStripMenuItem;
    }
}
