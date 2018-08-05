Public Class AddNewStockForm
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim inc As Integer
    Private Sub StocksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksBindingNavigatorSaveItem.Click
        'Update the data set
        Me.Validate()
        Me.StocksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StocksDataSet)

    End Sub

    Private Sub AddNewStockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StocksDataSet.Stocks' table. You can move, or remove it, as needed.
        'Filling the data set
        Me.StocksTableAdapter.Fill(Me.StocksDataSet.Stocks)

        'Set connectiong string
        dbProvider = "PROVIDER=Microsoft.Jet.Oledb.4.0;"
        dbSource = "Data Source=stocks.mdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the connection
        con.Open()

        'Filling the data set
        sql = "SELECT * FROM Stocks"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Stocks")

        con.Close()

        Me.StocksBindingSource.AddNew()
        txtDatePurchased.Value = Today()

        'Set the inc value
        inc = 0


        If inc <> -1 Then
            'Declare the variables for command builder
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            'Declare the variables for dataset row
            Dim dsNewRow As DataRow

            Try
                Dim decPrice As Decimal
                Dim decNumber As Integer

                decPrice = CDec(txtPricePerShare.Text)
                decNumber = CInt(txtNumberOfShares.Text)

                dsNewRow = ds.Tables("Stocks").NewRow()
                txtPricePerShare.Text = decPrice.ToString()



                dsNewRow.Item("Stock Symbol") = txtStockSymbol.Text
                dsNewRow.Item("Stock Name") = txtStockName.Text
                dsNewRow.Item("Date Purchased") = txtDatePurchased.Text
                dsNewRow.Item("Price per share") = CDec(txtPricePerShare.Text)
                dsNewRow.Item("Number of shares") = CInt(txtNumberOfShares.Text)
                dsNewRow.Item("Earning Potential Rating") = txtEarningPotentialRating.Text

                ds.Tables("Stocks").Rows.Add(dsNewRow)

                da.Update(ds, "Stocks")

                MessageBox.Show("New Record added to the Database")
            Catch ex As InvalidCastException

            End Try

        End If

    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddNewStockFileSave.Click
        Try
            Me.StocksBindingSource.EndEdit()
            Me.StocksTableAdapter.Update(StocksDataSet.Stocks)
            MessageBox.Show("New data added")

        Catch ex As Exception
            MessageBox.Show(Me, "Error:" & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ClosingWithoutSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddNewStockFileClose.Click
        Me.StocksBindingSource.CancelEdit()
        Me.Close()
    End Sub
End Class