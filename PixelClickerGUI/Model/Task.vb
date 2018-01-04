Imports Newtonsoft.Json
Imports PixelClickerGUI.Types

Namespace Model
    Public Class Task
        'Default Values
        <JsonIgnore> Public Controller As Controller.PixelClicker
        <JsonIgnore> Public LastFps As Integer = 0
        <JsonIgnore> Public CurrentAimPos As Point
        <JsonIgnore> Public LastHealthBarHeight As Integer = 0



        Public BotName As String = "Bot Name" 

        'Search Settings
        <JsonIgnore> Public WidthOffset As Integer = 100
        <JsonIgnore> Public HeightOffset As Integer = 100
        Public AntiShake As Double = .25
        Public MaximumHealthBarHeight As Integer = 9
        Public SearchMethod As SearchMethod = SearchMethod.CursorPosition
        Private _searchArea As Size = New Size(200,200)

        Public Property SearchArea() As Size  
	        Get
	            Return _searchArea
	        End Get
	        Set
	            _searchArea = value

                WidthOffset = value.Width/2
                HeightOffset = value.Height/2
	        End Set
        End Property
        Public SkipPixel As Integer = -1

        Private _searchPos As Point = New Point(My.Computer.Screen.Bounds.Width/2-WidthOffset, My.Computer.Screen.Bounds.Height/2-HeightOffset*1.75)
        Public Property SearchPos() As Point  
	        Get
	            Return _searchPos
	        End Get
	        Set
	            If SearchMethod = SearchMethod.MiddleOfScreen Then
                     _searchPos = New Point(My.Computer.Screen.Bounds.Width/2-WidthOffset, My.Computer.Screen.Bounds.Height/2-HeightOffset*1.75)
	            Else 
                     _searchPos = New Point(value.X-WidthOffset, value.Y-HeightOffset*1.75)
	            End If
	           
	        End Set
        End Property
        Public Debug As Boolean = False
       ' Public DrawOnGame As Boolean = True

        'Search Type
        Public Bot As Bot = Bot.Middle
        Public LineChecks As Integer = 180
        Public HitChance As Double = .6

        'Mouse Settings
        Public Hotkey As Keys = Keys.LButton
        Public MoveMouse As Boolean = True
        Public AimBotMoveSpeed As Integer = 30
        Public UsePremadeShades As Boolean = False

        Public Click As Click = Click.NoClick
        Public YOffset As Integer = 50
        Public XOffset As Integer = 45

        'ColorP Settings
        Public SearchColors As HashSet(Of ColorModel) = New HashSet(Of ColorModel)
        Public RedStrength As Integer = 4
        Public GreenStrength As Integer = 9
        Public BlueStrength As Integer = 6
    End Class
End NameSpace