﻿Imports System.Data.SqlClient

Public Class Impresoras

    Private idTipo As Integer
    Private id As Integer
    Private nombre As String
    Private habilitar As Boolean
    Private margenIzquierdo As Integer
    Private margenSuperior As Integer

    Public Property EIdTipo() As Integer
        Get
            Return idTipo
        End Get
        Set(value As Integer)
            idTipo = value
        End Set
    End Property
    Public Property EId() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property ENombre() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property EHabilitar() As String
        Get
            Return habilitar
        End Get
        Set(value As String)
            habilitar = value
        End Set
    End Property
    Public Property EMargenIzquierdo() As Integer
        Get
            Return margenIzquierdo
        End Get
        Set(value As Integer)
            margenIzquierdo = value
        End Set
    End Property
    Public Property EMargenSuperior() As Integer
        Get
            Return margenSuperior
        End Get
        Set(value As Integer)
            margenSuperior = value
        End Set
    End Property

    Public Sub Guardar()

        Try
            Dim comando As New SqlCommand()
            comando.Connection = BaseDatos.conexionEmpaque
            comando.CommandText = "INSERT INTO Impresoras (IdTipo, Id, Nombre, Habilitar, MargenIzquierdo, MargenSuperior) VALUES (@idTipo, @id, @nombre, @habilitar, @margenIzquierdo, @margenSuperior)"
            comando.Parameters.AddWithValue("@idTipo", Me.EIdTipo)
            comando.Parameters.AddWithValue("@id", Me.EId)
            comando.Parameters.AddWithValue("@nombre", Me.ENombre)
            comando.Parameters.AddWithValue("@habilitar", Me.EHabilitar)
            comando.Parameters.AddWithValue("@margenIzquierdo", Me.EMargenIzquierdo)
            comando.Parameters.AddWithValue("@margenSuperior", Me.EMargenSuperior)
            BaseDatos.conexionEmpaque.Open()
            comando.ExecuteNonQuery()
            BaseDatos.conexionEmpaque.Close()
        Catch ex As Exception
            Throw ex
        Finally
            BaseDatos.conexionEmpaque.Close()
        End Try

    End Sub

    Public Sub Eliminar()

        Try
            Dim comando As New SqlCommand()
            comando.Connection = BaseDatos.conexionEmpaque
            Dim condicion As String = String.Empty
            If (Me.EIdTipo > 0) Then
                condicion &= " AND IdTipo=@idTipo"
            End If
            If (Me.EId > 0) Then
                condicion &= " AND Id=@id"
            End If
            comando.CommandText = "DELETE FROM Impresoras WHERE 0=0 " & condicion
            comando.Parameters.AddWithValue("@idTipo", Me.EIdTipo)
            comando.Parameters.AddWithValue("@id", Me.EId)
            BaseDatos.conexionEmpaque.Open()
            comando.ExecuteNonQuery()
            BaseDatos.conexionEmpaque.Close()
        Catch ex As Exception
            Throw ex
        Finally
            BaseDatos.conexionEmpaque.Close()
        End Try

    End Sub

    Public Function ObtenerListado() As List(Of Impresoras)

        Try
            Dim lista As New List(Of Impresoras)
            Dim comando As New SqlCommand()
            comando.Connection = BaseDatos.conexionEmpaque
            Dim condicion As String = String.Empty
            If (Me.EIdTipo > 0) Then
                condicion &= " AND IdTipo=@idTipo"
            End If
            If (Me.EId > 0) Then
                condicion &= " AND Id=@id"
            End If
            comando.CommandText = "SELECT IdTipo, Id, Nombre, Habilitar, MargenIzquierdo, MargenSuperior FROM Impresoras WHERE 0=0 " & condicion
            comando.Parameters.AddWithValue("@idTipo", Me.EIdTipo)
            comando.Parameters.AddWithValue("@id", Me.EId)
            BaseDatos.conexionEmpaque.Open()
            Dim lectorDatos As SqlDataReader = comando.ExecuteReader()
            Dim tabla As Impresoras
            While lectorDatos.Read()
                tabla = New Impresoras()
                tabla.idTipo = Convert.ToInt32(lectorDatos("IdTipo").ToString())
                tabla.id = Convert.ToInt32(lectorDatos("Id").ToString())
                tabla.nombre = lectorDatos("Nombre").ToString()
                tabla.habilitar = Convert.ToBoolean(lectorDatos("Habilitar").ToString())
                tabla.margenIzquierdo = Convert.ToInt32(lectorDatos("MargenIzquierdo").ToString())
                tabla.margenSuperior = Convert.ToInt32(lectorDatos("MargenSuperior").ToString())
                lista.Add(tabla)
            End While
            BaseDatos.conexionEmpaque.Close()
            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            BaseDatos.conexionEmpaque.Close()
        End Try

    End Function

End Class
