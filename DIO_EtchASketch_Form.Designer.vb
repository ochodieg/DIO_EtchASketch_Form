﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIO_EtchASketch_Form
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.selectcolorButton = New System.Windows.Forms.Button()
        Me.drawwaveformsButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.CanvasBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialogSelect = New System.Windows.Forms.ColorDialog()
        Me.BrushSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultBrushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumBrushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeBrushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EraserSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumEraserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeEraserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FineEraserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CanvasBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(719, 335)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(109, 49)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "Exit Program")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'selectcolorButton
        '
        Me.selectcolorButton.Location = New System.Drawing.Point(719, 54)
        Me.selectcolorButton.Name = "selectcolorButton"
        Me.selectcolorButton.Size = New System.Drawing.Size(109, 49)
        Me.selectcolorButton.TabIndex = 1
        Me.selectcolorButton.Text = "Color"
        Me.ToolTip1.SetToolTip(Me.selectcolorButton, "Select a Color")
        Me.selectcolorButton.UseVisualStyleBackColor = True
        '
        'drawwaveformsButton
        '
        Me.drawwaveformsButton.Location = New System.Drawing.Point(719, 151)
        Me.drawwaveformsButton.Name = "drawwaveformsButton"
        Me.drawwaveformsButton.Size = New System.Drawing.Size(109, 49)
        Me.drawwaveformsButton.TabIndex = 2
        Me.drawwaveformsButton.Text = "Draw Wave Form"
        Me.ToolTip1.SetToolTip(Me.drawwaveformsButton, "Draw:  Sine, Cosine , and Tangent waveforms.")
        Me.drawwaveformsButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(719, 246)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(109, 49)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.clearButton, "Erase drawing")
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'CanvasBox
        '
        Me.CanvasBox.Location = New System.Drawing.Point(12, 27)
        Me.CanvasBox.Name = "CanvasBox"
        Me.CanvasBox.Size = New System.Drawing.Size(625, 411)
        Me.CanvasBox.TabIndex = 4
        Me.CanvasBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CanvasBox, "Draw someTHING!")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(873, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformToolStripMenuItem, Me.ClearToolStripMenuItem, Me.BrushSizeToolStripMenuItem, Me.EraserSizeToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformToolStripMenuItem
        '
        Me.DrawWaveformToolStripMenuItem.Name = "DrawWaveformToolStripMenuItem"
        Me.DrawWaveformToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DrawWaveformToolStripMenuItem.Text = "Draw Waveform"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(100, 70)
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem1, Me.DrawWaveformToolStripMenuItem1, Me.ClearToolStripMenuItem1})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'SelectColorToolStripMenuItem1
        '
        Me.SelectColorToolStripMenuItem1.Name = "SelectColorToolStripMenuItem1"
        Me.SelectColorToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.SelectColorToolStripMenuItem1.Text = "Select Color"
        '
        'DrawWaveformToolStripMenuItem1
        '
        Me.DrawWaveformToolStripMenuItem1.Name = "DrawWaveformToolStripMenuItem1"
        Me.DrawWaveformToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.DrawWaveformToolStripMenuItem1.Text = "Draw Waveform"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'BrushSizeToolStripMenuItem
        '
        Me.BrushSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultBrushToolStripMenuItem, Me.MediumBrushToolStripMenuItem, Me.LargeBrushToolStripMenuItem})
        Me.BrushSizeToolStripMenuItem.Name = "BrushSizeToolStripMenuItem"
        Me.BrushSizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BrushSizeToolStripMenuItem.Text = "Brush Size"
        '
        'DefaultBrushToolStripMenuItem
        '
        Me.DefaultBrushToolStripMenuItem.Name = "DefaultBrushToolStripMenuItem"
        Me.DefaultBrushToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DefaultBrushToolStripMenuItem.Text = "Default Brush"
        '
        'MediumBrushToolStripMenuItem
        '
        Me.MediumBrushToolStripMenuItem.Name = "MediumBrushToolStripMenuItem"
        Me.MediumBrushToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MediumBrushToolStripMenuItem.Text = "Medium Brush"
        '
        'LargeBrushToolStripMenuItem
        '
        Me.LargeBrushToolStripMenuItem.Name = "LargeBrushToolStripMenuItem"
        Me.LargeBrushToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LargeBrushToolStripMenuItem.Text = "Large Brush"
        '
        'EraserSizeToolStripMenuItem
        '
        Me.EraserSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultSizeToolStripMenuItem, Me.MediumEraserToolStripMenuItem, Me.LargeEraserToolStripMenuItem, Me.FineEraserToolStripMenuItem})
        Me.EraserSizeToolStripMenuItem.Name = "EraserSizeToolStripMenuItem"
        Me.EraserSizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EraserSizeToolStripMenuItem.Text = "Eraser Size"
        '
        'DefaultSizeToolStripMenuItem
        '
        Me.DefaultSizeToolStripMenuItem.Name = "DefaultSizeToolStripMenuItem"
        Me.DefaultSizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DefaultSizeToolStripMenuItem.Text = "Default Eraser"
        '
        'MediumEraserToolStripMenuItem
        '
        Me.MediumEraserToolStripMenuItem.Name = "MediumEraserToolStripMenuItem"
        Me.MediumEraserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MediumEraserToolStripMenuItem.Text = "Medium Eraser"
        '
        'LargeEraserToolStripMenuItem
        '
        Me.LargeEraserToolStripMenuItem.Name = "LargeEraserToolStripMenuItem"
        Me.LargeEraserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LargeEraserToolStripMenuItem.Text = "Large Eraser"
        '
        'FineEraserToolStripMenuItem
        '
        Me.FineEraserToolStripMenuItem.Name = "FineEraserToolStripMenuItem"
        Me.FineEraserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FineEraserToolStripMenuItem.Text = "Fine Eraser"
        '
        'DIO_EtchASketch_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 450)
        Me.Controls.Add(Me.CanvasBox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.drawwaveformsButton)
        Me.Controls.Add(Me.selectcolorButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DIO_EtchASketch_Form"
        Me.Text = "Form1"
        CType(Me.CanvasBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents selectcolorButton As Button
    Friend WithEvents drawwaveformsButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents CanvasBox As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DrawWaveformToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ColorDialogSelect As ColorDialog
    Friend WithEvents BrushSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultBrushToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumBrushToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargeBrushToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EraserSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumEraserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargeEraserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FineEraserToolStripMenuItem As ToolStripMenuItem
End Class
