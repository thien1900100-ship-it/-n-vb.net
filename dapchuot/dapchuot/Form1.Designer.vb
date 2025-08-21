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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrMole = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.tmrLimit = New System.Windows.Forms.Timer(Me.components)
        Me.pbHole3 = New System.Windows.Forms.PictureBox()
        Me.pbHole2 = New System.Windows.Forms.PictureBox()
        Me.pbHole6 = New System.Windows.Forms.PictureBox()
        Me.pbHole5 = New System.Windows.Forms.PictureBox()
        Me.pbHole4 = New System.Windows.Forms.PictureBox()
        Me.pbHole7 = New System.Windows.Forms.PictureBox()
        Me.pbHole8 = New System.Windows.Forms.PictureBox()
        Me.pbHole9 = New System.Windows.Forms.PictureBox()
        Me.pbHole1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbHole3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHole1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMole
        '
        Me.tmrMole.Interval = 800
        '
        'lblScore
        '
        Me.lblScore.AllowDrop = True
        resources.ApplyResources(Me.lblScore, "lblScore")
        Me.lblScore.AutoEllipsis = True
        Me.lblScore.BackColor = System.Drawing.Color.Peru
        Me.lblScore.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblScore.Name = "lblScore"
        '
        'btnStart
        '
        resources.ApplyResources(Me.btnStart, "btnStart")
        Me.btnStart.BackColor = System.Drawing.Color.SkyBlue
        Me.btnStart.BackgroundImage = Global.dapchuot.My.Resources.Resources.st
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Name = "btnStart"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        resources.ApplyResources(Me.lblTime, "lblTime")
        Me.lblTime.BackColor = System.Drawing.Color.Peru
        Me.lblTime.Name = "lblTime"
        '
        'btnEnd
        '
        resources.ApplyResources(Me.btnEnd, "btnEnd")
        Me.btnEnd.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEnd.BackgroundImage = Global.dapchuot.My.Resources.Resources.ex
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'tmrLimit
        '
        Me.tmrLimit.Interval = 1000
        '
        'pbHole3
        '
        resources.ApplyResources(Me.pbHole3, "pbHole3")
        Me.pbHole3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole3.Name = "pbHole3"
        Me.pbHole3.TabStop = False
        '
        'pbHole2
        '
        resources.ApplyResources(Me.pbHole2, "pbHole2")
        Me.pbHole2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole2.Name = "pbHole2"
        Me.pbHole2.TabStop = False
        '
        'pbHole6
        '
        resources.ApplyResources(Me.pbHole6, "pbHole6")
        Me.pbHole6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole6.Name = "pbHole6"
        Me.pbHole6.TabStop = False
        '
        'pbHole5
        '
        resources.ApplyResources(Me.pbHole5, "pbHole5")
        Me.pbHole5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole5.Name = "pbHole5"
        Me.pbHole5.TabStop = False
        '
        'pbHole4
        '
        resources.ApplyResources(Me.pbHole4, "pbHole4")
        Me.pbHole4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole4.Name = "pbHole4"
        Me.pbHole4.TabStop = False
        '
        'pbHole7
        '
        resources.ApplyResources(Me.pbHole7, "pbHole7")
        Me.pbHole7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole7.Name = "pbHole7"
        Me.pbHole7.TabStop = False
        '
        'pbHole8
        '
        resources.ApplyResources(Me.pbHole8, "pbHole8")
        Me.pbHole8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole8.Name = "pbHole8"
        Me.pbHole8.TabStop = False
        '
        'pbHole9
        '
        resources.ApplyResources(Me.pbHole9, "pbHole9")
        Me.pbHole9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole9.Name = "pbHole9"
        Me.pbHole9.TabStop = False
        '
        'pbHole1
        '
        resources.ApplyResources(Me.pbHole1, "pbHole1")
        Me.pbHole1.BackColor = System.Drawing.SystemColors.Control
        Me.pbHole1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHole1.Name = "pbHole1"
        Me.pbHole1.TabStop = False
        '
        'Form1
        '
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BackgroundImage = Global.dapchuot.My.Resources.Resources.nengame
        Me.CausesValidation = False
        Me.Controls.Add(Me.pbHole2)
        Me.Controls.Add(Me.pbHole6)
        Me.Controls.Add(Me.pbHole5)
        Me.Controls.Add(Me.pbHole4)
        Me.Controls.Add(Me.pbHole7)
        Me.Controls.Add(Me.pbHole8)
        Me.Controls.Add(Me.pbHole9)
        Me.Controls.Add(Me.pbHole1)
        Me.Controls.Add(Me.pbHole3)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTime)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbHole3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHole1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbHole1 As PictureBox
    Friend WithEvents pbHole9 As PictureBox
    Friend WithEvents pbHole8 As PictureBox
    Friend WithEvents pbHole7 As PictureBox
    Friend WithEvents pbHole4 As PictureBox
    Friend WithEvents pbHole5 As PictureBox
    Friend WithEvents pbHole6 As PictureBox
    Friend WithEvents pbHole2 As PictureBox
    Friend WithEvents pbHole3 As PictureBox
    Friend WithEvents tmrMole As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents tmrLimit As Timer
End Class
