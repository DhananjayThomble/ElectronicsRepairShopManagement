Public Class frmCustomerList
    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.ProductDataSet1.Customer)

    End Sub
End Class