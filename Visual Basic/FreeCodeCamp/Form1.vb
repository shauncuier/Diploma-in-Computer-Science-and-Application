Public Class Form1


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Welcome")
        MsgBox("to")
        MsgBox("the")
        MsgBox("BV.NET")
        MsgBox("Programing")
        MsgBox("Course")

        MessageBox.Show("Hello")

    End Sub


    Private Sub btnVar_Click(sender As Object, e As EventArgs) Handles btnVar.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Jashedul Islam"
        stLastName = "Shaun"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope are well.")



        stFirstName = "Oahidul Islam"
        stLastName = "Sajib"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope are well.")



    End Sub

    Private Sub DataType_Click(sender As Object, e As EventArgs) Handles DataType.Click




    End Sub
End Class
