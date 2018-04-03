<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudiobooks
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
        Me.lblAudioBooks = New System.Windows.Forms.Label()
        Me.lstAudiobook = New System.Windows.Forms.ListBox()
        Me.btnAddAudioBook = New System.Windows.Forms.Button()
        Me.btnAudioClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAudioBooks
        '
        Me.lblAudioBooks.AutoSize = True
        Me.lblAudioBooks.Location = New System.Drawing.Point(13, 24)
        Me.lblAudioBooks.Name = "lblAudioBooks"
        Me.lblAudioBooks.Size = New System.Drawing.Size(110, 13)
        Me.lblAudioBooks.TabIndex = 0
        Me.lblAudioBooks.Text = "Select an Audio Book"
        '
        'lstAudiobook
        '
        Me.lstAudiobook.FormattingEnabled = True
        Me.lstAudiobook.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scottland (Audio)", "The Science of Body Language (Audio)"})
        Me.lstAudiobook.Location = New System.Drawing.Point(16, 54)
        Me.lstAudiobook.Name = "lstAudiobook"
        Me.lstAudiobook.Size = New System.Drawing.Size(206, 69)
        Me.lstAudiobook.TabIndex = 1
        '
        'btnAddAudioBook
        '
        Me.btnAddAudioBook.Location = New System.Drawing.Point(16, 155)
        Me.btnAddAudioBook.Name = "btnAddAudioBook"
        Me.btnAddAudioBook.Size = New System.Drawing.Size(107, 23)
        Me.btnAddAudioBook.TabIndex = 2
        Me.btnAddAudioBook.Text = "Add Book to Cart"
        Me.btnAddAudioBook.UseVisualStyleBackColor = True
        '
        'btnAudioClose
        '
        Me.btnAudioClose.Location = New System.Drawing.Point(177, 155)
        Me.btnAudioClose.Name = "btnAudioClose"
        Me.btnAudioClose.Size = New System.Drawing.Size(75, 23)
        Me.btnAudioClose.TabIndex = 3
        Me.btnAudioClose.Text = "Close"
        Me.btnAudioClose.UseVisualStyleBackColor = True
        '
        'frmAudiobooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 261)
        Me.Controls.Add(Me.btnAudioClose)
        Me.Controls.Add(Me.btnAddAudioBook)
        Me.Controls.Add(Me.lstAudiobook)
        Me.Controls.Add(Me.lblAudioBooks)
        Me.Name = "frmAudiobooks"
        Me.Text = "Audio Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAudioBooks As Label
    Friend WithEvents lstAudiobook As ListBox
    Friend WithEvents btnAddAudioBook As Button
    Friend WithEvents btnAudioClose As Button
End Class
