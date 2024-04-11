Imports System.Drawing.Text
Imports Newtonsoft.Json



Public Class Form1
    Public Qtype As Boolean
    Private defaultFile As String = "C:\Users\CMP_ViKuhl\Downloads\vbchapter5kahoot.json"
    Private QuestionList As New List(Of KahootQuestion)
    Dim ACK As Integer
    Public scorepointthing As Integer = 0
    Dim correctamendo As String


    Private Sub LoadQuestionsFromFile(filename As String)
        QuestionList.Clear()
        Dim reader As New IO.StreamReader(filename)
        Dim str As String = reader.ReadToEnd
        'NEW
        'Convert json file to collection of objects
        QuestionList = JsonConvert.DeserializeObject(Of List(Of KahootQuestion))(str)
        reader.Close()
        PnlAncerBoxes_Paint()
    End Sub





    Sub PrintListToConsole()

        For i As Integer = 0 To QuestionList.Count - 1

            Dim currentQuestion As KahootQuestion = QuestionList(i)
            Console.WriteLine("".PadLeft(55, "-"))
            Console.WriteLine(currentQuestion.Question)
            Console.WriteLine(currentQuestion.Answers(currentQuestion.Correct))
        Next


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        LoadQuestionsFromFile(defaultFile)
        PrintListToConsole()
        PnlAncerBoxes_Paint()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.DefaultExt = "json"
        OpenFileDialog1.Filter = "JSON files|*.json|All Files|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            LoadQuestionsFromFile(OpenFileDialog1.FileName)
            Console.WriteLine("".PadRight(25, "_"))
            Console.WriteLine(OpenFileDialog1.FileName)
            PrintListToConsole()
        End If
    End Sub

    Private Sub PnlAncerBoxes_Paint()
        Dim rand As New Random
        Dim random As Integer = rand.Next(0, QuestionList.Count)
        TxBxQuetions.Text = QuestionList(random).Question
        Dim Witha = PnlAncerBoxes.Width / 2
        Dim Hight = PnlAncerBoxes.Height / (QuestionList(random).Answers.Count / 2)
        PnlAncerBoxes.Controls.Clear()

        For i As Integer = 0 To QuestionList(random).Answers.Count - 1
            Dim yloc = Hight * Math.Floor(i / 2.0)
            Dim btn As New Button With {
                .Text = QuestionList(random).Answers(i),
                .Location = New Point(Witha * (i Mod 2), yloc),
                .Width = Witha,
                .Height = Hight
                }
            ACK = random
            AddHandler btn.Click, AddressOf Me.button_click
            PnlAncerBoxes.Controls.Add(btn)
            If btn.TabIndex = QuestionList(ACK).Correct Then
                correctamendo = btn.Text

            End If

        Next

    End Sub

    Private Sub button_click(sender As Button, e As EventArgs)
        If sender.TabIndex = QuestionList(ACK).Correct Then
            scorepointthing += 100
            MsgBox("corectimendo")
        Else
            MsgBox($"WRONG! The righ one is: {correctamendo}")
        End If
        LblScore.Text = scorepointthing.ToString
        QuestionList.RemoveAt(ACK)
        If QuestionList.Count > 0 Then
            PnlAncerBoxes_Paint()
        Else
            MsgBox("Game over")
            'show a new game over screen (form)
            'close this form

            PnlAncerBoxes.Controls.Clear()
            '            gameover.Label1.Text = scorepointthing.ToString
            gameover.StartPosition = FormStartPosition.CenterScreen
            gameover.Show()

        End If

    End Sub



End Class


Class KahootQuestion
    Private _Question As String
    Private _Answers As List(Of String)
    Private _Time As Integer
    Private _correct As Integer

    Public Property Correct As Integer
        Get
            Return _correct
        End Get
        Set(value As Integer)
            _correct = value
        End Set
    End Property

    Public Property Time As Integer
        Get
            Return _Time
        End Get
        Set(value As Integer)
            _Time = value
        End Set
    End Property

    Public Property Answers As List(Of String)
        Get
            Return _Answers
        End Get
        Set(value As List(Of String))
            _Answers = value
        End Set
    End Property

    Public Property Question As String
        Get

            Return _Question
        End Get
        Set(value As String)
            _Question = value
        End Set
    End Property
End Class