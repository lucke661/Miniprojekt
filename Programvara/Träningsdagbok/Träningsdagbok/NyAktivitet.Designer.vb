<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NyAktivitet
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
        Me.txtAktivitet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.chbMataTid = New System.Windows.Forms.CheckBox()
        Me.chbMataDistans = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtAktivitet
        '
        Me.txtAktivitet.Location = New System.Drawing.Point(120, 38)
        Me.txtAktivitet.Name = "txtAktivitet"
        Me.txtAktivitet.Size = New System.Drawing.Size(100, 23)
        Me.txtAktivitet.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aktivitet:"
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(39, 141)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(75, 23)
        Me.btnSpara.TabIndex = 2
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(157, 141)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(75, 23)
        Me.btnAvbryt.TabIndex = 3
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'chbMataTid
        '
        Me.chbMataTid.AutoSize = True
        Me.chbMataTid.Location = New System.Drawing.Point(120, 76)
        Me.chbMataTid.Name = "chbMataTid"
        Me.chbMataTid.Size = New System.Drawing.Size(77, 19)
        Me.chbMataTid.TabIndex = 4
        Me.chbMataTid.Text = "Mäta Tid?"
        Me.chbMataTid.UseVisualStyleBackColor = True
        '
        'chbMataDistans
        '
        Me.chbMataDistans.AutoSize = True
        Me.chbMataDistans.Location = New System.Drawing.Point(120, 101)
        Me.chbMataDistans.Name = "chbMataDistans"
        Me.chbMataDistans.Size = New System.Drawing.Size(99, 19)
        Me.chbMataDistans.TabIndex = 5
        Me.chbMataDistans.Text = "Mäta Distans?"
        Me.chbMataDistans.UseVisualStyleBackColor = True
        '
        'NyAktivitet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 195)
        Me.Controls.Add(Me.chbMataDistans)
        Me.Controls.Add(Me.chbMataTid)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAktivitet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NyAktivitet"
        Me.Text = "NyAktivitet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAktivitet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAvbryt As Button
    Friend WithEvents chbMataTid As CheckBox
    Friend WithEvents chbMataDistans As CheckBox
End Class
