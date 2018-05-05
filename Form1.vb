Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim i As Byte
        For i = 1 To 5
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
        Dim a As Byte
        Do While a < 5
            a = a + 1
            ComboBox1.Items.Add(a)
        Loop
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Text = "1" Then
            TextBox1.Text = "Satu"
        ElseIf ListBox1.Text = "2" Then
            TextBox1.Text = "Dua"
        ElseIf ListBox1.Text = "3" Then
            TextBox1.Text = "Tiga"
        ElseIf ListBox1.Text = "4" Then
            TextBox1.Text = "Empat"
        ElseIf ListBox1.Text = "5" Then
            TextBox1.Text = "Lima"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case 1
                TextBox2.Text = 1000
            Case 2
                TextBox2.Text = 2000
            Case 3
                TextBox2.Text = 3000
            Case 4
                TextBox2.Text = 4000
            Case 5
                TextBox2.Text = 5000
        End Select
    End Sub
End Class
