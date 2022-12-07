Public Class Form1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Decimal

        Dim decTotatCost As Decimal


        decPrice = 5
        iQuantity = 10
        decDiscount = 2



        decTotatCost = (decPrice - decDiscount) * iQuantity

        ' BO(DM)(AS) - Brackets Order Div Mult Add Sub

        MsgBox(decTotatCost)





    End Sub
End Class
