Public Module modEnums

#Region "Enumerators"

    Public Enum enumTextOrientation
        Normal = 0
        Vertical = 1
    End Enum

    Public Enum AudioMode
        Background = AudioPlayMode.Background
        WaitToComplete = AudioPlayMode.WaitToComplete
    End Enum

    Public Enum ShadowCorner
        TopLeft = 0
        TopRight = 1
        BottomLeft = 2
        BottomRight = 3
    End Enum

    Public Enum GraphicSmoothingMode
        DefaultSmoothing = 0
        HighSpeedSmoothing = 1
        HighQualitySmoothing = 2
        NoSmoothing = 3
        AntiAliasSmoothing = 4
    End Enum

#End Region
End Module