<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputSaveMoney
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputSaveMoney))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DelBut = New System.Windows.Forms.Button()
        Me.StatusSave = New System.Windows.Forms.TextBox()
        Me.StatusLBL = New System.Windows.Forms.Label()
        Me.SaveMoney = New System.Windows.Forms.TextBox()
        Me.DtSvMnyLBL = New System.Windows.Forms.Label()
        Me.Classroom = New System.Windows.Forms.TextBox()
        Me.MoneyLBL = New System.Windows.Forms.Label()
        Me.NamStu = New System.Windows.Forms.TextBox()
        Me.QuitBut = New System.Windows.Forms.Button()
        Me.SaveMoneyBut = New System.Windows.Forms.Button()
        Me.ClassLBL = New System.Windows.Forms.Label()
        Me.NamStuLBL = New System.Windows.Forms.Label()
        Me.SaveMoneyView = New System.Windows.Forms.DataGridView()
        Me.NameStudentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassStudentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveMoneyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSaveMoneyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSaveMoneyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_bank_schoollDataSet = New App_Desktop_Save_Money_Student.db_bank_schoollDataSet()
        Me.Tbl_SaveMoneyTableAdapter = New App_Desktop_Save_Money_Student.db_bank_schoollDataSetTableAdapters.tbl_SaveMoneyTableAdapter()
        Me.DateSaveMoneyTime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SaveMoneyView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSaveMoneyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_bank_schoollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.DateSaveMoneyTime)
        Me.GroupBox1.Controls.Add(Me.DelBut)
        Me.GroupBox1.Controls.Add(Me.StatusSave)
        Me.GroupBox1.Controls.Add(Me.StatusLBL)
        Me.GroupBox1.Controls.Add(Me.SaveMoney)
        Me.GroupBox1.Controls.Add(Me.DtSvMnyLBL)
        Me.GroupBox1.Controls.Add(Me.Classroom)
        Me.GroupBox1.Controls.Add(Me.MoneyLBL)
        Me.GroupBox1.Controls.Add(Me.NamStu)
        Me.GroupBox1.Controls.Add(Me.QuitBut)
        Me.GroupBox1.Controls.Add(Me.SaveMoneyBut)
        Me.GroupBox1.Controls.Add(Me.ClassLBL)
        Me.GroupBox1.Controls.Add(Me.NamStuLBL)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 527)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DelBut
        '
        Me.DelBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBut.Location = New System.Drawing.Point(153, 376)
        Me.DelBut.Name = "DelBut"
        Me.DelBut.Size = New System.Drawing.Size(96, 58)
        Me.DelBut.TabIndex = 20
        Me.DelBut.Text = "Delete"
        Me.DelBut.UseVisualStyleBackColor = True
        '
        'StatusSave
        '
        Me.StatusSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusSave.Location = New System.Drawing.Point(120, 310)
        Me.StatusSave.Name = "StatusSave"
        Me.StatusSave.Size = New System.Drawing.Size(242, 26)
        Me.StatusSave.TabIndex = 19
        '
        'StatusLBL
        '
        Me.StatusLBL.AutoSize = True
        Me.StatusLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLBL.Location = New System.Drawing.Point(6, 305)
        Me.StatusLBL.Name = "StatusLBL"
        Me.StatusLBL.Size = New System.Drawing.Size(71, 21)
        Me.StatusLBL.TabIndex = 18
        Me.StatusLBL.Text = "Status :"
        '
        'SaveMoney
        '
        Me.SaveMoney.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveMoney.Location = New System.Drawing.Point(120, 177)
        Me.SaveMoney.Name = "SaveMoney"
        Me.SaveMoney.Size = New System.Drawing.Size(242, 26)
        Me.SaveMoney.TabIndex = 17
        '
        'DtSvMnyLBL
        '
        Me.DtSvMnyLBL.AutoSize = True
        Me.DtSvMnyLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtSvMnyLBL.Location = New System.Drawing.Point(6, 237)
        Me.DtSvMnyLBL.Name = "DtSvMnyLBL"
        Me.DtSvMnyLBL.Size = New System.Drawing.Size(171, 21)
        Me.DtSvMnyLBL.TabIndex = 18
        Me.DtSvMnyLBL.Text = "Date Save Money :"
        '
        'Classroom
        '
        Me.Classroom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classroom.Location = New System.Drawing.Point(120, 108)
        Me.Classroom.Name = "Classroom"
        Me.Classroom.Size = New System.Drawing.Size(242, 26)
        Me.Classroom.TabIndex = 15
        '
        'MoneyLBL
        '
        Me.MoneyLBL.AutoSize = True
        Me.MoneyLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyLBL.Location = New System.Drawing.Point(6, 172)
        Me.MoneyLBL.Name = "MoneyLBL"
        Me.MoneyLBL.Size = New System.Drawing.Size(78, 21)
        Me.MoneyLBL.TabIndex = 16
        Me.MoneyLBL.Text = "Money :"
        '
        'NamStu
        '
        Me.NamStu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamStu.Location = New System.Drawing.Point(153, 25)
        Me.NamStu.Name = "NamStu"
        Me.NamStu.Size = New System.Drawing.Size(192, 26)
        Me.NamStu.TabIndex = 14
        '
        'QuitBut
        '
        Me.QuitBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBut.Location = New System.Drawing.Point(293, 376)
        Me.QuitBut.Name = "QuitBut"
        Me.QuitBut.Size = New System.Drawing.Size(96, 58)
        Me.QuitBut.TabIndex = 13
        Me.QuitBut.Text = "Quit"
        Me.QuitBut.UseVisualStyleBackColor = True
        '
        'SaveMoneyBut
        '
        Me.SaveMoneyBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveMoneyBut.Location = New System.Drawing.Point(10, 376)
        Me.SaveMoneyBut.Name = "SaveMoneyBut"
        Me.SaveMoneyBut.Size = New System.Drawing.Size(99, 58)
        Me.SaveMoneyBut.TabIndex = 12
        Me.SaveMoneyBut.Text = "Save Money"
        Me.SaveMoneyBut.UseVisualStyleBackColor = True
        '
        'ClassLBL
        '
        Me.ClassLBL.AutoSize = True
        Me.ClassLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassLBL.Location = New System.Drawing.Point(6, 103)
        Me.ClassLBL.Name = "ClassLBL"
        Me.ClassLBL.Size = New System.Drawing.Size(103, 21)
        Me.ClassLBL.TabIndex = 11
        Me.ClassLBL.Text = "Classroom :"
        '
        'NamStuLBL
        '
        Me.NamStuLBL.AutoSize = True
        Me.NamStuLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamStuLBL.Location = New System.Drawing.Point(6, 27)
        Me.NamStuLBL.Name = "NamStuLBL"
        Me.NamStuLBL.Size = New System.Drawing.Size(141, 21)
        Me.NamStuLBL.TabIndex = 10
        Me.NamStuLBL.Text = "Name Student :"
        '
        'SaveMoneyView
        '
        Me.SaveMoneyView.AutoGenerateColumns = False
        Me.SaveMoneyView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.SaveMoneyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaveMoneyView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameStudentDataGridViewTextBoxColumn, Me.ClassStudentDataGridViewTextBoxColumn, Me.SaveMoneyDataGridViewTextBoxColumn, Me.DateSaveMoneyDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.SaveMoneyView.DataSource = Me.TblSaveMoneyBindingSource
        Me.SaveMoneyView.GridColor = System.Drawing.Color.Salmon
        Me.SaveMoneyView.Location = New System.Drawing.Point(467, 12)
        Me.SaveMoneyView.Name = "SaveMoneyView"
        Me.SaveMoneyView.Size = New System.Drawing.Size(519, 203)
        Me.SaveMoneyView.TabIndex = 1
        '
        'NameStudentDataGridViewTextBoxColumn
        '
        Me.NameStudentDataGridViewTextBoxColumn.DataPropertyName = "Name_Student"
        Me.NameStudentDataGridViewTextBoxColumn.HeaderText = "Name_Student"
        Me.NameStudentDataGridViewTextBoxColumn.Name = "NameStudentDataGridViewTextBoxColumn"
        '
        'ClassStudentDataGridViewTextBoxColumn
        '
        Me.ClassStudentDataGridViewTextBoxColumn.DataPropertyName = "Class_Student"
        Me.ClassStudentDataGridViewTextBoxColumn.HeaderText = "Class_Student"
        Me.ClassStudentDataGridViewTextBoxColumn.Name = "ClassStudentDataGridViewTextBoxColumn"
        '
        'SaveMoneyDataGridViewTextBoxColumn
        '
        Me.SaveMoneyDataGridViewTextBoxColumn.DataPropertyName = "Save_Money"
        Me.SaveMoneyDataGridViewTextBoxColumn.HeaderText = "Save_Money"
        Me.SaveMoneyDataGridViewTextBoxColumn.Name = "SaveMoneyDataGridViewTextBoxColumn"
        '
        'DateSaveMoneyDataGridViewTextBoxColumn
        '
        Me.DateSaveMoneyDataGridViewTextBoxColumn.DataPropertyName = "Date_SaveMoney"
        Me.DateSaveMoneyDataGridViewTextBoxColumn.HeaderText = "Date_SaveMoney"
        Me.DateSaveMoneyDataGridViewTextBoxColumn.Name = "DateSaveMoneyDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TblSaveMoneyBindingSource
        '
        Me.TblSaveMoneyBindingSource.DataMember = "tbl_SaveMoney"
        Me.TblSaveMoneyBindingSource.DataSource = Me.Db_bank_schoollDataSet
        '
        'Db_bank_schoollDataSet
        '
        Me.Db_bank_schoollDataSet.DataSetName = "db_bank_schoollDataSet"
        Me.Db_bank_schoollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_SaveMoneyTableAdapter
        '
        Me.Tbl_SaveMoneyTableAdapter.ClearBeforeFill = True
        '
        'DateSaveMoneyTime
        '
        Me.DateSaveMoneyTime.CustomFormat = "dd-MM-yyy"
        Me.DateSaveMoneyTime.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateSaveMoneyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateSaveMoneyTime.Location = New System.Drawing.Point(183, 238)
        Me.DateSaveMoneyTime.Name = "DateSaveMoneyTime"
        Me.DateSaveMoneyTime.Size = New System.Drawing.Size(200, 24)
        Me.DateSaveMoneyTime.TabIndex = 21
        '
        'InputSaveMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(998, 458)
        Me.Controls.Add(Me.SaveMoneyView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InputSaveMoney"
        Me.Text = "InputSaveMoney"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SaveMoneyView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSaveMoneyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_bank_schoollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Classroom As TextBox
    Friend WithEvents NamStu As TextBox
    Friend WithEvents QuitBut As Button
    Friend WithEvents SaveMoneyBut As Button
    Friend WithEvents ClassLBL As Label
    Friend WithEvents NamStuLBL As Label
    Friend WithEvents SaveMoney As TextBox
    Friend WithEvents MoneyLBL As Label
    Friend WithEvents DtSvMnyLBL As Label
    Friend WithEvents StatusSave As TextBox
    Friend WithEvents StatusLBL As Label
    Friend WithEvents SaveMoneyView As DataGridView
    Friend WithEvents Db_bank_schoollDataSet As db_bank_schoollDataSet
    Friend WithEvents TblSaveMoneyBindingSource As BindingSource
    Friend WithEvents Tbl_SaveMoneyTableAdapter As db_bank_schoollDataSetTableAdapters.tbl_SaveMoneyTableAdapter
    Friend WithEvents NameStudentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassStudentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaveMoneyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateSaveMoneyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelBut As Button
    Friend WithEvents DateSaveMoneyTime As DateTimePicker
End Class
