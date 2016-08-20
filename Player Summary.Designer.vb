<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player_Summary
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
        Me.dvgStatistics = New System.Windows.Forms.DataGridView()
        Me.btnGetStats = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpOpertions = New System.Windows.Forms.GroupBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        CType(Me.dvgStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpertions.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgStatistics
        '
        Me.dvgStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgStatistics.Location = New System.Drawing.Point(12, 39)
        Me.dvgStatistics.Name = "dvgStatistics"
        Me.dvgStatistics.RowHeadersVisible = False
        Me.dvgStatistics.Size = New System.Drawing.Size(578, 209)
        Me.dvgStatistics.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dvgStatistics, "All players career goals, assists, and points.")
        '
        'btnGetStats
        '
        Me.btnGetStats.Location = New System.Drawing.Point(6, 19)
        Me.btnGetStats.Name = "btnGetStats"
        Me.btnGetStats.Size = New System.Drawing.Size(75, 39)
        Me.btnGetStats.TabIndex = 1
        Me.btnGetStats.Text = "Season Summary"
        Me.ToolTip1.SetToolTip(Me.btnGetStats, "Click to retrieve and display summary data.")
        Me.btnGetStats.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(87, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 39)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear Summary"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click to clear summary data file.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(168, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Close Summary"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to close the summary form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpOpertions
        '
        Me.grpOpertions.Controls.Add(Me.btnExit)
        Me.grpOpertions.Controls.Add(Me.btnGetStats)
        Me.grpOpertions.Controls.Add(Me.btnClear)
        Me.grpOpertions.Location = New System.Drawing.Point(12, 254)
        Me.grpOpertions.Name = "grpOpertions"
        Me.grpOpertions.Size = New System.Drawing.Size(249, 64)
        Me.grpOpertions.TabIndex = 4
        Me.grpOpertions.TabStop = False
        Me.grpOpertions.Text = "Operations"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(12, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(129, 13)
        Me.lblHeading.TabIndex = 5
        Me.lblHeading.Text = "Player’s Season Summary"
        '
        'Player_Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 323)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.grpOpertions)
        Me.Controls.Add(Me.dvgStatistics)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Player_Summary"
        Me.Text = "Player_Summary"
        CType(Me.dvgStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpertions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dvgStatistics As System.Windows.Forms.DataGridView
    Friend WithEvents btnGetStats As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpOpertions As System.Windows.Forms.GroupBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
End Class
