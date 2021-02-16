'***************************************************************
'* Name:       Richard Soria
'* File:       frmLegos.vb
'* Purpose:    Application that CRUDs information on lego sets
'***************************************************************

Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.IO
Imports System.Text

Public Class frmLegos
    'Can hold up to to 1000 lego sets
    Private LegoArray(999) As LegoInfo
    Private LegoSets As Integer = 0

    Private Const FILENAME As String = "StoredData.txt"
    Private Const MAX_LINES As Integer = 1000

    Private Sub frmLegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromFile()
    End Sub


    Private Sub LoadFromFile()
        Dim infile As IO.StreamReader
        Dim temp As String
        Dim splitString As String()

        If Not File.Exists(FILENAME) Then
            MsgBox("The file does not exist")
            Return
        ElseIf File.Exists(FILENAME) Then
            lstReadLegos.Items.Clear()
        End If
        'Need to reset LegoSet number to read from file
        LegoSets = 0

        infile = File.OpenText(FILENAME)



        Do Until infile.Peek = -1
            temp = infile.ReadLine()
            If (temp.Contains("|"c)) Then
                splitString = temp.Split("|"c)

                'Loading new array
                LegoArray(LegoSets) = New LegoInfo()

                LegoArray(LegoSets).SetNum = splitString(0)
                LegoArray(LegoSets).Pieces = splitString(1)
                LegoArray(LegoSets).Year = splitString(2)
                LegoArray(LegoSets).Name = splitString(3)
                LegoArray(LegoSets).Theme = splitString(4)
                LegoArray(LegoSets).movingPieces = splitString(5)
                LegoArray(LegoSets).Price = splitString(6)
                LegoArray(LegoSets).Age = splitString(7)
                LegoArray(LegoSets).Licensed = splitString(8)
                LegoArray(LegoSets).Minifigures = splitString(9)
                LegoArray(LegoSets).Time = splitString(10)
                LegoArray(LegoSets).Tags = splitString(11)


                lstReadLegos.Items.Add(LegoArray(LegoSets).SetNum.PadRight(5) _
                                       & LegoArray(LegoSets).Theme.PadRight(20) _
                                       & LegoArray(LegoSets).Name)
                LegoSets += 1
            Else
                Return
            End If


        Loop

        infile.Close()

    End Sub

    Private Sub lstReadLegos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReadLegos.SelectedValueChanged
        If lstReadLegos.SelectedIndex <> -1 Then

            pnlDisplayInfo.Visible = True
            lblSetNum.Text = LegoArray(lstReadLegos.SelectedIndex).SetNum
            lblPieces.Text = LegoArray(lstReadLegos.SelectedIndex).Pieces
            lblYear.Text = LegoArray(lstReadLegos.SelectedIndex).Year
            lblName.Text = LegoArray(lstReadLegos.SelectedIndex).Name
            lblTheme.Text = LegoArray(lstReadLegos.SelectedIndex).Theme
            lblMoving.Text = LegoArray(lstReadLegos.SelectedIndex).movingPieces
            lblPrice.Text = LegoArray(lstReadLegos.SelectedIndex).Price
            lblAges.Text = LegoArray(lstReadLegos.SelectedIndex).Age
            lblLicense.Text = LegoArray(lstReadLegos.SelectedIndex).Licensed
            lblMinifig.Text = LegoArray(lstReadLegos.SelectedIndex).Minifigures
            lblTime.Text = LegoArray(lstReadLegos.SelectedIndex).Time
            lblTag.Text = LegoArray(lstReadLegos.SelectedIndex).Tags
        End If

        If lblMoving.Text = "1" Then
            lblMoving.Text = "Yes"
        Else
            lblMoving.Text = "No"
        End If

        If lblLicense.Text = "1" Then
            lblLicense.Text = "Yes"
        Else
            lblLicense.Text = "No"
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim newLegoForm As frmNewEditLegoSet
        Dim myLegoSet As LegoInfo
        myLegoSet = New LegoInfo()
        newLegoForm = New frmNewEditLegoSet(myLegoSet, True)
        newLegoForm.ShowDialog()



        If myLegoSet.SetNum <> "" Then
            LegoArray(LegoSets) = myLegoSet
            LegoSets += 1
            lstReadLegos.Items.Add(myLegoSet.SetNum.PadRight(5) & myLegoSet.Theme.PadRight(20) _
                & myLegoSet.Name)

            'Better way to print out information
            lstReadLegos.SelectedIndex = -1
            lstReadLegos.SelectedIndex = LegoSets - 1

        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim editLegoSetForm As frmNewEditLegoSet
        editLegoSetForm = New frmNewEditLegoSet(LegoArray(lstReadLegos.SelectedIndex), False)
        editLegoSetForm.ShowDialog()


        If lstReadLegos.SelectedIndex <> -1 Then
            LegoArray(LegoSets) = LegoArray(lstReadLegos.SelectedIndex)

            lstReadLegos.Items(lstReadLegos.SelectedIndex) = (LegoArray(lstReadLegos.SelectedIndex).SetNum.PadRight(5) _
                & LegoArray(lstReadLegos.SelectedIndex).Theme.PadRight(20) & LegoArray(lstReadLegos.SelectedIndex).Name)
        End If

        WriteOutToFile(LegoArray)
    End Sub


    Private Sub WriteOutToFile(LegoSet As Object)
        Dim outfile As IO.StreamWriter

        outfile = File.CreateText(FILENAME)


        For counter As Integer = 0 To LegoSets - 1
            outfile.WriteLine(LegoArray(counter).SetNum & "|" & LegoArray(counter).Pieces & "|" _
                & LegoArray(counter).Year & "|" & LegoArray(counter).Name & "|" & LegoArray(counter).Theme _
                & "|" & LegoArray(counter).movingPieces & "|" & LegoArray(counter).Price & "|" & LegoArray(counter).Age _
                & "|" & LegoArray(counter).Licensed & "|" & LegoArray(counter).Minifigures & "|" & LegoArray(counter).Time _
                & "|" & LegoArray(counter).Tags)

        Next
        outfile.Close()

    End Sub


    'First delete items from file
    'Then reload array with items from file
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim msgboxResult As Integer


        msgboxResult = MsgBox("Are you sure you want to delete this item? It will be permanently lost.",
           MsgBoxStyle.YesNo, "Confirmation")

        If msgboxResult = DialogResult.Yes Then
            pnlDisplayInfo.Visible = False

            'Destroy contenets of file and write values except current value using array
            Dim outfile As IO.StreamWriter

            outfile = File.CreateText(FILENAME)

            For counter As Integer = 0 To LegoSets - 1
                If counter <> lstReadLegos.SelectedIndex Then
                    outfile.WriteLine(LegoArray(counter).SetNum & "|" & LegoArray(counter).Pieces & "|" _
                    & LegoArray(counter).Year & "|" & LegoArray(counter).Name & "|" & LegoArray(counter).Theme _
                    & "|" & LegoArray(counter).movingPieces & "|" & LegoArray(counter).Price & "|" & LegoArray(counter).Age _
                    & "|" & LegoArray(counter).Licensed & "|" & LegoArray(counter).Minifigures & "|" & LegoArray(counter).Time _
                    & "|" & LegoArray(counter).Tags)

                End If
            Next
            outfile.Close()
            lstReadLegos.Items.Clear()
            LoadFromFile()

        End If


    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim newAboutForm As frmAboutPage

        newAboutForm = New frmAboutPage()
        newAboutForm.ShowDialog()

    End Sub

    Private Sub lstReadLegos_DoubleClick(sender As Object, e As EventArgs) Handles lstReadLegos.DoubleClick
        btnChange_Click(Nothing, Nothing)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
