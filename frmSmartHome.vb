Public Class frmSmartHome
    ' instantiating variables needed globally
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' form load
        ' should read data from the .txt file, and create + populate array

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
    End Sub
End Class
