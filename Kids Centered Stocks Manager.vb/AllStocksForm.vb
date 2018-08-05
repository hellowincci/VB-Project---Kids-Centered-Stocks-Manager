Public Class AllStocksForm
    'Programmer : Go Wen Xi
    'Project Title : Kids Centered Stocks Manager
    'Purpose : To manage stocks

    'Declare the variables
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim inc As Integer
    Private Sub AddStocksForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StocksDataSet.Stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.StocksDataSet.Stocks)
        'Set connection string
        dbProvider = "PROVIDER=Microsoft.Jet.Oledb.4.0;"
        dbSource = "Data Source=stocks.mdb"

        con.ConnectionString = dbProvider & dbSource

        'Open connection
        con.Open()

        sql = "SELECT * FROM Stocks"

        'Set data Adapter
        da = New OleDb.OleDbDataAdapter(sql, con)

        'Filling the dataset
        da.Fill(ds, "Stocks")

        con.Close()

        inc = 0
    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAllStocksFileSave.Click
        'Declare the variable
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        'Update record to dataset
        Try
            Me.StocksBindingSource.EndEdit()
            Me.StocksTableAdapter.Update(StocksDataSet.Stocks)
            MessageBox.Show("Data updated")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error:" & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mnuAllStocksFileClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAllStocksFileClose.Click
        'Close the program
        Me.Close()
    End Sub

    Private Sub dgvStocksList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStocksList.CellContentClick
        'Enable edit at the stock list
        Me.StocksTableAdapter.Update(Me.StocksDataSet.Stocks)

    End Sub
End Class