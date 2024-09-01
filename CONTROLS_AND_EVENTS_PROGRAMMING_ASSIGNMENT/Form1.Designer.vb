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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtCore = New System.Windows.Forms.TextBox()
        Me.picStudentImage = New System.Windows.Forms.PictureBox()
        Me.lblStudent = New System.Windows.Forms.Label()
        CType(Me.picStudentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(375, 34)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 77)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(610, 34)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(157, 77)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtCore
        '
        Me.txtCore.BackColor = System.Drawing.SystemColors.Info
        Me.txtCore.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCore.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtCore.Location = New System.Drawing.Point(28, 168)
        Me.txtCore.Multiline = True
        Me.txtCore.Name = "txtCore"
        Me.txtCore.Size = New System.Drawing.Size(238, 93)
        Me.txtCore.TabIndex = 2
        Me.txtCore.TabStop = False
        Me.txtCore.Text = "Therefore everyone who hears these words of mine and puts them into practice is l" &
    "ike a wise man who built his house on the rock. - Matthew 7:24"
        Me.txtCore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picStudentImage
        '
        Me.picStudentImage.Image = Global.CONTROLS_AND_EVENTS_PROGRAMMING_ASSIGNMENT.My.Resources.Resources.IMG_6160
        Me.picStudentImage.Location = New System.Drawing.Point(303, 117)
        Me.picStudentImage.Name = "picStudentImage"
        Me.picStudentImage.Size = New System.Drawing.Size(464, 299)
        Me.picStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentImage.TabIndex = 3
        Me.picStudentImage.TabStop = False
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(270, 9)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(217, 13)
        Me.lblStudent.TabIndex = 4
        Me.lblStudent.Text = "Josiah Barringer | Dr.  O'Malley | 25AUG2024"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.txtCore)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.picStudentImage)
        Me.Name = "Form1"
        Me.Text = "Foundation Assignment"
        CType(Me.picStudentImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtCore As TextBox
    Friend WithEvents picStudentImage As PictureBox
    Friend WithEvents lblStudent As Label
End Class
