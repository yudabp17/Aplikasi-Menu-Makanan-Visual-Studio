Public Class Form1
    Private Sub soto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles soto.Click
        ayam.Text = 8000
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time.Text = Date.Now.ToLongTimeString
        date2.Text = Date.Now.ToLongDateString
    End Sub

    Private Sub Bakso3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bakso3.Click
        bakso.Text = 10000
    End Sub

    Private Sub sateayam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sateayam.Click
        sate.Text = 50000
    End Sub

    Private Sub pecelayam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pecelayam.Click
        pecel.Text = 20000
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        aqua.Text = 2000
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        teh.Text = 2000
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        campur.Text = 5000
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        kelapa.Text = 5000
    End Sub

    Private Sub ayam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ayam.TextChanged
        makan.Text = Val(ayam.Text) + Val(bakso.Text) + Val(sate.Text) + Val(pecel.Text)
    End Sub

    Private Sub bakso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bakso.TextChanged
        makan.Text = Val(ayam.Text) + Val(bakso.Text) + Val(sate.Text) + Val(pecel.Text)
    End Sub

    Private Sub sate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sate.TextChanged
        makan.Text = Val(ayam.Text) + Val(bakso.Text) + Val(sate.Text) + Val(pecel.Text)
    End Sub

    Private Sub pecel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pecel.TextChanged
        makan.Text = Val(ayam.Text) + Val(bakso.Text) + Val(sate.Text) + Val(pecel.Text)
    End Sub
    Private Sub aqua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aqua.TextChanged
        minum.Text = Val(aqua.Text) + Val(teh.Text) + Val(campur.Text) + Val(kelapa.Text)
    End Sub

    Private Sub teh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teh.TextChanged
        minum.Text = Val(aqua.Text) + Val(teh.Text) + Val(campur.Text) + Val(kelapa.Text)
    End Sub

    Private Sub campur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles campur.TextChanged
        minum.Text = Val(aqua.Text) + Val(teh.Text) + Val(campur.Text) + Val(kelapa.Text)
    End Sub

    Private Sub kelapa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kelapa.TextChanged
        minum.Text = Val(aqua.Text) + Val(teh.Text) + Val(campur.Text) + Val(kelapa.Text)
    End Sub

    Private Sub ppn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ppn.TextChanged
        total.Text = (Val(makan.Text) + Val(minum.Text) + Val(ppn.Text)) - Val(diskon.Text)
        

    End Sub

    Private Sub TeksBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeksBox1.TextChanged
        ayam.Text = Val(TeksBox1.Text) * 8000
    End Sub

    Private Sub minum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minum.TextChanged
        Dim a, b, c, d As Double
        a = Val((makan.Text * 0.1) + Val(minum.Text * 0.1))
        ppn.Text = a * 0.1
        b = Val(makan.Text)
        If b >= 50000 Then
            b = Val((makan.Text * 0.2))
            diskon.Text = b * 0.2
        End If

    End Sub
    
    
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        kelapa.Text = Val(TextBox8.Text) * 5000
        Me.TextBox8.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        bakso.Text = Val(TextBox2.Text) * 10000
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        sate.Text = Val(TextBox3.Text) * 50000
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        pecel.Text = Val(TextBox4.Text) * 20000
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        aqua.Text = Val(TextBox5.Text) * 2000
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        teh.Text = Val(TextBox6.Text) * 2000
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        campur.Text = Val(TextBox7.Text) * 5000
    End Sub

    Private Sub bayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bayar.TextChanged

        Const uang As String = "UANG KEMBALIAN " + vbNewLine
        Dim pembayaran As Integer = Val(bayar.Text) - Val(total.Text)
        kmbali.Text = uang
        If pembayaran < 0 Then
            kmbali2.Text = "UANG ANDA KURANG"
        Else
            kmbali2.Text = "Rp. " & pembayaran
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        ayam.Enabled = False
        bakso.Enabled = False
        sate.Enabled = False
        pecel.Enabled = False

        aqua.Enabled = False
        teh.Enabled = False
        campur.Enabled = False
        kelapa.Enabled = False

        makan.Enabled = False
        minum.Enabled = False
        ppn.Enabled = False
        total.Enabled = False

        diskon.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ayam.Text = "0"
        bakso.Text = "0"
        sate.Text = "0"
        pecel.Text = "0"

        aqua.Text = "0"
        teh.Text = "0"
        campur.Text = "0"
        kelapa.Text = "0"

        makan.Text = "0"
        minum.Text = "0"
        ppn.Text = "0"
        total.Text = "0"
        diskon.Text = "0"
        bayar.Clear()

        TeksBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        kmbali.Text = "KEMBALIAN "
        kmbali2.Text = "KEMBALIAN"

        
    End Sub

   

End Class
