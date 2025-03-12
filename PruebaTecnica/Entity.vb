Imports DevExpress.Xpo

<NonPersistent>
<DeferredDeletion(False)>
<OptimisticLocking(False)>
<MemberDesignTimeVisibility(False)>
Public Class Entity
    Inherits XPLiteObject

#Region "Methods"
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
#End Region

End Class
