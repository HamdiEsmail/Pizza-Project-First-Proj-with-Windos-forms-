namespace Pizza_Project
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
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labMakeYourPizza = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.LabTotalPrice1 = new System.Windows.Forms.Label();
            this.LabWhereToEat1 = new System.Windows.Forms.Label();
            this.labCrustType1 = new System.Windows.Forms.Label();
            this.labTopping1 = new System.Windows.Forms.Label();
            this.labSize1 = new System.Windows.Forms.Label();
            this.labSize2 = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labCrust = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbMashrooms = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.gbParent = new System.Windows.Forms.GroupBox();
            this.gbOrderSummary.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrderPizza.Location = new System.Drawing.Point(275, 424);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(93, 25);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Crimson;
            this.btnResetForm.Location = new System.Drawing.Point(400, 424);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(98, 25);
            this.btnResetForm.TabIndex = 5;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // labMakeYourPizza
            // 
            this.labMakeYourPizza.AutoSize = true;
            this.labMakeYourPizza.Font = new System.Drawing.Font("Arial Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMakeYourPizza.ForeColor = System.Drawing.Color.Firebrick;
            this.labMakeYourPizza.Location = new System.Drawing.Point(158, 18);
            this.labMakeYourPizza.Name = "labMakeYourPizza";
            this.labMakeYourPizza.Size = new System.Drawing.Size(455, 68);
            this.labMakeYourPizza.TabIndex = 6;
            this.labMakeYourPizza.Text = "Make Your Pizza";
            this.labMakeYourPizza.Click += new System.EventHandler(this.labMakeYourPizza_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbOrderSummary.Controls.Add(this.LabTotalPrice1);
            this.gbOrderSummary.Controls.Add(this.LabWhereToEat1);
            this.gbOrderSummary.Controls.Add(this.labCrustType1);
            this.gbOrderSummary.Controls.Add(this.labTopping1);
            this.gbOrderSummary.Controls.Add(this.labSize1);
            this.gbOrderSummary.Controls.Add(this.labSize2);
            this.gbOrderSummary.Controls.Add(this.labTotalPrice);
            this.gbOrderSummary.Controls.Add(this.labWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labCrust);
            this.gbOrderSummary.Controls.Add(this.labToppings);
            this.gbOrderSummary.Controls.Add(this.labSize);
            this.gbOrderSummary.Location = new System.Drawing.Point(559, 103);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(196, 321);
            this.gbOrderSummary.TabIndex = 7;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // LabTotalPrice1
            // 
            this.LabTotalPrice1.AutoSize = true;
            this.LabTotalPrice1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalPrice1.ForeColor = System.Drawing.Color.SeaGreen;
            this.LabTotalPrice1.Location = new System.Drawing.Point(80, 246);
            this.LabTotalPrice1.Name = "LabTotalPrice1";
            this.LabTotalPrice1.Size = new System.Drawing.Size(32, 25);
            this.LabTotalPrice1.TabIndex = 10;
            this.LabTotalPrice1.Text = "$0";
            this.LabTotalPrice1.Click += new System.EventHandler(this.TotalPrice_Click);
            // 
            // LabWhereToEat1
            // 
            this.LabWhereToEat1.AutoSize = true;
            this.LabWhereToEat1.Location = new System.Drawing.Point(52, 189);
            this.LabWhereToEat1.Name = "LabWhereToEat1";
            this.LabWhereToEat1.Size = new System.Drawing.Size(44, 13);
            this.LabWhereToEat1.TabIndex = 9;
            this.LabWhereToEat1.Text = "Nothing";
            // 
            // labCrustType1
            // 
            this.labCrustType1.AutoSize = true;
            this.labCrustType1.Location = new System.Drawing.Point(124, 135);
            this.labCrustType1.Name = "labCrustType1";
            this.labCrustType1.Size = new System.Drawing.Size(44, 13);
            this.labCrustType1.TabIndex = 8;
            this.labCrustType1.Text = "Nothing";
            // 
            // labTopping1
            // 
            this.labTopping1.AutoSize = true;
            this.labTopping1.Location = new System.Drawing.Point(25, 85);
            this.labTopping1.Name = "labTopping1";
            this.labTopping1.Size = new System.Drawing.Size(44, 13);
            this.labTopping1.TabIndex = 7;
            this.labTopping1.Text = "Nothing";
            this.labTopping1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labSize1
            // 
            this.labSize1.AutoSize = true;
            this.labSize1.Location = new System.Drawing.Point(74, 36);
            this.labSize1.Name = "labSize1";
            this.labSize1.Size = new System.Drawing.Size(44, 13);
            this.labSize1.TabIndex = 6;
            this.labSize1.Text = "Nothing";
            // 
            // labSize2
            // 
            this.labSize2.AutoSize = true;
            this.labSize2.Location = new System.Drawing.Point(74, 38);
            this.labSize2.Name = "labSize2";
            this.labSize2.Size = new System.Drawing.Size(0, 13);
            this.labSize2.TabIndex = 5;
            this.labSize2.Visible = false;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.Location = new System.Drawing.Point(23, 216);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(103, 21);
            this.labTotalPrice.TabIndex = 4;
            this.labTotalPrice.Text = "Total Price : ";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.Location = new System.Drawing.Point(23, 168);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(119, 21);
            this.labWhereToEat.TabIndex = 3;
            this.labWhereToEat.Text = "Where To Eat: ";
            // 
            // labCrust
            // 
            this.labCrust.AutoSize = true;
            this.labCrust.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrust.Location = new System.Drawing.Point(24, 131);
            this.labCrust.Name = "labCrust";
            this.labCrust.Size = new System.Drawing.Size(94, 21);
            this.labCrust.TabIndex = 2;
            this.labCrust.Text = "Crust Type:";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.Location = new System.Drawing.Point(23, 63);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(85, 21);
            this.labToppings.TabIndex = 1;
            this.labToppings.Text = "Toppings:";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(23, 33);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(45, 21);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size:";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Black;
            this.gbSize.Location = new System.Drawing.Point(11, 13);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(111, 142);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(10, 37);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(52, 18);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.btnSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(6, 67);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(67, 18);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "15";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.btnMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(7, 97);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(53, 18);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.btnLarge_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThick);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(5, 207);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(117, 120);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            this.gbCrustType.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(16, 43);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(46, 17);
            this.rbThin.TabIndex = 2;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "10";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(16, 75);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(52, 17);
            this.rbThick.TabIndex = 3;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "15";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rdThick_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.cbGreenPeppers);
            this.gbToppings.Controls.Add(this.cbOlives);
            this.gbToppings.Controls.Add(this.cbOnion);
            this.gbToppings.Controls.Add(this.cbTomatoes);
            this.gbToppings.Controls.Add(this.cbMashrooms);
            this.gbToppings.Controls.Add(this.cbExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(205, 13);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(250, 131);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.gbToppings_Enter);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraCheese.Location = new System.Drawing.Point(26, 29);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(92, 20);
            this.cbExtraCheese.TabIndex = 0;
            this.cbExtraCheese.Tag = "5";
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cbExtraCheese_CheckedChanged);
            // 
            // cbMashrooms
            // 
            this.cbMashrooms.AutoSize = true;
            this.cbMashrooms.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMashrooms.Location = new System.Drawing.Point(26, 65);
            this.cbMashrooms.Name = "cbMashrooms";
            this.cbMashrooms.Size = new System.Drawing.Size(88, 20);
            this.cbMashrooms.TabIndex = 1;
            this.cbMashrooms.Tag = "8";
            this.cbMashrooms.Text = "Mashrooms";
            this.cbMashrooms.UseVisualStyleBackColor = true;
            this.cbMashrooms.CheckedChanged += new System.EventHandler(this.cbMashrooms_CheckedChanged);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTomatoes.Location = new System.Drawing.Point(26, 99);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(77, 20);
            this.cbTomatoes.TabIndex = 2;
            this.cbTomatoes.Tag = "2";
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnion.Location = new System.Drawing.Point(138, 27);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(59, 20);
            this.cbOnion.TabIndex = 3;
            this.cbOnion.Tag = "5";
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(138, 63);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(58, 20);
            this.cbOlives.TabIndex = 4;
            this.cbOlives.Tag = "1";
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGreenPeppers.Location = new System.Drawing.Point(138, 97);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(102, 20);
            this.cbGreenPeppers.TabIndex = 5;
            this.cbGreenPeppers.Tag = "1";
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(205, 219);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(250, 88);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(16, 41);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(53, 17);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "10";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(111, 41);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "0";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // gbParent
            // 
            this.gbParent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbParent.Controls.Add(this.gbWhereToEat);
            this.gbParent.Controls.Add(this.gbToppings);
            this.gbParent.Controls.Add(this.gbCrustType);
            this.gbParent.Controls.Add(this.gbSize);
            this.gbParent.Location = new System.Drawing.Point(43, 103);
            this.gbParent.Name = "gbParent";
            this.gbParent.Size = new System.Drawing.Size(501, 321);
            this.gbParent.TabIndex = 8;
            this.gbParent.TabStop = false;
            this.gbParent.Enter += new System.EventHandler(this.none_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 478);
            this.Controls.Add(this.gbParent);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.labMakeYourPizza);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Name = "Form1";
            this.Text = "Pizza Order ";
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbParent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label labMakeYourPizza;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label labCrust;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labSize2;
        private System.Windows.Forms.Label labTopping1;
        private System.Windows.Forms.Label labSize1;
        private System.Windows.Forms.Label LabTotalPrice1;
        private System.Windows.Forms.Label LabWhereToEat1;
        private System.Windows.Forms.Label labCrustType1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbMashrooms;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbParent;
    }
}

