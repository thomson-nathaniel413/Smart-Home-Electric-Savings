Public Class frmSmartHome
    ' instantiating variables needed globally
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' form load
        ' should read data from the .txt file, and create + populate array

        ' hide statistics button
        btnStats.Visible = False

        ' use this if savings.txt isn't found despite being in the correct location
        ' MsgBox(CurDir())

        ' variable instantiation
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        ' clear contents of labels
        lblSavingsMonthly.Text = ""
        lblSavingsAverage.Text = ""
        lblSavingsBest.Text = ""

        ' attempt to retrieve file and parse data
        Try
            objReader = IO.File.OpenText("..\..\savings.txt")
            ' read file line-by-line
            ' assumes file is formatted with alternating lines of month and savings amount
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()
            ' fill combo box object with input from file
            For intFill = 0 To (_strSavings.Length - 1)
                cboMonths.Items.Add(_strSavings(intFill))
            Next
        Catch exception As IO.FileNotFoundException
            MsgBox("input file not found")
            Close()
        Catch exception As FormatException
            MsgBox("file was improperly formatted")
            Close()
        End Try

    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        ' user changed selected month

        ' variable instantiation
        Dim intSelectedMonthIndex As Integer
        intSelectedMonthIndex = cboMonths.SelectedIndex

        ' display proper output as per selected input
        lblSavingsMonthly.Text = "The electric savings for " & _strSavings(intSelectedMonthIndex) & " is $" & _decBill(intSelectedMonthIndex)

        ' show statistics button
        btnStats.Visible = True
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        ' stats button is clicked
        ComputeAverage()
        ComputeMaxSavings()
    End Sub

    Private Sub ComputeMaxSavings()
        ' function for computing the highest savings amount

        ' variable instantiation
        Dim strCurrentHighest As String = _strSavings(0)
        Dim decCurrentHighest As Decimal = _decBill(0)
        Dim intLoop As Integer

        ' iterate over savings array
        For intLoop = 1 To (_decBill.Length - 1)
            ' if a new max is found...
            If (_decBill(intLoop) > decCurrentHighest) Then
                ' ...set it as current highest
                strCurrentHighest = _strSavings(intLoop)
                decCurrentHighest = _decBill(intLoop)
            End If
        Next

        ' after the for loop, the current highest should be the absolute highest
        lblSavingsBest.Text = strCurrentHighest & " had the highest overall savings."
    End Sub

    Private Sub ComputeAverage()
        ' function for computing the average savings for the year

        ' variable instantiation
        Dim decCurrentSum As Decimal
        Dim intCurrentTally As Integer = 0
        Dim decAverage As Decimal

        ' iterate over savings array
        For intLoop = 0 To (_decBill.Length - 1)
            ' add current savings amount to sum total
            decCurrentSum += _decBill(intLoop)
            ' increment tally
            intCurrentTally += 1
        Next

        ' calculate average
        decAverage = decCurrentSum / Convert.ToDecimal(intCurrentTally)
        ' display average
        lblSavingsAverage.Text = "Average monthly savings were: " & decAverage.ToString("C2")
    End Sub
End Class
