Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text
        stCountry = stCountry.ToUpper



        If stCountry = "BANGLADESH" Then
            MsgBox("Sovo Sokal")
        ElseIf stCountry = "INDIA" Then
            MsgBox("Soba mubarak")

        Else
            MsgBox("Hello")

        End If



    End Sub
End Class
