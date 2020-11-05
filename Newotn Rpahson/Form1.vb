Imports info.lundin.math
Public Class Form1
    Dim a, b, n, ec, m As Single
    Dim i, j, redon As Integer
    Dim x(50), er(50), y(50) As Single

    Function f(x As Single) As Single

        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)

    End Function


    Function d(y As Single) As Single

        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", y)
        Return parser.Parse(td.Text)

    End Function

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        n = tcs.Text
        a = ta.Text
        b = tb.Text
        j = 1
        m = (a + b) / 2
        redon = n + 2
        ec = 0.5 * 10 ^ (-n)
        x(i) = m - (f(m) / d(m))
        er(i) = 1
        salida.Rows.Add(i, m, "0")
        salida.Rows.Add(j, Math.Round(x(i), redon), Math.Round((x(i) - m) / x(i), redon))
        Do While er(i) > ec
            x(i + 1) = x(i) - (f(x(i)) / d(x(i)))
            er(i + 1) = Math.Abs((x(i + 1) - x(i)) / x(i + 1))
            salida.Rows.Add(j + 1, Math.Round(x(i + 1), redon), Math.Round(er(i + 1), redon))
            j = j + 1
            i = i + 1
        Loop
        salida.Rows.Add("El Resultado es", Math.Round(x(i), redon))
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

End Class
