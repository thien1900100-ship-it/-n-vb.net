<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScoresForm
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
        Me.lstHighScores = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstHighScores
        '
        Me.lstHighScores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstHighScores.BackColor = System.Drawing.Color.RosyBrown
        Me.lstHighScores.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHighScores.ForeColor = System.Drawing.Color.Linen
        Me.lstHighScores.FormattingEnabled = True
        Me.lstHighScores.ItemHeight = 32
        Me.lstHighScores.Location = New System.Drawing.Point(394, 102)
        Me.lstHighScores.Name = "lstHighScores"
        Me.lstHighScores.Size = New System.Drawing.Size(647, 580)
        Me.lstHighScores.TabIndex = 0
        '
        'HighScoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dapchuot.My.Resources.Resources.nengame
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1374, 760)
        Me.Controls.Add(Me.lstHighScores)
        Me.Name = "HighScoresForm"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstHighScores As ListBox
End Class
