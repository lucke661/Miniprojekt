<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnNyAktivitet = New System.Windows.Forms.Button()
        Me.lblNodTag = New System.Windows.Forms.Label()
        Me.btnRedigeraDagbok = New System.Windows.Forms.Button()
        Me.lsvAnteckning = New System.Windows.Forms.ListView()
        Me.grdDetalj = New System.Windows.Forms.DataGridView()
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNyAktivitet
        '
        Me.btnNyAktivitet.Location = New System.Drawing.Point(250, 377)
        Me.btnNyAktivitet.Name = "btnNyAktivitet"
        Me.btnNyAktivitet.Size = New System.Drawing.Size(92, 33)
        Me.btnNyAktivitet.TabIndex = 2
        Me.btnNyAktivitet.Text = "Ny Aktivitet"
        Me.btnNyAktivitet.UseVisualStyleBackColor = True
        '
        'lblNodTag
        '
        Me.lblNodTag.AutoSize = True
        Me.lblNodTag.Location = New System.Drawing.Point(693, 386)
        Me.lblNodTag.Name = "lblNodTag"
        Me.lblNodTag.Size = New System.Drawing.Size(61, 15)
        Me.lblNodTag.TabIndex = 3
        Me.lblNodTag.Text = "lblNodTag"
        '
        'btnRedigeraDagbok
        '
        Me.btnRedigeraDagbok.Location = New System.Drawing.Point(373, 377)
        Me.btnRedigeraDagbok.Name = "btnRedigeraDagbok"
        Me.btnRedigeraDagbok.Size = New System.Drawing.Size(114, 33)
        Me.btnRedigeraDagbok.TabIndex = 4
        Me.btnRedigeraDagbok.Text = "Ändra Anteckning"
        Me.btnRedigeraDagbok.UseVisualStyleBackColor = True
        '
        'lsvAnteckning
        '
        Me.lsvAnteckning.Location = New System.Drawing.Point(-2, -1)
        Me.lsvAnteckning.Name = "lsvAnteckning"
        Me.lsvAnteckning.Size = New System.Drawing.Size(196, 372)
        Me.lsvAnteckning.TabIndex = 5
        Me.lsvAnteckning.UseCompatibleStateImageBehavior = False
        '
        'grdDetalj
        '
        Me.grdDetalj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalj.Location = New System.Drawing.Point(200, -1)
        Me.grdDetalj.Name = "grdDetalj"
        Me.grdDetalj.RowTemplate.Height = 25
        Me.grdDetalj.Size = New System.Drawing.Size(601, 372)
        Me.grdDetalj.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grdDetalj)
        Me.Controls.Add(Me.lsvAnteckning)
        Me.Controls.Add(Me.btnRedigeraDagbok)
        Me.Controls.Add(Me.lblNodTag)
        Me.Controls.Add(Me.btnNyAktivitet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNyAktivitet As Button
    Friend WithEvents lblNodTag As Label
    Friend WithEvents btnRedigeraDagbok As Button
    Friend WithEvents lsvAnteckning As ListView
    Friend WithEvents grdDetalj As DataGridView
End Class
