

Imports System.Data.SqlClient

Public Class Form1
    Dim rand As New Random()
    Dim currentHole As Integer = -1
    Dim score As Integer = 0
    Dim holes As PictureBox()
    Dim timeLeft As Integer = 30
    Dim connStr As String = "Server=LAPTOP-U555ALAJ\SQLEXPRESS;Database=WhacAMoleDB;Trusted_Connection=True;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        holes = New PictureBox() {pbHole1, pbHole2, pbHole3,
                                  pbHole4, pbHole5, pbHole6,
                                  pbHole7, pbHole8, pbHole9}
        For Each pb As PictureBox In holes
            AddHandler pb.Click, AddressOf Hole_Click
            pb.Image = My.Resources.hole
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.BackColor = Color.Transparent
            pb.BringToFront()


        Next


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        score = 0
        timeLeft = 30
        lblScore.Text = "Score: 0"
        lblTime.Text = "Time: 30"
        btnStart.Enabled = False
        tmrMole.Enabled = True
        tmrLimit.Enabled = True
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        tmrMole.Enabled = False
        tmrLimit.Enabled = False
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn kết thúc trò chơi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Bạn đã kết thúc trò chơi! Điểm của bạn là: " & score)
            SaveScore()
            btnStart.Enabled = True
            Me.Hide()
            Dim lobby As New LobbyForm()
            lobby.Show()
        Else
            tmrMole.Enabled = True
            tmrLimit.Enabled = True
        End If
    End Sub

    Private Sub tmrMole_Tick(sender As Object, e As EventArgs) Handles tmrMole.Tick
        If currentHole >= 0 Then
            holes(currentHole).Image = My.Resources.hole
        End If
        currentHole = rand.Next(0, holes.Length)

        holes(currentHole).Image = My.Resources.mole

    End Sub

    Private Sub Hole_Click(sender As Object, e As EventArgs)
        Dim clicked As PictureBox = CType(sender, PictureBox)
        Dim idx As Integer = Array.IndexOf(holes, clicked)
        If idx = currentHole Then
            score += 1
            lblScore.Text = "Score: " & score
            clicked.Image = My.Resources.hole
            currentHole = -1
        End If
    End Sub

    Private Sub tmrLimit_Tick(sender As Object, e As EventArgs) Handles tmrLimit.Tick
        timeLeft -= 1
        lblTime.Text = "Time: " & timeLeft
        If timeLeft <= 0 Then
            tmrMole.Enabled = False
            tmrLimit.Enabled = False
            MessageBox.Show("Hết giờ! Điểm của bạn là: " & score)
            SaveScore()
            btnStart.Enabled = True
            Me.Hide()
            Dim lobby As New LobbyForm()
            lobby.Show()
        End If
    End Sub

    Private Sub SaveScore()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Scores (Score, Time) VALUES (@score, @time)", conn)
            cmd.Parameters.AddWithValue("@score", score)
            cmd.Parameters.AddWithValue("@time", DateTime.Now)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class

' Form LobbyForm: Form sảnh chờ
Public Partial Class LobbyForm
    Inherits Form
    Private Sub LobbyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Giao diện chờ - có nút bắt đầu và xem điểm cao
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim game As New Form1()
        game.Show()
        Me.Hide()
    End Sub
    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Dim highScores As New HighScoresForm()
        highScores.Show()
    End Sub
End Class

' Form HighScoresForm: Hiển thị điểm cao
Partial Public Class HighScoresForm
    Inherits Form

    Dim connStr As String = "Server=LAPTOP-U555ALAJ\SQLEXPRESS;Database=WhacAMoleDB;Trusted_Connection=True;"

    Private Sub HighScoresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT TOP 10 Score, Time FROM Scores ORDER BY Score DESC", conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim i As Integer = 1
            While reader.Read()
                lstHighScores.Items.Add(i.ToString() & ". " & reader("Score").ToString() & " - " & reader("Time").ToString())
                i += 1
            End While
        End Using
    End Sub

End Class
