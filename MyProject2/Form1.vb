Imports System.Data.OleDb
Imports System.DateTime
Public Class frmDashboard
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmNewProduct.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=H:\Study\Practical\Vb\Database\Product.accdb; ")
        con.Open()
        cmd = New OleDbCommand("select count(*) from ProductMaster where status = 0 ", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        lblPendingNo.Text = lblPendingNo.Text + dr.Item(0).ToString
        con.Close()

        con.Open()
        Dim d As Date
        d = Today
        cmd = New OleDbCommand(" select count(*) from ProductMaster where dateReturn < #" & d.ToString("MM-dd-yyyy") & "# ", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        lblLatePrd.Text = dr.Item(0).ToString

        con.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyBase.Leave
        End
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmUserRegist.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmUserRegist.Show()
        Me.Hide()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmNewProduct.Show()
        Me.Hide()
    End Sub

    Private Sub AddOrModifyCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddOrModifyCustomerToolStripMenuItem.Click
        frmAddCustomer.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub Exitfrm()
        End
    End Sub


    Private Sub AddAdminAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAdminAccountToolStripMenuItem.Click
        frmUserRegist.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmShowAdmin.Show()
    End Sub

    Private Sub NewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
        FrmNewProduct.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPendingProduct.Click
        frmPendingProduct.Show()
    End Sub

    Private Sub PendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendingToolStripMenuItem.Click
        frmPendingProduct.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        FrmNewProduct.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnProductLst.Click
        frmProductStatus.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCusLst.Click
        frmCustomerList.Show()
    End Sub

    Private Sub AllProductsCategoryWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllProductsCategoryWiseToolStripMenuItem.Click
        Form3ShowPro.Show()

    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        frmLatePrd.Show()
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        frmPendingProduct.Show()
    End Sub

    Private Sub btnCmltd_Click(sender As Object, e As EventArgs) Handles btnCmltd.Click
        frmPrdCmlt.Show()
    End Sub

    Private Sub CompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompletedToolStripMenuItem.Click
        frmPrdCmlt.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("taskmgr.exe")
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MSWordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WINWORD.exe")
    End Sub
End Class
