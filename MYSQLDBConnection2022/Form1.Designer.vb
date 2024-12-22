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
        btnTest = New Button()
        Label1 = New Label()
        Label2 = New Label()
        usernameTextBox = New TextBox()
        passwordTextBox = New TextBox()
        loginBtn = New Button()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(12, 12)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(217, 38)
        btnTest.TabIndex = 0
        btnTest.Text = "Check Connection"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(185, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 22)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 22)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(283, 82)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(133, 29)
        usernameTextBox.TabIndex = 3
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(283, 125)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.PasswordChar = "*"c
        passwordTextBox.Size = New Size(133, 29)
        passwordTextBox.TabIndex = 4
        ' 
        ' loginBtn
        ' 
        loginBtn.Location = New Point(283, 172)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(78, 35)
        loginBtn.TabIndex = 5
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(438, 336)
        Controls.Add(loginBtn)
        Controls.Add(passwordTextBox)
        Controls.Add(usernameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnTest)
        Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents loginBtn As Button

End Class
