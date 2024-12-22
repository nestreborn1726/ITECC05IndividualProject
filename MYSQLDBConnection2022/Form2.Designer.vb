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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        btnLogout = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox_name = New TextBox()
        TextBox_surname = New TextBox()
        TextBox_age = New TextBox()
        btnSave = New Button()
        Label5 = New Label()
        dtp_dob = New DateTimePicker()
        radbtn_male = New RadioButton()
        radbtn_female = New RadioButton()
        Label6 = New Label()
        TextBox_address = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox_phone = New TextBox()
        TextBox_email = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        TextBox_search = New TextBox()
        Label1 = New Label()
        btnClear = New Button()
        btnEdit = New Button()
        TextBox_eid = New TextBox()
        Label10 = New Label()
        btnDelete = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        btnChart = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(13, 9)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(96, 32)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 80)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 30)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 115)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 30)
        Label3.TabIndex = 3
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 151)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 30)
        Label4.TabIndex = 4
        Label4.Text = "Age"
        ' 
        ' TextBox_name
        ' 
        TextBox_name.Location = New Point(162, 80)
        TextBox_name.Name = "TextBox_name"
        TextBox_name.Size = New Size(254, 29)
        TextBox_name.TabIndex = 6
        ' 
        ' TextBox_surname
        ' 
        TextBox_surname.Location = New Point(162, 115)
        TextBox_surname.Name = "TextBox_surname"
        TextBox_surname.Size = New Size(254, 29)
        TextBox_surname.TabIndex = 7
        ' 
        ' TextBox_age
        ' 
        TextBox_age.Location = New Point(162, 151)
        TextBox_age.Name = "TextBox_age"
        TextBox_age.Size = New Size(254, 29)
        TextBox_age.TabIndex = 8
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(162, 358)
        btnSave.Margin = New Padding(4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(96, 32)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 186)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 30)
        Label5.TabIndex = 10
        Label5.Text = "Date Of Birth"
        ' 
        ' dtp_dob
        ' 
        dtp_dob.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtp_dob.Location = New Point(162, 186)
        dtp_dob.Name = "dtp_dob"
        dtp_dob.Size = New Size(254, 29)
        dtp_dob.TabIndex = 11
        ' 
        ' radbtn_male
        ' 
        radbtn_male.AutoSize = True
        radbtn_male.Location = New Point(183, 221)
        radbtn_male.Name = "radbtn_male"
        radbtn_male.Size = New Size(62, 25)
        radbtn_male.TabIndex = 12
        radbtn_male.TabStop = True
        radbtn_male.Text = "Male"
        radbtn_male.UseVisualStyleBackColor = True
        ' 
        ' radbtn_female
        ' 
        radbtn_female.AutoSize = True
        radbtn_female.Location = New Point(311, 221)
        radbtn_female.Name = "radbtn_female"
        radbtn_female.Size = New Size(78, 25)
        radbtn_female.TabIndex = 13
        radbtn_female.TabStop = True
        radbtn_female.Text = "Female"
        radbtn_female.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 221)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 30)
        Label6.TabIndex = 14
        Label6.Text = "Gender"
        ' 
        ' TextBox_address
        ' 
        TextBox_address.Location = New Point(162, 252)
        TextBox_address.Name = "TextBox_address"
        TextBox_address.Size = New Size(254, 29)
        TextBox_address.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 252)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 30)
        Label7.TabIndex = 16
        Label7.Text = "Address"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(13, 287)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 30)
        Label8.TabIndex = 17
        Label8.Text = "Phone"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 321)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 30)
        Label9.TabIndex = 18
        Label9.Text = "Email"
        ' 
        ' TextBox_phone
        ' 
        TextBox_phone.Location = New Point(162, 287)
        TextBox_phone.Name = "TextBox_phone"
        TextBox_phone.Size = New Size(254, 29)
        TextBox_phone.TabIndex = 19
        ' 
        ' TextBox_email
        ' 
        TextBox_email.Location = New Point(162, 321)
        TextBox_email.Name = "TextBox_email"
        TextBox_email.Size = New Size(254, 29)
        TextBox_email.TabIndex = 20
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10})
        DataGridView1.Location = New Point(438, 80)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1044, 271)
        DataGridView1.TabIndex = 21
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "EmployeeID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 118
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 77
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Surname"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 98
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Age"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 62
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Gender"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 86
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "HireDate"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 96
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "BirthDate"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Address"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 91
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Phone"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 79
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Email"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 73
        ' 
        ' TextBox_search
        ' 
        TextBox_search.Location = New Point(529, 41)
        TextBox_search.Name = "TextBox_search"
        TextBox_search.Size = New Size(438, 29)
        TextBox_search.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(438, 41)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 30)
        Label1.TabIndex = 23
        Label1.Text = "Search:"
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(320, 358)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(96, 32)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(162, 398)
        btnEdit.Margin = New Padding(4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(96, 32)
        btnEdit.TabIndex = 25
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' TextBox_eid
        ' 
        TextBox_eid.Location = New Point(162, 45)
        TextBox_eid.Name = "TextBox_eid"
        TextBox_eid.Size = New Size(254, 29)
        TextBox_eid.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(13, 45)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(136, 30)
        Label10.TabIndex = 27
        Label10.Text = "Employee ID"
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(320, 398)
        btnDelete.Margin = New Padding(4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(96, 32)
        btnDelete.TabIndex = 28
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(651, 375)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "NAME_VS_AGE"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(831, 300)
        Chart1.TabIndex = 29
        Chart1.Text = "Chart1"
        ' 
        ' btnChart
        ' 
        btnChart.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChart.Location = New Point(438, 643)
        btnChart.Margin = New Padding(4)
        btnChart.Name = "btnChart"
        btnChart.Size = New Size(187, 32)
        btnChart.TabIndex = 30
        btnChart.Text = "Load Chart"
        btnChart.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1495, 700)
        Controls.Add(btnChart)
        Controls.Add(Chart1)
        Controls.Add(btnDelete)
        Controls.Add(Label10)
        Controls.Add(TextBox_eid)
        Controls.Add(btnEdit)
        Controls.Add(btnClear)
        Controls.Add(Label1)
        Controls.Add(TextBox_search)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox_email)
        Controls.Add(TextBox_phone)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TextBox_address)
        Controls.Add(Label6)
        Controls.Add(radbtn_female)
        Controls.Add(radbtn_male)
        Controls.Add(dtp_dob)
        Controls.Add(Label5)
        Controls.Add(btnSave)
        Controls.Add(TextBox_age)
        Controls.Add(TextBox_surname)
        Controls.Add(TextBox_name)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_name As TextBox
    Friend WithEvents TextBox_surname As TextBox
    Friend WithEvents TextBox_age As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents radbtn_male As RadioButton
    Friend WithEvents radbtn_female As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_phone As TextBox
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents TextBox_eid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnChart As Button
End Class
