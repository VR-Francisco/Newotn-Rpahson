<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.la = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.lcs = New System.Windows.Forms.Label()
        Me.lf = New System.Windows.Forms.Label()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.tcs = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.td = New System.Windows.Forms.TextBox()
        Me.ld = New System.Windows.Forms.Label()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(67, 27)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(44, 13)
        Me.la.TabIndex = 0
        Me.la.Text = "Dame a"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(67, 58)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(44, 13)
        Me.lb.TabIndex = 1
        Me.lb.Text = "Dame b"
        '
        'lcs
        '
        Me.lcs.AutoSize = True
        Me.lcs.Location = New System.Drawing.Point(67, 90)
        Me.lcs.Name = "lcs"
        Me.lcs.Size = New System.Drawing.Size(71, 13)
        Me.lcs.TabIndex = 2
        Me.lcs.Text = "Dame cifras s"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(67, 123)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(73, 13)
        Me.lf.TabIndex = 3
        Me.lf.Text = "Dame función"
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(184, 24)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(100, 20)
        Me.ta.TabIndex = 4
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(184, 55)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(100, 20)
        Me.tb.TabIndex = 5
        '
        'tcs
        '
        Me.tcs.Location = New System.Drawing.Point(184, 90)
        Me.tcs.Name = "tcs"
        Me.tcs.Size = New System.Drawing.Size(100, 20)
        Me.tcs.TabIndex = 6
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(184, 123)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 7
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(44, 190)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(490, 247)
        Me.salida.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "i"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "xi"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "error"
        Me.Column3.Name = "Column3"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(441, 85)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 9
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(441, 123)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'td
        '
        Me.td.Location = New System.Drawing.Point(184, 152)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(100, 20)
        Me.td.TabIndex = 11
        '
        'ld
        '
        Me.ld.AutoSize = True
        Me.ld.Location = New System.Drawing.Point(67, 152)
        Me.ld.Name = "ld"
        Me.ld.Size = New System.Drawing.Size(79, 13)
        Me.ld.TabIndex = 12
        Me.ld.Text = "Dame derivada"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 467)
        Me.Controls.Add(Me.ld)
        Me.Controls.Add(Me.td)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.tcs)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.lf)
        Me.Controls.Add(Me.lcs)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.la)
        Me.Name = "Form1"
        Me.Text = "Newthon Rhapson"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents la As Label
    Friend WithEvents lb As Label
    Friend WithEvents lcs As Label
    Friend WithEvents lf As Label
    Friend WithEvents ta As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents tcs As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents salida As DataGridView
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents td As TextBox
    Friend WithEvents ld As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
