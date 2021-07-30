Public Class FRM_DATA_HORA

    Private Sub BTN_CARREGA_Click(sender As System.Object, e As System.EventArgs) Handles BTN_CARREGA.Click
        LST_DATA_HORA.Items.Clear()
        Dim dtAtual As DateTime = Now

        LST_DATA_HORA.Items.Add("Agora")
        LST_DATA_HORA.Items.Add("")
        LST_DATA_HORA.Items.Add(dtAtual)
        LST_DATA_HORA.Items.Add("")
        LST_DATA_HORA.Items.Add("Data : " & dtAtual.ToShortDateString)
        LST_DATA_HORA.Items.Add("Hora : " & dtAtual.ToShortTimeString)
        LST_DATA_HORA.Items.Add("Ticks : " & dtAtual.Ticks.ToString)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        LST_DATA_HORA.Items.Clear()
        Dim datahoraAtual As DateTime = Now

        LST_DATA_HORA.Items.Add(datahoraAtual)
        LST_DATA_HORA.Items.Add("")
        LST_DATA_HORA.Items.Add("Um ano atrás : " & datahoraAtual.AddYears(-1))
        LST_DATA_HORA.Items.Add("No ano seguinte : " & datahoraAtual.AddYears(+1))
        LST_DATA_HORA.Items.Add("No mês seguinte : " & datahoraAtual.AddMonths(+1))
        LST_DATA_HORA.Items.Add("No mês anterior : " & datahoraAtual.AddMonths(-1))
        LST_DATA_HORA.Items.Add("No dia anterior : " & datahoraAtual.AddDays(-1))
        LST_DATA_HORA.Items.Add("No próximo dia : " & datahoraAtual.AddDays(+1))
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim dataAtual As Date = Now
        Dim diaDaSemana As Integer = dataAtual.DayOfWeek
        Dim diaDaSemanaAbreviado As String = Format(dataAtual, "ddd")
        Dim diaDaSemanaExpandido As String = String.Format("{0:dddd}", dataAtual)
        Dim resultado As String = String.Format("Hoje é o dia da semana : {0}, ou {1}, ou {2}", diaDaSemana, diaDaSemanaAbreviado, diaDaSemanaExpandido)
        MsgBox(resultado)


        '-------------------------
        'Obtem data e hora atual do sistema

        MsgBox(Date.Now)

        'Obtendo dia da semana

        MsgBox(String.Format("{0:dddd}", Now))

        'Soma 20 dias a data atual

        MsgBox(Date.Now.AddDays(20))

        'Subtrai 15 dias da data atual

        MsgBox(Date.Now.AddDays(-15))

        'Exibe uma mensagem informando se o ano é bissexto

        If Date.IsLeapYear(2007) = True Then

            MsgBox("Ano Bissexto")

        Else

            MsgBox("Ano Não Bissexto")

        End If

        'Exibe o número de dias do mês para  o ano de 2007 e mes 2

        MsgBox("O numero de dias do mês é: " & Date.DaysInMonth(2007, 2))
        '----
        MsgBox("TIPOS DE FORMATOS DE DATAS..." & vbNewLine & _
        "Exibe data e hora= " & DateTime.Now.ToString() & vbNewLine & _
        "Exibe hora sem os segundos= " & DateTime.Now.ToShortTimeString() & vbNewLine & _
        "Exibe a data com barras= " & DateTime.Now.ToShortDateString() & vbNewLine & _
        "Exibe as horas, minutos e  segundos= " & DateTime.Now.ToLongTimeString() & vbNewLine & _
        "Exibe a data em modo extensor= " & DateTime.Now.ToLongDateString() & vbNewLine & _
        "2/6/2010= " & DateTime.Now.ToString("d") & vbNewLine & _
        "quarta-feira, 2 de junho de 2010= " & DateTime.Now.ToString("D") & vbNewLine & _
        "quarta-feira, 2 de junho de 2010 15:24= " & DateTime.Now.ToString("f") & vbNewLine & _
        " 	quarta-feira, 2 de junho de 2010 15:24:18= " & DateTime.Now.ToString("F") & vbNewLine & _
        "2/6/2010 15:24= " & DateTime.Now.ToString("g") & vbNewLine & _
        "2/6/2010 15:24:48= " & DateTime.Now.ToString("G") & vbNewLine & _
        "02 de junho= " & DateTime.Now.ToString("m") & vbNewLine & _
        " 	Wed, 02 Jun 2010 15:26:07 GMT= " & DateTime.Now.ToString("r") & vbNewLine & _
        "2010-06-02T15:26:20= " & DateTime.Now.ToString("s") & vbNewLine & _
        "15:26= " & DateTime.Now.ToString("t") & vbNewLine & _
        "15:26:40= " & DateTime.Now.ToString("T") & vbNewLine & _
        " 2010-06-02 15:26:51Z= " & DateTime.Now.ToString("u") & vbNewLine & _
        "quarta-feira, 2 de junho de 2010 18:26:59= " & DateTime.Now.ToString("U") & vbNewLine & _
        "junho de 2010= " & DateTime.Now.ToString("y") & vbNewLine & _
        "quarta-feira, junho 02 2010= " & DateTime.Now.ToString("dddd, MMMM dd yyyy") & vbNewLine & _
        "qua, jun 02 10= " & DateTime.Now.ToString("ddd, MMM d '' ‘ ''yy") & vbNewLine & _
        "quarta-feira, junho 02= " & DateTime.Now.ToString("dddd, MMMM dd") & vbNewLine & _
        " 06/10= " & DateTime.Now.ToString("MM/yy") & vbNewLine & _
        "02/06/10= " & DateTime.Now.ToString("dd/MM/yy"))
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'Define as variáveis 
        Dim hoje As Date = Today
        Dim agora As Date = Now
        MsgBox("Hoje é dia: " & agora)
        agora = agora.AddDays(2)
        MsgBox("Somando-se 2 dias: " & agora)
        agora = agora.AddMonths(3)
        MsgBox("Somando-se 3 meses: " & agora)
        Dim ProxMes As Date = DateAdd(DateInterval.Month, 3, hoje)
        MsgBox("Somando-se 3 meses com DateAdd: " & ProxMes)
        Dim ProxAno As Date = DateAdd(DateInterval.Year, 1, hoje)
        MsgBox("Somando-se 1 ano com DateAdd: " & ProxAno)
        'Calcula a idade 
        Dim idade As Long
        Dim nasc As Date = #12/06/1994#
        idade = DateDiff(DateInterval.Year, nasc, Today)
        If DateSerial(Today.Year, nasc.Month, nasc.Day) > Today Then
            idade = idade - 1
        End If
        MsgBox("idade: " & idade)

        '---- FORMATANDO DATA E HORA

        Dim dataAtual As DateTime = DateTime.Now
        MsgBox("Este exemplo se baseia em: " & Format(dataAtual, "General Date"))
        MsgBox("-- Função de formatação --")
        MsgBox("Data completa: " & FormatDateTime(dataAtual, DateFormat.GeneralDate))
        MsgBox("Long Date: " & FormatDateTime(dataAtual, DateFormat.LongDate))
        MsgBox("Short Date: " & FormatDateTime(dataAtual, DateFormat.ShortDate))
        MsgBox("Long Time: " & FormatDateTime(dataAtual, DateFormat.LongTime))
        MsgBox("Short Time: " & FormatDateTime(dataAtual, DateFormat.ShortTime))
        MsgBox("-- Formatos de dias --")
        MsgBox("d: -> " & Format(dataAtual, "d"))
        MsgBox("dd: -> " & Format(dataAtual, "dd"))
        MsgBox("ddd: -> " & Format(dataAtual, "ddd"))
        MsgBox("dddd: -> " & Format(dataAtual, "dddd"))
        MsgBox("-- Formatos de meses --")
        MsgBox("M: -> " & Format(dataAtual, "M"))
        MsgBox("MM: -> " & Format(dataAtual, "MM"))
        MsgBox("MMM: -> " & Format(dataAtual, "MMM"))
        MsgBox("MMMM: -> " & Format(dataAtual, "MMMM"))
        MsgBox("-- Formatos de anos --")
        MsgBox("y: -> " & Format(dataAtual, "y"))
        MsgBox("yy: -> " & Format(dataAtual, "yy"))
        MsgBox("yyyy -> " & Format(dataAtual, "yyyy"))
        MsgBox("-- Formatos de horas --")
        MsgBox("hh: -> " & Format(dataAtual, "hh"))
        MsgBox("HH: -> " & Format(dataAtual, "HH"))
        MsgBox("-- Formatos de minutos --")
        MsgBox("mm: -> " & Format(dataAtual, "mm"))
        MsgBox("-- Formatos de segundos --")
        MsgBox("ss: -> " & Format(dataAtual, "ss"))
        MsgBox("-- Formatos de personalizados --")
        MsgBox("dd/MM/yyyy: -> " & Format(dataAtual, "dd/MM/yyyy"))
        MsgBox("MM/dd/yyyy: -> " & Format(dataAtual, "MM/dd/yyyy"))
        MsgBox("dd/MM: -> " & Format(dataAtual, "dd/MM"))
        MsgBox("dd ddd/MMM/yyyy: -> " & Format(dataAtual, "dd ddd/MMM/yyyy"))
        MsgBox("dd dddd/MMMM/yyyy: -> " & Format(dataAtual, "dd dddd/MMMD/yyyy"))
        MsgBox("dddd dd/MMM/yyyy: -> " & Format(dataAtual, "dddd dd/MMM/yyyy"))
    End Sub

End Class
