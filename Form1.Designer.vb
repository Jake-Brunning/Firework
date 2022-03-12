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
        Me.components = New System.ComponentModel.Container()
        Me.Fire = New System.Windows.Forms.Button()
        Me.IncreaseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ColorPicker = New System.Windows.Forms.ListBox()
        Me.Info = New System.Windows.Forms.Button()
        Me.DrawTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Fire
        '
        Me.Fire.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Fire.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fire.ForeColor = System.Drawing.Color.Crimson
        Me.Fire.Location = New System.Drawing.Point(609, 501)
        Me.Fire.Name = "Fire"
        Me.Fire.Size = New System.Drawing.Size(281, 70)
        Me.Fire.TabIndex = 0
        Me.Fire.Text = "FIRE ROCKET"
        Me.Fire.UseVisualStyleBackColor = False
        '
        'IncreaseTimer
        '
        Me.IncreaseTimer.Interval = 1000
        Me.IncreaseTimer.Tag = "Increases radius"
        '
        'ColorPicker
        '
        Me.ColorPicker.BackColor = System.Drawing.Color.Black
        Me.ColorPicker.ForeColor = System.Drawing.Color.Crimson
        Me.ColorPicker.FormattingEnabled = True
        Me.ColorPicker.Items.AddRange(New Object() {"Red", "Purple", "Blue", "Green", "Yellow", "Orange", "White"})
        Me.ColorPicker.Location = New System.Drawing.Point(896, 501)
        Me.ColorPicker.Name = "ColorPicker"
        Me.ColorPicker.Size = New System.Drawing.Size(83, 95)
        Me.ColorPicker.TabIndex = 1
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info.ForeColor = System.Drawing.Color.Crimson
        Me.Info.Location = New System.Drawing.Point(1411, 531)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(122, 40)
        Me.Info.TabIndex = 2
        Me.Info.Text = "INFO"
        Me.Info.UseVisualStyleBackColor = False
        '
        'DrawTimer
        '
        Me.DrawTimer.Tag = "Draws particles"
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.Crimson
        Me.Clear.Location = New System.Drawing.Point(12, 531)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(122, 40)
        Me.Clear.TabIndex = 3
        Me.Clear.Text = "CLEAR"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1545, 610)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.ColorPicker)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Fire)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fire As System.Windows.Forms.Button
    Friend WithEvents IncreaseTimer As System.Windows.Forms.Timer
    Friend WithEvents ColorPicker As System.Windows.Forms.ListBox
    Friend WithEvents Info As System.Windows.Forms.Button
    Friend WithEvents DrawTimer As System.Windows.Forms.Timer
    Friend WithEvents Clear As Button
End Class
