<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CSVComparison
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
        Me.OpenFile1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFile2 = New System.Windows.Forms.Button()
        Me.File1 = New System.Windows.Forms.OpenFileDialog()
        Me.File2 = New System.Windows.Forms.OpenFileDialog()
        Me.Path1 = New System.Windows.Forms.TextBox()
        Me.Path2 = New System.Windows.Forms.TextBox()
        Me.DataFile1 = New System.Windows.Forms.DataGridView()
        Me.DataFile2 = New System.Windows.Forms.DataGridView()
        Me.Compare = New System.Windows.Forms.Button()
        CType(Me.DataFile1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataFile2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFile1
        '
        Me.OpenFile1.Location = New System.Drawing.Point(496, 13)
        Me.OpenFile1.Name = "OpenFile1"
        Me.OpenFile1.Size = New System.Drawing.Size(75, 23)
        Me.OpenFile1.TabIndex = 0
        Me.OpenFile1.Text = "Open"
        Me.OpenFile1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(784, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "File 2"
        '
        'OpenFile2
        '
        Me.OpenFile2.Location = New System.Drawing.Point(1256, 15)
        Me.OpenFile2.Name = "OpenFile2"
        Me.OpenFile2.Size = New System.Drawing.Size(75, 23)
        Me.OpenFile2.TabIndex = 2
        Me.OpenFile2.Text = "Open"
        Me.OpenFile2.UseVisualStyleBackColor = True
        '
        'File1
        '
        Me.File1.FileName = "OpenFileDialog1"
        '
        'File2
        '
        Me.File2.FileName = "OpenFileDialog1"
        '
        'Path1
        '
        Me.Path1.Location = New System.Drawing.Point(72, 13)
        Me.Path1.Name = "Path1"
        Me.Path1.Size = New System.Drawing.Size(418, 22)
        Me.Path1.TabIndex = 4
        '
        'Path2
        '
        Me.Path2.Location = New System.Drawing.Point(832, 16)
        Me.Path2.Name = "Path2"
        Me.Path2.Size = New System.Drawing.Size(418, 22)
        Me.Path2.TabIndex = 5
        '
        'DataFile1
        '
        Me.DataFile1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataFile1.Location = New System.Drawing.Point(12, 42)
        Me.DataFile1.Name = "DataFile1"
        Me.DataFile1.RowHeadersWidth = 51
        Me.DataFile1.RowTemplate.Height = 24
        Me.DataFile1.Size = New System.Drawing.Size(685, 462)
        Me.DataFile1.TabIndex = 6
        '
        'DataFile2
        '
        Me.DataFile2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataFile2.Location = New System.Drawing.Point(718, 43)
        Me.DataFile2.Name = "DataFile2"
        Me.DataFile2.RowHeadersWidth = 51
        Me.DataFile2.RowTemplate.Height = 24
        Me.DataFile2.Size = New System.Drawing.Size(709, 460)
        Me.DataFile2.TabIndex = 7
        '
        'Compare
        '
        Me.Compare.Location = New System.Drawing.Point(1312, 512)
        Me.Compare.Name = "Compare"
        Me.Compare.Size = New System.Drawing.Size(95, 23)
        Me.Compare.TabIndex = 8
        Me.Compare.Text = "Compare"
        Me.Compare.UseVisualStyleBackColor = True
        '
        'CSVComparison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 547)
        Me.Controls.Add(Me.Compare)
        Me.Controls.Add(Me.DataFile2)
        Me.Controls.Add(Me.DataFile1)
        Me.Controls.Add(Me.Path2)
        Me.Controls.Add(Me.Path1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OpenFile2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpenFile1)
        Me.Name = "CSVComparison"
        Me.Text = "Path1"
        CType(Me.DataFile1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataFile2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFile1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFile2 As Button
    Friend WithEvents File1 As OpenFileDialog
    Friend WithEvents File2 As OpenFileDialog
    Friend WithEvents Path1 As TextBox
    Friend WithEvents Path2 As TextBox
    Friend WithEvents DataFile1 As DataGridView
    Friend WithEvents DataFile2 As DataGridView
    Friend WithEvents Compare As Button
End Class
