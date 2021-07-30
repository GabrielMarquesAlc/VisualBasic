<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DATA_HORA
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
        Me.LST_DATA_HORA = New System.Windows.Forms.ListBox()
        Me.BTN_CARREGA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LST_DATA_HORA
        '
        Me.LST_DATA_HORA.FormattingEnabled = True
        Me.LST_DATA_HORA.ItemHeight = 20
        Me.LST_DATA_HORA.Location = New System.Drawing.Point(17, 14)
        Me.LST_DATA_HORA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LST_DATA_HORA.Name = "LST_DATA_HORA"
        Me.LST_DATA_HORA.Size = New System.Drawing.Size(512, 184)
        Me.LST_DATA_HORA.TabIndex = 0
        '
        'BTN_CARREGA
        '
        Me.BTN_CARREGA.Location = New System.Drawing.Point(13, 217)
        Me.BTN_CARREGA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_CARREGA.Name = "BTN_CARREGA"
        Me.BTN_CARREGA.Size = New System.Drawing.Size(123, 35)
        Me.BTN_CARREGA.TabIndex = 1
        Me.BTN_CARREGA.Text = "CARREGA"
        Me.BTN_CARREGA.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 217)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CARREGA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(275, 217)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CARREGA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(406, 217)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "CARREGA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FRM_DATA_HORA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 269)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_CARREGA)
        Me.Controls.Add(Me.LST_DATA_HORA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_DATA_HORA"
        Me.Text = "TRABALHANDO COM DATA E HORA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LST_DATA_HORA As System.Windows.Forms.ListBox
    Friend WithEvents BTN_CARREGA As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
