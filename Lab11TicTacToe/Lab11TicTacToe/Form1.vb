Public Class frmTIcTac
    'Private intRand As Integer = 1
    Private intSet As Integer = 0

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        btnPlay1.Text = ""
        btnPlay1.Enabled = True
        btnPlay2.Text = ""
        btnPlay2.Enabled = True
        btnPlay3.Text = ""
        btnPlay3.Enabled = True
        btnPlay4.Text = ""
        btnPlay4.Enabled = True
        btnPlay5.Text = ""
        btnPlay5.Enabled = True
        btnPlay6.Text = ""
        btnPlay6.Enabled = True
        btnPlay7.Text = ""
        btnPlay7.Enabled = True
        btnPlay8.Text = ""
        btnPlay8.Enabled = True
        btnPlay9.Text = ""
        btnPlay9.Enabled = True
        lblWin.Text = ""

        intSet = 0
    End Sub

    Private Sub frmTIcTac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlay1.Text = ""
        btnPlay1.Enabled = True
        btnPlay2.Text = ""
        btnPlay2.Enabled = True
        btnPlay3.Text = ""
        btnPlay3.Enabled = True
        btnPlay4.Text = ""
        btnPlay4.Enabled = True
        btnPlay5.Text = ""
        btnPlay5.Enabled = True
        btnPlay6.Text = ""
        btnPlay6.Enabled = True
        btnPlay7.Text = ""
        btnPlay7.Enabled = True
        btnPlay8.Text = ""
        btnPlay8.Enabled = True
        btnPlay9.Text = ""
        btnPlay9.Enabled = True

        intSet = 0
    End Sub

    Sub ComputerPlay()
        Dim objRandon As New Random
        Dim intRandom As Integer

        intRandom = Integer.Parse(objRandon.Next(1, 10))

        If intRandom = 1 And btnPlay1.Enabled Then
            btnPlay1.Text = "O"
            btnPlay1.Enabled = False
            Exit Sub
        End If

        If intRandom = 2 And btnPlay2.Enabled Then
            btnPlay2.Text = "O"
            btnPlay2.Enabled = False
            Exit Sub
        End If

        If intRandom = 3 And btnPlay3.Enabled Then
            btnPlay3.Text = "O"
            btnPlay3.Enabled = False
            Exit Sub
        End If

        If intRandom = 4 And btnPlay4.Enabled Then
            btnPlay4.Text = "O"
            btnPlay4.Enabled = False
            Exit Sub
        End If

        If intRandom = 5 And btnPlay5.Enabled Then
            btnPlay5.Text = "O"
            btnPlay5.Enabled = False
            Exit Sub
        End If

        If intRandom = 6 And btnPlay6.Enabled Then
            btnPlay6.Text = "O"
            btnPlay6.Enabled = False
            Exit Sub
        End If

        If intRandom = 7 And btnPlay7.Enabled Then
            btnPlay7.Text = "O"
            btnPlay7.Enabled = False
            Exit Sub
        End If

        If intRandom = 8 And btnPlay8.Enabled Then
            btnPlay8.Text = "O"
            btnPlay8.Enabled = False
            Exit Sub
        End If

        If intRandom = 9 And btnPlay9.Enabled Then
            btnPlay9.Text = "O"
            btnPlay9.Enabled = False
            Exit Sub
        End If

        'ComputerPlay()

    End Sub

    Private Sub ClickButtons(sender As Object, e As EventArgs) Handles btnPlay1.Click, btnPlay2.Click, btnPlay3.Click, btnPlay4.Click, btnPlay5.Click, btnPlay6.Click, btnPlay7.Click, btnPlay8.Click, btnPlay8.Click, btnPlay9.Click

        'You play
        sender.text = "X"
        sender.enabled = False
        intSet += 1
        CheckWinner()

        'Computer plays
        ComputerPlay()
        intSet += 1
        CheckWinner()

    End Sub

    Sub CheckWinner()
        If intSet >= 9 Then
            lblWin.Text = "Nobody is winner"
        ElseIf btnPlay1.Text = "O" And btnPlay2.Text = "O" And btnPlay3.Text = "O" _
            Or btnPlay4.Text = "O" And btnPlay5.Text = "O" And btnPlay6.Text = "O" _
            Or btnPlay7.Text = "O" And btnPlay8.Text = "O" And btnPlay9.Text = "O" _
            Or btnPlay1.Text = "O" And btnPlay4.Text = "O" And btnPlay7.Text = "O" _
            Or btnPlay2.Text = "O" And btnPlay5.Text = "O" And btnPlay8.Text = "O" _
            Or btnPlay3.Text = "O" And btnPlay6.Text = "O" And btnPlay9.Text = "O" _
            Or btnPlay1.Text = "O" And btnPlay5.Text = "O" And btnPlay9.Text = "O" _
            Or btnPlay1.Text = "O" And btnPlay2.Text = "O" And btnPlay3.Text = "O" _
            Or btnPlay7.Text = "O" And btnPlay5.Text = "O" And btnPlay3.Text = "O" Then

            lblWin.Text = "Computer winner!!"
        ElseIf btnPlay1.Text = "X" And btnPlay2.Text = "X" And btnPlay3.Text = "X" _
            Or btnPlay4.Text = "X" And btnPlay5.Text = "X" And btnPlay6.Text = "X" _
            Or btnPlay7.Text = "X" And btnPlay8.Text = "X" And btnPlay9.Text = "X" _
            Or btnPlay1.Text = "X" And btnPlay4.Text = "X" And btnPlay7.Text = "X" _
            Or btnPlay2.Text = "X" And btnPlay5.Text = "X" And btnPlay8.Text = "X" _
            Or btnPlay3.Text = "X" And btnPlay6.Text = "X" And btnPlay9.Text = "X" _
            Or btnPlay1.Text = "X" And btnPlay5.Text = "X" And btnPlay9.Text = "X" _
            Or btnPlay1.Text = "X" And btnPlay2.Text = "X" And btnPlay3.Text = "X" _
            Or btnPlay7.Text = "X" And btnPlay5.Text = "X" And btnPlay3.Text = "X" Then

            lblWin.Text = "You winner!!"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
