
namespace BussinesCommunications
{
    partial class OperatorForm
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
            this.Exit1 = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.webBrowserPrewiev = new System.Windows.Forms.WebBrowser();
            this.UpdateReportBTN = new System.Windows.Forms.Button();
            this.UpdateReportComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateReportTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit1
            // 
            this.Exit1.Location = new System.Drawing.Point(713, 415);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(75, 23);
            this.Exit1.TabIndex = 12;
            this.Exit1.Text = "Выйти";
            this.Exit1.UseVisualStyleBackColor = true;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(651, 383);
            this.dataGridViewReport.TabIndex = 13;
            this.dataGridViewReport.DoubleClick += new System.EventHandler(this.dataGridViewReport_DoubleClick);
            // 
            // webBrowserPrewiev
            // 
            this.webBrowserPrewiev.Location = new System.Drawing.Point(744, 12);
            this.webBrowserPrewiev.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPrewiev.Name = "webBrowserPrewiev";
            this.webBrowserPrewiev.Size = new System.Drawing.Size(44, 33);
            this.webBrowserPrewiev.TabIndex = 14;
            this.webBrowserPrewiev.Visible = false;
            // 
            // UpdateReportBTN
            // 
            this.UpdateReportBTN.Location = new System.Drawing.Point(588, 402);
            this.UpdateReportBTN.Name = "UpdateReportBTN";
            this.UpdateReportBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateReportBTN.TabIndex = 15;
            this.UpdateReportBTN.Text = "Изменить";
            this.UpdateReportBTN.UseVisualStyleBackColor = true;
            this.UpdateReportBTN.Click += new System.EventHandler(this.UpdateReportBTN_Click);
            // 
            // UpdateReportComboBox
            // 
            this.UpdateReportComboBox.FormattingEnabled = true;
            this.UpdateReportComboBox.Items.AddRange(new object[] {
            "Подписано",
            "Отказано"});
            this.UpdateReportComboBox.Location = new System.Drawing.Point(145, 402);
            this.UpdateReportComboBox.Name = "UpdateReportComboBox";
            this.UpdateReportComboBox.Size = new System.Drawing.Size(151, 21);
            this.UpdateReportComboBox.TabIndex = 16;
            this.UpdateReportComboBox.SelectedValueChanged += new System.EventHandler(this.UpdateReportComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Изменить статус отчета";
            // 
            // UpdateReportTextBox
            // 
            this.UpdateReportTextBox.Location = new System.Drawing.Point(145, 429);
            this.UpdateReportTextBox.Name = "UpdateReportTextBox";
            this.UpdateReportTextBox.Size = new System.Drawing.Size(438, 20);
            this.UpdateReportTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Причина отказа";
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateReportTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateReportComboBox);
            this.Controls.Add(this.UpdateReportBTN);
            this.Controls.Add(this.Exit1);
            this.Controls.Add(this.webBrowserPrewiev);
            this.Controls.Add(this.dataGridViewReport);
            this.MaximumSize = new System.Drawing.Size(816, 498);
            this.MinimumSize = new System.Drawing.Size(816, 498);
            this.Name = "OperatorForm";
            this.Text = "OperatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.WebBrowser webBrowserPrewiev;
        private System.Windows.Forms.Button UpdateReportBTN;
        private System.Windows.Forms.ComboBox UpdateReportComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdateReportTextBox;
        private System.Windows.Forms.Label label2;
    }
}