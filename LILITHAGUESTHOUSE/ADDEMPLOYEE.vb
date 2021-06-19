Imports System.Data
Imports System.Data.OleDb
Public Class ADDEMPLOYEE
    Dim Lilitha As New LilithaClasss
    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        If txtID.Text.Trim.Length <> 13 Then
            MsgBox("Id number must contain 13 numbers")
            txtName.Focus()
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
        If IsNumeric(txtID.Text.Trim) = False Then
            MsgBox("Id number must be numeric")
            txtID.Focus()
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
        Dim res As String
        res = Lilitha.getConnection()
        If res = "True" Then
            Dim result As String
            result = Lilitha.AddEmp(txtID.Text, txtName.Text, txtSurname.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text, cmbGender.SelectedItem, txtBusinesscode.Text, txtEmployeeT.Text)
            If result = "True" Then
                MessageBox.Show("Inserted succesfully")

                Me.txtName.Text = ""
                Me.txtSurname.Text = ""
                Me.txtBusinesscode.Text = ""
                Me.txtID.Text = ""
                Me.txtAddress.Text = ""
                Me.txtPhone.Text = ""
                Me.cmbGender.Text = "SelectTitle"
                Me.txtEmployeeT.Text = ""
                Me.txtEmail.Text = ""
                txtName.Focus()
            Else
                MessageBox.Show(res, "Error has occured when adding details", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else

            MessageBox.Show(res, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ADDEMPLOYEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGender.SelectedItem = "Select"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Management.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtName.Text = ""
        Me.txtSurname.Text = ""
        Me.txtID.Text = ""
        Me.txtPhone.Text = ""
        Me.txtAddress.Text = ""
        Me.txtIDNumber.Text = ""
        Me.txtBusinesscode.Text = ""
        Me.txtEmail.Clear()
        Me.txtEmployeeT.Clear()
        txtName.Focus()
    End Sub
End Class