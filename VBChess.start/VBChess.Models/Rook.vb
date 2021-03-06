﻿Imports VBChess.Models
Imports VBChess.Shared

Public Class Rook
    Inherits ChessPiece

    Public Sub New(owner As Player, board As ChessBoard, position As Point)
        MyBase.New(owner, board, position)
    End Sub

    Public Overrides ReadOnly Property PawnType As PawnTypes
        Get
            Return PawnTypes.Rook
        End Get
    End Property

    Friend Overrides Function IsMoveValid(newPosition As Point) As Boolean
        If Not MyBase.IsMoveValid(newPosition) Then Return False
        If Position.Value.X <> newPosition.X AndAlso Position.Value.Y <> newPosition.Y Then Return False
        Dim stepX As Integer = Math.Sign(newPosition.X - Position.Value.X)
        Dim stepY As Integer = Math.Sign(newPosition.Y - Position.Value.Y)
        Dim steps As Integer = Math.Max(Math.Abs(newPosition.X - Position.Value.X), Math.Abs(newPosition.Y - Position.Value.Y))
        For i As Integer = 1 To steps - 1
            If Not Board(Position.Value.X + i * stepX, Position.Value.Y + i * stepY).Content.Value Is Nothing Then Return False
        Next
        Return True
    End Function
End Class
