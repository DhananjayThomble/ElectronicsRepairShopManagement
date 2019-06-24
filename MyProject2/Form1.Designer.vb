<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAdminAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOrModifyCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllProductsCategoryWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.btnPendingProduct = New System.Windows.Forms.Button()
        Me.btnProductLst = New System.Windows.Forms.Button()
        Me.btnCusLst = New System.Windows.Forms.Button()
        Me.btnCmltd = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblPendingNo = New System.Windows.Forms.Label()
        Me.ProductDataSet = New MyProject2.ProductDataSet()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductMasterTableAdapter = New MyProject2.ProductDataSetTableAdapters.ProductMasterTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblLatePrd = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(0, 612)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1, 1)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(902, 24)
        Me.MenuStrip2.TabIndex = 102
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AddAdminAccountToolStripMenuItem, Me.AddOrModifyCustomerToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem1.Text = "Show Accounts"
        '
        'AddAdminAccountToolStripMenuItem
        '
        Me.AddAdminAccountToolStripMenuItem.Name = "AddAdminAccountToolStripMenuItem"
        Me.AddAdminAccountToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AddAdminAccountToolStripMenuItem.Text = "Add Admin Account"
        '
        'AddOrModifyCustomerToolStripMenuItem
        '
        Me.AddOrModifyCustomerToolStripMenuItem.Name = "AddOrModifyCustomerToolStripMenuItem"
        Me.AddOrModifyCustomerToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AddOrModifyCustomerToolStripMenuItem.Text = "Add Or Modify Customer"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProductToolStripMenuItem, Me.PendingToolStripMenuItem, Me.CompletedToolStripMenuItem, Me.AllProductsCategoryWiseToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InventoryToolStripMenuItem.Text = "Products"
        '
        'NewProductToolStripMenuItem
        '
        Me.NewProductToolStripMenuItem.Name = "NewProductToolStripMenuItem"
        Me.NewProductToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NewProductToolStripMenuItem.Text = "New Product"
        '
        'PendingToolStripMenuItem
        '
        Me.PendingToolStripMenuItem.Name = "PendingToolStripMenuItem"
        Me.PendingToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.PendingToolStripMenuItem.Text = "Pending"
        '
        'CompletedToolStripMenuItem
        '
        Me.CompletedToolStripMenuItem.Name = "CompletedToolStripMenuItem"
        Me.CompletedToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CompletedToolStripMenuItem.Text = "Completed"
        '
        'AllProductsCategoryWiseToolStripMenuItem
        '
        Me.AllProductsCategoryWiseToolStripMenuItem.Name = "AllProductsCategoryWiseToolStripMenuItem"
        Me.AllProductsCategoryWiseToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AllProductsCategoryWiseToolStripMenuItem.Text = "All Products Category wise"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.MSWordToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Image = CType(resources.GetObject("CalculatorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Image = CType(resources.GetObject("NotepadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Image = CType(resources.GetObject("TaskManagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'MSWordToolStripMenuItem
        '
        Me.MSWordToolStripMenuItem.Image = CType(resources.GetObject("MSWordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MSWordToolStripMenuItem.Name = "MSWordToolStripMenuItem"
        Me.MSWordToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MSWordToolStripMenuItem.Text = "MS Word"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnNewProduct
        '
        Me.btnNewProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewProduct.Location = New System.Drawing.Point(3, 3)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(101, 58)
        Me.btnNewProduct.TabIndex = 106
        Me.btnNewProduct.Text = "New Product"
        Me.btnNewProduct.UseVisualStyleBackColor = True
        '
        'btnPendingProduct
        '
        Me.btnPendingProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingProduct.Location = New System.Drawing.Point(110, 3)
        Me.btnPendingProduct.Name = "btnPendingProduct"
        Me.btnPendingProduct.Size = New System.Drawing.Size(101, 58)
        Me.btnPendingProduct.TabIndex = 107
        Me.btnPendingProduct.Text = "Pending Product"
        Me.btnPendingProduct.UseVisualStyleBackColor = True
        '
        'btnProductLst
        '
        Me.btnProductLst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductLst.Location = New System.Drawing.Point(217, 3)
        Me.btnProductLst.Name = "btnProductLst"
        Me.btnProductLst.Size = New System.Drawing.Size(101, 58)
        Me.btnProductLst.TabIndex = 108
        Me.btnProductLst.Text = "Product List"
        Me.btnProductLst.UseVisualStyleBackColor = True
        '
        'btnCusLst
        '
        Me.btnCusLst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCusLst.Location = New System.Drawing.Point(324, 3)
        Me.btnCusLst.Name = "btnCusLst"
        Me.btnCusLst.Size = New System.Drawing.Size(101, 58)
        Me.btnCusLst.TabIndex = 109
        Me.btnCusLst.Text = "Customer List"
        Me.btnCusLst.UseVisualStyleBackColor = True
        '
        'btnCmltd
        '
        Me.btnCmltd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCmltd.Location = New System.Drawing.Point(431, 3)
        Me.btnCmltd.Name = "btnCmltd"
        Me.btnCmltd.Size = New System.Drawing.Size(110, 58)
        Me.btnCmltd.TabIndex = 110
        Me.btnCmltd.Text = "Completed"
        Me.btnCmltd.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(181, 52)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 112
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Location = New System.Drawing.Point(184, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 113
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNewProduct)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPendingProduct)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnProductLst)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCusLst)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCmltd)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(187, 54)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(544, 64)
        Me.FlowLayoutPanel2.TabIndex = 114
        '
        'lblPendingNo
        '
        Me.lblPendingNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingNo.AutoSize = True
        Me.lblPendingNo.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingNo.Location = New System.Drawing.Point(3, 68)
        Me.lblPendingNo.Name = "lblPendingNo"
        Me.lblPendingNo.Size = New System.Drawing.Size(250, 34)
        Me.lblPendingNo.TabIndex = 116
        Me.lblPendingNo.Text = "Total Pending = "
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "ProductDataSet"
        Me.ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "ProductMaster"
        Me.ProductMasterBindingSource.DataSource = Me.ProductDataSet
        '
        'ProductMasterTableAdapter
        '
        Me.ProductMasterTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.lblPendingNo)
        Me.Panel2.Location = New System.Drawing.Point(12, 298)
        Me.Panel2.MinimumSize = New System.Drawing.Size(313, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 151)
        Me.Panel2.TabIndex = 117
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.lblLatePrd)
        Me.Panel3.Controls.Add(Me.lbl1)
        Me.Panel3.Location = New System.Drawing.Point(577, 298)
        Me.Panel3.MinimumSize = New System.Drawing.Size(313, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 151)
        Me.Panel3.TabIndex = 118
        '
        'lblLatePrd
        '
        Me.lblLatePrd.AutoSize = True
        Me.lblLatePrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatePrd.ForeColor = System.Drawing.Color.Red
        Me.lblLatePrd.Location = New System.Drawing.Point(274, 68)
        Me.lblLatePrd.Name = "lblLatePrd"
        Me.lblLatePrd.Size = New System.Drawing.Size(36, 37)
        Me.lblLatePrd.TabIndex = 120
        Me.lblLatePrd.Text = "0"
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(3, 68)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(276, 34)
        Me.lbl1.TabIndex = 116
        Me.lbl1.Text = "Late for Service = "
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.MyProject2.My.Resources.Resources.Webp2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(902, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.Name = "frmDashboard"
        Me.Text = "Dashboard"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAdminAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNewProduct As Button
    Friend WithEvents btnPendingProduct As Button
    Friend WithEvents btnProductLst As Button
    Friend WithEvents btnCusLst As Button
    Friend WithEvents btnCmltd As Button
    Friend WithEvents AddOrModifyCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllProductsCategoryWiseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblPendingNo As Label
    Friend WithEvents ProductDataSet As ProductDataSet
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents ProductMasterTableAdapter As ProductDataSetTableAdapters.ProductMasterTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblLatePrd As Label
End Class
