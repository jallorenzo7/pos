﻿Imports System.Data
Imports System.Data.Odbc

Module mainModule
    Public strcon As String
    Public con As New Odbc.OdbcConnection
    Public strcommand As New Odbc.OdbcCommand
    Public sql As String
    Public PassSql, stdtype As String
    Public stradapter As Odbc.OdbcDataAdapter
    Public StrTable As New DataSet
    Public strreader As Odbc.OdbcDataReader
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
    Public categAdapter As New Odbc.OdbcDataAdapter
    Public categs As New DataSet
    Public counter As Integer = 1
    Function dbconn()
        '   strcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + appPath + "posandroid.mdb"
        strcon = "Dsn=PostgreSQL30;database=dbij3u4aipolgu;server=ec2-23-23-228-115.compute-1.amazonaws.com;port=5432;uid=vyiwdhkruxsdeu;sslmode=allow;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;gssauthusegss=0;xaopt=1"
        con.ConnectionString = strcon
        con.Open()
        Return (0)
    End Function

    Function query(ByVal Process As String)
        strcommand = Nothing
        PassSql = Process
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        strcommand.ExecuteNonQuery()
        Return (0)
    End Function
    Function viewmysql(ByVal Process As String, ByVal strdataset As String)
        strcommand = Nothing
        stradapter = Nothing
        StrTable = Nothing
        PassSql = Process
        stradapter = New OdbcDataAdapter(PassSql, con)
        StrTable = New DataSet()
        stradapter.Fill(StrTable, strdataset)
        Return (0)
    End Function
    Function checkexist(ByVal Process As String)
        strcommand = Nothing
        StrTable = Nothing
        strreader = Nothing
        PassSql = Process
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        strreader = strcommand.ExecuteReader()
        Return (0)
    End Function

    Function checkCategory(ByVal procsql As String)
        strreader = Nothing
        strcommand = Nothing
        PassSql = procsql
        strcommand = New Odbc.OdbcCommand(PassSql, con)
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
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            category_id = strreader("id").ToString
            category_name = strreader("category_name").ToString
            category_description = strreader("category_description").ToString
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
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            product_id = strreader("id").ToString
            product_name = strreader("product_name").ToString
            product_category = strreader("category_id").ToString
            product_description = strreader("product_description").ToString
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
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        categAdapter = New OdbcDataAdapter(PassSql, con)
        categAdapter.SelectCommand = strcommand
        categAdapter.Fill(categs)
        frmAddProduct.cboxCategory.DataSource = categs.Tables(0)
        frmAddProduct.cboxCategory.ValueMember = "id"
        frmAddProduct.cboxCategory.DisplayMember = "category_name"
        Return (0)
    End Function

End Module