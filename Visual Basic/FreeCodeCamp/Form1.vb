﻿Public Class Form1

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

        Dim stMake As String
        Dim stModel As String
        Dim iDoor As Integer
        Dim stColor As String
        Dim bTexded As Boolean
        Dim iEnginSize As Integer
        Dim decPrice As Decimal
        Dim dtDate As Date



        stMake = "Ford"
        stModel = "Escort"
        iDoor = 5
        stColor = "red"
        bTexded = True
        iEnginSize = 1200
        decPrice = 999.99
        dtDate = #12/7/2022#

        MsgBox("The car is " &
               stMake & vbNewLine &
               stModel & vbNewLine &
               iDoor & vbNewLine &
               stColor & vbNewLine &
               bTexded & vbNewLine &
               iEnginSize & vbNewLine &
               decPrice & vbNewLine &
               dtDate)


    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click

        Dim stFirstName As String
        stFirstName = InputBox("Please Enter Your Name")
        MsgBox("Hello " & stFirstName)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirtsName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        stOccupation = lstOccupation.SelectedItem

        MsgBox("Hello " & stFirstName & " " & stLastName & " " & " You are " & stGender & ". Your Occupation is " & stOccupation)



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Printer")
        lstOccupation.Items.Add("Developer")
        lstOccupation.Items.Add("Eng.")

    End Sub
End Class
