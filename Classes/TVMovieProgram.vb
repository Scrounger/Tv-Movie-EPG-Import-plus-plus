﻿#Region "Copyright (C) 2005-2011 Team MediaPortal"

' Copyright (C) 2005-2011 Team MediaPortal
' http://www.team-mediaportal.com
' 
' MediaPortal is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 2 of the License, or
' (at your option) any later version.
' 
' MediaPortal is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#End Region

Imports System
Imports System.Collections.Generic
Imports Gentle.Framework
Imports TvLibrary.Log
Imports TvDatabase

Namespace TvDatabase
    ''' <summary>
    ''' Instances of this class represent the properties and methods of a row in the table <b>TVMovieProgram</b>.
    ''' </summary>
    <TableName("TVMovieProgram")> _
    Public Class TVMovieProgram
        Inherits Persistent
#Region "Members"

        Private m_isChanged As Boolean

        <TableColumn("idTVMovieProgram", NotNull:=True), PrimaryKey(AutoGenerated:=True)> _
        Private m_idTVMovieProgram As Integer

        <TableColumn("idProgram", NotNull:=True)> _
        Private m_idProgram As Integer

        <TableColumn("TVMovieBewertung", NotNull:=True)> _
        Private m_TVMovieBewertung As Integer

        <TableColumn("idSeries", NotNull:=True)> _
        Private m_idSeries As Integer

        <TableColumn("SeriesPosterImage", NotNull:=True)> _
        Private m_SeriesPosterImage As String

        <TableColumn("FanArt", NotNull:=True)> _
        Private m_FanArt As String

        <TableColumn("idEpisode", NotNull:=True)> _
        Private m_idEpisode As String

        <TableColumn("EpisodeImage", NotNull:=True)> _
        Private m_EpisodeImage As String

        <TableColumn("local", NotNull:=True)> _
        Private m_local As Boolean

        <TableColumn("idMovingPictures", NotNull:=True)> _
        Private m_idMovingPictures As Integer

        <TableColumn("idVideo", NotNull:=True)> _
        Private m_idVideo As Integer

        <TableColumn("KurzKritik", NotNull:=True)> _
        Private m_KurzKritik As String

        <TableColumn("BildDateiname", NotNull:=True)> _
        Private m_BildDateiname As String

#End Region

#Region "Constructors"

        ''' <summary> 
        ''' Create an object from an existing row of data. This will be used by Gentle to 
        ''' construct objects from retrieved rows. 
        ''' </summary> 
        'public TVMovieProgram(int idClickfinderMapping, int idProgram, string idSeries, string timeSharingStart, string timeSharingEnd)
        '{
        '  isChanged = true;
        '  this.idClickfinderMapping = idClickfinderMapping;
        '  this.idProgram = idProgram;
        '  this.idSeries = idSeries;
        '  this.timeSharingStart = timeSharingStart;
        '  this.timeSharingEnd = timeSharingEnd;
        '}
        Public Sub New(ByVal idProgram As Integer)
            Me.m_idProgram = idProgram
        End Sub

#End Region

#Region "Public Properties"

        ''' <summary>
        ''' Indicates whether the entity is changed and requires saving or not.
        ''' </summary>
        Public ReadOnly Property IsChanged() As Boolean
            Get
                Return m_isChanged
            End Get
        End Property

        ''' <summary>
        ''' Property relating to database column idTVMovieProgram
        ''' </summary>
        Public Property idTVMovieProgram() As Integer
            Get
                Return m_idTVMovieProgram
            End Get
            Set(ByVal value As Integer)
                m_isChanged = m_isChanged Or m_idTVMovieProgram <> value
                m_idTVMovieProgram = value
            End Set
        End Property

        ''' <summary>
        ''' Property relating to database column TVMovieBewertung
        ''' </summary>
        Public Property TVMovieBewertung() As Integer
            Get
                Return m_TVMovieBewertung
            End Get
            Set(ByVal value As Integer)
                m_isChanged = m_isChanged Or m_TVMovieBewertung <> value
                m_TVMovieBewertung = value
            End Set
        End Property

        ''' <summary>
        ''' Property relating to database column idProgram
        ''' </summary>
        Public Property idProgram() As Integer
            Get
                Return m_idProgram
            End Get
            Set(ByVal value As Integer)
                m_isChanged = m_isChanged Or m_idProgram <> value
                m_idProgram = value
            End Set
        End Property
        ''' <summary>
        ''' Property relating to database column idSeries
        ''' </summary>
        Public Property idSeries() As Integer
            Get
                Return m_idSeries
            End Get
            Set(ByVal value As Integer)
                m_isChanged = m_isChanged Or m_idSeries <> value
                m_idSeries = value
            End Set
        End Property
        Public Property SeriesPosterImage() As String
            Get
                Return m_SeriesPosterImage
            End Get
            Set(ByVal value As String)
                m_isChanged = m_isChanged Or m_SeriesPosterImage <> value
                '"\" am Anfang entfernen sofern vorhanden
                If Not String.IsNullOrEmpty(value) And value(0) = "\" Then
                    value = value.Remove(0, 1)
                End If

                m_SeriesPosterImage = value
            End Set
        End Property

        Public Property FanArt() As String
            Get
                Return m_FanArt
            End Get
            Set(ByVal value As String)
                m_isChanged = m_isChanged Or m_FanArt <> value
                '"\" am Anfang entfernen sofern vorhanden
                If Not String.IsNullOrEmpty(value) And value(0) = "\" Then
                    value = value.Remove(0, 1)
                End If

                m_FanArt = value
            End Set
        End Property
        Public Property idEpisode() As String
            Get
                Return m_idEpisode
            End Get
            Set(ByVal value As String)
                m_isChanged = m_isChanged Or m_idEpisode <> value
                m_idEpisode = value
            End Set
        End Property
        Public Property EpisodeImage() As String
            Get
                Return m_EpisodeImage
            End Get
            Set(ByVal value As String)
                m_isChanged = m_isChanged Or m_EpisodeImage <> value
                '"\" am Anfang entfernen sofern vorhanden
                If Not String.IsNullOrEmpty(value) And value(0) = "\" Then
                    value = value.Remove(0, 1)
                End If

                m_EpisodeImage = value
            End Set
        End Property

        Public Property local() As Boolean
            Get
                Return m_local
            End Get
            Set(ByVal value As Boolean)
                m_isChanged = m_isChanged Or m_local <> value
                m_local = value
            End Set
        End Property
        ''' <summary>
        ''' Property relating to database column idMovingPictures
        ''' </summary>
        Public Property idMovingPictures() As Integer
            Get
                Return m_idMovingPictures
            End Get
            Set(ByVal value As Integer)
                m_isChanged = m_isChanged Or m_idMovingPictures <> value
                m_idMovingPictures = value
            End Set
        End Property

        ''' <summary>
        ''' Property relating to database column idVideo
        ''' </summary>
        Public Property idVideo() As Integer
            Get
                Return m_idVideo
            End Get
            Set(ByVal value As Integer)
                m_isChanged = m_isChanged Or m_idVideo <> value
                m_idVideo = value
            End Set
        End Property
        Public Property KurzKritik() As String
            Get
                Return m_KurzKritik
            End Get
            Set(ByVal value As String)
                m_isChanged = m_isChanged Or m_KurzKritik <> value
                m_KurzKritik = value
            End Set
        End Property
        Public Property BildDateiname() As String
            Get
                Return m_BildDateiname
            End Get
            Set(ByVal value As String)
                m_isChanged = m_isChanged Or m_BildDateiname <> value
                m_BildDateiname = value
            End Set
        End Property
#End Region

#Region "Storage and Retrieval"

        ''' <summary>
        ''' Static method to retrieve all instances that are stored in the database in one call
        ''' </summary>
        Public Shared Function ListAll() As IList(Of TVMovieProgram)
            Return Gentle.Framework.Broker.RetrieveList(Of TVMovieProgram)()
        End Function

        ''' <summary>
        ''' Retrieves an entity given it's id.
        ''' </summary>
        Public Overloads Shared Function Retrieve(ByVal idProgram As Integer) As TVMovieProgram
            Dim key As New Key(GetType(TVMovieProgram), True, "idProgram", idProgram)
            Return Gentle.Framework.Broker.RetrieveInstance(Of TVMovieProgram)(key)
        End Function

        ''' <summary>
        ''' Retrieves an entity given it's id, using Gentle.Framework.Key class.
        ''' This allows retrieval based on multi-column keys.
        ''' </summary>
        Public Overloads Shared Function Retrieve(ByVal key As Key) As TVMovieProgram
            Return Gentle.Framework.Broker.RetrieveInstance(Of TVMovieProgram)(key)
        End Function

        ''' <summary>
        ''' Persists the entity if it was never persisted or was changed.
        ''' </summary>
        Public Overrides Sub Persist()
            If IsChanged OrElse Not IsPersisted Then
                Try
                    MyBase.Persist()
                Catch ex As Exception
                    Log.[Error]("Exception in TVMovieProgram.Persist() with Message {0}", ex.Message)
                    Return
                End Try
                m_isChanged = False
            End If
        End Sub

#End Region

#Region "Relations"

        ''' <summary>
        '''
        ''' </summary>
        <CLSCompliant(False)> _
        Public Function ReferencedProgram() As Program
            Return Program.Retrieve(idProgram)
        End Function

#End Region

        Public Sub Delete()
            Dim list As IList(Of TVMovieProgram) = ListAll()
            For Each map As TVMovieProgram In list
                map.Remove()
            Next
            'Remove()
        End Sub
    End Class
End Namespace
