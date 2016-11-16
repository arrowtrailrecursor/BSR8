Module modMessageBoxGlobalVariables
    Public title As String ' Title of the message box
    Public list As New ArrayList ' List of pictures to view
    Public temp As Char() ' array of characters for the message body
    Public count1 As Integer = 0 ' Counter for the text timer
    Public count2 As Integer = 0 ' counter for the picture timer
    Public result As String ' name of the button clicked by the user
    Public path As String ' path of the folder for pictures
    Public type As String ' type of the custom message
    Public names As New ArrayList ' array containing names of buttons to create
    Public xcenter, ycenter As Integer ' position of the form
    Public filename As String '
    Public x, y As Integer ' variables to adjust buttons positions
    Public btns ' array of buttons
    Public clicked As Boolean = False ' to show a button is clicked
End Module