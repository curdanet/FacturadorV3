Module ModuloArchivo
    Private Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Long, ByVal dwShareMode As Long, ByVal lpSecurityAttributes As Long, ByVal dwCreationDisposition As Long, ByVal dwFlagsAndAttributes As Long, ByVal hTemplateFile As Long) As Long
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long

    Public Function ArchivoEnUso(ByVal sFileName As String) As Boolean
        Dim hFile As Long
        Const FILE_SHARE_READ = &H1
        Const FILE_SHARE_WRITE = &H2
        Const OPEN_EXISTING = &H3
        Const GENERIC_WRITE = &H40000000
        Const INVALID_HANDLE_VALUE = -1
        On Error GoTo ExitGetFileInfo
        hFile = CreateFile(sFileName, GENERIC_WRITE, FILE_SHARE_READ Or FILE_SHARE_WRITE, 0&, OPEN_EXISTING, 0&, 0&)
        If hFile = INVALID_HANDLE_VALUE Then
            ArchivoEnUso = True
        End If
ExitGetFileInfo:
        hFile = CloseHandle(hFile)
    End Function

   
End Module
