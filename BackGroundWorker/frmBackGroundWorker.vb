'http://imasters.com.br/artigo/5743/dotnet/trabalhando-com-backgroundworker/

Public Class frmBackGroundWorker
    Dim MeuDataTable As New DataTable

    Private Sub PopularDataTable()
        Try

            '*********************************************************
            'Iremos forçar que o nosso aplicativo demore
            'alguns segundos, especificaremos isso na
            'Threading atual, conforme a linha de código abaixo
            '*********************************************************
            Threading.Thread.Sleep(10000)

            Dim intCont As Integer

            '*********************************************************
            'A estrutura de repetição seguir, servirá para
            'adicionarmos itens ao nosso DataTable
            '*********************************************************

            For intCont = 0 To 2000
                Dim dr As Data.DataRow

                '********************************************************
                ' Verificando se a quantidade de coluna no datatable
                ' é menor que 1, sendo será criada um coluna e adicionada
                ' ao dataTable
                '********************************************************
                If MeuDataTable.Columns.Count < 1 Then
                    Dim dc As New Data.DataColumn

                    dc.ColumnName = "id"

                    MeuDataTable.Columns.Add(dc)
                End If

                '********************************************************
                ' Criando uma nova Linha para o nosso datetable
                '********************************************************
                dr = MeuDataTable.NewRow()

                '********************************************************
                ' Atribuindo um valor a primeira coluna dessa nova linha
                '********************************************************
                dr(0) = intCont * 2000

                '********************************************************
                ' Adicionando o linha ao DataTable
                '********************************************************
                MeuDataTable.Rows.Add(dr)

            Next

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Esse evento será o responsável por executar os procedimentos em um nova thread. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub bwrTeste_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwrTeste.DoWork
        Try
            Me.PopularDataTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Esse evento só é disparado quando é finalizada a thread criada no evento DoWork.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub bwrTeste_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwrTeste.RunWorkerCompleted
        Try
            Me.dgvTeste.DataSource = MeuDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Nesse evento iremos dizer ao aplicativo que ele deverá iniciar o BackgroundWorker, 
    ''' fazendo com que dispare o evento DoWork do componente BackgroundWorker.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCarregarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarGrid.Click
        Try
            Me.bwrTeste.RunWorkerAsync()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' O objetivo desse evento nesse contexto é apenas mostrar que mesmo o aplicativo 
    ''' carregando o grid, você poderá deixar outra funcionalidades livres.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTestarThreading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestarThreading.Click
        Try
            MessageBox.Show("Funcionando!!!!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class