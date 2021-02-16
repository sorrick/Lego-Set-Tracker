<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEditLegoSet
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.hdrYear = New System.Windows.Forms.Label()
        Me.hdrTag = New System.Windows.Forms.Label()
        Me.hdrTime = New System.Windows.Forms.Label()
        Me.hdrMinifig = New System.Windows.Forms.Label()
        Me.hdrLicensed = New System.Windows.Forms.Label()
        Me.hdrAge = New System.Windows.Forms.Label()
        Me.hdrPrice = New System.Windows.Forms.Label()
        Me.hdrMoving = New System.Windows.Forms.Label()
        Me.hdrTheme = New System.Windows.Forms.Label()
        Me.hdrName = New System.Windows.Forms.Label()
        Me.hdrPieces = New System.Windows.Forms.Label()
        Me.hdrSetNum = New System.Windows.Forms.Label()
        Me.txtSetNum = New System.Windows.Forms.TextBox()
        Me.txtPieces = New System.Windows.Forms.TextBox()
        Me.chkMoving = New System.Windows.Forms.CheckBox()
        Me.chkLicense = New System.Windows.Forms.CheckBox()
        Me.radToddler = New System.Windows.Forms.RadioButton()
        Me.radYoungChildren = New System.Windows.Forms.RadioButton()
        Me.radChildren = New System.Windows.Forms.RadioButton()
        Me.radOlderChild = New System.Windows.Forms.RadioButton()
        Me.radPreteen = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtMinifigures = New System.Windows.Forms.TextBox()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.ddlYears = New System.Windows.Forms.ComboBox()
        Me.lstThemes = New System.Windows.Forms.ListBox()
        Me.nudHours = New System.Windows.Forms.NumericUpDown()
        Me.lblSetError = New System.Windows.Forms.Label()
        Me.lblPiecesError = New System.Windows.Forms.Label()
        Me.lblYearError = New System.Windows.Forms.Label()
        Me.lblMovingError = New System.Windows.Forms.Label()
        Me.lblLicenseError = New System.Windows.Forms.Label()
        Me.lblAgeError = New System.Windows.Forms.Label()
        Me.lblNameError = New System.Windows.Forms.Label()
        Me.lblThemeError = New System.Windows.Forms.Label()
        Me.lblPriceError = New System.Windows.Forms.Label()
        Me.lblMinifigError = New System.Windows.Forms.Label()
        Me.lblHoursError = New System.Windows.Forms.Label()
        Me.lblTagError = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tipTag = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(264, 443)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(501, 443)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'hdrYear
        '
        Me.hdrYear.AutoSize = True
        Me.hdrYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrYear.Location = New System.Drawing.Point(12, 108)
        Me.hdrYear.Name = "hdrYear"
        Me.hdrYear.Size = New System.Drawing.Size(47, 20)
        Me.hdrYear.TabIndex = 34
        Me.hdrYear.Text = "Year:"
        '
        'hdrTag
        '
        Me.hdrTag.AutoSize = True
        Me.hdrTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTag.Location = New System.Drawing.Point(334, 392)
        Me.hdrTag.Name = "hdrTag"
        Me.hdrTag.Size = New System.Drawing.Size(40, 20)
        Me.hdrTag.TabIndex = 33
        Me.hdrTag.Text = "Tag:"
        '
        'hdrTime
        '
        Me.hdrTime.AutoSize = True
        Me.hdrTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTime.Location = New System.Drawing.Point(334, 351)
        Me.hdrTime.Name = "hdrTime"
        Me.hdrTime.Size = New System.Drawing.Size(143, 20)
        Me.hdrTime.TabIndex = 32
        Me.hdrTime.Text = "Hours to complete:"
        '
        'hdrMinifig
        '
        Me.hdrMinifig.AutoSize = True
        Me.hdrMinifig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrMinifig.Location = New System.Drawing.Point(334, 314)
        Me.hdrMinifig.Name = "hdrMinifig"
        Me.hdrMinifig.Size = New System.Drawing.Size(89, 20)
        Me.hdrMinifig.TabIndex = 31
        Me.hdrMinifig.Text = "Minifigures:"
        '
        'hdrLicensed
        '
        Me.hdrLicensed.AutoSize = True
        Me.hdrLicensed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrLicensed.Location = New System.Drawing.Point(12, 190)
        Me.hdrLicensed.Name = "hdrLicensed"
        Me.hdrLicensed.Size = New System.Drawing.Size(82, 20)
        Me.hdrLicensed.TabIndex = 30
        Me.hdrLicensed.Text = "Licensed?"
        '
        'hdrAge
        '
        Me.hdrAge.AutoSize = True
        Me.hdrAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrAge.Location = New System.Drawing.Point(13, 231)
        Me.hdrAge.Name = "hdrAge"
        Me.hdrAge.Size = New System.Drawing.Size(106, 20)
        Me.hdrAge.TabIndex = 29
        Me.hdrAge.Text = "Ages (Years):"
        '
        'hdrPrice
        '
        Me.hdrPrice.AutoSize = True
        Me.hdrPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrPrice.Location = New System.Drawing.Point(334, 269)
        Me.hdrPrice.Name = "hdrPrice"
        Me.hdrPrice.Size = New System.Drawing.Size(48, 20)
        Me.hdrPrice.TabIndex = 28
        Me.hdrPrice.Text = "Price:"
        '
        'hdrMoving
        '
        Me.hdrMoving.AutoSize = True
        Me.hdrMoving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrMoving.Location = New System.Drawing.Point(12, 153)
        Me.hdrMoving.Name = "hdrMoving"
        Me.hdrMoving.Size = New System.Drawing.Size(119, 20)
        Me.hdrMoving.TabIndex = 27
        Me.hdrMoving.Text = "Moving Pieces?"
        '
        'hdrTheme
        '
        Me.hdrTheme.AutoSize = True
        Me.hdrTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTheme.Location = New System.Drawing.Point(334, 64)
        Me.hdrTheme.Name = "hdrTheme"
        Me.hdrTheme.Size = New System.Drawing.Size(62, 20)
        Me.hdrTheme.TabIndex = 26
        Me.hdrTheme.Text = "Theme:"
        '
        'hdrName
        '
        Me.hdrName.AutoSize = True
        Me.hdrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrName.Location = New System.Drawing.Point(334, 19)
        Me.hdrName.Name = "hdrName"
        Me.hdrName.Size = New System.Drawing.Size(99, 20)
        Me.hdrName.TabIndex = 25
        Me.hdrName.Text = "Name of set:"
        '
        'hdrPieces
        '
        Me.hdrPieces.AutoSize = True
        Me.hdrPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrPieces.Location = New System.Drawing.Point(12, 64)
        Me.hdrPieces.Name = "hdrPieces"
        Me.hdrPieces.Size = New System.Drawing.Size(91, 20)
        Me.hdrPieces.TabIndex = 24
        Me.hdrPieces.Text = "# of Pieces:"
        '
        'hdrSetNum
        '
        Me.hdrSetNum.AutoSize = True
        Me.hdrSetNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrSetNum.Location = New System.Drawing.Point(12, 19)
        Me.hdrSetNum.Name = "hdrSetNum"
        Me.hdrSetNum.Size = New System.Drawing.Size(51, 20)
        Me.hdrSetNum.TabIndex = 23
        Me.hdrSetNum.Text = "Set #:"
        '
        'txtSetNum
        '
        Me.txtSetNum.Location = New System.Drawing.Point(109, 19)
        Me.txtSetNum.MaxLength = 4
        Me.txtSetNum.Name = "txtSetNum"
        Me.txtSetNum.Size = New System.Drawing.Size(54, 20)
        Me.txtSetNum.TabIndex = 35
        '
        'txtPieces
        '
        Me.txtPieces.Location = New System.Drawing.Point(109, 66)
        Me.txtPieces.MaxLength = 6
        Me.txtPieces.Name = "txtPieces"
        Me.txtPieces.Size = New System.Drawing.Size(79, 20)
        Me.txtPieces.TabIndex = 36
        '
        'chkMoving
        '
        Me.chkMoving.AutoSize = True
        Me.chkMoving.Location = New System.Drawing.Point(137, 159)
        Me.chkMoving.Name = "chkMoving"
        Me.chkMoving.Size = New System.Drawing.Size(15, 14)
        Me.chkMoving.TabIndex = 37
        Me.chkMoving.UseVisualStyleBackColor = True
        '
        'chkLicense
        '
        Me.chkLicense.AutoSize = True
        Me.chkLicense.Location = New System.Drawing.Point(137, 195)
        Me.chkLicense.Name = "chkLicense"
        Me.chkLicense.Size = New System.Drawing.Size(15, 14)
        Me.chkLicense.TabIndex = 38
        Me.chkLicense.UseVisualStyleBackColor = True
        '
        'radToddler
        '
        Me.radToddler.AutoSize = True
        Me.radToddler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radToddler.Location = New System.Drawing.Point(62, 270)
        Me.radToddler.Name = "radToddler"
        Me.radToddler.Size = New System.Drawing.Size(43, 19)
        Me.radToddler.TabIndex = 39
        Me.radToddler.TabStop = True
        Me.radToddler.Text = "1-2"
        Me.radToddler.UseVisualStyleBackColor = True
        '
        'radYoungChildren
        '
        Me.radYoungChildren.AutoSize = True
        Me.radYoungChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radYoungChildren.Location = New System.Drawing.Point(62, 296)
        Me.radYoungChildren.Name = "radYoungChildren"
        Me.radYoungChildren.Size = New System.Drawing.Size(43, 19)
        Me.radYoungChildren.TabIndex = 40
        Me.radYoungChildren.TabStop = True
        Me.radYoungChildren.Text = "3-5"
        Me.radYoungChildren.UseVisualStyleBackColor = True
        '
        'radChildren
        '
        Me.radChildren.AutoSize = True
        Me.radChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChildren.Location = New System.Drawing.Point(62, 322)
        Me.radChildren.Name = "radChildren"
        Me.radChildren.Size = New System.Drawing.Size(43, 19)
        Me.radChildren.TabIndex = 41
        Me.radChildren.TabStop = True
        Me.radChildren.Text = "6-8"
        Me.radChildren.UseVisualStyleBackColor = True
        '
        'radOlderChild
        '
        Me.radOlderChild.AutoSize = True
        Me.radOlderChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOlderChild.Location = New System.Drawing.Point(62, 348)
        Me.radOlderChild.Name = "radOlderChild"
        Me.radOlderChild.Size = New System.Drawing.Size(50, 19)
        Me.radOlderChild.TabIndex = 42
        Me.radOlderChild.TabStop = True
        Me.radOlderChild.Text = "9-11"
        Me.radOlderChild.UseVisualStyleBackColor = True
        '
        'radPreteen
        '
        Me.radPreteen.AutoSize = True
        Me.radPreteen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPreteen.Location = New System.Drawing.Point(62, 371)
        Me.radPreteen.Name = "radPreteen"
        Me.radPreteen.Size = New System.Drawing.Size(46, 19)
        Me.radPreteen.TabIndex = 43
        Me.radPreteen.TabStop = True
        Me.radPreteen.Text = "12+"
        Me.radPreteen.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(439, 21)
        Me.txtName.MaxLength = 25
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(176, 20)
        Me.txtName.TabIndex = 44
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(439, 271)
        Me.txtPrice.MaxLength = 8
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(115, 20)
        Me.txtPrice.TabIndex = 46
        '
        'txtMinifigures
        '
        Me.txtMinifigures.Location = New System.Drawing.Point(439, 316)
        Me.txtMinifigures.MaxLength = 2
        Me.txtMinifigures.Name = "txtMinifigures"
        Me.txtMinifigures.Size = New System.Drawing.Size(45, 20)
        Me.txtMinifigures.TabIndex = 48
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(380, 394)
        Me.txtTag.MaxLength = 20
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(209, 20)
        Me.txtTag.TabIndex = 50
        Me.tipTag.SetToolTip(Me.txtTag, "You can enter any personal tag in here.")
        '
        'ddlYears
        '
        Me.ddlYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlYears.FormattingEnabled = True
        Me.ddlYears.Location = New System.Drawing.Point(109, 106)
        Me.ddlYears.Name = "ddlYears"
        Me.ddlYears.Size = New System.Drawing.Size(100, 21)
        Me.ddlYears.TabIndex = 51
        '
        'lstThemes
        '
        Me.lstThemes.FormattingEnabled = True
        Me.lstThemes.Location = New System.Drawing.Point(439, 64)
        Me.lstThemes.Name = "lstThemes"
        Me.lstThemes.Size = New System.Drawing.Size(227, 186)
        Me.lstThemes.TabIndex = 52
        '
        'nudHours
        '
        Me.nudHours.Location = New System.Drawing.Point(483, 354)
        Me.nudHours.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudHours.Name = "nudHours"
        Me.nudHours.Size = New System.Drawing.Size(40, 20)
        Me.nudHours.TabIndex = 53
        '
        'lblSetError
        '
        Me.lblSetError.AutoSize = True
        Me.lblSetError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetError.ForeColor = System.Drawing.Color.Red
        Me.lblSetError.Location = New System.Drawing.Point(158, 18)
        Me.lblSetError.Name = "lblSetError"
        Me.lblSetError.Size = New System.Drawing.Size(25, 31)
        Me.lblSetError.TabIndex = 54
        Me.lblSetError.Text = "*"
        Me.lblSetError.Visible = False
        '
        'lblPiecesError
        '
        Me.lblPiecesError.AutoSize = True
        Me.lblPiecesError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPiecesError.ForeColor = System.Drawing.Color.Red
        Me.lblPiecesError.Location = New System.Drawing.Point(184, 65)
        Me.lblPiecesError.Name = "lblPiecesError"
        Me.lblPiecesError.Size = New System.Drawing.Size(25, 31)
        Me.lblPiecesError.TabIndex = 55
        Me.lblPiecesError.Text = "*"
        Me.lblPiecesError.Visible = False
        '
        'lblYearError
        '
        Me.lblYearError.AutoSize = True
        Me.lblYearError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearError.ForeColor = System.Drawing.Color.Red
        Me.lblYearError.Location = New System.Drawing.Point(208, 106)
        Me.lblYearError.Name = "lblYearError"
        Me.lblYearError.Size = New System.Drawing.Size(25, 31)
        Me.lblYearError.TabIndex = 56
        Me.lblYearError.Text = "*"
        Me.lblYearError.Visible = False
        '
        'lblMovingError
        '
        Me.lblMovingError.AutoSize = True
        Me.lblMovingError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovingError.ForeColor = System.Drawing.Color.Red
        Me.lblMovingError.Location = New System.Drawing.Point(149, 155)
        Me.lblMovingError.Name = "lblMovingError"
        Me.lblMovingError.Size = New System.Drawing.Size(25, 31)
        Me.lblMovingError.TabIndex = 57
        Me.lblMovingError.Text = "*"
        Me.lblMovingError.Visible = False
        '
        'lblLicenseError
        '
        Me.lblLicenseError.AutoSize = True
        Me.lblLicenseError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicenseError.ForeColor = System.Drawing.Color.Red
        Me.lblLicenseError.Location = New System.Drawing.Point(149, 190)
        Me.lblLicenseError.Name = "lblLicenseError"
        Me.lblLicenseError.Size = New System.Drawing.Size(25, 31)
        Me.lblLicenseError.TabIndex = 58
        Me.lblLicenseError.Text = "*"
        Me.lblLicenseError.Visible = False
        '
        'lblAgeError
        '
        Me.lblAgeError.AutoSize = True
        Me.lblAgeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeError.ForeColor = System.Drawing.Color.Red
        Me.lblAgeError.Location = New System.Drawing.Point(131, 231)
        Me.lblAgeError.Name = "lblAgeError"
        Me.lblAgeError.Size = New System.Drawing.Size(25, 31)
        Me.lblAgeError.TabIndex = 59
        Me.lblAgeError.Text = "*"
        Me.lblAgeError.Visible = False
        '
        'lblNameError
        '
        Me.lblNameError.AutoSize = True
        Me.lblNameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameError.ForeColor = System.Drawing.Color.Red
        Me.lblNameError.Location = New System.Drawing.Point(611, 21)
        Me.lblNameError.Name = "lblNameError"
        Me.lblNameError.Size = New System.Drawing.Size(25, 31)
        Me.lblNameError.TabIndex = 60
        Me.lblNameError.Text = "*"
        Me.lblNameError.Visible = False
        '
        'lblThemeError
        '
        Me.lblThemeError.AutoSize = True
        Me.lblThemeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThemeError.ForeColor = System.Drawing.Color.Red
        Me.lblThemeError.Location = New System.Drawing.Point(402, 66)
        Me.lblThemeError.Name = "lblThemeError"
        Me.lblThemeError.Size = New System.Drawing.Size(25, 31)
        Me.lblThemeError.TabIndex = 61
        Me.lblThemeError.Text = "*"
        Me.lblThemeError.Visible = False
        '
        'lblPriceError
        '
        Me.lblPriceError.AutoSize = True
        Me.lblPriceError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceError.ForeColor = System.Drawing.Color.Red
        Me.lblPriceError.Location = New System.Drawing.Point(551, 271)
        Me.lblPriceError.Name = "lblPriceError"
        Me.lblPriceError.Size = New System.Drawing.Size(25, 31)
        Me.lblPriceError.TabIndex = 62
        Me.lblPriceError.Text = "*"
        Me.lblPriceError.Visible = False
        '
        'lblMinifigError
        '
        Me.lblMinifigError.AutoSize = True
        Me.lblMinifigError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinifigError.ForeColor = System.Drawing.Color.Red
        Me.lblMinifigError.Location = New System.Drawing.Point(481, 315)
        Me.lblMinifigError.Name = "lblMinifigError"
        Me.lblMinifigError.Size = New System.Drawing.Size(25, 31)
        Me.lblMinifigError.TabIndex = 63
        Me.lblMinifigError.Text = "*"
        Me.lblMinifigError.Visible = False
        '
        'lblHoursError
        '
        Me.lblHoursError.AutoSize = True
        Me.lblHoursError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursError.ForeColor = System.Drawing.Color.Red
        Me.lblHoursError.Location = New System.Drawing.Point(529, 351)
        Me.lblHoursError.Name = "lblHoursError"
        Me.lblHoursError.Size = New System.Drawing.Size(25, 31)
        Me.lblHoursError.TabIndex = 64
        Me.lblHoursError.Text = "*"
        Me.lblHoursError.Visible = False
        '
        'lblTagError
        '
        Me.lblTagError.AutoSize = True
        Me.lblTagError.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagError.ForeColor = System.Drawing.Color.Red
        Me.lblTagError.Location = New System.Drawing.Point(587, 393)
        Me.lblTagError.Name = "lblTagError"
        Me.lblTagError.Size = New System.Drawing.Size(25, 31)
        Me.lblTagError.TabIndex = 65
        Me.lblTagError.Text = "*"
        Me.lblTagError.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(62, 442)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 24)
        Me.btnClear.TabIndex = 66
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tipTag
        '
        Me.tipTag.AutomaticDelay = 200
        Me.tipTag.AutoPopDelay = 5000
        Me.tipTag.InitialDelay = 200
        Me.tipTag.ReshowDelay = 40
        '
        'frmNewEditLegoSet
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 478)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblHoursError)
        Me.Controls.Add(Me.lblThemeError)
        Me.Controls.Add(Me.lblAgeError)
        Me.Controls.Add(Me.lblYearError)
        Me.Controls.Add(Me.nudHours)
        Me.Controls.Add(Me.lstThemes)
        Me.Controls.Add(Me.ddlYears)
        Me.Controls.Add(Me.txtTag)
        Me.Controls.Add(Me.txtMinifigures)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.radPreteen)
        Me.Controls.Add(Me.radOlderChild)
        Me.Controls.Add(Me.radChildren)
        Me.Controls.Add(Me.radYoungChildren)
        Me.Controls.Add(Me.radToddler)
        Me.Controls.Add(Me.chkLicense)
        Me.Controls.Add(Me.chkMoving)
        Me.Controls.Add(Me.txtPieces)
        Me.Controls.Add(Me.txtSetNum)
        Me.Controls.Add(Me.hdrYear)
        Me.Controls.Add(Me.hdrTag)
        Me.Controls.Add(Me.hdrTime)
        Me.Controls.Add(Me.hdrMinifig)
        Me.Controls.Add(Me.hdrLicensed)
        Me.Controls.Add(Me.hdrAge)
        Me.Controls.Add(Me.hdrPrice)
        Me.Controls.Add(Me.hdrMoving)
        Me.Controls.Add(Me.hdrTheme)
        Me.Controls.Add(Me.hdrName)
        Me.Controls.Add(Me.hdrPieces)
        Me.Controls.Add(Me.hdrSetNum)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSetError)
        Me.Controls.Add(Me.lblPiecesError)
        Me.Controls.Add(Me.lblMovingError)
        Me.Controls.Add(Me.lblLicenseError)
        Me.Controls.Add(Me.lblNameError)
        Me.Controls.Add(Me.lblPriceError)
        Me.Controls.Add(Me.lblMinifigError)
        Me.Controls.Add(Me.lblTagError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNewEditLegoSet"
        Me.Text = "frmNewEditLegoSet"
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents hdrYear As Label
    Friend WithEvents hdrTag As Label
    Friend WithEvents hdrTime As Label
    Friend WithEvents hdrMinifig As Label
    Friend WithEvents hdrLicensed As Label
    Friend WithEvents hdrAge As Label
    Friend WithEvents hdrPrice As Label
    Friend WithEvents hdrMoving As Label
    Friend WithEvents hdrTheme As Label
    Friend WithEvents hdrName As Label
    Friend WithEvents hdrPieces As Label
    Friend WithEvents hdrSetNum As Label
    Friend WithEvents txtSetNum As TextBox
    Friend WithEvents txtPieces As TextBox
    Friend WithEvents chkMoving As CheckBox
    Friend WithEvents chkLicense As CheckBox
    Friend WithEvents radToddler As RadioButton
    Friend WithEvents radYoungChildren As RadioButton
    Friend WithEvents radChildren As RadioButton
    Friend WithEvents radOlderChild As RadioButton
    Friend WithEvents radPreteen As RadioButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtMinifigures As TextBox
    Friend WithEvents txtTag As TextBox
    Friend WithEvents ddlYears As ComboBox
    Friend WithEvents lstThemes As ListBox
    Friend WithEvents nudHours As NumericUpDown
    Friend WithEvents lblSetError As Label
    Friend WithEvents lblPiecesError As Label
    Friend WithEvents lblYearError As Label
    Friend WithEvents lblMovingError As Label
    Friend WithEvents lblLicenseError As Label
    Friend WithEvents lblAgeError As Label
    Friend WithEvents lblNameError As Label
    Friend WithEvents lblThemeError As Label
    Friend WithEvents lblPriceError As Label
    Friend WithEvents lblMinifigError As Label
    Friend WithEvents lblHoursError As Label
    Friend WithEvents lblTagError As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents tipTag As ToolTip
End Class
