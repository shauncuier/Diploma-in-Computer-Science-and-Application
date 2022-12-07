Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblNumber1 As Double
        Dim dblNumber2 As Double

        Dim dblResult As Double

        dblNumber1 = txtNum1.Text
        dblNumber2 = txtNum2.Text

        dblResult = dblNumber1 + dblNumber2

        MsgBox(dblResult)

        dblResult = dblNumber1 - dblNumber2

        MsgBox(dblResult)

        dblResult = dblNumber1 * dblNumber2

        MsgBox(dblResult)

        dblResult = dblNumber1 / dblNumber2

        MsgBox(dblResult)

        dblResult = dblNumber1 \ dblNumber2

        MsgBox(dblResult)

        dblResult = dblNumber1 Mod dblNumber2

        MsgBox(dblResult)

    End Sub
End Class
