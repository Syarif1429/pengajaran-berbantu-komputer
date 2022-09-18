Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object,
           e As EventArgs) Handles btnAdd.Click
        Dim intNumber As Integer
        intNumber = 27
        intNumber = intNumber + 1
        MessageBox.Show("Value of intNumber + 1 = " &
intNumber.ToString,
            "Variables")
    End Sub

    Private Sub btnIntMath_Click(sender As Object,
                e As EventArgs) Handles btnIntMath.Click

        'Declare variable
        Dim intNumber As Integer

        'Set number, add numbers, and display results
        intNumber = 16
        intNumber += 8
        MessageBox.Show("Addition test. " & intNumber.ToString,
            "Integer Math")

        'Set number, subtract numbers, and display results
        intNumber = 24
        intNumber -= 2
        MessageBox.Show("Subtraction test. " & intNumber.ToString,
            "Integer Math")

        'Set number, multiply numbers, and display results
        intNumber = 6
        intNumber *= 10
        MessageBox.Show("Multiplication test. " & intNumber.ToString,
            "Integer Math")

        'Set number, divide numbers, and display results
        intNumber = 12
        intNumber = CType(intNumber / 6, Integer)
        MessageBox.Show("Division test. " & intNumber.ToString,
            "Integer Math")
    End Sub

    Private Sub btnFloatMath_Click(sender As Object,
                e As EventArgs) Handles btnFloatMath.Click

        'Declare variable
        Dim dblNumber As Double

        'Set number, multiply numbers, and display results
        dblNumber = 45.34
        dblNumber *= 4.333
        MessageBox.Show("Multiplication test. " & dblNumber.ToString,
            "Floating Points")

        'Set number, divide numbers, and display results
        dblNumber = 12
        dblNumber /= 7
        MessageBox.Show("Division test. " & dblNumber.ToString,
            "Floating Points")
    End Sub

    Private Sub btnStrings_Click(sender As Object,
                e As EventArgs) Handles btnStrings.Click

        'Declare variable
        Dim strResults As String

        'Set the string value
        strResults = "Hello World!"

        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub

    Private Sub btnConcatenation_Click(sender As Object,
                e As EventArgs) Handles btnConcatenation.Click

        'Declare variables
        Dim strResults As String
        Dim strOne As String
        Dim strTwo As String

        'Set the string values
        strOne = "Hello"
        strTwo = " World!"

        'Concatenate the strings
        strResults = strOne & strTwo

        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub


End Class
