<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewStockForm
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
        Dim Stock_SymbolLabel As System.Windows.Forms.Label
        Dim Stock_NameLabel As System.Windows.Forms.Label
        Dim Date_PurchasedLabel As System.Windows.Forms.Label
        Dim Price_per_shareLabel As System.Windows.Forms.Label
        Dim Number_of_sharesLabel As System.Windows.Forms.Label
        Dim Earning_Potential_RatingLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewStockForm))
        Me.StocksDataSet = New Kids_Centered_Stocks_Manager.vb.stocksDataSet()
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksTableAdapter = New Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.StocksTableAdapter()
        Me.TableAdapterManager = New Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.TableAdapterManager()
        Me.StocksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StocksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtStockSymbol = New System.Windows.Forms.TextBox()
        Me.txtStockName = New System.Windows.Forms.TextBox()
        Me.txtDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.txtPricePerShare = New System.Windows.Forms.TextBox()
        Me.txtNumberOfShares = New System.Windows.Forms.TextBox()
        Me.txtEarningPotentialRating = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuAddNewStockFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddNewStockFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddNewStockFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Stock_SymbolLabel = New System.Windows.Forms.Label()
        Stock_NameLabel = New System.Windows.Forms.Label()
        Date_PurchasedLabel = New System.Windows.Forms.Label()
        Price_per_shareLabel = New System.Windows.Forms.Label()
        Number_of_sharesLabel = New System.Windows.Forms.Label()
        Earning_Potential_RatingLabel = New System.Windows.Forms.Label()
        CType(Me.StocksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StocksBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Stock_SymbolLabel
        '
        Stock_SymbolLabel.AutoSize = True
        Stock_SymbolLabel.Location = New System.Drawing.Point(77, 53)
        Stock_SymbolLabel.Name = "Stock_SymbolLabel"
        Stock_SymbolLabel.Size = New System.Drawing.Size(75, 13)
        Stock_SymbolLabel.TabIndex = 1
        Stock_SymbolLabel.Text = "Stock Symbol:"
        '
        'Stock_NameLabel
        '
        Stock_NameLabel.AutoSize = True
        Stock_NameLabel.Location = New System.Drawing.Point(83, 79)
        Stock_NameLabel.Name = "Stock_NameLabel"
        Stock_NameLabel.Size = New System.Drawing.Size(69, 13)
        Stock_NameLabel.TabIndex = 3
        Stock_NameLabel.Text = "Stock Name:"
        '
        'Date_PurchasedLabel
        '
        Date_PurchasedLabel.AutoSize = True
        Date_PurchasedLabel.Location = New System.Drawing.Point(65, 105)
        Date_PurchasedLabel.Name = "Date_PurchasedLabel"
        Date_PurchasedLabel.Size = New System.Drawing.Size(87, 13)
        Date_PurchasedLabel.TabIndex = 5
        Date_PurchasedLabel.Text = "Date Purchased:"
        '
        'Price_per_shareLabel
        '
        Price_per_shareLabel.AutoSize = True
        Price_per_shareLabel.Location = New System.Drawing.Point(71, 131)
        Price_per_shareLabel.Name = "Price_per_shareLabel"
        Price_per_shareLabel.Size = New System.Drawing.Size(81, 13)
        Price_per_shareLabel.TabIndex = 7
        Price_per_shareLabel.Text = "Price per share:"
        '
        'Number_of_sharesLabel
        '
        Number_of_sharesLabel.AutoSize = True
        Number_of_sharesLabel.Location = New System.Drawing.Point(59, 157)
        Number_of_sharesLabel.Name = "Number_of_sharesLabel"
        Number_of_sharesLabel.Size = New System.Drawing.Size(93, 13)
        Number_of_sharesLabel.TabIndex = 9
        Number_of_sharesLabel.Text = "Number of shares:"
        '
        'Earning_Potential_RatingLabel
        '
        Earning_Potential_RatingLabel.AutoSize = True
        Earning_Potential_RatingLabel.Location = New System.Drawing.Point(28, 183)
        Earning_Potential_RatingLabel.Name = "Earning_Potential_RatingLabel"
        Earning_Potential_RatingLabel.Size = New System.Drawing.Size(124, 13)
        Earning_Potential_RatingLabel.TabIndex = 11
        Earning_Potential_RatingLabel.Text = "Earning Potential Rating:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StocksTableAdapter = Me.StocksTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StocksBindingNavigator
        '
        Me.StocksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StocksBindingNavigator.BindingSource = Me.StocksBindingSource
        Me.StocksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StocksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StocksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StocksBindingNavigatorSaveItem})
        Me.StocksBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.StocksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StocksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StocksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StocksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StocksBindingNavigator.Name = "StocksBindingNavigator"
        Me.StocksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StocksBindingNavigator.Size = New System.Drawing.Size(371, 25)
        Me.StocksBindingNavigator.TabIndex = 0
        Me.StocksBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StocksBindingNavigatorSaveItem
        '
        Me.StocksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StocksBindingNavigatorSaveItem.Image = CType(resources.GetObject("StocksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StocksBindingNavigatorSaveItem.Name = "StocksBindingNavigatorSaveItem"
        Me.StocksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StocksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtStockSymbol
        '
        Me.txtStockSymbol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Stock_Symbol", True))
        Me.txtStockSymbol.Location = New System.Drawing.Point(158, 50)
        Me.txtStockSymbol.Name = "txtStockSymbol"
        Me.txtStockSymbol.Size = New System.Drawing.Size(100, 20)
        Me.txtStockSymbol.TabIndex = 2
        '
        'txtStockName
        '
        Me.txtStockName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Stock_Name", True))
        Me.txtStockName.Location = New System.Drawing.Point(158, 77)
        Me.txtStockName.Name = "txtStockName"
        Me.txtStockName.Size = New System.Drawing.Size(100, 20)
        Me.txtStockName.TabIndex = 4
        '
        'txtDatePurchased
        '
        Me.txtDatePurchased.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StocksBindingSource, "Date_Purchased", True))
        Me.txtDatePurchased.Location = New System.Drawing.Point(158, 104)
        Me.txtDatePurchased.Name = "txtDatePurchased"
        Me.txtDatePurchased.Size = New System.Drawing.Size(200, 20)
        Me.txtDatePurchased.TabIndex = 6
        '
        'txtPricePerShare
        '
        Me.txtPricePerShare.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Price_per_share", True))
        Me.txtPricePerShare.Location = New System.Drawing.Point(158, 131)
        Me.txtPricePerShare.Name = "txtPricePerShare"
        Me.txtPricePerShare.Size = New System.Drawing.Size(100, 20)
        Me.txtPricePerShare.TabIndex = 8
        '
        'txtNumberOfShares
        '
        Me.txtNumberOfShares.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Number_of_shares", True))
        Me.txtNumberOfShares.Location = New System.Drawing.Point(158, 158)
        Me.txtNumberOfShares.Name = "txtNumberOfShares"
        Me.txtNumberOfShares.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfShares.TabIndex = 10
        '
        'txtEarningPotentialRating
        '
        Me.txtEarningPotentialRating.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StocksBindingSource, "Earning_Potential_Rating", True))
        Me.txtEarningPotentialRating.Location = New System.Drawing.Point(158, 185)
        Me.txtEarningPotentialRating.Name = "txtEarningPotentialRating"
        Me.txtEarningPotentialRating.Size = New System.Drawing.Size(100, 20)
        Me.txtEarningPotentialRating.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddNewStockFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(371, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuAddNewStockFile
        '
        Me.mnuAddNewStockFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddNewStockFileSave, Me.mnuAddNewStockFileClose})
        Me.mnuAddNewStockFile.Name = "mnuAddNewStockFile"
        Me.mnuAddNewStockFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuAddNewStockFile.Text = "File"
        '
        'mnuAddNewStockFileSave
        '
        Me.mnuAddNewStockFileSave.Name = "mnuAddNewStockFileSave"
        Me.mnuAddNewStockFileSave.Size = New System.Drawing.Size(185, 22)
        Me.mnuAddNewStockFileSave.Text = "&Save and Close"
        '
        'mnuAddNewStockFileClose
        '
        Me.mnuAddNewStockFileClose.Name = "mnuAddNewStockFileClose"
        Me.mnuAddNewStockFileClose.Size = New System.Drawing.Size(185, 22)
        Me.mnuAddNewStockFileClose.Text = "&Closing without Save"
        '
        'AddNewStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 301)
        Me.Controls.Add(Earning_Potential_RatingLabel)
        Me.Controls.Add(Me.txtEarningPotentialRating)
        Me.Controls.Add(Number_of_sharesLabel)
        Me.Controls.Add(Me.txtNumberOfShares)
        Me.Controls.Add(Price_per_shareLabel)
        Me.Controls.Add(Me.txtPricePerShare)
        Me.Controls.Add(Date_PurchasedLabel)
        Me.Controls.Add(Me.txtDatePurchased)
        Me.Controls.Add(Stock_NameLabel)
        Me.Controls.Add(Me.txtStockName)
        Me.Controls.Add(Stock_SymbolLabel)
        Me.Controls.Add(Me.txtStockSymbol)
        Me.Controls.Add(Me.StocksBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AddNewStockForm"
        Me.Text = "Add New Stock"
        CType(Me.StocksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StocksBindingNavigator.ResumeLayout(False)
        Me.StocksBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StocksDataSet As Kids_Centered_Stocks_Manager.vb.stocksDataSet
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.StocksTableAdapter
    Friend WithEvents TableAdapterManager As Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StocksBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StocksBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtStockSymbol As System.Windows.Forms.TextBox
    Friend WithEvents txtStockName As System.Windows.Forms.TextBox
    Friend WithEvents txtDatePurchased As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPricePerShare As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfShares As System.Windows.Forms.TextBox
    Friend WithEvents txtEarningPotentialRating As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAddNewStockFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAddNewStockFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAddNewStockFileClose As System.Windows.Forms.ToolStripMenuItem
End Class
