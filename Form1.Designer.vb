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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListOfVertex = New System.Windows.Forms.ListBox()
        Me.XVertexTB = New System.Windows.Forms.TextBox()
        Me.YVertexTB = New System.Windows.Forms.TextBox()
        Me.ZVertexTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListOfPol = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.V1TB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.V2TB = New System.Windows.Forms.TextBox()
        Me.V3TB = New System.Windows.Forms.TextBox()
        Me.VertexRB = New System.Windows.Forms.RadioButton()
        Me.PolygonRB = New System.Windows.Forms.RadioButton()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DrawBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLoadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotateBTStart = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NormalZLabel = New System.Windows.Forms.Label()
        Me.NormalYLabel = New System.Windows.Forms.Label()
        Me.NormalXLabel = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.VNormalZLabel = New System.Windows.Forms.Label()
        Me.VNormalYLabel = New System.Windows.Forms.Label()
        Me.VNormalXLabel = New System.Windows.Forms.Label()
        Me.ResetAllBtn = New System.Windows.Forms.Button()
        Me.ResetViewBtn = New System.Windows.Forms.Button()
        Me.ZoomTrackBar = New System.Windows.Forms.TrackBar()
        Me.RotSpdTB = New System.Windows.Forms.TrackBar()
        Me.RotXCB = New System.Windows.Forms.CheckBox()
        Me.RotYCB = New System.Windows.Forms.CheckBox()
        Me.RotZCB = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BFCCB = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ZoomTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotSpdTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 400)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ListOfVertex
        '
        Me.ListOfVertex.FormattingEnabled = True
        Me.ListOfVertex.Location = New System.Drawing.Point(433, 53)
        Me.ListOfVertex.Name = "ListOfVertex"
        Me.ListOfVertex.Size = New System.Drawing.Size(197, 134)
        Me.ListOfVertex.TabIndex = 1
        '
        'XVertexTB
        '
        Me.XVertexTB.Location = New System.Drawing.Point(451, 191)
        Me.XVertexTB.Name = "XVertexTB"
        Me.XVertexTB.Size = New System.Drawing.Size(39, 20)
        Me.XVertexTB.TabIndex = 2
        '
        'YVertexTB
        '
        Me.YVertexTB.Location = New System.Drawing.Point(509, 191)
        Me.YVertexTB.Name = "YVertexTB"
        Me.YVertexTB.Size = New System.Drawing.Size(39, 20)
        Me.YVertexTB.TabIndex = 3
        '
        'ZVertexTB
        '
        Me.ZVertexTB.Location = New System.Drawing.Point(569, 191)
        Me.ZVertexTB.Name = "ZVertexTB"
        Me.ZVertexTB.Size = New System.Drawing.Size(39, 20)
        Me.ZVertexTB.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(436, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(494, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(553, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Z"
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(660, 77)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 26)
        Me.AddBtn.TabIndex = 9
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(660, 109)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 26)
        Me.DeleteBtn.TabIndex = 10
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(422, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 188)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Of Vertex"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ListOfPol)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.V1TB)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.V2TB)
        Me.GroupBox2.Controls.Add(Me.V3TB)
        Me.GroupBox2.Location = New System.Drawing.Point(422, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 188)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Of Polygon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "V3"
        '
        'ListOfPol
        '
        Me.ListOfPol.FormattingEnabled = True
        Me.ListOfPol.Location = New System.Drawing.Point(11, 19)
        Me.ListOfPol.Name = "ListOfPol"
        Me.ListOfPol.Size = New System.Drawing.Size(197, 134)
        Me.ListOfPol.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "V2"
        '
        'V1TB
        '
        Me.V1TB.Location = New System.Drawing.Point(31, 157)
        Me.V1TB.Name = "V1TB"
        Me.V1TB.Size = New System.Drawing.Size(39, 20)
        Me.V1TB.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "V1"
        '
        'V2TB
        '
        Me.V2TB.Location = New System.Drawing.Point(92, 157)
        Me.V2TB.Name = "V2TB"
        Me.V2TB.Size = New System.Drawing.Size(39, 20)
        Me.V2TB.TabIndex = 18
        '
        'V3TB
        '
        Me.V3TB.Location = New System.Drawing.Point(151, 157)
        Me.V3TB.Name = "V3TB"
        Me.V3TB.Size = New System.Drawing.Size(39, 20)
        Me.V3TB.TabIndex = 19
        '
        'VertexRB
        '
        Me.VertexRB.AutoSize = True
        Me.VertexRB.Checked = True
        Me.VertexRB.Location = New System.Drawing.Point(665, 33)
        Me.VertexRB.Name = "VertexRB"
        Me.VertexRB.Size = New System.Drawing.Size(55, 17)
        Me.VertexRB.TabIndex = 12
        Me.VertexRB.TabStop = True
        Me.VertexRB.Text = "Vertex"
        Me.VertexRB.UseVisualStyleBackColor = True
        '
        'PolygonRB
        '
        Me.PolygonRB.AutoSize = True
        Me.PolygonRB.Enabled = False
        Me.PolygonRB.Location = New System.Drawing.Point(665, 56)
        Me.PolygonRB.Name = "PolygonRB"
        Me.PolygonRB.Size = New System.Drawing.Size(63, 17)
        Me.PolygonRB.TabIndex = 13
        Me.PolygonRB.Text = "Polygon"
        Me.PolygonRB.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(660, 141)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(75, 26)
        Me.EditBtn.TabIndex = 15
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'DrawBtn
        '
        Me.DrawBtn.Location = New System.Drawing.Point(660, 173)
        Me.DrawBtn.Name = "DrawBtn"
        Me.DrawBtn.Size = New System.Drawing.Size(75, 26)
        Me.DrawBtn.TabIndex = 16
        Me.DrawBtn.Text = "Draw"
        Me.DrawBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(946, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenLoadFileToolStripMenuItem, Me.SaveFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenLoadFileToolStripMenuItem
        '
        Me.OpenLoadFileToolStripMenuItem.Name = "OpenLoadFileToolStripMenuItem"
        Me.OpenLoadFileToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenLoadFileToolStripMenuItem.Text = "Open/Load File"
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveFileToolStripMenuItem.Text = "Save File"
        '
        'RotateBTStart
        '
        Me.RotateBTStart.Enabled = False
        Me.RotateBTStart.Location = New System.Drawing.Point(773, 122)
        Me.RotateBTStart.Name = "RotateBTStart"
        Me.RotateBTStart.Size = New System.Drawing.Size(69, 23)
        Me.RotateBTStart.TabIndex = 21
        Me.RotateBTStart.Text = "Start/Stop"
        Me.RotateBTStart.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.NormalZLabel)
        Me.GroupBox4.Controls.Add(Me.NormalYLabel)
        Me.GroupBox4.Controls.Add(Me.NormalXLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(650, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(92, 82)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Surface Normal"
        '
        'NormalZLabel
        '
        Me.NormalZLabel.AutoSize = True
        Me.NormalZLabel.Location = New System.Drawing.Point(9, 63)
        Me.NormalZLabel.Name = "NormalZLabel"
        Me.NormalZLabel.Size = New System.Drawing.Size(26, 13)
        Me.NormalZLabel.TabIndex = 25
        Me.NormalZLabel.Text = "Z = "
        '
        'NormalYLabel
        '
        Me.NormalYLabel.AutoSize = True
        Me.NormalYLabel.Location = New System.Drawing.Point(8, 45)
        Me.NormalYLabel.Name = "NormalYLabel"
        Me.NormalYLabel.Size = New System.Drawing.Size(23, 13)
        Me.NormalYLabel.TabIndex = 24
        Me.NormalYLabel.Text = "Y ="
        '
        'NormalXLabel
        '
        Me.NormalXLabel.AutoSize = True
        Me.NormalXLabel.Location = New System.Drawing.Point(8, 29)
        Me.NormalXLabel.Name = "NormalXLabel"
        Me.NormalXLabel.Size = New System.Drawing.Size(26, 13)
        Me.NormalXLabel.TabIndex = 23
        Me.NormalXLabel.Text = "X = "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.VNormalZLabel)
        Me.GroupBox5.Controls.Add(Me.VNormalYLabel)
        Me.GroupBox5.Controls.Add(Me.VNormalXLabel)
        Me.GroupBox5.Location = New System.Drawing.Point(650, 345)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(126, 86)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vertex Normal"
        '
        'VNormalZLabel
        '
        Me.VNormalZLabel.AutoSize = True
        Me.VNormalZLabel.Location = New System.Drawing.Point(7, 52)
        Me.VNormalZLabel.Name = "VNormalZLabel"
        Me.VNormalZLabel.Size = New System.Drawing.Size(26, 13)
        Me.VNormalZLabel.TabIndex = 25
        Me.VNormalZLabel.Text = "Z = "
        '
        'VNormalYLabel
        '
        Me.VNormalYLabel.AutoSize = True
        Me.VNormalYLabel.Location = New System.Drawing.Point(6, 34)
        Me.VNormalYLabel.Name = "VNormalYLabel"
        Me.VNormalYLabel.Size = New System.Drawing.Size(23, 13)
        Me.VNormalYLabel.TabIndex = 24
        Me.VNormalYLabel.Text = "Y ="
        '
        'VNormalXLabel
        '
        Me.VNormalXLabel.AutoSize = True
        Me.VNormalXLabel.Location = New System.Drawing.Point(6, 17)
        Me.VNormalXLabel.Name = "VNormalXLabel"
        Me.VNormalXLabel.Size = New System.Drawing.Size(26, 13)
        Me.VNormalXLabel.TabIndex = 23
        Me.VNormalXLabel.Text = "X = "
        '
        'ResetAllBtn
        '
        Me.ResetAllBtn.Location = New System.Drawing.Point(661, 206)
        Me.ResetAllBtn.Name = "ResetAllBtn"
        Me.ResetAllBtn.Size = New System.Drawing.Size(74, 26)
        Me.ResetAllBtn.TabIndex = 23
        Me.ResetAllBtn.Text = "Reset All"
        Me.ResetAllBtn.UseVisualStyleBackColor = True
        '
        'ResetViewBtn
        '
        Me.ResetViewBtn.Location = New System.Drawing.Point(93, 441)
        Me.ResetViewBtn.Name = "ResetViewBtn"
        Me.ResetViewBtn.Size = New System.Drawing.Size(75, 23)
        Me.ResetViewBtn.TabIndex = 32
        Me.ResetViewBtn.Text = "Reset View"
        Me.ResetViewBtn.UseVisualStyleBackColor = True
        '
        'ZoomTrackBar
        '
        Me.ZoomTrackBar.Location = New System.Drawing.Point(268, 441)
        Me.ZoomTrackBar.Maximum = 25
        Me.ZoomTrackBar.Minimum = 2
        Me.ZoomTrackBar.Name = "ZoomTrackBar"
        Me.ZoomTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ZoomTrackBar.RightToLeftLayout = True
        Me.ZoomTrackBar.Size = New System.Drawing.Size(103, 45)
        Me.ZoomTrackBar.TabIndex = 33
        Me.ZoomTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ZoomTrackBar.Value = 15
        '
        'RotSpdTB
        '
        Me.RotSpdTB.Enabled = False
        Me.RotSpdTB.Location = New System.Drawing.Point(773, 173)
        Me.RotSpdTB.Maximum = 8
        Me.RotSpdTB.Minimum = 1
        Me.RotSpdTB.Name = "RotSpdTB"
        Me.RotSpdTB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RotSpdTB.RightToLeftLayout = True
        Me.RotSpdTB.Size = New System.Drawing.Size(103, 45)
        Me.RotSpdTB.TabIndex = 33
        Me.RotSpdTB.TickStyle = System.Windows.Forms.TickStyle.None
        Me.RotSpdTB.Value = 4
        '
        'RotXCB
        '
        Me.RotXCB.AutoSize = True
        Me.RotXCB.Enabled = False
        Me.RotXCB.Location = New System.Drawing.Point(773, 54)
        Me.RotXCB.Name = "RotXCB"
        Me.RotXCB.Size = New System.Drawing.Size(55, 17)
        Me.RotXCB.TabIndex = 34
        Me.RotXCB.Text = "X Axis"
        Me.RotXCB.UseVisualStyleBackColor = True
        '
        'RotYCB
        '
        Me.RotYCB.AutoSize = True
        Me.RotYCB.Checked = True
        Me.RotYCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RotYCB.Enabled = False
        Me.RotYCB.Location = New System.Drawing.Point(773, 77)
        Me.RotYCB.Name = "RotYCB"
        Me.RotYCB.Size = New System.Drawing.Size(55, 17)
        Me.RotYCB.TabIndex = 33
        Me.RotYCB.Text = "Y Axis"
        Me.RotYCB.UseVisualStyleBackColor = True
        '
        'RotZCB
        '
        Me.RotZCB.AutoSize = True
        Me.RotZCB.Enabled = False
        Me.RotZCB.Location = New System.Drawing.Point(773, 99)
        Me.RotZCB.Name = "RotZCB"
        Me.RotZCB.Size = New System.Drawing.Size(55, 17)
        Me.RotZCB.TabIndex = 35
        Me.RotZCB.Text = "Z Axis"
        Me.RotZCB.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(764, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Rotation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(770, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Speed"
        '
        'BFCCB
        '
        Me.BFCCB.AutoSize = True
        Me.BFCCB.Enabled = False
        Me.BFCCB.Location = New System.Drawing.Point(773, 215)
        Me.BFCCB.Name = "BFCCB"
        Me.BFCCB.Size = New System.Drawing.Size(112, 17)
        Me.BFCCB.TabIndex = 37
        Me.BFCCB.Text = "Back Face Culling"
        Me.BFCCB.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(215, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Zoom"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(946, 491)
        Me.Controls.Add(Me.BFCCB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RotZCB)
        Me.Controls.Add(Me.RotYCB)
        Me.Controls.Add(Me.RotXCB)
        Me.Controls.Add(Me.RotSpdTB)
        Me.Controls.Add(Me.ZoomTrackBar)
        Me.Controls.Add(Me.RotateBTStart)
        Me.Controls.Add(Me.ResetViewBtn)
        Me.Controls.Add(Me.ResetAllBtn)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DrawBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.PolygonRB)
        Me.Controls.Add(Me.VertexRB)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ZVertexTB)
        Me.Controls.Add(Me.YVertexTB)
        Me.Controls.Add(Me.XVertexTB)
        Me.Controls.Add(Me.ListOfVertex)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Polygon Mesh"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ZoomTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotSpdTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListOfVertex As System.Windows.Forms.ListBox
    Friend WithEvents XVertexTB As System.Windows.Forms.TextBox
    Friend WithEvents YVertexTB As System.Windows.Forms.TextBox
    Friend WithEvents ZVertexTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VertexRB As System.Windows.Forms.RadioButton
    Friend WithEvents PolygonRB As System.Windows.Forms.RadioButton
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListOfPol As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents V1TB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents V2TB As System.Windows.Forms.TextBox
    Friend WithEvents V3TB As System.Windows.Forms.TextBox
    Friend WithEvents DrawBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLoadFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RotateBTStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents NormalZLabel As System.Windows.Forms.Label
    Friend WithEvents NormalYLabel As System.Windows.Forms.Label
    Friend WithEvents NormalXLabel As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents VNormalZLabel As Label
    Friend WithEvents VNormalYLabel As Label
    Friend WithEvents VNormalXLabel As Label
    Friend WithEvents ResetAllBtn As Button
    Friend WithEvents ResetViewBtn As Button
    Friend WithEvents ZoomTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents RotSpdTB As System.Windows.Forms.TrackBar
    Friend WithEvents RotXCB As System.Windows.Forms.CheckBox
    Friend WithEvents RotYCB As System.Windows.Forms.CheckBox
    Friend WithEvents RotZCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BFCCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
