<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lName = New System.Windows.Forms.Label()
        Me.lLocation = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lName
        '
        Me.lName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lName.AutoSize = True
        Me.lName.Location = New System.Drawing.Point(50, 15)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(41, 15)
        Me.lName.TabIndex = 0
        Me.lName.Text = "Label1"
        '
        'lLocation
        '
        Me.lLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lLocation.AutoSize = True
        Me.lLocation.Location = New System.Drawing.Point(50, 30)
        Me.lLocation.Name = "lLocation"
        Me.lLocation.Size = New System.Drawing.Size(56, 15)
        Me.lLocation.TabIndex = 1
        Me.lLocation.Text = "lLocation"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(34, 80)
        Me.TrackBar1.Maximum = 98
        Me.TrackBar1.Minimum = 10
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 2
        Me.TrackBar1.Value = 50
        '
        'uScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lLocation)
        Me.Controls.Add(Me.lName)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "uScreen"
        Me.Size = New System.Drawing.Size(171, 113)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lName As Label
    Friend WithEvents lLocation As Label
    Friend WithEvents TrackBar1 As TrackBar
End Class
