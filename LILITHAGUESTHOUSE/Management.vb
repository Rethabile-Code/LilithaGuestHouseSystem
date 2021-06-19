Public Class Management
    Dim Lilitha As New LilithaClasss
    Dim con As New OleDb.OleDbConnection


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblEmployeeInfo.Click
        Me.Hide()
        EMPLOYEEINFO.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        HomePage.Show()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblReports_Click(sender As Object, e As EventArgs) Handles lblReports.Click
        Me.Hide()
        REPORTS.Show()
    End Sub

    Private Sub lblHistory_Click(sender As Object, e As EventArgs) Handles lblHistory.Click
        Me.Hide()
        HISTORY.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblAddRoom_Click(sender As Object, e As EventArgs) Handles lblAddRoom.Click
        Me.Hide()
        ADDROOM.Show()
    End Sub

    Private Sub lblRoomList_Click(sender As Object, e As EventArgs) Handles lblRoomList.Click
        Me.Hide()
        frmROOMLIST.Show()

    End Sub

    Private Sub lblAddEmployee_Click(sender As Object, e As EventArgs) Handles lblAddEmployee.Click
        Me.Hide()
        ADDEMPLOYEE.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class