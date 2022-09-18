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
        Me.btnStrings = New System.Windows.Forms.Button()
        Me.btnConcatenation = New System.Windows.Forms.Button()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnSubStrings = New System.Windows.Forms.Button()
        Me.btnFloatMath = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnDateProperties = New System.Windows.Forms.Button()
        Me.btnDateNames = New System.Windows.Forms.Button()
        Me.btnDateLiterals = New System.Windows.Forms.Button()
        Me.btnDateManipulation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(398, 32)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(177, 23)
        Me.btnStrings.TabIndex = 0
        Me.btnStrings.Text = "Using Strings"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(398, 62)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(177, 23)
        Me.btnConcatenation.TabIndex = 1
        Me.btnConcatenation.Text = "Concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(516, 92)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(59, 23)
        Me.btnLength.TabIndex = 3
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(398, 92)
        Me.txtString.Multiline = True
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(114, 20)
        Me.txtString.TabIndex = 4
        '
        'btnSubStrings
        '
        Me.btnSubStrings.Location = New System.Drawing.Point(398, 134)
        Me.btnSubStrings.Name = "btnSubStrings"
        Me.btnSubStrings.Size = New System.Drawing.Size(90, 23)
        Me.btnSubStrings.TabIndex = 5
        Me.btnSubStrings.Text = "SubStrings"
        Me.btnSubStrings.UseVisualStyleBackColor = True
        '
        'btnFloatMath
        '
        Me.btnFloatMath.Location = New System.Drawing.Point(398, 163)
        Me.btnFloatMath.Name = "btnFloatMath"
        Me.btnFloatMath.Size = New System.Drawing.Size(90, 23)
        Me.btnFloatMath.TabIndex = 6
        Me.btnFloatMath.Text = "Double Test"
        Me.btnFloatMath.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(500, 163)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 7
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(214, 32)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(75, 23)
        Me.btnShowDate.TabIndex = 8
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnDateProperties
        '
        Me.btnDateProperties.Location = New System.Drawing.Point(214, 61)
        Me.btnDateProperties.Name = "btnDateProperties"
        Me.btnDateProperties.Size = New System.Drawing.Size(93, 23)
        Me.btnDateProperties.TabIndex = 9
        Me.btnDateProperties.Text = "Date Properties"
        Me.btnDateProperties.UseVisualStyleBackColor = True
        '
        'btnDateNames
        '
        Me.btnDateNames.Location = New System.Drawing.Point(214, 89)
        Me.btnDateNames.Name = "btnDateNames"
        Me.btnDateNames.Size = New System.Drawing.Size(93, 23)
        Me.btnDateNames.TabIndex = 10
        Me.btnDateNames.Text = "Data Names"
        Me.btnDateNames.UseVisualStyleBackColor = True
        '
        'btnDateLiterals
        '
        Me.btnDateLiterals.Location = New System.Drawing.Point(214, 118)
        Me.btnDateLiterals.Name = "btnDateLiterals"
        Me.btnDateLiterals.Size = New System.Drawing.Size(93, 23)
        Me.btnDateLiterals.TabIndex = 11
        Me.btnDateLiterals.Text = "Date Literals"
        Me.btnDateLiterals.UseVisualStyleBackColor = True
        '
        'btnDateManipulation
        '
        Me.btnDateManipulation.Location = New System.Drawing.Point(214, 147)
        Me.btnDateManipulation.Name = "btnDateManipulation"
        Me.btnDateManipulation.Size = New System.Drawing.Size(114, 23)
        Me.btnDateManipulation.TabIndex = 12
        Me.btnDateManipulation.Text = "Date Manipulation"
        Me.btnDateManipulation.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 324)
        Me.Controls.Add(Me.btnDateManipulation)
        Me.Controls.Add(Me.btnDateLiterals)
        Me.Controls.Add(Me.btnDateNames)
        Me.Controls.Add(Me.btnDateProperties)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnFloatMath)
        Me.Controls.Add(Me.btnSubStrings)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnStrings)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStrings As Button
    Friend WithEvents btnConcatenation As Button
    Friend WithEvents btnLength As Button
    Friend WithEvents txtString As TextBox
    Friend WithEvents btnSubStrings As Button
    Friend WithEvents btnFloatMath As Button
    Friend WithEvents btnReplace As Button
    Friend WithEvents btnShowDate As Button
    Friend WithEvents btnDateProperties As Button
    Friend WithEvents btnDateNames As Button
    Friend WithEvents btnDateLiterals As Button
    Friend WithEvents btnDateManipulation As Button
End Class
