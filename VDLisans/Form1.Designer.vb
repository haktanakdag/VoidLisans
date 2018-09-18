<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtSeriNo = New System.Windows.Forms.TextBox()
        Me.txtLisansNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnYapistir = New System.Windows.Forms.Button()
        Me.btnKopyala = New System.Windows.Forms.Button()
        Me.btnLisansOlustur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSeriNo
        '
        Me.txtSeriNo.Location = New System.Drawing.Point(94, 21)
        Me.txtSeriNo.Name = "txtSeriNo"
        Me.txtSeriNo.Size = New System.Drawing.Size(1036, 22)
        Me.txtSeriNo.TabIndex = 7
        '
        'txtLisansNo
        '
        Me.txtLisansNo.Location = New System.Drawing.Point(97, 61)
        Me.txtLisansNo.Name = "txtLisansNo"
        Me.txtLisansNo.Size = New System.Drawing.Size(1033, 22)
        Me.txtLisansNo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lisans No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seri No:"
        '
        'btnYapistir
        '
        Me.btnYapistir.Location = New System.Drawing.Point(1136, 12)
        Me.btnYapistir.Name = "btnYapistir"
        Me.btnYapistir.Size = New System.Drawing.Size(122, 38)
        Me.btnYapistir.TabIndex = 9
        Me.btnYapistir.Text = "Yapıştır"
        Me.btnYapistir.UseVisualStyleBackColor = True
        '
        'btnKopyala
        '
        Me.btnKopyala.Location = New System.Drawing.Point(1136, 56)
        Me.btnKopyala.Name = "btnKopyala"
        Me.btnKopyala.Size = New System.Drawing.Size(122, 38)
        Me.btnKopyala.TabIndex = 8
        Me.btnKopyala.Text = "Kopyala"
        Me.btnKopyala.UseVisualStyleBackColor = True
        '
        'btnLisansOlustur
        '
        Me.btnLisansOlustur.Location = New System.Drawing.Point(1136, 100)
        Me.btnLisansOlustur.Name = "btnLisansOlustur"
        Me.btnLisansOlustur.Size = New System.Drawing.Size(122, 53)
        Me.btnLisansOlustur.TabIndex = 10
        Me.btnLisansOlustur.Text = "Lisans Oluştur"
        Me.btnLisansOlustur.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 172)
        Me.Controls.Add(Me.btnLisansOlustur)
        Me.Controls.Add(Me.btnYapistir)
        Me.Controls.Add(Me.btnKopyala)
        Me.Controls.Add(Me.txtSeriNo)
        Me.Controls.Add(Me.txtLisansNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "VOID Lisans"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSeriNo As TextBox
    Friend WithEvents txtLisansNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnYapistir As Button
    Friend WithEvents btnKopyala As Button
    Friend WithEvents btnLisansOlustur As Button
End Class
