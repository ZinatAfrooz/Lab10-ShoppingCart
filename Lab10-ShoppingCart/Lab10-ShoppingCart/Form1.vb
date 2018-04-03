Public Class frmShoppingCart

    'Sales tax on total cost
    Public Const decSALES_TAX As Decimal = 0.06D

    'Shipping Cost on each item
    Public Const decSHIPPING_CHARGE As Decimal = 2

    Public printBookPrice() As Decimal = {11.95D, 14.5D, 29.95D, 18.5D}
    Public printBookName() As String = {"I Did It your Way", "The History of Scotland", "Learn Calculus in One Day", "Feel the Stress"}
    Public audioBookPrice() As Decimal = {29.95D, 14.5D, 12.95D, 11.5D}
    Public audioBookName() As String = {"Learn Calculus in One Day", "The History of Scotland", "The Science of Body Language", "Relaxation Techniques"}

    Public Sub DisplayCharges()
        'This procedure calculates the tax, shipping charge and total cart purchase.
        Dim BookTotal As Decimal = 0
        For Each Book As String In lstProducts.Items
            If Book.StartsWith("A") Then
                BookTotal += audioBookPrice(CInt(Book.Substring(1, 1)))
            Else ' must be a print book
                BookTotal += printBookPrice(CInt(Book.Substring(1, 1)))
            End If
        Next

        Dim BookCount As Integer = lstProducts.Items.Count
        'Display the Data.
        lblSubtotalVal.Text = BookTotal.ToString("c")
        lblTaxVal.Text = (BookTotal * decSALES_TAX).ToString("c")
        BookTotal += BookTotal * decSALES_TAX
        lblShippingVal.Text = (BookCount * decSHIPPING_CHARGE).ToString("c")
        BookTotal += BookCount * decSHIPPING_CHARGE
        lblTotalVal.Text = BookTotal.ToString("c")

    End Sub

    Private Sub mnuResetExit_Click(sender As Object, e As EventArgs) Handles mnuResetExit.Click
        'Reset the form.
        lblSubtotalVal.Text = String.Empty
        lblTaxVal.Text = String.Empty
        lblShippingVal.Text = String.Empty
        lblTotalVal.Text = String.Empty
        lstProducts.Items.Clear()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Close the form
        Me.Close()

    End Sub

    Private Sub mnuProductPrint_Click(sender As Object, e As EventArgs) Handles mnuProductPrint.Click
        frmPrintbooks.Show()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display a simple About box.
        MessageBox.Show("A Shopping cart system to shop Print and Audio Books", " Shopping Cart System")
    End Sub

    Private Sub mnuProductAudio_Click(sender As Object, e As EventArgs) Handles mnuProductAudio.Click
        frmAudiobooks.Show()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'Remove Items from List Box
        If lstProducts.SelectedIndex <> -1 Then
            lstProducts.Items.RemoveAt(lstProducts.SelectedIndex)
        End If
        DisplayCharges()
    End Sub
End Class
