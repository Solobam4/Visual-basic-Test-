<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Types_of_Rooms_and_Prices
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim RoomLabel As System.Windows.Forms.Label
        Dim Type_of_RoomLabel As System.Windows.Forms.Label
        Dim PricesLabel As System.Windows.Forms.Label
        Dim Per_personLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Types_of_Rooms_and_Prices))
        Me.btnOccupants = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnVisitors = New System.Windows.Forms.Button()
        Me.btnAvailable = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.DB_Hostel_Management_System_1DataSet = New Hostel_Management_System.DB_Hostel_Management_System_1DataSet()
        Me.Types_of_Rooms_and_PricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Types_of_Rooms_and_PricesTableAdapter = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.Types_of_Rooms_and_PricesTableAdapter()
        Me.TableAdapterManager = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager()
        Me.Types_of_Rooms_and_PricesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Types_of_Rooms_and_PricesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.Type_of_RoomTextBox = New System.Windows.Forms.TextBox()
        Me.PricesTextBox = New System.Windows.Forms.TextBox()
        Me.Per_personTextBox = New System.Windows.Forms.TextBox()
        Me.Types_of_Rooms_and_PricesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        Type_of_RoomLabel = New System.Windows.Forms.Label()
        PricesLabel = New System.Windows.Forms.Label()
        Per_personLabel = New System.Windows.Forms.Label()
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Types_of_Rooms_and_PricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Types_of_Rooms_and_PricesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Types_of_Rooms_and_PricesBindingNavigator.SuspendLayout()
        CType(Me.Types_of_Rooms_and_PricesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.Info
        IDLabel.Location = New System.Drawing.Point(21, 66)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 17)
        IDLabel.TabIndex = 21
        IDLabel.Text = "ID:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RoomLabel.ForeColor = System.Drawing.SystemColors.Info
        RoomLabel.Location = New System.Drawing.Point(21, 106)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(52, 17)
        RoomLabel.TabIndex = 23
        RoomLabel.Text = "Room:"
        '
        'Type_of_RoomLabel
        '
        Type_of_RoomLabel.AutoSize = True
        Type_of_RoomLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Type_of_RoomLabel.ForeColor = System.Drawing.SystemColors.Info
        Type_of_RoomLabel.Location = New System.Drawing.Point(21, 142)
        Type_of_RoomLabel.Name = "Type_of_RoomLabel"
        Type_of_RoomLabel.Size = New System.Drawing.Size(104, 17)
        Type_of_RoomLabel.TabIndex = 25
        Type_of_RoomLabel.Text = "Type of Room:"
        '
        'PricesLabel
        '
        PricesLabel.AutoSize = True
        PricesLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PricesLabel.ForeColor = System.Drawing.SystemColors.Info
        PricesLabel.Location = New System.Drawing.Point(21, 179)
        PricesLabel.Name = "PricesLabel"
        PricesLabel.Size = New System.Drawing.Size(54, 17)
        PricesLabel.TabIndex = 27
        PricesLabel.Text = "Prices:"
        '
        'Per_personLabel
        '
        Per_personLabel.AutoSize = True
        Per_personLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Per_personLabel.ForeColor = System.Drawing.SystemColors.Info
        Per_personLabel.Location = New System.Drawing.Point(21, 217)
        Per_personLabel.Name = "Per_personLabel"
        Per_personLabel.Size = New System.Drawing.Size(85, 17)
        Per_personLabel.TabIndex = 29
        Per_personLabel.Text = "Per-person:"
        '
        'btnOccupants
        '
        Me.btnOccupants.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOccupants.Location = New System.Drawing.Point(934, 503)
        Me.btnOccupants.Name = "btnOccupants"
        Me.btnOccupants.Size = New System.Drawing.Size(339, 32)
        Me.btnOccupants.TabIndex = 15
        Me.btnOccupants.Text = "        Occupants_Details_and_Room_Number"
        Me.btnOccupants.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(934, 541)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(339, 35)
        Me.btnEmployees.TabIndex = 16
        Me.btnEmployees.Text = "Employee_Details"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnVisitors
        '
        Me.btnVisitors.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitors.Location = New System.Drawing.Point(1141, 582)
        Me.btnVisitors.Name = "btnVisitors"
        Me.btnVisitors.Size = New System.Drawing.Size(132, 33)
        Me.btnVisitors.TabIndex = 17
        Me.btnVisitors.Text = "Visitors_Details"
        Me.btnVisitors.UseVisualStyleBackColor = True
        '
        'btnAvailable
        '
        Me.btnAvailable.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailable.Location = New System.Drawing.Point(957, 582)
        Me.btnAvailable.Name = "btnAvailable"
        Me.btnAvailable.Size = New System.Drawing.Size(148, 33)
        Me.btnAvailable.TabIndex = 18
        Me.btnAvailable.Text = "Availabe_Rooms"
        Me.btnAvailable.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(599, 503)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(90, 32)
        Me.btnCommit.TabIndex = 20
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'DB_Hostel_Management_System_1DataSet
        '
        Me.DB_Hostel_Management_System_1DataSet.DataSetName = "DB_Hostel_Management_System_1DataSet"
        Me.DB_Hostel_Management_System_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Types_of_Rooms_and_PricesBindingSource
        '
        Me.Types_of_Rooms_and_PricesBindingSource.DataMember = "Types of Rooms and Prices"
        Me.Types_of_Rooms_and_PricesBindingSource.DataSource = Me.DB_Hostel_Management_System_1DataSet
        '
        'Types_of_Rooms_and_PricesTableAdapter
        '
        Me.Types_of_Rooms_and_PricesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_RoomsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employees__DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Occupants_Details_and__Room_NumbersTableAdapter = Nothing
        Me.TableAdapterManager.Types_of_Rooms_and_PricesTableAdapter = Me.Types_of_Rooms_and_PricesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisitorsTableAdapter = Nothing
        '
        'Types_of_Rooms_and_PricesBindingNavigator
        '
        Me.Types_of_Rooms_and_PricesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.BindingSource = Me.Types_of_Rooms_and_PricesBindingSource
        Me.Types_of_Rooms_and_PricesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Types_of_Rooms_and_PricesBindingNavigatorSaveItem})
        Me.Types_of_Rooms_and_PricesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Types_of_Rooms_and_PricesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.Name = "Types_of_Rooms_and_PricesBindingNavigator"
        Me.Types_of_Rooms_and_PricesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Types_of_Rooms_and_PricesBindingNavigator.Size = New System.Drawing.Size(1287, 25)
        Me.Types_of_Rooms_and_PricesBindingNavigator.TabIndex = 21
        Me.Types_of_Rooms_and_PricesBindingNavigator.Text = "BindingNavigator1"
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
        'Types_of_Rooms_and_PricesBindingNavigatorSaveItem
        '
        Me.Types_of_Rooms_and_PricesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Types_of_Rooms_and_PricesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Types_of_Rooms_and_PricesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Types_of_Rooms_and_PricesBindingNavigatorSaveItem.Name = "Types_of_Rooms_and_PricesBindingNavigatorSaveItem"
        Me.Types_of_Rooms_and_PricesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Types_of_Rooms_and_PricesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Types_of_Rooms_and_PricesBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.IDTextBox.Location = New System.Drawing.Point(170, 63)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IDTextBox.TabIndex = 22
        '
        'RoomTextBox
        '
        Me.RoomTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.RoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Types_of_Rooms_and_PricesBindingSource, "Room", True))
        Me.RoomTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.RoomTextBox.Location = New System.Drawing.Point(170, 103)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RoomTextBox.TabIndex = 24
        '
        'Type_of_RoomTextBox
        '
        Me.Type_of_RoomTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Type_of_RoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Type_of_RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Types_of_Rooms_and_PricesBindingSource, "Type of Room", True))
        Me.Type_of_RoomTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type_of_RoomTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Type_of_RoomTextBox.Location = New System.Drawing.Point(170, 139)
        Me.Type_of_RoomTextBox.Name = "Type_of_RoomTextBox"
        Me.Type_of_RoomTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Type_of_RoomTextBox.TabIndex = 26
        '
        'PricesTextBox
        '
        Me.PricesTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.PricesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PricesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Types_of_Rooms_and_PricesBindingSource, "Prices", True))
        Me.PricesTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PricesTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.PricesTextBox.Location = New System.Drawing.Point(170, 176)
        Me.PricesTextBox.Name = "PricesTextBox"
        Me.PricesTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PricesTextBox.TabIndex = 28
        '
        'Per_personTextBox
        '
        Me.Per_personTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Per_personTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Per_personTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Types_of_Rooms_and_PricesBindingSource, "Per-person", True))
        Me.Per_personTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Per_personTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Per_personTextBox.Location = New System.Drawing.Point(170, 214)
        Me.Per_personTextBox.Name = "Per_personTextBox"
        Me.Per_personTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Per_personTextBox.TabIndex = 30
        '
        'Types_of_Rooms_and_PricesDataGridView
        '
        Me.Types_of_Rooms_and_PricesDataGridView.AutoGenerateColumns = False
        Me.Types_of_Rooms_and_PricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Types_of_Rooms_and_PricesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Types_of_Rooms_and_PricesDataGridView.DataSource = Me.Types_of_Rooms_and_PricesBindingSource
        Me.Types_of_Rooms_and_PricesDataGridView.Location = New System.Drawing.Point(482, 43)
        Me.Types_of_Rooms_and_PricesDataGridView.Name = "Types_of_Rooms_and_PricesDataGridView"
        Me.Types_of_Rooms_and_PricesDataGridView.Size = New System.Drawing.Size(791, 369)
        Me.Types_of_Rooms_and_PricesDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Room"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Room"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Type of Room"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type of Room"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Prices"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prices"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Per-person"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Per-person"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnOccupants)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.btnCommit)
        Me.Panel1.Controls.Add(Me.Types_of_Rooms_and_PricesDataGridView)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.btnEmployees)
        Me.Panel1.Controls.Add(RoomLabel)
        Me.Panel1.Controls.Add(Me.btnAvailable)
        Me.Panel1.Controls.Add(Me.RoomTextBox)
        Me.Panel1.Controls.Add(Me.btnVisitors)
        Me.Panel1.Controls.Add(Type_of_RoomLabel)
        Me.Panel1.Controls.Add(Me.PricesTextBox)
        Me.Panel1.Controls.Add(Me.Type_of_RoomTextBox)
        Me.Panel1.Controls.Add(Me.Per_personTextBox)
        Me.Panel1.Controls.Add(PricesLabel)
        Me.Panel1.Controls.Add(Per_personLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 625)
        Me.Panel1.TabIndex = 31
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(37, 462)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(104, 39)
        Me.btnPrevious.TabIndex = 34
        Me.btnPrevious.Text = "Previous  |<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(182, 462)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(104, 39)
        Me.btnNext.TabIndex = 33
        Me.btnNext.Text = "Next >>|"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(482, 503)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 32)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(536, 542)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 34)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Types_of_Rooms_and_Prices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 657)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Types_of_Rooms_and_PricesBindingNavigator)
        Me.Name = "Types_of_Rooms_and_Prices"
        Me.Text = "Types_of_Rooms_and_Prices"
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Types_of_Rooms_and_PricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Types_of_Rooms_and_PricesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Types_of_Rooms_and_PricesBindingNavigator.ResumeLayout(False)
        Me.Types_of_Rooms_and_PricesBindingNavigator.PerformLayout()
        CType(Me.Types_of_Rooms_and_PricesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOccupants As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnVisitors As Button
    Friend WithEvents btnAvailable As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents DB_Hostel_Management_System_1DataSet As DB_Hostel_Management_System_1DataSet
    Friend WithEvents Types_of_Rooms_and_PricesBindingSource As BindingSource
    Friend WithEvents Types_of_Rooms_and_PricesTableAdapter As DB_Hostel_Management_System_1DataSetTableAdapters.Types_of_Rooms_and_PricesTableAdapter
    Friend WithEvents TableAdapterManager As DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Types_of_Rooms_and_PricesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Types_of_Rooms_and_PricesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents Type_of_RoomTextBox As TextBox
    Friend WithEvents PricesTextBox As TextBox
    Friend WithEvents Per_personTextBox As TextBox
    Friend WithEvents Types_of_Rooms_and_PricesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
End Class
