<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeowmaMeatzaPizza
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMeowmaMeatzaPizza))
        Me.grpCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.mtxZipCodeEntry = New System.Windows.Forms.MaskedTextBox()
        Me.cboStateEntry = New System.Windows.Forms.ComboBox()
        Me.txtCityEntry = New System.Windows.Forms.TextBox()
        Me.txtAddressEntry2 = New System.Windows.Forms.TextBox()
        Me.txtAddressEntry1 = New System.Windows.Forms.TextBox()
        Me.txtNameEntry = New System.Windows.Forms.TextBox()
        Me.mtxPhoneEntry = New System.Windows.Forms.MaskedTextBox()
        Me.picMeowmaMiaLogo = New System.Windows.Forms.PictureBox()
        Me.lblPizzaShop = New System.Windows.Forms.Label()
        Me.grpOrderInformation = New System.Windows.Forms.GroupBox()
        Me.lblOrderNumberCounter = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblMaxQuantity = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.grpPizzaToppings = New System.Windows.Forms.GroupBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkTurkey = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkSalami = New System.Windows.Forms.CheckBox()
        Me.chkHamburger = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.grpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpPricing = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblSubtotalAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.chkMute = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.tmrDateTimeSource = New System.Windows.Forms.Timer(Me.components)
        Me.grpCustomerInformation.SuspendLayout()
        CType(Me.picMeowmaMiaLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderInformation.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPizzaToppings.SuspendLayout()
        Me.grpPizzaSize.SuspendLayout()
        Me.grpPricing.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomerInformation
        '
        Me.grpCustomerInformation.Controls.Add(Me.lblZipCode)
        Me.grpCustomerInformation.Controls.Add(Me.lblState)
        Me.grpCustomerInformation.Controls.Add(Me.lblCity)
        Me.grpCustomerInformation.Controls.Add(Me.lblAddress2)
        Me.grpCustomerInformation.Controls.Add(Me.lblAddress1)
        Me.grpCustomerInformation.Controls.Add(Me.lblName)
        Me.grpCustomerInformation.Controls.Add(Me.lblPhone)
        Me.grpCustomerInformation.Controls.Add(Me.mtxZipCodeEntry)
        Me.grpCustomerInformation.Controls.Add(Me.cboStateEntry)
        Me.grpCustomerInformation.Controls.Add(Me.txtCityEntry)
        Me.grpCustomerInformation.Controls.Add(Me.txtAddressEntry2)
        Me.grpCustomerInformation.Controls.Add(Me.txtAddressEntry1)
        Me.grpCustomerInformation.Controls.Add(Me.txtNameEntry)
        Me.grpCustomerInformation.Controls.Add(Me.mtxPhoneEntry)
        Me.grpCustomerInformation.Location = New System.Drawing.Point(12, 47)
        Me.grpCustomerInformation.Name = "grpCustomerInformation"
        Me.grpCustomerInformation.Size = New System.Drawing.Size(200, 320)
        Me.grpCustomerInformation.TabIndex = 0
        Me.grpCustomerInformation.TabStop = False
        Me.grpCustomerInformation.Text = "Customer Information"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblZipCode.Location = New System.Drawing.Point(21, 287)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(53, 13)
        Me.lblZipCode.TabIndex = 13
        Me.lblZipCode.Text = "&Zip Code:"
        Me.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblState.Location = New System.Drawing.Point(39, 243)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "&State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCity.Location = New System.Drawing.Point(47, 200)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 8
        Me.lblCity.Text = "&City:"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAddress2.Location = New System.Drawing.Point(20, 157)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(54, 13)
        Me.lblAddress2.TabIndex = 6
        Me.lblAddress2.Text = "Address&2:"
        Me.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAddress1.Location = New System.Drawing.Point(20, 115)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(54, 13)
        Me.lblAddress1.TabIndex = 4
        Me.lblAddress1.Text = "Address&1:"
        Me.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblName.Location = New System.Drawing.Point(36, 71)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "&Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPhone.Location = New System.Drawing.Point(33, 28)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "&Phone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mtxZipCodeEntry
        '
        Me.mtxZipCodeEntry.Location = New System.Drawing.Point(75, 284)
        Me.mtxZipCodeEntry.Mask = "00000-9999"
        Me.mtxZipCodeEntry.Name = "mtxZipCodeEntry"
        Me.mtxZipCodeEntry.Size = New System.Drawing.Size(68, 20)
        Me.mtxZipCodeEntry.TabIndex = 13
        '
        'cboStateEntry
        '
        Me.cboStateEntry.FormattingEnabled = True
        Me.cboStateEntry.Location = New System.Drawing.Point(75, 240)
        Me.cboStateEntry.Name = "cboStateEntry"
        Me.cboStateEntry.Size = New System.Drawing.Size(42, 21)
        Me.cboStateEntry.TabIndex = 11
        '
        'txtCityEntry
        '
        Me.txtCityEntry.Location = New System.Drawing.Point(75, 197)
        Me.txtCityEntry.MaxLength = 25
        Me.txtCityEntry.Name = "txtCityEntry"
        Me.txtCityEntry.Size = New System.Drawing.Size(115, 20)
        Me.txtCityEntry.TabIndex = 9
        '
        'txtAddressEntry2
        '
        Me.txtAddressEntry2.Location = New System.Drawing.Point(75, 154)
        Me.txtAddressEntry2.MaxLength = 25
        Me.txtAddressEntry2.Name = "txtAddressEntry2"
        Me.txtAddressEntry2.Size = New System.Drawing.Size(115, 20)
        Me.txtAddressEntry2.TabIndex = 7
        '
        'txtAddressEntry1
        '
        Me.txtAddressEntry1.Location = New System.Drawing.Point(75, 111)
        Me.txtAddressEntry1.MaxLength = 25
        Me.txtAddressEntry1.Name = "txtAddressEntry1"
        Me.txtAddressEntry1.Size = New System.Drawing.Size(115, 20)
        Me.txtAddressEntry1.TabIndex = 5
        '
        'txtNameEntry
        '
        Me.txtNameEntry.Location = New System.Drawing.Point(75, 68)
        Me.txtNameEntry.MaxLength = 25
        Me.txtNameEntry.Name = "txtNameEntry"
        Me.txtNameEntry.Size = New System.Drawing.Size(115, 20)
        Me.txtNameEntry.TabIndex = 3
        '
        'mtxPhoneEntry
        '
        Me.mtxPhoneEntry.Location = New System.Drawing.Point(75, 25)
        Me.mtxPhoneEntry.Mask = "(999) 000-0000"
        Me.mtxPhoneEntry.Name = "mtxPhoneEntry"
        Me.mtxPhoneEntry.Size = New System.Drawing.Size(82, 20)
        Me.mtxPhoneEntry.TabIndex = 1
        '
        'picMeowmaMiaLogo
        '
        Me.picMeowmaMiaLogo.BackgroundImage = CType(resources.GetObject("picMeowmaMiaLogo.BackgroundImage"), System.Drawing.Image)
        Me.picMeowmaMiaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMeowmaMiaLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMeowmaMiaLogo.Image = CType(resources.GetObject("picMeowmaMiaLogo.Image"), System.Drawing.Image)
        Me.picMeowmaMiaLogo.InitialImage = CType(resources.GetObject("picMeowmaMiaLogo.InitialImage"), System.Drawing.Image)
        Me.picMeowmaMiaLogo.Location = New System.Drawing.Point(416, 47)
        Me.picMeowmaMiaLogo.Name = "picMeowmaMiaLogo"
        Me.picMeowmaMiaLogo.Size = New System.Drawing.Size(156, 117)
        Me.picMeowmaMiaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMeowmaMiaLogo.TabIndex = 1
        Me.picMeowmaMiaLogo.TabStop = False
        '
        'lblPizzaShop
        '
        Me.lblPizzaShop.AutoSize = True
        Me.lblPizzaShop.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaShop.ForeColor = System.Drawing.Color.Red
        Me.lblPizzaShop.Location = New System.Drawing.Point(12, 9)
        Me.lblPizzaShop.Name = "lblPizzaShop"
        Me.lblPizzaShop.Size = New System.Drawing.Size(344, 39)
        Me.lblPizzaShop.TabIndex = 0
        Me.lblPizzaShop.Text = "Meowma Meatza Pizzaria"
        '
        'grpOrderInformation
        '
        Me.grpOrderInformation.Controls.Add(Me.lblOrderNumberCounter)
        Me.grpOrderInformation.Controls.Add(Me.lblOrderNumber)
        Me.grpOrderInformation.Controls.Add(Me.lblMaxQuantity)
        Me.grpOrderInformation.Controls.Add(Me.lblQuantity)
        Me.grpOrderInformation.Controls.Add(Me.nudQuantity)
        Me.grpOrderInformation.Controls.Add(Me.grpPizzaToppings)
        Me.grpOrderInformation.Controls.Add(Me.grpPizzaSize)
        Me.grpOrderInformation.Location = New System.Drawing.Point(218, 47)
        Me.grpOrderInformation.Name = "grpOrderInformation"
        Me.grpOrderInformation.Size = New System.Drawing.Size(192, 320)
        Me.grpOrderInformation.TabIndex = 1
        Me.grpOrderInformation.TabStop = False
        Me.grpOrderInformation.Text = "Order Information"
        '
        'lblOrderNumberCounter
        '
        Me.lblOrderNumberCounter.AutoSize = True
        Me.lblOrderNumberCounter.Location = New System.Drawing.Point(127, 25)
        Me.lblOrderNumberCounter.Name = "lblOrderNumberCounter"
        Me.lblOrderNumberCounter.Size = New System.Drawing.Size(31, 13)
        Me.lblOrderNumberCounter.TabIndex = 1
        Me.lblOrderNumberCounter.Text = "0000"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(6, 25)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(96, 13)
        Me.lblOrderNumber.TabIndex = 0
        Me.lblOrderNumber.Text = "ORDER NUMBER"
        '
        'lblMaxQuantity
        '
        Me.lblMaxQuantity.AutoSize = True
        Me.lblMaxQuantity.Location = New System.Drawing.Point(121, 115)
        Me.lblMaxQuantity.Name = "lblMaxQuantity"
        Me.lblMaxQuantity.Size = New System.Drawing.Size(42, 13)
        Me.lblMaxQuantity.TabIndex = 0
        Me.lblMaxQuantity.Text = "Max 10"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(119, 71)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "&Quantity"
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(124, 88)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(36, 20)
        Me.nudQuantity.TabIndex = 2
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpPizzaToppings
        '
        Me.grpPizzaToppings.Controls.Add(Me.chkBacon)
        Me.grpPizzaToppings.Controls.Add(Me.chkTurkey)
        Me.grpPizzaToppings.Controls.Add(Me.chkChicken)
        Me.grpPizzaToppings.Controls.Add(Me.chkSalami)
        Me.grpPizzaToppings.Controls.Add(Me.chkHamburger)
        Me.grpPizzaToppings.Controls.Add(Me.chkSausage)
        Me.grpPizzaToppings.Controls.Add(Me.chkPepperoni)
        Me.grpPizzaToppings.Location = New System.Drawing.Point(6, 135)
        Me.grpPizzaToppings.Name = "grpPizzaToppings"
        Me.grpPizzaToppings.Size = New System.Drawing.Size(180, 179)
        Me.grpPizzaToppings.TabIndex = 4
        Me.grpPizzaToppings.TabStop = False
        Me.grpPizzaToppings.Text = "Meatza Toppings"
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(6, 157)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(57, 17)
        Me.chkBacon.TabIndex = 6
        Me.chkBacon.Text = "&Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkTurkey
        '
        Me.chkTurkey.AutoSize = True
        Me.chkTurkey.Location = New System.Drawing.Point(6, 134)
        Me.chkTurkey.Name = "chkTurkey"
        Me.chkTurkey.Size = New System.Drawing.Size(59, 17)
        Me.chkTurkey.TabIndex = 5
        Me.chkTurkey.Text = "&Turkey"
        Me.chkTurkey.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.Location = New System.Drawing.Point(6, 111)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(65, 17)
        Me.chkChicken.TabIndex = 4
        Me.chkChicken.Text = "&Chicken"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkSalami
        '
        Me.chkSalami.AutoSize = True
        Me.chkSalami.Location = New System.Drawing.Point(6, 88)
        Me.chkSalami.Name = "chkSalami"
        Me.chkSalami.Size = New System.Drawing.Size(57, 17)
        Me.chkSalami.TabIndex = 3
        Me.chkSalami.Text = "S&alami"
        Me.chkSalami.UseVisualStyleBackColor = True
        '
        'chkHamburger
        '
        Me.chkHamburger.AutoSize = True
        Me.chkHamburger.Location = New System.Drawing.Point(6, 65)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(78, 17)
        Me.chkHamburger.TabIndex = 2
        Me.chkHamburger.Text = "&Hamburger"
        Me.chkHamburger.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(6, 42)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(68, 17)
        Me.chkSausage.TabIndex = 1
        Me.chkSausage.Text = "&Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(6, 19)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chkPepperoni.TabIndex = 0
        Me.chkPepperoni.Text = "&Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'grpPizzaSize
        '
        Me.grpPizzaSize.Controls.Add(Me.radLarge)
        Me.grpPizzaSize.Controls.Add(Me.radMedium)
        Me.grpPizzaSize.Controls.Add(Me.radSmall)
        Me.grpPizzaSize.Location = New System.Drawing.Point(6, 53)
        Me.grpPizzaSize.Name = "grpPizzaSize"
        Me.grpPizzaSize.Size = New System.Drawing.Size(87, 83)
        Me.grpPizzaSize.TabIndex = 2
        Me.grpPizzaSize.TabStop = False
        Me.grpPizzaSize.Text = "Meatza Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 58)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "&Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Checked = True
        Me.radMedium.Location = New System.Drawing.Point(6, 38)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "&Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(6, 18)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "&Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpPricing
        '
        Me.grpPricing.Controls.Add(Me.lblTotalAmount)
        Me.grpPricing.Controls.Add(Me.lblTaxAmount)
        Me.grpPricing.Controls.Add(Me.lblSubtotalAmount)
        Me.grpPricing.Controls.Add(Me.lblTotal)
        Me.grpPricing.Controls.Add(Me.lblTax)
        Me.grpPricing.Controls.Add(Me.lblSubtotal)
        Me.grpPricing.Location = New System.Drawing.Point(416, 240)
        Me.grpPricing.Name = "grpPricing"
        Me.grpPricing.Size = New System.Drawing.Size(156, 100)
        Me.grpPricing.TabIndex = 0
        Me.grpPricing.TabStop = False
        Me.grpPricing.Text = "Pricing"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(79, 76)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalAmount.TabIndex = 0
        Me.lblTotalAmount.Text = "$0.00"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Location = New System.Drawing.Point(79, 39)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(34, 13)
        Me.lblTaxAmount.TabIndex = 0
        Me.lblTaxAmount.Text = "$0.00"
        '
        'lblSubtotalAmount
        '
        Me.lblSubtotalAmount.AutoSize = True
        Me.lblSubtotalAmount.Location = New System.Drawing.Point(79, 16)
        Me.lblSubtotalAmount.Name = "lblSubtotalAmount"
        Me.lblSubtotalAmount.Size = New System.Drawing.Size(34, 13)
        Me.lblSubtotalAmount.TabIndex = 0
        Me.lblSubtotalAmount.Text = "$0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(21, 76)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(27, 39)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 0
        Me.lblTax.Text = "Tax"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(6, 16)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal"
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.cboPayment)
        Me.grpPayment.Location = New System.Drawing.Point(416, 169)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(156, 65)
        Me.grpPayment.TabIndex = 2
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment"
        '
        'cboPayment
        '
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Items.AddRange(New Object() {"CASH", "CHECK", "VISA", "MASTERCARD", "AMERICAN EXPRESS"})
        Me.cboPayment.Location = New System.Drawing.Point(6, 25)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(144, 21)
        Me.cboPayment.TabIndex = 0
        Me.cboPayment.Text = "VISA"
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.chkMute)
        Me.grpActions.Controls.Add(Me.btnClose)
        Me.grpActions.Controls.Add(Me.btnReset)
        Me.grpActions.Controls.Add(Me.btnAccept)
        Me.grpActions.Controls.Add(Me.btnPrice)
        Me.grpActions.Location = New System.Drawing.Point(12, 373)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(560, 65)
        Me.grpActions.TabIndex = 3
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "Actions"
        '
        'chkMute
        '
        Me.chkMute.AutoSize = True
        Me.chkMute.Location = New System.Drawing.Point(461, 32)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.Size = New System.Drawing.Size(50, 17)
        Me.chkMute.TabIndex = 4
        Me.chkMute.Text = "&Mute"
        Me.chkMute.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(328, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(221, 20)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 40)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(114, 20)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 40)
        Me.btnAccept.TabIndex = 1
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(7, 20)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(75, 40)
        Me.btnPrice.TabIndex = 0
        Me.btnPrice.Text = "&Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(437, 348)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(0, 13)
        Me.lblDateTime.TabIndex = 6
        '
        'tmrDateTimeSource
        '
        Me.tmrDateTimeSource.Enabled = True
        Me.tmrDateTimeSource.Interval = 1000
        '
        'frmMeowmaMeatzaPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 450)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpPricing)
        Me.Controls.Add(Me.grpOrderInformation)
        Me.Controls.Add(Me.lblPizzaShop)
        Me.Controls.Add(Me.picMeowmaMiaLogo)
        Me.Controls.Add(Me.grpCustomerInformation)
        Me.Name = "frmMeowmaMeatzaPizza"
        Me.Text = "Meowma Meatza Pizzaria"
        Me.grpCustomerInformation.ResumeLayout(False)
        Me.grpCustomerInformation.PerformLayout()
        CType(Me.picMeowmaMiaLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderInformation.ResumeLayout(False)
        Me.grpOrderInformation.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPizzaToppings.ResumeLayout(False)
        Me.grpPizzaToppings.PerformLayout()
        Me.grpPizzaSize.ResumeLayout(False)
        Me.grpPizzaSize.PerformLayout()
        Me.grpPricing.ResumeLayout(False)
        Me.grpPricing.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpActions.ResumeLayout(False)
        Me.grpActions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCustomerInformation As GroupBox
    Friend WithEvents mtxPhoneEntry As MaskedTextBox
    Friend WithEvents mtxZipCodeEntry As MaskedTextBox
    Friend WithEvents cboStateEntry As ComboBox
    Friend WithEvents txtCityEntry As TextBox
    Friend WithEvents txtAddressEntry2 As TextBox
    Friend WithEvents txtAddressEntry1 As TextBox
    Friend WithEvents txtNameEntry As TextBox
    Friend WithEvents picMeowmaMiaLogo As PictureBox
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblPizzaShop As Label
    Friend WithEvents grpOrderInformation As GroupBox
    Friend WithEvents grpPizzaToppings As GroupBox
    Friend WithEvents grpPizzaSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents chkTurkey As CheckBox
    Friend WithEvents chkChicken As CheckBox
    Friend WithEvents chkSalami As CheckBox
    Friend WithEvents chkHamburger As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents grpPricing As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblMaxQuantity As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblSubtotalAmount As Label
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents grpActions As GroupBox
    Friend WithEvents chkMute As CheckBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnPrice As Button
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents lblOrderNumberCounter As Label
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrDateTimeSource As Timer
End Class
