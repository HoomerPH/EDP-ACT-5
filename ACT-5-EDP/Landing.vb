Public Class Landing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles breed.Click
        Dim Breed As New Breed
        Breed.Show()
        Me.Hide() 'Optional: hide the current form
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles nickname.Click
        Dim form1 As New Name
        form1.Show()
        Me.Hide() 'Optional: hide the current form
    End Sub

    Private Sub sex_Click(sender As Object, e As EventArgs) Handles sex.Click
        Dim Sex As New Sex
        Sex.Show()
        Me.Hide() 'Optional: hide the current form
    End Sub

    Private Sub color_Click(sender As Object, e As EventArgs) Handles color.Click
        Dim Color As New Color
        Color.Show()
        Me.Hide() 'Optional: hide the current form
    End Sub


End Class