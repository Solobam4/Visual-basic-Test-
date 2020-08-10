<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visitors_Details
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
        Dim Visitors_FirstNameLabel As System.Windows.Forms.Label
        Dim Visitors_Last_NameLabel As System.Windows.Forms.Label
        Dim Residence_FirstNameLabel As System.Windows.Forms.Label
        Dim Residence__LastNameLabel As System.Windows.Forms.Label
        Dim DayLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim Check_In_TimeLabel As System.Windows.Forms.Label
        Dim Check_Out_TimeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visitors_Details))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnOccupants = New System.Windows.Forms.Button()
        Me.btnAvailable = New System.Windows.Forms.Button()
        Me.btnTypes = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.DB_Hostel_Management_System_1DataSet = New Hostel_Management_System.DB_Hostel_Management_System_1DataSet()
        Me.VisitorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitorsTableAdapter = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.VisitorsTableAdapter()
        Me.TableAdapterManager = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager()
        Me.VisitorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VisitorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.Visitors_FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Visitors_Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Residence_FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Residence__LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Check_In_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Check_Out_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VisitorsDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        Visitors_FirstNameLabel = New System.Windows.Forms.Label()
        Visitors_Last_NameLabel = New System.Windows.Forms.Label()
        Residence_FirstNameLabel = New System.Windows.Forms.Label()
        Residence__LastNameLabel = New System.Windows.Forms.Label()
        DayLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        Check_In_TimeLabel = New System.Windows.Forms.Label()
        Check_Out_TimeLabel = New System.Windows.Forms.Label()
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VisitorsBindingNavigator.SuspendLayout()
        CType(Me.VisitorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.Info
        IDLabel.Location = New System.Drawing.Point(16, 31)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 15)
        IDLabel.TabIndex = 16
        IDLabel.Text = "ID:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RoomLabel.ForeColor = System.Drawing.SystemColors.Info
        RoomLabel.Location = New System.Drawing.Point(16, 72)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(42, 15)
        RoomLabel.TabIndex = 18
        RoomLabel.Text = "Room:"
        '
        'Visitors_FirstNameLabel
        '
        Visitors_FirstNameLabel.AutoSize = True
        Visitors_FirstNameLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitors_FirstNameLabel.ForeColor = System.Drawing.SystemColors.Info
        Visitors_FirstNameLabel.Location = New System.Drawing.Point(16, 116)
        Visitors_FirstNameLabel.Name = "Visitors_FirstNameLabel"
        Visitors_FirstNameLabel.Size = New System.Drawing.Size(120, 15)
        Visitors_FirstNameLabel.TabIndex = 20
        Visitors_FirstNameLabel.Text = "Visitors First Name:"
        '
        'Visitors_Last_NameLabel
        '
        Visitors_Last_NameLabel.AutoSize = True
        Visitors_Last_NameLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitors_Last_NameLabel.ForeColor = System.Drawing.SystemColors.Info
        Visitors_Last_NameLabel.Location = New System.Drawing.Point(16, 156)
        Visitors_Last_NameLabel.Name = "Visitors_Last_NameLabel"
        Visitors_Last_NameLabel.Size = New System.Drawing.Size(117, 15)
        Visitors_Last_NameLabel.TabIndex = 22
        Visitors_Last_NameLabel.Text = "Visitors Last Name:"
        '
        'Residence_FirstNameLabel
        '
        Residence_FirstNameLabel.AutoSize = True
        Residence_FirstNameLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Residence_FirstNameLabel.ForeColor = System.Drawing.SystemColors.Info
        Residence_FirstNameLabel.Location = New System.Drawing.Point(16, 203)
        Residence_FirstNameLabel.Name = "Residence_FirstNameLabel"
        Residence_FirstNameLabel.Size = New System.Drawing.Size(131, 15)
        Residence_FirstNameLabel.TabIndex = 24
        Residence_FirstNameLabel.Text = "Residence First Name:"
        '
        'Residence__LastNameLabel
        '
        Residence__LastNameLabel.AutoSize = True
        Residence__LastNameLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Residence__LastNameLabel.ForeColor = System.Drawing.SystemColors.Info
        Residence__LastNameLabel.Location = New System.Drawing.Point(16, 241)
        Residence__LastNameLabel.Name = "Residence__LastNameLabel"
        Residence__LastNameLabel.Size = New System.Drawing.Size(131, 15)
        Residence__LastNameLabel.TabIndex = 26
        Residence__LastNameLabel.Text = "Residence  Last Name:"
        '
        'DayLabel
        '
        DayLabel.AutoSize = True
        DayLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DayLabel.ForeColor = System.Drawing.SystemColors.Info
        DayLabel.Location = New System.Drawing.Point(16, 282)
        DayLabel.Name = "DayLabel"
        DayLabel.Size = New System.Drawing.Size(32, 15)
        DayLabel.TabIndex = 28
        DayLabel.Text = "Day:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.ForeColor = System.Drawing.SystemColors.Info
        ContactLabel.Location = New System.Drawing.Point(16, 321)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(53, 15)
        ContactLabel.TabIndex = 30
        ContactLabel.Text = "Contact:"
        '
        'Check_In_TimeLabel
        '
        Check_In_TimeLabel.AutoSize = True
        Check_In_TimeLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Check_In_TimeLabel.ForeColor = System.Drawing.SystemColors.Info
        Check_In_TimeLabel.Location = New System.Drawing.Point(16, 362)
        Check_In_TimeLabel.Name = "Check_In_TimeLabel"
        Check_In_TimeLabel.Size = New System.Drawing.Size(92, 15)
        Check_In_TimeLabel.TabIndex = 32
        Check_In_TimeLabel.Text = "Check In Time:"
        '
        'Check_Out_TimeLabel
        '
        Check_Out_TimeLabel.AutoSize = True
        Check_Out_TimeLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Check_Out_TimeLabel.ForeColor = System.Drawing.SystemColors.Info
        Check_Out_TimeLabel.Location = New System.Drawing.Point(16, 409)
        Check_Out_TimeLabel.Name = "Check_Out_TimeLabel"
        Check_Out_TimeLabel.Size = New System.Drawing.Size(102, 15)
        Check_Out_TimeLabel.TabIndex = 34
        Check_Out_TimeLabel.Text = "Check Out Time:"
        '
        'btnCommit
        '
        Me.btnCommit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(661, 527)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(89, 33)
        Me.btnCommit.TabIndex = 11
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnOccupants
        '
        Me.btnOccupants.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOccupants.Location = New System.Drawing.Point(949, 492)
        Me.btnOccupants.Name = "btnOccupants"
        Me.btnOccupants.Size = New System.Drawing.Size(295, 43)
        Me.btnOccupants.TabIndex = 12
        Me.btnOccupants.Text = "Occupants_Details_and_Room_Number"
        Me.btnOccupants.UseVisualStyleBackColor = True
        '
        'btnAvailable
        '
        Me.btnAvailable.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailable.Location = New System.Drawing.Point(1118, 584)
        Me.btnAvailable.Name = "btnAvailable"
        Me.btnAvailable.Size = New System.Drawing.Size(143, 31)
        Me.btnAvailable.TabIndex = 13
        Me.btnAvailable.Text = "Available_Rooms"
        Me.btnAvailable.UseVisualStyleBackColor = True
        '
        'btnTypes
        '
        Me.btnTypes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTypes.Location = New System.Drawing.Point(949, 541)
        Me.btnTypes.Name = "btnTypes"
        Me.btnTypes.Size = New System.Drawing.Size(295, 37)
        Me.btnTypes.TabIndex = 14
        Me.btnTypes.Text = "Types_of_Rooms_and_Prices"
        Me.btnTypes.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(949, 583)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(153, 33)
        Me.btnEmployees.TabIndex = 15
        Me.btnEmployees.Text = "Employee_Details"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'DB_Hostel_Management_System_1DataSet
        '
        Me.DB_Hostel_Management_System_1DataSet.DataSetName = "DB_Hostel_Management_System_1DataSet"
        Me.DB_Hostel_Management_System_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitorsBindingSource
        '
        Me.VisitorsBindingSource.DataMember = "Visitors"
        Me.VisitorsBindingSource.DataSource = Me.DB_Hostel_Management_System_1DataSet
        '
        'VisitorsTableAdapter
        '
        Me.VisitorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_RoomsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employees__DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Occupants_Details_and__Room_NumbersTableAdapter = Nothing
        Me.TableAdapterManager.Types_of_Rooms_and_PricesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisitorsTableAdapter = Me.VisitorsTableAdapter
        '
        'VisitorsBindingNavigator
        '
        Me.VisitorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VisitorsBindingNavigator.BindingSource = Me.VisitorsBindingSource
        Me.VisitorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VisitorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VisitorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VisitorsBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripTextBox1})
        Me.VisitorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VisitorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VisitorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VisitorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VisitorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VisitorsBindingNavigator.Name = "VisitorsBindingNavigator"
        Me.VisitorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VisitorsBindingNavigator.Size = New System.Drawing.Size(1287, 25)
        Me.VisitorsBindingNavigator.TabIndex = 16
        Me.VisitorsBindingNavigator.Text = "BindingNavigator1"
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
        'VisitorsBindingNavigatorSaveItem
        '
        Me.VisitorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VisitorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("VisitorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VisitorsBindingNavigatorSaveItem.Name = "VisitorsBindingNavigatorSaveItem"
        Me.VisitorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VisitorsBindingNavigatorSaveItem.Text = "Save Data"
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
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.Info
        Me.IDTextBox.Location = New System.Drawing.Point(153, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IDTextBox.TabIndex = 17
        '
        'RoomTextBox
        '
        Me.RoomTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.RoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "Room", True))
        Me.RoomTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTextBox.ForeColor = System.Drawing.SystemColors.Info
        Me.RoomTextBox.Location = New System.Drawing.Point(153, 72)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(200, 21)
        Me.RoomTextBox.TabIndex = 19
        '
        'Visitors_FirstNameTextBox
        '
        Me.Visitors_FirstNameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Visitors_FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visitors_FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "Visitors_FirstName", True))
        Me.Visitors_FirstNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visitors_FirstNameTextBox.ForeColor = System.Drawing.SystemColors.Info
        Me.Visitors_FirstNameTextBox.Location = New System.Drawing.Point(153, 116)
        Me.Visitors_FirstNameTextBox.Name = "Visitors_FirstNameTextBox"
        Me.Visitors_FirstNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Visitors_FirstNameTextBox.TabIndex = 21
        '
        'Visitors_Last_NameTextBox
        '
        Me.Visitors_Last_NameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Visitors_Last_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visitors_Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "Visitors_Last Name", True))
        Me.Visitors_Last_NameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visitors_Last_NameTextBox.ForeColor = System.Drawing.SystemColors.Info
        Me.Visitors_Last_NameTextBox.Location = New System.Drawing.Point(153, 156)
        Me.Visitors_Last_NameTextBox.Name = "Visitors_Last_NameTextBox"
        Me.Visitors_Last_NameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Visitors_Last_NameTextBox.TabIndex = 23
        '
        'Residence_FirstNameTextBox
        '
        Me.Residence_FirstNameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Residence_FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Residence_FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "Residence_FirstName", True))
        Me.Residence_FirstNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Residence_FirstNameTextBox.ForeColor = System.Drawing.SystemColors.Info
        Me.Residence_FirstNameTextBox.Location = New System.Drawing.Point(153, 203)
        Me.Residence_FirstNameTextBox.Name = "Residence_FirstNameTextBox"
        Me.Residence_FirstNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Residence_FirstNameTextBox.TabIndex = 25
        '
        'Residence__LastNameTextBox
        '
        Me.Residence__LastNameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Residence__LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Residence__LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "Residence _LastName", True))
        Me.Residence__LastNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Residence__LastNameTextBox.ForeColor = System.Drawing.SystemColors.Info
        Me.Residence__LastNameTextBox.Location = New System.Drawing.Point(153, 241)
        Me.Residence__LastNameTextBox.Name = "Residence__LastNameTextBox"
        Me.Residence__LastNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Residence__LastNameTextBox.TabIndex = 27
        '
        'DayDateTimePicker
        '
        Me.DayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VisitorsBindingSource, "Day", True))
        Me.DayDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayDateTimePicker.Location = New System.Drawing.Point(153, 281)
        Me.DayDateTimePicker.Name = "DayDateTimePicker"
        Me.DayDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.DayDateTimePicker.TabIndex = 29
        '
        'ContactTextBox
        '
        Me.ContactTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "Contact", True))
        Me.ContactTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.ContactTextBox.Location = New System.Drawing.Point(153, 321)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 21)
        Me.ContactTextBox.TabIndex = 31
        '
        'Check_In_TimeDateTimePicker
        '
        Me.Check_In_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VisitorsBindingSource, "Check_In_Time", True))
        Me.Check_In_TimeDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_In_TimeDateTimePicker.Location = New System.Drawing.Point(153, 361)
        Me.Check_In_TimeDateTimePicker.Name = "Check_In_TimeDateTimePicker"
        Me.Check_In_TimeDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.Check_In_TimeDateTimePicker.TabIndex = 33
        '
        'Check_Out_TimeDateTimePicker
        '
        Me.Check_Out_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VisitorsBindingSource, "Check_Out_Time", True))
        Me.Check_Out_TimeDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Out_TimeDateTimePicker.Location = New System.Drawing.Point(153, 408)
        Me.Check_Out_TimeDateTimePicker.Name = "Check_Out_TimeDateTimePicker"
        Me.Check_Out_TimeDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.Check_Out_TimeDateTimePicker.TabIndex = 35
        '
        'VisitorsDataGridView
        '
        Me.VisitorsDataGridView.AutoGenerateColumns = False
        Me.VisitorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VisitorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.VisitorsDataGridView.DataSource = Me.VisitorsBindingSource
        Me.VisitorsDataGridView.Location = New System.Drawing.Point(378, 15)
        Me.VisitorsDataGridView.Name = "VisitorsDataGridView"
        Me.VisitorsDataGridView.Size = New System.Drawing.Size(883, 464)
        Me.VisitorsDataGridView.TabIndex = 35
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Visitors_FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Visitors_FirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Visitors_Last Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Visitors_Last Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Residence_FirstName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Residence_FirstName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Residence _LastName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Residence _LastName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Day"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Contact"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Check_In_Time"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Check_In_Time"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Check_Out_Time"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Check_Out_Time"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnfirst)
        Me.Panel1.Controls.Add(Me.btnLast)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnOccupants)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.btnCommit)
        Me.Panel1.Controls.Add(Me.VisitorsDataGridView)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.btnTypes)
        Me.Panel1.Controls.Add(RoomLabel)
        Me.Panel1.Controls.Add(Me.RoomTextBox)
        Me.Panel1.Controls.Add(Me.btnAvailable)
        Me.Panel1.Controls.Add(Visitors_FirstNameLabel)
        Me.Panel1.Controls.Add(Me.btnEmployees)
        Me.Panel1.Controls.Add(Me.Visitors_FirstNameTextBox)
        Me.Panel1.Controls.Add(Me.Check_Out_TimeDateTimePicker)
        Me.Panel1.Controls.Add(Visitors_Last_NameLabel)
        Me.Panel1.Controls.Add(Check_Out_TimeLabel)
        Me.Panel1.Controls.Add(Me.Visitors_Last_NameTextBox)
        Me.Panel1.Controls.Add(Me.Check_In_TimeDateTimePicker)
        Me.Panel1.Controls.Add(Residence_FirstNameLabel)
        Me.Panel1.Controls.Add(Check_In_TimeLabel)
        Me.Panel1.Controls.Add(Me.Residence_FirstNameTextBox)
        Me.Panel1.Controls.Add(Me.ContactTextBox)
        Me.Panel1.Controls.Add(Residence__LastNameLabel)
        Me.Panel1.Controls.Add(ContactLabel)
        Me.Panel1.Controls.Add(Me.Residence__LastNameTextBox)
        Me.Panel1.Controls.Add(Me.DayDateTimePicker)
        Me.Panel1.Controls.Add(DayLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 626)
        Me.Panel1.TabIndex = 36
        '
        'btnfirst
        '
        Me.btnfirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.Location = New System.Drawing.Point(55, 545)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(97, 28)
        Me.btnfirst.TabIndex = 46
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(202, 546)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(97, 28)
        Me.btnLast.TabIndex = 45
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(610, 566)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 30)
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(55, 497)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(111, 33)
        Me.btnPrevious.TabIndex = 38
        Me.btnPrevious.Text = "Previous |<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(205, 497)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 33)
        Me.btnNext.TabIndex = 37
        Me.btnNext.Text = "Next >>|"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(548, 527)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 33)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Visitors_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 657)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VisitorsBindingNavigator)
        Me.Name = "Visitors_Details"
        Me.Text = "Vistors_Details"
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VisitorsBindingNavigator.ResumeLayout(False)
        Me.VisitorsBindingNavigator.PerformLayout()
        CType(Me.VisitorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnOccupants As Button
    Friend WithEvents btnAvailable As Button
    Friend WithEvents btnTypes As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents DB_Hostel_Management_System_1DataSet As DB_Hostel_Management_System_1DataSet
    Friend WithEvents VisitorsBindingSource As BindingSource
    Friend WithEvents VisitorsTableAdapter As DB_Hostel_Management_System_1DataSetTableAdapters.VisitorsTableAdapter
    Friend WithEvents TableAdapterManager As DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VisitorsBindingNavigator As BindingNavigator
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
    Friend WithEvents VisitorsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents Visitors_FirstNameTextBox As TextBox
    Friend WithEvents Visitors_Last_NameTextBox As TextBox
    Friend WithEvents Residence_FirstNameTextBox As TextBox
    Friend WithEvents Residence__LastNameTextBox As TextBox
    Friend WithEvents DayDateTimePicker As DateTimePicker
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents Check_In_TimeDateTimePicker As DateTimePicker
    Friend WithEvents Check_Out_TimeDateTimePicker As DateTimePicker
    Friend WithEvents VisitorsDataGridView As DataGridView
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents btnLast As Button
End Class
