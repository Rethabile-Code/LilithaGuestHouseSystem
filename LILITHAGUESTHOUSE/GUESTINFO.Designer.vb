<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUESTINFO
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbCustomerId = New System.Windows.Forms.ComboBox()
        Me.dgvCustomerInfo = New System.Windows.Forms.DataGridView()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRess = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPayn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtPNumber = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvCustomerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(498, 510)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 37)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Location = New System.Drawing.Point(318, 510)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 37)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Firebrick
        Me.btnUpdate.Location = New System.Drawing.Point(1, 510)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 37)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbCustomerId
        '
        Me.cmbCustomerId.FormattingEnabled = True
        Me.cmbCustomerId.Location = New System.Drawing.Point(77, 68)
        Me.cmbCustomerId.Name = "cmbCustomerId"
        Me.cmbCustomerId.Size = New System.Drawing.Size(165, 21)
        Me.cmbCustomerId.TabIndex = 7
        '
        'dgvCustomerInfo
        '
        Me.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerInfo.Location = New System.Drawing.Point(1, 230)
        Me.dgvCustomerInfo.Name = "dgvCustomerInfo"
        Me.dgvCustomerInfo.Size = New System.Drawing.Size(592, 268)
        Me.dgvCustomerInfo.TabIndex = 6
        '
        'btnFetch
        '
        Me.btnFetch.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetch.ForeColor = System.Drawing.Color.Firebrick
        Me.btnFetch.Location = New System.Drawing.Point(257, 66)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(95, 23)
        Me.btnFetch.TabIndex = 12
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(3, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Guest ID"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(374, 199)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbGender.TabIndex = 64
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.OldLace
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Firebrick
        Me.Label16.Location = New System.Drawing.Point(254, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 18)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.OldLace
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(3, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 18)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Reservation No."
        '
        'txtRess
        '
        Me.txtRess.Location = New System.Drawing.Point(119, 199)
        Me.txtRess.Name = "txtRess"
        Me.txtRess.Size = New System.Drawing.Size(123, 20)
        Me.txtRess.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.OldLace
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(254, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 18)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Number of Days"
        '
        'txtPayn
        '
        Me.txtPayn.Location = New System.Drawing.Point(370, 150)
        Me.txtPayn.Name = "txtPayn"
        Me.txtPayn.Size = New System.Drawing.Size(173, 20)
        Me.txtPayn.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.OldLace
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(254, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 18)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Payment No."
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(370, 104)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(169, 20)
        Me.txtDays.TabIndex = 57
        '
        'txtPNumber
        '
        Me.txtPNumber.Location = New System.Drawing.Point(104, 173)
        Me.txtPNumber.Name = "txtPNumber"
        Me.txtPNumber.Size = New System.Drawing.Size(138, 20)
        Me.txtPNumber.TabIndex = 56
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(77, 140)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(165, 20)
        Me.txtSurname.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.OldLace
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(3, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.OldLace
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(3, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.OldLace
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(4, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(77, 104)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(165, 20)
        Me.txtName.TabIndex = 49
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(145, 510)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 37)
        Me.btnClear.TabIndex = 65
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(124, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "GUEST INFORMATION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 43)
        Me.Panel1.TabIndex = 66
        '
        'GUESTINFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources.images__2_1
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRess)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPayn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.txtPNumber)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cmbCustomerId)
        Me.Controls.Add(Me.dgvCustomerInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GUESTINFO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUESTINFO"
        CType(Me.dgvCustomerInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbCustomerId As ComboBox
    Friend WithEvents dgvCustomerInfo As DataGridView
    Friend WithEvents btnFetch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRess As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPayn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtPNumber As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
