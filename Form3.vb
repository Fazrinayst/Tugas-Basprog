Public Class Form3

    Private Sub nested_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nested.Click
        Dim i, j, tinggi As Integer
        Dim output As String
        output = ""
        tinggi = t.Text

        For i = 0 To tinggi - 1
            For j = 0 To i
                output = output & " " & "*"
            Next
            output = output & vbCrLf
        Next
        MsgBox(output)
    End Sub

    Private Sub exitfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitfor.Click
        Dim i As Integer
        Dim output As String
        output = ""
        For i = 0 To 10
            If i = 3 Then
                Exit For
            End If
            output = output & " " & i
        Next
        MsgBox(output)
    End Sub
End Class