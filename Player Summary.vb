Public Class Player_Summary

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGetStats_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetStats.Click


        Dim objStreamReader As System.IO.StreamReader
        Try
            objStreamReader = System.IO.File.OpenText("PlayerStats.txt")
        Catch ex As Exception
            MessageBox.Show("File could not be opened")
            Exit Sub
        End Try

        Dim statistics() As String = IO.File.ReadAllLines("PlayerStats.txt")
        Dim query = From line In statistics
                    Let data = line.Split(","c)
                    Let FirstName = data(0)
                    Let LastName = data(1)
                    Let Seasons = data(2)
                    Let Age = data(3)
                    Let Goals = data(4)
                    Let Assists = data(5)
                    Let Points = data(6)
                    Select FirstName, LastName, Seasons, Age, Goals, Assists, Points

        dvgStatistics.DataSource = query.ToList
        dvgStatistics.CurrentCell = Nothing

        dvgStatistics.Columns("FirstName").HeaderText = "First Name"
        dvgStatistics.Columns("LastName").HeaderText = "Last Name"

        Try
            objStreamReader.Close()
        Catch ex As Exception
            MessageBox.Show("Filecould not be closed")
            Exit Sub
        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim objStreamWriter As System.IO.StreamWriter

        Try
            objStreamWriter = System.IO.File.CreateText("PlayerStats.txt")
        Catch ex As Exception
            MessageBox.Show("File could not be opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try
            objStreamWriter.Close()
        Catch ex As Exception
            MessageBox.Show("File could not be closed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class