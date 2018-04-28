Public Class frmTIcTac

    Dim game(2, 2) As Integer
    Const intMAX_ROW As Integer = 2
    Const intMAX_COL As Integer = 2
    Dim rand As New Random
    Dim intRow As Integer
    Dim intCol As Integer

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click

        'Randomly fill array  1
        For intRow As Integer = 0 To 2
            For intCol As Integer = 0 To 2
                Dim n As Integer = rand.Next(3)
                game(intRow, intCol) = n
            Next
        Next

        'Determine if an X or O will be the text by the random value placed in the subscript.
        If game(0, 0) = 1 Then
            btnPlay1.Text = "X"
        Else
            btnPlay1.Text = "O"
        End If
        If game(0, 1) = 1 Then
            btnPlay2.Text = "X"
        Else
            btnPlay2.Text = "O"
        End If
        If game(0, 2) = 1 Then
            btnPlay3.Text = "X"
        Else
            btnPlay3.Text = "O"
        End If
        If game(1, 0) = 1 Then
            btnPlay4.Text = "X"
        Else
            btnPlay4.Text = "O"
        End If
        If game(1, 1) = 1 Then
            btnPlay5.Text = "X"
        Else
            btnPlay5.Text = "O"
        End If
        If game(1, 2) = 1 Then
            btnPlay6.Text = "X"
        Else
            btnPlay6.Text = "O"
        End If
        If game(2, 0) = 1 Then
            btnPlay7.Text = "X"
        Else
            btnPlay7.Text = "O"
        End If
        If game(2, 1) = 1 Then
            btnPlay8.Text = "X"
        Else
            btnPlay8.Text = "O"
        End If
        If game(2, 2) = 1 Then
            btnPlay9.Text = "X"
        Else
            btnPlay9.Text = "O"
        End If


        If btnPlay1.Text = "O" And btnPlay2.Text = "O" And btnPlay3.Text = "O" _
            Or btnPlay4.Text = "O" And btnPlay5.Text = "O" And btnPlay6.Text = "O" _
            Or btnPlay7.Text = "O" And btnPlay8.Text = "O" And btnPlay9.Text = "O" _
            Or btnPlay1.Text = "O" And btnPlay4.Text = "O" And btnPlay7.Text = "O" _
            Or btnPlay2.Text = "O" And btnPlay5.Text = "O" And btnPlay8.Text = "O" _
            Or btnPlay3.Text = "O" And btnPlay6.Text = "O" And btnPlay9.Text = "O" _
            Or btnPlay1.Text = "O" And btnPlay5.Text = "O" And btnPlay9.Text = "O" _
            Or btnPlay1.Text = "O" And btnPlay2.Text = "O" And btnPlay3.Text = "O" _
            Or btnPlay7.Text = "O" And btnPlay5.Text = "O" And btnPlay3.Text = "O" Then

            lblWin.Text = "O is winner"
        ElseIf btnPlay1.Text = "X" And btnPlay2.Text = "X" And btnPlay3.Text = "X" _
            Or btnPlay4.Text = "X" And btnPlay5.Text = "X" And btnPlay6.Text = "X" _
            Or btnPlay7.Text = "X" And btnPlay8.Text = "X" And btnPlay9.Text = "X" _
            Or btnPlay1.Text = "X" And btnPlay4.Text = "X" And btnPlay7.Text = "X" _
            Or btnPlay2.Text = "X" And btnPlay5.Text = "X" And btnPlay8.Text = "X" _
            Or btnPlay3.Text = "X" And btnPlay6.Text = "X" And btnPlay9.Text = "X" _
            Or btnPlay1.Text = "X" And btnPlay5.Text = "X" And btnPlay9.Text = "X" _
            Or btnPlay1.Text = "X" And btnPlay2.Text = "X" And btnPlay3.Text = "X" _
            Or btnPlay7.Text = "X" And btnPlay5.Text = "X" And btnPlay3.Text = "X" Then

            lblWin.Text = "X is winner!!"
        Else
            lblWin.Text = "Nobody is winner!!"
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
