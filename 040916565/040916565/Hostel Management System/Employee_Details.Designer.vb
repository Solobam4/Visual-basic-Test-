<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Details
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
        Dim Auto_IDLabel As System.Windows.Forms.Label
        Dim Employee__IDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Job_TitleLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Details))
        Me.btnOccupants = New System.Windows.Forms.Button()
        Me.btnAvailable = New System.Windows.Forms.Button()
        Me.btnTypes = New System.Windows.Forms.Button()
        Me.btnVisitors = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.DB_Hostel_Management_System_1DataSet = New Hostel_Management_System.DB_Hostel_Management_System_1DataSet()
        Me.Employees__DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employees__DetailsTableAdapter = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.Employees__DetailsTableAdapter()
        Me.TableAdapterManager = New Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager()
        Me.Employees__DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Employees__DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.Auto_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Employee__IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Job_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Employees__DetailsDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Auto_IDLabel = New System.Windows.Forms.Label()
        Employee__IDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Job_TitleLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employees__DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employees__DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Employees__DetailsBindingNavigator.SuspendLayout()
        CType(Me.Employees__DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Auto_IDLabel
        '
        Auto_IDLabel.AutoSize = True
        Auto_IDLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Auto_IDLabel.ForeColor = System.Drawing.SystemColors.Info
        Auto_IDLabel.Location = New System.Drawing.Point(12, 40)
        Auto_IDLabel.Name = "Auto_IDLabel"
        Auto_IDLabel.Size = New System.Drawing.Size(66, 17)
        Auto_IDLabel.TabIndex = 16
        Auto_IDLabel.Text = "Auto ID:"
        '
        'Employee__IDLabel
        '
        Employee__IDLabel.AutoSize = True
        Employee__IDLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee__IDLabel.ForeColor = System.Drawing.SystemColors.Info
        Employee__IDLabel.Location = New System.Drawing.Point(12, 70)
        Employee__IDLabel.Name = "Employee__IDLabel"
        Employee__IDLabel.Size = New System.Drawing.Size(103, 17)
        Employee__IDLabel.TabIndex = 18
        Employee__IDLabel.Text = "Employee  ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.ForeColor = System.Drawing.SystemColors.Info
        FirstNameLabel.Location = New System.Drawing.Point(12, 106)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(86, 17)
        FirstNameLabel.TabIndex = 20
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.ForeColor = System.Drawing.SystemColors.Info
        LastNameLabel.Location = New System.Drawing.Point(12, 141)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(84, 17)
        LastNameLabel.TabIndex = 22
        LastNameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.SystemColors.Info
        GenderLabel.Location = New System.Drawing.Point(12, 176)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(62, 17)
        GenderLabel.TabIndex = 24
        GenderLabel.Text = "Gender:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.ForeColor = System.Drawing.SystemColors.Info
        DOBLabel.Location = New System.Drawing.Point(12, 215)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(47, 17)
        DOBLabel.TabIndex = 26
        DOBLabel.Text = "DOB:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.ForeColor = System.Drawing.SystemColors.Info
        CountryLabel.Location = New System.Drawing.Point(12, 255)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(66, 17)
        CountryLabel.TabIndex = 28
        CountryLabel.Text = "Country:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.ForeColor = System.Drawing.SystemColors.Info
        ContactLabel.Location = New System.Drawing.Point(12, 297)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(64, 17)
        ContactLabel.TabIndex = 30
        ContactLabel.Text = "Contact:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.Info
        EmailLabel.Location = New System.Drawing.Point(12, 339)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(50, 17)
        EmailLabel.TabIndex = 32
        EmailLabel.Text = "Email:"
        '
        'Job_TitleLabel
        '
        Job_TitleLabel.AutoSize = True
        Job_TitleLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Job_TitleLabel.ForeColor = System.Drawing.SystemColors.Info
        Job_TitleLabel.Location = New System.Drawing.Point(12, 382)
        Job_TitleLabel.Name = "Job_TitleLabel"
        Job_TitleLabel.Size = New System.Drawing.Size(72, 17)
        Job_TitleLabel.TabIndex = 34
        Job_TitleLabel.Text = "Job Title:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalaryLabel.ForeColor = System.Drawing.SystemColors.Info
        SalaryLabel.Location = New System.Drawing.Point(12, 429)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(52, 17)
        SalaryLabel.TabIndex = 36
        SalaryLabel.Text = "Salary:"
        '
        'btnOccupants
        '
        Me.btnOccupants.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOccupants.Location = New System.Drawing.Point(967, 485)
        Me.btnOccupants.Name = "btnOccupants"
        Me.btnOccupants.Size = New System.Drawing.Size(308, 45)
        Me.btnOccupants.TabIndex = 10
        Me.btnOccupants.Text = "Occupants_Details_and_Room_Number"
        Me.btnOccupants.UseVisualStyleBackColor = True
        '
        'btnAvailable
        '
        Me.btnAvailable.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailable.Location = New System.Drawing.Point(1130, 581)
        Me.btnAvailable.Name = "btnAvailable"
        Me.btnAvailable.Size = New System.Drawing.Size(145, 36)
        Me.btnAvailable.TabIndex = 11
        Me.btnAvailable.Text = "Available_Rooms"
        Me.btnAvailable.UseVisualStyleBackColor = True
        '
        'btnTypes
        '
        Me.btnTypes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTypes.Location = New System.Drawing.Point(967, 536)
        Me.btnTypes.Name = "btnTypes"
        Me.btnTypes.Size = New System.Drawing.Size(308, 39)
        Me.btnTypes.TabIndex = 12
        Me.btnTypes.Text = "Types_of_Rooms_and_Prices"
        Me.btnTypes.UseVisualStyleBackColor = True
        '
        'btnVisitors
        '
        Me.btnVisitors.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitors.Location = New System.Drawing.Point(967, 581)
        Me.btnVisitors.Name = "btnVisitors"
        Me.btnVisitors.Size = New System.Drawing.Size(141, 36)
        Me.btnVisitors.TabIndex = 13
        Me.btnVisitors.Text = "Visitors_Details"
        Me.btnVisitors.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(604, 536)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(104, 29)
        Me.btnCommit.TabIndex = 15
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'DB_Hostel_Management_System_1DataSet
        '
        Me.DB_Hostel_Management_System_1DataSet.DataSetName = "DB_Hostel_Management_System_1DataSet"
        Me.DB_Hostel_Management_System_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employees__DetailsBindingSource
        '
        Me.Employees__DetailsBindingSource.DataMember = "Employees  Details"
        Me.Employees__DetailsBindingSource.DataSource = Me.DB_Hostel_Management_System_1DataSet
        '
        'Employees__DetailsTableAdapter
        '
        Me.Employees__DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_RoomsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employees__DetailsTableAdapter = Me.Employees__DetailsTableAdapter
        Me.TableAdapterManager.Occupants_Details_and__Room_NumbersTableAdapter = Nothing
        Me.TableAdapterManager.Types_of_Rooms_and_PricesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hostel_Management_System.DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisitorsTableAdapter = Nothing
        '
        'Employees__DetailsBindingNavigator
        '
        Me.Employees__DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Employees__DetailsBindingNavigator.BindingSource = Me.Employees__DetailsBindingSource
        Me.Employees__DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Employees__DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Employees__DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Employees__DetailsBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripTextBox1})
        Me.Employees__DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Employees__DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Employees__DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Employees__DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Employees__DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Employees__DetailsBindingNavigator.Name = "Employees__DetailsBindingNavigator"
        Me.Employees__DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Employees__DetailsBindingNavigator.Size = New System.Drawing.Size(1287, 25)
        Me.Employees__DetailsBindingNavigator.TabIndex = 16
        Me.Employees__DetailsBindingNavigator.Text = "BindingNavigator1"
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
        'Employees__DetailsBindingNavigatorSaveItem
        '
        Me.Employees__DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Employees__DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Employees__DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Employees__DetailsBindingNavigatorSaveItem.Name = "Employees__DetailsBindingNavigatorSaveItem"
        Me.Employees__DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Employees__DetailsBindingNavigatorSaveItem.Text = "Save Data"
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
        'Auto_IDTextBox
        '
        Me.Auto_IDTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Auto_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Auto_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Auto_ID", True))
        Me.Auto_IDTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Auto_IDTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Auto_IDTextBox.Location = New System.Drawing.Point(118, 33)
        Me.Auto_IDTextBox.Name = "Auto_IDTextBox"
        Me.Auto_IDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Auto_IDTextBox.TabIndex = 17
        '
        'Employee__IDTextBox
        '
        Me.Employee__IDTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Employee__IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Employee__IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Employee_ ID", True))
        Me.Employee__IDTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee__IDTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Employee__IDTextBox.Location = New System.Drawing.Point(118, 63)
        Me.Employee__IDTextBox.Name = "Employee__IDTextBox"
        Me.Employee__IDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Employee__IDTextBox.TabIndex = 19
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.FirstNameTextBox.Location = New System.Drawing.Point(118, 99)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.FirstNameTextBox.TabIndex = 21
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.LastNameTextBox.Location = New System.Drawing.Point(118, 134)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.LastNameTextBox.TabIndex = 23
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.GenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.GenderTextBox.Location = New System.Drawing.Point(118, 169)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 21)
        Me.GenderTextBox.TabIndex = 25
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Employees__DetailsBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(118, 207)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.DOBDateTimePicker.TabIndex = 27
        '
        'CountryTextBox
        '
        Me.CountryTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.CountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Country", True))
        Me.CountryTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.CountryTextBox.Location = New System.Drawing.Point(118, 248)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 21)
        Me.CountryTextBox.TabIndex = 29
        '
        'ContactTextBox
        '
        Me.ContactTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.ContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Contact", True))
        Me.ContactTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.ContactTextBox.Location = New System.Drawing.Point(118, 290)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 21)
        Me.ContactTextBox.TabIndex = 31
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.EmailTextBox.Location = New System.Drawing.Point(118, 332)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 21)
        Me.EmailTextBox.TabIndex = 33
        '
        'Job_TitleTextBox
        '
        Me.Job_TitleTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.Job_TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Job_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Job Title", True))
        Me.Job_TitleTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Job_TitleTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Job_TitleTextBox.Location = New System.Drawing.Point(118, 375)
        Me.Job_TitleTextBox.Name = "Job_TitleTextBox"
        Me.Job_TitleTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Job_TitleTextBox.TabIndex = 35
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.BackColor = System.Drawing.SystemColors.MenuText
        Me.SalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employees__DetailsBindingSource, "Salary", True))
        Me.SalaryTextBox.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.SalaryTextBox.Location = New System.Drawing.Point(118, 422)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(200, 21)
        Me.SalaryTextBox.TabIndex = 37
        '
        'Employees__DetailsDataGridView
        '
        Me.Employees__DetailsDataGridView.AutoGenerateColumns = False
        Me.Employees__DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Employees__DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Employees__DetailsDataGridView.DataSource = Me.Employees__DetailsBindingSource
        Me.Employees__DetailsDataGridView.Location = New System.Drawing.Point(339, 33)
        Me.Employees__DetailsDataGridView.Name = "Employees__DetailsDataGridView"
        Me.Employees__DetailsDataGridView.Size = New System.Drawing.Size(936, 446)
        Me.Employees__DetailsDataGridView.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Auto_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Auto_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Employee_ ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee_ ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Country"
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
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Job Title"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Job Title"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Salary"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Panel1.Controls.Add(Me.btnfirst)
        Me.Panel1.Controls.Add(Me.btnLast)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnOccupants)
        Me.Panel1.Controls.Add(Auto_IDLabel)
        Me.Panel1.Controls.Add(Me.btnCommit)
        Me.Panel1.Controls.Add(Me.Employees__DetailsDataGridView)
        Me.Panel1.Controls.Add(Me.Auto_IDTextBox)
        Me.Panel1.Controls.Add(Me.btnTypes)
        Me.Panel1.Controls.Add(Employee__IDLabel)
        Me.Panel1.Controls.Add(Me.btnAvailable)
        Me.Panel1.Controls.Add(Me.Employee__IDTextBox)
        Me.Panel1.Controls.Add(Me.btnVisitors)
        Me.Panel1.Controls.Add(FirstNameLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.Panel1.Controls.Add(Me.SalaryTextBox)
        Me.Panel1.Controls.Add(LastNameLabel)
        Me.Panel1.Controls.Add(SalaryLabel)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(Me.Job_TitleTextBox)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Controls.Add(Job_TitleLabel)
        Me.Panel1.Controls.Add(Me.GenderTextBox)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(DOBLabel)
        Me.Panel1.Controls.Add(Me.ContactTextBox)
        Me.Panel1.Controls.Add(Me.DOBDateTimePicker)
        Me.Panel1.Controls.Add(ContactLabel)
        Me.Panel1.Controls.Add(CountryLabel)
        Me.Panel1.Controls.Add(Me.CountryTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 637)
        Me.Panel1.TabIndex = 38
        '
        'btnfirst
        '
        Me.btnfirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.Location = New System.Drawing.Point(46, 536)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(97, 28)
        Me.btnfirst.TabIndex = 44
        Me.btnfirst.Text = "First"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(193, 537)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(97, 28)
        Me.btnLast.TabIndex = 43
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(543, 571)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 30)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(24, 490)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(135, 34)
        Me.btnPrevious.TabIndex = 41
        Me.btnPrevious.Text = "Previous |<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(176, 490)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 34)
        Me.btnNext.TabIndex = 40
        Me.btnNext.Text = "Next |>>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(472, 536)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 29)
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Employee_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Employees__DetailsBindingNavigator)
        Me.Name = "Employee_Details"
        Me.Text = "Employee_Details"
        CType(Me.DB_Hostel_Management_System_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employees__DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employees__DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Employees__DetailsBindingNavigator.ResumeLayout(False)
        Me.Employees__DetailsBindingNavigator.PerformLayout()
        CType(Me.Employees__DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOccupants As Button
    Friend WithEvents btnAvailable As Button
    Friend WithEvents btnTypes As Button
    Friend WithEvents btnVisitors As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents DB_Hostel_Management_System_1DataSet As DB_Hostel_Management_System_1DataSet
    Friend WithEvents Employees__DetailsBindingSource As BindingSource
    Friend WithEvents Employees__DetailsTableAdapter As DB_Hostel_Management_System_1DataSetTableAdapters.Employees__DetailsTableAdapter
    Friend WithEvents TableAdapterManager As DB_Hostel_Management_System_1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Employees__DetailsBindingNavigator As BindingNavigator
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
    Friend WithEvents Employees__DetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Auto_IDTextBox As TextBox
    Friend WithEvents Employee__IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Job_TitleTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents Employees__DetailsDataGridView As DataGridView
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
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnfirst As Button
End Class
