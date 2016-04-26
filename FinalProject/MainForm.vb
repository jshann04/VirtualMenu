'Program:  FinalProject: MainForm
'Programmer: John Shannon
'Date: 12.7.2010
'Description: Base for project, send to other order types, summary of today's and past orders, and prints paper menu on request




Public Class MainForm
    Friend todaysdate As String = Format(Today, "MM_dd_yyyy")
    Friend fileName As String = "OrdersFor" & todaysdate & ".txt"
    Friend Const TAX_RATE_DECIMAL As Decimal = 0.06
    Friend summaryString As String
    Friend decSubtotal, decTotal, decTax As Decimal
    Friend dateCustomersAge As Date


    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click, OrderToolStripMenuItem.Click

        'creates file to save orders to
        If Not My.Computer.FileSystem.FileExists(fileName) Then
            My.Computer.FileSystem.WriteAllText(fileName, "These are the sales on " + todaysdate + Environment.NewLine + Environment.NewLine, False)
        End If
        'decides and sends user to proper order form
        If (radDinner.Checked) Then
            DinnerForm.ShowDialog()
        ElseIf radLunch.Checked Then
            LunchForm.ShowDialog()
        Else
            BreakfastForm.ShowDialog()
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCustomer.Click, NewCustomerToolStripMenuItem.Click
        'clears name and selects breakfast
        txtCustomerName.Clear()
        radBreakfast.Checked = True
        txtCustomerName.Focus()
    End Sub

    Private Sub btnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSummary.Click, SummaryToolStripMenuItem.Click
        Dim OrdersString As String
        'checks for orders for today
        Try
            OrdersString = My.Computer.FileSystem.ReadAllText(fileName)
            MessageBox.Show(OrdersString, "Summary of Todays Orders", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("There are no records for today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub RestaurantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub


    Private Sub OrderingDirectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderingDirectionsToolStripMenuItem.Click
        'Helps with order directions
        OrderingAboutBox.ShowDialog()
    End Sub

    Private Sub lblPaperMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPaperMenu.Click, PaperMenuToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim x As Integer
        'Prints paper menu
        e.Graphics.DrawString("Menu", New Font("Ariel", 60), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 80



        e.Graphics.DrawString("BreakFast", New Font("Ariel", 30), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 45
        e.Graphics.DrawString("Meat", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < BreakfastForm.MeatComboBox.Items.Count
            e.Graphics.DrawString(BreakfastForm.MeatComboBox.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Eggs", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < BreakfastForm.EggsComboBox.Items.Count
            e.Graphics.DrawString(BreakfastForm.EggsComboBox.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Potato", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < BreakfastForm.PotatoComboBox.Items.Count
            e.Graphics.DrawString(BreakfastForm.PotatoComboBox.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Drinks", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < BreakfastForm.DrinkComboBox.Items.Count
            e.Graphics.DrawString(BreakfastForm.DrinkComboBox.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While



        'next menu items


        e.Graphics.DrawString("Lunch", New Font("Ariel", 30), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 45
        e.Graphics.DrawString("Main", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < LunchForm.cmbMain.Items.Count
            e.Graphics.DrawString(LunchForm.cmbMain.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Side", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < LunchForm.cmbSide.Items.Count
            e.Graphics.DrawString(LunchForm.cmbSide.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Soup", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < LunchForm.cmbSoup.Items.Count
            e.Graphics.DrawString(LunchForm.cmbSoup.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Drinks", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < LunchForm.cmbDrink.Items.Count
            e.Graphics.DrawString(LunchForm.cmbDrink.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        'reset print to right section of page

        HorizontalPrintLocationSingle = (e.MarginBounds.Right) * 0.6
        VerticalPrintLocationSingle = e.MarginBounds.Top + 80


        'print out dinner items

        e.Graphics.DrawString("Dinner", New Font("Ariel", 30), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 45

        e.Graphics.DrawString("Appetizer", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < DinnerForm.cmbApp.Items.Count
            e.Graphics.DrawString(DinnerForm.cmbApp.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While
        e.Graphics.DrawString("Main", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < DinnerForm.cmbMain.Items.Count
            e.Graphics.DrawString(DinnerForm.cmbMain.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Sides", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < DinnerForm.cmbSide1.Items.Count
            e.Graphics.DrawString(DinnerForm.cmbSide1.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Desserts", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < DinnerForm.cmbDessert.Items.Count
            e.Graphics.DrawString(DinnerForm.cmbDessert.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

        e.Graphics.DrawString("Drinks", New Font("Ariel", 20), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 35
        x = 1
        While x < DinnerForm.cmbDrink.Items.Count
            e.Graphics.DrawString(DinnerForm.cmbDrink.Items.Item(x), New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 15
            x += 1
        End While

    End Sub

 
    Private Sub lblPaperMenu_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPaperMenu.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub lblPaperMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPaperMenu.MouseLeave
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnPreviousSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousSummary.Click
        PreviousOrdersForm.ShowDialog()
    End Sub
End Class
