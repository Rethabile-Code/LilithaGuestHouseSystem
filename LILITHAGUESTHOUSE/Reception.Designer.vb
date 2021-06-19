<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reception
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ADDGUESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESERVETIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAYMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUESTINFOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEVELOPERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDGUESTToolStripMenuItem, Me.CHECKINToolStripMenuItem, Me.RESERVETIONToolStripMenuItem, Me.PAYMENTToolStripMenuItem, Me.GUESTINFOToolStripMenuItem, Me.DEVELOPERSToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ADDGUESTToolStripMenuItem
        '
        Me.ADDGUESTToolStripMenuItem.Name = "ADDGUESTToolStripMenuItem"
        Me.ADDGUESTToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ADDGUESTToolStripMenuItem.Text = "ADD GUEST"
        '
        'CHECKINToolStripMenuItem
        '
        Me.CHECKINToolStripMenuItem.Name = "CHECKINToolStripMenuItem"
        Me.CHECKINToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CHECKINToolStripMenuItem.Text = "CHECKIN"
        '
        'RESERVETIONToolStripMenuItem
        '
        Me.RESERVETIONToolStripMenuItem.Name = "RESERVETIONToolStripMenuItem"
        Me.RESERVETIONToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.RESERVETIONToolStripMenuItem.Text = "RESERVATION"
        '
        'PAYMENTToolStripMenuItem
        '
        Me.PAYMENTToolStripMenuItem.Name = "PAYMENTToolStripMenuItem"
        Me.PAYMENTToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.PAYMENTToolStripMenuItem.Text = "PAYMENT"
        '
        'GUESTINFOToolStripMenuItem
        '
        Me.GUESTINFOToolStripMenuItem.Name = "GUESTINFOToolStripMenuItem"
        Me.GUESTINFOToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.GUESTINFOToolStripMenuItem.Text = "GUEST INFO"
        '
        'DEVELOPERSToolStripMenuItem
        '
        Me.DEVELOPERSToolStripMenuItem.Name = "DEVELOPERSToolStripMenuItem"
        Me.DEVELOPERSToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.DEVELOPERSToolStripMenuItem.Text = "DEVELOPERS"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.DarkRed
        Me.btnLogout.Location = New System.Drawing.Point(1253, 1)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(85, 23)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Reception
        '
        Me.BackgroundImage = Global.LILITHAGUESTHOUSE.My.Resources.Resources._4___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Reception"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ADDGUESTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RESERVETIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAYMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GUESTINFOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogout As Button
    Friend WithEvents DEVELOPERSToolStripMenuItem As ToolStripMenuItem
End Class
