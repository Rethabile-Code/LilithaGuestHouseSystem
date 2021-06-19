<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADDGUEST
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPNumber = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddGuest = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPayn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRess = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCancel.FlatAppearance.BorderSize = 3
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(488, 403)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(281, 403)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtPNumber
        '
        Me.txtPNumber.Location = New System.Drawing.Point(141, 310)
        Me.txtPNumber.Name = "txtPNumber"
        Me.txtPNumber.Size = New System.Drawing.Size(183, 20)
        Me.txtPNumber.TabIndex = 30
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(141, 242)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(183, 20)
        Me.txtId.TabIndex = 29
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(141, 174)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(183, 20)
        Me.txtSurname.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(32, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(32, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ID Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(32, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(32, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(141, 106)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(183, 20)
        Me.txtName.TabIndex = 20
        '
        'btnAddGuest
        '
        Me.btnAddGuest.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnAddGuest.FlatAppearance.BorderSize = 3
        Me.btnAddGuest.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGuest.ForeColor = System.Drawing.Color.Firebrick
        Me.btnAddGuest.Location = New System.Drawing.Point(35, 403)
        Me.btnAddGuest.Name = "btnAddGuest"
        Me.btnAddGuest.Size = New System.Drawing.Size(109, 23)
        Me.btnAddGuest.TabIndex = 19
        Me.btnAddGuest.Text = "Add Guest"
        Me.btnAddGuest.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(-3, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 44)
        Me.Panel1.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(141, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ADD GUEST"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(347, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 18)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Payment No."
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(467, 172)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(87, 20)
        Me.txtDays.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(347, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Number of Days"
        '
        'txtPayn
        '
        Me.txtPayn.Location = New System.Drawing.Point(467, 238)
        Me.txtPayn.Name = "txtPayn"
        Me.txtPayn.Size = New System.Drawing.Size(87, 20)
        Me.txtPayn.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(347, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Reservation No."
        '
        'txtRess
        '
        Me.txtRess.Location = New System.Drawing.Point(467, 108)
        Me.txtRess.Name = "txtRess"
        Me.txtRess.Size = New System.Drawing.Size(87, 20)
        Me.txtRess.TabIndex = 41
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(467, 308)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(87, 21)
        Me.cmbGender.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Firebrick
        Me.Label16.Location = New System.Drawing.Point(347, 311)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 18)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Gender"
        '
        'ADDGUEST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources._1
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRess)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPayn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPNumber)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAddGuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADDGUEST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADDGUEST"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtPNumber As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAddGuest As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPayn As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRess As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label16 As Label
End Class
