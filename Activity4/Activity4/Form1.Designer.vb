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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubtractionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem, Me.SimpleOperationToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(379, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonToolStripMenuItem, Me.CheckBoxToolStripMenuItem, Me.RadioButtonToolStripMenuItem, Me.DateTimePickerToolStripMenuItem})
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(76, 27)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'SimpleOperationToolStripMenuItem
        '
        Me.SimpleOperationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdditionToolStripMenuItem, Me.SubtractionToolStripMenuItem, Me.MultiplicationToolStripMenuItem, Me.DivisionToolStripMenuItem})
        Me.SimpleOperationToolStripMenuItem.Name = "SimpleOperationToolStripMenuItem"
        Me.SimpleOperationToolStripMenuItem.Size = New System.Drawing.Size(134, 27)
        Me.SimpleOperationToolStripMenuItem.Text = "Simple Operation"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MeToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(61, 27)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ButtonToolStripMenuItem
        '
        Me.ButtonToolStripMenuItem.Name = "ButtonToolStripMenuItem"
        Me.ButtonToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.ButtonToolStripMenuItem.Text = "Button"
        '
        'CheckBoxToolStripMenuItem
        '
        Me.CheckBoxToolStripMenuItem.Name = "CheckBoxToolStripMenuItem"
        Me.CheckBoxToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.CheckBoxToolStripMenuItem.Text = "Check Box"
        '
        'RadioButtonToolStripMenuItem
        '
        Me.RadioButtonToolStripMenuItem.Name = "RadioButtonToolStripMenuItem"
        Me.RadioButtonToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.RadioButtonToolStripMenuItem.Text = "Radio Button"
        '
        'DateTimePickerToolStripMenuItem
        '
        Me.DateTimePickerToolStripMenuItem.Name = "DateTimePickerToolStripMenuItem"
        Me.DateTimePickerToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.DateTimePickerToolStripMenuItem.Text = "Date Time Picker"
        '
        'AdditionToolStripMenuItem
        '
        Me.AdditionToolStripMenuItem.Name = "AdditionToolStripMenuItem"
        Me.AdditionToolStripMenuItem.Size = New System.Drawing.Size(166, 28)
        Me.AdditionToolStripMenuItem.Text = "Addition"
        '
        'SubtractionToolStripMenuItem
        '
        Me.SubtractionToolStripMenuItem.Name = "SubtractionToolStripMenuItem"
        Me.SubtractionToolStripMenuItem.Size = New System.Drawing.Size(166, 28)
        Me.SubtractionToolStripMenuItem.Text = "Subtraction"
        '
        'MultiplicationToolStripMenuItem
        '
        Me.MultiplicationToolStripMenuItem.Name = "MultiplicationToolStripMenuItem"
        Me.MultiplicationToolStripMenuItem.Size = New System.Drawing.Size(166, 28)
        Me.MultiplicationToolStripMenuItem.Text = "Multiplication"
        '
        'DivisionToolStripMenuItem
        '
        Me.DivisionToolStripMenuItem.Name = "DivisionToolStripMenuItem"
        Me.DivisionToolStripMenuItem.Size = New System.Drawing.Size(166, 28)
        Me.DivisionToolStripMenuItem.Text = "Division"
        '
        'MeToolStripMenuItem
        '
        Me.MeToolStripMenuItem.Name = "MeToolStripMenuItem"
        Me.MeToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.MeToolStripMenuItem.Text = "Me?"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome To Menu System!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 297)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleOperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButtonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePickerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubtractionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultiplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DivisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
