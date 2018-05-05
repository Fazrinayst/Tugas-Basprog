<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sa = New System.Windows.Forms.TextBox()
        Me.bunga = New System.Windows.Forms.TextBox()
        Me.waktu = New System.Windows.Forms.TextBox()
        Me.ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ok)
        Me.GroupBox1.Controls.Add(Me.waktu)
        Me.GroupBox1.Controls.Add(Me.bunga)
        Me.GroupBox1.Controls.Add(Me.sa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Input"
        '
        'sa
        '
        Me.sa.Location = New System.Drawing.Point(126, 38)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(182, 29)
        Me.sa.TabIndex = 0
        '
        'bunga
        '
        Me.bunga.Location = New System.Drawing.Point(126, 82)
        Me.bunga.Name = "bunga"
        Me.bunga.Size = New System.Drawing.Size(131, 29)
        Me.bunga.TabIndex = 1
        '
        'waktu
        '
        Me.waktu.Location = New System.Drawing.Point(126, 127)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(131, 29)
        Me.waktu.TabIndex = 2
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(242, 189)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(79, 34)
        Me.ok.TabIndex = 3
        Me.ok.Text = "Oke"
        Me.ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Saldo Awal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bunga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Waktu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "% /bln"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Bulan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 31)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Perhitungan Bunga"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(353, 83)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(333, 264)
        Me.ListBox1.TabIndex = 3
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 449)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents waktu As System.Windows.Forms.TextBox
    Friend WithEvents bunga As System.Windows.Forms.TextBox
    Friend WithEvents sa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
