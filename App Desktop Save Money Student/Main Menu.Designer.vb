<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputSaveMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputTransactionOutMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstagramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacebookCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SupportCompanyToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ReportBugToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputSaveMoneyToolStripMenuItem, Me.InputTransactionOutMoneyToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'InputSaveMoneyToolStripMenuItem
        '
        Me.InputSaveMoneyToolStripMenuItem.Name = "InputSaveMoneyToolStripMenuItem"
        Me.InputSaveMoneyToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.InputSaveMoneyToolStripMenuItem.Text = "Input Save Money"
        '
        'InputTransactionOutMoneyToolStripMenuItem
        '
        Me.InputTransactionOutMoneyToolStripMenuItem.Name = "InputTransactionOutMoneyToolStripMenuItem"
        Me.InputTransactionOutMoneyToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.InputTransactionOutMoneyToolStripMenuItem.Text = "Input Transaction Out Money"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'SupportCompanyToolStripMenuItem
        '
        Me.SupportCompanyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstagramToolStripMenuItem, Me.FacebookCompanyToolStripMenuItem})
        Me.SupportCompanyToolStripMenuItem.Name = "SupportCompanyToolStripMenuItem"
        Me.SupportCompanyToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.SupportCompanyToolStripMenuItem.Text = "Support Company"
        '
        'InstagramToolStripMenuItem
        '
        Me.InstagramToolStripMenuItem.Name = "InstagramToolStripMenuItem"
        Me.InstagramToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InstagramToolStripMenuItem.Text = "Instagram"
        '
        'FacebookCompanyToolStripMenuItem
        '
        Me.FacebookCompanyToolStripMenuItem.Name = "FacebookCompanyToolStripMenuItem"
        Me.FacebookCompanyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FacebookCompanyToolStripMenuItem.Text = "Facebook Company"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ReportBugToolStripMenuItem.Text = "Report Bug"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(729, 350)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Menu"
        Me.Text = "Main_Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputSaveMoneyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstagramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacebookCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputTransactionOutMoneyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
End Class
