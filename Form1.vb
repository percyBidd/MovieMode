Public Class Form1
    Dim fmLeft As Form = New Form
    Dim fmCenter As Form = New Form
    Dim fmRight As Form = New Form
    Dim screenList As ArrayList = New ArrayList()
    Public masterOpasity As Decimal = 0.5

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            Dim i As Int32 = 0
            For Each scrn In Screen.AllScreens

                If screenList.Count = 0 Then
                    screenList.Insert(i, scrn)
                    i += 1
                    Continue For
                End If
                If screenList.Item(i - 1).Bounds.Location.X > scrn.Bounds.Location.X Then
                    screenList.Insert(i - 1, scrn)
                Else
                    screenList.Insert(i, scrn)

                End If
                i += 1
                'If scrn.Bounds.Contains(Location) Then

                '    Exit For
                'End If
            Next
            For Each scr In screenList

                Dim MyUsrCont As uScreen = New uScreen
                MyUsrCont.deviceName = scr.DeviceName
                MyUsrCont.location = scr.Bounds.Location
                flpScreens.Controls.Add(MyUsrCont)
            Next


            fmLeft.Width = 1920
            fmLeft.Height = 1080

        Catch ex As Exception

        End Try
    End Sub

End Class
