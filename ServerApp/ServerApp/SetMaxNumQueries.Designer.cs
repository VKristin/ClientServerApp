namespace ServerApp
{
    partial class SetMaxNumQueries
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
            lblMaxNumQueries = new Label();
            btnStartServer = new Button();
            nudMaxNumQueriesValue = new NumericUpDown();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMaxNumQueriesValue).BeginInit();
            SuspendLayout();
            // 
            // lblMaxNumQueries
            // 
            lblMaxNumQueries.AutoSize = true;
            lblMaxNumQueries.Location = new Point(90, 33);
            lblMaxNumQueries.Name = "lblMaxNumQueries";
            lblMaxNumQueries.Size = new Size(212, 15);
            lblMaxNumQueries.TabIndex = 0;
            lblMaxNumQueries.Text = "Максимальное количество запросов";
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(64, 118);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(99, 31);
            btnStartServer.TabIndex = 1;
            btnStartServer.Text = "Запустить";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // nudMaxNumQueriesValue
            // 
            nudMaxNumQueriesValue.Location = new Point(135, 66);
            nudMaxNumQueriesValue.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudMaxNumQueriesValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxNumQueriesValue.Name = "nudMaxNumQueriesValue";
            nudMaxNumQueriesValue.Size = new Size(120, 23);
            nudMaxNumQueriesValue.TabIndex = 3;
            nudMaxNumQueriesValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(232, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SetMaxNumQueries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(btnCancel);
            Controls.Add(nudMaxNumQueriesValue);
            Controls.Add(btnStartServer);
            Controls.Add(lblMaxNumQueries);
            Name = "SetMaxNumQueries";
            Text = "Максимальное количество запросов";
            ((System.ComponentModel.ISupportInitialize)nudMaxNumQueriesValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaxNumQueries;
        private Button btnStartServer;
        private NumericUpDown nudMaxNumQueriesValue;
        private Button btnCancel;
    }
}