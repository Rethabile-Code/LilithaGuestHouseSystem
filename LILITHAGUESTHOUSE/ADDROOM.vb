Public Class ADDROOM
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Management.Show()
    End Sub


    Private Sub btnARoom_Click(sender As Object, e As EventArgs) Handles btnARoom.Click

        If txtRNumber.Text.Trim.Length <> 2 Then
            MsgBox("Room number must be 2 charecters")
            txtRNumber.Focus()
            Return
        End If
        If txtRNumber.Text = "" Then
            MsgBox("Please Room Number")
            txtRNumber.Focus()
            Return
        End If
        If IsNumeric(txtRDescription.Text) = True Then
            MsgBox("Room must description must alphabetic")
            txtRNumber.Focus()
            Return
        End If

        If txtRDescription.Text = "" Then
            MsgBox("Please enter the room description")
            txtRDescription.Focus()
            Return
        End If

        If txtRType.Text = "" Then
            MsgBox("Enter enter room code")
            txtRNumber.Focus()
            Return
        End If
        If txtBCode.Text.Trim.Length <> 4 Then
            MsgBox("Business code must 4 charecters")
            txtRNumber.Focus()
            Return
        End If
        If txtBCode.Text = "" Then
            MsgBox("Enter business code")
            txtRNumber.Focus()
            Return
        End If
        Dim result As String
        Dim res As String
        result = Lilitha.getConnection()
        If result = "True" Then
            res = Lilitha.AddRoom(txtRNumber.Text, txtRDescription.Text, txtRType.Text, txtBCode.Text)
            If res = "True" Then
                MsgBox("Room added succesfully")
                Me.txtRNumber.Text = ""
                Me.txtRDescription.Text = ""
                Me.txtRType.Text = ""
                Me.txtBCode.Text = ""
                Me.txtRNumber.Focus()
            Else
                MsgBox("Error has occured when adding details")

            End If
        Else

            MessageBox.Show(result, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBCode.Text = ""
        txtRDescription.Text = ""
        txtRNumber.Text = ""
        txtRType.Text = ""
        txtRNumber.Focus()
    End Sub
End Class