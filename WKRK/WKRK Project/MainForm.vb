'Project:Name : WKRK Solution
'Purpose:Saving votes from the callers in the text file
'Created/Edited: Srikanth.bandi/ (11/26/2016)

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    'declaring variables
    Private total_Bud As Integer
    Private total_pepsi As Integer
    Private total_fedex As Integer
    Private total_etrade As Integer


    'code for exit button
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        commercialListBox.Items.Add("Budweiser")
        commercialListBox.Items.Add("Fed-Ex")
        commercialListBox.Items.Add("E-Trade")
        commercialListBox.Items.Add("Pepsi")
    End Sub


    Private Sub savevoteButton_Click(sender As Object, e As EventArgs) Handles savevoteButton.Click
        Dim vote As Integer
        vote = commercialListBox.SelectedIndex
        If (vote = 0) Then
            total_Bud += 1
        ElseIf (vote = 1) Then
            total_fedex += 1
        ElseIf (vote = 2) Then
            total_etrade += 1
        ElseIf (vote = 3) Then
            total_pepsi += 1
        End If
        'writes the  data to a text file
        Dim outFile As IO.StreamWriter
        Dim heading As String =
        "Commercial" & Strings.Space(5) & "Votes"
        outFile = IO.File.CreateText("Commercial.txt")
        outFile.WriteLine(heading)

        outFile.WriteLine("Budweiser = " & Strings.Space(5) & total_Bud)
        outFile.WriteLine("Etrade = " & Strings.Space(5) & total_etrade)
        outFile.WriteLine("Pepsi = " & Strings.Space(5) & total_pepsi)
        outFile.WriteLine("FedEx = " & Strings.Space(5) & total_fedex)
        outFile.Close()


    End Sub


    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        pepsidisplayLabel.Text = total_pepsi.ToString
        fedexdisplayLabel.Text = total_fedex.ToString
        etradedisplayLabel.Text = total_etrade.ToString
        budwesierdisplayLabel.Text = total_Bud.ToString
    End Sub
End Class
