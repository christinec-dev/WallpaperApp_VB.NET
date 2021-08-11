Public Class FormMain
    Private Sub WallpaperAppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click

        'This defines our variables that will be used to calculate our single rolls
        Dim answer1 As Integer
        Dim answer2 As Integer
        Dim answer3 As Integer
        Dim answer4 As Decimal
        Dim totalCalc As Decimal

        'This assigns our variables to their designated comboboxes to record user input
        answer1 = LenghtCmb.Text
        answer2 = WidthCmb.Text
        answer3 = HeightCmb.Text
        answer4 = RollCoverCmb.Text

        'This is the calculation that will execute on the button to get the rolls
        totalCalc = (2 * (answer1 * answer3) + 2 * (answer2 * answer3)) / answer4

        'This will round the answer up
        totalCalc = Math.Ceiling(totalCalc)

        'This will display the answer in our textbox for the user to see and use
        SingleRollTxt.Text = totalCalc

    End Sub

    Private Sub RoomLengthInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LenghtCmb.SelectedIndexChanged
        'I added this for the purpose of clearing the SingleRoll textbox of any values whenever the four comboboxes change in values
        If LenghtCmb.SelectedItem = "+1" Then
            SingleRollTxt.Text = ""
        Else
            SingleRollTxt.Text = ""
        End If
    End Sub

    Private Sub RoomWidthInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WidthCmb.SelectedIndexChanged
        If WidthCmb.SelectedItem = "+1" Then
            SingleRollTxt.Text = ""
        Else
            SingleRollTxt.Text = ""
        End If
    End Sub

    Private Sub RoomHeightInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HeightCmb.SelectedIndexChanged
        If HeightCmb.SelectedItem = "+1" Then
            SingleRollTxt.Text = ""
        Else
            SingleRollTxt.Text = ""
        End If
    End Sub

    Private Sub RollCoverageInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RollCoverCmb.SelectedIndexChanged
        If RollCoverCmb.SelectedItem = "+0.5" Then
            SingleRollTxt.Text = ""
        Else
            SingleRollTxt.Text = ""
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        'This will close the application when the user click on the button
    End Sub

End Class