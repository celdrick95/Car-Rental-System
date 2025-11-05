<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Rent_IDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Rent_DayLabel As System.Windows.Forms.Label
        Dim No_of_DaysLabel As System.Windows.Forms.Label
        Dim Total_DueLabel As System.Windows.Forms.Label
        Dim Processed_ByLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Rent_DetailsDataSet = New FinalCarRentalSystem.Rent_DetailsDataSet()
        Me.RentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter()
        Me.TableAdapterManager = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager()
        Me.Rent_DetailsTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter()
        Me.RentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Rent_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Rent_DayTextBox = New System.Windows.Forms.TextBox()
        Me.No_of_DaysTextBox = New System.Windows.Forms.TextBox()
        Me.Total_DueTextBox = New System.Windows.Forms.TextBox()
        Me.Processed_ByTextBox = New System.Windows.Forms.TextBox()
        Me.Rent_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsDataSet = New FinalCarRentalSystem.ListOfCarsDataSet()
        Me.ListOfCarsTableAdapter = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter()
        Me.First_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New FinalCarRentalSystem.CustomerDataSet()
        Me.CustomerTableAdapter = New FinalCarRentalSystem.CustomerDataSetTableAdapters.CustomerTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Rent_IDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Rent_DayLabel = New System.Windows.Forms.Label()
        No_of_DaysLabel = New System.Windows.Forms.Label()
        Total_DueLabel = New System.Windows.Forms.Label()
        Processed_ByLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RentBindingNavigator.SuspendLayout()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rent_IDLabel
        '
        Rent_IDLabel.AutoSize = True
        Rent_IDLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_IDLabel.Location = New System.Drawing.Point(29, 106)
        Rent_IDLabel.Name = "Rent_IDLabel"
        Rent_IDLabel.Size = New System.Drawing.Size(53, 17)
        Rent_IDLabel.TabIndex = 1
        Rent_IDLabel.Text = "Rent ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(29, 167)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(38, 17)
        DateLabel.TabIndex = 25
        DateLabel.Text = "Date:"
        '
        'Rent_DayLabel
        '
        Rent_DayLabel.AutoSize = True
        Rent_DayLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_DayLabel.Location = New System.Drawing.Point(29, 200)
        Rent_DayLabel.Name = "Rent_DayLabel"
        Rent_DayLabel.Size = New System.Drawing.Size(64, 17)
        Rent_DayLabel.TabIndex = 27
        Rent_DayLabel.Text = "Rent/Day:"
        '
        'No_of_DaysLabel
        '
        No_of_DaysLabel.AutoSize = True
        No_of_DaysLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_of_DaysLabel.Location = New System.Drawing.Point(29, 226)
        No_of_DaysLabel.Name = "No_of_DaysLabel"
        No_of_DaysLabel.Size = New System.Drawing.Size(77, 17)
        No_of_DaysLabel.TabIndex = 29
        No_of_DaysLabel.Text = "No of Days:"
        '
        'Total_DueLabel
        '
        Total_DueLabel.AutoSize = True
        Total_DueLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_DueLabel.Location = New System.Drawing.Point(29, 256)
        Total_DueLabel.Name = "Total_DueLabel"
        Total_DueLabel.Size = New System.Drawing.Size(66, 17)
        Total_DueLabel.TabIndex = 31
        Total_DueLabel.Text = "Total Due:"
        '
        'Processed_ByLabel
        '
        Processed_ByLabel.AutoSize = True
        Processed_ByLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Processed_ByLabel.Location = New System.Drawing.Point(29, 286)
        Processed_ByLabel.Name = "Processed_ByLabel"
        Processed_ByLabel.Size = New System.Drawing.Size(88, 17)
        Processed_ByLabel.TabIndex = 33
        Processed_ByLabel.Text = "Processed By:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(30, 139)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(69, 17)
        First_NameLabel.TabIndex = 39
        First_NameLabel.Text = "Full Name:"
        '
        'Rent_DetailsDataSet
        '
        Me.Rent_DetailsDataSet.DataSetName = "Rent_DetailsDataSet"
        Me.Rent_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentBindingSource
        '
        Me.RentBindingSource.DataMember = "Rent"
        Me.RentBindingSource.DataSource = Me.Rent_DetailsDataSet
        '
        'RentTableAdapter
        '
        Me.RentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Rent_DetailsTableAdapter = Me.Rent_DetailsTableAdapter
        Me.TableAdapterManager.RentTableAdapter = Me.RentTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Rent_DetailsTableAdapter
        '
        Me.Rent_DetailsTableAdapter.ClearBeforeFill = True
        '
        'RentBindingNavigator
        '
        Me.RentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RentBindingNavigator.BindingSource = Me.RentBindingSource
        Me.RentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RentBindingNavigatorSaveItem})
        Me.RentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RentBindingNavigator.Name = "RentBindingNavigator"
        Me.RentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RentBindingNavigator.Size = New System.Drawing.Size(407, 25)
        Me.RentBindingNavigator.TabIndex = 0
        Me.RentBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'RentBindingNavigatorSaveItem
        '
        Me.RentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RentBindingNavigatorSaveItem.Image = CType(resources.GetObject("RentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RentBindingNavigatorSaveItem.Name = "RentBindingNavigatorSaveItem"
        Me.RentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Rent_IDTextBox
        '
        Me.Rent_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent_ID", True))
        Me.Rent_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rent_IDTextBox.Location = New System.Drawing.Point(124, 103)
        Me.Rent_IDTextBox.Name = "Rent_IDTextBox"
        Me.Rent_IDTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Rent_IDTextBox.TabIndex = 2
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RentBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(124, 163)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 25)
        Me.DateDateTimePicker.TabIndex = 26
        '
        'Rent_DayTextBox
        '
        Me.Rent_DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent/Day", True))
        Me.Rent_DayTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rent_DayTextBox.Location = New System.Drawing.Point(124, 193)
        Me.Rent_DayTextBox.Name = "Rent_DayTextBox"
        Me.Rent_DayTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Rent_DayTextBox.TabIndex = 28
        '
        'No_of_DaysTextBox
        '
        Me.No_of_DaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "No_of_Days", True))
        Me.No_of_DaysTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_of_DaysTextBox.Location = New System.Drawing.Point(124, 223)
        Me.No_of_DaysTextBox.Name = "No_of_DaysTextBox"
        Me.No_of_DaysTextBox.Size = New System.Drawing.Size(200, 25)
        Me.No_of_DaysTextBox.TabIndex = 30
        '
        'Total_DueTextBox
        '
        Me.Total_DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Total_Due", True))
        Me.Total_DueTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_DueTextBox.Location = New System.Drawing.Point(124, 253)
        Me.Total_DueTextBox.Name = "Total_DueTextBox"
        Me.Total_DueTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Total_DueTextBox.TabIndex = 32
        '
        'Processed_ByTextBox
        '
        Me.Processed_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Processed_By", True))
        Me.Processed_ByTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Processed_ByTextBox.Location = New System.Drawing.Point(124, 283)
        Me.Processed_ByTextBox.Name = "Processed_ByTextBox"
        Me.Processed_ByTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Processed_ByTextBox.TabIndex = 34
        '
        'Rent_DetailsBindingSource
        '
        Me.Rent_DetailsBindingSource.DataMember = "Rent_Rent_Details"
        Me.Rent_DetailsBindingSource.DataSource = Me.RentBindingSource
        '
        'ListOfCarsBindingSource
        '
        Me.ListOfCarsBindingSource.DataMember = "ListOfCars"
        Me.ListOfCarsBindingSource.DataSource = Me.ListOfCarsDataSet
        '
        'ListOfCarsDataSet
        '
        Me.ListOfCarsDataSet.DataSetName = "ListOfCarsDataSet"
        Me.ListOfCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListOfCarsTableAdapter
        '
        Me.ListOfCarsTableAdapter.ClearBeforeFill = True
        '
        'First_NameComboBox
        '
        Me.First_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "First_Name", True))
        Me.First_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RentBindingSource, "First_Name", True))
        Me.First_NameComboBox.DataSource = Me.CustomerBindingSource
        Me.First_NameComboBox.DisplayMember = "First_Name"
        Me.First_NameComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameComboBox.FormattingEnabled = True
        Me.First_NameComboBox.Location = New System.Drawing.Point(124, 133)
        Me.First_NameComboBox.Name = "First_NameComboBox"
        Me.First_NameComboBox.Size = New System.Drawing.Size(200, 25)
        Me.First_NameComboBox.TabIndex = 40
        Me.First_NameComboBox.ValueMember = "First_Name"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 45)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Booking"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(407, 70)
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.button1)
        Me.groupBox3.Controls.Add(Me.button3)
        Me.groupBox3.Controls.Add(Me.button2)
        Me.groupBox3.Location = New System.Drawing.Point(12, 335)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(379, 57)
        Me.groupBox3.TabIndex = 104
        Me.groupBox3.TabStop = False
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(146, 15)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 32)
        Me.button1.TabIndex = 18
        Me.button1.Text = "SAVE"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(31, 15)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(96, 32)
        Me.button3.TabIndex = 22
        Me.button3.Text = "ADD"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(254, 15)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(96, 32)
        Me.button2.TabIndex = 19
        Me.button2.Text = "CLOSE"
        Me.button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(32, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 253)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(407, 404)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameComboBox)
        Me.Controls.Add(Rent_IDLabel)
        Me.Controls.Add(Me.Rent_IDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Rent_DayLabel)
        Me.Controls.Add(Me.Rent_DayTextBox)
        Me.Controls.Add(No_of_DaysLabel)
        Me.Controls.Add(Me.No_of_DaysTextBox)
        Me.Controls.Add(Total_DueLabel)
        Me.Controls.Add(Me.Total_DueTextBox)
        Me.Controls.Add(Processed_ByLabel)
        Me.Controls.Add(Me.Processed_ByTextBox)
        Me.Controls.Add(Me.RentBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RentBindingNavigator.ResumeLayout(False)
        Me.RentBindingNavigator.PerformLayout()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rent_DetailsDataSet As FinalCarRentalSystem.Rent_DetailsDataSet
    Friend WithEvents RentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rent_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rent_DayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_of_DaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_DueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Processed_ByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rent_DetailsTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter
    Friend WithEvents Rent_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsDataSet As FinalCarRentalSystem.ListOfCarsDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
    Friend WithEvents First_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerDataSet As FinalCarRentalSystem.CustomerDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As FinalCarRentalSystem.CustomerDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
