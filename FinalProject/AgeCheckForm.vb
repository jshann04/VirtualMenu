'Program:  FinalProject AgeCheckForm
'Programmer: John Shannon
'Date: 12.7.2010
'Description: Checks customer age

Public Class AgeCheckForm

    Private Sub AgeCheckForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        'sets the combo boxes to contain all possible dates from 1900 to 2010
        For x = 1 To 31
            cmbDay.Items.Add(x.ToString("00"))
        Next

        For x = 1 To 12
            cmbMonth.Items.Add(x.ToString("00"))
        Next

        For x = 1900 To 2010
            cmbYear.Items.Insert(0, x.ToString())
        Next
        'selects the first available date #01/01/2010#
        cmbDay.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
        cmbYear.SelectedIndex = 0



    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim dateString As String
        dateString = cmbMonth.Text() & "/" & cmbDay.Text() & "/" & cmbYear.Text()
        'Checks if date is valid
        Try
            MainForm.dateCustomersAge = Date.Parse(dateString)
        Catch ex As Exception
            MessageBox.Show("Date entered is invalid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Me.Close()

    End Sub
End Class