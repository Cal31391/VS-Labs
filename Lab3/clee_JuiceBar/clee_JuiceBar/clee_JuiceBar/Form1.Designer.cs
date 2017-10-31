namespace clee_JuiceBar
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
            this.comBox_juiceSelect = new System.Windows.Forms.ComboBox();
            this.comBox_smoothieSelect = new System.Windows.Forms.ComboBox();
            this.label_drinkSize = new System.Windows.Forms.Label();
            this.label_additives = new System.Windows.Forms.Label();
            this.btn_addToOrder = new System.Windows.Forms.Button();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.comBox_12ou = new System.Windows.Forms.ComboBox();
            this.comBox_16ou = new System.Windows.Forms.ComboBox();
            this.comBox_20ou = new System.Windows.Forms.ComboBox();
            this.comboBox_drinkSelection = new System.Windows.Forms.ComboBox();
            this.label_12ou = new System.Windows.Forms.Label();
            this.label_16ou = new System.Windows.Forms.Label();
            this.label_20ou = new System.Windows.Forms.Label();
            this.label_totalPriceContent = new System.Windows.Forms.Label();
            this.btn_summary = new System.Windows.Forms.Button();
            this.lBox_additives = new System.Windows.Forms.ListBox();
            this.label_currentOrder = new System.Windows.Forms.Label();
            this.label_drink = new System.Windows.Forms.Label();
            this.label_drinkType = new System.Windows.Forms.Label();
            this.label_order = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_12ounce = new System.Windows.Forms.Label();
            this.label_16ounce = new System.Windows.Forms.Label();
            this.label_20ounce = new System.Windows.Forms.Label();
            this.btn_clearOrder = new System.Windows.Forms.Button();
            this.label_selectSmoothie = new System.Windows.Forms.Label();
            this.btn_exit2 = new System.Windows.Forms.Button();
            this.menuStrip_form2 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSummaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip_form2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBox_juiceSelect
            // 
            this.comBox_juiceSelect.Enabled = false;
            this.comBox_juiceSelect.FormattingEnabled = true;
            this.comBox_juiceSelect.Items.AddRange(new object[] {
            "",
            "Fruit",
            "Veggie"});
            this.comBox_juiceSelect.Location = new System.Drawing.Point(83, 168);
            this.comBox_juiceSelect.Name = "comBox_juiceSelect";
            this.comBox_juiceSelect.Size = new System.Drawing.Size(121, 21);
            this.comBox_juiceSelect.TabIndex = 10;
            this.comBox_juiceSelect.Text = "Select Juice";
            this.comBox_juiceSelect.SelectedIndexChanged += new System.EventHandler(this.comBox_juiceSelect_SelectedIndexChanged);
            // 
            // comBox_smoothieSelect
            // 
            this.comBox_smoothieSelect.Enabled = false;
            this.comBox_smoothieSelect.FormattingEnabled = true;
            this.comBox_smoothieSelect.Items.AddRange(new object[] {
            "",
            "Pomegranate",
            "Strawberry Banana",
            "Wheat Berry"});
            this.comBox_smoothieSelect.Location = new System.Drawing.Point(210, 168);
            this.comBox_smoothieSelect.Name = "comBox_smoothieSelect";
            this.comBox_smoothieSelect.Size = new System.Drawing.Size(121, 21);
            this.comBox_smoothieSelect.TabIndex = 11;
            this.comBox_smoothieSelect.Text = "Select Smoothie";
            this.comBox_smoothieSelect.SelectedIndexChanged += new System.EventHandler(this.comBox_smoothieSelect_SelectedIndexChanged);
            // 
            // label_drinkSize
            // 
            this.label_drinkSize.AutoSize = true;
            this.label_drinkSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_drinkSize.Location = new System.Drawing.Point(92, 215);
            this.label_drinkSize.Name = "label_drinkSize";
            this.label_drinkSize.Size = new System.Drawing.Size(69, 13);
            this.label_drinkSize.TabIndex = 13;
            this.label_drinkSize.Text = "Drink Size:";
            // 
            // label_additives
            // 
            this.label_additives.AutoSize = true;
            this.label_additives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_additives.Location = new System.Drawing.Point(348, 234);
            this.label_additives.Name = "label_additives";
            this.label_additives.Size = new System.Drawing.Size(107, 13);
            this.label_additives.TabIndex = 20;
            this.label_additives.Text = "Additives ($2.50):";
            // 
            // btn_addToOrder
            // 
            this.btn_addToOrder.AutoSize = true;
            this.btn_addToOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToOrder.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_addToOrder.Location = new System.Drawing.Point(177, 370);
            this.btn_addToOrder.Name = "btn_addToOrder";
            this.btn_addToOrder.Size = new System.Drawing.Size(89, 23);
            this.btn_addToOrder.TabIndex = 22;
            this.btn_addToOrder.Text = "Add to Order";
            this.btn_addToOrder.UseVisualStyleBackColor = false;
            this.btn_addToOrder.Click += new System.EventHandler(this.btn_addToOrder_Click);
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalPrice.Location = new System.Drawing.Point(267, 340);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(73, 13);
            this.label_totalPrice.TabIndex = 23;
            this.label_totalPrice.Text = "Total Price:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(250, 215);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(58, 13);
            this.label_quantity.TabIndex = 24;
            this.label_quantity.Text = "Quantity:";
            // 
            // comBox_12ou
            // 
            this.comBox_12ou.Enabled = false;
            this.comBox_12ou.FormattingEnabled = true;
            this.comBox_12ou.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comBox_12ou.Location = new System.Drawing.Point(259, 231);
            this.comBox_12ou.Name = "comBox_12ou";
            this.comBox_12ou.Size = new System.Drawing.Size(42, 21);
            this.comBox_12ou.TabIndex = 25;
            this.comBox_12ou.SelectedIndexChanged += new System.EventHandler(this.comBox_12ou_SelectedIndexChanged);
            // 
            // comBox_16ou
            // 
            this.comBox_16ou.Enabled = false;
            this.comBox_16ou.FormattingEnabled = true;
            this.comBox_16ou.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comBox_16ou.Location = new System.Drawing.Point(259, 259);
            this.comBox_16ou.Name = "comBox_16ou";
            this.comBox_16ou.Size = new System.Drawing.Size(42, 21);
            this.comBox_16ou.TabIndex = 26;
            this.comBox_16ou.SelectedIndexChanged += new System.EventHandler(this.comBox_16ou_SelectedIndexChanged);
            // 
            // comBox_20ou
            // 
            this.comBox_20ou.Enabled = false;
            this.comBox_20ou.FormattingEnabled = true;
            this.comBox_20ou.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comBox_20ou.Location = new System.Drawing.Point(259, 286);
            this.comBox_20ou.Name = "comBox_20ou";
            this.comBox_20ou.Size = new System.Drawing.Size(42, 21);
            this.comBox_20ou.TabIndex = 27;
            this.comBox_20ou.SelectedIndexChanged += new System.EventHandler(this.comBox_20ou_SelectedIndexChanged);
            // 
            // comboBox_drinkSelection
            // 
            this.comboBox_drinkSelection.FormattingEnabled = true;
            this.comboBox_drinkSelection.Items.AddRange(new object[] {
            "",
            "Juice",
            "Smoothie"});
            this.comboBox_drinkSelection.Location = new System.Drawing.Point(83, 123);
            this.comboBox_drinkSelection.Name = "comboBox_drinkSelection";
            this.comboBox_drinkSelection.Size = new System.Drawing.Size(121, 21);
            this.comboBox_drinkSelection.TabIndex = 28;
            this.comboBox_drinkSelection.Text = "Select Drink ";
            this.comboBox_drinkSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox_drinkSelection_SelectedIndexChanged);
            // 
            // label_12ou
            // 
            this.label_12ou.AutoSize = true;
            this.label_12ou.Location = new System.Drawing.Point(95, 239);
            this.label_12ou.Name = "label_12ou";
            this.label_12ou.Size = new System.Drawing.Size(57, 13);
            this.label_12ou.TabIndex = 29;
            this.label_12ou.Text = "12 ounces";
            // 
            // label_16ou
            // 
            this.label_16ou.AutoSize = true;
            this.label_16ou.Location = new System.Drawing.Point(95, 265);
            this.label_16ou.Name = "label_16ou";
            this.label_16ou.Size = new System.Drawing.Size(57, 13);
            this.label_16ou.TabIndex = 30;
            this.label_16ou.Text = "16 ounces";
            // 
            // label_20ou
            // 
            this.label_20ou.AutoSize = true;
            this.label_20ou.Location = new System.Drawing.Point(95, 292);
            this.label_20ou.Name = "label_20ou";
            this.label_20ou.Size = new System.Drawing.Size(57, 13);
            this.label_20ou.TabIndex = 31;
            this.label_20ou.Text = "20 ounces";
            // 
            // label_totalPriceContent
            // 
            this.label_totalPriceContent.AutoSize = true;
            this.label_totalPriceContent.Location = new System.Drawing.Point(348, 340);
            this.label_totalPriceContent.Name = "label_totalPriceContent";
            this.label_totalPriceContent.Size = new System.Drawing.Size(34, 13);
            this.label_totalPriceContent.TabIndex = 32;
            this.label_totalPriceContent.Text = "$0.00";
            // 
            // btn_summary
            // 
            this.btn_summary.AutoSize = true;
            this.btn_summary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_summary.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_summary.Location = new System.Drawing.Point(408, 370);
            this.btn_summary.Name = "btn_summary";
            this.btn_summary.Size = new System.Drawing.Size(88, 23);
            this.btn_summary.TabIndex = 33;
            this.btn_summary.Text = "Summary";
            this.btn_summary.UseVisualStyleBackColor = false;
            this.btn_summary.Click += new System.EventHandler(this.btn_summary_Click);
            // 
            // lBox_additives
            // 
            this.lBox_additives.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lBox_additives.Enabled = false;
            this.lBox_additives.FormattingEnabled = true;
            this.lBox_additives.Items.AddRange(new object[] {
            "Vitamin Pack ",
            "Energy Boost",
            "Cool Down Remedy"});
            this.lBox_additives.Location = new System.Drawing.Point(351, 250);
            this.lBox_additives.Name = "lBox_additives";
            this.lBox_additives.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBox_additives.Size = new System.Drawing.Size(124, 56);
            this.lBox_additives.TabIndex = 21;
            this.lBox_additives.SelectedIndexChanged += new System.EventHandler(this.lBox_additives_SelectedIndexChanged);
            // 
            // label_currentOrder
            // 
            this.label_currentOrder.AutoSize = true;
            this.label_currentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentOrder.Location = new System.Drawing.Point(471, 92);
            this.label_currentOrder.Name = "label_currentOrder";
            this.label_currentOrder.Size = new System.Drawing.Size(91, 13);
            this.label_currentOrder.TabIndex = 34;
            this.label_currentOrder.Text = "Current Order: ";
            // 
            // label_drink
            // 
            this.label_drink.AutoSize = true;
            this.label_drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_drink.Location = new System.Drawing.Point(80, 104);
            this.label_drink.Name = "label_drink";
            this.label_drink.Size = new System.Drawing.Size(81, 13);
            this.label_drink.TabIndex = 35;
            this.label_drink.Text = "Select Drink:";
            // 
            // label_drinkType
            // 
            this.label_drinkType.AutoSize = true;
            this.label_drinkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_drinkType.Location = new System.Drawing.Point(80, 152);
            this.label_drinkType.Name = "label_drinkType";
            this.label_drinkType.Size = new System.Drawing.Size(81, 13);
            this.label_drinkType.TabIndex = 36;
            this.label_drinkType.Text = "Select Juice:";
            // 
            // label_order
            // 
            this.label_order.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_order.Location = new System.Drawing.Point(471, 114);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(145, 97);
            this.label_order.TabIndex = 37;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(176, 215);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(40, 13);
            this.label_Price.TabIndex = 38;
            this.label_Price.Text = "Price:";
            // 
            // label_12ounce
            // 
            this.label_12ounce.AutoSize = true;
            this.label_12ounce.Location = new System.Drawing.Point(176, 239);
            this.label_12ounce.Name = "label_12ounce";
            this.label_12ounce.Size = new System.Drawing.Size(34, 13);
            this.label_12ounce.TabIndex = 39;
            this.label_12ounce.Text = "$3.00";
            // 
            // label_16ounce
            // 
            this.label_16ounce.AutoSize = true;
            this.label_16ounce.Location = new System.Drawing.Point(176, 265);
            this.label_16ounce.Name = "label_16ounce";
            this.label_16ounce.Size = new System.Drawing.Size(34, 13);
            this.label_16ounce.TabIndex = 40;
            this.label_16ounce.Text = "$3.50";
            // 
            // label_20ounce
            // 
            this.label_20ounce.AutoSize = true;
            this.label_20ounce.Location = new System.Drawing.Point(176, 292);
            this.label_20ounce.Name = "label_20ounce";
            this.label_20ounce.Size = new System.Drawing.Size(34, 13);
            this.label_20ounce.TabIndex = 41;
            this.label_20ounce.Text = "$4.00";
            // 
            // btn_clearOrder
            // 
            this.btn_clearOrder.AutoSize = true;
            this.btn_clearOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_clearOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearOrder.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_clearOrder.Location = new System.Drawing.Point(294, 370);
            this.btn_clearOrder.Name = "btn_clearOrder";
            this.btn_clearOrder.Size = new System.Drawing.Size(88, 23);
            this.btn_clearOrder.TabIndex = 42;
            this.btn_clearOrder.Text = "Clear Order";
            this.btn_clearOrder.UseVisualStyleBackColor = false;
            this.btn_clearOrder.Click += new System.EventHandler(this.btn_clearOrder_Click);
            // 
            // label_selectSmoothie
            // 
            this.label_selectSmoothie.AutoSize = true;
            this.label_selectSmoothie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectSmoothie.Location = new System.Drawing.Point(209, 152);
            this.label_selectSmoothie.Name = "label_selectSmoothie";
            this.label_selectSmoothie.Size = new System.Drawing.Size(103, 13);
            this.label_selectSmoothie.TabIndex = 43;
            this.label_selectSmoothie.Text = "Select Smoothie:";
            // 
            // btn_exit2
            // 
            this.btn_exit2.AutoSize = true;
            this.btn_exit2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_exit2.Location = new System.Drawing.Point(645, 27);
            this.btn_exit2.Name = "btn_exit2";
            this.btn_exit2.Size = new System.Drawing.Size(39, 23);
            this.btn_exit2.TabIndex = 44;
            this.btn_exit2.Text = "Exit";
            this.btn_exit2.UseVisualStyleBackColor = false;
            this.btn_exit2.Click += new System.EventHandler(this.btn_exit2_Click);
            // 
            // menuStrip_form2
            // 
            this.menuStrip_form2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.helpMenuItem});
            this.menuStrip_form2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_form2.Name = "menuStrip_form2";
            this.menuStrip_form2.Size = new System.Drawing.Size(684, 24);
            this.menuStrip_form2.TabIndex = 45;
            this.menuStrip_form2.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderSummaryMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // orderSummaryMenuItem
            // 
            this.orderSummaryMenuItem.Name = "orderSummaryMenuItem";
            this.orderSummaryMenuItem.Size = new System.Drawing.Size(154, 22);
            this.orderSummaryMenuItem.Text = "Daily Summary";
            this.orderSummaryMenuItem.Click += new System.EventHandler(this.orderSummaryMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completeOrderMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // completeOrderMenuItem
            // 
            this.completeOrderMenuItem.Name = "completeOrderMenuItem";
            this.completeOrderMenuItem.Size = new System.Drawing.Size(159, 22);
            this.completeOrderMenuItem.Text = "Complete Order";
            this.completeOrderMenuItem.Click += new System.EventHandler(this.completeOrderMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenuItem,
            this.colorMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "View";
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontMenuItem.Text = "Font";
            this.fontMenuItem.Click += new System.EventHandler(this.fontMenuItem_Click);
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorMenuItem.Text = "Color";
            this.colorMenuItem.Click += new System.EventHandler(this.colorMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(190, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Welcome to PSTCC Fitness Center Juice Bar!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(213, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pellissippi State University";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(684, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_form2);
            this.Controls.Add(this.btn_exit2);
            this.Controls.Add(this.label_selectSmoothie);
            this.Controls.Add(this.btn_clearOrder);
            this.Controls.Add(this.label_20ounce);
            this.Controls.Add(this.label_16ounce);
            this.Controls.Add(this.label_12ounce);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_order);
            this.Controls.Add(this.label_drinkType);
            this.Controls.Add(this.label_drink);
            this.Controls.Add(this.label_currentOrder);
            this.Controls.Add(this.btn_summary);
            this.Controls.Add(this.label_totalPriceContent);
            this.Controls.Add(this.label_20ou);
            this.Controls.Add(this.label_16ou);
            this.Controls.Add(this.label_12ou);
            this.Controls.Add(this.comboBox_drinkSelection);
            this.Controls.Add(this.comBox_20ou);
            this.Controls.Add(this.comBox_16ou);
            this.Controls.Add(this.comBox_12ou);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.btn_addToOrder);
            this.Controls.Add(this.lBox_additives);
            this.Controls.Add(this.label_additives);
            this.Controls.Add(this.label_drinkSize);
            this.Controls.Add(this.comBox_smoothieSelect);
            this.Controls.Add(this.comBox_juiceSelect);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Form1";
            this.Text = "Add To Order";
            this.menuStrip_form2.ResumeLayout(false);
            this.menuStrip_form2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comBox_juiceSelect;
        private System.Windows.Forms.ComboBox comBox_smoothieSelect;
        private System.Windows.Forms.Label label_drinkSize;
        private System.Windows.Forms.Label label_additives;
        private System.Windows.Forms.Button btn_addToOrder;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.ComboBox comBox_12ou;
        private System.Windows.Forms.ComboBox comBox_16ou;
        private System.Windows.Forms.ComboBox comBox_20ou;
        private System.Windows.Forms.ComboBox comboBox_drinkSelection;
        private System.Windows.Forms.Label label_12ou;
        private System.Windows.Forms.Label label_16ou;
        private System.Windows.Forms.Label label_20ou;
        private System.Windows.Forms.Label label_totalPriceContent;
        private System.Windows.Forms.Button btn_summary;
        private System.Windows.Forms.ListBox lBox_additives;
        private System.Windows.Forms.Label label_currentOrder;
        private System.Windows.Forms.Label label_drink;
        private System.Windows.Forms.Label label_drinkType;
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_12ounce;
        private System.Windows.Forms.Label label_16ounce;
        private System.Windows.Forms.Label label_20ounce;
        private System.Windows.Forms.Button btn_clearOrder;
        private System.Windows.Forms.Label label_selectSmoothie;
        private System.Windows.Forms.Button btn_exit2;
        private System.Windows.Forms.MenuStrip menuStrip_form2;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSummaryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}