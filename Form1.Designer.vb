<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.flpScreens = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flpScreens
        '
        Me.flpScreens.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpScreens.AutoScroll = True
        Me.flpScreens.Location = New System.Drawing.Point(22, 12)
        Me.flpScreens.Name = "flpScreens"
        Me.flpScreens.Size = New System.Drawing.Size(565, 136)
        Me.flpScreens.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(599, 160)
        Me.Controls.Add(Me.flpScreens)
        Me.Name = "Form1"
        Me.Text = "Movie Dimmer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flpScreens As FlowLayoutPanel
End Class
