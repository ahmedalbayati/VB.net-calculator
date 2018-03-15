<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.tbAnswer = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAC = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnParenthesesLeft = New System.Windows.Forms.Button()
        Me.btnParenthesesRight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(26, 211)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(56, 58)
        Me.btnOne.TabIndex = 9
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(88, 211)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(56, 58)
        Me.btnTwo.TabIndex = 10
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(150, 211)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(56, 58)
        Me.btnThree.TabIndex = 11
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(26, 147)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(56, 58)
        Me.btnFour.TabIndex = 12
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(88, 147)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(56, 58)
        Me.btnFive.TabIndex = 13
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Location = New System.Drawing.Point(150, 147)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(56, 58)
        Me.btnSix.TabIndex = 14
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Location = New System.Drawing.Point(26, 83)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(56, 58)
        Me.btnSeven.TabIndex = 15
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Location = New System.Drawing.Point(88, 83)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(56, 58)
        Me.btnEight.TabIndex = 16
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Location = New System.Drawing.Point(150, 83)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(56, 58)
        Me.btnNine.TabIndex = 17
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Location = New System.Drawing.Point(26, 275)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(56, 58)
        Me.btnZero.TabIndex = 18
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(88, 275)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(56, 58)
        Me.btnDot.TabIndex = 19
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(150, 275)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(56, 58)
        Me.btnEquals.TabIndex = 20
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'tbAnswer
        '
        Me.tbAnswer.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbAnswer.Enabled = False
        Me.tbAnswer.Font = New System.Drawing.Font("Arial", 32.0!)
        Me.tbAnswer.Location = New System.Drawing.Point(26, 12)
        Me.tbAnswer.Multiline = True
        Me.tbAnswer.Name = "tbAnswer"
        Me.tbAnswer.ReadOnly = True
        Me.tbAnswer.Size = New System.Drawing.Size(304, 53)
        Me.tbAnswer.TabIndex = 21
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Brown
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.Location = New System.Drawing.Point(212, 83)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 58)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "DEL"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAC
        '
        Me.btnAC.BackColor = System.Drawing.Color.Brown
        Me.btnAC.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAC.Location = New System.Drawing.Point(274, 83)
        Me.btnAC.Name = "btnAC"
        Me.btnAC.Size = New System.Drawing.Size(56, 58)
        Me.btnAC.TabIndex = 23
        Me.btnAC.Text = "AC"
        Me.btnAC.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(212, 211)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(56, 58)
        Me.btnMultiply.TabIndex = 24
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(274, 211)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(56, 58)
        Me.btnDivide.TabIndex = 25
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(212, 275)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 58)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(274, 275)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(56, 58)
        Me.btnSubtract.TabIndex = 27
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnParenthesesLeft
        '
        Me.btnParenthesesLeft.Location = New System.Drawing.Point(212, 147)
        Me.btnParenthesesLeft.Name = "btnParenthesesLeft"
        Me.btnParenthesesLeft.Size = New System.Drawing.Size(56, 58)
        Me.btnParenthesesLeft.TabIndex = 28
        Me.btnParenthesesLeft.Text = "("
        Me.btnParenthesesLeft.UseVisualStyleBackColor = True
        '
        'btnParenthesesRight
        '
        Me.btnParenthesesRight.Location = New System.Drawing.Point(274, 147)
        Me.btnParenthesesRight.Name = "btnParenthesesRight"
        Me.btnParenthesesRight.Size = New System.Drawing.Size(56, 58)
        Me.btnParenthesesRight.TabIndex = 29
        Me.btnParenthesesRight.Text = ")"
        Me.btnParenthesesRight.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 348)
        Me.Controls.Add(Me.btnParenthesesRight)
        Me.Controls.Add(Me.btnParenthesesLeft)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnAC)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.tbAnswer)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.MaximumSize = New System.Drawing.Size(371, 387)
        Me.MinimumSize = New System.Drawing.Size(371, 387)
        Me.Name = "frmCalculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents tbAnswer As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAC As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnParenthesesLeft As Button
    Friend WithEvents btnParenthesesRight As Button
End Class
