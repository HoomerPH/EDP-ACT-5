Imports MySql.Data.MySqlClient

Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from users where username = '" _
                & .UsernameTextBox.Text & "' and pass = md5('" _
                & .PasswordTextBox.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                Landing.Show()
            Else
                MessageBox.Show("Invalid Username or Password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
