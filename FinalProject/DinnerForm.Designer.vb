<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinnerForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DinnerForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbMain = New System.Windows.Forms.ComboBox
        Me.cmbDessert = New System.Windows.Forms.ComboBox
        Me.cmbApp = New System.Windows.Forms.ComboBox
        Me.cmbSide2 = New System.Windows.Forms.ComboBox
        Me.cmbSide1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnOrder = New System.Windows.Forms.Button
        Me.cmbDrink = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblApp = New System.Windows.Forms.Label
        Me.lblMain = New System.Windows.Forms.Label
        Me.lblDessert = New System.Windows.Forms.Label
        Me.lblDrink = New System.Windows.Forms.Label
        Me.lblSide2 = New System.Windows.Forms.Label
        Me.lblSide1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AppetizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Side1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Side2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DessetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DrinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.OrderToolStripMenuItem1, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'OrderToolStripMenuItem1
        '
        Me.OrderToolStripMenuItem1.Name = "OrderToolStripMenuItem1"
        Me.OrderToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.OrderToolStripMenuItem1.Text = "&Order"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HelpToolStripMenuItem.Text = "&About"
        '
        'cmbMain
        '
        Me.cmbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMain.FormattingEnabled = True
        Me.cmbMain.Items.AddRange(New Object() {"Nothing", "Spagetti", "Steak (16 oz)", "Hamburger", "Hot Dogs", "Salad (Large)"})
        Me.cmbMain.Location = New System.Drawing.Point(111, 54)
        Me.cmbMain.Name = "cmbMain"
        Me.cmbMain.Size = New System.Drawing.Size(243, 21)
        Me.cmbMain.TabIndex = 4
        '
        'cmbDessert
        '
        Me.cmbDessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDessert.FormattingEnabled = True
        Me.cmbDessert.Items.AddRange(New Object() {"Nothing", "Parfiat", "Cake (Chocolate)", "Cake (Carrot)", "Pudding (Banana)", "Pudding (Chocolate)"})
        Me.cmbDessert.Location = New System.Drawing.Point(111, 135)
        Me.cmbDessert.Name = "cmbDessert"
        Me.cmbDessert.Size = New System.Drawing.Size(243, 21)
        Me.cmbDessert.TabIndex = 10
        '
        'cmbApp
        '
        Me.cmbApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbApp.FormattingEnabled = True
        Me.cmbApp.Items.AddRange(New Object() {"Nothing", "Dumplings", "Crab Cakes", "Stuffed Mushrooms"})
        Me.cmbApp.Location = New System.Drawing.Point(111, 27)
        Me.cmbApp.Name = "cmbApp"
        Me.cmbApp.Size = New System.Drawing.Size(243, 21)
        Me.cmbApp.TabIndex = 2
        '
        'cmbSide2
        '
        Me.cmbSide2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSide2.FormattingEnabled = True
        Me.cmbSide2.Items.AddRange(New Object() {"Nothing", "French Fries", "Toast", "Baked Potato", "Side Salad"})
        Me.cmbSide2.Location = New System.Drawing.Point(111, 108)
        Me.cmbSide2.Name = "cmbSide2"
        Me.cmbSide2.Size = New System.Drawing.Size(243, 21)
        Me.cmbSide2.TabIndex = 8
        '
        'cmbSide1
        '
        Me.cmbSide1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSide1.FormattingEnabled = True
        Me.cmbSide1.Items.AddRange(New Object() {"Nothing", "French Fries", "Toast", "Baked Potato", "Side Salad"})
        Me.cmbSide1.Location = New System.Drawing.Point(111, 81)
        Me.cmbSide1.Name = "cmbSide1"
        Me.cmbSide1.Size = New System.Drawing.Size(243, 21)
        Me.cmbSide1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&Main Course"
        Me.ToolTip1.SetToolTip(Me.Label1, "Food served after appetizer and main portion of meal")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Side &1"
        Me.ToolTip1.SetToolTip(Me.Label2, "Sides served during main course")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Side &2"
        Me.ToolTip1.SetToolTip(Me.Label3, "Sides served during main course")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "A&ppetizer"
        Me.ToolTip1.SetToolTip(Me.Label4, "Smaller dish served before Main course")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "&Dessert"
        Me.ToolTip1.SetToolTip(Me.Label11, "Desserts served shortly after main course is finished")
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(186, 279)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 41)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Set choices to ""Nothing""")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(261, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 41)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Back to main form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(36, 279)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(69, 41)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Preview the order price")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(111, 279)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(69, 41)
        Me.btnOrder.TabIndex = 14
        Me.btnOrder.Text = "&Order"
        Me.ToolTip1.SetToolTip(Me.btnOrder, "Place Order")
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'cmbDrink
        '
        Me.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDrink.FormattingEnabled = True
        Me.cmbDrink.Items.AddRange(New Object() {"Nothing", "Water", "Milk", "Soda", "Coffee", "Tea", "Beer (Domestic)", "Beer (Foreign)"})
        Me.cmbDrink.Location = New System.Drawing.Point(111, 217)
        Me.cmbDrink.Name = "cmbDrink"
        Me.cmbDrink.Size = New System.Drawing.Size(243, 21)
        Me.cmbDrink.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "D&rink"
        Me.ToolTip1.SetToolTip(Me.Label5, "Beverages served with Dinner" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alcoholic Drinks served only to customers 21 and ol" & _
                "der")
        '
        'lblApp
        '
        Me.lblApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblApp.Location = New System.Drawing.Point(415, 33)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(60, 15)
        Me.lblApp.TabIndex = 17
        Me.lblApp.Text = "$00.00"
        Me.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMain
        '
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMain.Location = New System.Drawing.Point(415, 60)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(60, 15)
        Me.lblMain.TabIndex = 18
        Me.lblMain.Text = "$00.00"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDessert
        '
        Me.lblDessert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDessert.Location = New System.Drawing.Point(415, 141)
        Me.lblDessert.Name = "lblDessert"
        Me.lblDessert.Size = New System.Drawing.Size(60, 15)
        Me.lblDessert.TabIndex = 21
        Me.lblDessert.Text = "$00.00"
        Me.lblDessert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDrink
        '
        Me.lblDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDrink.Location = New System.Drawing.Point(415, 220)
        Me.lblDrink.Name = "lblDrink"
        Me.lblDrink.Size = New System.Drawing.Size(60, 15)
        Me.lblDrink.TabIndex = 22
        Me.lblDrink.Text = "$00.00"
        Me.lblDrink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSide2
        '
        Me.lblSide2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSide2.Location = New System.Drawing.Point(415, 114)
        Me.lblSide2.Name = "lblSide2"
        Me.lblSide2.Size = New System.Drawing.Size(60, 15)
        Me.lblSide2.TabIndex = 20
        Me.lblSide2.Text = "$00.00"
        Me.lblSide2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSide1
        '
        Me.lblSide1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSide1.Location = New System.Drawing.Point(415, 87)
        Me.lblSide1.Name = "lblSide1"
        Me.lblSide1.Size = New System.Drawing.Size(60, 15)
        Me.lblSide1.TabIndex = 19
        Me.lblSide1.Text = "$00.00"
        Me.lblSide1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppetizerToolStripMenuItem, Me.MainCourseToolStripMenuItem, Me.Side1ToolStripMenuItem, Me.Side2ToolStripMenuItem, Me.DessetToolStripMenuItem, Me.DrinkToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AppetizerToolStripMenuItem
        '
        Me.AppetizerToolStripMenuItem.Name = "AppetizerToolStripMenuItem"
        Me.AppetizerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AppetizerToolStripMenuItem.Text = "A&ppetizer"
        '
        'MainCourseToolStripMenuItem
        '
        Me.MainCourseToolStripMenuItem.Name = "MainCourseToolStripMenuItem"
        Me.MainCourseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MainCourseToolStripMenuItem.Text = "&Main Course"
        '
        'Side1ToolStripMenuItem
        '
        Me.Side1ToolStripMenuItem.Name = "Side1ToolStripMenuItem"
        Me.Side1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Side1ToolStripMenuItem.Text = "Side &1"
        '
        'Side2ToolStripMenuItem
        '
        Me.Side2ToolStripMenuItem.Name = "Side2ToolStripMenuItem"
        Me.Side2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Side2ToolStripMenuItem.Text = "Side &2"
        '
        'DessetToolStripMenuItem
        '
        Me.DessetToolStripMenuItem.Name = "DessetToolStripMenuItem"
        Me.DessetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DessetToolStripMenuItem.Text = "&Dessert"
        '
        'DrinkToolStripMenuItem
        '
        Me.DrinkToolStripMenuItem.Name = "DrinkToolStripMenuItem"
        Me.DrinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DrinkToolStripMenuItem.Text = "D&rink"
        '
        'DinnerForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(587, 339)
        Me.Controls.Add(Me.lblSide1)
        Me.Controls.Add(Me.lblSide2)
        Me.Controls.Add(Me.lblDrink)
        Me.Controls.Add(Me.lblDessert)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDrink)
        Me.Controls.Add(Me.cmbApp)
        Me.Controls.Add(Me.cmbSide2)
        Me.Controls.Add(Me.cmbSide1)
        Me.Controls.Add(Me.cmbDessert)
        Me.Controls.Add(Me.cmbMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DinnerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dinner Order for: "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cmbMain As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDessert As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSide2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSide1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents cmbDrink As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbApp As System.Windows.Forms.ComboBox
    Friend WithEvents lblApp As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblDessert As System.Windows.Forms.Label
    Friend WithEvents lblDrink As System.Windows.Forms.Label
    Friend WithEvents lblSide2 As System.Windows.Forms.Label
    Friend WithEvents lblSide1 As System.Windows.Forms.Label
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppetizerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Side1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Side2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DessetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
