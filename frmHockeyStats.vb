Option Strict On
Public Class frmHockeyStats
    Dim goals, totalGoals, assists, totalAssists, points, totalPoints As Integer
    Dim strInput, strFirstName, strLastName, strLine As String
    Dim intSeasons, intAge, count As Integer
    Const minGoals As Integer = 0, maxGoals As Integer = 70
    Const minSeasons As Integer = 0, maxSeasons As Integer = 25
    Const minAssists As Integer = 0, maxAssists As Integer = 75
    Const minAge As Integer = 18, maxAge As Integer = 30
    Dim objStreamWriter As System.IO.StreamWriter

    Private Function StringIsValid(ByVal strText As String, ByRef strVariable As String) As Boolean
        If String.IsNullOrEmpty(strText) = True Then
            MessageBox.Show("Please type a valid name.")
            Return False
        Else
            strVariable = strText
            Return True
        End If
    End Function
    Private Function validateInteger(ByVal strTitle As String, ByVal strText As String, _
                                     ByRef intVariable As Integer, ByVal intMinInput As Integer, _
                                     ByVal intMaxInput As Integer) As Boolean
        If Integer.TryParse(strText, intVariable) = False Then
            MessageBox.Show("Please type a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            If intVariable >= intMinInput And intVariable <= intMaxInput Then
                Return True
            Else
                MessageBox.Show("The " & strTitle & " must be between " & CStr(intMinInput) & " and " _
                                & CStr(intMaxInput) & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
    End Function
    Private Function Sum(ByVal intValue1 As Integer, ByVal intValue2 As Integer, _
                         ByRef intTotalValue As Integer) As Integer
        intTotalValue = intValue1 + intValue2
        Return 0
    End Function
    Private Sub CollectStatistics()
        count = 1
        Do While count <= intSeasons
            Do While True
                strInput = InputBox("Goals for Season " & CStr(count) & ":", "Goals")
                If validateInteger("number of goals", strInput, goals, minGoals, maxGoals) Then
                    Exit Do
                End If
            Loop

            Do While True
                strInput = InputBox("Assists for Season " & CStr(count) & ":", "Assists")
                If validateInteger("number of assists", strInput, assists, minAssists, maxAssists) Then
                    Exit Do
                End If
            Loop

            Sum(totalGoals, goals, totalGoals)
            Sum(totalAssists, assists, totalAssists)
            Sum(goals, assists, points)
            Sum(totalPoints, points, totalPoints)

            lstSeasons.Items.Add("Season " & CStr(count) & ", Goals: " & CStr(goals) & ", Assists: " _
                                 & CStr(assists) & ", Points: " & CStr(points))
            count = count + 1
        Loop
    End Sub
    Private Sub WriteToFile()
        Try
            objStreamWriter = System.IO.File.AppendText("PlayerStats.txt")
        Catch ex As Exception
            MessageBox.Show("File could not be opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        strLine = strFirstName & "," & _
                  strLastName & "," & _
                  intSeasons & "," & _
                  intAge & "," & _
                  totalGoals & "," & _
                  totalAssists & "," & _
                  totalPoints

        Try
            objStreamWriter.WriteLine(strLine)
        Catch ex As Exception
            MessageBox.Show("File could not be written.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try
            objStreamWriter.Close()
        Catch ex As Exception
            MessageBox.Show("File could not be closed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGetStats_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnGetStats.Click, mnuGetStats.Click

        'Reset list
        lstSeasons.Items.Clear()

        Do While True
            strInput = InputBox("First Name:", "Name")
            If StringIsValid(strInput, strFirstName) Then
                Exit Do
            End If
        Loop

        Do While True
            strInput = InputBox("Last Name:", "Name")
            If StringIsValid(strInput, strLastName) Then
                Exit Do
            End If
        Loop

        Do While True
            strInput = InputBox("Number of seasons:", "Seasons")
            If validateInteger("number of seasons", strInput, intSeasons, minSeasons, maxSeasons) Then
                Exit Do
            End If
        Loop

        Do While True
            strInput = InputBox("Age:", "Age")
            If validateInteger("age", strInput, intAge, minAge, maxAge) Then
                Exit Do
            End If
        Loop

        count = 1

        lstSeasons.Items.Add("Statistics for: " & strFirstName & " " & strLastName)
        lstSeasons.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -")

        'Collect Data
        Call CollectStatistics()

        'Display Results
        lblTotal.Text = strFirstName & " " & strLastName & " career statistics. Age: " & intAge _
            & ", Seasons: " & CStr(intSeasons) & ", Goals: " & CStr(totalGoals) & ", Assists: " _
            & CStr(totalAssists) & ", Points: " & CStr(totalPoints)

        'Write to file
        Call WriteToFile()


    End Sub


    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click, mnuClear.Click
        lstSeasons.Items.Clear()
        lblTotal.Text = Nothing
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click, mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSummary.Click, mnuSummary.Click
        Player_Summary.Show()
    End Sub
End Class
