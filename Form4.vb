Public Class Form4

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Dim a, b, c, d, ee, i As Integer
        a = sa.Text
        b = bunga.Text
        c = waktu.Text

        For i = 0 To c - 1
            d = (a * b / 100)
            ee = (a + d)
            ListBox1.Items.Add(ee)
            a = ee
        Next
    End Sub
End Class