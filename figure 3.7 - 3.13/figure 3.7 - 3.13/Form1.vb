Public Class Form1
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

    Private Sub btnLength_Click(sender As Object,
                e As EventArgs) Handles btnLength.Click

        'Declare variable
        Dim strResults As String

        'Get the text from the TextBox
        strResults = txtString.Text

        'Display the length of the string
        MessageBox.Show(strResults.Length.ToString & " characters(s)",
                        "Strings")
    End Sub

    Private Sub btnSubStrings_Click(sender As Object,
                e As EventArgs) Handles btnSubStrings.Click

        'Declare variable
        Dim strResults As String

        'Get the text from the TextBox
        strResults = txtString.Text

        'Display the first three characters
        MessageBox.Show(strResults.Substring(0, 3), "Strings")

        'Display the middle three characters
        MessageBox.Show(strResults.Substring(3, 3), "Strings")

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

    Private Sub btnReplace_Click(sender As Object,
                e As EventArgs) Handles btnReplace.Click

        'Declare variables
        Dim strData As String
        Dim strResults As String

        'Get the text from the TextBox
        strData = txtString.Text

        'Replace the string occurrence
        strResults = strData.Replace("Hello", "Goodbye")

        'Display the new string
        MessageBox.Show(strResults, "Strings")
    End Sub

    Private Sub btnShowDate_Click(sender As Object,
                e As EventArgs) Handles btnShowDate.Click

        'Declare variable
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        'Display the results
        MessageBox.Show(dteResults.ToString, "Date Demo")

        'Display dates
        MessageBox.Show(dteResults.ToLongDateString, "Date Demo")
        MessageBox.Show(dteResults.ToShortDateString, "Date Demo")

        'Display times
        MessageBox.Show(dteResults.ToLongTimeString, "Date Demo")
        MessageBox.Show(dteResults.ToShortTimeString, "Date Demo")
    End Sub

    Private Sub btnDateProperties_Click(sender As Object,
                e As EventArgs) Handles btnDateProperties.Click

        'Declare variable
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        'Display the various date properties
        MessageBox.Show("Month: " & dteResults.Month, "Date Demo")
        MessageBox.Show("Day: " & dteResults.Day, "Date Demo")
        MessageBox.Show("Year: " & dteResults.Year, "Date Demo")
        MessageBox.Show("Hour: " & dteResults.Hour, "Date Demo")
        MessageBox.Show("Minute: " & dteResults.Minute, "Date Demo")
        MessageBox.Show("Second: " & dteResults.Second, "Date Demo")
        MessageBox.Show("Day of week: " & dteResults.DayOfWeek, "Date Demo")
        MessageBox.Show("Day of year: " & dteResults.DayOfYear, "Date Demo")
    End Sub

    Private Sub btnDateNames_Click(sender As Object,
                e As EventArgs) Handles btnDateNames.Click

        'Declare variable
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now
        MessageBox.Show("Weekday name: " & dteResults.ToString("dddd"), "Date Demo")
        MessageBox.Show("Month name: " & dteResults.ToString("MMMM"), "Date Demo")
    End Sub

    Private Sub btnDateLiterals_Click(sender As Object,
                e As EventArgs) Handles btnDateLiterals.Click

        'Declare variable
        Dim dteResults As Date

        'Set a date and time
        dteResults = #1/1/2010 8:01:00 AM#

        'Display the date and time
        MessageBox.Show(dteResults.ToLongDateString & " " & dteResults.ToLongTimeString, "Date Demo")
    End Sub

    Private Sub btnDateManipulation_Click(sender As Object,
                e As EventArgs) Handles btnDateManipulation.Click

        'Declare variables
        Dim dteStartDate As Date
        Dim dteChangedDate As Date

        'Start in the year 2400
        dteStartDate = #2/28/2400#

        'Add a day and display the results
        dteChangedDate = dteStartDate.AddDays(1)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")

        'Add some months and display the results
        dteChangedDate = dteStartDate.AddMonths(6)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")

        'Subtract a year and display the results
        dteChangedDate = dteStartDate.AddYears(-1)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")
    End Sub
End Class
