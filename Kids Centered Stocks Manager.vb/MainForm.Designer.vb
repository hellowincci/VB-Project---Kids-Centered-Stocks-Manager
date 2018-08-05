<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStocks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStocksAddNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStocksListAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompute = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuComputeTotalInvestment = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksDataSet = New Kids_Centered_Stocks_Manager.vb.stocksDataSet()
        Me.StocksTableAdapter = New Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.StocksTableAdapter()
        Me.TableAdapterManager = New Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(129, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 201)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuStocks, Me.mnuCompute})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuStocks
        '
        Me.mnuStocks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStocksListAll, Me.mnuStocksAddNew})
        Me.mnuStocks.Name = "mnuStocks"
        Me.mnuStocks.Size = New System.Drawing.Size(53, 20)
        Me.mnuStocks.Text = "&Stocks"
        '
        'mnuStocksAddNew
        '
        Me.mnuStocksAddNew.Name = "mnuStocksAddNew"
        Me.mnuStocksAddNew.Size = New System.Drawing.Size(160, 22)
        Me.mnuStocksAddNew.Text = "&Add New Stocks"
        '
        'mnuStocksListAll
        '
        Me.mnuStocksListAll.Name = "mnuStocksListAll"
        Me.mnuStocksListAll.Size = New System.Drawing.Size(160, 22)
        Me.mnuStocksListAll.Text = "&List All"
        '
        'mnuCompute
        '
        Me.mnuCompute.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuComputeTotalInvestment})
        Me.mnuCompute.Name = "mnuCompute"
        Me.mnuCompute.Size = New System.Drawing.Size(69, 20)
        Me.mnuCompute.Text = "&Compute"
        '
        'mnuComputeTotalInvestment
        '
        Me.mnuComputeTotalInvestment.Name = "mnuComputeTotalInvestment"
        Me.mnuComputeTotalInvestment.Size = New System.Drawing.Size(163, 22)
        Me.mnuComputeTotalInvestment.Text = "&Total Investment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kids Centered Stocks Management System 1.0"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.StocksDataSet
        Me.BindingSource1.Position = 0
        '
        'StocksDataSet
        '
        Me.StocksDataSet.DataSetName = "stocksDataSet"
        Me.StocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 281)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kids Centered Stocks Manager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStocks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStocksAddNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStocksListAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuComputeTotalInvestment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StocksDataSet As Kids_Centered_Stocks_Manager.vb.stocksDataSet
    Friend WithEvents StocksTableAdapter As Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.StocksTableAdapter
    Friend WithEvents TableAdapterManager As Kids_Centered_Stocks_Manager.vb.stocksDataSetTableAdapters.TableAdapterManager

End Class
