Imports System.Data
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
    Public stock_id, stock_tId, stock_product_id, stock_quantity_onhand, stock_quantity_initial, stock_cost As String
    Public stock_arrival_date As Date
    Public product_category_int As Integer
    Public productAdapter As New Odbc.OdbcDataAdapter
    Public categAdapter As New Odbc.OdbcDataAdapter
    Public typeAdapter As New Odbc.OdbcDataAdapter
    Public categs As New DataSet
    Public productsData As New DataSet
    Public typeData As New DataSet
    Public receipt_id, receipt_buyerType, receipt_quantity, receipt_total_amount, receipt_transaction_date As String
    Public rd_quantity, rd_amount, rd_id, rd_product As String
    Public db_id, db_username, db_password, db_role As String
    Public dateNos As Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Function dbconn()
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
        If product_id = "" Then
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

    Function productPopulate()
        frmInventoryAdd.cboxProduct.DataSource = Nothing
        frmInventoryAdd.cboxProduct.DataBindings.Clear()
        strcommand = Nothing
        PassSql = "select * from products"
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        productAdapter = New OdbcDataAdapter(PassSql, con)
        productAdapter.SelectCommand = strcommand
        productAdapter.Fill(productsData)
        frmInventoryAdd.cboxProduct.DataSource = productsData.Tables(0)
        frmInventoryAdd.cboxProduct.ValueMember = "id"
        frmInventoryAdd.cboxProduct.DisplayMember = "product_name"
        Return (0)
    End Function
    Function typePopulate()
        pos.cboxType.DataSource = Nothing
        pos.cboxType.DataBindings.Clear()
        strcommand = Nothing
        PassSql = "select * from buyer_type"
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        productAdapter = New OdbcDataAdapter(PassSql, con)
        typeAdapter.SelectCommand = strcommand
        typeAdapter.Fill(typeData)
        pos.cboxType.DataSource = typeData.Tables(0)
        pos.cboxType.ValueMember = "id"
        pos.cboxType.DisplayMember = "type_name"
        Return (0)
    End Function
    Function newReceipts()
        Dim checking As Boolean = checkExistingReceipt()
        If checking = False Then
            sql = "insert into receipts (amount_received) values ('0')"
            query(sql)
            clearVariables()
            checkExistingReceipt()
            pos.lblOr.Text = receipt_id
        Else
            pos.lblOr.Text = receipt_id
            pos.lblTotalAmount.Text = receipt_total_amount
        End If
        Return 0
    End Function
    Function checkExistingReceipt()
        sql = "SELECT * FROM receipts WHERE transaction_date IS NULL"
        strcommand = New Odbc.OdbcCommand(sql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            receipt_id = strreader("id").ToString
            receipt_buyerType = strreader("buyer_type_id").ToString
            receipt_quantity = strreader("quantity").ToString
            receipt_total_amount = strreader("total_amount").ToString
            receipt_transaction_date = strreader("transaction_date").ToString
        End While
        If receipt_id = "" Then
            Return False
        Else
            Return True
        End If
        Return 0
    End Function
    Function getProd(ByVal takeId As String)
        clearVariables()
        If takeId.Trim = "" Then
            MsgBox("Product does not exist!")
            Return False
        End If
        sql = "SELECT * FROM products WHERE barcode = '" + takeId + "' OR product_name LIKE '%" + takeId + "%'"
        getProduct(sql)
        If product_id = "" Then
            MsgBox("Product does not exist!")
            Return False
        End If
        sql = "SELECT * FROM products WHERE barcode = '" + takeId + "' OR product_name LIKE '%" + takeId + "%'"
        getProduct(sql)
        Dim quantity As String = pos.txtboxQuantity.Text

        Dim total As String = Val(quantity) * Val(product_price)
        addingInReceipt(quantity, total)
        Return True
    End Function
    Function addingInReceipt(ByVal quantity As String, ByVal price As String)
        Dim id As String = pos.lblOr.Text
        sql = "insert into product_receipt (receipt_id,product_id,quantity,amount) values ('" + id + "','" + product_id + "','" + quantity + "','" + price + "')"
        query(sql)
        checkExistingReceipt()
        Dim tm As String = Val(receipt_total_amount) + Val(price)
        Dim qty As String = Val(receipt_quantity) + Val(quantity)
        sql = "update receipts set quantity = '" + qty + "', total_amount = '" + tm + "' where id =" + id
        query(sql)
        clearVariables()
        checkExistingReceipt()
        pos.lblOr.Text = receipt_id
        pos.txtBxProductSearch.Text = ""
        pos.txtboxQuantity.Text = "1"
        pos.lblTotalAmount.Text = receipt_total_amount
        pos.loadReceipts()
        Return 0
    End Function
    Function clearVariables()
        product_id = ""
        product_name = ""
        product_category = ""
        product_description = ""
        product_barcode = ""
        product_price = ""

        receipt_id = ""
        receipt_buyerType = ""
        receipt_quantity = ""
        receipt_total_amount = ""

        stock_id = ""
        stock_tId = ""
        stock_product_id = ""
        stock_quantity_onhand = ""
        stock_quantity_initial = ""
        stock_cost = ""

        category_id = ""
        category_name = ""
        category_description = ""

        rd_id = ""
        rd_quantity = ""
        rd_amount = ""

        Return 0
    End Function
    Function itemVoid(ByVal id As String)
        Dim exist As Boolean = getReceiptDetails(id)
        If exist Then
            Dim orId As String = pos.lblOr.Text
            checkExistingReceipt()
            Dim dbQuan As String = Val(receipt_quantity) - Val(rd_quantity)
            Dim dbTm As String = Val(receipt_total_amount) - Val(rd_amount)
            If Val(dbTm) < 0 Then
                dbTm = 0
            End If
            sql = "update receipts set quantity ='" + dbQuan + "',total_amount = '" + dbTm + "' where id = " + orId
            query(sql)
            sql = "delete from product_receipt where id =" + id
            query(sql)
            pos.loadReceipts()
            checkExistingReceipt()
            pos.lblTotalAmount.Text = receipt_total_amount
            clearVariables()
        Else
            MsgBox("Entry does not exist")
            Return 0
        End If

        Return 0
    End Function
    Function getReceiptDetails(ByVal id As String)
        sql = "SELECT * FROM product_receipt WHERE id = " + id
        strcommand = New Odbc.OdbcCommand(sql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            rd_id = strreader("id").ToString
            rd_product = strreader("product_id").ToString
            rd_quantity = strreader("quantity").ToString
            rd_amount = strreader("amount").ToString
        End While
        If rd_id = "" Then
            Return False
        Else
            Return True
        End If
        Return 0
    End Function
    Function cashOut(ByVal amount As String)
        clearVariables()
        Dim id As String = pos.lblOr.Text
        checkExistingReceipt()
        sql = "update receipts set amount_received = '" + amount + "' where id = " + id
        query(sql)
        pos.lblChange.Text = Val(amount) - Val(receipt_total_amount)
        pos.lblAReceived.Text = amount
        Return 0
    End Function
    Function discountInput(ByVal amount As String, ByVal type As string)
        Dim id As String = pos.lblOr.Text
        checkExistingReceipt()
        Dim tm As String = receipt_total_amount * (Val(amount) / 100)
        sql = "update receipts set buyer_type_id = '" + type + "', total_amount = '" + tm + "' where id =" + id
        query(sql)
        clearVariables()
        checkExistingReceipt()
        pos.lblOr.Text = receipt_id
        pos.txtBxProductSearch.Text = ""
        pos.txtboxQuantity.Text = "1"
        pos.lblTotalAmount.Text = receipt_total_amount
        pos.loadReceipts()
        Return 0
    End Function
    Function stockMinus(ByVal id As String)
        sql = "SELECT id,quantity,product_id FROM product_receipt WHERE receipt_id = '" + id + "'"
        stradapter = New OdbcDataAdapter(sql, con)
        StrTable = New DataSet()
        Dim ngRows = stradapter.Fill(StrTable, "product_receipst")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("product_receipst").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("product_receipst").Rows.Count
        Dim ItRow(1000) As String
        Dim quantu As String
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                If j = 1 Then
                    quantu = StrTable.Tables("product_receipst").Rows(m).Item(j).ToString
                ElseIf j = 2 Then
                    Dim prod As String = StrTable.Tables("product_receipst").Rows(m).Item(j).ToString
                    Dim com As String = "SELECT id,quantity_onhand FROM stocks WHERE product_id = '" + prod + "'"
                    minusStock(com, quantu)
                End If
            Next
        Next
        Return 0
    End Function

    Function minusStock(ByVal procsql As String, ByVal quan As String)
        viewmysql(procsql, "stocksss")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("stocksss").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("stocksss").Rows.Count
        Dim ItRow(1000) As String
        Dim id_stock As String
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                If j = 1 Then
                    Dim quantity_OH As String = StrTable.Tables("stocksss").Rows(m).Item(j).ToString
                    If Val(quantity_OH) <= 0 Then
                    ElseIf Val(quantity_OH) <= Val(quan) Then
                        quantity_OH = "0"
                        quan = Val(quan) - Val(quantity_OH)
                    ElseIf Val(quantity_OH) > Val(quan) Then
                        quantity_OH = "0"
                        quan = Val(quantity_OH) - Val(quan)
                    End If
                    sql = "update stocks set quantity_onhand='" + quan + "' where id = " + id_stock
                    query(sql)
                Else
                    id_stock = StrTable.Tables("stocksss").Rows(m).Item(j).ToString
                End If
            Next
        Next
        Return True
    End Function
    Function getStock(ByVal procsql As String)
        strreader = Nothing
        strcommand = Nothing
        PassSql = procsql
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            stock_id = strreader("id").ToString
            stock_tId = strreader("transaction_id").ToString
            stock_product_id = strreader("product_id").ToString
            stock_quantity_onhand = strreader("quantity_onhand").ToString
            stock_quantity_initial = strreader("quantity_initial").ToString
            stock_cost = strreader("cost").ToString
            stock_arrival_date = strreader("arrival_date").ToString
        End While
        If stock_id = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Function stockAdd(ByVal id As String)
        sql = "SELECT * FROM product_receipt WHERE receipt_id = '" + id + "'"
        strcommand = New Odbc.OdbcCommand(sql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            rd_id = strreader("id").ToString
            rd_product = strreader("product_id").ToString
            rd_quantity = strreader("quantity").ToString
            rd_amount = strreader("amount").ToString
            Dim com As String = "SELECT * FROM stocks WHERE product_id = '" + rd_product + "'"
            addStock(com)
        End While
        Return 0
    End Function

    Function addStock(ByVal procsql As String)
        strreader = Nothing
        strcommand = Nothing
        PassSql = procsql
        strcommand = New Odbc.OdbcCommand(PassSql, con)
        strreader = strcommand.ExecuteReader
        Dim temp As String = rd_quantity
        While (strreader.Read)
            stock_id = strreader("id").ToString
            stock_tId = strreader("transaction_id").ToString
            stock_product_id = strreader("product_id").ToString
            stock_quantity_onhand = strreader("quantity_onhand").ToString
            stock_quantity_initial = strreader("quantity_initial").ToString
            stock_cost = strreader("cost").ToString
            stock_arrival_date = strreader("arrival_date").ToString
            If Val(stock_quantity_onhand) <= Val(temp) Then
                stock_quantity_onhand = Val(temp) + Val(stock_quantity_onhand)
                rd_quantity = Val(temp) - Val(stock_quantity_onhand)
            Else
                stock_quantity_onhand = Val(stock_quantity_onhand) + Val(temp)
                temp = Val(stock_quantity_onhand) - Val(temp)
            End If
        End While
        sql = "update stocks set quantity_onhand='" + stock_quantity_onhand + "' where id = " + stock_id
        query(sql)
        Return True
    End Function
    Function getUser(ByVal sql As String)
        strcommand = New Odbc.OdbcCommand(sql, con)
        strreader = strcommand.ExecuteReader
        While (strreader.Read)
            db_id = strreader("id").ToString
            db_username = strreader("username").ToString
            db_password = strreader("password").ToString
            db_role = strreader("role").ToString
        End While
        If db_id = "" Then
            Return False
        Else
            Return True
        End If
    End Function
End Module