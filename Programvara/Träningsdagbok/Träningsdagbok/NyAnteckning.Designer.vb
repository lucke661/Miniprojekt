<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NyAnteckning
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboAktivitet = New System.Windows.Forms.ComboBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.txtTid = New System.Windows.Forms.TextBox()
        Me.txtDistans = New System.Windows.Forms.TextBox()
        Me.txtGrad = New System.Windows.Forms.TextBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aktivitet:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Info:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tid:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Distans:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ansträngningsgrad:"
        '
        'cboAktivitet
        '
        Me.cboAktivitet.FormattingEnabled = True
        Me.cboAktivitet.Location = New System.Drawing.Point(122, 52)
        Me.cboAktivitet.Name = "cboAktivitet"
        Me.cboAktivitet.Size = New System.Drawing.Size(164, 23)
        Me.cboAktivitet.TabIndex = 5
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(122, 82)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(164, 23)
        Me.txtInfo.TabIndex = 6
        '
        'txtTid
        '
        Me.txtTid.Location = New System.Drawing.Point(122, 153)
        Me.txtTid.Name = "txtTid"
        Me.txtTid.Size = New System.Drawing.Size(125, 23)
        Me.txtTid.TabIndex = 8
        '
        'txtDistans
        '
        Me.txtDistans.Location = New System.Drawing.Point(122, 184)
        Me.txtDistans.Name = "txtDistans"
        Me.txtDistans.Size = New System.Drawing.Size(125, 23)
        Me.txtDistans.TabIndex = 10
        '
        'txtGrad
        '
        Me.txtGrad.Location = New System.Drawing.Point(147, 215)
        Me.txtGrad.Name = "txtGrad"
        Me.txtGrad.Size = New System.Drawing.Size(100, 23)
        Me.txtGrad.TabIndex = 12
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(53, 273)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(88, 38)
        Me.btnSpara.TabIndex = 13
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(186, 273)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(86, 38)
        Me.btnAvbryt.TabIndex = 14
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'NyAnteckning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 333)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.txtGrad)
        Me.Controls.Add(Me.txtDistans)
        Me.Controls.Add(Me.txtTid)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.cboAktivitet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NyAnteckning"
        Me.Text = "NyAnteckning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboAktivitet As ComboBox
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents txtTid As TextBox
    Friend WithEvents txtDistans As TextBox
    Friend WithEvents txtGrad As TextBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAvbryt As Button
End Class
