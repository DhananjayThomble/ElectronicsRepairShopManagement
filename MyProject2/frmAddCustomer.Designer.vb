<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.richTxtAddress = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMobno = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnGetdata = New System.Windows.Forms.Button()
        Me.cmbUid = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cmbUid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.richTxtAddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMobno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(163, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 281)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "UID ->"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(126, 247)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(183, 24)
        Me.txtEmail.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Email"
        '
        'richTxtAddress
        '
        Me.richTxtAddress.Location = New System.Drawing.Point(126, 91)
        Me.richTxtAddress.Name = "richTxtAddress"
        Me.richTxtAddress.Size = New System.Drawing.Size(183, 96)
        Me.richTxtAddress.TabIndex = 55
        Me.richTxtAddress.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name"
        '
        'txtMobno
        '
        Me.txtMobno.Location = New System.Drawing.Point(126, 218)
        Me.txtMobno.Mask = "0000000000"
        Me.txtMobno.Name = "txtMobno"
        Me.txtMobno.Size = New System.Drawing.Size(99, 24)
        Me.txtMobno.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact No."
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(14, 117)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 27)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(14, 84)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 27)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(14, 51)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(94, 27)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(14, 18)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(94, 27)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(165, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 22)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Add Customer"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnGetdata)
        Me.panel1.Controls.Add(Me.btnUpdate)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnInsert)
        Me.panel1.Controls.Add(Me.btnNew)
        Me.panel1.Location = New System.Drawing.Point(515, 151)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(123, 194)
        Me.panel1.TabIndex = 53
        '
        'btnGetdata
        '
        Me.btnGetdata.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetdata.Location = New System.Drawing.Point(14, 150)
        Me.btnGetdata.Name = "btnGetdata"
        Me.btnGetdata.Size = New System.Drawing.Size(94, 28)
        Me.btnGetdata.TabIndex = 4
        Me.btnGetdata.Text = "&Get Data"
        Me.btnGetdata.UseVisualStyleBackColor = True
        '
        'cmbUid
        '
        Me.cmbUid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbUid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUid.FormattingEnabled = True
        Me.cmbUid.Location = New System.Drawing.Point(126, 23)
        Me.cmbUid.Name = "cmbUid"
        Me.cmbUid.Size = New System.Drawing.Size(183, 25)
        Me.cmbUid.TabIndex = 60
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(126, 54)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(183, 24)
        Me.txtName.TabIndex = 61
        '
        'frmAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frmAddCustomer"
        Me.Text = "AddCustomer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMobno As MaskedTextBox
    Friend WithEvents Label5 As Label
    Public WithEvents btnUpdate As Button
    Public WithEvents btnDelete As Button
    Public WithEvents btnInsert As Button
    Public WithEvents btnNew As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents richTxtAddress As RichTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents btnGetdata As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbUid As ComboBox
End Class
