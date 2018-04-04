Public Class Form1


 Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  Label1.Text = "Ingrese el numero"

    End Sub


   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' el x mod y sirve para sacar resoduo donde x se divide sobre y

        If (TextBox1.Text Mod 2 = 0) Then

            Label1.Text = "El numero introducido es par"

        Else : Label1.Text = "El numero introducido es impar"

        End If

    End Sub

End Class