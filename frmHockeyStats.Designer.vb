<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHockeyStats
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
        Me.components = New System.ComponentModel.Container()
        Me.lstSeasons = New System.Windows.Forms.ListBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.grpPlayer = New System.Windows.Forms.GroupBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblSeasons = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblTypeInformation = New System.Windows.Forms.Label()
        Me.grpStatistics = New System.Windows.Forms.GroupBox()
        Me.btnGetStats = New System.Windows.Forms.Button()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpOperations = New System.Windows.Forms.GroupBox()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGetStats = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpPlayer.SuspendLayout()
        Me.grpStatistics.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.grpOperations.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSeasons
        '
        Me.lstSeasons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstSeasons.FormattingEnabled = True
        Me.lstSeasons.Location = New System.Drawing.Point(6, 28)
        Me.lstSeasons.Name = "lstSeasons"
        Me.lstSeasons.Size = New System.Drawing.Size(435, 147)
        Me.lstSeasons.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstSeasons, "Season by season goals, assists, and total points.")
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(12, 33)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(287, 13)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Pablo Munoz, Programming w/LAB VB.Net, Week 7, Lab A"
        '
        'grpPlayer
        '
        Me.grpPlayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpPlayer.Controls.Add(Me.lblAge)
        Me.grpPlayer.Controls.Add(Me.lblSeasons)
        Me.grpPlayer.Controls.Add(Me.lblLastName)
        Me.grpPlayer.Controls.Add(Me.lblFirstName)
        Me.grpPlayer.Controls.Add(Me.lblTypeInformation)
        Me.grpPlayer.Location = New System.Drawing.Point(14, 59)
        Me.grpPlayer.Name = "grpPlayer"
        Me.grpPlayer.Size = New System.Drawing.Size(200, 143)
        Me.grpPlayer.TabIndex = 3
        Me.grpPlayer.TabStop = False
        Me.grpPlayer.Text = "Player Information"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(8, 96)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(66, 13)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Text = "Rookie Age:"
        '
        'lblSeasons
        '
        Me.lblSeasons.AutoSize = True
        Me.lblSeasons.Location = New System.Drawing.Point(7, 78)
        Me.lblSeasons.Name = "lblSeasons"
        Me.lblSeasons.Size = New System.Drawing.Size(103, 13)
        Me.lblSeasons.TabIndex = 3
        Me.lblSeasons.Text = "Number of Seasons:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(7, 61)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(7, 44)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "FirstName:"
        '
        'lblTypeInformation
        '
        Me.lblTypeInformation.AutoSize = True
        Me.lblTypeInformation.Location = New System.Drawing.Point(6, 20)
        Me.lblTypeInformation.Name = "lblTypeInformation"
        Me.lblTypeInformation.Size = New System.Drawing.Size(127, 13)
        Me.lblTypeInformation.TabIndex = 0
        Me.lblTypeInformation.Text = "Please type the following:"
        '
        'grpStatistics
        '
        Me.grpStatistics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpStatistics.Controls.Add(Me.btnGetStats)
        Me.grpStatistics.Location = New System.Drawing.Point(220, 59)
        Me.grpStatistics.Name = "grpStatistics"
        Me.grpStatistics.Size = New System.Drawing.Size(172, 62)
        Me.grpStatistics.TabIndex = 4
        Me.grpStatistics.TabStop = False
        Me.grpStatistics.Text = "Statistic Operations"
        '
        'btnGetStats
        '
        Me.btnGetStats.Location = New System.Drawing.Point(6, 19)
        Me.btnGetStats.Name = "btnGetStats"
        Me.btnGetStats.Size = New System.Drawing.Size(75, 36)
        Me.btnGetStats.TabIndex = 0
        Me.btnGetStats.Text = "Get Player Statistics"
        Me.ToolTip1.SetToolTip(Me.btnGetStats, "Click to enter player statistics.")
        Me.btnGetStats.UseVisualStyleBackColor = True
        '
        'grpResults
        '
        Me.grpResults.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpResults.Controls.Add(Me.lblTotal)
        Me.grpResults.Controls.Add(Me.lstSeasons)
        Me.grpResults.Location = New System.Drawing.Point(14, 208)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(447, 223)
        Me.grpResults.TabIndex = 5
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Season Results"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(7, 192)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 1
        '
        'grpOperations
        '
        Me.grpOperations.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpOperations.Controls.Add(Me.btnSummary)
        Me.grpOperations.Controls.Add(Me.btnExit)
        Me.grpOperations.Controls.Add(Me.btnClear)
        Me.grpOperations.Location = New System.Drawing.Point(220, 127)
        Me.grpOperations.Name = "grpOperations"
        Me.grpOperations.Size = New System.Drawing.Size(172, 75)
        Me.grpOperations.TabIndex = 6
        Me.grpOperations.TabStop = False
        Me.grpOperations.Text = "Operations"
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(7, 17)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(75, 52)
        Me.btnSummary.TabIndex = 2
        Me.btnSummary.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.btnSummary, "Click to display Summary.")
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(89, 46)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to exit the Hockey Player statistics program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(89, 17)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click to clear all input and output data.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(471, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "Exit"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGetStats, Me.mnuSummary})
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ToolToolStripMenuItem.Text = "Tool"
        '
        'mnuGetStats
        '
        Me.mnuGetStats.Name = "mnuGetStats"
        Me.mnuGetStats.Size = New System.Drawing.Size(176, 22)
        Me.mnuGetStats.Text = "Get Player Statistics"
        '
        'mnuSummary
        '
        Me.mnuSummary.Name = "mnuSummary"
        Me.mnuSummary.Size = New System.Drawing.Size(176, 22)
        Me.mnuSummary.Text = "Summary Data"
        '
        'frmHockeyStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 445)
        Me.Controls.Add(Me.grpOperations)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpStatistics)
        Me.Controls.Add(Me.grpPlayer)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHockeyStats"
        Me.Text = "Hockey Player Statistics"
        Me.grpPlayer.ResumeLayout(False)
        Me.grpPlayer.PerformLayout()
        Me.grpStatistics.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.grpOperations.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSeasons As System.Windows.Forms.ListBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents grpPlayer As System.Windows.Forms.GroupBox
    Friend WithEvents grpStatistics As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetStats As System.Windows.Forms.Button
    Friend WithEvents grpResults As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents grpOperations As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblSeasons As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblTypeInformation As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGetStats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSummary As System.Windows.Forms.Button

End Class
