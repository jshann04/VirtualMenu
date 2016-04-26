'Program:  Final Project Dinner Form
'Programmer: John Shannon
'Date: 12/2/10
'Description: Allows User to order dinner




Public Class DinnerForm


    Private Sub txtApp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbApp.SelectedIndexChanged
        Select Case cmbApp.SelectedIndex
            Case 0
                lblApp.Text = "$0.00"
            Case 1
                lblApp.Text = "$1.00"
            Case 2
                lblApp.Text = "$1.50"
            Case 3
                lblApp.Text = "$2.00"
        End Select
    End Sub

    Private Sub DinnerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & MainForm.txtCustomerName.Text
        cmbApp.SelectedIndex = 0
        cmbDessert.SelectedIndex = 0
        cmbDrink.SelectedIndex = 0
        cmbMain.SelectedIndex = 0
        cmbSide1.SelectedIndex = 0
        cmbSide2.SelectedIndex = 0

    End Sub

    Private Sub cmbMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMain.SelectedIndexChanged
        Select Case cmbMain.SelectedIndex
            Case 0
                lblMain.Text = "$0.00"
            Case 1
                lblMain.Text = "$6.50"
            Case 2
                lblMain.Text = "$10.00"
            Case 3
                lblMain.Text = "$9.50"
            Case 4
                lblMain.Text = "$12.80"
            Case 5
                lblMain.Text = "$5.00"

        End Select
    End Sub

    Private Sub cmbSide1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSide1.SelectedIndexChanged, cmbSide2.SelectedIndexChanged
        Dim lblFiller As Label
        lblFiller = New Label

        Select Case sender.SelectedIndex
            Case 0
                lblFiller.Text = "$0.00"
            Case 1
                lblFiller.Text = "$1.50"
            Case 2
                lblFiller.Text = "$1.95"
            Case 3
                lblFiller.Text = "$2.25"
            Case 4
                lblFiller.Text = "$2.50"
        End Select

        If (sender.name = "cmbSide1") Then
            lblSide1.Text = lblFiller.Text
        Else
            lblSide2.Text = lblFiller.Text
        End If

    End Sub

    Private Sub cmbDessert_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDessert.SelectedIndexChanged
        Select Case cmbDessert.SelectedIndex
            Case 0
                lblDessert.Text = "$0.00"
            Case 1
                lblDessert.Text = "$1.75"
            Case 2, 3
                lblDessert.Text = "$3.00"
            Case 4, 5
                lblDessert.Text = "$2.50"

        End Select
    End Sub

    Private Sub cmbDrink_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDrink.SelectedIndexChanged
        Select Case cmbDrink.SelectedIndex
            Case 0
                lblDrink.Text = "$0.00"
            Case 1
                lblDrink.Text = "$0.00"
            Case 2
                lblDrink.Text = "$1.00"
            Case 3 To 5
                lblDrink.Text = "$2.00"
            Case 6
                AgeCheckForm.ShowDialog()
                If DateDiff(DateInterval.Year, MainForm.dateCustomersAge, Today) > 21 Then
                    lblDrink.Text = "$3.00"
                Else
                    MessageBox.Show("Alcoholic beverages can only be sold to customers 21 and older", "Too Young", MessageBoxButtons.OK)
                    cmbDrink.SelectedIndex = 1
                End If

            Case 7
                AgeCheckForm.ShowDialog()
                If DateDiff(DateInterval.Year, MainForm.dateCustomersAge, Today) > 21 Then
                    lblDrink.Text = "$5.00"
                Else
                    MessageBox.Show("Alcoholic beverages can only be sold to customers 21 and older", "Too Young", MessageBoxButtons.OK)
                    cmbDrink.SelectedIndex = 1
                End If
        End Select
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click, ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click, ClearToolStripMenuItem.Click

        cmbApp.SelectedIndex = 0
        cmbDessert.SelectedIndex = 0
        cmbDrink.SelectedIndex = 0
        cmbMain.SelectedIndex = 0
        cmbSide1.SelectedIndex = 0
        cmbSide2.SelectedIndex = 0
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        MainForm.summaryString = summaryCreation()
        Dim answer As DialogResult
        answer = MessageBox.Show(MainForm.summaryString, "Order Summary", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If answer = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        My.Computer.FileSystem.WriteAllText(MainForm.fileName, MainForm.summaryString + Environment.NewLine, True)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

        'PrintDocument1.Print()

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        MainForm.summaryString = summaryCreation()
        MessageBox.Show(MainForm.summaryString, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function summaryCreation()
        Dim mainCourseString, appetizerString, side1String, side2String, dessertString, drinkString, subtotalString, taxString, totalString As String



        'detrmines subtotal, tax, and total (Does not use try catch because no lable text should be blank due to formating)
        MainForm.decSubtotal = Decimal.Parse(lblApp.Text.Substring(1)) + Decimal.Parse(lblDessert.Text.Substring(1)) + Decimal.Parse(lblDrink.Text.Substring(1)) + _
        Decimal.Parse(lblMain.Text.Substring(1)) + Decimal.Parse(lblSide1.Text.Substring(1)) + Decimal.Parse(lblSide2.Text.Substring(1))
        MainForm.decTax = MainForm.decSubtotal * MainForm.TAX_RATE_DECIMAL
        MainForm.decTotal = MainForm.decSubtotal + MainForm.decTax


        'determines the strings used to make the summary
        If cmbApp.SelectedIndex <> 0 Then
            appetizerString = "Appetizer: " + cmbApp.Text + " " + lblApp.Text + "." + Environment.NewLine
        Else
            appetizerString = ""
        End If
        If cmbMain.SelectedIndex <> 0 Then
            mainCourseString = "Main Course: " + cmbMain.Text + " " + lblMain.Text + "." + Environment.NewLine
        Else
            mainCourseString = ""
        End If
        If cmbSide1.SelectedIndex <> 0 Then
            side1String = "Side One: " + cmbSide1.Text + " " + lblSide1.Text + "." + Environment.NewLine
        Else
            side1String = ""
        End If
        If cmbSide2.SelectedIndex <> 0 Then
            side2String = "Side Two: " + cmbSide2.Text + " " + lblSide2.Text + "." + Environment.NewLine
        Else
            side2String = ""
        End If
        If cmbDessert.SelectedIndex <> 0 Then
            dessertString = "Dessert: " + cmbDessert.Text + " " + lblDessert.Text + "." + Environment.NewLine
        Else
            dessertString = ""
        End If
        If cmbDrink.SelectedIndex <> 0 Then
            drinkString = "Drink: " + cmbDrink.Text + " " + lblDrink.Text + "." + Environment.NewLine
        Else
            drinkString = ""
        End If
        subtotalString = "Subtotal: " + MainForm.decSubtotal.ToString("C") + Environment.NewLine
        taxString = "Tax: " + MainForm.decTax.ToString("C") + Environment.NewLine
        totalString = "Total: " + MainForm.decTotal.ToString("C") + Environment.NewLine

        Return Me.Text & Environment.NewLine & appetizerString & mainCourseString & side1String & side2String & _
        dessertString & drinkString & subtotalString & taxString & totalString

    End Function

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top

        e.Graphics.DrawString(MainForm.summaryString, New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub AppetizerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppetizerToolStripMenuItem.Click
        cmbApp.Focus()
    End Sub

    Private Sub MainCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainCourseToolStripMenuItem.Click
        cmbMain.Focus()
    End Sub

    Private Sub Side1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Side1ToolStripMenuItem.Click
        cmbSide1.Focus()
    End Sub

    Private Sub Side2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Side2ToolStripMenuItem.Click
        cmbSide2.Focus()
    End Sub

    Private Sub DessetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DessetToolStripMenuItem.Click
        cmbDessert.Focus()
    End Sub

    Private Sub DrinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrinkToolStripMenuItem.Click
        cmbDrink.Focus()
    End Sub
End Class