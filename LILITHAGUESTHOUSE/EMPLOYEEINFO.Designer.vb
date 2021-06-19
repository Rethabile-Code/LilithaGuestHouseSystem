<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMPLOYEEINFO
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDeleteE = New System.Windows.Forms.Button()
        Me.btnUpdateE = New System.Windows.Forms.Button()
        Me.cmbEmpId = New System.Windows.Forms.ComboBox()
        Me.dgdEmpInfo = New System.Windows.Forms.DataGridView()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeT = New System.Windows.Forms.TextBox()
        Me.txtBusinesscode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Busine = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgdEmpInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(12, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Employee ID"
        '
        'btnFetch
        '
        Me.btnFetch.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetch.ForeColor = System.Drawing.Color.Firebrick
        Me.btnFetch.Location = New System.Drawing.Point(295, 93)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(95, 23)
        Me.btnFetch.TabIndex = 19
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(492, 513)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 37)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDeleteE
        '
        Me.btnDeleteE.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteE.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDeleteE.Location = New System.Drawing.Point(336, 513)
        Me.btnDeleteE.Name = "btnDeleteE"
        Me.btnDeleteE.Size = New System.Drawing.Size(101, 37)
        Me.btnDeleteE.TabIndex = 17
        Me.btnDeleteE.Text = "Delete"
        Me.btnDeleteE.UseVisualStyleBackColor = True
        '
        'btnUpdateE
        '
        Me.btnUpdateE.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateE.ForeColor = System.Drawing.Color.Firebrick
        Me.btnUpdateE.Location = New System.Drawing.Point(1, 513)
        Me.btnUpdateE.Name = "btnUpdateE"
        Me.btnUpdateE.Size = New System.Drawing.Size(92, 37)
        Me.btnUpdateE.TabIndex = 16
        Me.btnUpdateE.Text = "Update"
        Me.btnUpdateE.UseVisualStyleBackColor = True
        '
        'cmbEmpId
        '
        Me.cmbEmpId.FormattingEnabled = True
        Me.cmbEmpId.Location = New System.Drawing.Point(112, 95)
        Me.cmbEmpId.Name = "cmbEmpId"
        Me.cmbEmpId.Size = New System.Drawing.Size(165, 21)
        Me.cmbEmpId.TabIndex = 15
        '
        'dgdEmpInfo
        '
        Me.dgdEmpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdEmpInfo.Location = New System.Drawing.Point(1, 242)
        Me.dgdEmpInfo.Name = "dgdEmpInfo"
        Me.dgdEmpInfo.Size = New System.Drawing.Size(623, 258)
        Me.dgdEmpInfo.TabIndex = 14
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Famale"})
        Me.cmbGender.Location = New System.Drawing.Point(413, 157)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(159, 21)
        Me.cmbGender.TabIndex = 42
        '
        'txtEmployeeT
        '
        Me.txtEmployeeT.Location = New System.Drawing.Point(413, 216)
        Me.txtEmployeeT.Name = "txtEmployeeT"
        Me.txtEmployeeT.Size = New System.Drawing.Size(159, 20)
        Me.txtEmployeeT.TabIndex = 41
        '
        'txtBusinesscode
        '
        Me.txtBusinesscode.Location = New System.Drawing.Point(413, 190)
        Me.txtBusinesscode.Name = "txtBusinesscode"
        Me.txtBusinesscode.Size = New System.Drawing.Size(159, 20)
        Me.txtBusinesscode.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Firebrick
        Me.Label9.Location = New System.Drawing.Point(310, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Employee Type"
        '
        'Busine
        '
        Me.Busine.AutoSize = True
        Me.Busine.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busine.ForeColor = System.Drawing.Color.Firebrick
        Me.Busine.Location = New System.Drawing.Point(310, 185)
        Me.Busine.Name = "Busine"
        Me.Busine.Size = New System.Drawing.Size(95, 18)
        Me.Busine.TabIndex = 38
        Me.Busine.Text = "BusinessCode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(315, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Gender"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(112, 214)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(159, 20)
        Me.txtEmail.TabIndex = 36
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(413, 127)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(159, 20)
        Me.txtAddress.TabIndex = 35
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(112, 183)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(159, 20)
        Me.txtPhone.TabIndex = 34
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(112, 157)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(159, 20)
        Me.txtSurname.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(7, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(310, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(7, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(7, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Surname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(12, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(112, 129)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(159, 20)
        Me.txtName.TabIndex = 25
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(171, 513)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 37)
        Me.btnClear.TabIndex = 66
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.ForeColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(-7, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 44)
        Me.Panel1.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(72, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(444, 34)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "EMPLOYEE INFORMATION"
        '
        'EMPLOYEEINFO
        '
        Me.AcceptButton = Me.btnFetch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources._2
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtEmployeeT)
        Me.Controls.Add(Me.txtBusinesscode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Busine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDeleteE)
        Me.Controls.Add(Me.btnUpdateE)
        Me.Controls.Add(Me.cmbEmpId)
        Me.Controls.Add(Me.dgdEmpInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EMPLOYEEINFO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLOYEE INFO"
        CType(Me.dgdEmpInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnFetch As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDeleteE As Button
    Friend WithEvents btnUpdateE As Button
    Friend WithEvents cmbEmpId As ComboBox
    Friend WithEvents dgdEmpInfo As DataGridView
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtEmployeeT As TextBox
    Friend WithEvents txtBusinesscode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Busine As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class
