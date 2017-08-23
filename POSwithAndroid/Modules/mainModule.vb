Imports System.Data
Imports System.Text
Imports System.Data.Odbc
Imports System.IO

Module mainModule
    Public strcon As String
    Public con As New OleDb.OleDbConnection
    Public strcommand As New OleDb.OleDbCommand
    Public sql As String
    Public PassSql, stdtype As String
    Public stradapter As New OleDb.OleDbDataAdapter
    Public StrTable As New DataSet
    Public strreader As OleDb.OleDbDataReader
    Public strlistval, strpassListVal As Integer
    Public buttonval, butval, butopt, category_exist, dbpass, loggedAdmin As String
    Public category_name, category_description, category_id As String
    Public product_barcode, product_category, product_description, product_id, product_name, product_price As String
    Public conf As Integer
    Public checknum, dbSTNO As Integer
    Public dbStdNo, dbavatar As String
    Public funcIden, dir2, dir3, dirfinal As String
    Public dbsectadviser, dbsectyear, dbsectlist, searchSQL, searchSQL2 As String
    Public FileToMove As String
    Public MoveLocation As String
    Public currentSY As String = Year(Now) & "-" & Year(Now) + 1
    Public dir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public dbFN, dbMN, dbLN, dbGEN, dbADD, dbAGE, dbYEAR, dbSECT, dbADV, dbDATE, dbSY, dbAVA, dbGRAD, dbTYPE As String
    Public sqlsec, sqlyear As String
    Public appPath As String = AppDomain.CurrentDomain.BaseDirectory
    Public categAdapter As New OleDb.OleDbDataAdapter
    Public categs As New DataSet
    Public counter As Integer = 1
    Public adapter As OdbcDataAdapter
    Function dbconn()
        strcon = "DRIVER={MySQL ODBC 3.51 Driver};" & _
        "SERVER=ec2-23-23-228-115.compute-1.amazonaws.com;" & _
        "DATABASE=dbij3u4aipolgu;" & _
        "USER=vyiwdhkruxsdeu;" & _
        "PASSWORD=d1aea6819b20f5479d9bb0af8feff8cb5d6c9b48643792ce088cb90c7daf54bc;" & _
        "port=5432;"

        'adapter = New OdbcDataAdapter("select * from products", strcon)
        adapter = New OdbcDataAdapter("insert into products (product_name) values ('test')", strcon)

        Return (0)
    End Function

    Function query(ByVal Process As String)
        strcommand = Nothing
        PassSql = Process
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        strcommand.ExecuteNonQuery()
        Return (0)
    End Function
    Function viewmysql(ByVal Process As String, ByVal strdataset As String)
        strcommand = Nothing
        stradapter = Nothing
        StrTable = Nothing
        PassSql = Process
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        stradapter = New OleDb.OleDbDataAdapter(strcommand)
        StrTable = New DataSet()
        stradapter.Fill(StrTable, strdataset)
        Return (0)
    End Function
    Function checkexist(ByVal Process As String)
        strcommand = Nothing
        StrTable = Nothing
        strreader = Nothing
        PassSql = Process
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        strreader = strcommand.ExecuteReader()
        Return (0)
    End Function

    Function Updatedatatable(ByVal Process As String)
        strcommand = Nothing
        PassSql = Process
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        strcommand.ExecuteNonQuery()
        Return (0)
    End Function
    Function checkCategory(ByVal procsql As String)
        strreader = Nothing
        strcommand = Nothing
        PassSql = procsql
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            category_exist = strreader("category_name").ToString
        End While
        If category_exist = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Function getCategory(ByVal procsql As String)
        strreader = Nothing
        strcommand = Nothing
        PassSql = procsql
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            category_id = strreader("id").ToString
            category_name = strreader("category_name").ToString
            category_description = strreader("description").ToString
        End While
        If category_name = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Function getProduct(ByVal procsql As String)
        strreader = Nothing
        strcommand = Nothing
        PassSql = procsql
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            product_id = strreader("id").ToString
            product_name = strreader("product_name").ToString
            product_category = strreader("category_id").ToString
            product_description = strreader("description").ToString
            product_barcode = strreader("barcode").ToString
            product_price = strreader("price").ToString
        End While
        If category_name = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Function categoryPopulate()
        frmAddProduct.cboxCategory.DataSource = Nothing
        frmAddProduct.cboxCategory.DataBindings.Clear()
        strcommand = Nothing
        PassSql = "select * from categories"
        strcommand = New OleDb.OleDbCommand(PassSql, con)
        categAdapter.SelectCommand = strcommand
        categAdapter.Fill(categs)
        Return (0)
    End Function

End Module