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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddSeconds = New System.Windows.Forms.Button()
        Me.btnAddminutes = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnAddSeconds
        '
        Me.btnAddSeconds.Location = New System.Drawing.Point(78, 79)
        Me.btnAddSeconds.Name = "btnAddSeconds"
        Me.btnAddSeconds.Size = New System.Drawing.Size(129, 45)
        Me.btnAddSeconds.TabIndex = 1
        Me.btnAddSeconds.Text = "Add 5 second"
        Me.btnAddSeconds.UseVisualStyleBackColor = True
        '
        'btnAddminutes
        '
        Me.btnAddminutes.Location = New System.Drawing.Point(78, 141)
        Me.btnAddminutes.Name = "btnAddminutes"
        Me.btnAddminutes.Size = New System.Drawing.Size(129, 45)
        Me.btnAddminutes.TabIndex = 2
        Me.btnAddminutes.Text = "Add 5 minutes"
        Me.btnAddminutes.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Location = New System.Drawing.Point(252, 79)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(39, 13)
        Me.lblCurrentTime.TabIndex = 3
        Me.lblCurrentTime.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 327)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.btnAddminutes)
        Me.Controls.Add(Me.btnAddSeconds)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddSeconds As Button
    Friend WithEvents btnAddminutes As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblCurrentTime As Label
End Class
