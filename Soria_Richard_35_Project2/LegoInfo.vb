'******************************************************
'* Name:       Richard Soria
'* File:       LegonInfo.vb
'* Purpose:    Class for Lego sets
'******************************************************

Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.IO
Imports System.Text
Public Class LegoInfo
    Private _SetNum As String
    Private _Pieces As String
    Private _Year As String
    Private _Name As String
    Private _Theme As String
    Private _movingPieces As String
    Private _Price As String
    Private _Age As String
    Private _Licensed As String
    Private _Minifigures As String
    Private _Time As String
    Private _Tags As String

    Public Property SetNum As String
        Get
            Return _SetNum
        End Get
        Set(value As String)
            _SetNum = value.Trim()
        End Set
    End Property

    Public Property Pieces As String
        Get
            Return _Pieces
        End Get
        Set(value As String)
            _Pieces = value.Trim()
        End Set
    End Property

    Public Property Year As String
        Get
            Return _Year
        End Get
        Set(value As String)
            _Year = value.Trim()
        End Set
    End Property
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value.Trim()
        End Set
    End Property
    Public Property Theme As String
        Get
            Return _Theme
        End Get
        Set(value As String)
            _Theme = value.Trim()
        End Set
    End Property
    Public Property movingPieces As String
        Get
            Return _movingPieces
        End Get
        Set(value As String)
            _movingPieces = value.Trim()
        End Set
    End Property

    Public Property Price As String
        Get
            Return _Price
        End Get
        Set(value As String)
            _Price = value.Trim()
        End Set
    End Property
    Public Property Age As String
        Get
            Return _Age
        End Get
        Set(value As String)
            _Age = value.Trim()
        End Set
    End Property
    Public Property Licensed As String
        Get
            Return _Licensed
        End Get
        Set(value As String)
            _Licensed = value.Trim()
        End Set
    End Property
    Public Property Minifigures As String
        Get
            Return _Minifigures
        End Get
        Set(value As String)
            _Minifigures = value.Trim()
        End Set
    End Property
    Public Property Time As String
        Get
            Return _Time
        End Get
        Set(value As String)
            _Time = value.Trim()
        End Set
    End Property
    Public Property Tags As String
        Get
            Return _Tags
        End Get
        Set(value As String)
            _Tags = value.Trim()
        End Set
    End Property
End Class
