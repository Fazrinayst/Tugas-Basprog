<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.t = New System.Windows.Forms.TextBox()
        Me.nested = New System.Windows.Forms.Button()
        Me.exitfor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tinggi"
        '
        't
        '
        Me.t.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.Location = New System.Drawing.Point(95, 44)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(163, 29)
        Me.t.TabIndex = 1
        '
        'nested
        '
        Me.nested.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nested.Location = New System.Drawing.Point(34, 104)
        Me.nested.Name = "nested"
        Me.nested.Size = New System.Drawing.Size(94, 32)
        Me.nested.TabIndex = 2
        Me.nested.Text = "Nested"
        Me.nested.UseVisualStyleBackColor = True
        '
        'exitfor
        '
        Me.exitfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitfor.Location = New System.Drawing.Point(176, 104)
        Me.exitfor.Name = "exitfor"
        Me.exitfor.Size = New System.Drawing.Size(93, 32)
        Me.exitfor.TabIndex = 3
        Me.exitfor.Text = "Exit For"
        Me.exitfor.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 355)
        Me.Controls.Add(Me.exitfor)
        Me.Controls.Add(Me.nested)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t As System.Windows.Forms.TextBox
    Friend WithEvents nested As System.Windows.Forms.Button
    Friend WithEvents exitfor As System.Windows.Forms.Button
End Class
