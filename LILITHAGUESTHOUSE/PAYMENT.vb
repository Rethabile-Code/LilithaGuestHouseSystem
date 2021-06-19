Public Class PAYMENT
    Dim Lilitha As New LilithaClasss
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Reception.Show()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim res As String
        If radCash.Checked = False And radCredit.Checked = False And radDebit.Checked = False Then
            MsgBox("Please select payment type")
            radCash.Checked = True
        End If
        If txtCard.Text = "" Then
            MsgBox("Please enter card number")
            txtCard.Focus()
            Return
        End If
        If IsNumeric(txtCard.Text.Trim) = False Then
            MsgBox("Card number must be only numbers")
            txtAmount.Focus()
            Return
        End If
        If txtAmount.Text = "" Then
            MsgBox("Please enter amount")
            txtAmount.Focus()
            Return
        End If
        If IsNumeric(txtAmount.Text.Trim) = False Then
            MsgBox("Amount must be only numbers")
            txtAmount.Focus()
            Return
        End If
        If txtEmpID.Text.Trim.Length <> 13 Then
            MsgBox(" Emp Id number must contain 13 numbers")
            txtEmpID.Focus()
            Return
        End If
        If IsNumeric(txtEmpID.Text.Trim) = False Then
            MsgBox("Id number must be only numbers")
            txtEmpID.Focus()
            Return
        End If
        If txtCustId.Text.Trim.Length <> 13 Then
            MsgBox(" Customer Id number must contain 13 numbers")
            txtEmpID.Focus()
            Return
        End If
        If IsNumeric(txtCustId.Text.Trim) = False Then
            MsgBox("Id number must be only numbers")
            txtEmpID.Focus()
            Return
        End If
        If txtPNumber.Text.Trim = " " Then
            MsgBox("Please enter payment number")
            txtPNumber.Focus()
            Return
        End If
        If IsNumeric(txtPNumber.Text.Trim) = False Then
            MsgBox("Payment number must be only numbers")
            txtPNumber.Focus()
            Return
        End If
        If txtResNo.Text.Trim = " " Then
            MsgBox("Please enter Resavertion number number")
            txtResNo.Focus()
            Return
        End If
        If IsNumeric(txtResNo.Text.Trim) = False Then
            MsgBox("Reservation number must be only numbers")
            txtResNo.Focus()
            Return
        End If
        Dim Ptype As String = ""
        If radCash.Checked = True Then
            Ptype = "Cash"
        End If
        If radCredit.Checked = True Then
            Ptype = "Credit"
        End If
        If radDebit.Checked = True Then
            Ptype = "Debit"
        End If
        res = Lilitha.getConnection()
        If res = "True" Then
            Dim result As String
            result = Lilitha.AddPayment(txtPNumber.Text, Ptype, DateTimePicker1.Text, txtAmount.Text, txtCustId.Text, txtResNo.Text, txtEmpID.Text)
            If result = "True" Then
                MsgBox("Payment made succesfully")
                Me.radCash.Checked = True
                Me.txtAmount.Text = ""
                Me.txtCard.Text = ""
                Me.txtCustId.Text = ""
                Me.txtEmpID.Text = ""
                Me.txtPNumber.Text = ""
                Me.txtResNo.Text = ""
                txtAmount.Focus()
            Else
                MsgBox("Error has occurs when making payment")


            End If
        Else
            MessageBox.Show(res, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radCash.Checked = True
        Dim dsCust As New DataSet
        Dim result As String
        result = Lilitha.getConnection()
        If result = "True" Then
            dsCust = Lilitha.GetAllGuest()
            If dsCust.Tables("dtCustomers").Rows.Count = 0 Then
                MessageBox.Show(result, "No data values in the database", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                For i As Integer = 0 To dsCust.Tables("dtCustomers").Rows.Count - 1
                    Me.cmdCustId.Items.Add(dsCust.Tables("dtCustomers").Rows(i)!CustId)
                Next
            End If
        Else
            MsgBox("NO CONNECTION")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        radCash.Checked = True
        txtAmount.Text = ""
        txtCard.Text = ""
        txtCustId.Text = ""
        txtEmpID.Text = ""
        txtPNumber.Text = ""
        txtResNo.Text = ""
        txtAmount.Focus()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


        Dim result As String
        Dim res As String
        result = Lilitha.getConnection()
        If result = "True" Then
            res = Lilitha.GetDeletePayment(cmdCustId.SelectedItem)
            If res = "True" Then
                If (DialogResult.Yes = MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                    MsgBox(" Payment cancelled successfully")
                Else
                    Me.Hide()
                    Reception.Show()
                End If
            Else
                MsgBox("Error has occured in delete process")
            End If

        Else
            MsgBox("NO CONNECTION")
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class