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
        Me.ButtonPost = New System.Windows.Forms.Button
        Me.TextBoxRequest = New System.Windows.Forms.TextBox
        Me.TextBoxResult = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ButtonPost
        '
        Me.ButtonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPost.Location = New System.Drawing.Point(12, 422)
        Me.ButtonPost.Name = "ButtonPost"
        Me.ButtonPost.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPost.TabIndex = 11
        Me.ButtonPost.Text = "Post"
        Me.ButtonPost.UseVisualStyleBackColor = True
        '
        'TextBoxRequest
        '
        Me.TextBoxRequest.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxRequest.MaxLength = 0
        Me.TextBoxRequest.Multiline = True
        Me.TextBoxRequest.Name = "TextBoxRequest"
        Me.TextBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxRequest.Size = New System.Drawing.Size(833, 168)
        Me.TextBoxRequest.TabIndex = 9
        Me.TextBoxRequest.WordWrap = False
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(12, 192)
        Me.TextBoxResult.MaxLength = 0
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxResult.Size = New System.Drawing.Size(833, 224)
        Me.TextBoxResult.TabIndex = 10
        Me.TextBoxResult.WordWrap = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 455)
        Me.Controls.Add(Me.ButtonPost)
        Me.Controls.Add(Me.TextBoxRequest)
        Me.Controls.Add(Me.TextBoxResult)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MT940 Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonPost As System.Windows.Forms.Button
    Friend WithEvents TextBoxRequest As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxResult As System.Windows.Forms.TextBox

End Class
