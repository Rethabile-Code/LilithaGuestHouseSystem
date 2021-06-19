Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Public Class LilithaClasss
    Dim con As New OleDbConnection
    Public Function getConnection() As String
        Dim str As String = ""
        Try
            con.ConnectionString = "PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source =LILITHAGUESTLODGE.mdb"
            str = "True"
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function GetLogin() As DataSet
        Dim sqlUsers As String
        Dim dsUsers As New DataSet
        Dim daUsers As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlUsers = "SELECT * FROM LOGIN"
        daUsers = New OleDb.OleDbDataAdapter(sqlUsers, con)
        daUsers.Fill(dsUsers, "LOGIN")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsUsers
    End Function
    Public Function AddUser(ByVal Uname As String, ByVal Pword As String, ByVal Alevel As String) As String
        Dim sqlAdd As String
        Dim cmd As OleDbCommand
        Dim result As String = ""

        Try

            sqlAdd = "INSERT INTO LOGIN Values ('" + Uname + "','" + Pword + "','" + Alevel + "')"
            cmd = New OleDbCommand(sqlAdd, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sqlAdd
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function


    Public Function GetUserByName(ByVal UName As String) As DataSet
        Dim sqlName As String
        Dim dsName As New DataSet
        Dim daName As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlName = "SELECT * FROM LOGIN WHERE Username = '" + UName + "'"
        daName = New OleDb.OleDbDataAdapter(sqlName, con)
        daName.Fill(dsName, "dtLOGIN")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsName
    End Function
    Public Function GetAllGuest() As DataSet
        Dim sqlGuest As String
        Dim dsGuest As New DataSet
        Dim daGuest As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlGuest = "SELECT * FROM Customers order by CustName asc"
        daGuest = New OleDb.OleDbDataAdapter(sqlGuest, con)
        daGuest.Fill(dsGuest, "dtCustomers")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsGuest
    End Function

    Public Function GetCustId() As DataSet
        Dim sql As String
        Dim dsCustIdd As New DataSet
        Dim daCustIdd As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT CustId FROM Customers order by CustId asc"
        daCustIdd = New OleDb.OleDbDataAdapter(sql, con)
        daCustIdd.Fill(dsCustIdd, "dtEmployees")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsCustIdd
    End Function
    Public Function GetCustEmp() As DataSet
        Dim sql As String
        Dim dsEmpIdd As New DataSet
        Dim daEmpIdd As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT EmpId FROM Employees order by EmpName asc"
        daEmpIdd = New OleDb.OleDbDataAdapter(sql, con)
        daEmpIdd.Fill(dsEmpIdd, "dtEmployees")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsEmpIdd
    End Function
    Public Function GetRoomNo() As DataSet
        Dim sql As String
        Dim dsRNo As New DataSet
        Dim daRNo As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT RoomNumber FROM Room order by RoomNumber asc"
        daRNo = New OleDb.OleDbDataAdapter(sql, con)
        daRNo.Fill(dsRNo, "dtRoom")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsRNo
    End Function
    Public Function AddRoom(ByVal no As String, ByVal descr As String, ByVal type As String, ByVal bcodes As String) As String
        Dim sqlAddRoom As String
        Dim cmd As OleDbCommand
        Dim result As String = ""

        Try

            sqlAddRoom = "INSERT INTO Room (RoomNumber,RoomDescr,RoomType,BusinessCode) Values ('" + no + "','" + descr + "','" + type + "','" + bcodes + "')"
            cmd = New OleDbCommand(sqlAddRoom, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sqlAddRoom
            cmd.ExecuteNonQuery()

            result = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        Return result
    End Function
    Public Function AddCustomer(ByVal id As String, ByVal name As String, ByVal surname As String, ByVal phone As String, ByVal resno As String, ByVal pno As String, ByVal noOdays As String, ByRef g As String) As String
        Dim sqlAddC As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = " "

        Try

            sqlAddC = "INSERT INTO Customers (CustId,CustName,CustSurname,CustCellNum,ResNumber,PNumber,NumberOfDays,Gender) Values ('" + id + "','" + name + "','" + surname + "','" + phone + "','" + resno + "','" + pno + "','" + noOdays + "','" + g + "')"
            cmd = New OleDbCommand(sqlAddC, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.CommandText = sqlAddC
            cmd.ExecuteNonQuery()

            result = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        Return result
    End Function
    Public Function AddEmp(ByVal id As String, ByVal name As String, ByVal surname As String, ByVal phone As String, ByVal email As String, ByVal addresss As String, ByVal gender As String, ByVal bcode As String, ByVal emptype As String) As String

        Dim sql As String
        Dim cmd As OleDbCommand
        Dim result As String = ""

        Try

            sql = "INSERT INTO Employees ( EmpId, EmpName, EmpSurname, PhoneNumber, Email,  Address, Gender, BusinessCode, EmpType) Values ('" + id + "','" + name + "','" + surname + "','" + phone + "','" + email + "','" + addresss + "','" + gender + "','" + bcode + "','" + emptype + "')"
            cmd = New OleDbCommand(sql, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            result = "True"

            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        Return result
    End Function

    Public Function UpdateEmp(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String, ByVal g As String, ByVal i As String, ByVal s As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "Update Employees Set EmpName='" + b + "', EmpSurname='" + c + "', PhoneNumber='" + d + "', Email ='" + e + "', Address='" + f + "', Gender='" + g + "', BusinessCode='" + i + "', EmpType='" + s + "' where (EmpId='" + a + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function UpdateGuest(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String, ByVal g As String, ByVal i As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "Update Customers Set CustName='" + b + "',CustSurname='" + c + "',CustCellNum='" + d + "',ResNumber='" + e + "',PNumber='" + f + "',NumberOfDays='" + g + "',Gender='" + i + "' where CustId='" + a + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function

    Public Function UpdateRoom(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "Update Room Set RoomDescr='" + b + "',RoomType='" + c + "',BusinessCode='" + d + "' where RoomNumber='" + a + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function getDeleteEmp(ByVal id As String) As String
        Dim sql As String
        Dim ds1 As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim result1 As String
        Try
            sql = " DELETE * FROM Employees WHERE (EmpId='" + id + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result1 = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result1 = ex.Message.ToString()
        End Try
        Return result1
    End Function
    Public Function getDeleteRoom(ByVal no As String) As String
        Dim sql As String
        Dim ds1 As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim result1 As String
        Try
            sql = " DELETE * FROM Room WHERE (RoomNumber='" + no + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result1 = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result1 = ex.Message.ToString()
        End Try
        Return result1
    End Function
    Public Function GetDeletePayment(ByVal Id As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result1 As String = ""
        Try
            sql = " DELETE * FROM Customers INNER JOIN Payments ON Customers.CustId = Payments.CustId  WHERE (Customers.CustId='" + Id + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result1 = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result1 = ex.Message.ToString()
        End Try
        Return result1
    End Function


    Public Function DeleteGuest(ByVal a As String) As String
        Dim res As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "DELETE * from Customers where  CustId ='" + a + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            res = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If

        Catch ex As Exception
            res = ex.Message.ToString()
        End Try
        Return res
    End Function

    Public Function GetEmpByEmpId(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Employees WHERE EmpId = '" + id + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Employees")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function
    Public Function GetRoomByRNumber(ByVal rn As String) As DataSet
        Dim ds As New DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Room WHERE RoomNumber = '" + rn + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "dtRoom")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function
    Public Function GetGuestByCusdId(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Customers WHERE CustId = '" + id + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Customers")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return ds
    End Function

    Public Function AddPayment(ByVal pno As String, ByVal pt As String, ByVal pd As String, ByVal a As String, ByVal ci As String, ByVal resn As String, ByVal empid As String) As String
        Dim sqlAddP As String
        Dim cmd As OleDbCommand
        Dim result As String = ""

        Try

            sqlAddP = "INSERT INTO Payments(PNumber,PType,PDate,Amount,CustId,ResNumber,EmpId)VALUES('" + pno + "','" + pt + "','" + pd + "','" + a + "','" + ci + "','" + resn + "', '" + empid + "')"
            cmd = New OleDbCommand(sqlAddP, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.CommandText = sqlAddP
            cmd.ExecuteNonQuery()

            result = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        Return result
    End Function
    Public Function AddRes(ByVal Rno As String, ByVal rd As String, ByVal rt As String, ByVal id As String, ByVal pno As String, ByVal rnoo As String) As String
        Dim sqlAddR As String
        Dim cmd As OleDbCommand
        Dim result As String

        Try

            sqlAddR = "INSERT INTO Reservations (ResNumber,ResDate,ResType,CustId,PNumber,RoomNumber) Values ('" + Rno + "','" + rd + "','" + rt + "','" + id + "','" + pno + "','" + rnoo + "')"
            cmd = New OleDbCommand(sqlAddR, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.CommandText = sqlAddR
            cmd.ExecuteNonQuery()

            result = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        Return result
    End Function



    Public Function getAllEmployeeDetails() As DataSet
        Dim dsEmployees As New DataSet
        Dim sqlEmp As String
        Dim daEmployees As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sqlEmp = "Select * From Employees"
        daEmployees = New OleDb.OleDbDataAdapter(sqlEmp, con)
        daEmployees.Fill(dsEmployees, "dtEmployees")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsEmployees

    End Function
    Public Function getRoom() As DataSet
        Dim dsRoom As New DataSet
        Dim sqlRoom As String
        Dim daRoom As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sqlRoom = "Select * From Room"
        daRoom = New OleDb.OleDbDataAdapter(sqlRoom, con)
        daRoom.Fill(dsRoom, "dtRoom")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsRoom

    End Function

End Class
