<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.btnMSSQL_INSERT = New System.Windows.Forms.Button()
        Me.btnMYSQL_INSERT = New System.Windows.Forms.Button()
        Me.course = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_MS_Update = New System.Windows.Forms.Button()
        Me.btn_MY_Update = New System.Windows.Forms.Button()
        Me.btn_MS_Delete = New System.Windows.Forms.Button()
        Me.btn_MY_Delete = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columncourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_MSloadRecords = New System.Windows.Forms.Button()
        Me.btn_MYloadRecords = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID NO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FIRST NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MIDDLE NAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LAST NAME:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(188, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(242, 29)
        Me.txtID.TabIndex = 4
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(188, 68)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(242, 29)
        Me.txtfname.TabIndex = 5
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(188, 116)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(242, 29)
        Me.txtmname.TabIndex = 6
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(188, 160)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(242, 29)
        Me.txtlname.TabIndex = 7
        '
        'btnMSSQL_INSERT
        '
        Me.btnMSSQL_INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMSSQL_INSERT.Location = New System.Drawing.Point(84, 244)
        Me.btnMSSQL_INSERT.Name = "btnMSSQL_INSERT"
        Me.btnMSSQL_INSERT.Size = New System.Drawing.Size(139, 58)
        Me.btnMSSQL_INSERT.TabIndex = 8
        Me.btnMSSQL_INSERT.Text = "REGISTER (MSSQL)"
        Me.btnMSSQL_INSERT.UseVisualStyleBackColor = True
        '
        'btnMYSQL_INSERT
        '
        Me.btnMYSQL_INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMYSQL_INSERT.Location = New System.Drawing.Point(251, 244)
        Me.btnMYSQL_INSERT.Name = "btnMYSQL_INSERT"
        Me.btnMYSQL_INSERT.Size = New System.Drawing.Size(139, 58)
        Me.btnMYSQL_INSERT.TabIndex = 9
        Me.btnMYSQL_INSERT.Text = "REGISTER (MYSQL)"
        Me.btnMYSQL_INSERT.UseVisualStyleBackColor = True
        '
        'course
        '
        Me.course.FormattingEnabled = True
        Me.course.Items.AddRange(New Object() {"BSIT", "BSHM", "BSBA", "BST"})
        Me.course.Location = New System.Drawing.Point(188, 207)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(242, 21)
        Me.course.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "COURSE:"
        '
        'btn_MS_Update
        '
        Me.btn_MS_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MS_Update.Location = New System.Drawing.Point(84, 308)
        Me.btn_MS_Update.Name = "btn_MS_Update"
        Me.btn_MS_Update.Size = New System.Drawing.Size(139, 58)
        Me.btn_MS_Update.TabIndex = 12
        Me.btn_MS_Update.Text = "UPDATE (MSSQL)"
        Me.btn_MS_Update.UseVisualStyleBackColor = True
        '
        'btn_MY_Update
        '
        Me.btn_MY_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MY_Update.Location = New System.Drawing.Point(251, 308)
        Me.btn_MY_Update.Name = "btn_MY_Update"
        Me.btn_MY_Update.Size = New System.Drawing.Size(139, 58)
        Me.btn_MY_Update.TabIndex = 13
        Me.btn_MY_Update.Text = "UPDATE (MYSQL)"
        Me.btn_MY_Update.UseVisualStyleBackColor = True
        '
        'btn_MS_Delete
        '
        Me.btn_MS_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MS_Delete.Location = New System.Drawing.Point(84, 372)
        Me.btn_MS_Delete.Name = "btn_MS_Delete"
        Me.btn_MS_Delete.Size = New System.Drawing.Size(139, 58)
        Me.btn_MS_Delete.TabIndex = 14
        Me.btn_MS_Delete.Text = "DELETE (MSSQL)"
        Me.btn_MS_Delete.UseVisualStyleBackColor = True
        '
        'btn_MY_Delete
        '
        Me.btn_MY_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MY_Delete.Location = New System.Drawing.Point(251, 372)
        Me.btn_MY_Delete.Name = "btn_MY_Delete"
        Me.btn_MY_Delete.Size = New System.Drawing.Size(139, 58)
        Me.btn_MY_Delete.TabIndex = 15
        Me.btn_MY_Delete.Text = "DELETE (MYSQL)"
        Me.btn_MY_Delete.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5})
        Me.DataGridView2.Location = New System.Drawing.Point(479, 290)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(371, 214)
        Me.DataGridView2.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idno"
        Me.Column1.FillWeight = 100.2717!
        Me.Column1.HeaderText = "ID NO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 123
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "fullname"
        Me.Column2.FillWeight = 125.1077!
        Me.Column2.HeaderText = "FULL NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "course"
        Me.Column5.FillWeight = 74.62054!
        Me.Column5.HeaderText = "COURSE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 92
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idno, Me.fullname, Me.Columncourse})
        Me.DataGridView1.Location = New System.Drawing.Point(479, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(371, 214)
        Me.DataGridView1.TabIndex = 18
        '
        'idno
        '
        Me.idno.DataPropertyName = "idno"
        Me.idno.HeaderText = "ID NO"
        Me.idno.Name = "idno"
        Me.idno.ReadOnly = True
        '
        'fullname
        '
        Me.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "FULL NAME"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        '
        'Columncourse
        '
        Me.Columncourse.DataPropertyName = "course"
        Me.Columncourse.HeaderText = "COURSE"
        Me.Columncourse.Name = "Columncourse"
        Me.Columncourse.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(475, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "DATA GRID VIEW (MYSQL)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(475, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "DATA GRID VIEW (MSSQL)"
        '
        'btn_MSloadRecords
        '
        Me.btn_MSloadRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MSloadRecords.Location = New System.Drawing.Point(84, 436)
        Me.btn_MSloadRecords.Name = "btn_MSloadRecords"
        Me.btn_MSloadRecords.Size = New System.Drawing.Size(139, 68)
        Me.btn_MSloadRecords.TabIndex = 22
        Me.btn_MSloadRecords.Text = "LOAD RECORDS (MSSQL)"
        Me.btn_MSloadRecords.UseVisualStyleBackColor = True
        '
        'btn_MYloadRecords
        '
        Me.btn_MYloadRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MYloadRecords.Location = New System.Drawing.Point(251, 436)
        Me.btn_MYloadRecords.Name = "btn_MYloadRecords"
        Me.btn_MYloadRecords.Size = New System.Drawing.Size(139, 68)
        Me.btn_MYloadRecords.TabIndex = 23
        Me.btn_MYloadRecords.Text = "LOAD RECORDS (MYSQL)"
        Me.btn_MYloadRecords.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 516)
        Me.Controls.Add(Me.btn_MYloadRecords)
        Me.Controls.Add(Me.btn_MSloadRecords)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_MY_Delete)
        Me.Controls.Add(Me.btn_MS_Delete)
        Me.Controls.Add(Me.btn_MY_Update)
        Me.Controls.Add(Me.btn_MS_Update)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.btnMYSQL_INSERT)
        Me.Controls.Add(Me.btnMSSQL_INSERT)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSSQL_MYSQL_INSERTRECORDSvb"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents btnMSSQL_INSERT As Button
    Friend WithEvents btnMYSQL_INSERT As Button
    Friend WithEvents course As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_MS_Update As Button
    Friend WithEvents btn_MY_Update As Button
    Friend WithEvents btn_MS_Delete As Button
    Friend WithEvents btn_MY_Delete As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idno As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents Columncourse As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_MSloadRecords As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btn_MYloadRecords As Button
End Class
