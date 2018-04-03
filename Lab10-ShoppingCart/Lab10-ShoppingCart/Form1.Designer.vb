<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoppingCart
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductAudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblSubtotalVal = New System.Windows.Forms.Label()
        Me.lblTaxVal = New System.Windows.Forms.Label()
        Me.lblShippingVal = New System.Windows.Forms.Label()
        Me.lblTotalVal = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuProduct, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(477, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResetExit, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutKeyDisplayString = ""
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuResetExit
        '
        Me.mnuResetExit.Name = "mnuResetExit"
        Me.mnuResetExit.ShortcutKeyDisplayString = ""
        Me.mnuResetExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuResetExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuResetExit.Text = "&Reset"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuProduct
        '
        Me.mnuProduct.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProductPrint, Me.mnuProductAudio})
        Me.mnuProduct.Name = "mnuProduct"
        Me.mnuProduct.Size = New System.Drawing.Size(66, 20)
        Me.mnuProduct.Text = "&Products"
        '
        'mnuProductPrint
        '
        Me.mnuProductPrint.Name = "mnuProductPrint"
        Me.mnuProductPrint.Size = New System.Drawing.Size(141, 22)
        Me.mnuProductPrint.Text = "P&rint Books"
        '
        'mnuProductAudio
        '
        Me.mnuProductAudio.Name = "mnuProductAudio"
        Me.mnuProductAudio.Size = New System.Drawing.Size(152, 22)
        Me.mnuProductAudio.Text = "&Audio Books"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.Location = New System.Drawing.Point(34, 48)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(213, 108)
        Me.lstProducts.TabIndex = 1
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(297, 61)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 2
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(297, 89)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = "Tax"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(297, 114)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(48, 13)
        Me.lblShipping.TabIndex = 4
        Me.lblShipping.Text = "Shipping"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(297, 143)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(117, 177)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblSubtotalVal
        '
        Me.lblSubtotalVal.AutoSize = True
        Me.lblSubtotalVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotalVal.Location = New System.Drawing.Point(352, 61)
        Me.lblSubtotalVal.Name = "lblSubtotalVal"
        Me.lblSubtotalVal.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblSubtotalVal.Size = New System.Drawing.Size(52, 15)
        Me.lblSubtotalVal.TabIndex = 7
        '
        'lblTaxVal
        '
        Me.lblTaxVal.AutoSize = True
        Me.lblTaxVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxVal.Location = New System.Drawing.Point(352, 89)
        Me.lblTaxVal.Name = "lblTaxVal"
        Me.lblTaxVal.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblTaxVal.Size = New System.Drawing.Size(52, 15)
        Me.lblTaxVal.TabIndex = 8
        '
        'lblShippingVal
        '
        Me.lblShippingVal.AutoSize = True
        Me.lblShippingVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShippingVal.Location = New System.Drawing.Point(352, 114)
        Me.lblShippingVal.Name = "lblShippingVal"
        Me.lblShippingVal.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblShippingVal.Size = New System.Drawing.Size(52, 15)
        Me.lblShippingVal.TabIndex = 9
        '
        'lblTotalVal
        '
        Me.lblTotalVal.AutoSize = True
        Me.lblTotalVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalVal.Location = New System.Drawing.Point(352, 143)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.lblTotalVal.Size = New System.Drawing.Size(52, 15)
        Me.lblTotalVal.TabIndex = 10
        '
        'frmShoppingCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 261)
        Me.Controls.Add(Me.lblTotalVal)
        Me.Controls.Add(Me.lblShippingVal)
        Me.Controls.Add(Me.lblTaxVal)
        Me.Controls.Add(Me.lblSubtotalVal)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmShoppingCart"
        Me.Text = "Shopping Cart"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuResetExit As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuProduct As ToolStripMenuItem
    Friend WithEvents mnuProductPrint As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuProductAudio As ToolStripMenuItem
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblSubtotalVal As Label
    Friend WithEvents lblTaxVal As Label
    Friend WithEvents lblShippingVal As Label
    Friend WithEvents lblTotalVal As Label
End Class
