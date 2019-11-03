Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CPWebApp.CPWebApp

Namespace Controllers
    Public Class PESSOASController
        Inherits System.Web.Mvc.Controller

        Private db As New CPDatabaseEntities

        ' GET: PESSOAS
        Function Index() As ActionResult
            Dim pESSOAS = db.PESSOAS.Include(Function(p) p.PESSOAS2)
            Return View(pESSOAS.ToList())
        End Function

        ' GET: PESSOAS/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pESSOAS As PESSOAS = db.PESSOAS.Find(id)
            If IsNothing(pESSOAS) Then
                Return HttpNotFound()
            End If
            Return View(pESSOAS)
        End Function

        ' GET: PESSOAS/Create
        Function Create() As ActionResult
            ViewBag.gestor = New SelectList(db.PESSOAS, "id", "nome")
            Return View()
        End Function

        ' POST: PESSOAS/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,nome,gestor")> ByVal pESSOAS As PESSOAS) As ActionResult
            If ModelState.IsValid Then
                db.PESSOAS.Add(pESSOAS)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.gestor = New SelectList(db.PESSOAS, "id", "nome", pESSOAS.gestor)
            Return View(pESSOAS)
        End Function

        ' GET: PESSOAS/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pESSOAS As PESSOAS = db.PESSOAS.Find(id)
            If IsNothing(pESSOAS) Then
                Return HttpNotFound()
            End If
            ViewBag.gestor = New SelectList(db.PESSOAS, "id", "nome", pESSOAS.gestor)
            Return View(pESSOAS)
        End Function

        ' POST: PESSOAS/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,nome,gestor")> ByVal pESSOAS As PESSOAS) As ActionResult
            If ModelState.IsValid Then
                db.Entry(pESSOAS).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.gestor = New SelectList(db.PESSOAS, "id", "nome", pESSOAS.gestor)
            Return View(pESSOAS)
        End Function

        ' GET: PESSOAS/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pESSOAS As PESSOAS = db.PESSOAS.Find(id)
            If IsNothing(pESSOAS) Then
                Return HttpNotFound()
            End If
            Return View(pESSOAS)
        End Function

        ' POST: PESSOAS/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim pESSOAS As PESSOAS = db.PESSOAS.Find(id)
            db.PESSOAS.Remove(pESSOAS)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
