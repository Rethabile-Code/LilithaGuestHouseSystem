Public Class REPORTS
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub REPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class