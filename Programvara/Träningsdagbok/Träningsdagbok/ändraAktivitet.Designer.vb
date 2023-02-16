<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ändraAktivitet
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
        Me.chbMataDistans = New System.Windows.Forms.CheckBox()
        Me.chbMataTid = New System.Windows.Forms.CheckBox()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRadera = New System.Windows.Forms.Button()
        Me.cboAktivitet = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'chbMataDistans
        '
        Me.chbMataDistans.AutoSize = True
        Me.chbMataDistans.Location = New System.Drawing.Point(91, 82)
        Me.chbMataDistans.Name = "chbMataDistans"
        Me.chbMataDistans.Size = New System.Drawing.Size(99, 19)
        Me.chbMataDistans.TabIndex = 11
        Me.chbMataDistans.Text = "Mäta Distans?"
        Me.chbMataDistans.UseVisualStyleBackColor = True
        '
        'chbMataTid
        '
        Me.chbMataTid.AutoSize = True
        Me.chbMataTid.Location = New System.Drawing.Point(91, 57)
        Me.chbMataTid.Name = "chbMataTid"
        Me.chbMataTid.Size = New System.Drawing.Size(77, 19)
        Me.chbMataTid.TabIndex = 10
        Me.chbMataTid.Text = "Mäta Tid?"
        Me.chbMataTid.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(91, 122)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(75, 23)
        Me.btnAvbryt.TabIndex = 9
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(10, 122)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(75, 23)
        Me.btnSpara.TabIndex = 8
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Aktivitet:"
        '
        'btnRadera
        '
        Me.btnRadera.Location = New System.Drawing.Point(172, 122)
        Me.btnRadera.Name = "btnRadera"
        Me.btnRadera.Size = New System.Drawing.Size(75, 23)
        Me.btnRadera.TabIndex = 12
        Me.btnRadera.Text = "Radera"
        Me.btnRadera.UseVisualStyleBackColor = True
        '
        'cboAktivitet
        '
        Me.cboAktivitet.FormattingEnabled = True
        Me.cboAktivitet.Location = New System.Drawing.Point(91, 19)
        Me.cboAktivitet.Name = "cboAktivitet"
        Me.cboAktivitet.Size = New System.Drawing.Size(121, 23)
        Me.cboAktivitet.TabIndex = 13
        '
        'ändraAktivitet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 166)
        Me.Controls.Add(Me.cboAktivitet)
        Me.Controls.Add(Me.btnRadera)
        Me.Controls.Add(Me.chbMataDistans)
        Me.Controls.Add(Me.chbMataTid)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ändraAktivitet"
        Me.Text = "ändraAktivitet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chbMataDistans As CheckBox
    Friend WithEvents chbMataTid As CheckBox
    Friend WithEvents btnAvbryt As Button
    Friend WithEvents btnSpara As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRadera As Button
    Friend WithEvents cboAktivitet As ComboBox
End Class
