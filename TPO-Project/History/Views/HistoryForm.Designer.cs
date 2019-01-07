namespace TPO_Project.History.Views
{
    partial class HistoryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(550, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(475, 244);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 272);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private void nonGeneratedInitializeComponent()
        {
            // Initialize the DataGridView.
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnCount = 5;
            this.dataGridView1.AutoSize = false;

            this.dataGridView1.Columns[0].Name = "First Number";
            this.dataGridView1.Columns[0].HeaderText = "First Number";
            this.dataGridView1.Columns[0].DataPropertyName = "FirstNumber";

            this.dataGridView1.Columns[1].Name = "Operation";
            this.dataGridView1.Columns[1].HeaderText = "Operation";
            this.dataGridView1.Columns[1].DataPropertyName = "Operation";

            this.dataGridView1.Columns[2].Name = "Second Number";
            this.dataGridView1.Columns[2].HeaderText = "Second Number";
            this.dataGridView1.Columns[2].DataPropertyName = "SecondNumber";

            this.dataGridView1.Columns[3].Name = "Result";
            this.dataGridView1.Columns[3].HeaderText = "Result";
            this.dataGridView1.Columns[3].DataPropertyName = "Result";

            this.dataGridView1.Columns[4].Name = "Type";
            this.dataGridView1.Columns[4].HeaderText = "Type";
            this.dataGridView1.Columns[4].DataPropertyName = "Type";
        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearButton;
    }
}