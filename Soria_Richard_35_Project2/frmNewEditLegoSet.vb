'***************************************************************
'* Name:       Richard Soria
'* File:       frmNewEditLegoSet.vb
'* Purpose:    Form where user can create new or edit Lego Sets
'***************************************************************

Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.IO
Imports System.Text
Public Class frmNewEditLegoSet
    Dim theLegoSet As LegoInfo
    Dim newFlag As Boolean

    Private Const FILENAME1 As String = "Themes.txt"
    Private Const FILENAME2 As String = "YearReleased.txt"

    Private Const FILENAME As String = "StoredData.txt"
    Private Const MAX_LINES As Integer = 1000
    Dim price As String
    Dim hours As String



    Private Sub frmNewEditLegoSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromFiles()
    End Sub

    Private Sub LoadFromFiles()
        Dim infile As IO.StreamReader
        Dim temp As String
        Dim temp2 As String

        If Not File.Exists(FILENAME1) Then
            MsgBox("The file does not exist")
            Return
        End If

        If Not File.Exists(FILENAME2) Then
            MsgBox("The file does not exist")
            Return
        End If

        infile = File.OpenText(FILENAME1)

        Do Until infile.Peek = -1
            temp = infile.ReadLine()

            lstThemes.Items.Add(temp)
        Loop



        infile = File.OpenText(FILENAME2)

        Do Until infile.Peek = -1
            temp2 = infile.ReadLine()


            ddlYears.Items.Add(temp2)

        Loop

    End Sub


    Public Sub New(pLego As LegoInfo, pNewFlag As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        theLegoSet = pLego
        newFlag = pNewFlag

        'Changes the title of the form depending on what is clicked
        'This is the correct way to do it
        If (newFlag) Then
            Me.Text = "New Lego Set (Richard Soria #35)"
            btnSave.Text = "&Add Lego Set"
            txtSetNum.Select()
        Else
            Me.Text = "Edit Lego Set (Richard Soria #35)"
            btnSave.Text = "&Save"
            txtSetNum.Text = theLegoSet.SetNum
            txtPieces.Text = theLegoSet.Pieces
            txtName.Text = theLegoSet.Name
            txtPrice.Text = theLegoSet.Price
            txtMinifigures.Text = theLegoSet.Minifigures
            txtTag.Text = theLegoSet.Tags

            If theLegoSet.movingPieces = "1" Then
                chkMoving.Checked = True
            Else
                chkMoving.Checked = False
            End If

            If theLegoSet.Licensed = "1" Then
                chkLicense.Checked = True
            Else
                chkLicense.Checked = False
            End If

            If theLegoSet.Age = "1-2" Then
                radToddler.Checked = True
            ElseIf theLegoSet.Age = "3-5" Then
                radYoungChildren.Checked = True
            ElseIf theLegoSet.Age = "6-8" Then
                radChildren.Checked = True
            ElseIf theLegoSet.Age = "9-11" Then
                radOlderChild.Checked = True
            ElseIf theLegoSet.Age = "12+" Then
                radPreteen.Checked = True
            End If

            nudHours.Value = CDec(theLegoSet.Time)



            'Couldn't get this to work
            'Need to fix drop down list And list box
            'lstThemes.SelectedItem.ToString(theLegoSet.Theme)
            'ddlYears.SelectedItem = theLegoSet.Year


        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        lblSetError.Visible = False
        lblYearError.Visible = False
        lblTagError.Visible = False
        lblThemeError.Visible = False
        lblAgeError.Visible = False
        lblMovingError.Visible = False
        lblLicenseError.Visible = False
        lblMinifigError.Visible = False
        lblHoursError.Visible = False
        lblNameError.Visible = False
        lblPriceError.Visible = False
        lblPiecesError.Visible = False




        'Defensive programming - Checking if theres anything in the input controls
        If txtSetNum.Text = "" Then
            txtSetNum.Select()
            txtSetNum.SelectAll()
            lblSetError.Visible = True
            MsgBox("You must enter a Set Number.", MsgBoxStyle.Critical, "Error")
            lblSetError.Visible = True
            Return
        ElseIf txtPieces.Text = "" Then
            txtPieces.Select()
            txtPieces.SelectAll()
            lblPiecesError.Visible = True
            MsgBox("You must enter a number for pieces.", MsgBoxStyle.Critical, "Error")
            lblPiecesError.Visible = True
            Return
        ElseIf txtName.Text = "" Then
            txtName.Select()
            txtName.SelectAll()
            lblNameError.Visible = True
            MsgBox("You must enter a Set Name.", MsgBoxStyle.Critical, "Error")
            lblNameError.Visible = True
            Return
        ElseIf txtPrice.Text = "" Then
            txtPrice.Select()
            txtPrice.SelectAll()
            lblPriceError.Visible = True
            MsgBox("You must enter a price.", MsgBoxStyle.Critical, "Error")
            lblPriceError.Visible = True
            Return
        ElseIf txtMinifigures.Text = "" Then
            txtMinifigures.Select()
            txtMinifigures.SelectAll()
            lblMinifigError.Visible = True
            MsgBox("You must enter a number of minifigures.", MsgBoxStyle.Critical, "Error")
            lblMinifigError.Visible = True
            Return
        ElseIf txtTag.Text = "" Then
            txtTag.Select()
            txtTag.SelectAll()
            lblTagError.Visible = True
            MsgBox("You must enter a tag.", MsgBoxStyle.Critical, "Error")
            lblTagError.Visible = True
            Return
        ElseIf lstThemes.SelectedIndex = -1 Then
            lblThemeError.Visible = True
            MsgBox("You must select a theme.", MsgBoxStyle.Critical, "Error")
            lblThemeError.Visible = True
            Return
        ElseIf ddlYears.SelectedIndex = -1 Then
            lblYearError.Visible = True
            MsgBox("You must select a year.", MsgBoxStyle.Critical, "Error")
            lblYearError.Visible = True
            Return
        End If

        'theme = lstThemes.SelectedItem.ToString()
        'year = ddlYears.SelectedItem.ToString()

        If radToddler.Checked Then
            theLegoSet.Age = "1-2"
        ElseIf radYoungChildren.Checked Then
            theLegoSet.Age = "3-5"
        ElseIf radChildren.Checked Then
            theLegoSet.Age = "6-8"
        ElseIf radOlderChild.Checked Then
            theLegoSet.Age = "9-11"
        ElseIf radPreteen.Checked Then
            theLegoSet.Age = "12+"
        Else
            lblAgeError.Visible = True
            MsgBox("You must select an age.", MsgBoxStyle.Critical, "Error")
            lblAgeError.Visible = True
            Return
        End If

        If chkMoving.Checked Then
            theLegoSet.movingPieces = "1"
        Else
            theLegoSet.movingPieces = "0"
        End If

        If chkLicense.Checked Then
            theLegoSet.Licensed = "1"
        Else
            theLegoSet.Licensed = "0"
        End If

        If txtSetNum.Text.Length() < 4 Then
            txtSetNum.Select()
            txtSetNum.SelectAll()
            lblSetError.Visible = True
            MsgBox("You must enter at least 4 digits for Set Number.", MsgBoxStyle.Critical, "Error")
            lblSetError.Visible = True
            Return
        End If

        If txtPrice.Text Like "###.##" Then
            price = txtPrice.ToString()
        ElseIf txtPrice.Text Like "##.##" Then
            price = txtPrice.ToString()
        ElseIf txtPrice.Text Like "#.##" Then
            price = txtPrice.ToString()
        Else
            txtPrice.Select()
            txtPrice.SelectAll()
            lblPriceError.Visible = True
            MsgBox("The price must be in the format of #.## or ##.## or ###.##.", MsgBoxStyle.Critical, "Error")
            lblPriceError.Visible = True
            Return
        End If


        If nudHours.Value <= 0 Then
            lblHoursError.Visible = True
            MsgBox("You must enter a value greater than 0.", MsgBoxStyle.Critical, "Error")
            lblHoursError.Visible = True
            Return
        Else
            hours = nudHours.Value.ToString()
        End If



        theLegoSet.SetNum = txtSetNum.Text
        theLegoSet.Pieces = txtPieces.Text
        theLegoSet.Name = txtName.Text
        theLegoSet.Price = txtPrice.Text
        theLegoSet.Minifigures = txtMinifigures.Text
        theLegoSet.Time = nudHours.Value.ToString()
        theLegoSet.Tags = txtTag.Text



        theLegoSet.Theme = lstThemes.SelectedItem.ToString()
        theLegoSet.Year = ddlYears.SelectedItem.ToString()

        If btnSave.Text = "&Add Lego Set" Then
            Dim outFile As IO.StreamWriter

            outFile = File.AppendText(FILENAME)

            outFile.WriteLine(theLegoSet.SetNum & "|" & theLegoSet.Pieces & "|" & theLegoSet.Year _
                & "|" & theLegoSet.Name & "|" & theLegoSet.Theme & "|" & theLegoSet.movingPieces _
                & "|" & theLegoSet.Price & "|" & theLegoSet.Age & "|" & theLegoSet.Licensed _
                & "|" & theLegoSet.Minifigures & "|" & theLegoSet.Time & "|" & theLegoSet.Tags)

            outFile.Close()


        End If

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim msgboxResult As Integer


        msgboxResult = MsgBox("Are you sure you want to clear the inputs?",
           MsgBoxStyle.YesNo, "Confirmation")

        If msgboxResult = DialogResult.Yes Then
            txtSetNum.Clear()
            txtPieces.Clear()
            txtName.Clear()
            txtPrice.Clear()
            txtTag.Clear()
            txtMinifigures.Clear()

            ddlYears.SelectedIndex = -1
            nudHours.Value = 0
            lstThemes.SelectedIndex = -1

            chkLicense.Checked = False
            chkMoving.Checked = False
            radToddler.Checked = False
            radYoungChildren.Checked = False
            radChildren.Checked = False
            radOlderChild.Checked = False
            radPreteen.Checked = False
        End If



    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim msgboxResult As Integer


        msgboxResult = MsgBox("Are you sure you want to cancel your changes? Your changes will be lost.",
           MsgBoxStyle.YesNo, "Confirmation")

        If msgboxResult = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub


    Private Sub txtSetNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSetNum.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
        End If

        If e.KeyChar = "|" Then
            e.Handled = True
        End If

        If e.KeyChar = "." Then
            e.Handled = True
        End If

        If e.KeyChar = "=" Then
            e.Handled = True
        End If

        If e.KeyChar = "/" Then
            e.Handled = True
        End If

        If e.KeyChar = "," Then
            e.Handled = True
        End If

        If e.KeyChar = "'" Then
            e.Handled = True
        End If

        If e.KeyChar = ":" Then
            e.Handled = True
        End If

        If e.KeyChar = ";" Then
            e.Handled = True
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If e.KeyChar = "[" Then
            e.Handled = True
        End If

        If e.KeyChar = "]" Then
            e.Handled = True
        End If

        If e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPieces_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPieces.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
        End If

        If e.KeyChar = "." Then
            e.Handled = True
        End If

        If e.KeyChar = "=" Then
            e.Handled = True
        End If

        If e.KeyChar = "/" Then
            e.Handled = True
        End If

        If e.KeyChar = "|" Then
            e.Handled = True
        End If

        If e.KeyChar = "," Then
            e.Handled = True
        End If

        If e.KeyChar = "'" Then
            e.Handled = True
        End If

        If e.KeyChar = ":" Then
            e.Handled = True
        End If

        If e.KeyChar = ";" Then
            e.Handled = True
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If e.KeyChar = "[" Then
            e.Handled = True
        End If

        If e.KeyChar = "]" Then
            e.Handled = True
        End If

        If e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMinifigures_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinifigures.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
        End If

        If e.KeyChar = "." Then
            e.Handled = True
        End If

        If e.KeyChar = "=" Then
            e.Handled = True
        End If

        If e.KeyChar = "|" Then
            e.Handled = True
        End If

        If e.KeyChar = "/" Then
            e.Handled = True
        End If

        If e.KeyChar = "," Then
            e.Handled = True
        End If

        If e.KeyChar = "'" Then
            e.Handled = True
        End If

        If e.KeyChar = ":" Then
            e.Handled = True
        End If

        If e.KeyChar = ";" Then
            e.Handled = True
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If e.KeyChar = "[" Then
            e.Handled = True
        End If

        If e.KeyChar = "]" Then
            e.Handled = True
        End If

        If e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
        End If

        If e.KeyChar = "=" Then
            e.Handled = True
        End If

        If e.KeyChar = "/" Then
            e.Handled = True
        End If

        If e.KeyChar = "|" Then
            e.Handled = True
        End If

        If e.KeyChar = "," Then
            e.Handled = True
        End If

        If e.KeyChar = "'" Then
            e.Handled = True
        End If

        If e.KeyChar = ":" Then
            e.Handled = True
        End If

        If e.KeyChar = ";" Then
            e.Handled = True
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If e.KeyChar = "[" Then
            e.Handled = True
        End If

        If e.KeyChar = "]" Then
            e.Handled = True
        End If

        If e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
        End If

        If e.KeyChar = "." Then
            e.Handled = True
        End If

        If e.KeyChar = "=" Then
            e.Handled = True
        End If

        If e.KeyChar = "|" Then
            e.Handled = True
        End If

        If e.KeyChar = "/" Then
            e.Handled = True
        End If

        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If e.KeyChar = "[" Then
            e.Handled = True
        End If

        If e.KeyChar = "]" Then
            e.Handled = True
        End If

        If e.KeyChar = "-" Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtTag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTag.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
        End If

        If e.KeyChar = "." Then
            e.Handled = True
        End If

        If e.KeyChar = "=" Then
            e.Handled = True
        End If

        If e.KeyChar = "|" Then
            e.Handled = True
        End If

        If e.KeyChar = "/" Then
            e.Handled = True
        End If

        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If e.KeyChar = "[" Then
            e.Handled = True
        End If

        If e.KeyChar = "]" Then
            e.Handled = True
        End If

        If e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub
End Class