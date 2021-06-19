Public Class HomePage
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        pnlHISTORY.Visible = False
        pnlLogin.Visible = True
        pnlRoomT.Visible = False
        pnlL.Visible = False
        pnlR.Visible = True
        pnlH.Visible = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblHistory_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HISTORY.Show()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblRoomType_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.Text = "Enter passward"
        txtPass.ForeColor = Color.Gold
        txtUser.Text = "Enter username"
        txtUser.ForeColor = Color.Gold
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        pnlHISTORY.Visible = False
        pnlLogin.Visible = False
        pnlRoomT.Visible = True
        pnlR.Visible = False
        pnlL.Visible = True
        pnlH.Visible = True
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim AccLev As Integer
        Dim re As String = ""
        Dim flag As Integer
        flag = 0
        Dim dsDet As New DataSet
        'VALIDATING USERNAME IS EMPTY OR NOT
        If txtUser.Text = "" Then
            lblError.ForeColor = Color.Red
            lblError.Text = "Please input User name"
            txtUser.Focus()
            Return
        End If
        'VALIDATING PASSWORD IS EMPTY OR NOT
        If txtPass.Text = "" Then
            lblError.ForeColor = Color.Red
            lblError.Text = "Please input password"
            txtPass.Focus()
            Return
        End If
        'VALIDATING Job title IS EMPTY OR NOT
        If cmbTitle.Text = "Select" Then
            lblError.ForeColor = Color.Red
            lblError.Text = "Please select job title"

            cmbTitle.Focus()
            Return
        End If
        If cmbTitle.SelectedItem = "Manager" Then
            AccLev = 2
        End If
        If cmbTitle.SelectedItem = "Receptionist" Then
            AccLev = 1
        End If
        re = Lilitha.getConnection()
        If re = "True" Then

            dsDet = Lilitha.GetLogin()
            Dim count As Integer
            For count = 0 To dsDet.Tables("LOGIN").Rows.Count - 1
                If (txtUser.Text = dsDet.Tables("LOGIN").Rows(count).Item("Username")) Then
                    If (txtPass.Text = dsDet.Tables("LOGIN").Rows(count).Item("Password")) Then
                        If (AccLev = dsDet.Tables("LOGIN").Rows(count).Item("AccessLevel")) Then
                            flag = 0
                            MsgBox("Sucessfuly Loggedin")
                            Me.Hide()
                            If (AccLev = 1) Then
                                Reception.Show()
                            Else
                                Management.Show()
                            End If
                            Return
                        Else
                            flag = 1
                        End If
                    Else
                        flag = 1
                    End If
                Else
                    flag = 1
                End If
            Next
            If flag = 1 Then
                lblError.Text = "Invalid user"
                lblError.ForeColor = Color.Red

                txtUser.Text = ""
                txtPass.Text = ""
                cmbTitle.Text = "Select"
                txtUser.Focus()
            End If
        Else
            MessageBox.Show(re, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        NewUser.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Just create new account", "We can't help you", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub


    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlHISTORY.Visible = True
        pnlH.Visible = False
        pnlLogin.Visible = False
        pnlRoomT.Visible = False
        pnlR.Visible = True
        pnlL.Visible = True
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtUser_MouseEnter(sender As Object, e As EventArgs) Handles txtUser.MouseEnter

        If txtUser.Text = "Enter username" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Gold
        End If
    End Sub

    Private Sub txtUser_MouseLeave(sender As Object, e As EventArgs) Handles txtUser.MouseLeave
        If txtUser.Text = "" Then
            txtUser.Text = "Enter username"
            txtUser.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub txtPass_MouseEnter(sender As Object, e As EventArgs) Handles txtPass.MouseEnter

        If txtUser.Text = "Enter password" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Gold
        End If
    End Sub

    Private Sub txtPass_MouseLeave(sender As Object, e As EventArgs) Handles txtPass.MouseLeave
        If txtPass.Text = "" Then
            txtPass.Text = "Enter password"
            txtPass.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        txtPass.UseSystemPasswordChar = False
    End Sub

    Private Sub btnEnter_MouseEnter(sender As Object, e As EventArgs) Handles btnEnter.MouseEnter
        btnEnter.ForeColor = Color.Green
    End Sub

    Private Sub btnEnter_MouseLeave(sender As Object, e As EventArgs) Handles btnEnter.MouseLeave
        btnEnter.ForeColor = Color.AliceBlue
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()

    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.Red

    End Sub

    Private Sub Button5_MouseMove(sender As Object, e As MouseEventArgs) Handles Button5.MouseMove

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseClick

    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.AliceBlue


    End Sub
End Class