Public Class Reception
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection
    Private Sub RESERVETIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESERVETIONToolStripMenuItem.Click
        Me.Hide()
        RESERVATION.Show()
    End Sub

    Private Sub ADDGUESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDGUESTToolStripMenuItem.Click

        Me.Hide()
        ADDGUEST.Show()

    End Sub

    Private Sub CHECKINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKINToolStripMenuItem.Click
        Me.Hide()
        CHECKIN.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub PAYMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAYMENTToolStripMenuItem.Click
        Me.Hide()
        PAYMENT.Show()
    End Sub

    Private Sub GUESTINFOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUESTINFOToolStripMenuItem.Click
        Me.Hide()
        GUESTINFO.Show()
    End Sub

    Private Sub Reception_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DEVELOPERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVELOPERSToolStripMenuItem.Click
        Me.Hide()
        Developers.Show()
    End Sub
End Class