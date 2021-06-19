Public Class NewUser
    Dim Lilitha As New LilithaClasss
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        HomePage.Show()
    End Sub
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        If txtUsername.Text = "" Then
            MsgBox("Please enter Surname")
            txtUsername.Focus()
            Return
        End If

        If txtNewP.Text = "" Then
            MsgBox("Please enter New Password")
            txtNewP.Focus()
            Return
        End If

        If txtConP.Text = "" Then
            MsgBox("Please enter New Password")
            txtConP.Focus()
            Return
        End If
        If (txtAccessL.Text) = "" Then
            MsgBox(" Enter Access level")
            txtUsername.Focus()
        End If
        If IsNumeric(txtAccessL.Text) = False Then
            MsgBox(" We allow numbers only")
            txtUsername.Focus()
        End If
        Dim result As String = " "
        result = Lilitha.getConnection()
        If result = "True" Then
            Dim dsDet As New DataSet
            Dim res As String
            res = Lilitha.AddUser(txtUsername.Text, txtNewP.Text, txtAccessL.Text)
            If res = "true" Then
                MessageBox.Show("You have  Inserted new user succesfully", "Welcome to liitha guest lodge", MessageBoxButtons.OK)
                Me.txtAccessL.Clear()
                Me.txtConP.Clear()
                Me.txtNewP.Clear()
                Me.txtUsername.Clear()
            Else
                MsgBox("Error in Insertion")
            End If
        Else
            MsgBox("Broken connection")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsername.Text = ""
        txtNewP.Text = ""
        txtConP.Text = ""
        Me.txtAccessL.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class