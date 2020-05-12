Public Class Form1
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim N As Long, G As Integer, p As Single
        N = 7000000
        G = 2000
        p = 7
        Do While N < 10000000
            N = N + N / 100 * p
            G = G + 1
        Loop
        MsgBox(CStr(G) + "год")
    End Sub
End Class
