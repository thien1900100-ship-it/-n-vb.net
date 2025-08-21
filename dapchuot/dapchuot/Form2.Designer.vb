<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LobbyForm
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPlay.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPlay.BackgroundImage = Global.dapchuot.My.Resources.Resources.st
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.Location = New System.Drawing.Point(359, 127)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(132, 118)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnHighScores
        '
        Me.btnHighScores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHighScores.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnHighScores.BackgroundImage = Global.dapchuot.My.Resources.Resources.hc
        Me.btnHighScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHighScores.Location = New System.Drawing.Point(359, 268)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(132, 118)
        Me.btnHighScores.TabIndex = 1
        Me.btnHighScores.UseVisualStyleBackColor = False
        '
        'LobbyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dapchuot.My.Resources.Resources.nen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "LobbyForm"
        Me.Text = "Sảnh chờ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnHighScores As Button
End Class
