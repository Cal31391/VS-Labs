namespace cleeCarpetCalc
{
    partial class Main_CarpetCalculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbtnEconCarp = new System.Windows.Forms.RadioButton();
            this.rbtnExpensive = new System.Windows.Forms.RadioButton();
            this.labelCarpetType = new System.Windows.Forms.Label();
            this.txtAnswerBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(109, 93);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(59, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbtnEconCarp
            // 
            this.rbtnEconCarp.AutoSize = true;
            this.rbtnEconCarp.Location = new System.Drawing.Point(36, 45);
            this.rbtnEconCarp.Name = "rbtnEconCarp";
            this.rbtnEconCarp.Size = new System.Drawing.Size(42, 17);
            this.rbtnEconCarp.TabIndex = 1;
            this.rbtnEconCarp.TabStop = true;
            this.rbtnEconCarp.Text = "Pile";
            this.rbtnEconCarp.UseVisualStyleBackColor = true;
            this.rbtnEconCarp.CheckedChanged += new System.EventHandler(this.rbtnEconCarp_CheckedChanged);
            // 
            // rbtnExpensive
            // 
            this.rbtnExpensive.AutoSize = true;
            this.rbtnExpensive.Location = new System.Drawing.Point(36, 67);
            this.rbtnExpensive.Name = "rbtnExpensive";
            this.rbtnExpensive.Size = new System.Drawing.Size(56, 17);
            this.rbtnExpensive.TabIndex = 2;
            this.rbtnExpensive.TabStop = true;
            this.rbtnExpensive.Text = "Berber";
            this.rbtnExpensive.UseVisualStyleBackColor = true;
            this.rbtnExpensive.CheckedChanged += new System.EventHandler(this.rbtnExpensive_CheckedChanged);
            // 
            // labelCarpetType
            // 
            this.labelCarpetType.AutoSize = true;
            this.labelCarpetType.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCarpetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarpetType.Location = new System.Drawing.Point(33, 29);
            this.labelCarpetType.Name = "labelCarpetType";
            this.labelCarpetType.Size = new System.Drawing.Size(65, 13);
            this.labelCarpetType.TabIndex = 3;
            this.labelCarpetType.Text = "Carpet Type";
            // 
            // txtAnswerBox
            // 
            this.txtAnswerBox.Location = new System.Drawing.Point(111, 54);
            this.txtAnswerBox.Name = "txtAnswerBox";
            this.txtAnswerBox.ReadOnly = true;
            this.txtAnswerBox.Size = new System.Drawing.Size(57, 20);
            this.txtAnswerBox.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(41, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX.Location = new System.Drawing.Point(166, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 23);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // Main_CarpetCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 128);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAnswerBox);
            this.Controls.Add(this.labelCarpetType);
            this.Controls.Add(this.rbtnExpensive);
            this.Controls.Add(this.rbtnEconCarp);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Main_CarpetCalculator";
            this.Text = "CarpetCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbtnEconCarp;
        private System.Windows.Forms.RadioButton rbtnExpensive;
        private System.Windows.Forms.Label labelCarpetType;
        private System.Windows.Forms.TextBox txtAnswerBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnX;
    }
}

