﻿Imports System.Data.SqlClient

Public Class Lotes

    Private id As Integer
    Private nombre As String 

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

    Public Function ObtenerListadoReporte() As DataTable

        Try
            Dim datos As New DataTable
            Dim comando As New SqlCommand()
            comando.Connection = BaseDatos.conexionCatalogo
            comando.CommandText = "SELECT Id, Nombre FROM " & EYELogicaReporteRecepcion.Programas.prefijoBaseDatosEmpaque & "Lotes " & _
            " UNION SELECT -1 AS Id, 'Todos' AS Nombre FROM " & EYELogicaReporteRecepcion.Programas.prefijoBaseDatosEmpaque & "Lotes " & _
            " ORDER BY Id ASC"
            BaseDatos.conexionCatalogo.Open()
            Dim lectorDatos As SqlDataReader
            lectorDatos = comando.ExecuteReader()
            datos.Load(lectorDatos)
            BaseDatos.conexionCatalogo.Close()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            BaseDatos.conexionCatalogo.Close()
        End Try

    End Function

End Class
