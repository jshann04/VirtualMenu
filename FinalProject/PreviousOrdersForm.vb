Public Class PreviousOrdersForm

    Private Sub PreviousOrdersForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim dateholder As Date
        Dim dateString As String
        Dim previousFileName As String
        Dim oldsummary As String
        dateString = cmbMonth.Text() & "/" & cmbDay.Text() & "/" & cmbYear.Text()
        'tests for valid date
        Try
            dateholder = Date.Parse(dateString)
        Catch ex As Exception
            MessageBox.Show("Date entered is invalid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        'Tests for existing files
        Try
            previousFileName = "OrdersFor" & dateholder.ToString("MM_dd_yyy") & ".txt"
            oldsummary = My.Computer.FileSystem.ReadAllText(previousFileName)
        Catch ex As Exception
            MessageBox.Show("No recodered orders for that date", "No Orders", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        'displays the orders made that date.
        MessageBox.Show(oldsummary, "Orders for " & dateholder, MessageBoxButtons.OK)

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class