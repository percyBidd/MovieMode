Public Class uScreen
    Public deviceName As String = ""
    Public location As Point = New Point(0, 0)
    Dim fmLeft As Form = New FrmBlocker

    Private Sub uScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        lName.Text = deviceName
        lLocation.Text = location.ToString
        fmLeft.Location = location
        TrackBar1.Value = Form1.masterOpasity * 100
        Application.DoEvents()
    End Sub

    Private Sub uScreen_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            If fmLeft.Visible = False Then
                fmLeft.Show()
                'fmLeft.Opacity = Form1.masterOpasity

                'fmLeft.BackColor = Color.DarkGray
            Else
                fmLeft.Hide()
            End If
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Try
            fmLeft.Opacity = TrackBar1.Value / 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lName_Click(sender As Object, e As EventArgs) Handles lName.Click
        uScreen_MouseDown(sender, e)
    End Sub

    Private Sub lLocation_Click(sender As Object, e As EventArgs) Handles lLocation.Click
        uScreen_MouseDown(sender, e)
    End Sub
End Class
