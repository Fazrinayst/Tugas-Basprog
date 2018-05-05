Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 31
            tanggal.Items.Add(i)
        Next
        For i = 1 To 12
            bulan.Items.Add(MonthName(i))
        Next
    End Sub

    Dim zodiak As String
    Private Sub cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.Click
        If tanggal.SelectedIndex < 20 And bulan.SelectedIndex = 0 Or
            tanggal.SelectedIndex > 21 And bulan.SelectedIndex = 11 Then
            zodiak = "Capricorn"
        ElseIf tanggal.SelectedIndex < 18 And bulan.SelectedIndex = 1 Or
            tanggal.SelectedIndex > 19 And bulan.SelectedIndex = 0 Then
            zodiak = "Aquarius"
        ElseIf tanggal.SelectedIndex < 20 And bulan.SelectedIndex = 2 Or
            tanggal.SelectedIndex > 17 And bulan.SelectedIndex = 1 Then
            zodiak = "Pisces"
        ElseIf tanggal.SelectedIndex < 20 And bulan.SelectedIndex = 3 Or
            tanggal.SelectedIndex > 19 And bulan.SelectedIndex = 2 Then
            zodiak = "Aries"
        ElseIf tanggal.SelectedIndex < 20 And bulan.SelectedIndex = 4 Or
            tanggal.SelectedIndex > 19 And bulan.SelectedIndex = 3 Then
            zodiak = "Taurus"
        ElseIf tanggal.SelectedIndex < 21 And bulan.SelectedIndex = 5 Or
            tanggal.SelectedIndex > 19 And bulan.SelectedIndex = 4 Then
            zodiak = "Gemini"
        ElseIf tanggal.SelectedIndex < 22 And bulan.SelectedIndex = 6 Or
       tanggal.SelectedIndex > 20 And bulan.SelectedIndex = 5 Then
            zodiak = "Cancer"
        End If

        TextBox2.Text = nama.Text & ", Anda lahir pada " & tanggal.Text & " " &
            bulan.Text & " zodiak anda adalah " & zodiak
    End Sub

    Private Sub bersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bersih.Click
        nama.ResetText()
        tanggal.ResetText()
        bulan.ResetText()
        TextBox2.ResetText()
    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Close()

    End Sub

    Private Sub tanggal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tanggal.SelectedIndexChanged

    End Sub
End Class