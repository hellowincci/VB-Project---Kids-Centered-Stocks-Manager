<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllStocksForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvStocksList = New System.Windows.Forms.DataGridView()
        Me.StockSymbolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePurchasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricepershareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberofsharesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EarningPotentialRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksDataSet = New Kids_Centered_Stocks_Manager.vb.stocksDataSet()
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksTableAdapter = New Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.StocksTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuAllStocksFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAllStocksFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAllStocksFileClose = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvStocksList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStocksList
        '
        Me.dgvStocksList.AllowUserToOrderColumns = True
        Me.dgvStocksList.AutoGenerateColumns = False
        Me.dgvStocksList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvStocksList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStocksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocksList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockSymbolDataGridViewTextBoxColumn, Me.StockNameDataGridViewTextBoxColumn, Me.DatePurchasedDataGridViewTextBoxColumn, Me.PricepershareDataGridViewTextBoxColumn, Me.NumberofsharesDataGridViewTextBoxColumn, Me.EarningPotentialRatingDataGridViewTextBoxColumn})
        Me.dgvStocksList.DataSource = Me.StocksBindingSource1
        Me.dgvStocksList.Location = New System.Drawing.Point(12, 27)
        Me.dgvStocksList.Name = "dgvStocksList"
        Me.dgvStocksList.Size = New System.Drawing.Size(702, 417)
        Me.dgvStocksList.TabIndex = 0
        '
        'StockSymbolDataGridViewTextBoxColumn
        '
        Me.StockSymbolDataGridViewTextBoxColumn.DataPropertyName = "Stock_Symbol"
        Me.StockSymbolDataGridViewTextBoxColumn.HeaderText = "Stock_Symbol"
        Me.StockSymbolDataGridViewTextBoxColumn.Name = "StockSymbolDataGridViewTextBoxColumn"
        '
        'StockNameDataGridViewTextBoxColumn
        '
        Me.StockNameDataGridViewTextBoxColumn.DataPropertyName = "Stock_Name"
        Me.StockNameDataGridViewTextBoxColumn.HeaderText = "Stock_Name"
        Me.StockNameDataGridViewTextBoxColumn.Name = "StockNameDataGridViewTextBoxColumn"
        '
        'DatePurchasedDataGridViewTextBoxColumn
        '
        Me.DatePurchasedDataGridViewTextBoxColumn.DataPropertyName = "Date_Purchased"
        Me.DatePurchasedDataGridViewTextBoxColumn.HeaderText = "Date_Purchased"
        Me.DatePurchasedDataGridViewTextBoxColumn.Name = "DatePurchasedDataGridViewTextBoxColumn"
        '
        'PricepershareDataGridViewTextBoxColumn
        '
        Me.PricepershareDataGridViewTextBoxColumn.DataPropertyName = "Price_per_share"
        Me.PricepershareDataGridViewTextBoxColumn.HeaderText = "Price_per_share"
        Me.PricepershareDataGridViewTextBoxColumn.Name = "PricepershareDataGridViewTextBoxColumn"
        '
        'NumberofsharesDataGridViewTextBoxColumn
        '
        Me.NumberofsharesDataGridViewTextBoxColumn.DataPropertyName = "Number_of_shares"
        Me.NumberofsharesDataGridViewTextBoxColumn.HeaderText = "Number_of_shares"
        Me.NumberofsharesDataGridViewTextBoxColumn.Name = "NumberofsharesDataGridViewTextBoxColumn"
        '
        'EarningPotentialRatingDataGridViewTextBoxColumn
        '
        Me.EarningPotentialRatingDataGridViewTextBoxColumn.DataPropertyName = "Earning_Potential_Rating"
        Me.EarningPotentialRatingDataGridViewTextBoxColumn.HeaderText = "Earning_Potential_Rating"
        Me.EarningPotentialRatingDataGridViewTextBoxColumn.Name = "EarningPotentialRatingDataGridViewTextBoxColumn"
        '
        'StocksBindingSource1
        '
        Me.StocksBindingSource1.DataMember = "Stocks"
        Me.StocksBindingSource1.DataSource = Me.StocksDataSet
        '
        'StocksDataSet
        '
        Me.StocksDataSet.DataSetName = "stocksDataSet"
        Me.StocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "Stocks"
        Me.StocksBindingSource.DataSource = Me.StocksDataSet
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAllStocksFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuAllStocksFile
        '
        Me.mnuAllStocksFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAllStocksFileSave, Me.mnuAllStocksFileClose})
        Me.mnuAllStocksFile.Name = "mnuAllStocksFile"
        Me.mnuAllStocksFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuAllStocksFile.Text = "&File"
        '
        'mnuAllStocksFileSave
        '
        Me.mnuAllStocksFileSave.Name = "mnuAllStocksFileSave"
        Me.mnuAllStocksFileSave.Size = New System.Drawing.Size(185, 22)
        Me.mnuAllStocksFileSave.Text = "&Save Changes"
        '
        'mnuAllStocksFileClose
        '
        Me.mnuAllStocksFileClose.Name = "mnuAllStocksFileClose"
        Me.mnuAllStocksFileClose.Size = New System.Drawing.Size(185, 22)
        Me.mnuAllStocksFileClose.Text = "&Closing without Save"
        '
        'AllStocksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 437)
        Me.Controls.Add(Me.dgvStocksList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "AllStocksForm"
        Me.Text = "Stocks List"
        CType(Me.dgvStocksList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvStocksList As System.Windows.Forms.DataGridView
    Friend WithEvents StocksDataSet As Kids_Centered_Stocks_Manager.vb.stocksDataSet
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.StocksTableAdapter
    Friend WithEvents StockSymbolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePurchasedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PricepershareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberofsharesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EarningPotentialRatingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StocksBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAllStocksFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAllStocksFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAllStocksFileClose As System.Windows.Forms.ToolStripMenuItem
End Class
