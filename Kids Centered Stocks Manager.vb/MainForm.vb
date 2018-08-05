Public Class MainForm
    'Declare the variables
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim inc As Integer
    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'Close the program
        Me.Close()

    End Sub

    Private Sub mnuStocksListAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStocksListAll.Click
        'Create an instance of AllStocksForm
        Dim frmStocksList As New AllStocksForm

        'Display the form
        frmStocksList.ShowDialog()

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Filling the data set
        Me.StocksTableAdapter.Fill(Me.StocksDataSet.Stocks)
    End Sub

    Private Sub mnuStocksAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStocksAddNew.Click
        'Create an instance of AddStocksForm
        Dim frmAddStocks As New AddNewStockForm

        'Display the form
        frmAddStocks.ShowDialog()
    End Sub

    Private Sub mnuComputeTotalInvestment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuComputeTotalInvestment.Click
        'Declare variables
        Dim decTotalInvestment As Decimal
        Dim rows As stocksDataSet.StocksRow

        'Calculate the total investment
        For Each rows In Me.StocksDataSet.Stocks.Rows
            decTotalInvestment += rows.Price_per_share * rows.Number_of_shares
        Next
        'Display the total investment
        MessageBox.Show("Total investment is " & decTotalInvestment.ToString("C"))


    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub
End Class
