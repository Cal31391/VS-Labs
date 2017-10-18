namespace clee_SpeedingTicket
{
    partial class Main_TicketCalculator
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
            this.comboxViolators = new System.Windows.Forms.ComboBox();
            this.violator = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboxAppeal = new System.Windows.Forms.CheckBox();
            this.cboxEvening = new System.Windows.Forms.CheckBox();
            this.price = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.Label();
            this.txtbxSpeed = new System.Windows.Forms.TextBox();
            this.txtbxAppeal = new System.Windows.Forms.TextBox();
            this.txtbxDailyTotals = new System.Windows.Forms.TextBox();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboxViolators
            // 
            this.comboxViolators.FormattingEnabled = true;
            this.comboxViolators.Items.AddRange(new object[] {
            "Visitors",
            "Faculty/Staff",
            "Students",
            "Seniors"});
            this.comboxViolators.Location = new System.Drawing.Point(24, 41);
            this.comboxViolators.Name = "comboxViolators";
            this.comboxViolators.Size = new System.Drawing.Size(121, 21);
            this.comboxViolators.TabIndex = 0;
            // 
            // violator
            // 
            this.violator.AutoSize = true;
            this.violator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.violator.Location = new System.Drawing.Point(56, 23);
            this.violator.Name = "violator";
            this.violator.Size = new System.Drawing.Size(48, 15);
            this.violator.TabIndex = 1;
            this.violator.Text = "Violator";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(243, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(177, 195);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(29, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboxAppeal
            // 
            this.cboxAppeal.AutoSize = true;
            this.cboxAppeal.Location = new System.Drawing.Point(193, 148);
            this.cboxAppeal.Name = "cboxAppeal";
            this.cboxAppeal.Size = new System.Drawing.Size(59, 17);
            this.cboxAppeal.TabIndex = 5;
            this.cboxAppeal.Text = "Appeal";
            this.cboxAppeal.UseVisualStyleBackColor = true;
            // 
            // cboxEvening
            // 
            this.cboxEvening.AutoSize = true;
            this.cboxEvening.Location = new System.Drawing.Point(193, 125);
            this.cboxEvening.Name = "cboxEvening";
            this.cboxEvening.Size = new System.Drawing.Size(65, 17);
            this.cboxEvening.TabIndex = 6;
            this.cboxEvening.Text = "Evening";
            this.cboxEvening.UseVisualStyleBackColor = true;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(26, 125);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(58, 13);
            this.price.TabIndex = 7;
            this.price.Text = "Total Price";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(29, 145);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.ReadOnly = true;
            this.txtbxPrice.Size = new System.Drawing.Size(55, 20);
            this.txtbxPrice.TabIndex = 8;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(26, 80);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(38, 13);
            this.speed.TabIndex = 9;
            this.speed.Text = "Speed";
            // 
            // txtbxSpeed
            // 
            this.txtbxSpeed.Location = new System.Drawing.Point(29, 96);
            this.txtbxSpeed.Name = "txtbxSpeed";
            this.txtbxSpeed.Size = new System.Drawing.Size(44, 20);
            this.txtbxSpeed.TabIndex = 10;
            // 
            // txtbxAppeal
            // 
            this.txtbxAppeal.Location = new System.Drawing.Point(90, 145);
            this.txtbxAppeal.Name = "txtbxAppeal";
            this.txtbxAppeal.ReadOnly = true;
            this.txtbxAppeal.Size = new System.Drawing.Size(61, 20);
            this.txtbxAppeal.TabIndex = 11;
            // 
            // txtbxDailyTotals
            // 
            this.txtbxDailyTotals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxDailyTotals.Location = new System.Drawing.Point(165, 77);
            this.txtbxDailyTotals.Multiline = true;
            this.txtbxDailyTotals.Name = "txtbxDailyTotals";
            this.txtbxDailyTotals.ReadOnly = true;
            this.txtbxDailyTotals.Size = new System.Drawing.Size(104, 32);
            this.txtbxDailyTotals.TabIndex = 12;
            // 
            // txtbxDate
            // 
            this.txtbxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxDate.Location = new System.Drawing.Point(165, 39);
            this.txtbxDate.Multiline = true;
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.ReadOnly = true;
            this.txtbxDate.Size = new System.Drawing.Size(93, 32);
            this.txtbxDate.TabIndex = 13;
            // 
            // Main_TicketCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtbxDate);
            this.Controls.Add(this.txtbxDailyTotals);
            this.Controls.Add(this.txtbxAppeal);
            this.Controls.Add(this.txtbxSpeed);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.cboxEvening);
            this.Controls.Add(this.cboxAppeal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.violator);
            this.Controls.Add(this.comboxViolators);
            this.Name = "Main_TicketCalculator";
            this.Text = "Ticket Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxViolators;
        private System.Windows.Forms.Label violator;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cboxAppeal;
        private System.Windows.Forms.CheckBox cboxEvening;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.TextBox txtbxSpeed;
        private System.Windows.Forms.TextBox txtbxAppeal;
        private System.Windows.Forms.TextBox txtbxDailyTotals;
        private System.Windows.Forms.TextBox txtbxDate;
    }
}

