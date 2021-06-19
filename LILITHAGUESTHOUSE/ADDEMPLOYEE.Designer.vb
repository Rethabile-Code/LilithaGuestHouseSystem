<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADDEMPLOYEE
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
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Busine = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBusinesscode = New System.Windows.Forms.TextBox()
        Me.txtEmployeeT = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.Color.Firebrick
        Me.btnAddEmp.Location = New System.Drawing.Point(11, 507)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(127, 23)
        Me.btnAddEmp.TabIndex = 0
        Me.btnAddEmp.Text = "Add Employee"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(134, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(198, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(20, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(23, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 43)
        Me.Panel1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(119, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(259, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ADD EMPLOYEE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(20, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Surname"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.AutoSize = True
        Me.txtIDNumber.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.ForeColor = System.Drawing.Color.Firebrick
        Me.txtIDNumber.Location = New System.Drawing.Point(20, 160)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(83, 18)
        Me.txtIDNumber.TabIndex = 5
        Me.txtIDNumber.Text = "ID Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(20, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(20, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(22, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Email"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(134, 110)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(198, 20)
        Me.txtSurname.TabIndex = 10
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(134, 156)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(198, 20)
        Me.txtID.TabIndex = 11
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(134, 206)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(198, 20)
        Me.txtPhone.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(134, 296)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(198, 20)
        Me.txtAddress.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(134, 254)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(198, 20)
        Me.txtEmail.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(238, 507)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(395, 507)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(22, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Gender"
        '
        'Busine
        '
        Me.Busine.AutoSize = True
        Me.Busine.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busine.ForeColor = System.Drawing.Color.Firebrick
        Me.Busine.Location = New System.Drawing.Point(20, 406)
        Me.Busine.Name = "Busine"
        Me.Busine.Size = New System.Drawing.Size(95, 18)
        Me.Busine.TabIndex = 20
        Me.Busine.Text = "BusinessCode"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Firebrick
        Me.Label9.Location = New System.Drawing.Point(20, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Employee Type"
        '
        'txtBusinesscode
        '
        Me.txtBusinesscode.Location = New System.Drawing.Point(134, 405)
        Me.txtBusinesscode.Name = "txtBusinesscode"
        Me.txtBusinesscode.Size = New System.Drawing.Size(198, 20)
        Me.txtBusinesscode.TabIndex = 22
        '
        'txtEmployeeT
        '
        Me.txtEmployeeT.Location = New System.Drawing.Point(134, 445)
        Me.txtEmployeeT.Name = "txtEmployeeT"
        Me.txtEmployeeT.Size = New System.Drawing.Size(198, 20)
        Me.txtEmployeeT.TabIndex = 23
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Famale"})
        Me.cmbGender.Location = New System.Drawing.Point(134, 351)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(198, 21)
        Me.cmbGender.TabIndex = 24
        '
        'ADDEMPLOYEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources._62497138_digits_and_map_abstract_computer_background_in_blues_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtEmployeeT)
        Me.Controls.Add(Me.txtBusinesscode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Busine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAddEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADDEMPLOYEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADDEMPLOYEE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddEmp As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDNumber As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Busine As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBusinesscode As TextBox
    Friend WithEvents txtEmployeeT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbGender As ComboBox
End Class
