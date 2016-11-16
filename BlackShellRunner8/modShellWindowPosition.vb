Module modShellWindowPosition
    Sub TileHorizontal()
        CreateObject("Shell.Application").TileHorizontally()
    End Sub

    Sub TileVertical()
        CreateObject("Shell.Application").TileVertically()
    End Sub

    Sub Cascade()
        CreateObject("Shell.Application").CascadeWindows()
    End Sub

    Sub Minimize()
        CreateObject("Shell.Application").MinimizeAll()
    End Sub

    Sub UndoMinimize()
        CreateObject("Shell.Application").UndoMinimizeAll()
    End Sub
End Module