Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Threading.Tasks

Public Class FormCreateSubmission
    Private stopwatch As Stopwatch

    Private Sub FormCreateSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If

        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
        .Name = txtName.Text,
        .Email = txtEmail.Text,
        .Phone = txtPhone.Text,
        .Github_Link = txtGithubLink.Text,
        .Stopwatch_Time = lblStopwatchTime.Text
    }

        Await SaveSubmission(submission)
        MessageBox.Show("Submission Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Async Function SaveSubmission(submission As Submission) As Task
        Using client As New HttpClient()
            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Await client.PostAsync("http://localhost:3000/submit", content)
        End Using
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            btnToggleStopwatch.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
