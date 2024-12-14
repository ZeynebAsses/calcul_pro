
Public Class calul_pro
    Dim a As String
    Dim b As String
    Dim op = ""
    Dim test As Boolean = False
    Dim res As Object
    Private Sub Button_0_Click(sender As Object, e As EventArgs) Handles Button_0.Click
        If op = "" Then
            A = a + 0
        Else
            B = b + 0
        End If
    End Sub

    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        If op = "" Then
            A = a + 1
        Else
            B = b + 1
        End If
    End Sub

    Private Sub Button_egal_Click(sender As Object, e As EventArgs) Handles Button_egal.Click
        If IsNumeric(a) And IsNumeric(b) Then
            Dim test = True
            Dim va = Integer.Parse(a)
            Dim vb = Integer.Parse(b)

            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va + vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" Then
                res = va / vb
            Else
                MessageBox.Show("division par 0")
                test = False

            End If
            If test Then
                res.text = res.text + "=" + res.ToString + "" + op + "" + b.ToString + "=" + res.ToString
            Else
                MessageBox.Show("a et b doivent etre des entiers ")
            End If
        End If
    End Sub

    Private Sub Button_div_Click(sender As Object, e As EventArgs) Handles Button_div.Click
        If Not A = "" Then
            op = "/"
        End If
        res.text = a + "" + op + "" + b
    End Sub

    Private Sub Button_plus_Click(sender As Object, e As EventArgs) Handles Button_plus.Click
        If Not a = "" Then
            op = "+"
        End If
        Res.text = a + "" + op + "" + b
    End Sub

    Private Sub Button_fois_Click(sender As Object, e As EventArgs) Handles Button_fois.Click
        If Not A = "" Then
            op = "*"
        End If
        res.text = a + "" + op + "" + b
    End Sub
    Private Sub Button_moins_Click(sender As Object, e As EventArgs) Handles Button_moins.Click
        If Not A = "" Then
            op = "-"
        End If
        Res.text = a + "" + op + "" + b

    End Sub

    Private Sub Button_c_Click(sender As Object, e As EventArgs) Handles Button_c.Click
        res.text = ""
    End Sub

    Private Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button_2.Click
        If op = "" Then
            A = a + 2
        Else
            B = b + 2
        End If
    End Sub

    Private Sub button_3_Click(sender As Object, e As EventArgs) Handles button_3.Click
        If op = "" Then
            A = a + 3
        Else
            B = b + 3
        End If
    End Sub

    Private Sub Button_4_Click(sender As Object, e As EventArgs) Handles Button_4.Click
        If op = "" Then
            A = a + 4
        Else
            B = b + 4
        End If
    End Sub

    Private Sub Button_5_Click(sender As Object, e As EventArgs) Handles Button_5.Click
        If op = "" Then
            A = a + 5
        Else
            B = b + 5
        End If
    End Sub

    Private Sub button_6_Click(sender As Object, e As EventArgs) Handles button_6.Click
        If op = "" Then
            A = a + 6
        Else
            B = b + 6
        End If
    End Sub

    Private Sub Button_7_Click(sender As Object, e As EventArgs) Handles Button_7.Click
        If op = "" Then
            A = a + 7
        Else
            B = b + 7
        End If
    End Sub

    Private Sub Button_8_Click(sender As Object, e As EventArgs) Handles Button_8.Click
        If op = "" Then
            A = a + 8
        Else
            B = b + 8
        End If
    End Sub

    Private Sub Button_9_Click(sender As Object, e As EventArgs) Handles Button_9.Click
        If op = "" Then
            A = a + 9
        Else
            B = b + 9
        End If
    End Sub
End Class
