<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Available__Rooms
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
        Dim CapacityLabel As System.Windows.Forms.Label
        Dim Number_Of_OccupantsLabel As System.Windows.Forms.Label
        Dim VacancyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Available__Rooms))
        Me.btnOccupants = New System.Windows.Forms.Button()
        Me.btnVisitors = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnTypes = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.DB_Hostel_Management_System_1DataSet = New Hostel_Management_System.DB_Hostel_Management_System_1DataSet()
        Me.Available_RoomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Available_RoomsTableAdapter = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.Available_RoomsTableAdapter()
        Me.TableAdapterManager = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager()
        Me.Available_RoomsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Available_RoomsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.CapacityTextBox = New System.Windows.Forms.TextBox()
        Me.Number_Of_OccupantsTextBox = New System.Windows.Forms.TextBox()
        Me.VacancyTextBox = New System.Windows.Forms.TextBox()
        Me.Available_RoomsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        CapacityLabel = New System.Windows.Forms.Label()
        Number_Of_OccupantsLabel = New System.Windows.Forms.Label()
        VacancyLabel = New System.Windows.Forms.Label()
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Available_RoomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Available_RoomsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Available_RoomsBindingNavigator.SuspendLayout()
        CType(Me.Available_RoomsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.Info
        IDLabel.Location = New System.Drawing.Point(24, 101)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 17)
        IDLabel.TabIndex = 12
        IDLabel.Text = "ID:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RoomLabel.ForeColor = System.Drawing.SystemColors.Info
        RoomLabel.Location = New System.Drawing.Point(24, 144)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(52, 17)
        RoomLabel.TabIndex = 14
        RoomLabel.Text = "Room:"
        '
        'CapacityLabel
        '
        CapacityLabel.AutoSize = True
        CapacityLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CapacityLabel.ForeColor = System.Drawing.SystemColors.Info
        CapacityLabel.Location = New System.Drawing.Point(24, 180)
        CapacityLabel.Name = "CapacityLabel"
        CapacityLabel.Size = New System.Drawing.Size(69, 17)
        CapacityLabel.TabIndex = 16
        CapacityLabel.Text = "Capacity:"
        '
        'Number_Of_OccupantsLabel
        '
        Number_Of_OccupantsLabel.AutoSize = True
        Number_Of_OccupantsLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_Of_OccupantsLabel.ForeColor = System.Drawing.SystemColors.Info
        Number_Of_OccupantsLabel.Location = New System.Drawing.Point(24, 222)
        Number_Of_OccupantsLabel.Name = "Number_Of_OccupantsLabel"
        Number_Of_OccupantsLabel.Size = New System.Drawing.Size(159, 17)
        Number_Of_OccupantsLabel.TabIndex = 18
        Number_Of_OccupantsLabel.Text = "Number Of Occupants:"
        '
        'VacancyLabel
        '
        VacancyLabel.AutoSize = True
        VacancyLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VacancyLabel.ForeColor = System.Drawing.SystemColors.Info
        VacancyLabel.Location = New System.Drawing.Point(24, 267)
        VacancyLabel.Name = "VacancyLabel"
        VacancyLabel.Size = New System.Drawing.Size(65, 17)
        VacancyLabel.TabIndex = 20
        VacancyLabel.Text = "Vacancy:"
        '
        'btnOccupants
        '
        Me.btnOccupants.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOccupants.Location = New System.Drawing.Point(969, 500)
        Me.btnOccupants.Name = "btnOccupants"
        Me.btnOccupants.Size = New System.Drawing.Size(294, 34)
        Me.btnOccupants.TabIndex = 5
        Me.btnOccupants.Text = "Occupants_Details_ and_Room_Number"
        Me.btnOccupants.UseVisualStyleBackColor = True
        '
        'btnVisitors
        '
        Me.btnVisitors.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitors.Location = New System.Drawing.Point(969, 580)
        Me.btnVisitors.Name = "btnVisitors"
        Me.btnVisitors.Size = New System.Drawing.Size(131, 34)
        Me.btnVisitors.TabIndex = 6
        Me.btnVisitors.Text = "Vistors_Details"
        Me.btnVisitors.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(1116, 580)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(147, 37)
        Me.btnEmployees.TabIndex = 8
        Me.btnEmployees.Text = "Employees_Details"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnTypes
        '
        Me.btnTypes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTypes.Location = New System.Drawing.Point(969, 540)
        Me.btnTypes.Name = "btnTypes"
        Me.btnTypes.Size = New System.Drawing.Size(294, 34)
        Me.btnTypes.TabIndex = 9
        Me.btnTypes.Text = "Types of Rooms and Prices"
        Me.btnTypes.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(654, 548)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(101, 26)
        Me.btnCommit.TabIndex = 11
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'DB_Hostel_Management_System_1DataSet
        '
        Me.DB_Hostel_Management_System_1DataSet.DataSetName = "DB_Hostel_Management_System_1DataSet"
        Me.DB_Hostel_Management_System_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Available_RoomsBindingSource
        '
        Me.Available_RoomsBindingSource.DataMember = "Available Rooms"
        Me.Available_RoomsBindingSource.DataSource = Me.DB_Hostel_Management_System_1DataSet
        '
        'Available_RoomsTableAdapter
        '
        Me.Available_RoomsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_RoomsTableAdapter = Me.Available_RoomsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employees__DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Occupants_Details_and__Room_NumbersTableAdapter = Nothing
        Me.TableAdapterManager.Types_of_Rooms_and_PricesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisitorsTableAdapter = Nothing
        '
        'Available_RoomsBindingNavigator
        '
        Me.Available_RoomsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Available_RoomsBindingNavigator.BindingSource = Me.Available_RoomsBindingSource
        Me.Available_RoomsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Available_RoomsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Available_RoomsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Available_RoomsBindingNavigatorSaveItem})
        Me.Available_RoomsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Available_RoomsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Available_RoomsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Available_RoomsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Available_RoomsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Available_RoomsBindingNavigator.Name = "Available_RoomsBindingNavigator"
        Me.Available_RoomsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Available_RoomsBindingNavigator.Size = New System.Drawing.Size(1287, 25)
        Me.Available_RoomsBindingNavigator.TabIndex = 12
        Me.Available_RoomsBindingNavigator.Text = "BindingNavigator1"
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
        'Available_RoomsBindingNavigatorSaveItem
        '
        Me.Available_RoomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Available_RoomsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Available_RoomsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Available_RoomsBindingNavigatorSaveItem.Name = "Available_RoomsBindingNavigatorSaveItem"
        Me.Available_RoomsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Available_RoomsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_RoomsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.IDTextBox.Location = New System.Drawing.Point(198, 103)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IDTextBox.TabIndex = 13
        '
        'RoomTextBox
        '
        Me.RoomTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.RoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_RoomsBindingSource, "Room", True))
        Me.RoomTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.RoomTextBox.Location = New System.Drawing.Point(198, 146)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RoomTextBox.TabIndex = 15
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.CapacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CapacityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_RoomsBindingSource, "Capacity", True))
        Me.CapacityTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapacityTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.CapacityTextBox.Location = New System.Drawing.Point(198, 182)
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CapacityTextBox.TabIndex = 17
        '
        'Number_Of_OccupantsTextBox
        '
        Me.Number_Of_OccupantsTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Number_Of_OccupantsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Number_Of_OccupantsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_RoomsBindingSource, "Number_Of_Occupants", True))
        Me.Number_Of_OccupantsTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number_Of_OccupantsTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Number_Of_OccupantsTextBox.Location = New System.Drawing.Point(198, 222)
        Me.Number_Of_OccupantsTextBox.Name = "Number_Of_OccupantsTextBox"
        Me.Number_Of_OccupantsTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Number_Of_OccupantsTextBox.TabIndex = 19
        '
        'VacancyTextBox
        '
        Me.VacancyTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.VacancyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VacancyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_RoomsBindingSource, "Vacancy", True))
        Me.VacancyTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VacancyTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.VacancyTextBox.Location = New System.Drawing.Point(198, 269)
        Me.VacancyTextBox.Name = "VacancyTextBox"
        Me.VacancyTextBox.Size = New System.Drawing.Size(100, 21)
        Me.VacancyTextBox.TabIndex = 21
        '
        'Available_RoomsDataGridView
        '
        Me.Available_RoomsDataGridView.AutoGenerateColumns = False
        Me.Available_RoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Available_RoomsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Available_RoomsDataGridView.DataSource = Me.Available_RoomsBindingSource
        Me.Available_RoomsDataGridView.Location = New System.Drawing.Point(378, 15)
        Me.Available_RoomsDataGridView.Name = "Available_RoomsDataGridView"
        Me.Available_RoomsDataGridView.Size = New System.Drawing.Size(869, 461)
        Me.Available_RoomsDataGridView.TabIndex = 21
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Number_Of_Occupants"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Number_Of_Occupants"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Vacancy"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vacancy"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnAddNew)
        Me.Panel1.Controls.Add(Me.Available_RoomsDataGridView)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.btnCommit)
        Me.Panel1.Controls.Add(Me.btnEmployees)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.btnVisitors)
        Me.Panel1.Controls.Add(RoomLabel)
        Me.Panel1.Controls.Add(Me.btnTypes)
        Me.Panel1.Controls.Add(Me.RoomTextBox)
        Me.Panel1.Controls.Add(Me.btnOccupants)
        Me.Panel1.Controls.Add(CapacityLabel)
        Me.Panel1.Controls.Add(Me.VacancyTextBox)
        Me.Panel1.Controls.Add(Me.CapacityTextBox)
        Me.Panel1.Controls.Add(VacancyLabel)
        Me.Panel1.Controls.Add(Number_Of_OccupantsLabel)
        Me.Panel1.Controls.Add(Me.Number_Of_OccupantsTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 626)
        Me.Panel1.TabIndex = 22
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(27, 504)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(113, 30)
        Me.btnPrevious.TabIndex = 38
        Me.btnPrevious.Text = "Previous |<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(186, 504)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(84, 30)
        Me.btnNext.TabIndex = 37
        Me.btnNext.Text = "Next >>|"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(535, 544)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(95, 30)
        Me.btnAddNew.TabIndex = 35
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(594, 580)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 27)
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Available__Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 657)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Available_RoomsBindingNavigator)
        Me.Name = "Available__Rooms"
        Me.Text = "Available__Rooms"
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Available_RoomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Available_RoomsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Available_RoomsBindingNavigator.ResumeLayout(False)
        Me.Available_RoomsBindingNavigator.PerformLayout()
        CType(Me.Available_RoomsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOccupants As Button
    Friend WithEvents btnVisitors As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnTypes As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents DB_Hostel_Management_System_1DataSet As DB_Hostel_Management_System_1DataSet
    Friend WithEvents Available_RoomsBindingSource As BindingSource
    Friend WithEvents Available_RoomsTableAdapter As DB_Hostel_Management_System_1DataSetTableAdapters.Available_RoomsTableAdapter
    Friend WithEvents TableAdapterManager As DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Available_RoomsBindingNavigator As BindingNavigator
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
    Friend WithEvents Available_RoomsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents CapacityTextBox As TextBox
    Friend WithEvents Number_Of_OccupantsTextBox As TextBox
    Friend WithEvents VacancyTextBox As TextBox
    Friend WithEvents Available_RoomsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
End Class
