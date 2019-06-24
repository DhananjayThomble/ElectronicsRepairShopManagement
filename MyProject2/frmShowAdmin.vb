Public Class frmShowAdmin
    Private Sub frmShowAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login2DataSet.LoginTable' table. You can move, or remove it, as needed.
        Me.LoginTableTableAdapter.Fill(Me.Login2DataSet.LoginTable)
        'TODO: This line of code loads data into the 'LoginDataSet.LoginTable' table. You can move, or remove it, as needed.
        Me.LoginTableTableAdapter.Fill(Me.Login2DataSet.LoginTable)

    End Sub


End Class