<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LunchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LunchForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SoupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DrinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbMain = New System.Windows.Forms.ComboBox
        Me.cmbSoup = New System.Windows.Forms.ComboBox
        Me.cmbSide = New System.Windows.Forms.ComboBox
        Me.cmbDrink = New System.Windows.Forms.ComboBox
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnOrder = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtMain = New System.Windows.Forms.TextBox
        Me.txtSoup = New System.Windows.Forms.TextBox
        Me.txtSide = New System.Windows.Forms.TextBox
        Me.txtDrink = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTax = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.SideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Main"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Soup"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "S&ide"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "&Drink"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.OrderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrderToolStripMenuItem.Text = "&Order"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.SoupToolStripMenuItem, Me.SideToolStripMenuItem, Me.DrinkToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MainToolStripMenuItem.Text = "&Main"
        '
        'SoupToolStripMenuItem
        '
        Me.SoupToolStripMenuItem.Name = "SoupToolStripMenuItem"
        Me.SoupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SoupToolStripMenuItem.Text = "&Soup"
        '
        'DrinkToolStripMenuItem
        '
        Me.DrinkToolStripMenuItem.Name = "DrinkToolStripMenuItem"
        Me.DrinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DrinkToolStripMenuItem.Text = "&Drink"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'cmbMain
        '
        Me.cmbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMain.FormattingEnabled = True
        Me.cmbMain.Items.AddRange(New Object() {"Nothing", "Sandwich", "Pizza", "Salad"})
        Me.cmbMain.Location = New System.Drawing.Point(144, 67)
        Me.cmbMain.Name = "cmbMain"
        Me.cmbMain.Size = New System.Drawing.Size(121, 24)
        Me.cmbMain.TabIndex = 1
        '
        'cmbSoup
        '
        Me.cmbSoup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSoup.FormattingEnabled = True
        Me.cmbSoup.Items.AddRange(New Object() {"Nothing", "Cicken Noodle", "Vegetable", "Potato"})
        Me.cmbSoup.Location = New System.Drawing.Point(144, 126)
        Me.cmbSoup.Name = "cmbSoup"
        Me.cmbSoup.Size = New System.Drawing.Size(121, 24)
        Me.cmbSoup.TabIndex = 3
        '
        'cmbSide
        '
        Me.cmbSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSide.FormattingEnabled = True
        Me.cmbSide.Items.AddRange(New Object() {"Nothing", "Fries", "Salad", "Onion Rings"})
        Me.cmbSide.Location = New System.Drawing.Point(144, 185)
        Me.cmbSide.Name = "cmbSide"
        Me.cmbSide.Size = New System.Drawing.Size(121, 24)
        Me.cmbSide.TabIndex = 5
        '
        'cmbDrink
        '
        Me.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDrink.FormattingEnabled = True
        Me.cmbDrink.Items.AddRange(New Object() {"Nothing", "Soda", "Milk", "Coffee"})
        Me.cmbDrink.Location = New System.Drawing.Point(144, 244)
        Me.cmbDrink.Name = "cmbDrink"
        Me.cmbDrink.Size = New System.Drawing.Size(121, 24)
        Me.cmbDrink.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(21, 307)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(108, 59)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalc, "Calculates your order")
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(21, 388)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 59)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clears your order")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(157, 307)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(108, 59)
        Me.btnOrder.TabIndex = 9
        Me.btnOrder.Text = "&Order"
        Me.ToolTip1.SetToolTip(Me.btnOrder, "Places the order")
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(157, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 59)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exits the lunch menu")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(400, 68)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ReadOnly = True
        Me.txtMain.Size = New System.Drawing.Size(100, 23)
        Me.txtMain.TabIndex = 13
        '
        'txtSoup
        '
        Me.txtSoup.Location = New System.Drawing.Point(400, 126)
        Me.txtSoup.Name = "txtSoup"
        Me.txtSoup.ReadOnly = True
        Me.txtSoup.Size = New System.Drawing.Size(100, 23)
        Me.txtSoup.TabIndex = 14
        '
        'txtSide
        '
        Me.txtSide.Location = New System.Drawing.Point(400, 184)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.ReadOnly = True
        Me.txtSide.Size = New System.Drawing.Size(100, 23)
        Me.txtSide.TabIndex = 15
        '
        'txtDrink
        '
        Me.txtDrink.Location = New System.Drawing.Point(400, 242)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.ReadOnly = True
        Me.txtDrink.Size = New System.Drawing.Size(100, 23)
        Me.txtDrink.TabIndex = 16
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(400, 300)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtSubTotal.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "SubTotal"
        Me.ToolTip1.SetToolTip(Me.Label3, "Price before tax.")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tax"
        Me.ToolTip1.SetToolTip(Me.Label6, "Tax (6%) for MI")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Total"
        Me.ToolTip1.SetToolTip(Me.Label7, "After Tax Price")
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(400, 358)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(100, 23)
        Me.txtTax.TabIndex = 20
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(400, 416)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtTotal.TabIndex = 22
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
        'SideToolStripMenuItem
        '
        Me.SideToolStripMenuItem.Name = "SideToolStripMenuItem"
        Me.SideToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SideToolStripMenuItem.Text = "S&ide"
        '
        'LunchForm
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(532, 466)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtDrink)
        Me.Controls.Add(Me.txtSide)
        Me.Controls.Add(Me.txtSoup)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.cmbDrink)
        Me.Controls.Add(Me.cmbSide)
        Me.Controls.Add(Me.cmbSoup)
        Me.Controls.Add(Me.cmbMain)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LunchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lunch Order for:  "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbMain As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSoup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSide As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDrink As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents txtSoup As System.Windows.Forms.TextBox
    Friend WithEvents txtSide As System.Windows.Forms.TextBox
    Friend WithEvents txtDrink As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents SideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
