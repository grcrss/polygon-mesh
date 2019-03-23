Imports System.IO
Public Class Form1
    Structure TPoint
        Dim x, y, z, w As Double
    End Structure

    Structure TPolygon
        Dim V1, V2, V3 As Integer
    End Structure

    Dim ArrVertex(), tempVer(), arrRot() As TPoint
    Dim ListOfPolygon() As TPolygon
    Dim bmp As New Bitmap(400, 400)
    Dim graph As Graphics = Graphics.FromImage(bmp)
    Dim Screen(3, 3), Trans(3, 3) As Double
    Dim rotX(3, 3), rotY(3, 3), rotZ(3, 3) As Double
    Dim VW(), VR(), VS() As TPoint
    Dim DOP As TPoint
    Const PI As Double = 3.14159265359
    Const deg2rad As Double = PI / 180
    Dim deg As Double
    Dim screensize As Double = 15
    Dim a, f As Double

    Function CrossProduct(ByVal V1 As TPoint, ByVal V2 As TPoint) As TPoint
        Dim CP As TPoint
        CP.x = V1.y * V2.z - V2.y * V1.z
        CP.y = V1.z * V2.x - V2.z * V1.x
        CP.z = V1.x * V2.y - V2.x * V1.y
        Return CP
    End Function

    Function DotProduct(ByVal V1 As TPoint, ByVal V2 As TPoint) As Double
        Return (V1.x * V2.x) + (V1.y * V2.y) + (V1.z * V2.z)
    End Function

    Function CalcVector(ByVal P1 As TPoint, ByVal P2 As TPoint) As TPoint
        Dim v As TPoint
        v.x = P2.x - P1.x
        v.y = P2.y - P1.y
        v.z = P2.z - P1.z
        Return v
    End Function

    Function CalcNormalSurface(ByVal TPol As TPolygon) As TPoint
        Return CrossProduct(CalcVector(ArrVertex(TPol.V1), ArrVertex(TPol.V2)), CalcVector(ArrVertex(TPol.V1), ArrVertex(TPol.V3)))
    End Function

    Function VectorLength(ByVal V As TPoint) As Double
        Return Math.Sqrt((V.x * V.x) + (V.y * V.y) + (V.z * V.z))
    End Function

    Function AddVector(ByVal arrVec() As TPoint) As TPoint
        Dim res As TPoint
        For i = 0 To arrVec.Length - 1
            res.x += arrVec(i).x
            res.y += arrVec(i).y
            res.z += arrVec(i).z
        Next
        Return res
    End Function

    Function CalcNormalVextex(ByVal arr() As TPoint) As TPoint
        Dim NVertex As TPoint
        NVertex = AddVector(arr)
        Dim len As Double
        len = VectorLength(NVertex)
        NVertex.x = NVertex.x / len
        NVertex.y = NVertex.y / len
        NVertex.z = NVertex.z / len
        Return NVertex
    End Function
    Function cosDeg(ByVal degree As Double) As Double
        degree = degree * deg2rad
        Return Math.Cos(degree)
    End Function

    Function sinDeg(ByVal degree As Double) As Double
        degree = degree * deg2rad
        Return Math.Sin(degree)
    End Function
    Sub DeleteVertex(ByRef Arr() As TPoint, ByVal index As Integer)
        If index = 0 Then
            For i = 0 To Arr.Length - 2
                Arr(i) = Arr(i + 1)
            Next
            ReDim Preserve Arr(Arr.Length - 2)
        ElseIf index = Arr.Length - 1 Then
            ReDim Preserve Arr(Arr.Length - 2)
        Else
            For j = index To Arr.Length - 2
                Arr(j) = Arr(j + 1)
            Next
            ReDim Preserve Arr(Arr.Length - 2)
        End If
    End Sub

    Sub DeletePol(ByRef Arr() As TPolygon, ByVal index As Integer)
        If index = 0 Then
            For i = 0 To Arr.Length - 2
                Arr(i) = Arr(i + 1)
            Next
            ReDim Preserve Arr(Arr.Length - 2)
        ElseIf index = Arr.Length - 1 Then
            ReDim Preserve Arr(Arr.Length - 2)
        Else
            For j = index To Arr.Length - 2
                Arr(j) = Arr(j + 1)
            Next
            ReDim Preserve Arr(Arr.Length - 2)
        End If
    End Sub

    Sub InitNormalVertex()
        VNormalXLabel.Text = "X = "
        VNormalYLabel.Text = "Y = "
        VNormalZLabel.Text = "Z = "
    End Sub

    Function MultiplyMatrix(ByVal vtx As TPoint, ByVal mat(,) As Double) As TPoint
        Dim matvtx(0, 3), resMat(0, 3), sum As Double
        matvtx(0, 0) = vtx.x
        matvtx(0, 1) = vtx.y
        matvtx(0, 2) = vtx.z
        matvtx(0, 3) = 1
        For i = 0 To matvtx.GetUpperBound(0)
            For j = 0 To mat.GetUpperBound(1)
                sum = 0
                For k = 0 To matvtx.GetUpperBound(1)
                    sum += matvtx(i, k) * mat(k, j)
                    resMat(i, j) = sum
                Next
            Next
        Next
        vtx.x = resMat(0, 0)
        vtx.y = resMat(0, 1)
        vtx.z = resMat(0, 2)
        vtx.w = resMat(0, 3)
        Return vtx
    End Function

    Sub Draw(ByVal col As Pen, ByVal P1 As TPoint, ByVal P2 As TPoint, ByVal P3 As TPoint)
        graph.DrawLine(col, CInt(P1.x), CInt(P1.y), CInt(P2.x), CInt(P2.y))
        graph.DrawLine(col, CInt(P2.x), CInt(P2.y), CInt(P3.x), CInt(P3.y))
        graph.DrawLine(col, CInt(P3.x), CInt(P3.y), CInt(P1.x), CInt(P1.y))
        PictureBox1.Image = bmp
    End Sub

    Private Sub DrawBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DrawBtn.Click
        If ListOfPol.Items.Count > 0 Then
            If BFCCB.Checked Then
                BFC()
            Else
                DrawPol()
            End If
            If ListOfPolygon.Length > 0 Then
                RotXCB.Enabled = True
                RotYCB.Enabled = True
                RotZCB.Enabled = True
                RotateBTStart.Enabled = True
                BFCCB.Enabled = True
                ZoomTrackBar.Enabled = True
                RotSpdTB.Enabled = True
            End If
        Else
            MsgBox("Please input at least one polygon or load the mesh from the file first")
        End If
        ResetViewBtn.Enabled = True
    End Sub

    Private Sub EditBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditBtn.Click
        If VertexRB.Checked Then
            If ListOfVertex.SelectedIndex > -1 Then
                If IsNumeric(XVertexTB.Text) And IsNumeric(YVertexTB.Text) And IsNumeric(ZVertexTB.Text) Then
                    ArrVertex(ListOfVertex.SelectedIndex).x = XVertexTB.Text
                    ArrVertex(ListOfVertex.SelectedIndex).y = YVertexTB.Text
                    ArrVertex(ListOfVertex.SelectedIndex).z = ZVertexTB.Text
                    ListOfVertex.Items(ListOfVertex.SelectedIndex) = "V" + CStr(ListOfVertex.SelectedIndex) + "<" + CStr(ArrVertex(ListOfVertex.SelectedIndex).x) + ", " + CStr(ArrVertex(ListOfVertex.SelectedIndex).y) + ", " + CStr(ArrVertex(ListOfVertex.SelectedIndex).z) + ">"
                    ReDim tempVer(ArrVertex.Length - 1)
                    Array.Copy(ArrVertex, tempVer, tempVer.Length)
                    ReDim arrRot(tempVer.Length - 1)
                    Array.Copy(tempVer, arrRot, arrRot.Length)
                Else
                    MsgBox("Invalid Value")
                End If
            End If
        ElseIf PolygonRB.Checked Then
            If ListOfPol.SelectedIndex > -1 Then
                If IsNumeric(V1TB.Text) And IsNumeric(V2TB.Text) And IsNumeric(V3TB.Text) Then
                    ListOfPolygon(ListOfPol.SelectedIndex).V1 = V1TB.Text
                    ListOfPolygon(ListOfPol.SelectedIndex).V2 = V2TB.Text
                    ListOfPolygon(ListOfPol.SelectedIndex).V3 = V3TB.Text
                    ListOfPol.Items(ListOfPol.SelectedIndex) = "P" + CStr(ListOfPol.SelectedIndex) + "<" + CStr(ListOfPolygon(ListOfPol.SelectedIndex).V1) + ", " + CStr(ListOfPolygon(ListOfPol.SelectedIndex).V2) + ", " + CStr(ListOfPolygon(ListOfPol.SelectedIndex).V3) + ">"
                Else
                    MsgBox("Invalid Value")
                End If
            End If
        End If
    End Sub

    Sub ResetAll()
        graph.Clear(Color.White)
        InitNormalSurface()
        InitNormalVertex()
        ListOfPol.Items.Clear()
        ListOfVertex.Items.Clear()
        ReDim ListOfPolygon(-1)
        ReDim ArrVertex(-1)
        ReDim arrRot(-1)
        ReDim tempVer(-1)
        BFCCB.Enabled = False
        BFCCB.Checked = False
        RotXCB.Enabled = False
        RotYCB.Enabled = False
        RotZCB.Enabled = False
        deg = 0
        V1TB.Text = ""
        V2TB.Text = ""
        V3TB.Text = ""
        XVertexTB.Text = ""
        YVertexTB.Text = ""
        ZVertexTB.Text = ""
        Timer1.Enabled = False
        SetColmatrix(Screen, 0, 50, 0, 0, 200)
        SetColmatrix(Screen, 1, 0, -50, 0, 200)
        PolygonRB.Enabled = False
        screensize = 15
        zoom()
        ZoomTrackBar.Enabled = False
        ZoomTrackBar.Value = 15
        RotSpdTB.Enabled = False
        RotateBTStart.Enabled = False
        ResetViewBtn.Enabled = False
        PictureBox1.Image = bmp
    End Sub
    Private Sub ResetAllBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResetAllBtn.Click
        ResetAll()
    End Sub

    Private Sub RotateBTStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RotateBTStart.Click
        If Timer1.Enabled Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        graph.Clear(Color.White)

        deg = RotSpdTB.Value * 0.5
        SetColmatrix(rotX, 0, 1, 0, 0, 0)
        SetColmatrix(rotX, 1, 0, cosDeg(deg), -sinDeg(deg), 0)
        SetColmatrix(rotX, 2, 0, sinDeg(deg), cosDeg(deg), 0)
        SetColmatrix(rotX, 3, 0, 0, 0, 1)

        SetColmatrix(rotY, 0, cosDeg(deg), 0, sinDeg(deg), 0)
        SetColmatrix(rotY, 1, 0, 1, 0, 0)
        SetColmatrix(rotY, 2, -sinDeg(deg), 0, cosDeg(deg), 0)
        SetColmatrix(rotY, 3, 0, 0, 0, 1)

        SetColmatrix(rotZ, 0, cosDeg(deg), -sinDeg(deg), 0, 0)
        SetColmatrix(rotZ, 1, sinDeg(deg), cosDeg(deg), 0, 0)
        SetColmatrix(rotZ, 2, 0, 0, 1, 0)
        SetColmatrix(rotZ, 3, 0, 0, 0, 1)


        For i = 0 To arrRot.Length - 1
            VW(i) = arrRot(i)
            If RotXCB.Checked Then
                VW(i) = MultiplyMatrix(VW(i), rotX)
            End If
            If RotYCB.Checked Then
                VW(i) = MultiplyMatrix(VW(i), rotY)
            End If
            If RotZCB.Checked Then
                VW(i) = MultiplyMatrix(VW(i), rotZ)
            End If

            VR(i) = MultiplyMatrix(VW(i), Trans)
            VS(i) = MultiplyMatrix(VS(i), Screen)
            tempVer(i) = VW(i)

        Next
        If BFCCB.Checked Then
            BFC()
        Else
            DrawPol()
        End If
            ReDim arrRot(ArrVertex.Length - 1)
            Array.Copy(tempVer, arrRot, arrRot.Length)
            PictureBox1.Refresh()
    End Sub

    Private Sub OpenLoadFileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenLoadFileToolStripMenuItem.Click
        Dim SR As StreamReader
        OpenFileDialog1.Filter = "Text File|*.txt"
        If ListOfPol.Items.Count > 0 Or ListOfVertex.Items.Count > 0 And Timer1.Enabled = True Or RotXCB.Enabled = True Or RotYCB.Enabled = True Or RotZCB.Enabled = True Then
            Dim Response = MsgBox("Changes will not be saved!", MsgBoxStyle.Exclamation, "Warning!")
        End If
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ResetAll()
            SR = File.OpenText(OpenFileDialog1.FileName)
            Dim str As String = SR.ReadToEnd
            Dim changeToPol As Boolean = False 'indicate to stop assigning coordinate x,y,and z to array of vertex and start assigning index of vertices to list of polygon, "&" acts as separator, true if "&" is found, false otherwise
            Dim vtx() As String 'temporary array to split values every ti
            Dim startidxpol As Integer 'indicate the starting index of list of polygon from the lines array
            ReDim ArrVertex(-1) 'redeclare the size of arrvertex to 0, if it is arrvertex(0) then it will generate one additional empty vertex
            ReDim ListOfPolygon(-1)

            Dim Lines() As String = str.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For i = 0 To Lines.Length - 1
                If Lines(i) = "&" Then 'kalo ketemu - ganti ke polygon nginputnya
                    changeToPol = True
                    startidxpol = i + 1
                ElseIf Not changeToPol Then 'kalo belum ketemu - nginputnya ke vertex
                    vtx = Lines(i).Split(",")
                    ReDim Preserve ArrVertex(ArrVertex.Length)
                    ArrVertex(i).x = vtx(0)
                    ArrVertex(i).y = vtx(1)
                    ArrVertex(i).z = vtx(2)
                    ListOfVertex.Items.Add("V" + CStr(i) + "<" + CStr(ArrVertex(i).x) + ", " + CStr(ArrVertex(i).y) + ", " + CStr(ArrVertex(i).z) + ">")
                ElseIf i >= startidxpol And changeToPol Then
                    vtx = Lines(i).Split(",")
                    ReDim Preserve ListOfPolygon(ListOfPolygon.Length)
                    ListOfPolygon(i - startidxpol).V1 = vtx(0)
                    ListOfPolygon(i - startidxpol).V2 = vtx(1)
                    ListOfPolygon(i - startidxpol).V3 = vtx(2)

                End If
            Next
            'ReDim VS(ArrVertex.Length - 1)
            'ReDim VR(ArrVertex.Length - 1)
            'ReDim VW(ArrVertex.Length - 1)
            'VW = ArrVertex
            'For i = 0 To ArrVertex.Length - 1
            '    VR(i) = MultiplyMatrix(VW(i), Trans)
            '    VS(i) = MultiplyMatrix(VR(i), Screen)
            'Next
            For i = 0 To ListOfPolygon.Length - 1
                ListOfPol.Items.Add("P" + CStr(i) + "<" + CStr(ListOfPolygon(i).V1) + ", " + CStr(ListOfPolygon(i).V2) + ", " + CStr(ListOfPolygon(i).V3) + ">")
            Next
            SR.Close()
            If ListOfVertex.Items.Count > 2 Then PolygonRB.Enabled = True
            ReDim tempVer(ArrVertex.Length - 1)
            Array.Copy(ArrVertex, tempVer, tempVer.Length)
            ReDim arrRot(tempVer.Length - 1)
            Array.Copy(tempVer, arrRot, arrRot.Length)
            DrawPol()
            If ListOfPolygon.Length > 0 Then
                RotXCB.Enabled = True
                RotYCB.Enabled = True
                RotZCB.Enabled = True
                RotateBTStart.Enabled = True
                BFCCB.Enabled = True
                ZoomTrackBar.Enabled = True
                RotSpdTB.Enabled = True
                ResetViewBtn.Enabled = True
            End If
        End If

    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        Dim SW As StreamWriter
        SaveFileDialog1.Filter = "Text|*.txt"
        If ListOfVertex.Items.Count = 0 And ListOfPol.Items.Count = 0 Then
            MsgBox("Please insert vertex and polygon values to be saved")
        Else
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                SW = File.CreateText(SaveFileDialog1.FileName)
                For i = 0 To ArrVertex.Length - 1
                    SW.WriteLine(CStr(ArrVertex(i).x) + "," + CStr(ArrVertex(i).y) + "," + CStr(ArrVertex(i).z))
                Next
                SW.WriteLine("&")
                If ListOfPol.Items.Count > 0 Then
                    For i = 0 To ListOfPolygon.Length - 2
                        SW.WriteLine(CStr(ListOfPolygon(i).V1) + "," + CStr(ListOfPolygon(i).V2) + "," + CStr(ListOfPolygon(i).V3))
                    Next
                    SW.Write(CStr(ListOfPolygon(ListOfPolygon.Length - 1).V1) + "," + CStr(ListOfPolygon(ListOfPolygon.Length - 1).V2) + "," + CStr(ListOfPolygon(ListOfPolygon.Length - 1).V3))
                End If
                SW.Close()
            End If
        End If
    End Sub

    Sub BFC()
        graph.Clear(Color.White)
        For i = 0 To arrRot.Length - 1
            VW(i) = arrRot(i)
            VR(i) = MultiplyMatrix(VW(i), Trans)
            VS(i) = MultiplyMatrix(VR(i), Screen)
        Next
        For i = 0 To ListOfPolygon.Length - 1
            Dim n As TPoint
            n = CrossProduct(CalcVector(VR(ListOfPolygon(i).V1), VR(ListOfPolygon(i).V2)), CalcVector(VR(ListOfPolygon(i).V1), VR(ListOfPolygon(i).V3)))
            If DotProduct(DOP, n) < 0 Then 'backfaceculling
                Draw(Pens.Maroon, VS(ListOfPolygon(i).V1), VS(ListOfPolygon(i).V2), VS(ListOfPolygon(i).V3))
            End If
        Next

    End Sub

    Private Sub BFCCB_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BFCCB.CheckedChanged
        If BFCCB.Checked Then
            If Not Timer1.Enabled Then
                BFC()
            End If
        Else
            If ListOfPol.Items.Count > 0 Then
                DrawPol()
            End If
        End If
    End Sub

    Private Sub ZoomTrackBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles ZoomTrackBar.Scroll
        screensize = ZoomTrackBar.Value
        zoom()
    End Sub

    Private Sub RotSpdTB_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles RotSpdTB.Scroll
        deg = RotSpdTB.Value * 0.5
    End Sub

    Private Sub ListOfVertex_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListOfVertex.SelectedIndexChanged
        Dim N As TPoint
        Dim allSurface() As TPoint
        If ListOfPol.Items.Count > 0 Then
            Dim i As Integer = 0
            ReDim allSurface(0)
            For j = 0 To ListOfPolygon.Length - 1
                If ListOfVertex.SelectedIndex = ListOfPolygon(j).V1 Or ListOfVertex.SelectedIndex = ListOfPolygon(j).V2 Or ListOfVertex.SelectedIndex = ListOfPolygon(j).V3 Then
                    allSurface(i) = CalcNormalSurface(ListOfPolygon(j))
                    i += 1
                    ReDim Preserve allSurface(allSurface.Length)
                Else
                    InitNormalVertex()
                End If
            Next
            If i > 0 Then
                N = CalcNormalVextex(allSurface)
                VNormalXLabel.Text = "X = " + Math.Round(N.x, 8).ToString
                VNormalYLabel.Text = "Y = " + Math.Round(N.y, 8).ToString
                VNormalZLabel.Text = "Z = " + Math.Round(N.z, 8).ToString
            End If
        End If
    End Sub

    Private Sub ListOfPol_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListOfPol.SelectedIndexChanged
        If ListOfPolygon.Length > 0 Then
            Dim N As TPoint
            If ListOfPol.SelectedIndex >= 0 Then
                N = CalcNormalSurface(ListOfPolygon(ListOfPol.SelectedIndex))
                NormalXLabel.Text = "X = " + N.x.ToString
                NormalYLabel.Text = "Y = " + N.y.ToString
                NormalZLabel.Text = "Z = " + N.z.ToString
            End If
        End If
    End Sub

    Private Sub ResetViewBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResetViewBtn.Click
        ReDim tempVer(ArrVertex.Length - 1)
        Array.Copy(ArrVertex, tempVer, tempVer.Length)
        ReDim arrRot(tempVer.Length - 1)
        Array.Copy(tempVer, arrRot, arrRot.Length)
        DrawPol()
        If ListOfPolygon.Length > 0 Then
            RotXCB.Enabled = True
            RotYCB.Enabled = True
            RotZCB.Enabled = True
            RotateBTStart.Enabled = True
            BFCCB.Enabled = True
            screensize = 15
            zoom()
            ZoomTrackBar.Value = 15
            ZoomTrackBar.Enabled = True
        End If
        Timer1.Enabled = False
        BFCCB.Checked = False
        'ReDim arrRot(ArrVertex.Length - 1)
        'Array.Copy(ArrVertex, arrRot, arrRot.Length)
        'ReDim tempVer(ArrVertex.Length - 1)
        'Array.Copy(ArrVertex, tempVer, tempVer.Length) '
    End Sub

    Sub zoom()
        a = 400 / (screensize) * 2 '
        f = -a
        SetColmatrix(Screen, 0, a, 0, 0, 200)
        SetColmatrix(Screen, 1, 0, f, 0, 200)
        For i = 0 To arrRot.Length - 1
            VS(i) = MultiplyMatrix(arrRot(i), Screen)
        Next
        graph.Clear(Color.White)
        If BFCCB.Checked Then
            BFC()
        Else
            DrawPol()
        End If

        PictureBox1.Refresh()
    End Sub
    Sub DrawPol()
        'If RotateBTStart.Enabled Then
        ReDim VW(ArrVertex.Length - 1)
        ReDim VR(ArrVertex.Length - 1)
        ReDim VS(ArrVertex.Length - 1)
        For i = 0 To arrRot.Length - 1
            VW(i) = arrRot(i)
            VR(i) = MultiplyMatrix(VW(i), Trans)
            VS(i) = MultiplyMatrix(VR(i), Screen)
        Next
        'End If
        graph.Clear(Color.White)
        For i = 0 To ListOfPolygon.Length - 1
            Draw(Pens.Black, VS(ListOfPolygon(i).V1), VS(ListOfPolygon(i).V2), VS(ListOfPolygon(i).V3))
        Next

        'polexist = True
    End Sub

    Sub InitNormalSurface()
        NormalXLabel.Text = "X = "
        NormalYLabel.Text = "Y = "
        NormalZLabel.Text = "Z = "
    End Sub

    Sub RefreshList()
        If VertexRB.Checked Then
            ListOfVertex.Items.Clear()
            For i = 0 To ArrVertex.Length - 1
                ListOfVertex.Items.Add("V" + CStr(i) + "<" + CStr(ArrVertex(i).x) + ", " + CStr(ArrVertex(i).y) + ", " + CStr(ArrVertex(i).z) + ">")
            Next
            InitNormalVertex()
        ElseIf PolygonRB.Checked Then
            ListOfPol.Items.Clear()
            For i = 0 To ListOfPolygon.Length - 1
                ListOfPol.Items.Add("P" + CStr(i) + "<" + CStr(ListOfPolygon(i).V1) + ", " + CStr(ListOfPolygon(i).V2) + ", " + CStr(ListOfPolygon(i).V3) + ">")
            Next
            'reDimArray(VS1, VS2, VS3)
            For i = 0 To arrRot.Length - 1
                VS(i) = MultiplyMatrix(ArrVertex(i), Screen)

            Next
            InitNormalSurface()
        End If
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteBtn.Click
        Dim partofSur As Boolean = False
        If VertexRB.Checked Then
            If ListOfVertex.SelectedIndex < 0 Then
                MsgBox("Please select a vertex to be deleted")
            Else
                If ListOfPol.Items.Count > 0 Then 'at least one polygon exist
                    Dim j As Integer = 0
                    While j <= ListOfPolygon.Length - 1 And Not partofSur
                        If ListOfVertex.SelectedIndex = ListOfPolygon(j).V1 Or ListOfVertex.SelectedIndex = ListOfPolygon(j).V2 Or ListOfVertex.SelectedIndex = ListOfPolygon(j).V3 Then
                            MsgBox("This vertex is part of a surface")
                            partofSur = True
                        End If
                        j += 1
                    End While
                    If Not partofSur Then
                        DeleteVertex(ArrVertex, ListOfVertex.SelectedIndex)
                        ListOfVertex.Items.RemoveAt(ListOfVertex.SelectedIndex.ToString)
                        RefreshList()
                    End If
                    partofSur = False
                Else 'no polygon
                    DeleteVertex(ArrVertex, ListOfVertex.SelectedIndex)
                    ListOfVertex.Items.RemoveAt(ListOfVertex.SelectedIndex.ToString)
                    RefreshList()
                End If
            End If
        ElseIf PolygonRB.Checked Then
            If ListOfPol.SelectedIndex < 0 Then
                MsgBox("Please select a polygon to be deleted")
            Else
                DeletePol(ListOfPolygon, ListOfPol.SelectedIndex)
                ListOfPol.Items.RemoveAt(ListOfPol.SelectedIndex.ToString)
                RefreshList()
                graph.Clear(Color.White)
                If BFCCB.Checked Then
                    BFC()
                Else
                    DrawPol()
                End If

            End If

        End If
        PictureBox1.Image = bmp
    End Sub

    Private Sub AddBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddBtn.Click
        If VertexRB.Checked Then
            If XVertexTB.Text <> "" And YVertexTB.Text <> "" And ZVertexTB.Text <> "" Then
                If ListOfVertex.Items.Count = 0 Then
                    ReDim ArrVertex(0)
                    ArrVertex(0).x = XVertexTB.Text
                    ArrVertex(0).y = YVertexTB.Text
                    ArrVertex(0).z = ZVertexTB.Text
                    ListOfVertex.Items.Add("V0<" + CStr(ArrVertex(0).x) + ", " + CStr(ArrVertex(0).y) + ", " + CStr(ArrVertex(0).z) + ">")
                Else
                    ReDim Preserve ArrVertex(ArrVertex.Length)
                    ArrVertex(ArrVertex.Length - 1).x = XVertexTB.Text
                    ArrVertex(ArrVertex.Length - 1).y = YVertexTB.Text
                    ArrVertex(ArrVertex.Length - 1).z = ZVertexTB.Text
                    ListOfVertex.Items.Add("V" + CStr(ArrVertex.Length - 1) + "<" + CStr(ArrVertex(ArrVertex.Length - 1).x) + ", " + CStr(ArrVertex(ArrVertex.Length - 1).y) + ", " + CStr(ArrVertex(ArrVertex.Length - 1).z) + ">")
                End If
                If ArrVertex.Length > 2 Then PolygonRB.Enabled = True
            Else
                MsgBox("Please input the vertex coordinate")
            End If
        ElseIf PolygonRB.Checked Then
            If V1TB.Text <> "" And V2TB.Text <> "" And V3TB.Text <> "" Then
                If CInt(V1TB.Text) <= ArrVertex.Length - 1 And CInt(V1TB.Text) >= 0 And CInt(V2TB.Text) <= ArrVertex.Length - 1 And CInt(V2TB.Text) >= 0 And CInt(V3TB.Text) <= ArrVertex.Length - 1 And CInt(V3TB.Text) >= 0 Then
                    If ListOfPol.Items.Count = 0 Then
                        ReDim ListOfPolygon(0)
                        ListOfPolygon(0).V1 = CInt(V1TB.Text)
                        ListOfPolygon(0).V2 = CInt(V2TB.Text)
                        ListOfPolygon(0).V3 = CInt(V3TB.Text)
                        ListOfPol.Items.Add("P0<" + V1TB.Text + ", " + V2TB.Text + ", " + V3TB.Text + ">")
                    Else
                        ReDim Preserve ListOfPolygon(ListOfPolygon.Length)
                        ListOfPolygon(ListOfPolygon.Length - 1).V1 = CInt(V1TB.Text)
                        ListOfPolygon(ListOfPolygon.Length - 1).V2 = CInt(V2TB.Text)
                        ListOfPolygon(ListOfPolygon.Length - 1).V3 = CInt(V3TB.Text)
                        ListOfPol.Items.Add("P" + CStr(ListOfPolygon.Length - 1) + "<" + V1TB.Text + ", " + V2TB.Text + ", " + V3TB.Text + ">")
                    End If
                Else
                    MsgBox("Index out of bound")
                End If
            Else
                MsgBox("Please select 3 vertices from the list of vertex")
            End If
        End If
        ReDim tempVer(ArrVertex.Length - 1)
        Array.Copy(ArrVertex, tempVer, tempVer.Length)
        ReDim arrRot(tempVer.Length - 1)
        Array.Copy(tempVer, arrRot, arrRot.Length)
    End Sub
    Sub SetColmatrix(ByRef mat(,) As Double, ByVal colnum As Integer, ByVal x1 As Double, ByVal y1 As Double, ByVal z1 As Double, ByVal w1 As Double)
        mat(0, colnum) = x1
        mat(1, colnum) = y1
        mat(2, colnum) = z1
        mat(3, colnum) = w1
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        graph.Clear(Color.White)
        PictureBox1.Image = bmp
        DOP.x = 0
        DOP.y = 0
        DOP.z = -1
        SetColmatrix(Screen, 0, 50, 0, 0, 200)
        SetColmatrix(Screen, 1, 0, -50, 0, 200)
        SetColmatrix(Screen, 2, 0, 0, 1, 0)
        SetColmatrix(Screen, 3, 0, 0, 0, 1)

        'SetColmatrix(Trans, 0, cosDeg(45), 0, sinDeg(45), 0)
        'SetColmatrix(Trans, 1, sinDeg(45) * sinDeg(45), cosDeg(45), -cosDeg(45) * sinDeg(45), 0)
        'SetColmatrix(Trans, 2, 0, 0, 1, 0)
        'SetColmatrix(Trans, 3, 0, 0, 0, 1)

        SetColmatrix(Trans, 0, 1, 0, 0, 0)
        SetColmatrix(Trans, 1, 0, 1, 0, 0)
        SetColmatrix(Trans, 2, 0, 0, 1, 0)
        SetColmatrix(Trans, 3, 0, 0, 0, 1)

        'SetColmatrix(Trans, 0, 1, 0, 0, 0)
        'SetColmatrix(Trans, 1, 0, 1, 0, 0)
        'SetColmatrix(Trans, 2, 0, 0, 1, 0)
        'SetColmatrix(Trans, 3, -0.2, 0, -0.5, 1)

        ZoomTrackBar.Enabled = False
        ResetViewBtn.Enabled = False
        ZoomTrackBar.Orientation = Orientation.Horizontal
        ZoomTrackBar.Minimum = 1
        ZoomTrackBar.Maximum = 50
        ZoomTrackBar.Value = 15
    End Sub
End Class
