Public Class frmROOMLIST
    Dim Lilitha As New LilithaClasss
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Management.Show()
    End Sub

    Private Sub frmROOMLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dsRoom, ds2 As New DataSet
        Dim result As String
        result = Lilitha.getConnection()
        If result = "True" Then
            dsRoom = Lilitha.GetRoomNo()
            If dsRoom.Tables("dtRoom").Rows.Count = 0 Then
                MessageBox.Show(result, "No data values in the database", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                For i As Integer = 0 To dsRoom.Tables("dtRoom").Rows.Count - 1
                    Me.cboRNumber.Items.Add(dsRoom.Tables("dtRoom").Rows(i)!RoomNumber)
                Next

                ds2 = Lilitha.getRoom()
                If ds2.Tables("dtRoom").Rows.Count = 0 Then
                    MessageBox.Show(result, "No data values in the database", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Me.dgvRoom.DataSource = ds2.Tables("dtRoom")
                End If
            End If
        Else
            MsgBox("NO CONNECTION")
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim res As String

        If cboRNumber.Text.Trim.Length <> 2 Then
            MsgBox("Room number must be 2 charecters")
            cboRNumber.Focus()
            Return
        End If
        If cboRNumber.Text = "" Then
            MsgBox("Please enter Room Number")
            cboRNumber.Focus()
            Return
        End If
        If IsNumeric(txtRDescription.Text) = True Then
            MsgBox("Room must description must alphabetic")
            cboRNumber.Focus()
            Return
        End If

        If txtRDescription.Text = "" Then
            MsgBox("Please enter the room description")
            txtRDescription.Focus()
            Return
        End If

        If txtRType.Text = "" Then
            MsgBox("Enter enter room type")
            cboRNumber.Focus()
            Return
        End If
        If txtBCode.Text.Trim.Length <> 4 Then
            MsgBox("Business code must 4 charecters")
            cboRNumber.Focus()
            Return
        End If
        If txtBCode.Text = "" Then
            MsgBox("Enter business code")
            cboRNumber.Focus()
            Return
        End If

        res = Lilitha.getConnection()
        If res = "True" Then
            Dim result As String
            result = Lilitha.UpdateRoom(cboRNumber.SelectedItem, txtRDescription.Text, txtRType.Text, txtBCode.Text)
            If result = "True" Then
                MsgBox("You have updated room succesfully")

                Me.txtRDescription.Text = ""
                Me.txtRType.Text = ""
                Me.txtBCode.Text = ""
                Me.cboRNumber.Text = "Select Room Number"

            Else
                MsgBox("Error has occured when adding details")

            End If
        Else

            MessageBox.Show(res, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtBCode_TextChanged(sender As Object, e As EventArgs) Handles txtBCode.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtBCode.Text = ""
        Me.txtRDescription.Text = ""
        Me.txtRType.Text = ""
        txtRDescription.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As String
        Dim res As String
        result = Lilitha.getConnection()
        If result = "True" Then
            res = Lilitha.getDeleteRoom(cboRNumber.SelectedItem)
            If res = "True" Then
                If (DialogResult.Yes = MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                    MsgBox(" Room deleted successfully")
                Else
                    Me.Hide()
                    Management.Show()
                End If
            Else
                MsgBox("Error has occured in delete process")
            End If

        Else
            MsgBox("NO CONNECTION")
        End If
    End Sub

    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Dim ds As New DataSet
        Dim str As String
        str = Lilitha.getConnection()
        If str = "True" Then
            ds = Lilitha.GetRoomByRNumber(cboRNumber.SelectedItem)

            For i As Integer = 0 To ds.Tables("dtRoom").Rows.Count - 1
                dgvRoom.DataSource = ds.Tables("dtRoom")
            Next
        Else
            MsgBox(str, "NO CONNECTION")

        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class