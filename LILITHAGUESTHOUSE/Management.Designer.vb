<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAddEmployee = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblRoomList = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAddRoom = New System.Windows.Forms.Label()
        Me.lblEmployeeInfo = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.LILITHAGUESTHOUSE.My.Resources.Resources.INFO
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.LILITHAGUESTHOUSE.My.Resources.Resources.ADDROOMNEW
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAddEmployee)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.lblRoomList)
        Me.GroupBox1.Controls.Add(Me.PictureBox18)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblAddRoom)
        Me.GroupBox1.Controls.Add(Me.lblEmployeeInfo)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblAddEmployee
        '
        resources.ApplyResources(Me.lblAddEmployee, "lblAddEmployee")
        Me.lblAddEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAddEmployee.Name = "lblAddEmployee"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = Global.LILITHAGUESTHOUSE.My.Resources.Resources.addEMP
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'lblRoomList
        '
        resources.ApplyResources(Me.lblRoomList, "lblRoomList")
        Me.lblRoomList.Name = "lblRoomList"
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.SystemColors.Highlight
        resources.ApplyResources(Me.PictureBox18, "PictureBox18")
        Me.PictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox18.Image = Global.LILITHAGUESTHOUSE.My.Resources.Resources.ROOMLIST
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.TabStop = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'lblAddRoom
        '
        resources.ApplyResources(Me.lblAddRoom, "lblAddRoom")
        Me.lblAddRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAddRoom.Name = "lblAddRoom"
        '
        'lblEmployeeInfo
        '
        resources.ApplyResources(Me.lblEmployeeInfo, "lblEmployeeInfo")
        Me.lblEmployeeInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEmployeeInfo.Name = "lblEmployeeInfo"
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Image = Global.LILITHAGUESTHOUSE.My.Resources.Resources.LOGOUT1
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblReports)
        Me.GroupBox2.Controls.Add(Me.lblHistory)
        Me.GroupBox2.Controls.Add(Me.PictureBox16)
        Me.GroupBox2.Controls.Add(Me.PictureBox15)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'lblReports
        '
        resources.ApplyResources(Me.lblReports, "lblReports")
        Me.lblReports.Name = "lblReports"
        '
        'lblHistory
        '
        resources.ApplyResources(Me.lblHistory, "lblHistory")
        Me.lblHistory.Name = "lblHistory"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.SystemColors.Highlight
        resources.ApplyResources(Me.PictureBox16, "PictureBox16")
        Me.PictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox16.Image = Global.LILITHAGUESTHOUSE.My.Resources.Resources.REPORTS
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.SystemColors.Highlight
        resources.ApplyResources(Me.PictureBox15, "PictureBox15")
        Me.PictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox15.Image = Global.LILITHAGUESTHOUSE.My.Resources.Resources.images__4_
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Name = "Label1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Management
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources._6
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "Management"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAddRoom As Label
    Friend WithEvents lblEmployeeInfo As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblRoomList As Label
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents lblAddEmployee As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblReports As Label
    Friend WithEvents lblHistory As Label
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
End Class
