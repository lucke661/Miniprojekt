<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyLat
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.cboMediatyp = New System.Windows.Forms.ComboBox()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.txtLatnamn = New System.Windows.Forms.TextBox()
        Me.txtKompositor = New System.Windows.Forms.TextBox()
        Me.txtPris = New System.Windows.Forms.TextBox()
        Me.txtStorlek = New System.Windows.Forms.TextBox()
        Me.txtLangd = New System.Windows.Forms.TextBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Albumid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Låtnamn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mediatyp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Genre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kompositör"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Längd (ms)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Storlek (bytes)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Pris"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(208, 39)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(56, 15)
        Me.lblAlbum.TabIndex = 8
        Me.lblAlbum.Text = "lblAlbum"
        '
        'cboMediatyp
        '
        Me.cboMediatyp.FormattingEnabled = True
        Me.cboMediatyp.Location = New System.Drawing.Point(208, 103)
        Me.cboMediatyp.Name = "cboMediatyp"
        Me.cboMediatyp.Size = New System.Drawing.Size(185, 23)
        Me.cboMediatyp.TabIndex = 9
        '
        'cboGenre
        '
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(208, 141)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(185, 23)
        Me.cboGenre.TabIndex = 10
        '
        'txtLatnamn
        '
        Me.txtLatnamn.Location = New System.Drawing.Point(208, 69)
        Me.txtLatnamn.Name = "txtLatnamn"
        Me.txtLatnamn.Size = New System.Drawing.Size(157, 23)
        Me.txtLatnamn.TabIndex = 11
        '
        'txtKompositor
        '
        Me.txtKompositor.Location = New System.Drawing.Point(208, 181)
        Me.txtKompositor.Name = "txtKompositor"
        Me.txtKompositor.Size = New System.Drawing.Size(157, 23)
        Me.txtKompositor.TabIndex = 12
        '
        'txtPris
        '
        Me.txtPris.Location = New System.Drawing.Point(208, 289)
        Me.txtPris.Name = "txtPris"
        Me.txtPris.Size = New System.Drawing.Size(157, 23)
        Me.txtPris.TabIndex = 13
        '
        'txtStorlek
        '
        Me.txtStorlek.Location = New System.Drawing.Point(208, 254)
        Me.txtStorlek.Name = "txtStorlek"
        Me.txtStorlek.Size = New System.Drawing.Size(157, 23)
        Me.txtStorlek.TabIndex = 14
        '
        'txtLangd
        '
        Me.txtLangd.Location = New System.Drawing.Point(208, 219)
        Me.txtLangd.Name = "txtLangd"
        Me.txtLangd.Size = New System.Drawing.Size(157, 23)
        Me.txtLangd.TabIndex = 15
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(100, 361)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(75, 37)
        Me.btnSpara.TabIndex = 16
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(208, 361)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(75, 37)
        Me.btnAvbryt.TabIndex = 17
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'frmNyLat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 417)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.txtLangd)
        Me.Controls.Add(Me.txtStorlek)
        Me.Controls.Add(Me.txtPris)
        Me.Controls.Add(Me.txtKompositor)
        Me.Controls.Add(Me.txtLatnamn)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.cboMediatyp)
        Me.Controls.Add(Me.lblAlbum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNyLat"
        Me.Text = "frmNyLat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents cboMediatyp As ComboBox
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents txtLatnamn As TextBox
    Friend WithEvents txtKompositor As TextBox
    Friend WithEvents txtPris As TextBox
    Friend WithEvents txtStorlek As TextBox
    Friend WithEvents txtLangd As TextBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAvbryt As Button
End Class
