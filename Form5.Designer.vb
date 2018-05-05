<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bilgan = New System.Windows.Forms.RadioButton()
        Me.bilgen = New System.Windows.Forms.RadioButton()
        Me.aw = New System.Windows.Forms.TextBox()
        Me.ak = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.pros = New System.Windows.Forms.Button()
        Me.hap = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Awal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Akhir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bilgen)
        Me.GroupBox1.Controls.Add(Me.bilgan)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Bilangan :"
        '
        'bilgan
        '
        Me.bilgan.AutoSize = True
        Me.bilgan.Location = New System.Drawing.Point(7, 20)
        Me.bilgan.Name = "bilgan"
        Me.bilgan.Size = New System.Drawing.Size(71, 17)
        Me.bilgan.TabIndex = 0
        Me.bilgan.TabStop = True
        Me.bilgan.Text = "Bil Genap"
        Me.bilgan.UseVisualStyleBackColor = True
        '
        'bilgen
        '
        Me.bilgen.AutoSize = True
        Me.bilgen.Location = New System.Drawing.Point(7, 44)
        Me.bilgen.Name = "bilgen"
        Me.bilgen.Size = New System.Drawing.Size(65, 17)
        Me.bilgen.TabIndex = 1
        Me.bilgen.TabStop = True
        Me.bilgen.Text = "Bil Ganjil"
        Me.bilgen.UseVisualStyleBackColor = True
        '
        'aw
        '
        Me.aw.Location = New System.Drawing.Point(50, 40)
        Me.aw.Name = "aw"
        Me.aw.Size = New System.Drawing.Size(100, 20)
        Me.aw.TabIndex = 3
        '
        'ak
        '
        Me.ak.Location = New System.Drawing.Point(50, 76)
        Me.ak.Name = "ak"
        Me.ak.Size = New System.Drawing.Size(100, 20)
        Me.ak.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(187, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 134)
        Me.ListBox1.TabIndex = 5
        '
        'pros
        '
        Me.pros.Location = New System.Drawing.Point(50, 209)
        Me.pros.Name = "pros"
        Me.pros.Size = New System.Drawing.Size(75, 23)
        Me.pros.TabIndex = 6
        Me.pros.Text = "proses"
        Me.pros.UseVisualStyleBackColor = True
        '
        'hap
        '
        Me.hap.Location = New System.Drawing.Point(132, 208)
        Me.hap.Name = "hap"
        Me.hap.Size = New System.Drawing.Size(75, 23)
        Me.hap.TabIndex = 7
        Me.hap.Text = "Hapus"
        Me.hap.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 380)
        Me.Controls.Add(Me.hap)
        Me.Controls.Add(Me.pros)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ak)
        Me.Controls.Add(Me.aw)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bilgan As System.Windows.Forms.RadioButton
    Friend WithEvents bilgen As System.Windows.Forms.RadioButton
    Friend WithEvents aw As System.Windows.Forms.TextBox
    Friend WithEvents ak As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents pros As System.Windows.Forms.Button
    Friend WithEvents hap As System.Windows.Forms.Button
End Class
