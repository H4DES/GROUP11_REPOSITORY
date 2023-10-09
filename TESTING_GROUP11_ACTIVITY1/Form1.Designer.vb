<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnMSSQL = New System.Windows.Forms.Button()
        Me.btnMYSQL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMSSQL
        '
        Me.btnMSSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMSSQL.Location = New System.Drawing.Point(30, 51)
        Me.btnMSSQL.Name = "btnMSSQL"
        Me.btnMSSQL.Size = New System.Drawing.Size(231, 99)
        Me.btnMSSQL.TabIndex = 0
        Me.btnMSSQL.Text = "TEST CONNECTION (MSSQL)"
        Me.btnMSSQL.UseVisualStyleBackColor = True
        '
        'btnMYSQL
        '
        Me.btnMYSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMYSQL.Location = New System.Drawing.Point(290, 51)
        Me.btnMYSQL.Name = "btnMYSQL"
        Me.btnMYSQL.Size = New System.Drawing.Size(231, 99)
        Me.btnMYSQL.TabIndex = 1
        Me.btnMYSQL.Text = "TEST CONNECTION (MYSQL)"
        Me.btnMYSQL.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 204)
        Me.Controls.Add(Me.btnMYSQL)
        Me.Controls.Add(Me.btnMSSQL)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSSQL_MYSQL_TestConnection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMSSQL As Button
    Friend WithEvents btnMYSQL As Button
End Class
