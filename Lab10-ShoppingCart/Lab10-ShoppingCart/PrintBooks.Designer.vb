<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintbooks
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
        Me.lblPrintBooks = New System.Windows.Forms.Label()
        Me.lstPrintbooks = New System.Windows.Forms.ListBox()
        Me.btnAddBookCart = New System.Windows.Forms.Button()
        Me.btnBookClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrintBooks
        '
        Me.lblPrintBooks.AutoSize = True
        Me.lblPrintBooks.Location = New System.Drawing.Point(27, 34)
        Me.lblPrintBooks.Name = "lblPrintBooks"
        Me.lblPrintBooks.Size = New System.Drawing.Size(98, 13)
        Me.lblPrintBooks.TabIndex = 0
        Me.lblPrintBooks.Text = "Select a Print Book"
        '
        'lstPrintbooks
        '
        Me.lstPrintbooks.FormattingEnabled = True
        Me.lstPrintbooks.Items.AddRange(New Object() {"I Did Your Way (Print)", "The History of Scottland (Print)", "Learn Calculus in One Day (Print)", "Feel The Stress (Print)"})
        Me.lstPrintbooks.Location = New System.Drawing.Point(30, 61)
        Me.lstPrintbooks.Name = "lstPrintbooks"
        Me.lstPrintbooks.Size = New System.Drawing.Size(213, 69)
        Me.lstPrintbooks.TabIndex = 1
        '
        'btnAddBookCart
        '
        Me.btnAddBookCart.Location = New System.Drawing.Point(30, 174)
        Me.btnAddBookCart.Name = "btnAddBookCart"
        Me.btnAddBookCart.Size = New System.Drawing.Size(104, 23)
        Me.btnAddBookCart.TabIndex = 2
        Me.btnAddBookCart.Text = "Add Book to Cart"
        Me.btnAddBookCart.UseVisualStyleBackColor = True
        '
        'btnBookClose
        '
        Me.btnBookClose.Location = New System.Drawing.Point(203, 173)
        Me.btnBookClose.Name = "btnBookClose"
        Me.btnBookClose.Size = New System.Drawing.Size(75, 23)
        Me.btnBookClose.TabIndex = 3
        Me.btnBookClose.Text = "Close"
        Me.btnBookClose.UseVisualStyleBackColor = True
        '
        'frmPrintbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 261)
        Me.Controls.Add(Me.btnBookClose)
        Me.Controls.Add(Me.btnAddBookCart)
        Me.Controls.Add(Me.lstPrintbooks)
        Me.Controls.Add(Me.lblPrintBooks)
        Me.Name = "frmPrintbooks"
        Me.Text = "Print Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrintBooks As Label
    Friend WithEvents lstPrintbooks As ListBox
    Friend WithEvents btnAddBookCart As Button
    Friend WithEvents btnBookClose As Button
End Class
