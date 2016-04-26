<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radDinner = New System.Windows.Forms.RadioButton
        Me.radLunch = New System.Windows.Forms.RadioButton
        Me.radBreakfast = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.btnOrder = New System.Windows.Forms.Button
        Me.btnNewCustomer = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PaperMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderingDirectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSummary = New System.Windows.Forms.Button
        Me.lblPaperMenu = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPreviousSummary = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDinner)
        Me.GroupBox1.Controls.Add(Me.radLunch)
        Me.GroupBox1.Controls.Add(Me.radBreakfast)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 123)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Selection"
        '
        'radDinner
        '
        Me.radDinner.AutoSize = True
        Me.radDinner.Location = New System.Drawing.Point(6, 75)
        Me.radDinner.Name = "radDinner"
        Me.radDinner.Size = New System.Drawing.Size(56, 17)
        Me.radDinner.TabIndex = 2
        Me.radDinner.TabStop = True
        Me.radDinner.Text = "&Dinner"
        Me.ToolTip1.SetToolTip(Me.radDinner, "Generally served from 5:00pm until closing")
        Me.radDinner.UseVisualStyleBackColor = True
        '
        'radLunch
        '
        Me.radLunch.AutoSize = True
        Me.radLunch.Location = New System.Drawing.Point(6, 52)
        Me.radLunch.Name = "radLunch"
        Me.radLunch.Size = New System.Drawing.Size(55, 17)
        Me.radLunch.TabIndex = 1
        Me.radLunch.TabStop = True
        Me.radLunch.Text = "&Lunch"
        Me.ToolTip1.SetToolTip(Me.radLunch, "Generally served from 10:00 am until 5:00pm")
        Me.radLunch.UseVisualStyleBackColor = True
        '
        'radBreakfast
        '
        Me.radBreakfast.AutoSize = True
        Me.radBreakfast.Checked = True
        Me.radBreakfast.Location = New System.Drawing.Point(6, 29)
        Me.radBreakfast.Name = "radBreakfast"
        Me.radBreakfast.Size = New System.Drawing.Size(70, 17)
        Me.radBreakfast.TabIndex = 0
        Me.radBreakfast.TabStop = True
        Me.radBreakfast.Text = "&Breakfast"
        Me.ToolTip1.SetToolTip(Me.radBreakfast, "Generally served from opening to 10:00 am")
        Me.radBreakfast.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Customer Name"
        Me.ToolTip1.SetToolTip(Me.Label1, "Name of Customer")
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(131, 29)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(220, 20)
        Me.txtCustomerName.TabIndex = 1
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(15, 239)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "&Order"
        Me.ToolTip1.SetToolTip(Me.btnOrder, "Open ordering menu")
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(106, 239)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(100, 23)
        Me.btnNewCustomer.TabIndex = 4
        Me.btnNewCustomer.Text = "&New Customer"
        Me.ToolTip1.SetToolTip(Me.btnNewCustomer, "Clears customer name and sets menu to breakfast")
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(221, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.NewCustomerToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.PaperMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.EToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OrderToolStripMenuItem.Text = "&Order"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewCustomerToolStripMenuItem.Text = "&New Customer"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'PaperMenuToolStripMenuItem
        '
        Me.PaperMenuToolStripMenuItem.Name = "PaperMenuToolStripMenuItem"
        Me.PaperMenuToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PaperMenuToolStripMenuItem.Text = "&Paper Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(150, 6)
        '
        'EToolStripMenuItem
        '
        Me.EToolStripMenuItem.Name = "EToolStripMenuItem"
        Me.EToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.OrderingDirectionsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'OrderingDirectionsToolStripMenuItem
        '
        Me.OrderingDirectionsToolStripMenuItem.Name = "OrderingDirectionsToolStripMenuItem"
        Me.OrderingDirectionsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OrderingDirectionsToolStripMenuItem.Text = "Ordering &Directions"
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(302, 209)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(91, 23)
        Me.btnSummary.TabIndex = 5
        Me.btnSummary.Text = "&Summary"
        Me.ToolTip1.SetToolTip(Me.btnSummary, "Gives a summary of today's orders " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Also found in bin/debug folder")
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'lblPaperMenu
        '
        Me.lblPaperMenu.AutoSize = True
        Me.lblPaperMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaperMenu.ForeColor = System.Drawing.Color.Blue
        Me.lblPaperMenu.Location = New System.Drawing.Point(18, 77)
        Me.lblPaperMenu.Name = "lblPaperMenu"
        Me.lblPaperMenu.Size = New System.Drawing.Size(65, 13)
        Me.lblPaperMenu.TabIndex = 3
        Me.lblPaperMenu.Text = "&Paper Menu"
        Me.ToolTip1.SetToolTip(Me.lblPaperMenu, "Print out a paper menu for people who do not like ordering electronically")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(136, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
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
        'btnPreviousSummary
        '
        Me.btnPreviousSummary.Location = New System.Drawing.Point(302, 239)
        Me.btnPreviousSummary.Name = "btnPreviousSummary"
        Me.btnPreviousSummary.Size = New System.Drawing.Size(91, 23)
        Me.btnPreviousSummary.TabIndex = 8
        Me.btnPreviousSummary.Text = "Sale &Records"
        Me.btnPreviousSummary.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(400, 271)
        Me.Controls.Add(Me.btnPreviousSummary)
        Me.Controls.Add(Me.lblPaperMenu)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Order Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radDinner As System.Windows.Forms.RadioButton
    Friend WithEvents radLunch As System.Windows.Forms.RadioButton
    Friend WithEvents radBreakfast As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderingDirectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblPaperMenu As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PaperMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPreviousSummary As System.Windows.Forms.Button

End Class
