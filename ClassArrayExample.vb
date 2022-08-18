Namespace ClassArrayExample

    Public Class ClassArray

        ' declare a event with the same signature as the class that
        ' we are holding the array collection for.
        Public Event NameSet(ByVal sender As testClass, ByVal e As TestClassEventArgs)

        ' our class array
        Private m_testClassArray() As testClass

        ' empty constructor
        Public Sub New()

        End Sub

        ' this is what we call a overloaded constructor.
        ' when overloading subs and functions we must use the
        ' OverLoads keyword.
        ' Here we take in a value to automatically add the classes
        ' to array on inheritance.
        Public Sub New(ByVal AmountToAdd As Integer)

            If Not AmountToAdd = 0 Then
                ReDim m_testClassArray(AmountToAdd - 1)

                Dim i As Integer
                Dim newTestClass As testClass

                For i = 0 To (AmountToAdd - 1)

                    'create our new class, and set its index property
                    newTestClass = New testClass()
                    newTestClass.Index = i
                    'add it to the array
                    m_testClassArray(i) = newTestClass
                    'set its event handler
                    AddHandlers(newTestClass)

                Next
            End If

        End Sub

        ' add handler for this classes NameSet event to be handled by the
        ' RaiseNameSetEvent sub.
        Private Sub AddHandlers(ByVal tc As testClass)
            AddHandler tc.NameSet, AddressOf RaiseNameSetEvent
        End Sub

        ' remove the handler(s).
        Private Sub RemoveHandlers(ByVal tc As testClass)
            RemoveHandler tc.NameSet, AddressOf RaiseNameSetEvent
        End Sub

        ' this sub will be triggered every time one of the classes in the array
        ' raises the NameSet event.
        Private Sub RaiseNameSetEvent(ByVal sender As testClass, ByVal e As TestClassEventArgs)
            RaiseEvent NameSet(sender, e)
        End Sub

        ' returns the class in the specified index of the array.
        Public Function GetClass(ByVal Index As Integer) As testClass
            Return m_testClassArray(Index)
        End Function

        ' removes the event handler for each of the class objects.
        ' and clears everything from memory
        Public Sub ClearArray()
            Dim i As Integer
            Dim currentClass As testClass

            For i = LBound(m_testClassArray) To UBound(m_testClassArray)
                currentClass = m_testClassArray(i)

                RemoveHandlers(currentClass)
                currentClass = Nothing

            Next

            Erase m_testClassArray

        End Sub

    End Class

    Public Class testClass

        ' declare our event
        Public Event NameSet(ByVal sender As testClass, ByVal e As TestClassEventArgs)

        Public Sub New()

        End Sub

        ' here we raise the NameSet event whenever the name is set or changed.
        Private m_Myname As String
        Public Property MyName() As String
            Get
                Return m_Myname
            End Get
            Set(ByVal Value As String)
                m_Myname = Value
                RaiseEvent NameSet(Me, New TestClassEventArgs(m_Index))
            End Set
        End Property

        ' index property will hold its index value in the class array.
        ' the Friend keyword specifies that the property can only be used
        ' in this namespace.
        Private m_Index As Integer
        Friend Property Index() As Integer
            Get
                Return m_Index
            End Get
            Set(ByVal Value As Integer)
                m_Index = Value
            End Set
        End Property

    End Class

    ' create our own event argument class to pass values thru the event
    Public Class TestClassEventArgs
        Inherits EventArgs

        Private m_Index As Integer

        Public Sub New(ByVal Index As Integer)
            m_Index = Index
        End Sub

        Public ReadOnly Property Index() As Integer
            Get
                Return m_Index
            End Get
        End Property
    End Class

End Namespace

