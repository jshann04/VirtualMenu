
'Program:       lunchForm
'Programmer:    Kathy Steele
'Date:          11-30-10
'Description:   Shows the message when user clicks a button.

'Modified: 12-06-2010
'Modified by: John Shannon
'Modifications: swaped item orders, included code to write to file.

Public Class LunchForm

    'Declare constants.
    Const TAX_RATE_Decimal As Decimal = 0.06D
    Const SANDWICH_PRICE_Decimal As Decimal = 5D
    Const PIZZA_PRICE_Decimal As Decimal = 3D
    Const SALAD_PRICE_Decimal As Decimal = 4.75D
    Const SIDESALAD_PRICE_Decimal As Decimal = 2D
    Const FRIES_PRICE_Decimal As Decimal = 1.5D
    Const ONIONRINGS_PRICE_Decimal As Decimal = 2D
    Const SODA_PRICE_Decimal As Decimal = 1.75D
    Const MILK_PRICE_Decimal As Decimal = 1.5D
    Const COFFEE_PRICE_Decimal As Decimal = 2D
    Const SOUP_PRICE_Decimal As Decimal = 1.5D
    Const NONE_PRICE_Decimal As Decimal = 0D

    Private decMain, decSoup, decSide, decDrink As Decimal

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Exits the form

        Me.Close()

    End Sub

    'next four display prices in real time
    Private Sub cmbMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMain.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 1
                decMain = SANDWICH_PRICE_Decimal
            Case 2
                decMain = PIZZA_PRICE_Decimal
            Case 3
                decMain = SALAD_PRICE_Decimal
            Case 0
                decMain = NONE_PRICE_Decimal
        End Select
        txtMain.Text = decMain.ToString("C")
    End Sub

    Private Sub cmbSoup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSoup.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 1
                decSoup = SOUP_PRICE_Decimal
            Case 2
                decSoup = SOUP_PRICE_Decimal
            Case 3
                decSoup = SOUP_PRICE_Decimal
            Case 0
                decSoup = NONE_PRICE_Decimal
        End Select
        txtSoup.Text = decSoup.ToString("C")
    End Sub

    Private Sub cmbSide_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSide.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 1
                decSide = FRIES_PRICE_Decimal
            Case 2
                decSide = SIDESALAD_PRICE_Decimal
            Case 3
                decSide = ONIONRINGS_PRICE_Decimal
            Case 0
                decSide = NONE_PRICE_Decimal
        End Select
        txtSide.Text = decSide.ToString("C")
    End Sub

    Private Sub cmbDrink_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDrink.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 0
                decDrink = NONE_PRICE_Decimal
            Case 1
                decDrink = SODA_PRICE_Decimal
            Case 2
                decDrink = MILK_PRICE_Decimal
            Case 3
                decDrink = COFFEE_PRICE_Decimal
        End Select
        txtDrink.Text = decDrink.ToString("C")
    End Sub

    'prints to preview or straight to printer and writes to text file
    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click

        Me.SummaryCreation()

        My.Computer.FileSystem.WriteAllText(MainForm.fileName, MainForm.summaryString & Environment.NewLine, True)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        'PrintDocument1.Print()
    End Sub

    'sets indexes to zero and clears subtotal, tax, and totals
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbDrink.SelectedIndex = 0
        cmbMain.SelectedIndex = 0
        cmbSide.SelectedIndex = 0
        cmbSoup.SelectedIndex = 0
        txtDrink.Clear()
        txtMain.Clear()
        txtSide.Clear()
        txtSoup.Clear()
        txtSubTotal.Clear()
        txtTax.Clear()
        txtTotal.Clear()

    End Sub

    'Make the subtotal, tax, and total appear in their text boxes
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        SubTaxTotal()

        txtSubTotal.Text = MainForm.decSubtotal.ToString("C")
        txtTax.Text = MainForm.decTax.ToString("C")
        txtTotal.Text = MainForm.decTotal.ToString("C")
    End Sub

    'Generates the summary used for 
    Private Sub SummaryCreation()
        MainForm.summaryString = Me.Text + Environment.NewLine
        SubTaxTotal()


        If cmbDrink.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Drink: " & cmbDrink.Text & " " & decDrink.ToString("C") & Environment.NewLine
        End If
        If cmbMain.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Main: " & cmbMain.Text & " " & decMain.ToString("C") & Environment.NewLine
        End If
        If cmbSide.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Side: " & cmbSide.Text & " " & decSide.ToString("C") & Environment.NewLine
        End If
        If cmbSoup.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Soup: " & cmbSoup.Text & " " & decSoup.ToString("C") & Environment.NewLine
        End If

        MainForm.summaryString = MainForm.summaryString & "Subtotal: " & MainForm.decTax.ToString("C") & Environment.NewLine & "Tax: " & MainForm.decTax.ToString("C") & _
        Environment.NewLine & "Total: " & MainForm.decTotal.ToString("C") & Environment.NewLine

    End Sub

    'Calculates the subtotal, tax and total for the order
    Private Sub SubTaxTotal()
        MainForm.decSubtotal = decMain + decDrink + decSide + decSoup
        MainForm.decTax = MainForm.TAX_RATE_DECIMAL * MainForm.decSubtotal
        MainForm.decTotal = MainForm.decTax + MainForm.decSubtotal
    End Sub

    'sets all indexes to 0 ("nothing")
    Private Sub lunchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = Me.Text & MainForm.txtCustomerName.Text


        cmbDrink.SelectedIndex = 0
        cmbMain.SelectedIndex = 0
        cmbSide.SelectedIndex = 0
        cmbSoup.SelectedIndex = 0
    End Sub

    'Sets up the summary to print on paper
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top

        e.Graphics.DrawString(MainForm.summaryString, New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub MainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainToolStripMenuItem.Click
        cmbMain.Focus()
    End Sub

    Private Sub SoupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoupToolStripMenuItem.Click
        cmbSoup.Focus()
    End Sub

    Private Sub SideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideToolStripMenuItem.Click
        cmbSide.Focus()
    End Sub

    Private Sub DrinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrinkToolStripMenuItem.Click
        cmbDrink.Focus()
    End Sub
End Class
