<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackGroundWorker
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
        Me.btnCarregarGrid = New System.Windows.Forms.Button()
        Me.btnTestarThreading = New System.Windows.Forms.Button()
        Me.dgvTeste = New System.Windows.Forms.DataGridView()
        Me.bwrTeste = New System.ComponentModel.BackgroundWorker()
        Me.lblExplicacao = New System.Windows.Forms.Label()
        Me.txtExplicacao2 = New System.Windows.Forms.Label()
        CType(Me.dgvTeste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCarregarGrid
        '
        Me.btnCarregarGrid.Location = New System.Drawing.Point(358, 12)
        Me.btnCarregarGrid.Name = "btnCarregarGrid"
        Me.btnCarregarGrid.Size = New System.Drawing.Size(100, 23)
        Me.btnCarregarGrid.TabIndex = 0
        Me.btnCarregarGrid.Text = "&Carregar Grid"
        Me.btnCarregarGrid.UseVisualStyleBackColor = True
        '
        'btnTestarThreading
        '
        Me.btnTestarThreading.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnTestarThreading.Location = New System.Drawing.Point(358, 87)
        Me.btnTestarThreading.Name = "btnTestarThreading"
        Me.btnTestarThreading.Size = New System.Drawing.Size(100, 23)
        Me.btnTestarThreading.TabIndex = 1
        Me.btnTestarThreading.Text = "&Testar Threading"
        Me.btnTestarThreading.UseVisualStyleBackColor = True
        '
        'dgvTeste
        '
        Me.dgvTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeste.Location = New System.Drawing.Point(12, 12)
        Me.dgvTeste.Name = "dgvTeste"
        Me.dgvTeste.Size = New System.Drawing.Size(340, 373)
        Me.dgvTeste.TabIndex = 2
        '
        'bwrTeste
        '
        '
        'lblExplicacao
        '
        Me.lblExplicacao.Location = New System.Drawing.Point(358, 54)
        Me.lblExplicacao.Name = "lblExplicacao"
        Me.lblExplicacao.Size = New System.Drawing.Size(100, 30)
        Me.lblExplicacao.TabIndex = 3
        Me.lblExplicacao.Text = "Aperte logo em seguida ese botão:"
        '
        'txtExplicacao2
        '
        Me.txtExplicacao2.Location = New System.Drawing.Point(358, 113)
        Me.txtExplicacao2.Name = "txtExplicacao2"
        Me.txtExplicacao2.Size = New System.Drawing.Size(100, 50)
        Me.txtExplicacao2.TabIndex = 4
        Me.txtExplicacao2.Text = "Veja que NÃO travou o processamento!"
        '
        'frmBackGroundWorker
        '
        Me.AcceptButton = Me.btnTestarThreading
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnTestarThreading
        Me.ClientSize = New System.Drawing.Size(470, 397)
        Me.Controls.Add(Me.txtExplicacao2)
        Me.Controls.Add(Me.lblExplicacao)
        Me.Controls.Add(Me.dgvTeste)
        Me.Controls.Add(Me.btnTestarThreading)
        Me.Controls.Add(Me.btnCarregarGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackGroundWorker"
        Me.ShowIcon = False
        Me.Text = "BackGround Worker VB.Net"
        CType(Me.dgvTeste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCarregarGrid As System.Windows.Forms.Button
    Friend WithEvents btnTestarThreading As System.Windows.Forms.Button
    Friend WithEvents dgvTeste As System.Windows.Forms.DataGridView
    Friend WithEvents bwrTeste As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblExplicacao As Label
    Friend WithEvents txtExplicacao2 As Label
End Class
