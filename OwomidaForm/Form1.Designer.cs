namespace OwomidaForm
{
    partial class Owomida
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTollFee = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbVehicle = new System.Windows.Forms.ListBox();
            this.tbTrip = new System.Windows.Forms.TextBox();
            this.tbNo = new System.Windows.Forms.RadioButton();
            this.tbYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TollFee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTollFee);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbVehicle);
            this.groupBox1.Controls.Add(this.tbTrip);
            this.groupBox1.Controls.Add(this.tbNo);
            this.groupBox1.Controls.Add(this.tbYes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(107, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TollFee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbTollFee
            // 
            this.tbTollFee.Location = new System.Drawing.Point(146, 302);
            this.tbTollFee.Name = "tbTollFee";
            this.tbTollFee.Size = new System.Drawing.Size(308, 26);
            this.tbTollFee.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbVehicle
            // 
            this.tbVehicle.FormattingEnabled = true;
            this.tbVehicle.ItemHeight = 20;
            this.tbVehicle.Items.AddRange(new object[] {
            "Korope",
            "Okada",
            "Maruwa",
            "Big Bus"});
            this.tbVehicle.Location = new System.Drawing.Point(235, 143);
            this.tbVehicle.Name = "tbVehicle";
            this.tbVehicle.Size = new System.Drawing.Size(120, 84);
            this.tbVehicle.TabIndex = 6;
            // 
            // tbTrip
            // 
            this.tbTrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrip.Location = new System.Drawing.Point(235, 33);
            this.tbTrip.Name = "tbTrip";
            this.tbTrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTrip.Size = new System.Drawing.Size(170, 26);
            this.tbTrip.TabIndex = 5;
            this.tbTrip.Text = "0";
            this.tbTrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNo
            // 
            this.tbNo.AutoSize = true;
            this.tbNo.Location = new System.Drawing.Point(367, 96);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(54, 24);
            this.tbNo.TabIndex = 4;
            this.tbNo.TabStop = true;
            this.tbNo.Text = "No";
            this.tbNo.UseVisualStyleBackColor = true;
            // 
            // tbYes
            // 
            this.tbYes.AutoSize = true;
            this.tbYes.Location = new System.Drawing.Point(235, 96);
            this.tbYes.Name = "tbYes";
            this.tbYes.Size = new System.Drawing.Size(62, 24);
            this.tbYes.TabIndex = 3;
            this.tbYes.TabStop = true;
            this.tbYes.Text = "Yes";
            this.tbYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type Of Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Trip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are You A Member?";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anthem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Owomida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Owomida";
            this.Text = "NURTW";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton tbNo;
        private System.Windows.Forms.RadioButton tbYes;
        private System.Windows.Forms.TextBox tbTollFee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox tbVehicle;
        private System.Windows.Forms.TextBox tbTrip;
    }
}

