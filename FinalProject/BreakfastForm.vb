'Program:  FinalProject: BreakfastForm
'Programmer: Sarah Logan
'Date: 
'Description: 


Public Class BreakfastForm

    'Declare constants.
    Const TAX_RATE_Decimal As Decimal = 0.06D
    Const SAUSAGE_PRICE_Decimal As Decimal = 2D
    Const HAM_PRICE_Decimal As Decimal = 2D
    Const BACON_PRICE_Decimal As Decimal = 2D
    Const HASH_BROWNS_PRICE_Decimal As Decimal = 2.5D

    Const COTTAGE_FRIES_Decimal As Decimal = 2.5D
    Const COFFEE_PRICE_Decimal As Decimal = 1D
    Const ORANGE_JUICE_PRICE_Decimal As Decimal = 1.25D
    Const SCRAMBLED_PRICE_Decimal As Decimal = 2.5D
    Const OVER_EASY_PRICE_Decimal As Decimal = 2.5D
    Const SUNNY_SIDE_UP_PRICE_Decimal As Decimal = 2.5D
    Const NONE_PRICE_Decimal As Decimal = 0D
    Private decMeat, decEggs, decDrink, decPotato As Decimal

    Private Sub MeatComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeatComboBox.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 0
                decMeat = NONE_PRICE_Decimal
            Case 1
                decMeat = SAUSAGE_PRICE_Decimal
            Case 2
                decMeat = HAM_PRICE_Decimal
            Case 3
                decMeat = BACON_PRICE_Decimal
        End Select
        LblMeatPrice.Text = decMeat.ToString("C")


    End Sub

    Private Sub Exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitbutton.Click
        Me.Close()
    End Sub

    Private Sub Clearbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearbutton.Click
        'resets selections
        MeatComboBox.SelectedIndex = 0
        PotatoComboBox.SelectedIndex = 0
        EggsComboBox.SelectedIndex = 0
        DrinkComboBox.SelectedIndex = 0

        taxTextBox.Clear()
        subtotalTextBox.Clear()
        totalTextBox.Clear()

    End Sub

    Private Sub Calculatebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculatebutton.Click
        SubTaxTotal()
        subtotalTextBox.Text = MainForm.decSubtotal.ToString("C")
        taxTextBox.Text = MainForm.decTax.ToString("C")
        totalTextBox.Text = MainForm.decTotal.ToString("C")
    End Sub


    Private Sub PotatoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PotatoComboBox.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 0
                LblPotatoPrice.Text = NONE_PRICE_Decimal.ToString
                decPotato = NONE_PRICE_Decimal
            Case 1
                decPotato = HASH_BROWNS_PRICE_Decimal
            Case 2
                decPotato = COTTAGE_FRIES_Decimal

        End Select

        LblPotatoPrice.Text = decPotato.ToString("C")

    End Sub

    Private Sub DrinkComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrinkComboBox.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 0
                LblDrinkPrice.Text = NONE_PRICE_Decimal.ToString
                decDrink = NONE_PRICE_Decimal
            Case 1
                decDrink = COFFEE_PRICE_Decimal
            Case 2
                decDrink = ORANGE_JUICE_PRICE_Decimal

        End Select
        LblDrinkPrice.Text = decDrink.ToString("C")
    End Sub

    Private Sub EggsComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EggsComboBox.SelectedIndexChanged
        Select Case sender.selectedindex
            Case 0
                LblEggsPrice.Text = NONE_PRICE_Decimal.ToString
                decEggs = NONE_PRICE_Decimal
            Case 1
                decEggs = SCRAMBLED_PRICE_Decimal
            Case 2
                decEggs = OVER_EASY_PRICE_Decimal
            Case 3
                decEggs = SUNNY_SIDE_UP_PRICE_Decimal

        End Select
        LblEggsPrice.Text = decEggs.ToString("C")
    End Sub

    Private Sub BreakfastForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MeatComboBox.SelectedIndex = 0
        EggsComboBox.SelectedIndex = 0
        DrinkComboBox.SelectedIndex = 0
        PotatoComboBox.SelectedIndex = 0
    End Sub

    Private Sub SubTaxTotal()
        'Calculates the subtotal
        MainForm.decSubtotal = decDrink + decEggs + decMeat + decPotato
        MainForm.decTax = MainForm.TAX_RATE_DECIMAL * MainForm.decSubtotal
        MainForm.decTotal = MainForm.decTax + MainForm.decSubtotal
    End Sub

    Private Sub Orderbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Orderbutton.Click
        SummaryCreation()
        My.Computer.FileSystem.WriteAllText(MainForm.fileName, MainForm.summaryString + Environment.NewLine, True)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        'PrintDocument1.Print()
    End Sub

    Private Sub SummaryCreation()
        SubTaxTotal()

        MainForm.summaryString = Me.Text + Environment.NewLine
        'determines what should be included in summary
        If MeatComboBox.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Main: " & MeatComboBox.Text & " " & decMeat.ToString("C") & Environment.NewLine
        End If

        If PotatoComboBox.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Side: " & PotatoComboBox.Text & " " & decPotato.ToString("C") & Environment.NewLine
        End If

        If EggsComboBox.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Soup: " & EggsComboBox.Text & " " & decEggs.ToString("C") & Environment.NewLine
        End If

        If DrinkComboBox.SelectedIndex <> 0 Then
            MainForm.summaryString = MainForm.summaryString & "Drink: " & DrinkComboBox.Text & " " & decDrink.ToString("C") & Environment.NewLine
        End If
        'tacks on subtotal, tax, and total to summary
        MainForm.summaryString = MainForm.summaryString & "Subtotal: " & MainForm.decTax.ToString("C") & Environment.NewLine & "Tax: " & MainForm.decTax.ToString("C") & _
        Environment.NewLine & "Total: " & MainForm.decTotal.ToString("C") & Environment.NewLine

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top

        e.Graphics.DrawString(MainForm.summaryString, New Font("Ariel", 10), Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
    End Sub




    'following toolbar items set the focus to the combo boxes
    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub EggsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EggsToolStripMenuItem.Click
        EggsComboBox.Focus()
    End Sub

    Private Sub PotatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PotatoToolStripMenuItem.Click
        PotatoComboBox.Focus()
    End Sub

    Private Sub DrinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrinkToolStripMenuItem.Click
        DrinkComboBox.Focus()
    End Sub

    Private Sub MeatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeatToolStripMenuItem.Click
        MeatComboBox.Focus()
    End Sub
End Class
