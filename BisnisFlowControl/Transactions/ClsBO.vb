Public Class ClsBO

#Region "Retrieve"
    Public Function RetrieveListBon(noOrder As String, dateIssues As Date, customer As String) As DataTable
        Dim dataAccess = New ClsDataAccess
        Dim dataTable = New DataTable
        Dim query As String = "Select BOID,NoOrder,DateIssues,ReffPO,CustomerID,CustomerName,BrandID,Brand,StyleID,StyleName,StatusDesc,Status From v_BOHeader" &
                               " Where Status <> 0"

        If Not String.IsNullOrEmpty(noOrder) Then
            query += " And NoOrder Like '%" & noOrder & "%'"
        End If

        If Not dateIssues = "1900-01-01" Then
            query += " AND DateIssues = '" & dateIssues & "'"
        End If

        If Not String.IsNullOrEmpty(customer) Then
            query += " AND CustomerName  Like '%" & customer & "%'"
        End If

        Try
            dataTable = dataAccess.RetrieveListData(query)
            dataAccess = Nothing
            Return dataTable
        Catch ex As Exception
            Return Nothing
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function RetrieveByID(headerID As Long) As BOHeaderModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim boHeaderModel As BOHeaderModel = New BOHeaderModel
        Dim query As String = "Select * From v_BOHeader Where BOID='" & headerID & "'"
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While dataAccess.reader.Read
                    boHeaderModel.BOID = .Item("BOID")
                    boHeaderModel.NoOrder = .Item("NoOrder")
                    boHeaderModel.DateIssues = .Item("DateIssues")
                    boHeaderModel.DeliveryDate = .Item("DeliveryDate")
                    boHeaderModel.ReffPO = .Item("ReffPO")
                    boHeaderModel.CustomerID = .Item("CustomerID")
                    boHeaderModel.CustomerName = .Item("CustomerName")
                    boHeaderModel.Telephone = .Item("Telephone")
                    boHeaderModel.fax = .Item("Fax")
                    boHeaderModel.Address = .Item("Address")
                    boHeaderModel.ContactPerson = .Item("ContactPerson")
                    boHeaderModel.BrandID = .Item("BrandID")
                    boHeaderModel.Brand = .Item("Brand")
                    boHeaderModel.StyleID = .Item("StyleID")
                    boHeaderModel.StyleName = .Item("StyleName")
                    boHeaderModel.SumBrutto = .Item("SumBrutto")
                    boHeaderModel.SumNetto = .Item("SumNetto")
                    boHeaderModel.Status = .Item("Status")
                    boHeaderModel.StatusDesc = .Item("StatusDesc")
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return boHeaderModel
        Catch ex As Exception
            dataAccess = Nothing
            dataAccess.reader.Close()
            Throw ex
        End Try
    End Function
    Public Function RetrieveDetailFabricByID(boID As Long) As List(Of BODetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BODetail Where BOID='" & boID & "'"
        Dim myList As List(Of BODetailModel) = New List(Of BODetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As BODetailModel = New BODetailModel
                    detailModel.BOID = .Item("BOID")
                    detailModel.FabricID = .Item("FabricID")
                    detailModel.FabricName = .Item("FabricName")
                    If IsDBNull(.Item("Weight")) Then detailModel.Weight = "" Else detailModel.Weight = .Item("Weight")
                    If IsDBNull(.Item("Width")) Then detailModel.Width = "" Else detailModel.Width = .Item("Width")
                    myList.Add(detailModel)
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function RetrieveDetailColorByID(boID As Long) As List(Of BOColorDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BOColorDetail Where BOID='" & boID & "'"
        Dim myList As List(Of BOColorDetailModel) = New List(Of BOColorDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As BOColorDetailModel = New BOColorDetailModel
                    detailModel.BOID = .Item("BOID")
                    detailModel.NoOrder = .Item("NoOrder")
                    detailModel.FabricID = .Item("FabricID")
                    detailModel.FabricName = .Item("FabricName")
                    detailModel.ColorID = .Item("ColorID")
                    detailModel.ColorName = .Item("ColorName")
                    detailModel.LabsDipsNo = .Item("LabsDipsNo")
                    detailModel.Brutto = .Item("Brutto")
                    detailModel.Netto = .Item("Netto")
                    myList.Add(detailModel)
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
    Public Function RetrieveDetailColorforPI(boID As Long, fabricID As Integer, colorID As Integer) As BOColorDetailModel
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BOColorDetail Where BOID='" & boID & "' AND FabricID='" & fabricID & "' AND ColorID='" & colorID & "'"
        Dim bocolordetailModel As BOColorDetailModel = New BOColorDetailModel
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While dataAccess.reader.Read
                    bocolordetailModel.BOID = .Item("BOID")
                    bocolordetailModel.NoOrder = .Item("NoOrder")
                    bocolordetailModel.FabricID = .Item("FabricID")
                    bocolordetailModel.FabricName = .Item("FabricName")
                    bocolordetailModel.ColorID = .Item("ColorID")
                    bocolordetailModel.ColorName = .Item("ColorName")
                    bocolordetailModel.LabsDipsNo = .Item("LabsDipsNo")
                    bocolordetailModel.Brutto = .Item("Brutto")
                    bocolordetailModel.Netto = .Item("Netto")
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return bocolordetailModel
        Catch ex As Exception
            dataAccess = Nothing
            dataAccess.reader.Close()
            Throw ex
        End Try
    End Function
    Public Function RetrieveDetailYarnByID(headerID As Long) As List(Of BOYarnDetailModel)
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim query As String = "Select * From v_BOYarnDetail Where BOID='" & headerID & "'"
        Dim myList As List(Of BOYarnDetailModel) = New List(Of BOYarnDetailModel)
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            With dataAccess.reader
                While .Read
                    Dim detailModel As BOYarnDetailModel = New BOYarnDetailModel
                    detailModel.BOID = .Item("BOID")
                    detailModel.YarnID = .Item("YarnID")
                    detailModel.YarnName = .Item("YarnName")
                    detailModel.UnitID = .Item("UnitID")
                    detailModel.UnitName = .Item("UnitName")
                    myList.Add(detailModel)
                End While
            End With
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myList
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Function"
    Protected Function ListComboBox1(boID As Long) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String = "Select FabricID,FabricName From v_BODetail where BOID = '" & boID & "'"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxFabric1(cmb As ComboBox, headerID As Long)
        Try
            With cmb
                .DataSource = ListComboBox1(headerID)
                .ValueMember = "FabricID"
                .DisplayMember = "FabricName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Function ListComboBox2(boID As Long, fabricID As Integer) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String = "Select ColorID,LabsDipsNo From v_BOColorDetail where BOID = '" & boID & "' AND FabricID= '" & fabricID & "'"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxColor(cmb As ComboBox, boID As Long, fabricID As Integer)
        Try
            With cmb
                .DataSource = ListComboBox2(boID, fabricID)
                .ValueMember = "ColorID"
                .DisplayMember = "LabsDipsNo"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Protected Function ListComboBox3(boID As Long) As DataTable
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim dataTable As DataTable = New DataTable
        Dim query As String = "Select YarnID,YarnName From v_BOYarnDetail where BOID = '" & boID & "'"
        Try
            dataTable = dataAccess.RetrieveListData(query)
        Catch ex As Exception
            Throw ex
            Return Nothing
        End Try
        dataAccess = Nothing
        Return dataTable
    End Function
    Public Sub ComboBoxYarn(cmb As ComboBox, boID As Long)
        Try
            With cmb
                .DataSource = ListComboBox3(boID)
                .ValueMember = "YarnID"
                .DisplayMember = "YarnName"
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Generated"
    Protected Function GeneratedNoOrder() As String
        Dim myCode As String
        Dim hitung As Integer
        Dim query As String = "Select MAX(NoOrder) as Code from BOHeader"
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Try
            dataAccess.reader = dataAccess.ExecuteReader(query)
            dataAccess.reader.Read()

            If IsDBNull(dataAccess.reader.Item("Code")) Then
                myCode = "OA" + "00001" + "/" + Format(Now.Year)
            Else
                Dim xtahun As String = Microsoft.VisualBasic.Right(dataAccess.reader.Item("Code"), 4)
                If xtahun = Format(Now.Year) Then
                    Dim xCode As String = Microsoft.VisualBasic.Left(dataAccess.reader.Item("Code"), 7)
                    hitung = Microsoft.VisualBasic.Right(xCode, 5) + 1
                    myCode = "OA" & Microsoft.VisualBasic.Right("00000" & hitung, 5) & "/" & Format(Now.Year)
                Else
                    myCode = "OA" + "00001" + "/" + Format(Now.Year)
                End If
            End If
            dataAccess.reader.Close()
            dataAccess = Nothing
            Return myCode
        Catch ex As Exception
            dataAccess.reader.Close()
            dataAccess = Nothing
            Throw ex
        End Try
    End Function

    Protected Function GeneratedAutoNumber() As Long
        Dim id As Long = 0
        Dim query As String = "Select max(BOID) from BOHeader"
        Dim dataAccess = New ClsDataAccess
        Try
            id = dataAccess.GeneratedAutoNumber(query)
            dataAccess = Nothing
            Return id
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
    End Function
#End Region

#Region "Get"
    Public Function GetNoOrder() As String
        Dim noOrder As String
        Try
            noOrder = GeneratedNoOrder()
            Return noOrder
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetBonOrderID() As Long
        Dim myID As Long
        Try
            myID = GeneratedAutoNumber()
            Return myID
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Check Available In List"
    Public Function CheckFabriclInList(dgv As DataGridView, FabricID As Integer) As Boolean
        Dim cek As Integer
        Dim status As Boolean = True
        For cek = 0 To dgv.Rows.Count - 1
            If dgv.Rows(cek).Cells(0).Value = FabricID Then
                status = False
            End If
        Next
        Return status
    End Function
    Public Function CheckColorslInList(dgv As DataGridView, ColorID As Integer) As Boolean
        Dim cek As Integer
        Dim status As Boolean = True
        For cek = 0 To dgv.Rows.Count - 1
            If dgv.Rows(cek).Cells(0).Value = ColorID Then
                status = False
            End If
        Next
        Return status
    End Function
    Public Function CheckYarnlInList(dgv As DataGridView, yarnID As Integer) As Boolean
        Dim cek As Integer
        Dim status As Boolean = True
        For cek = 0 To dgv.Rows.Count - 1
            If dgv.Rows(cek).Cells(0).Value = yarnID Then
                status = False
            End If
        Next
        Return status
    End Function
    Public Function CheckRemarksInList(dgvRemarks As DataGridView, remarks As String) As Boolean
        Dim row As Integer
        Dim status As Boolean = True
        For row = 0 To dgvRemarks.Rows.Count - 1
            If dgvRemarks.Rows(row).Cells(0).Value = remarks Then
                status = False
            End If
        Next
        Return status
    End Function
#End Region

#Region "Set Data Detail"
    Public Function SetDetailFabric(boID As Long, dgv As DataGridView) As List(Of BODetailModel)
        Dim listDetailFabricModel As List(Of BODetailModel) = New List(Of BODetailModel)
        Try
            For detail = 0 To dgv.Rows.Count - 2
                Dim detailModel As BODetailModel = New BODetailModel
                With dgv
                    detailModel.BOID = boID
                    detailModel.FabricID = .Rows(detail).Cells(0).Value
                    listDetailFabricModel.Add(detailModel)
                End With
            Next
            Return listDetailFabricModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SetDetailColor(boID As Long, dgv As DataGridView) As List(Of BOColorDetailModel)
        Dim listDetailColorModel As List(Of BOColorDetailModel) = New List(Of BOColorDetailModel)
        Try
            For detail = 0 To dgv.Rows.Count - 2
                Dim detailModel As BOColorDetailModel = New BOColorDetailModel
                With dgv
                    detailModel.BOID = boID
                    detailModel.FabricID = .Rows(detail).Cells(0).Value
                    detailModel.ColorID = .Rows(detail).Cells(2).Value
                    detailModel.Brutto = .Rows(detail).Cells(5).Value
                    detailModel.Netto = .Rows(detail).Cells(6).Value
                    listDetailColorModel.Add(detailModel)
                End With
            Next
            Return listDetailColorModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function SetDetailYarn(boID As Long, dgv As DataGridView) As List(Of BOYarnDetailModel)
        Dim listDetailYarnModel As List(Of BOYarnDetailModel) = New List(Of BOYarnDetailModel)
        Try
            For detail = 0 To dgv.Rows.Count - 2
                Dim detailModel As BOYarnDetailModel = New BOYarnDetailModel
                With dgv
                    detailModel.BOID = boID
                    detailModel.YarnID = .Rows(detail).Cells(0).Value
                    detailModel.UnitID = .Rows(detail).Cells(2).Value
                    listDetailYarnModel.Add(detailModel)
                End With
            Next
            Return listDetailYarnModel
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "CRUD"
    Protected Function SqlInsertHeader(headerModel As BOHeaderModel) As String
        Dim sqlHeader As String
        sqlHeader = "Insert into BOHeader(BOID,NoOrder,DateIssues,DeliveryDate,ReffPO,CustomerID,BrandID,StyleID,SumBrutto,SumNetto,Status,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)Values" &
                "('" & headerModel.BOID & "','" & headerModel.NoOrder & "','" & headerModel.DateIssues & "','" & headerModel.DeliveryDate & "','" & headerModel.ReffPO & "'" &
                 ",'" & headerModel.CustomerID & "','" & headerModel.BrandID & "','" & headerModel.StyleID & "','" & headerModel.SumBrutto & "','" & headerModel.SumNetto & "'" &
                ",'" & headerModel.Status & "','" & headerModel.CreatedBy & "','" & headerModel.CreatedDate & "'" &
                ",'" & headerModel.UpdatedBy & "','" & headerModel.UpdatedDate & "')"
        Return sqlHeader
    End Function

    Protected Function SqlInsertDetail(myModel As BODetailModel) As String
        Dim sql As String
        sql = "Insert into BODetail(BOID,FabricID)Values('" & myModel.BOID & "'" &
        ",'" & myModel.FabricID & "')"
        Return sql
    End Function
    Protected Function SqlInsertDetailColor(myModel As BOColorDetailModel) As String
        Dim sql As String
        sql = "Insert into BOColorDetail(BOID,FabricID,ColorID,Brutto,Netto)Values('" & myModel.BOID & "','" & myModel.FabricID & "'" &
        ",'" & myModel.ColorID & "','" & myModel.Brutto & "','" & myModel.Netto & "')"
        Return sql
    End Function

    Protected Function SqlInsertDetailYarn(myModel As BOYarnDetailModel) As String
        Dim sql As String
        sql = "Insert into BOYarnDetail(BOID,YarnID,UnitID)Values('" & myModel.BOID & "'" &
        ",'" & myModel.YarnID & "','" & myModel.UnitID & "')"
        Return sql
    End Function

    Protected Function SqlUpdateHeader(myModel As BOHeaderModel) As String
        Dim SQL As String
        SQL = "Update BOHeader set DateIssues = '" & myModel.DateIssues & "', DeliveryDate = '" & myModel.DeliveryDate & "',ReffPO = '" & myModel.ReffPO & "',CustomerID = '" & myModel.CustomerID & "'" &
          ",BrandID = '" & myModel.BrandID & "',StyleID= '" & myModel.StyleID & "',SumBrutto = '" & myModel.SumBrutto & "',SumNetto = '" & myModel.SumNetto & "',Status = '" & myModel.Status & "'" &
          ",UpdatedBy = '" & myModel.UpdatedBy & "',UpdatedDate = '" & myModel.UpdatedDate & "' Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlUpdateStatusHeader(myModel As BOHeaderModel) As String
        Dim SQL As String
        SQL = "Update BOHeader Set Status = '" & myModel.Status & "',UpdatedBy = '" & myModel.UpdatedBy & "'"
        SQL += ",UpdatedDate = '" & myModel.UpdatedDate & "' Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailfabric(myModel As BOHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From BODetail Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailColor(myModel As BOHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From BOColorDetail Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Protected Function SqlDeleteDetailYarn(myModel As BOHeaderModel) As String
        Dim SQL As String
        SQL = "Delete From BOYarnDetail Where BOID = '" & myModel.BOID & "'"
        Return SQL
    End Function

    Public Function InsertData(boHeaderModel As BOHeaderModel, listDetailFabricModel As List(Of BODetailModel), listDetailColorModel As List(Of BOColorDetailModel), listDetailYarnModel As List(Of BOYarnDetailModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory

        Dim queryList As List(Of String) = New List(Of String)
        Dim statusInsert As Boolean = False
        'insert header
        queryList.Add(SqlInsertHeader(boHeaderModel))

        'insert detail fabric
        For Each detail In listDetailFabricModel
            queryList.Add(SqlInsertDetail(detail))
        Next
        'insert detail color
        For Each detailColor In listDetailColorModel
            queryList.Add(SqlInsertDetailColor(detailColor))
        Next
        'insert detail yarn
        For Each detailYarn In listDetailYarnModel
            queryList.Add(SqlInsertDetailYarn(detailYarn))
        Next

        'insert log history
        queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            statusInsert = True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        Return statusInsert
    End Function

    Public Function UpdateData(boHeaderModel As BOHeaderModel, listDetailFabricModel As List(Of BODetailModel), listDetailColorModel As List(Of BOColorDetailModel), listDetailYarnModel As List(Of BOYarnDetailModel), logModel As LogHistoryModel) As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory
        Dim queryList As List(Of String) = New List(Of String)
        Dim statusUpdate As Boolean = False
        'delete all detail before update
        queryList.Add(SqlDeleteDetailfabric(boHeaderModel))
        queryList.Add(SqlDeleteDetailColor(boHeaderModel))
        queryList.Add(SqlDeleteDetailYarn(boHeaderModel))
        'update header
        queryList.Add(SqlUpdateHeader(boHeaderModel))

        'insert detail
        For Each detailFabric In listDetailFabricModel
            queryList.Add(SqlInsertDetail(detailFabric))
        Next
        For Each detailColor In listDetailColorModel
            queryList.Add(SqlInsertDetailColor(detailColor))
        Next
        For Each detailYarn In listDetailYarnModel
            queryList.Add(SqlInsertDetailYarn(detailYarn))
        Next

        'insert log history
        queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

        Try
            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            statusUpdate = True
        Catch ex As Exception
            dataAccess = Nothing
            Throw ex
        End Try
        Return statusUpdate
    End Function

    Public Function UpdateStatus(headerModel As BOHeaderModel, logModel As LogHistoryModel) As Boolean
        Dim status As Boolean
        Dim dataAccess As ClsDataAccess = New ClsDataAccess
        Dim logBFC As ClsLogHistory = New ClsLogHistory

        Dim queryList As List(Of String) = New List(Of String)

        Try
            'update header Bon Order
            queryList.Add(SqlUpdateStatusHeader(headerModel))

            'insert log history
            queryList.Add(logBFC.SqlInsertLogHistoryTransaction(logModel))

            dataAccess.InsertMasterDetail(queryList)
            dataAccess = Nothing
            status = True
        Catch ex As Exception
            dataAccess = Nothing
            status = False
            Throw ex
        End Try
        Return status
    End Function
#End Region
End Class

