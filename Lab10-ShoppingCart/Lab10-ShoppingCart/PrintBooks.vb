Public Class frmPrintbooks
    Private Sub btnBookClose_Click(sender As Object, e As EventArgs) Handles btnBookClose.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub btnAddBookCart_Click(sender As Object, e As EventArgs) Handles btnAddBookCart.Click
        frmShoppingCart.lstProducts.Items.Add("P" & lstPrintbooks.SelectedIndex & ": " & lstPrintbooks.SelectedItem.ToString)
        frmShoppingCart.DisplayCharges()
    End Sub
End Class