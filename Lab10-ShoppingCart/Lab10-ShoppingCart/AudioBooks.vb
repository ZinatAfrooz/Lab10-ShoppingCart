Public Class frmAudiobooks
    Private Sub btnAudioClose_Click(sender As Object, e As EventArgs) Handles btnAudioClose.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnAddAudioBook_Click(sender As Object, e As EventArgs) Handles btnAddAudioBook.Click
        frmShoppingCart.lstProducts.Items.Add("A" & lstAudiobook.SelectedIndex & ": " & lstAudiobook.SelectedItem.ToString)
        frmShoppingCart.DisplayCharges()
    End Sub
End Class