<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Occupants_Details_and_Room_Number
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim RoomLabel As System.Windows.Forms.Label
        Dim ID_TypeLabel As System.Windows.Forms.Label
        Dim ID_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Occupants_Details_and_Room_Number))
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnVisitors = New System.Windows.Forms.Button()
        Me.btnAvailable = New System.Windows.Forms.Button()
        Me.btnTypesOfRooms = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.DB_Hostel_Management_System_1DataSet = New Hostel_Management_System.DB_Hostel_Management_System_1DataSet()
        Me.Occupants_Details_and__Room_NumbersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Occupants_Details_and__Room_NumbersTableAdapter = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.Occupants_Details_and__Room_NumbersTableAdapter()
        Me.TableAdapterManager = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager()
        Me.Occupants_Details_and__Room_NumbersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.ID_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.ID_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Occupants_Details_and__Room_NumbersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        IDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        ID_TypeLabel = New System.Windows.Forms.Label()
        ID_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Occupants_Details_and__Room_NumbersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Occupants_Details_and__Room_NumbersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.SuspendLayout()
        CType(Me.Occupants_Details_and__Room_NumbersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.Info
        IDLabel.Location = New System.Drawing.Point(16, 32)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 17)
        IDLabel.TabIndex = 10
        IDLabel.Text = "ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.ForeColor = System.Drawing.SystemColors.Info
        FirstNameLabel.Location = New System.Drawing.Point(16, 71)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(86, 17)
        FirstNameLabel.TabIndex = 12
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.ForeColor = System.Drawing.SystemColors.Info
        LastNameLabel.Location = New System.Drawing.Point(16, 108)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(84, 17)
        LastNameLabel.TabIndex = 14
        LastNameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.SystemColors.Info
        GenderLabel.Location = New System.Drawing.Point(16, 143)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(62, 17)
        GenderLabel.TabIndex = 16
        GenderLabel.Text = "Gender:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.ForeColor = System.Drawing.SystemColors.Info
        DOBLabel.Location = New System.Drawing.Point(16, 183)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(47, 17)
        DOBLabel.TabIndex = 18
        DOBLabel.Text = "DOB:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.ForeColor = System.Drawing.SystemColors.Info
        CountryLabel.Location = New System.Drawing.Point(16, 223)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(66, 17)
        CountryLabel.TabIndex = 20
        CountryLabel.Text = "Country:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.ForeColor = System.Drawing.SystemColors.Info
        ContactLabel.Location = New System.Drawing.Point(16, 267)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(64, 17)
        ContactLabel.TabIndex = 22
        ContactLabel.Text = "Contact:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.Info
        EmailLabel.Location = New System.Drawing.Point(16, 308)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(50, 17)
        EmailLabel.TabIndex = 24
        EmailLabel.Text = "Email:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RoomLabel.ForeColor = System.Drawing.SystemColors.Info
        RoomLabel.Location = New System.Drawing.Point(16, 348)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(52, 17)
        RoomLabel.TabIndex = 26
        RoomLabel.Text = "Room:"
        '
        'ID_TypeLabel
        '
        ID_TypeLabel.AutoSize = True
        ID_TypeLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_TypeLabel.ForeColor = System.Drawing.SystemColors.Info
        ID_TypeLabel.Location = New System.Drawing.Point(16, 392)
        ID_TypeLabel.Name = "ID_TypeLabel"
        ID_TypeLabel.Size = New System.Drawing.Size(66, 17)
        ID_TypeLabel.TabIndex = 28
        ID_TypeLabel.Text = "ID Type:"
        '
        'ID_NumberLabel
        '
        ID_NumberLabel.AutoSize = True
        ID_NumberLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_NumberLabel.ForeColor = System.Drawing.SystemColors.Info
        ID_NumberLabel.Location = New System.Drawing.Point(16, 443)
        ID_NumberLabel.Name = "ID_NumberLabel"
        ID_NumberLabel.Size = New System.Drawing.Size(87, 17)
        ID_NumberLabel.TabIndex = 30
        ID_NumberLabel.Text = "ID Number:"
        '
        'btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(1011, 543)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(262, 36)
        Me.btnEmployees.TabIndex = 4
        Me.btnEmployees.Text = "Employees_Details"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnVisitors
        '
        Me.btnVisitors.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitors.Location = New System.Drawing.Point(1011, 584)
        Me.btnVisitors.Name = "btnVisitors"
        Me.btnVisitors.Size = New System.Drawing.Size(125, 35)
        Me.btnVisitors.TabIndex = 5
        Me.btnVisitors.Text = "Visitor_Details"
        Me.btnVisitors.UseVisualStyleBackColor = True
        '
        'btnAvailable
        '
        Me.btnAvailable.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailable.Location = New System.Drawing.Point(1142, 584)
        Me.btnAvailable.Name = "btnAvailable"
        Me.btnAvailable.Size = New System.Drawing.Size(131, 35)
        Me.btnAvailable.TabIndex = 6
        Me.btnAvailable.Text = "Available Rooms"
        Me.btnAvailable.UseVisualStyleBackColor = True
        '
        'btnTypesOfRooms
        '
        Me.btnTypesOfRooms.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTypesOfRooms.Location = New System.Drawing.Point(1011, 498)
        Me.btnTypesOfRooms.Name = "btnTypesOfRooms"
        Me.btnTypesOfRooms.Size = New System.Drawing.Size(262, 39)
        Me.btnTypesOfRooms.TabIndex = 7
        Me.btnTypesOfRooms.Text = "Types of Rooms and Prices"
        Me.btnTypesOfRooms.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(637, 539)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(104, 31)
        Me.btnCommit.TabIndex = 9
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'DB_Hostel_Management_System_1DataSet
        '
        Me.DB_Hostel_Management_System_1DataSet.DataSetName = "DB_Hostel_Management_System_1DataSet"
        Me.DB_Hostel_Management_System_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Occupants_Details_and__Room_NumbersBindingSource
        '
        Me.Occupants_Details_and__Room_NumbersBindingSource.DataMember = "Occupants_Details_and__Room_Numbers"
        Me.Occupants_Details_and__Room_NumbersBindingSource.DataSource = Me.DB_Hostel_Management_System_1DataSet
        '
        'Occupants_Details_and__Room_NumbersTableAdapter
        '
        Me.Occupants_Details_and__Room_NumbersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_RoomsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employees__DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Occupants_Details_and__Room_NumbersTableAdapter = Me.Occupants_Details_and__Room_NumbersTableAdapter
        Me.TableAdapterManager.Types_of_Rooms_and_PricesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisitorsTableAdapter = Nothing
        '
        'Occupants_Details_and__Room_NumbersBindingNavigator
        '
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.BindingSource = Me.Occupants_Details_and__Room_NumbersBindingSource
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1})
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.Name = "Occupants_Details_and__Room_NumbersBindingNavigator"
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.Size = New System.Drawing.Size(1287, 25)
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.TabIndex = 10
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.Text = "BindingNavigator1"
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
        'Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem
        '
        Me.Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem.Image = CType(resources.GetObject("Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem.Name = "Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem"
        Me.Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.IDTextBox.Location = New System.Drawing.Point(114, 30)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IDTextBox.TabIndex = 11
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.FirstNameTextBox.Location = New System.Drawing.Point(114, 69)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.FirstNameTextBox.TabIndex = 13
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.LastNameTextBox.Location = New System.Drawing.Point(114, 104)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.LastNameTextBox.TabIndex = 15
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.GenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.GenderTextBox.Location = New System.Drawing.Point(114, 141)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 21)
        Me.GenderTextBox.TabIndex = 17
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Occupants_Details_and__Room_NumbersBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(114, 180)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.DOBDateTimePicker.TabIndex = 19
        '
        'CountryTextBox
        '
        Me.CountryTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.CountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "Country", True))
        Me.CountryTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.CountryTextBox.Location = New System.Drawing.Point(114, 221)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 21)
        Me.CountryTextBox.TabIndex = 21
        '
        'ContactTextBox
        '
        Me.ContactTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "Contact", True))
        Me.ContactTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.ContactTextBox.Location = New System.Drawing.Point(114, 265)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 21)
        Me.ContactTextBox.TabIndex = 23
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.EmailTextBox.Location = New System.Drawing.Point(114, 306)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 21)
        Me.EmailTextBox.TabIndex = 25
        '
        'RoomTextBox
        '
        Me.RoomTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.RoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "Room", True))
        Me.RoomTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.RoomTextBox.Location = New System.Drawing.Point(114, 346)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(200, 21)
        Me.RoomTextBox.TabIndex = 27
        '
        'ID_TypeTextBox
        '
        Me.ID_TypeTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ID_TypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "ID Type", True))
        Me.ID_TypeTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_TypeTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.ID_TypeTextBox.Location = New System.Drawing.Point(114, 390)
        Me.ID_TypeTextBox.Name = "ID_TypeTextBox"
        Me.ID_TypeTextBox.Size = New System.Drawing.Size(200, 21)
        Me.ID_TypeTextBox.TabIndex = 29
        '
        'ID_NumberTextBox
        '
        Me.ID_NumberTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ID_NumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Occupants_Details_and__Room_NumbersBindingSource, "ID Number", True))
        Me.ID_NumberTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_NumberTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.ID_NumberTextBox.Location = New System.Drawing.Point(114, 441)
        Me.ID_NumberTextBox.Name = "ID_NumberTextBox"
        Me.ID_NumberTextBox.Size = New System.Drawing.Size(200, 21)
        Me.ID_NumberTextBox.TabIndex = 31
        '
        'Occupants_Details_and__Room_NumbersDataGridView
        '
        Me.Occupants_Details_and__Room_NumbersDataGridView.AutoGenerateColumns = False
        Me.Occupants_Details_and__Room_NumbersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Occupants_Details_and__Room_NumbersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Occupants_Details_and__Room_NumbersDataGridView.DataSource = Me.Occupants_Details_and__Room_NumbersBindingSource
        Me.Occupants_Details_and__Room_NumbersDataGridView.Location = New System.Drawing.Point(471, 14)
        Me.Occupants_Details_and__Room_NumbersDataGridView.Name = "Occupants_Details_and__Room_NumbersDataGridView"
        Me.Occupants_Details_and__Room_NumbersDataGridView.Size = New System.Drawing.Size(802, 467)
        Me.Occupants_Details_and__Room_NumbersDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contact"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Room"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Room"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ID Type"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID Type"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID Number"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID Number"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnLast)
        Me.Panel1.Controls.Add(Me.btnfirst)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAddNew)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnAvailable)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.btnCommit)
        Me.Panel1.Controls.Add(Me.Occupants_Details_and__Room_NumbersDataGridView)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.btnTypesOfRooms)
        Me.Panel1.Controls.Add(FirstNameLabel)
        Me.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.Panel1.Controls.Add(Me.btnVisitors)
        Me.Panel1.Controls.Add(LastNameLabel)
        Me.Panel1.Controls.Add(Me.btnEmployees)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(Me.ID_NumberTextBox)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Controls.Add(ID_NumberLabel)
        Me.Panel1.Controls.Add(Me.GenderTextBox)
        Me.Panel1.Controls.Add(Me.ID_TypeTextBox)
        Me.Panel1.Controls.Add(DOBLabel)
        Me.Panel1.Controls.Add(ID_TypeLabel)
        Me.Panel1.Controls.Add(Me.DOBDateTimePicker)
        Me.Panel1.Controls.Add(Me.RoomTextBox)
        Me.Panel1.Controls.Add(CountryLabel)
        Me.Panel1.Controls.Add(RoomLabel)
        Me.Panel1.Controls.Add(Me.CountryTextBox)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(ContactLabel)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.ContactTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 626)
        Me.Panel1.TabIndex = 33
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(217, 564)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(97, 28)
        Me.btnLast.TabIndex = 37
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.Location = New System.Drawing.Point(93, 564)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(97, 28)
        Me.btnfirst.TabIndex = 36
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(576, 576)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 30)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(526, 537)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(84, 30)
        Me.btnAddNew.TabIndex = 34
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(217, 519)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(97, 28)
        Me.btnNext.TabIndex = 33
        Me.btnNext.Text = "Next  >>|"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(84, 519)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(117, 30)
        Me.btnPrevious.TabIndex = 32
        Me.btnPrevious.Text = "Previous |<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripLabel1.Text = "Sreach Room Number"
        '
        'Occupants_Details_and_Room_Number
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 657)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Occupants_Details_and__Room_NumbersBindingNavigator)
        Me.Name = "Occupants_Details_and_Room_Number"
        Me.Text = "Occupants_Details_and_Room_Number"
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Occupants_Details_and__Room_NumbersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Occupants_Details_and__Room_NumbersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.ResumeLayout(False)
        Me.Occupants_Details_and__Room_NumbersBindingNavigator.PerformLayout()
        CType(Me.Occupants_Details_and__Room_NumbersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnVisitors As Button
    Friend WithEvents btnAvailable As Button
    Friend WithEvents btnTypesOfRooms As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents DB_Hostel_Management_System_1DataSet As DB_Hostel_Management_System_1DataSet
    Friend WithEvents Occupants_Details_and__Room_NumbersBindingSource As BindingSource
    Friend WithEvents Occupants_Details_and__Room_NumbersTableAdapter As DB_Hostel_Management_System_1DataSetTableAdapters.Occupants_Details_and__Room_NumbersTableAdapter
    Friend WithEvents TableAdapterManager As DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Occupants_Details_and__Room_NumbersBindingNavigator As BindingNavigator
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
    Friend WithEvents Occupants_Details_and__Room_NumbersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents ID_TypeTextBox As TextBox
    Friend WithEvents ID_NumberTextBox As TextBox
    Friend WithEvents Occupants_Details_and__Room_NumbersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
