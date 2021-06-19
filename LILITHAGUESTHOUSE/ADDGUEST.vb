Public Class ADDGUEST
    Dim Lilitha As New LilithaClasss
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Reception.Show()
    End Sub

    Private Sub btnAddGuest_Click(sender As Object, e As EventArgs) Handles btnAddGuest.Click

        If txtId.Text.Trim.Length <> 13 Then
            MsgBox("Id number must contain 13 numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtPNumber.Text.Trim) = False Then
            MsgBox("Phone number must be only numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtRess.Text.Trim) = False Then
            MsgBox("Reservation number must be only numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtDays.Text.Trim) = False Then
            MsgBox("Number of days must be only numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtPayn.Text.Trim) = False Then
            MsgBox("Phone number must be only numbers")
            txtName.Focus()
            Return
        End If
        If IsNumeric(txtId.Text.Trim) = False Then
            MsgBox("Id number must be numeric")
            txtId.Focus()
            Return
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
        Dim result As String
        Dim res As String
        result = Lilitha.getConnection()
        If result = "True" Then
            res = Lilitha.AddCustomer(txtId.Text, txtName.Text, txtSurname.Text, txtPNumber.Text, txtRess.Text, txtPayn.Text, txtDays.Text, cmbGender.Text)

            If res = "True" Then
                MsgBox("Inserted succesfully")
                Me.txtName.Text = ""
                Me.txtSurname.Text = ""
                Me.txtId.Text = ""
                Me.txtPayn.Text = ""
                Me.txtRess.Text = ""
                Me.txtPNumber.Text = ""
                Me.txtDays.Text = ""
                txtName.Focus()
            Else
                MsgBox("Error has occured when adding details")
            End If
        Else

            MessageBox.Show(result, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtName.Text = ""
        Me.txtSurname.Text = ""
        Me.txtId.Text = ""
        Me.txtPayn.Text = ""
        Me.txtRess.Text = ""
        Me.txtPNumber.Text = ""
        Me.txtDays.Text = ""
        txtName.Focus()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtRess_TextChanged(sender As Object, e As EventArgs) Handles txtRess.TextChanged

    End Sub
End Class