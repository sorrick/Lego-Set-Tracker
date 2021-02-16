<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLegos
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
        Me.lstReadLegos = New System.Windows.Forms.ListBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlDisplayInfo = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.hdrYear = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblMinifig = New System.Windows.Forms.Label()
        Me.lblLicense = New System.Windows.Forms.Label()
        Me.lblAges = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblMoving = New System.Windows.Forms.Label()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPieces = New System.Windows.Forms.Label()
        Me.lblSetNum = New System.Windows.Forms.Label()
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
        Me.pnlDisplayInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstReadLegos
        '
        Me.lstReadLegos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReadLegos.FormattingEnabled = True
        Me.lstReadLegos.ItemHeight = 22
        Me.lstReadLegos.Location = New System.Drawing.Point(18, 18)
        Me.lstReadLegos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstReadLegos.Name = "lstReadLegos"
        Me.lstReadLegos.Size = New System.Drawing.Size(648, 686)
        Me.lstReadLegos.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(555, 789)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(112, 35)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(134, 789)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(112, 35)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(942, 789)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlDisplayInfo
        '
        Me.pnlDisplayInfo.Controls.Add(Me.btnDelete)
        Me.pnlDisplayInfo.Controls.Add(Me.btnChange)
        Me.pnlDisplayInfo.Controls.Add(Me.lblYear)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrYear)
        Me.pnlDisplayInfo.Controls.Add(Me.lblTag)
        Me.pnlDisplayInfo.Controls.Add(Me.lblTime)
        Me.pnlDisplayInfo.Controls.Add(Me.lblMinifig)
        Me.pnlDisplayInfo.Controls.Add(Me.lblLicense)
        Me.pnlDisplayInfo.Controls.Add(Me.lblAges)
        Me.pnlDisplayInfo.Controls.Add(Me.lblPrice)
        Me.pnlDisplayInfo.Controls.Add(Me.lblMoving)
        Me.pnlDisplayInfo.Controls.Add(Me.lblTheme)
        Me.pnlDisplayInfo.Controls.Add(Me.lblName)
        Me.pnlDisplayInfo.Controls.Add(Me.lblPieces)
        Me.pnlDisplayInfo.Controls.Add(Me.lblSetNum)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrTag)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrTime)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrMinifig)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrLicensed)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrAge)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrPrice)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrMoving)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrTheme)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrName)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrPieces)
        Me.pnlDisplayInfo.Controls.Add(Me.hdrSetNum)
        Me.pnlDisplayInfo.Location = New System.Drawing.Point(706, 20)
        Me.pnlDisplayInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlDisplayInfo.Name = "pnlDisplayInfo"
        Me.pnlDisplayInfo.Size = New System.Drawing.Size(717, 694)
        Me.pnlDisplayInfo.TabIndex = 4
        Me.pnlDisplayInfo.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(531, 642)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 35)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(531, 523)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(126, 35)
        Me.btnChange.TabIndex = 24
        Me.btnChange.Text = "&Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(236, 148)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(73, 29)
        Me.lblYear.TabIndex = 23
        Me.lblYear.Text = "ZZZZ"
        '
        'hdrYear
        '
        Me.hdrYear.AutoSize = True
        Me.hdrYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrYear.Location = New System.Drawing.Point(26, 148)
        Me.hdrYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrYear.Name = "hdrYear"
        Me.hdrYear.Size = New System.Drawing.Size(70, 29)
        Me.hdrYear.TabIndex = 22
        Me.hdrYear.Text = "Year:"
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.Location = New System.Drawing.Point(236, 646)
        Me.lblTag.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(73, 29)
        Me.lblTag.TabIndex = 21
        Me.lblTag.Text = "ZZZZ"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(236, 592)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(73, 29)
        Me.lblTime.TabIndex = 20
        Me.lblTime.Text = "ZZZZ"
        '
        'lblMinifig
        '
        Me.lblMinifig.AutoSize = True
        Me.lblMinifig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinifig.Location = New System.Drawing.Point(236, 528)
        Me.lblMinifig.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinifig.Name = "lblMinifig"
        Me.lblMinifig.Size = New System.Drawing.Size(58, 29)
        Me.lblMinifig.TabIndex = 19
        Me.lblMinifig.Text = "ZZZ"
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicense.Location = New System.Drawing.Point(236, 468)
        Me.lblLicense.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(58, 29)
        Me.lblLicense.TabIndex = 18
        Me.lblLicense.Text = "ZZZ"
        '
        'lblAges
        '
        Me.lblAges.AutoSize = True
        Me.lblAges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAges.Location = New System.Drawing.Point(236, 411)
        Me.lblAges.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAges.Name = "lblAges"
        Me.lblAges.Size = New System.Drawing.Size(103, 29)
        Me.lblAges.TabIndex = 17
        Me.lblAges.Text = "ZZZZZZ"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(236, 355)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(103, 29)
        Me.lblPrice.TabIndex = 16
        Me.lblPrice.Text = "ZZZZZZ"
        '
        'lblMoving
        '
        Me.lblMoving.AutoSize = True
        Me.lblMoving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoving.Location = New System.Drawing.Point(236, 298)
        Me.lblMoving.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMoving.Name = "lblMoving"
        Me.lblMoving.Size = New System.Drawing.Size(58, 29)
        Me.lblMoving.TabIndex = 15
        Me.lblMoving.Text = "ZZZ"
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheme.Location = New System.Drawing.Point(236, 251)
        Me.lblTheme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(343, 29)
        Me.lblTheme.TabIndex = 14
        Me.lblTheme.Text = "ZZZZZZZZZZZZZZZZZZZZZZ"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(236, 200)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(343, 29)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "ZZZZZZZZZZZZZZZZZZZZZZ"
        '
        'lblPieces
        '
        Me.lblPieces.AutoSize = True
        Me.lblPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPieces.Location = New System.Drawing.Point(236, 92)
        Me.lblPieces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPieces.Name = "lblPieces"
        Me.lblPieces.Size = New System.Drawing.Size(73, 29)
        Me.lblPieces.TabIndex = 12
        Me.lblPieces.Text = "ZZZZ"
        '
        'lblSetNum
        '
        Me.lblSetNum.AutoSize = True
        Me.lblSetNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetNum.Location = New System.Drawing.Point(236, 26)
        Me.lblSetNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSetNum.Name = "lblSetNum"
        Me.lblSetNum.Size = New System.Drawing.Size(73, 29)
        Me.lblSetNum.TabIndex = 11
        Me.lblSetNum.Text = "ZZZZ"
        '
        'hdrTag
        '
        Me.hdrTag.AutoSize = True
        Me.hdrTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTag.Location = New System.Drawing.Point(26, 646)
        Me.hdrTag.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrTag.Name = "hdrTag"
        Me.hdrTag.Size = New System.Drawing.Size(62, 29)
        Me.hdrTag.TabIndex = 10
        Me.hdrTag.Text = "Tag:"
        '
        'hdrTime
        '
        Me.hdrTime.AutoSize = True
        Me.hdrTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTime.Location = New System.Drawing.Point(26, 592)
        Me.hdrTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrTime.Name = "hdrTime"
        Me.hdrTime.Size = New System.Drawing.Size(215, 29)
        Me.hdrTime.TabIndex = 9
        Me.hdrTime.Text = "Hours to complete:"
        '
        'hdrMinifig
        '
        Me.hdrMinifig.AutoSize = True
        Me.hdrMinifig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrMinifig.Location = New System.Drawing.Point(26, 528)
        Me.hdrMinifig.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrMinifig.Name = "hdrMinifig"
        Me.hdrMinifig.Size = New System.Drawing.Size(137, 29)
        Me.hdrMinifig.TabIndex = 8
        Me.hdrMinifig.Text = "Minifigures:"
        '
        'hdrLicensed
        '
        Me.hdrLicensed.AutoSize = True
        Me.hdrLicensed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrLicensed.Location = New System.Drawing.Point(26, 468)
        Me.hdrLicensed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrLicensed.Name = "hdrLicensed"
        Me.hdrLicensed.Size = New System.Drawing.Size(123, 29)
        Me.hdrLicensed.TabIndex = 7
        Me.hdrLicensed.Text = "Licensed?"
        '
        'hdrAge
        '
        Me.hdrAge.AutoSize = True
        Me.hdrAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrAge.Location = New System.Drawing.Point(27, 411)
        Me.hdrAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrAge.Name = "hdrAge"
        Me.hdrAge.Size = New System.Drawing.Size(74, 29)
        Me.hdrAge.TabIndex = 6
        Me.hdrAge.Text = "Ages:"
        '
        'hdrPrice
        '
        Me.hdrPrice.AutoSize = True
        Me.hdrPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrPrice.Location = New System.Drawing.Point(26, 355)
        Me.hdrPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrPrice.Name = "hdrPrice"
        Me.hdrPrice.Size = New System.Drawing.Size(75, 29)
        Me.hdrPrice.TabIndex = 5
        Me.hdrPrice.Text = "Price:"
        '
        'hdrMoving
        '
        Me.hdrMoving.AutoSize = True
        Me.hdrMoving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrMoving.Location = New System.Drawing.Point(26, 298)
        Me.hdrMoving.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrMoving.Name = "hdrMoving"
        Me.hdrMoving.Size = New System.Drawing.Size(183, 29)
        Me.hdrMoving.TabIndex = 4
        Me.hdrMoving.Text = "Moving Pieces?"
        '
        'hdrTheme
        '
        Me.hdrTheme.AutoSize = True
        Me.hdrTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrTheme.Location = New System.Drawing.Point(26, 251)
        Me.hdrTheme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrTheme.Name = "hdrTheme"
        Me.hdrTheme.Size = New System.Drawing.Size(96, 29)
        Me.hdrTheme.TabIndex = 3
        Me.hdrTheme.Text = "Theme:"
        '
        'hdrName
        '
        Me.hdrName.AutoSize = True
        Me.hdrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrName.Location = New System.Drawing.Point(26, 200)
        Me.hdrName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrName.Name = "hdrName"
        Me.hdrName.Size = New System.Drawing.Size(148, 29)
        Me.hdrName.TabIndex = 2
        Me.hdrName.Text = "Name of set:"
        '
        'hdrPieces
        '
        Me.hdrPieces.AutoSize = True
        Me.hdrPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrPieces.Location = New System.Drawing.Point(27, 92)
        Me.hdrPieces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrPieces.Name = "hdrPieces"
        Me.hdrPieces.Size = New System.Drawing.Size(138, 29)
        Me.hdrPieces.TabIndex = 1
        Me.hdrPieces.Text = "# of Pieces:"
        '
        'hdrSetNum
        '
        Me.hdrSetNum.AutoSize = True
        Me.hdrSetNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrSetNum.Location = New System.Drawing.Point(27, 26)
        Me.hdrSetNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hdrSetNum.Name = "hdrSetNum"
        Me.hdrSetNum.Size = New System.Drawing.Size(74, 29)
        Me.hdrSetNum.TabIndex = 0
        Me.hdrSetNum.Text = "Set #:"
        '
        'frmLegos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1456, 862)
        Me.Controls.Add(Me.pnlDisplayInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lstReadLegos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmLegos"
        Me.Text = " Lego Set Tracker"
        Me.pnlDisplayInfo.ResumeLayout(False)
        Me.pnlDisplayInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstReadLegos As ListBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlDisplayInfo As Panel
    Friend WithEvents hdrMoving As Label
    Friend WithEvents hdrTheme As Label
    Friend WithEvents hdrName As Label
    Friend WithEvents hdrPieces As Label
    Friend WithEvents hdrSetNum As Label
    Friend WithEvents hdrAge As Label
    Friend WithEvents hdrPrice As Label
    Friend WithEvents hdrLicensed As Label
    Friend WithEvents hdrMinifig As Label
    Friend WithEvents hdrTime As Label
    Friend WithEvents hdrTag As Label
    Friend WithEvents lblTag As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblMinifig As Label
    Friend WithEvents lblLicense As Label
    Friend WithEvents lblAges As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblMoving As Label
    Friend WithEvents lblTheme As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPieces As Label
    Friend WithEvents lblSetNum As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents hdrYear As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents btnDelete As Button
End Class
