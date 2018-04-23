Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Skins
Imports System.Windows.Forms

Namespace B3013
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace