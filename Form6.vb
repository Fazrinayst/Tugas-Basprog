Public Class Form6

    Private Sub hit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hit.Click
        Dim a, i, b, c, n, hasil As Integer
        a = 1
        For i = 1 To nn.Text
            a = a * i
        Next i
        fakto.Text = a
        a = 0
        b = 1
        n = nn.Text
        ListBox1.Items.Add(a)
        ListBox1.Items.Add(b)
        For i = 3 To n
            c = Val(a) + Val(b)
            ListBox1.Items.Add(c)
            a = b
            b = c
        Next i
        hasil = n * n

        kuad.Text = hasil
    End Sub
End Class