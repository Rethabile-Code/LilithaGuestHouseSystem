Public Class CHECKIN
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Reception.Show()
    End Sub

    Private Sub btnCheckin_Click(sender As Object, e As EventArgs) Handles btnCheckin.Click
        Dim res As String
        res = Lilitha.getConnection()
        If res = "True" Then
            Dim result As String
            result = Lilitha.AddCustomer(txtIdNumber.Text, txtName.Text, txtSurname.Text, txtPNumber.Text, txtRNumber.Text, txtPaymentN.Text, txtNumberOfDays.Text, cmbGender.Text)
            If result = "True" Then
                MsgBox("Customer Added succesfully")

                Me.txtName.Text = ""
                Me.txtSurname.Text = ""
                Me.txtNumberOfDays.Text = ""
                Me.txtIdNumber.Text = ""
                Me.txtPaymentN.Text = ""
                Me.txtRNumber.Text = ""
                Me.cmbGender.Text = "Select Gender"
                Me.txtPNumber.Text = ""

            Else
                MsgBox("Error has occured when adding details")

            End If
        Else

            MessageBox.Show(res, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If txtName.Text = "" Then
            MsgBox("Please enter name")
            txtName.Focus()
            Return
        End If
        If txtSurname.Text = "" Then
            MsgBox("Please enter Surname")
            txtName.Focus()
            Return
        End If
        If txtIdNumber.Text.Trim.Length <> 13 Then
            MsgBox("Id number must contain 13 numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtIdNumber.Text.Trim) = False Then
            MsgBox("Id number must be only numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtPNumber.Text.Trim) = False Then
            MsgBox("Phone number must be only numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtRNumber.Text.Trim) = False Then
            MsgBox("Reservation number must be only numbers")
            txtName.Focus()
            Return
        End If
        If txtRNumber.Text.Trim = " " Then
            MsgBox("Please enter reservation number")
            txtName.Focus()
            Return
        End If
        If txtPaymentN.Text.Trim = " " Then
            MsgBox("Please enter payment number")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtPaymentN.Text.Trim) = False Then
            MsgBox("Payment number must be numeric")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtNumberOfDays.Text.Trim) = False Then
            MsgBox("Number of days must be numeric")
            txtName.Focus()
            Return
        End If
        If txtNumberOfDays.Text = "" Then
            MsgBox("Please enter number of days to stays")
            txtName.Focus()
            Return
        End If
    End Sub

    Private Sub CHECKIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGender.SelectedItem = "Selec Gender"
    End Sub

    Private Sub txtPaymentN_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentN.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class