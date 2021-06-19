<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmROOMLIST
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
        Me.dgvRoom = New System.Windows.Forms.DataGridView()
        Me.cboRNumber = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtBCode = New System.Windows.Forms.TextBox()
        Me.txtRType = New System.Windows.Forms.TextBox()
        Me.txtRDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRoom
        '
        Me.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoom.Location = New System.Drawing.Point(4, 204)
        Me.dgvRoom.Name = "dgvRoom"
        Me.dgvRoom.Size = New System.Drawing.Size(606, 284)
        Me.dgvRoom.TabIndex = 0
        '
        'cboRNumber
        '
        Me.cboRNumber.FormattingEnabled = True
        Me.cboRNumber.Location = New System.Drawing.Point(138, 65)
        Me.cboRNumber.Name = "cboRNumber"
        Me.cboRNumber.Size = New System.Drawing.Size(181, 21)
        Me.cboRNumber.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Firebrick
        Me.btnUpdate.Location = New System.Drawing.Point(12, 494)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Location = New System.Drawing.Point(326, 494)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(473, 494)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnFetch
        '
        Me.btnFetch.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetch.ForeColor = System.Drawing.Color.Firebrick
        Me.btnFetch.Location = New System.Drawing.Point(326, 62)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(75, 23)
        Me.btnFetch.TabIndex = 6
        Me.btnFetch.Text = "Fetch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Room Number"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(140, 494)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 23)
        Me.btnClear.TabIndex = 66
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtBCode
        '
        Me.txtBCode.Location = New System.Drawing.Point(138, 170)
        Me.txtBCode.Name = "txtBCode"
        Me.txtBCode.Size = New System.Drawing.Size(181, 20)
        Me.txtBCode.TabIndex = 74
        '
        'txtRType
        '
        Me.txtRType.Location = New System.Drawing.Point(139, 136)
        Me.txtRType.Name = "txtRType"
        Me.txtRType.Size = New System.Drawing.Size(180, 20)
        Me.txtRType.TabIndex = 73
        '
        'txtRDescription
        '
        Me.txtRDescription.Location = New System.Drawing.Point(139, 103)
        Me.txtRDescription.Name = "txtRDescription"
        Me.txtRDescription.Size = New System.Drawing.Size(180, 20)
        Me.txtRDescription.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(8, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Business Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(8, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Room Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(8, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Room Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(119, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ROOM LIST"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(4, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 43)
        Me.Panel1.TabIndex = 75
        '
        'frmROOMLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources.black_blue_techno_corporate_business_background_design_template_8306_2391
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBCode)
        Me.Controls.Add(Me.txtRType)
        Me.Controls.Add(Me.txtRDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cboRNumber)
        Me.Controls.Add(Me.dgvRoom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmROOMLIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROOMLIST"
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRoom As DataGridView
    Friend WithEvents cboRNumber As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnFetch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtBCode As TextBox
    Friend WithEvents txtRType As TextBox
    Friend WithEvents txtRDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
End Class
