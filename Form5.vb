Public Class Form5

    Private Sub pros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pros.Click
        Dim i, j As Integer
        j = ak.Text

        If bilgen.Checked = True Then
            For i = aw.Text To j
                If i Mod 2 = 0 Then
                    ListBox1.Items.Add(i)
                End If
            Next
        ElseIf bilgan.Checked = True Then
            For i = aw.Text To j
                If i Mod 2 = 1 Then
                    ListBox1.Items.Add(i)
                End If
            Next
        End If
    End Sub
End Class