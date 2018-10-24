namespace cSharpPizzaApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDateTime = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.grpPricing = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblSubtotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpOrderInformation = new System.Windows.Forms.GroupBox();
            this.lblOrderNumberCounter = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblMaxQuantity = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.grpPizzaToppings = new System.Windows.Forms.GroupBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkTurkey = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkSalami = new System.Windows.Forms.CheckBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grpPizzaSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.lblPizzaShop = new System.Windows.Forms.Label();
            this.picMeowmaMiaLogo = new System.Windows.Forms.PictureBox();
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mtxZipCodeEntry = new System.Windows.Forms.MaskedTextBox();
            this.cboStateEntry = new System.Windows.Forms.ComboBox();
            this.txtCityEntry = new System.Windows.Forms.TextBox();
            this.txtAddressEntry2 = new System.Windows.Forms.TextBox();
            this.txtAddressEntry1 = new System.Windows.Forms.TextBox();
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.mtxPhoneEntry = new System.Windows.Forms.MaskedTextBox();
            this.tmrDateTimeSource = new System.Windows.Forms.Timer(this.components);
            this.grpActions.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpPricing.SuspendLayout();
            this.grpOrderInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpPizzaToppings.SuspendLayout();
            this.grpPizzaSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMeowmaMiaLogo)).BeginInit();
            this.grpCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(435, 351);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 13);
            this.lblDateTime.TabIndex = 14;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.chkMute);
            this.grpActions.Controls.Add(this.btnClose);
            this.grpActions.Controls.Add(this.btnReset);
            this.grpActions.Controls.Add(this.btnAccept);
            this.grpActions.Controls.Add(this.btnPrice);
            this.grpActions.Location = new System.Drawing.Point(10, 376);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(560, 65);
            this.grpActions.TabIndex = 13;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(461, 32);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(50, 17);
            this.chkMute.TabIndex = 4;
            this.chkMute.Text = "&Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(221, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(114, 20);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 40);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(7, 20);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 40);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.cboPayment);
            this.grpPayment.Location = new System.Drawing.Point(414, 172);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(156, 65);
            this.grpPayment.TabIndex = 12;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment";
            // 
            // cboPayment
            // 
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Items.AddRange(new object[] {
            "CASH",
            "CHECK",
            "VISA",
            "MASTERCARD",
            "AMERICAN EXPRESS"});
            this.cboPayment.Location = new System.Drawing.Point(6, 25);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(144, 21);
            this.cboPayment.TabIndex = 0;
            this.cboPayment.Text = "VISA";
            // 
            // grpPricing
            // 
            this.grpPricing.Controls.Add(this.lblTotalAmount);
            this.grpPricing.Controls.Add(this.lblTaxAmount);
            this.grpPricing.Controls.Add(this.lblSubtotalAmount);
            this.grpPricing.Controls.Add(this.lblTotal);
            this.grpPricing.Controls.Add(this.lblTax);
            this.grpPricing.Controls.Add(this.lblSubtotal);
            this.grpPricing.Location = new System.Drawing.Point(414, 243);
            this.grpPricing.Name = "grpPricing";
            this.grpPricing.Size = new System.Drawing.Size(156, 100);
            this.grpPricing.TabIndex = 7;
            this.grpPricing.TabStop = false;
            this.grpPricing.Text = "Pricing";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(79, 76);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(34, 13);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "$0.00";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(79, 39);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(34, 13);
            this.lblTaxAmount.TabIndex = 0;
            this.lblTaxAmount.Text = "$0.00";
            // 
            // lblSubtotalAmount
            // 
            this.lblSubtotalAmount.AutoSize = true;
            this.lblSubtotalAmount.Location = new System.Drawing.Point(79, 16);
            this.lblSubtotalAmount.Name = "lblSubtotalAmount";
            this.lblSubtotalAmount.Size = new System.Drawing.Size(34, 13);
            this.lblSubtotalAmount.TabIndex = 0;
            this.lblSubtotalAmount.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 76);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(27, 39);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 0;
            this.lblTax.Text = "Tax";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(6, 16);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // grpOrderInformation
            // 
            this.grpOrderInformation.Controls.Add(this.lblOrderNumberCounter);
            this.grpOrderInformation.Controls.Add(this.lblOrderNumber);
            this.grpOrderInformation.Controls.Add(this.lblMaxQuantity);
            this.grpOrderInformation.Controls.Add(this.lblQuantity);
            this.grpOrderInformation.Controls.Add(this.nudQuantity);
            this.grpOrderInformation.Controls.Add(this.grpPizzaToppings);
            this.grpOrderInformation.Controls.Add(this.grpPizzaSize);
            this.grpOrderInformation.Location = new System.Drawing.Point(216, 50);
            this.grpOrderInformation.Name = "grpOrderInformation";
            this.grpOrderInformation.Size = new System.Drawing.Size(192, 320);
            this.grpOrderInformation.TabIndex = 10;
            this.grpOrderInformation.TabStop = false;
            this.grpOrderInformation.Text = "Order Information";
            // 
            // lblOrderNumberCounter
            // 
            this.lblOrderNumberCounter.AutoSize = true;
            this.lblOrderNumberCounter.Location = new System.Drawing.Point(127, 25);
            this.lblOrderNumberCounter.Name = "lblOrderNumberCounter";
            this.lblOrderNumberCounter.Size = new System.Drawing.Size(31, 13);
            this.lblOrderNumberCounter.TabIndex = 1;
            this.lblOrderNumberCounter.Text = "0000";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(6, 25);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(96, 13);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "ORDER NUMBER";
            // 
            // lblMaxQuantity
            // 
            this.lblMaxQuantity.AutoSize = true;
            this.lblMaxQuantity.Location = new System.Drawing.Point(121, 115);
            this.lblMaxQuantity.Name = "lblMaxQuantity";
            this.lblMaxQuantity.Size = new System.Drawing.Size(42, 13);
            this.lblMaxQuantity.TabIndex = 0;
            this.lblMaxQuantity.Text = "Max 10";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(119, 71);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "&Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(124, 88);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(36, 20);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpPizzaToppings
            // 
            this.grpPizzaToppings.Controls.Add(this.chkBacon);
            this.grpPizzaToppings.Controls.Add(this.chkTurkey);
            this.grpPizzaToppings.Controls.Add(this.chkChicken);
            this.grpPizzaToppings.Controls.Add(this.chkSalami);
            this.grpPizzaToppings.Controls.Add(this.chkHamburger);
            this.grpPizzaToppings.Controls.Add(this.chkSausage);
            this.grpPizzaToppings.Controls.Add(this.chkPepperoni);
            this.grpPizzaToppings.Location = new System.Drawing.Point(6, 135);
            this.grpPizzaToppings.Name = "grpPizzaToppings";
            this.grpPizzaToppings.Size = new System.Drawing.Size(180, 179);
            this.grpPizzaToppings.TabIndex = 4;
            this.grpPizzaToppings.TabStop = false;
            this.grpPizzaToppings.Text = "Meatza Toppings";
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(6, 157);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(57, 17);
            this.chkBacon.TabIndex = 6;
            this.chkBacon.Text = "&Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkTurkey
            // 
            this.chkTurkey.AutoSize = true;
            this.chkTurkey.Location = new System.Drawing.Point(6, 134);
            this.chkTurkey.Name = "chkTurkey";
            this.chkTurkey.Size = new System.Drawing.Size(59, 17);
            this.chkTurkey.TabIndex = 5;
            this.chkTurkey.Text = "&Turkey";
            this.chkTurkey.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(6, 111);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(65, 17);
            this.chkChicken.TabIndex = 4;
            this.chkChicken.Text = "&Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkSalami
            // 
            this.chkSalami.AutoSize = true;
            this.chkSalami.Location = new System.Drawing.Point(6, 88);
            this.chkSalami.Name = "chkSalami";
            this.chkSalami.Size = new System.Drawing.Size(57, 17);
            this.chkSalami.TabIndex = 3;
            this.chkSalami.Text = "S&alami";
            this.chkSalami.UseVisualStyleBackColor = true;
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Location = new System.Drawing.Point(6, 65);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(78, 17);
            this.chkHamburger.TabIndex = 2;
            this.chkHamburger.Text = "&Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(6, 42);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(68, 17);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "&Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 19);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "&Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // grpPizzaSize
            // 
            this.grpPizzaSize.Controls.Add(this.radLarge);
            this.grpPizzaSize.Controls.Add(this.radMedium);
            this.grpPizzaSize.Controls.Add(this.radSmall);
            this.grpPizzaSize.Location = new System.Drawing.Point(6, 53);
            this.grpPizzaSize.Name = "grpPizzaSize";
            this.grpPizzaSize.Size = new System.Drawing.Size(87, 83);
            this.grpPizzaSize.TabIndex = 2;
            this.grpPizzaSize.TabStop = false;
            this.grpPizzaSize.Text = "Meatza Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(6, 58);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "&Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Checked = true;
            this.radMedium.Location = new System.Drawing.Point(6, 38);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "&Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(6, 18);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(50, 17);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "&Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // lblPizzaShop
            // 
            this.lblPizzaShop.AutoSize = true;
            this.lblPizzaShop.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaShop.ForeColor = System.Drawing.Color.Red;
            this.lblPizzaShop.Location = new System.Drawing.Point(10, 12);
            this.lblPizzaShop.Name = "lblPizzaShop";
            this.lblPizzaShop.Size = new System.Drawing.Size(344, 39);
            this.lblPizzaShop.TabIndex = 8;
            this.lblPizzaShop.Text = "Meowma Meatza Pizzaria";
            // 
            // picMeowmaMiaLogo
            // 
            this.picMeowmaMiaLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMeowmaMiaLogo.BackgroundImage")));
            this.picMeowmaMiaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMeowmaMiaLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMeowmaMiaLogo.Image = ((System.Drawing.Image)(resources.GetObject("picMeowmaMiaLogo.Image")));
            this.picMeowmaMiaLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMeowmaMiaLogo.InitialImage")));
            this.picMeowmaMiaLogo.Location = new System.Drawing.Point(414, 50);
            this.picMeowmaMiaLogo.Name = "picMeowmaMiaLogo";
            this.picMeowmaMiaLogo.Size = new System.Drawing.Size(156, 117);
            this.picMeowmaMiaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMeowmaMiaLogo.TabIndex = 11;
            this.picMeowmaMiaLogo.TabStop = false;
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.lblZipCode);
            this.grpCustomerInformation.Controls.Add(this.lblState);
            this.grpCustomerInformation.Controls.Add(this.lblCity);
            this.grpCustomerInformation.Controls.Add(this.lblAddress2);
            this.grpCustomerInformation.Controls.Add(this.lblAddress1);
            this.grpCustomerInformation.Controls.Add(this.lblName);
            this.grpCustomerInformation.Controls.Add(this.lblPhone);
            this.grpCustomerInformation.Controls.Add(this.mtxZipCodeEntry);
            this.grpCustomerInformation.Controls.Add(this.cboStateEntry);
            this.grpCustomerInformation.Controls.Add(this.txtCityEntry);
            this.grpCustomerInformation.Controls.Add(this.txtAddressEntry2);
            this.grpCustomerInformation.Controls.Add(this.txtAddressEntry1);
            this.grpCustomerInformation.Controls.Add(this.txtNameEntry);
            this.grpCustomerInformation.Controls.Add(this.mtxPhoneEntry);
            this.grpCustomerInformation.Location = new System.Drawing.Point(10, 50);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(200, 320);
            this.grpCustomerInformation.TabIndex = 9;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblZipCode.Location = new System.Drawing.Point(21, 287);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(53, 13);
            this.lblZipCode.TabIndex = 13;
            this.lblZipCode.Text = "&Zip Code:";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblState.Location = new System.Drawing.Point(39, 243);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "&State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCity.Location = new System.Drawing.Point(47, 200);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "&City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddress2.Location = new System.Drawing.Point(20, 157);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address&2:";
            this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddress1.Location = new System.Drawing.Point(20, 115);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address&1:";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(36, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "&Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhone.Location = new System.Drawing.Point(33, 28);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "&Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxZipCodeEntry
            // 
            this.mtxZipCodeEntry.Location = new System.Drawing.Point(75, 284);
            this.mtxZipCodeEntry.Mask = "00000-9999";
            this.mtxZipCodeEntry.Name = "mtxZipCodeEntry";
            this.mtxZipCodeEntry.Size = new System.Drawing.Size(68, 20);
            this.mtxZipCodeEntry.TabIndex = 13;
            // 
            // cboStateEntry
            // 
            this.cboStateEntry.FormattingEnabled = true;
            this.cboStateEntry.Location = new System.Drawing.Point(75, 240);
            this.cboStateEntry.Name = "cboStateEntry";
            this.cboStateEntry.Size = new System.Drawing.Size(42, 21);
            this.cboStateEntry.TabIndex = 11;
            // 
            // txtCityEntry
            // 
            this.txtCityEntry.Location = new System.Drawing.Point(75, 197);
            this.txtCityEntry.MaxLength = 25;
            this.txtCityEntry.Name = "txtCityEntry";
            this.txtCityEntry.Size = new System.Drawing.Size(115, 20);
            this.txtCityEntry.TabIndex = 9;
            // 
            // txtAddressEntry2
            // 
            this.txtAddressEntry2.Location = new System.Drawing.Point(75, 154);
            this.txtAddressEntry2.MaxLength = 25;
            this.txtAddressEntry2.Name = "txtAddressEntry2";
            this.txtAddressEntry2.Size = new System.Drawing.Size(115, 20);
            this.txtAddressEntry2.TabIndex = 7;
            // 
            // txtAddressEntry1
            // 
            this.txtAddressEntry1.Location = new System.Drawing.Point(75, 111);
            this.txtAddressEntry1.MaxLength = 25;
            this.txtAddressEntry1.Name = "txtAddressEntry1";
            this.txtAddressEntry1.Size = new System.Drawing.Size(115, 20);
            this.txtAddressEntry1.TabIndex = 5;
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.Location = new System.Drawing.Point(75, 68);
            this.txtNameEntry.MaxLength = 25;
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(115, 20);
            this.txtNameEntry.TabIndex = 3;
            // 
            // mtxPhoneEntry
            // 
            this.mtxPhoneEntry.Location = new System.Drawing.Point(75, 25);
            this.mtxPhoneEntry.Mask = "(999) 000-0000";
            this.mtxPhoneEntry.Name = "mtxPhoneEntry";
            this.mtxPhoneEntry.Size = new System.Drawing.Size(82, 20);
            this.mtxPhoneEntry.TabIndex = 1;
            // tmrDateTimeSource
            // 
            this.tmrDateTimeSource.Tick += new System.EventHandler(this.tmrDateTimeSource_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpPricing);
            this.Controls.Add(this.grpOrderInformation);
            this.Controls.Add(this.lblPizzaShop);
            this.Controls.Add(this.picMeowmaMiaLogo);
            this.Controls.Add(this.grpCustomerInformation);
            this.Name = "Form1";
            this.Text = "Meowma Meatza Pizzaria";
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPricing.ResumeLayout(false);
            this.grpPricing.PerformLayout();
            this.grpOrderInformation.ResumeLayout(false);
            this.grpOrderInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpPizzaToppings.ResumeLayout(false);
            this.grpPizzaToppings.PerformLayout();
            this.grpPizzaSize.ResumeLayout(false);
            this.grpPizzaSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMeowmaMiaLogo)).EndInit();
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblDateTime;
        internal System.Windows.Forms.GroupBox grpActions;
        internal System.Windows.Forms.CheckBox chkMute;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnAccept;
        internal System.Windows.Forms.Button btnPrice;
        internal System.Windows.Forms.GroupBox grpPayment;
        internal System.Windows.Forms.ComboBox cboPayment;
        internal System.Windows.Forms.GroupBox grpPricing;
        internal System.Windows.Forms.Label lblTotalAmount;
        internal System.Windows.Forms.Label lblTaxAmount;
        internal System.Windows.Forms.Label lblSubtotalAmount;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.GroupBox grpOrderInformation;
        internal System.Windows.Forms.Label lblOrderNumberCounter;
        internal System.Windows.Forms.Label lblOrderNumber;
        internal System.Windows.Forms.Label lblMaxQuantity;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.NumericUpDown nudQuantity;
        internal System.Windows.Forms.GroupBox grpPizzaToppings;
        internal System.Windows.Forms.CheckBox chkBacon;
        internal System.Windows.Forms.CheckBox chkTurkey;
        internal System.Windows.Forms.CheckBox chkChicken;
        internal System.Windows.Forms.CheckBox chkSalami;
        internal System.Windows.Forms.CheckBox chkHamburger;
        internal System.Windows.Forms.CheckBox chkSausage;
        internal System.Windows.Forms.CheckBox chkPepperoni;
        internal System.Windows.Forms.GroupBox grpPizzaSize;
        internal System.Windows.Forms.RadioButton radLarge;
        internal System.Windows.Forms.RadioButton radMedium;
        internal System.Windows.Forms.RadioButton radSmall;
        internal System.Windows.Forms.Label lblPizzaShop;
        internal System.Windows.Forms.PictureBox picMeowmaMiaLogo;
        internal System.Windows.Forms.GroupBox grpCustomerInformation;
        internal System.Windows.Forms.Label lblZipCode;
        internal System.Windows.Forms.Label lblState;
        internal System.Windows.Forms.Label lblCity;
        internal System.Windows.Forms.Label lblAddress2;
        internal System.Windows.Forms.Label lblAddress1;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.MaskedTextBox mtxZipCodeEntry;
        internal System.Windows.Forms.ComboBox cboStateEntry;
        internal System.Windows.Forms.TextBox txtCityEntry;
        internal System.Windows.Forms.TextBox txtAddressEntry2;
        internal System.Windows.Forms.TextBox txtAddressEntry1;
        internal System.Windows.Forms.TextBox txtNameEntry;
        internal System.Windows.Forms.MaskedTextBox mtxPhoneEntry;
        private System.Windows.Forms.Timer tmrDateTimeSource;
    }
}

