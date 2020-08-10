Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUsername.Text = My.Settings.AdminUser And txtPassword.Text = My.Settings.AdminPass Then


            Call Admin()

        ElseIf txtUsername.Text = My.Settings.UserUser And txtPassword.Text = My.Settings.UserPass Then

            Call User()

        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Please fill all textboxes!")

            txtUsername.Focus()

        ElseIf txtUsername.Text <> My.Settings.AdminUser And txtUsername.Text <> My.Settings.UserUser Then

            MsgBox("Username is not CORRECT")
            txtUsername.Focus()
            Return
        Else

            MsgBox("Password is not CORRECT")

        End If

    End Sub

    Private Sub Admin()
        Occupants_Details_and_Room_Number.Show()
        Me.Hide()



    End Sub
    Private Sub User()
        Occupants_Details_and_Room_Number.Show()
        Me.Hide()



    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
