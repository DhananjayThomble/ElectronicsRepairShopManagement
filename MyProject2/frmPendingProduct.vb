Public Class frmPendingProduct
    Private Sub frmPendingProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PendingProList.ProductMaster' table. You can move, or remove it, as needed.
        'Me.ProductMasterTableAdapter.Fill(Me.PendingProList.ProductMaster)
        Try
            Me.ProductMasterTableAdapter.FillBy(Me.PendingProList.ProductMaster)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub
End Class