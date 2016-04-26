<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BreakfastForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BreakfastForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Calculatebutton = New System.Windows.Forms.Button
        Me.Orderbutton = New System.Windows.Forms.Button
        Me.Exitbutton = New System.Windows.Forms.Button
        Me.Clearbutton = New System.Windows.Forms.Button
        Me.MeatComboBox = New System.Windows.Forms.ComboBox
        Me.PotatoComboBox = New System.Windows.Forms.ComboBox
        Me.DrinkComboBox = New System.Windows.Forms.ComboBox
        Me.EggsComboBox = New System.Windows.Forms.ComboBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PotatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DrinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EggsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.taxTextBox = New System.Windows.Forms.TextBox
        Me.subtotalTextBox = New System.Windows.Forms.TextBox
        Me.totalTextBox = New System.Windows.Forms.TextBox
        Me.LblMeatPrice = New System.Windows.Forms.Label
        Me.LblPotatoPrice = New System.Windows.Forms.Label
        Me.LblDrinkPrice = New System.Windows.Forms.Label
        Me.LblEggsPrice = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Meat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Potato"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Drink"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Eggs"
        '
        'Calculatebutton
        '
        Me.Calculatebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Calculatebutton.Location = New System.Drawing.Point(0, 277)
        Me.Calculatebutton.Name = "Calculatebutton"
        Me.Calculatebutton.Size = New System.Drawing.Size(75, 23)
        Me.Calculatebutton.TabIndex = 8
        Me.Calculatebutton.Text = "&Calculate"
        Me.Calculatebutton.UseVisualStyleBackColor = True
        '
        'Orderbutton
        '
        Me.Orderbutton.Location = New System.Drawing.Point(97, 277)
        Me.Orderbutton.Name = "Orderbutton"
        Me.Orderbutton.Size = New System.Drawing.Size(75, 23)
        Me.Orderbutton.TabIndex = 9
        Me.Orderbutton.Text = "&Order"
        Me.Orderbutton.UseVisualStyleBackColor = True
        '
        'Exitbutton
        '
        Me.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Exitbutton.Location = New System.Drawing.Point(198, 277)
        Me.Exitbutton.Name = "Exitbutton"
        Me.Exitbutton.Size = New System.Drawing.Size(75, 23)
        Me.Exitbutton.TabIndex = 11
        Me.Exitbutton.Text = "E&xit"
        Me.Exitbutton.UseVisualStyleBackColor = True
        '
        'Clearbutton
        '
        Me.Clearbutton.Location = New System.Drawing.Point(0, 335)
        Me.Clearbutton.Name = "Clearbutton"
        Me.Clearbutton.Size = New System.Drawing.Size(75, 23)
        Me.Clearbutton.TabIndex = 10
        Me.Clearbutton.Text = "C&lear"
        Me.Clearbutton.UseVisualStyleBackColor = True
        '
        'MeatComboBox
        '
        Me.MeatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MeatComboBox.FormattingEnabled = True
        Me.MeatComboBox.Items.AddRange(New Object() {"Nothing", "Sausage", "Ham", "Bacon"})
        Me.MeatComboBox.Location = New System.Drawing.Point(97, 47)
        Me.MeatComboBox.Name = "MeatComboBox"
        Me.MeatComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MeatComboBox.TabIndex = 1
        '
        'PotatoComboBox
        '
        Me.PotatoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PotatoComboBox.FormattingEnabled = True
        Me.PotatoComboBox.Items.AddRange(New Object() {"Nothing", "Hashbrowns", "Cottage Fries"})
        Me.PotatoComboBox.Location = New System.Drawing.Point(97, 82)
        Me.PotatoComboBox.Name = "PotatoComboBox"
        Me.PotatoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PotatoComboBox.TabIndex = 3
        '
        'DrinkComboBox
        '
        Me.DrinkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DrinkComboBox.FormattingEnabled = True
        Me.DrinkComboBox.Items.AddRange(New Object() {"Nothing", "Coffee", "Orange Juice"})
        Me.DrinkComboBox.Location = New System.Drawing.Point(97, 116)
        Me.DrinkComboBox.Name = "DrinkComboBox"
        Me.DrinkComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DrinkComboBox.TabIndex = 5
        '
        'EggsComboBox
        '
        Me.EggsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EggsComboBox.FormattingEnabled = True
        Me.EggsComboBox.Items.AddRange(New Object() {"Nothing", "Scrambled", "Over Easy", "Sunny Side Up"})
        Me.EggsComboBox.Location = New System.Drawing.Point(97, 151)
        Me.EggsComboBox.Name = "EggsComboBox"
        Me.EggsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EggsComboBox.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(615, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.OrderToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ClearToolStripMenuItem})
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
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MeatToolStripMenuItem, Me.PotatoToolStripMenuItem, Me.DrinkToolStripMenuItem, Me.EggsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'MeatToolStripMenuItem
        '
        Me.MeatToolStripMenuItem.Name = "MeatToolStripMenuItem"
        Me.MeatToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MeatToolStripMenuItem.Text = "&Meat"
        '
        'PotatoToolStripMenuItem
        '
        Me.PotatoToolStripMenuItem.Name = "PotatoToolStripMenuItem"
        Me.PotatoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PotatoToolStripMenuItem.Text = "&Potato"
        '
        'DrinkToolStripMenuItem
        '
        Me.DrinkToolStripMenuItem.Name = "DrinkToolStripMenuItem"
        Me.DrinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DrinkToolStripMenuItem.Text = "&Drink"
        '
        'EggsToolStripMenuItem
        '
        Me.EggsToolStripMenuItem.Name = "EggsToolStripMenuItem"
        Me.EggsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EggsToolStripMenuItem.Text = "&Eggs"
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
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Subtotal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(317, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Total"
        '
        'taxTextBox
        '
        Me.taxTextBox.Location = New System.Drawing.Point(424, 277)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.taxTextBox.TabIndex = 18
        '
        'subtotalTextBox
        '
        Me.subtotalTextBox.Location = New System.Drawing.Point(424, 221)
        Me.subtotalTextBox.Name = "subtotalTextBox"
        Me.subtotalTextBox.ReadOnly = True
        Me.subtotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.subtotalTextBox.TabIndex = 20
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(424, 328)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.totalTextBox.TabIndex = 22
        '
        'LblMeatPrice
        '
        Me.LblMeatPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMeatPrice.Location = New System.Drawing.Point(334, 49)
        Me.LblMeatPrice.Name = "LblMeatPrice"
        Me.LblMeatPrice.Size = New System.Drawing.Size(100, 23)
        Me.LblMeatPrice.TabIndex = 13
        '
        'LblPotatoPrice
        '
        Me.LblPotatoPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPotatoPrice.Location = New System.Drawing.Point(334, 84)
        Me.LblPotatoPrice.Name = "LblPotatoPrice"
        Me.LblPotatoPrice.Size = New System.Drawing.Size(100, 23)
        Me.LblPotatoPrice.TabIndex = 14
        '
        'LblDrinkPrice
        '
        Me.LblDrinkPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDrinkPrice.Location = New System.Drawing.Point(334, 118)
        Me.LblDrinkPrice.Name = "LblDrinkPrice"
        Me.LblDrinkPrice.Size = New System.Drawing.Size(100, 23)
        Me.LblDrinkPrice.TabIndex = 15
        '
        'LblEggsPrice
        '
        Me.LblEggsPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEggsPrice.Location = New System.Drawing.Point(334, 153)
        Me.LblEggsPrice.Name = "LblEggsPrice"
        Me.LblEggsPrice.Size = New System.Drawing.Size(100, 23)
        Me.LblEggsPrice.TabIndex = 16
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
        'PrintDocument1
        '
        '
        'BreakfastForm
        '
        Me.AcceptButton = Me.Calculatebutton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Exitbutton
        Me.ClientSize = New System.Drawing.Size(615, 384)
        Me.Controls.Add(Me.LblEggsPrice)
        Me.Controls.Add(Me.LblDrinkPrice)
        Me.Controls.Add(Me.LblPotatoPrice)
        Me.Controls.Add(Me.LblMeatPrice)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.subtotalTextBox)
        Me.Controls.Add(Me.taxTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EggsComboBox)
        Me.Controls.Add(Me.DrinkComboBox)
        Me.Controls.Add(Me.PotatoComboBox)
        Me.Controls.Add(Me.MeatComboBox)
        Me.Controls.Add(Me.Clearbutton)
        Me.Controls.Add(Me.Exitbutton)
        Me.Controls.Add(Me.Orderbutton)
        Me.Controls.Add(Me.Calculatebutton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BreakfastForm"
        Me.Text = "Breakfast order for: "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Calculatebutton As System.Windows.Forms.Button
    Friend WithEvents Orderbutton As System.Windows.Forms.Button
    Friend WithEvents Exitbutton As System.Windows.Forms.Button
    Friend WithEvents Clearbutton As System.Windows.Forms.Button
    Friend WithEvents MeatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PotatoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DrinkComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EggsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PotatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents taxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents subtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LblMeatPrice As System.Windows.Forms.Label
    Friend WithEvents LblPotatoPrice As System.Windows.Forms.Label
    Friend WithEvents LblDrinkPrice As System.Windows.Forms.Label
    Friend WithEvents LblEggsPrice As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EggsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
