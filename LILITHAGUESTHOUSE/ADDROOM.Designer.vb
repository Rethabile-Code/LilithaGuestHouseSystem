<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADDROOM
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
        Me.btnARoom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRDescription = New System.Windows.Forms.TextBox()
        Me.txtRType = New System.Windows.Forms.TextBox()
        Me.txtBCode = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnARoom
        '
        Me.btnARoom.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnARoom.ForeColor = System.Drawing.Color.Firebrick
        Me.btnARoom.Location = New System.Drawing.Point(15, 382)
        Me.btnARoom.Name = "btnARoom"
        Me.btnARoom.Size = New System.Drawing.Size(75, 23)
        Me.btnARoom.TabIndex = 0
        Me.btnARoom.Text = "Add Room"
        Me.btnARoom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room Number"
        '
        'txtRNumber
        '
        Me.txtRNumber.Location = New System.Drawing.Point(142, 79)
        Me.txtRNumber.Name = "txtRNumber"
        Me.txtRNumber.Size = New System.Drawing.Size(176, 20)
        Me.txtRNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(12, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Room Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(12, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Room Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(12, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Business Code"
        '
        'txtRDescription
        '
        Me.txtRDescription.Location = New System.Drawing.Point(142, 143)
        Me.txtRDescription.Name = "txtRDescription"
        Me.txtRDescription.Size = New System.Drawing.Size(176, 20)
        Me.txtRDescription.TabIndex = 6
        '
        'txtRType
        '
        Me.txtRType.Location = New System.Drawing.Point(142, 215)
        Me.txtRType.Name = "txtRType"
        Me.txtRType.Size = New System.Drawing.Size(176, 20)
        Me.txtRType.TabIndex = 7
        '
        'txtBCode
        '
        Me.txtBCode.Location = New System.Drawing.Point(142, 284)
        Me.txtBCode.Name = "txtBCode"
        Me.txtBCode.Size = New System.Drawing.Size(176, 20)
        Me.txtBCode.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(219, 382)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(382, 382)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 49)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(121, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ADD ROOM"
        '
        'ADDROOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtBCode)
        Me.Controls.Add(Me.txtRType)
        Me.Controls.Add(Me.txtRDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnARoom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADDROOM"
        Me.Text = "ADDROOM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnARoom As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRDescription As TextBox
    Friend WithEvents txtRType As TextBox
    Friend WithEvents txtBCode As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
End Class
