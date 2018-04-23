Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Map

Namespace CylindricalMapProjections
    Partial Public Class MainPage
        Inherits UserControl

        Public Class ProjectionRatios
            Public Const Lambert As Double = 3.14
            Public Const Behrmann As Double = 2.36
            Public Const Edwards As Double = 2.0
            Public Const GallPeters As Double = 1.57
            Public Const Balthasart As Double = 1.3
        End Class

        Public imageTileWidth As Double = 330

        Public Sub New()
            InitializeComponent()
            rbDefault.IsChecked = True
        End Sub

        Public Sub RadioButton_Default(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vectorlayer.InitialMapSize = New Size(imageTileWidth, imageTileWidth)
        End Sub

        Public Sub RadioButton_Lambert(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vectorlayer.InitialMapSize = New Size(imageTileWidth * ProjectionRatios.Lambert, imageTileWidth)
        End Sub

        Public Sub RadioButton_Behrmann(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vectorlayer.InitialMapSize = New Size(imageTileWidth * ProjectionRatios.Behrmann, imageTileWidth)
        End Sub

        Public Sub RadioButton_Tristan(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vectorlayer.InitialMapSize = New Size(imageTileWidth * ProjectionRatios.Edwards, imageTileWidth)
        End Sub

        Public Sub RadioButton_Peters(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vectorlayer.InitialMapSize = New Size(imageTileWidth * ProjectionRatios.GallPeters, imageTileWidth)
        End Sub


        Public Sub RadioButton_Balthasart(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vectorlayer.InitialMapSize = New Size(imageTileWidth * ProjectionRatios.Balthasart, imageTileWidth)
        End Sub
    End Class
End Namespace
