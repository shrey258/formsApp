Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Threading.Tasks
Imports System.Net
Imports System.Text


Public Class FormViewSubmissions
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission) = New List(Of Submission)


    ' Form load event handler
    Private Async Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                    Dim submission = JsonConvert.DeserializeObject(Of Submission)(responseBody)
                    txtName.Text = submission.Name
                    txtEmail.Text = submission.Email
                    txtPhone.Text = submission.Phone
                    txtGithubLink.Text = submission.Github_Link
                    lblStopwatchTime.Text = submission.Stopwatch_Time
                ElseIf response.StatusCode = HttpStatusCode.NotFound Then
                    MessageBox.Show("No submissions found")
                Else
                    MessageBox.Show("Error loading submission")
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading submission")
            End Try
        End Using
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using client As New HttpClient()
            Dim response = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully")
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                Await LoadSubmission(currentIndex)
            Else
                MessageBox.Show("Error deleting submission")
            End If
        End Using
    End Sub

    Private Sub btnEnableEdit_Click(sender As Object, e As EventArgs) Handles btnEnableEdit.Click
        ' Toggle the ReadOnly property of the text fields
        txtName.ReadOnly = Not txtName.ReadOnly
        txtEmail.ReadOnly = Not txtEmail.ReadOnly
        txtPhone.ReadOnly = Not txtPhone.ReadOnly
        txtGithubLink.ReadOnly = Not txtGithubLink.ReadOnly
        lblStopwatchTime.ReadOnly = Not lblStopwatchTime.ReadOnly


        btnSave.Visible = Not txtName.ReadOnly
        btnEnableEdit.Visible = False

    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Await UpdateSubmission(currentIndex)
    End Sub

    Private Async Function UpdateSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .Github_Link = txtGithubLink.Text,
            .Stopwatch_Time = lblStopwatchTime.Text
        }
            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PutAsync($"http://localhost:3000/edit?index={index}", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully")
                ' Toggle back to read-only mode after saving
                txtName.ReadOnly = True
                txtEmail.ReadOnly = True
                txtPhone.ReadOnly = True
                txtGithubLink.ReadOnly = True
                lblStopwatchTime.ReadOnly = True
                btnSave.Visible = False
                btnEnableEdit.Visible = True
            Else
                MessageBox.Show("Error updating submission")
            End If
        End Using
    End Function


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.D) Then
            btnDelete.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.E) Then
            btnEnableEdit.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSave.PerformClick()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function




End Class
