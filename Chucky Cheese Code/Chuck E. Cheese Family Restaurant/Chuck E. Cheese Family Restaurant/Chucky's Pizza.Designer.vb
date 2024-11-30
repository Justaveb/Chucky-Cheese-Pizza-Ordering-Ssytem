<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        rbDummy = New RadioButton()
        rbFamily = New RadioButton()
        rbLarge = New RadioButton()
        rbRegular = New RadioButton()
        GroupBox2 = New GroupBox()
        rbStuffed = New RadioButton()
        rbThick = New RadioButton()
        rbThin = New RadioButton()
        GroupBox3 = New GroupBox()
        rbSoft = New RadioButton()
        rbShake = New RadioButton()
        rbTea = New RadioButton()
        GroupBox4 = New GroupBox()
        cboxPine = New CheckBox()
        cboxSalami = New CheckBox()
        cboxSpinach = New CheckBox()
        cboxOlives = New CheckBox()
        cboxShrooms = New CheckBox()
        cboxTruffle = New CheckBox()
        cboxSausage = New CheckBox()
        cboxChicken = New CheckBox()
        cboxHam = New CheckBox()
        cboxPepperoni = New CheckBox()
        PictureBox1 = New PictureBox()
        GroupBox5 = New GroupBox()
        rbChed = New RadioButton()
        rbMoz = New RadioButton()
        rbParm = New RadioButton()
        lblPizza = New Label()
        Timer1 = New Timer(components)
        btnSpecial = New Button()
        btnBuild = New Button()
        btnClear = New Button()
        rbTakeout = New RadioButton()
        rbDinein = New RadioButton()
        lblTime = New Label()
        lblDate = New Label()
        Amount = New GroupBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTotal = New TextBox()
        txtPizza = New TextBox()
        txtToppings = New TextBox()
        txtDrinks = New TextBox()
        GroupBox6 = New GroupBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        Amount.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(rbDummy)
        GroupBox1.Controls.Add(rbFamily)
        GroupBox1.Controls.Add(rbLarge)
        GroupBox1.Controls.Add(rbRegular)
        GroupBox1.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        GroupBox1.Location = New Point(12, 94)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(183, 107)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Size"
        ' 
        ' rbDummy
        ' 
        rbDummy.AutoSize = True
        rbDummy.Location = New Point(87, 26)
        rbDummy.Name = "rbDummy"
        rbDummy.Size = New Size(14, 13)
        rbDummy.TabIndex = 3
        rbDummy.UseVisualStyleBackColor = True
        rbDummy.Visible = False
        ' 
        ' rbFamily
        ' 
        rbFamily.AutoSize = True
        rbFamily.Location = New Point(6, 74)
        rbFamily.Name = "rbFamily"
        rbFamily.Size = New Size(67, 20)
        rbFamily.TabIndex = 2
        rbFamily.Text = "Family"
        rbFamily.UseVisualStyleBackColor = True
        ' 
        ' rbLarge
        ' 
        rbLarge.AutoSize = True
        rbLarge.Location = New Point(6, 48)
        rbLarge.Name = "rbLarge"
        rbLarge.Size = New Size(60, 20)
        rbLarge.TabIndex = 1
        rbLarge.Text = "Large"
        rbLarge.UseVisualStyleBackColor = True
        ' 
        ' rbRegular
        ' 
        rbRegular.AutoSize = True
        rbRegular.Location = New Point(6, 22)
        rbRegular.Name = "rbRegular"
        rbRegular.Size = New Size(74, 20)
        rbRegular.TabIndex = 0
        rbRegular.Text = "Regular"
        rbRegular.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(rbStuffed)
        GroupBox2.Controls.Add(rbThick)
        GroupBox2.Controls.Add(rbThin)
        GroupBox2.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        GroupBox2.Location = New Point(12, 211)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(183, 107)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Crust"
        ' 
        ' rbStuffed
        ' 
        rbStuffed.AutoSize = True
        rbStuffed.Location = New Point(6, 74)
        rbStuffed.Name = "rbStuffed"
        rbStuffed.Size = New Size(137, 20)
        rbStuffed.TabIndex = 5
        rbStuffed.TabStop = True
        rbStuffed.Text = "Stuffed (Cheese)"
        rbStuffed.UseVisualStyleBackColor = True
        ' 
        ' rbThick
        ' 
        rbThick.AutoSize = True
        rbThick.Location = New Point(6, 48)
        rbThick.Name = "rbThick"
        rbThick.Size = New Size(60, 20)
        rbThick.TabIndex = 4
        rbThick.TabStop = True
        rbThick.Text = "Thick"
        rbThick.UseVisualStyleBackColor = True
        ' 
        ' rbThin
        ' 
        rbThin.AutoSize = True
        rbThin.Location = New Point(6, 22)
        rbThin.Name = "rbThin"
        rbThin.Size = New Size(53, 20)
        rbThin.TabIndex = 3
        rbThin.TabStop = True
        rbThin.Text = "Thin"
        rbThin.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(rbSoft)
        GroupBox3.Controls.Add(rbShake)
        GroupBox3.Controls.Add(rbTea)
        GroupBox3.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        GroupBox3.Location = New Point(12, 324)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(183, 107)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Drinks"
        ' 
        ' rbSoft
        ' 
        rbSoft.AutoSize = True
        rbSoft.Location = New Point(6, 53)
        rbSoft.Name = "rbSoft"
        rbSoft.Size = New Size(95, 20)
        rbSoft.TabIndex = 8
        rbSoft.TabStop = True
        rbSoft.Text = "Soft Drink"
        rbSoft.UseVisualStyleBackColor = True
        ' 
        ' rbShake
        ' 
        rbShake.AutoSize = True
        rbShake.Location = New Point(6, 79)
        rbShake.Name = "rbShake"
        rbShake.Size = New Size(95, 20)
        rbShake.TabIndex = 7
        rbShake.TabStop = True
        rbShake.Text = "Milk Shake"
        rbShake.UseVisualStyleBackColor = True
        ' 
        ' rbTea
        ' 
        rbTea.AutoSize = True
        rbTea.Location = New Point(6, 27)
        rbTea.Name = "rbTea"
        rbTea.Size = New Size(81, 20)
        rbTea.TabIndex = 6
        rbTea.TabStop = True
        rbTea.Text = "Iced Tea"
        rbTea.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(cboxPine)
        GroupBox4.Controls.Add(cboxSalami)
        GroupBox4.Controls.Add(cboxSpinach)
        GroupBox4.Controls.Add(cboxOlives)
        GroupBox4.Controls.Add(cboxShrooms)
        GroupBox4.Controls.Add(cboxTruffle)
        GroupBox4.Controls.Add(cboxSausage)
        GroupBox4.Controls.Add(cboxChicken)
        GroupBox4.Controls.Add(cboxHam)
        GroupBox4.Controls.Add(cboxPepperoni)
        GroupBox4.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        GroupBox4.Location = New Point(201, 71)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(247, 155)
        GroupBox4.TabIndex = 1
        GroupBox4.TabStop = False
        GroupBox4.Text = "Toppings"
        ' 
        ' cboxPine
        ' 
        cboxPine.AutoSize = True
        cboxPine.Font = New Font("Roboto Mono", 9.75F)
        cboxPine.Location = New Point(131, 123)
        cboxPine.Name = "cboxPine"
        cboxPine.Size = New Size(99, 22)
        cboxPine.TabIndex = 9
        cboxPine.Text = "Pineapple"
        cboxPine.UseVisualStyleBackColor = True
        ' 
        ' cboxSalami
        ' 
        cboxSalami.AutoSize = True
        cboxSalami.Font = New Font("Roboto Mono", 9.75F)
        cboxSalami.Location = New Point(4, 126)
        cboxSalami.Name = "cboxSalami"
        cboxSalami.Size = New Size(75, 22)
        cboxSalami.TabIndex = 8
        cboxSalami.Text = "Salami"
        cboxSalami.UseVisualStyleBackColor = True
        ' 
        ' cboxSpinach
        ' 
        cboxSpinach.AutoSize = True
        cboxSpinach.Font = New Font("Roboto Mono", 9.75F)
        cboxSpinach.Location = New Point(131, 97)
        cboxSpinach.Name = "cboxSpinach"
        cboxSpinach.Size = New Size(83, 22)
        cboxSpinach.TabIndex = 7
        cboxSpinach.Text = "Spinach"
        cboxSpinach.UseVisualStyleBackColor = True
        ' 
        ' cboxOlives
        ' 
        cboxOlives.AutoSize = True
        cboxOlives.Font = New Font("Roboto Mono", 9.75F)
        cboxOlives.Location = New Point(131, 74)
        cboxOlives.Name = "cboxOlives"
        cboxOlives.Size = New Size(75, 22)
        cboxOlives.TabIndex = 6
        cboxOlives.Text = "Olives"
        cboxOlives.UseVisualStyleBackColor = True
        ' 
        ' cboxShrooms
        ' 
        cboxShrooms.AutoSize = True
        cboxShrooms.Font = New Font("Roboto Mono", 9.75F)
        cboxShrooms.Location = New Point(131, 48)
        cboxShrooms.Name = "cboxShrooms"
        cboxShrooms.Size = New Size(99, 22)
        cboxShrooms.TabIndex = 5
        cboxShrooms.Text = "Mushrooms"
        cboxShrooms.UseVisualStyleBackColor = True
        ' 
        ' cboxTruffle
        ' 
        cboxTruffle.AutoSize = True
        cboxTruffle.Font = New Font("Roboto Mono", 9.75F)
        cboxTruffle.Location = New Point(131, 22)
        cboxTruffle.Name = "cboxTruffle"
        cboxTruffle.Size = New Size(83, 22)
        cboxTruffle.TabIndex = 4
        cboxTruffle.Text = "Truffle"
        cboxTruffle.UseVisualStyleBackColor = True
        ' 
        ' cboxSausage
        ' 
        cboxSausage.AutoSize = True
        cboxSausage.Font = New Font("Roboto Mono", 9.75F)
        cboxSausage.Location = New Point(4, 100)
        cboxSausage.Name = "cboxSausage"
        cboxSausage.Size = New Size(83, 22)
        cboxSausage.TabIndex = 3
        cboxSausage.Text = "Sausage"
        cboxSausage.UseVisualStyleBackColor = True
        ' 
        ' cboxChicken
        ' 
        cboxChicken.AutoSize = True
        cboxChicken.Font = New Font("Roboto Mono", 9.75F)
        cboxChicken.Location = New Point(4, 74)
        cboxChicken.Name = "cboxChicken"
        cboxChicken.Size = New Size(83, 22)
        cboxChicken.TabIndex = 2
        cboxChicken.Text = "Chicken"
        cboxChicken.UseVisualStyleBackColor = True
        ' 
        ' cboxHam
        ' 
        cboxHam.AutoSize = True
        cboxHam.Font = New Font("Roboto Mono", 9.75F)
        cboxHam.Location = New Point(4, 49)
        cboxHam.Name = "cboxHam"
        cboxHam.Size = New Size(51, 22)
        cboxHam.TabIndex = 1
        cboxHam.Text = "Ham"
        cboxHam.UseVisualStyleBackColor = True
        ' 
        ' cboxPepperoni
        ' 
        cboxPepperoni.AutoSize = True
        cboxPepperoni.Font = New Font("Roboto Mono", 9.75F)
        cboxPepperoni.Location = New Point(4, 23)
        cboxPepperoni.Name = "cboxPepperoni"
        cboxPepperoni.Size = New Size(99, 22)
        cboxPepperoni.TabIndex = 0
        cboxPepperoni.Text = "Pepperoni"
        cboxPepperoni.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(455, 186)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(113, 344)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.Transparent
        GroupBox5.Controls.Add(rbChed)
        GroupBox5.Controls.Add(rbMoz)
        GroupBox5.Controls.Add(rbParm)
        GroupBox5.Cursor = Cursors.Cross
        GroupBox5.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox5.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        GroupBox5.Location = New Point(205, 232)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(243, 59)
        GroupBox5.TabIndex = 3
        GroupBox5.TabStop = False
        GroupBox5.Text = "Cheese"
        ' 
        ' rbChed
        ' 
        rbChed.AutoSize = True
        rbChed.Location = New Point(173, 22)
        rbChed.Name = "rbChed"
        rbChed.Size = New Size(74, 20)
        rbChed.TabIndex = 2
        rbChed.TabStop = True
        rbChed.Text = "Cheddar"
        rbChed.UseVisualStyleBackColor = True
        ' 
        ' rbMoz
        ' 
        rbMoz.AutoSize = True
        rbMoz.Location = New Point(86, 22)
        rbMoz.Name = "rbMoz"
        rbMoz.Size = New Size(88, 20)
        rbMoz.TabIndex = 1
        rbMoz.TabStop = True
        rbMoz.Text = "Mozzarela"
        rbMoz.UseVisualStyleBackColor = True
        ' 
        ' rbParm
        ' 
        rbParm.AutoSize = True
        rbParm.Location = New Point(6, 22)
        rbParm.Name = "rbParm"
        rbParm.Size = New Size(81, 20)
        rbParm.TabIndex = 0
        rbParm.TabStop = True
        rbParm.Text = "Parmesan"
        rbParm.UseVisualStyleBackColor = True
        ' 
        ' lblPizza
        ' 
        lblPizza.AutoSize = True
        lblPizza.BackColor = Color.Transparent
        lblPizza.Font = New Font("Roboto Mono Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPizza.ForeColor = Color.Red
        lblPizza.Location = New Point(63, 9)
        lblPizza.Name = "lblPizza"
        lblPizza.Size = New Size(434, 32)
        lblPizza.TabIndex = 4
        lblPizza.Text = "CHUCKY CHEESE'S PIZZA BUILDER!"
        ' 
        ' Timer1
        ' 
        ' 
        ' btnSpecial
        ' 
        btnSpecial.BackColor = Color.Transparent
        btnSpecial.FlatAppearance.BorderSize = 0
        btnSpecial.FlatStyle = FlatStyle.Flat
        btnSpecial.Font = New Font("Roboto Mono", 6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSpecial.Location = New Point(528, 411)
        btnSpecial.Name = "btnSpecial"
        btnSpecial.Size = New Size(45, 20)
        btnSpecial.TabIndex = 5
        btnSpecial.Text = "Secret"
        btnSpecial.UseVisualStyleBackColor = False
        ' 
        ' btnBuild
        ' 
        btnBuild.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnBuild.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnBuild.FlatAppearance.BorderSize = 2
        btnBuild.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnBuild.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnBuild.FlatStyle = FlatStyle.Flat
        btnBuild.Font = New Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuild.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnBuild.Location = New Point(454, 79)
        btnBuild.Name = "btnBuild"
        btnBuild.Size = New Size(102, 42)
        btnBuild.TabIndex = 6
        btnBuild.Text = "Build"
        btnBuild.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnClear.FlatAppearance.BorderSize = 2
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnClear.Location = New Point(454, 123)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(102, 42)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' rbTakeout
        ' 
        rbTakeout.AutoSize = True
        rbTakeout.BackColor = Color.Transparent
        rbTakeout.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbTakeout.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        rbTakeout.Location = New Point(10, 39)
        rbTakeout.Name = "rbTakeout"
        rbTakeout.Size = New Size(81, 20)
        rbTakeout.TabIndex = 9
        rbTakeout.TabStop = True
        rbTakeout.Text = "Take Out"
        rbTakeout.UseVisualStyleBackColor = False
        ' 
        ' rbDinein
        ' 
        rbDinein.AutoSize = True
        rbDinein.BackColor = Color.Transparent
        rbDinein.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbDinein.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        rbDinein.Location = New Point(10, 18)
        rbDinein.Name = "rbDinein"
        rbDinein.Size = New Size(74, 20)
        rbDinein.TabIndex = 10
        rbDinein.TabStop = True
        rbDinein.Text = "Dine In"
        rbDinein.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.ForeColor = Color.Red
        lblTime.Location = New Point(12, 48)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(59, 15)
        lblTime.TabIndex = 34
        lblTime.Text = "hh:mm:ss"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.ForeColor = Color.Red
        lblDate.Location = New Point(12, 70)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(77, 15)
        lblDate.TabIndex = 35
        lblDate.Text = "mm/dd/yyyy"
        ' 
        ' Amount
        ' 
        Amount.BackColor = Color.Transparent
        Amount.Controls.Add(Label4)
        Amount.Controls.Add(Label3)
        Amount.Controls.Add(Label2)
        Amount.Controls.Add(Label1)
        Amount.Controls.Add(txtTotal)
        Amount.Controls.Add(txtPizza)
        Amount.Controls.Add(txtToppings)
        Amount.Controls.Add(txtDrinks)
        Amount.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Amount.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Amount.Location = New Point(211, 297)
        Amount.Name = "Amount"
        Amount.Size = New Size(178, 134)
        Amount.TabIndex = 36
        Amount.TabStop = False
        Amount.Text = "Amount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 16)
        Label4.TabIndex = 27
        Label4.Text = "Total:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 16)
        Label3.TabIndex = 26
        Label3.Text = "Drinks:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(17, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 16)
        Label2.TabIndex = 25
        Label2.Text = "Toppings:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 16)
        Label1.TabIndex = 24
        Label1.Text = "Pizza:"
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.Black
        txtTotal.BorderStyle = BorderStyle.FixedSingle
        txtTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.ForeColor = Color.White
        txtTotal.Location = New Point(97, 105)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(72, 23)
        txtTotal.TabIndex = 22
        txtTotal.Text = "0"
        ' 
        ' txtPizza
        ' 
        txtPizza.BackColor = Color.Black
        txtPizza.BorderStyle = BorderStyle.FixedSingle
        txtPizza.Font = New Font("Segoe UI", 9F)
        txtPizza.ForeColor = Color.White
        txtPizza.Location = New Point(97, 20)
        txtPizza.Name = "txtPizza"
        txtPizza.ReadOnly = True
        txtPizza.Size = New Size(72, 23)
        txtPizza.TabIndex = 20
        txtPizza.Text = "0"
        ' 
        ' txtToppings
        ' 
        txtToppings.BackColor = Color.Black
        txtToppings.BorderStyle = BorderStyle.FixedSingle
        txtToppings.Font = New Font("Segoe UI", 9F)
        txtToppings.ForeColor = Color.White
        txtToppings.Location = New Point(97, 47)
        txtToppings.Name = "txtToppings"
        txtToppings.ReadOnly = True
        txtToppings.Size = New Size(72, 23)
        txtToppings.TabIndex = 21
        txtToppings.Text = "0"
        ' 
        ' txtDrinks
        ' 
        txtDrinks.BackColor = Color.Black
        txtDrinks.BorderStyle = BorderStyle.FixedSingle
        txtDrinks.Font = New Font("Segoe UI", 9F)
        txtDrinks.ForeColor = Color.White
        txtDrinks.Location = New Point(97, 76)
        txtDrinks.Name = "txtDrinks"
        txtDrinks.ReadOnly = True
        txtDrinks.Size = New Size(72, 23)
        txtDrinks.TabIndex = 23
        txtDrinks.Text = "0"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.Transparent
        GroupBox6.Controls.Add(rbTakeout)
        GroupBox6.Controls.Add(rbDinein)
        GroupBox6.Cursor = Cursors.Cross
        GroupBox6.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox6.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        GroupBox6.Location = New Point(395, 297)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(91, 58)
        GroupBox6.TabIndex = 4
        GroupBox6.TabStop = False
        GroupBox6.Text = "Delivery"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(568, 434)
        Controls.Add(GroupBox6)
        Controls.Add(Amount)
        Controls.Add(lblDate)
        Controls.Add(lblTime)
        Controls.Add(btnClear)
        Controls.Add(btnBuild)
        Controls.Add(btnSpecial)
        Controls.Add(lblPizza)
        Controls.Add(GroupBox5)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chucky's Pizza"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        Amount.ResumeLayout(False)
        Amount.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rbFamily As RadioButton
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbRegular As RadioButton
    Friend WithEvents rbStuffed As RadioButton
    Friend WithEvents rbThick As RadioButton
    Friend WithEvents rbThin As RadioButton
    Friend WithEvents rbSoft As RadioButton
    Friend WithEvents rbShake As RadioButton
    Friend WithEvents rbTea As RadioButton
    Friend WithEvents cboxPine As CheckBox
    Friend WithEvents cboxSalami As CheckBox
    Friend WithEvents cboxSpinach As CheckBox
    Friend WithEvents cboxOlives As CheckBox
    Friend WithEvents cboxShrooms As CheckBox
    Friend WithEvents cboxTruffle As CheckBox
    Friend WithEvents cboxSausage As CheckBox
    Friend WithEvents cboxChicken As CheckBox
    Friend WithEvents cboxHam As CheckBox
    Friend WithEvents cboxPepperoni As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbParm As RadioButton
    Friend WithEvents rbChed As RadioButton
    Friend WithEvents rbMoz As RadioButton
    Friend WithEvents lblPizza As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSpecial As Button
    Friend WithEvents btnBuild As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents rbTakeout As RadioButton
    Friend WithEvents rbDinein As RadioButton
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Amount As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtPizza As TextBox
    Friend WithEvents txtToppings As TextBox
    Friend WithEvents txtDrinks As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbDummy As RadioButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog

End Class
