<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewProduct
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
        Me.components = New System.ComponentModel.Container()
        Me.LblCat = New System.Windows.Forms.Label()
        Me.dateToday = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateReturn = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RichtxtAddress = New System.Windows.Forms.RichTextBox()
        Me.txtMobileno = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddData = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSn = New System.Windows.Forms.TextBox()
        Me.lblUniueID = New System.Windows.Forms.Label()
        Me.mTxtCost = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCat
        '
        Me.LblCat.AutoSize = True
        Me.LblCat.Location = New System.Drawing.Point(12, 44)
        Me.LblCat.Name = "LblCat"
        Me.LblCat.Size = New System.Drawing.Size(82, 13)
        Me.LblCat.TabIndex = 1
        Me.LblCat.Text = "Select Category"
        '
        'dateToday
        '
        Me.dateToday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateToday.Location = New System.Drawing.Point(100, 80)
        Me.dateToday.Name = "dateToday"
        Me.dateToday.Size = New System.Drawing.Size(204, 20)
        Me.dateToday.TabIndex = 4
        Me.dateToday.Value = New Date(2019, 2, 6, 16, 46, 50, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date Of Return"
        '
        'DateReturn
        '
        Me.DateReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateReturn.Location = New System.Drawing.Point(100, 106)
        Me.DateReturn.Name = "DateReturn"
        Me.DateReturn.Size = New System.Drawing.Size(204, 20)
        Me.DateReturn.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.RichtxtAddress)
        Me.GroupBox2.Controls.Add(Me.txtMobileno)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 408)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 250)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(72, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 20)
        Me.txtName.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Address"
        '
        'RichtxtAddress
        '
        Me.RichtxtAddress.Location = New System.Drawing.Point(72, 110)
        Me.RichtxtAddress.Name = "RichtxtAddress"
        Me.RichtxtAddress.Size = New System.Drawing.Size(225, 96)
        Me.RichtxtAddress.TabIndex = 16
        Me.RichtxtAddress.Text = ""
        '
        'txtMobileno
        '
        Me.txtMobileno.Location = New System.Drawing.Point(73, 54)
        Me.txtMobileno.Mask = "0000000000"
        Me.txtMobileno.Name = "txtMobileno"
        Me.txtMobileno.Size = New System.Drawing.Size(224, 20)
        Me.txtMobileno.TabIndex = 17
        Me.txtMobileno.ValidatingType = GetType(Integer)
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(73, 84)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtEmail.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mobile no"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Name"
        '
        'btnAddData
        '
        Me.btnAddData.Location = New System.Drawing.Point(426, 574)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(75, 84)
        Me.btnAddData.TabIndex = 13
        Me.btnAddData.Text = "Add Data"
        Me.btnAddData.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Tv", "Mobile", "Ac", "Laptop", "Refridgerator"})
        Me.cmbCategory.Location = New System.Drawing.Point(101, 39)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(203, 21)
        Me.cmbCategory.TabIndex = 15
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        '
        'txtSn
        '
        Me.txtSn.AcceptsReturn = True
        Me.txtSn.AcceptsTab = True
        Me.txtSn.Location = New System.Drawing.Point(79, 343)
        Me.txtSn.Name = "txtSn"
        Me.txtSn.Size = New System.Drawing.Size(225, 20)
        Me.txtSn.TabIndex = 25
        '
        'lblUniueID
        '
        Me.lblUniueID.AutoSize = True
        Me.lblUniueID.Location = New System.Drawing.Point(12, 346)
        Me.lblUniueID.Name = "lblUniueID"
        Me.lblUniueID.Size = New System.Drawing.Size(25, 13)
        Me.lblUniueID.TabIndex = 24
        Me.lblUniueID.Text = "S.N"
        '
        'mTxtCost
        '
        Me.mTxtCost.Location = New System.Drawing.Point(92, 298)
        Me.mTxtCost.Mask = "0000000"
        Me.mTxtCost.Name = "mTxtCost"
        Me.mTxtCost.Size = New System.Drawing.Size(212, 20)
        Me.mTxtCost.TabIndex = 23
        Me.mTxtCost.ValidatingType = GetType(Integer)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cost of Repair"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(79, 190)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(225, 96)
        Me.txtDesc.TabIndex = 21
        Me.txtDesc.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Description"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(79, 154)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(225, 20)
        Me.txtTitle.TabIndex = 18
        '
        'FrmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(869, 706)
        Me.Controls.Add(Me.txtSn)
        Me.Controls.Add(Me.lblUniueID)
        Me.Controls.Add(Me.mTxtCost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.btnAddData)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DateReturn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateToday)
        Me.Controls.Add(Me.LblCat)
        Me.Name = "FrmNewProduct"
        Me.Text = "Add Product"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCat As Label
    Friend WithEvents dateToday As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateReturn As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddData As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RichtxtAddress As RichTextBox
    Friend WithEvents txtMobileno As MaskedTextBox

    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSn As TextBox
    Friend WithEvents lblUniueID As Label
    Friend WithEvents mTxtCost As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDesc As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTitle As TextBox
End Class
