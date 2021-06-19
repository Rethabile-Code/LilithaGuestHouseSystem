<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PAYMENT
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
        Me.txtPNumber = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnShowE = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radDebit = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtCustId = New System.Windows.Forms.TextBox()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtResNo = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.cmdCustId = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPNumber
        '
        Me.txtPNumber.Location = New System.Drawing.Point(227, 310)
        Me.txtPNumber.Name = "txtPNumber"
        Me.txtPNumber.Size = New System.Drawing.Size(205, 20)
        Me.txtPNumber.TabIndex = 4
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(40, 548)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 37)
        Me.btnPay.TabIndex = 5
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnShowE
        '
        Me.btnShowE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowE.Location = New System.Drawing.Point(40, 470)
        Me.btnShowE.Name = "btnShowE"
        Me.btnShowE.Size = New System.Drawing.Size(142, 48)
        Me.btnShowE.TabIndex = 6
        Me.btnShowE.Text = "Reservation Number"
        Me.btnShowE.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(415, 548)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Cancel"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 46)
        Me.Panel1.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(150, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MAKE PAYMENT"
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCash.Location = New System.Drawing.Point(17, 19)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(72, 24)
        Me.radCash.TabIndex = 46
        Me.radCash.TabStop = True
        Me.radCash.Text = "CASH"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCredit.Location = New System.Drawing.Point(17, 42)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(137, 24)
        Me.radCredit.TabIndex = 47
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "CREDIT CARD"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDebit)
        Me.GroupBox1.Controls.Add(Me.radCash)
        Me.GroupBox1.Controls.Add(Me.radCredit)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 95)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAYMENT METHODS"
        '
        'radDebit
        '
        Me.radDebit.AutoSize = True
        Me.radDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDebit.Location = New System.Drawing.Point(17, 65)
        Me.radDebit.Name = "radDebit"
        Me.radDebit.Size = New System.Drawing.Size(125, 24)
        Me.radDebit.TabIndex = 48
        Me.radDebit.TabStop = True
        Me.radDebit.Text = "DEBIT CARD"
        Me.radDebit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(40, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 30)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Card Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCard
        '
        Me.txtCard.Location = New System.Drawing.Point(227, 233)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(205, 20)
        Me.txtCard.TabIndex = 50
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(227, 269)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(205, 20)
        Me.txtAmount.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(40, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 35)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Amount "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(40, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 33)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Payment Number"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(40, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 34)
        Me.Button4.TabIndex = 54
        Me.Button4.Text = "Employee Id"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtCustId
        '
        Me.txtCustId.Location = New System.Drawing.Point(227, 389)
        Me.txtCustId.Name = "txtCustId"
        Me.txtCustId.Size = New System.Drawing.Size(205, 20)
        Me.txtCustId.TabIndex = 55
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(227, 349)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(205, 20)
        Me.txtEmpID.TabIndex = 56
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(40, 389)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 36)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "Customer Id"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 431)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(205, 20)
        Me.DateTimePicker1.TabIndex = 58
        '
        'txtResNo
        '
        Me.txtResNo.Location = New System.Drawing.Point(227, 470)
        Me.txtResNo.Name = "txtResNo"
        Me.txtResNo.Size = New System.Drawing.Size(212, 20)
        Me.txtResNo.TabIndex = 59
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(240, 548)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 37)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(40, 431)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 33)
        Me.Button7.TabIndex = 61
        Me.Button7.Text = "Payment Date"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(40, 95)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(167, 28)
        Me.Button9.TabIndex = 63
        Me.Button9.Text = "Customer Id"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'cmdCustId
        '
        Me.cmdCustId.FormattingEnabled = True
        Me.cmdCustId.Location = New System.Drawing.Point(222, 95)
        Me.cmdCustId.Name = "cmdCustId"
        Me.cmdCustId.Size = New System.Drawing.Size(210, 21)
        Me.cmdCustId.TabIndex = 64
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 591)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(575, 40)
        Me.Panel3.TabIndex = 66
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Location = New System.Drawing.Point(571, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(36, 597)
        Me.Panel2.TabIndex = 65
        '
        'PAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources.Visa_Master
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdCustId)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtResNo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.txtCustId)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCard)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowE)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtPNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PAYMENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPNumber As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnShowE As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents radCash As RadioButton
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radDebit As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCard As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtCustId As TextBox
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtResNo As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents cmdCustId As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
