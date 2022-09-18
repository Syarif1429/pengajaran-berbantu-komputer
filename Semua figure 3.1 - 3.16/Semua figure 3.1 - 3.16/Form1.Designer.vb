<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnIntMath = New System.Windows.Forms.Button()
        Me.btnFloatMath = New System.Windows.Forms.Button()
        Me.btnStrings = New System.Windows.Forms.Button()
        Me.btnConcatenation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(109, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add  1 to int Number"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnIntMath
        '
        Me.btnIntMath.Location = New System.Drawing.Point(109, 41)
        Me.btnIntMath.Name = "btnIntMath"
        Me.btnIntMath.Size = New System.Drawing.Size(75, 23)
        Me.btnIntMath.TabIndex = 1
        Me.btnIntMath.Text = "Math Test"
        Me.btnIntMath.UseVisualStyleBackColor = True
        '
        'btnFloatMath
        '
        Me.btnFloatMath.Location = New System.Drawing.Point(109, 70)
        Me.btnFloatMath.Name = "btnFloatMath"
        Me.btnFloatMath.Size = New System.Drawing.Size(75, 23)
        Me.btnFloatMath.TabIndex = 2
        Me.btnFloatMath.Text = "Double Test"
        Me.btnFloatMath.UseVisualStyleBackColor = True
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(293, 11)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(160, 23)
        Me.btnStrings.TabIndex = 3
        Me.btnStrings.Text = "Using String"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(293, 41)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(160, 23)
        Me.btnConcatenation.TabIndex = 4
        Me.btnConcatenation.Text = "Concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 278)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnStrings)
        Me.Controls.Add(Me.btnFloatMath)
        Me.Controls.Add(Me.btnIntMath)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnIntMath As Button
    Friend WithEvents btnFloatMath As Button
    Friend WithEvents btnStrings As Button
    Friend WithEvents btnConcatenation As Button
End Class
