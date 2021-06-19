Public Class GUESTINFO
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Reception.Show()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As String
        Dim res As String
        result = Lilitha.getConnection()
        If result = "True" Then
            res = Lilitha.DeleteGuest(cmbCustomerId.SelectedItem)
            If res = "True" Then
                If (DialogResult.Yes = MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                    MsgBox(" Guest deleted successfully")
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

    Private Sub dgdCustomerInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerInfo.CellContentClick

    End Sub

    Private Sub GUESTINFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsEmp, dsEmp2 As New DataSet
        Dim result As String
        result = Lilitha.getConnection()
        If result = "True" Then
            dsEmp = Lilitha.GetAllGuest()
            If dsEmp.Tables("dtCustomers").Rows.Count = 0 Then
                MessageBox.Show(result, "No data values in the database", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                For i As Integer = 0 To dsEmp.Tables("dtCustomers").Rows.Count - 1
                    Me.cmbCustomerId.Items.Add(dsEmp.Tables("dtCustomers").Rows(i)!CustId)
                Next

                dsEmp2 = Lilitha.GetAllGuest()
                If dsEmp2.Tables("dtCustomers").Rows.Count = 0 Then
                    MessageBox.Show(result, "No data values in the database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.dgvCustomerInfo.DataSource = dsEmp2.Tables("dtCustomers")
                End If
            End If
        Else
            MsgBox("NO CONNECTION")
        End If
        Me.cmbCustomerId.Text = "Select Id"
        Me.cmbGender.Text = "Select Gender"

    End Sub

    Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim res As String
        If cmbCustomerId.Text.Trim.Length <> 13 Then
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
        If IsNumeric(cmbCustomerId.Text.Trim) = False Then
            MsgBox("Id number must be numeric")
            cmbCustomerId.Focus()
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
        res = Lilitha.getConnection()
        If res = "True" Then
            Dim result As String
            result = Lilitha.UpdateGuest(cmbCustomerId.SelectedItem, txtName.Text, txtSurname.Text, txtPNumber.Text, txtDays.Text, txtPayn.Text, txtRess.Text, cmbGender.SelectedItem)
            If result = "True" Then
                MsgBox("You have updated customer  succesfully")

                Me.txtName.Text = ""
                Me.txtSurname.Text = ""
                Me.txtPayn.Text = ""
                Me.txtDays.Text = ""
                Me.txtPNumber.Text = ""
                Me.txtRess.Text = ""
                Me.cmbGender.Text = "Selec Gender"
                Me.cmbCustomerId.Text = "Select ID"

            Else
                MsgBox("Error has occured when adding details")

            End If
        Else

            MessageBox.Show(res, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtName.Text = ""
        Me.txtSurname.Text = ""
        Me.txtPayn.Text = ""
        Me.txtRess.Text = ""
        Me.txtPNumber.Text = ""
        Me.txtDays.Text = ""
        Me.cmbCustomerId.Text = "Select Id"
        Me.cmbGender.Text = "Select Gender"
        txtName.Focus()
    End Sub

    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Dim ds As New DataSet
        Dim str As String
        str = Lilitha.getConnection()
        If str = "True" Then
            ds = Lilitha.GetGuestByCusdId(cmbCustomerId.SelectedItem)
            For i As Integer = 0 To ds.Tables("Customers").Rows.Count - 1
                dgvCustomerInfo.DataSource = ds.Tables("Customers")
            Next
        Else
            MsgBox(str, "NO CONNECTION")

        End If
    End Sub
End Class