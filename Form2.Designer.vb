<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.ComboBox()
        Me.bulan = New System.Windows.Forms.ComboBox()
        Me.cari = New System.Windows.Forms.Button()
        Me.bersih = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(160, 61)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(100, 20)
        Me.nama.TabIndex = 0
        '
        'tanggal
        '
        Me.tanggal.FormattingEnabled = True
        Me.tanggal.Location = New System.Drawing.Point(160, 103)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(121, 21)
        Me.tanggal.TabIndex = 1
        '
        'bulan
        '
        Me.bulan.FormattingEnabled = True
        Me.bulan.Location = New System.Drawing.Point(160, 150)
        Me.bulan.Name = "bulan"
        Me.bulan.Size = New System.Drawing.Size(121, 21)
        Me.bulan.TabIndex = 2
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(88, 204)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(75, 23)
        Me.cari.TabIndex = 3
        Me.cari.Text = "Cari"
        Me.cari.UseVisualStyleBackColor = True
        '
        'bersih
        '
        Me.bersih.Location = New System.Drawing.Point(270, 204)
        Me.bersih.Name = "bersih"
        Me.bersih.Size = New System.Drawing.Size(75, 23)
        Me.bersih.TabIndex = 4
        Me.bersih.Text = "Bersih"
        Me.bersih.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(74, 233)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(290, 65)
        Me.TextBox2.TabIndex = 5
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(196, 304)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 6
        Me.ok.Text = "Ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Bulan Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ZODIAK"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 376)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.bersih)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.bulan)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.nama)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.ComboBox
    Friend WithEvents bulan As System.Windows.Forms.ComboBox
    Friend WithEvents cari As System.Windows.Forms.Button
    Friend WithEvents bersih As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
