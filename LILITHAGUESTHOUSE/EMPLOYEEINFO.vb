Public Class EMPLOYEEINFO
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Management.Show()
    End Sub

    Private Sub EMPLOYEEINFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsEmp, dsEmp2 As New DataSet
        Dim result As String
        result = Lilitha.getConnection()
        If result = "True" Then
            dsEmp = Lilitha.GetCustEmp()
            If dsEmp.Tables("dtEmployees").Rows.Count = 0 Then
                MessageBox.Show(result, "No data values in the database", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                For i As Integer = 0 To dsEmp.Tables("dtEmployees").Rows.Count - 1
                    Me.cmbEmpId.Items.Add(dsEmp.Tables("dtEmployees").Rows(i)!EmpId)
                Next

                dsEmp2 = Lilitha.getAllEmployeeDetails()
                If dsEmp2.Tables("dtEmployees").Rows.Count = 0 Then
                    MessageBox.Show(result, "No data values in the database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.dgdEmpInfo.DataSource = dsEmp2.Tables("dtEmployees")
                End If
            End If
        Else
            MsgBox("NO CONNECTION")
        End If
    End Sub

    Private Sub cmbEmpId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpId.SelectedIndexChanged

    End Sub

    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Dim ds As New DataSet
        Dim str As String
        str = Lilitha.getConnection()
        If str = "True" Then
            ds = Lilitha.GetEmpByEmpId(cmbEmpId.SelectedItem)
            For i As Integer = 0 To ds.Tables("Employees").Rows.Count - 1
                dgdEmpInfo.DataSource = ds.Tables("Employees")
            Next
        Else
            MsgBox(str, "NO CONNECTION")

        End If
    End Sub

    Private Sub btnDeleteE_Click(sender As Object, e As EventArgs) Handles btnDeleteE.Click
        Dim result As String
        Dim res As String
        result = Lilitha.getConnection()
        If result = "True" Then
            res = Lilitha.getDeleteEmp(cmbEmpId.SelectedItem)
            If res = "True" Then
                If (DialogResult.Yes = MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                    MessageBox.Show(" Employee deleted successfully", "DELETED")
                Else
                    Me.Hide()
                    Management.Show()
                End If
            Else
                MessageBox.Show(result, "Error has occured in delete process", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show(result, "CONNECTION BROKEN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnUpdateE_Click(sender As Object, e As EventArgs) Handles btnUpdateE.Click
        Dim res As String
        If cmbEmpId.Text.Trim.Length <> 13 Then
            MsgBox("Id number must contain 13 numbers")
            cmbEmpId.Focus()
            Return
        End If
        If IsNumeric(txtPhone.Text.Trim) = False Then
            MsgBox("Phone number must be only numbers")
            txtName.Focus()
            Return
        End If
        If txtPhone.Text.Trim = " " Then
            MsgBox("Please enter phone number")
            txtName.Focus()
            Return
        End If
        If IsNumeric(cmbEmpId.Text.Trim) = False Then
            MsgBox("Id number must be numeric")
            cmbEmpId.Focus()
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

        If txtBusinesscode.Text = "" Then
            MsgBox("Please enter business code")
            txtName.Focus()
            Return
        End If

        If txtBusinesscode.Text.Trim.Length <> 4 Then
            MsgBox("Business code must be 4 digits")
            txtName.Focus()
            Return
        End If

        If txtAddress.Text = "" Then
            MsgBox("Please enter addres ")
            txtName.Focus()
            Return
        End If
        If txtEmployeeT.Text.Trim = " " Then
            MsgBox("Please enter employee type")
            txtName.Focus()
            Return
        End If
        Dim emp As String = txtEmployeeT.Text.ToUpper()
        For Z As Integer = 0 To emp.Length - 1
            Select Case emp.Substring(Z, 1)
                Case "A" To "Z"
                Case Else
                    MsgBox("Employee type must be alphabets")
                    txtSurname.Clear()
                    txtSurname.Focus()
                    Return
            End Select
        Next

        If cmbGender.SelectedItem = "Select" Then
            MsgBox("Please select gender")
            txtName.Focus()
            Return
        End If
        res = Lilitha.getConnection()
        If res = "True" Then
            Dim result As String
            result = Lilitha.UpdateEmp(cmbEmpId.SelectedItem, txtName.Text, txtSurname.Text, txtPhone.Text, txtAddress.Text, txtEmail.Text, cmbGender.SelectedItem, txtBusinesscode.Text, txtEmployeeT.Text)
            If result = "True" Then
                MsgBox("You have updated employee succesfully")

                Me.txtName.Text = ""
                Me.txtSurname.Text = ""
                Me.txtPhone.Text = ""
                Me.txtEmail.Text = ""
                Me.txtAddress.Text = ""
                Me.txtBusinesscode.Text = ""
                Me.txtEmployeeT.Text = ""
                Me.cmbGender.Text = "Selec Gender"
                Me.cmbEmpId.Text = "Select ID"

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
        Me.txtBusinesscode.Text = ""
        Me.txtEmail.Text = ""
        Me.txtAddress.Text = ""
        Me.txtEmployeeT.Text = ""
        Me.txtPhone.Text = ""
        txtName.Focus()
    End Sub
End Class