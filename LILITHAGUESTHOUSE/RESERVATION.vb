Public Class RESERVATION
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtRType.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtGustId.Clear()
        Me.txtPNumber.Clear()
        Me.txtRDate.Clear()
        Me.txtRoomNumber.Clear()
        Me.txtRType.Clear()
        Me.txtGustId.Focus()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtRNumber.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPNumber.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Reception.Show()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        If txtRNumber.Text = "" Then
            MsgBox("Please enter reservation number")
            txtRNumber.Focus()
            Return
        End If
        If IsNumeric(txtRNumber.Text) = False Then
            MsgBox("Reservation number must be numeric")
            txtRNumber.Focus()
            Return
        End If

        If txtRType.Text = "" Then
            MsgBox("Please enter reservation type")
            txtRNumber.Focus()
            Return
        End If
        If (txtGustId.Text.Trim.Length <> 13) Then
            MsgBox("ID NUMBER LENGTH MUST BE 13")
            txtRNumber.Focus()
            Return
        End If
        If IsNumeric(txtPNumber.Text) = False Then
            MsgBox("Payment number must be numeric")
            txtRNumber.Focus()
            Return
        End If
        If txtRType.Text = "" Then
            MsgBox("Please enter payment number")
            txtRNumber.Focus()
            Return
        End If
        If txtRoomNumber.Text = "" Then
            MsgBox("Please enter room number")
            txtRNumber.Focus()
            Return
        End If
        If txtRoomNumber.Text.Trim.Length <> 2 Then
            MsgBox("Room number must be 2 charecters")
            txtRNumber.Focus()
            Return
        End If
        Dim result As String
        Dim res As String
        result = Lilitha.getConnection()
        If result = "True" Then
            res = Lilitha.AddRes(txtRNumber.Text, txtRDate.Text, txtRType.Text, txtGustId.Text, txtPNumber.Text, txtRoomNumber.Text)

            If res = "True" Then
                MsgBox("Inserted succesfully")
                Me.txtRoomNumber.Clear()
                Me.txtRDate.Clear()
                Me.txtRNumber.Clear()
                Me.txtPNumber.Clear()
                Me.txtGustId.Clear()
                Me.txtRType.Clear()

                Me.txtRNumber.Focus()

            Else
                MsgBox("Error has occured when adding details")
            End If
        Else

            MessageBox.Show(result, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RESERVATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class