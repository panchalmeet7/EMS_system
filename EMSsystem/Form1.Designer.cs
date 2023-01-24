namespace EMSsystem
{
    partial class Form1
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
            this.insert = new System.Windows.Forms.Button();
            this.EmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.txtemployeetech = new System.Windows.Forms.TextBox();
            this.txtemployeeaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textemployeemonumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(10, 188);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(174, 40);
            this.insert.TabIndex = 0;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeedataGridView
            // 
            this.EmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeedataGridView.Location = new System.Drawing.Point(12, 263);
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.RowHeadersWidth = 51;
            this.EmployeedataGridView.RowTemplate.Height = 29;
            this.EmployeedataGridView.Size = new System.Drawing.Size(727, 188);
            this.EmployeedataGridView.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "RESET";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // txtemployeename
            // 
            this.txtemployeename.Location = new System.Drawing.Point(186, 32);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(182, 30);
            this.txtemployeename.TabIndex = 9;
            // 
            // txtemployeetech
            // 
            this.txtemployeetech.Location = new System.Drawing.Point(532, 32);
            this.txtemployeetech.Name = "txtemployeetech";
            this.txtemployeetech.Size = new System.Drawing.Size(182, 30);
            this.txtemployeetech.TabIndex = 10;
            // 
            // txtemployeeaddress
            // 
            this.txtemployeeaddress.Location = new System.Drawing.Point(186, 91);
            this.txtemployeeaddress.Name = "txtemployeeaddress";
            this.txtemployeeaddress.Size = new System.Drawing.Size(182, 30);
            this.txtemployeeaddress.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tech";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mo Number";
            // 
            // textemployeemonumber
            // 
            this.textemployeemonumber.Location = new System.Drawing.Point(532, 91);
            this.textemployeemonumber.Name = "textemployeemonumber";
            this.textemployeemonumber.Size = new System.Drawing.Size(182, 30);
            this.textemployeemonumber.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 463);
            this.Controls.Add(this.textemployeemonumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemployeeaddress);
            this.Controls.Add(this.txtemployeetech);
            this.Controls.Add(this.txtemployeename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EmployeedataGridView);
            this.Controls.Add(this.insert);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button insert;
        private DataGridView EmployeedataGridView;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox txtemployeename;
        private TextBox txtemployeetech;
        private TextBox txtemployeeaddress;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textemployeemonumber;
    }
}