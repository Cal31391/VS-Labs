namespace Coffee_Shop
{
    partial class Form1
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
            this.main_Frame = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoffeeFlavorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCoffeeFlavorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_SyrupFlavors = new System.Windows.Forms.ListBox();
            this.comBox_coffeeFlavors = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_itemInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_newFlavor = new System.Windows.Forms.TextBox();
            this.main_Frame.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_Frame
            // 
            this.main_Frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.main_Frame.Controls.Add(this.label_title);
            this.main_Frame.Controls.Add(this.menuStrip1);
            this.main_Frame.Location = new System.Drawing.Point(0, 2);
            this.main_Frame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.main_Frame.Name = "main_Frame";
            this.main_Frame.Size = new System.Drawing.Size(496, 96);
            this.main_Frame.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(181, 39);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(136, 25);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Coffee Shop";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(496, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCoffeeFlavorToolStripMenuItem,
            this.removeCoffeeFlavorToolStripMenuItem,
            this.clearCoffeeListToolStripMenuItem,
            this.countCoffeeListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addCoffeeFlavorToolStripMenuItem
            // 
            this.addCoffeeFlavorToolStripMenuItem.Name = "addCoffeeFlavorToolStripMenuItem";
            this.addCoffeeFlavorToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.addCoffeeFlavorToolStripMenuItem.Text = "Add Coffee Flavor";
            this.addCoffeeFlavorToolStripMenuItem.Click += new System.EventHandler(this.addCoffeeFlavorToolStripMenuItem_Click);
            // 
            // removeCoffeeFlavorToolStripMenuItem
            // 
            this.removeCoffeeFlavorToolStripMenuItem.Name = "removeCoffeeFlavorToolStripMenuItem";
            this.removeCoffeeFlavorToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removeCoffeeFlavorToolStripMenuItem.Text = "Remove Coffee Flavor";
            this.removeCoffeeFlavorToolStripMenuItem.Click += new System.EventHandler(this.removeCoffeeFlavorToolStripMenuItem_Click);
            // 
            // clearCoffeeListToolStripMenuItem
            // 
            this.clearCoffeeListToolStripMenuItem.Name = "clearCoffeeListToolStripMenuItem";
            this.clearCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.clearCoffeeListToolStripMenuItem.Text = "Clear Coffee List";
            this.clearCoffeeListToolStripMenuItem.Click += new System.EventHandler(this.clearCoffeeListToolStripMenuItem_Click);
            // 
            // countCoffeeListToolStripMenuItem
            // 
            this.countCoffeeListToolStripMenuItem.Name = "countCoffeeListToolStripMenuItem";
            this.countCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.countCoffeeListToolStripMenuItem.Text = "Count Coffee List";
            this.countCoffeeListToolStripMenuItem.Click += new System.EventHandler(this.countCoffeeListToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listBox_SyrupFlavors
            // 
            this.listBox_SyrupFlavors.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_SyrupFlavors.FormattingEnabled = true;
            this.listBox_SyrupFlavors.ItemHeight = 16;
            this.listBox_SyrupFlavors.Items.AddRange(new object[] {
            "Almond",
            "Amaretto",
            "Caramel",
            "Chocolate Milano",
            "Cinnamon"});
            this.listBox_SyrupFlavors.Location = new System.Drawing.Point(61, 123);
            this.listBox_SyrupFlavors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_SyrupFlavors.Name = "listBox_SyrupFlavors";
            this.listBox_SyrupFlavors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_SyrupFlavors.Size = new System.Drawing.Size(158, 116);
            this.listBox_SyrupFlavors.TabIndex = 1;
            // 
            // comBox_coffeeFlavors
            // 
            this.comBox_coffeeFlavors.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_coffeeFlavors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comBox_coffeeFlavors.FormattingEnabled = true;
            this.comBox_coffeeFlavors.Location = new System.Drawing.Point(61, 51);
            this.comBox_coffeeFlavors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comBox_coffeeFlavors.Name = "comBox_coffeeFlavors";
            this.comBox_coffeeFlavors.Size = new System.Drawing.Size(158, 24);
            this.comBox_coffeeFlavors.TabIndex = 0;
            this.comBox_coffeeFlavors.Text = "Select Coffee Flavor";
            this.comBox_coffeeFlavors.SelectedIndexChanged += new System.EventHandler(this.comBox_coffeeFlavors_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_itemInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_newFlavor);
            this.panel1.Controls.Add(this.listBox_SyrupFlavors);
            this.panel1.Controls.Add(this.comBox_coffeeFlavors);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 266);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Syrup Flavors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Info:";
            // 
            // label_itemInfo
            // 
            this.label_itemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_itemInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_itemInfo.Location = new System.Drawing.Point(277, 123);
            this.label_itemInfo.Name = "label_itemInfo";
            this.label_itemInfo.Size = new System.Drawing.Size(152, 117);
            this.label_itemInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Flavor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coffee Flavors:";
            // 
            // textBox_newFlavor
            // 
            this.textBox_newFlavor.Location = new System.Drawing.Point(277, 54);
            this.textBox_newFlavor.Name = "textBox_newFlavor";
            this.textBox_newFlavor.Size = new System.Drawing.Size(152, 21);
            this.textBox_newFlavor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_Frame);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.main_Frame.ResumeLayout(false);
            this.main_Frame.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_Frame;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ListBox listBox_SyrupFlavors;
        private System.Windows.Forms.ComboBox comBox_coffeeFlavors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoffeeFlavorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCoffeeFlavorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_newFlavor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_itemInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

