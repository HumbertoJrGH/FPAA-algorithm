// Importações básicas para construção da interface WPF
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;           // Controles gráficos como TextBox, Button, ListBox etc.

namespace TrabalhoFinalFPA.Views
{
    /// <summary>
    /// Código por trás da tela "BacktrackingWindow".
    /// Permite que o usuário insira duas sequências e visualize todas as subsequências comuns mais longas (LCS).
    /// Essa tela usa programação dinâmica com backtracking para exibir os resultados.
    /// </summary>
    public partial class BacktrackingWindow : UserControl
    {
        // Construtor da tela
        public BacktrackingWindow()
        {
            InitializeComponent(); // Inicializa os componentes definidos no XAML
        }

        // Evento acionado quando o botão "Calcular" é clicado
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            // Lê os valores inseridos pelo usuário e remove espaços em branco nas extremidades
            string sequencia1 = txtSequenciaHelena.Text.Trim();
            string sequencia2 = txtSequenciaMarcus.Text.Trim();

            // Limpa os resultados anteriores exibidos na tela
            lstResultados.Items.Clear();

            // Verifica se as duas sequências foram preenchidas
            if (string.IsNullOrEmpty(sequencia1) || string.IsNullOrEmpty(sequencia2))
            {
                MessageBox.Show("Preencha ambas as sequências.", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                // Executa o algoritmo para obter todas as subsequências comuns mais longas
                var resultado = ObterTodasSubsequencias(sequencia1, sequencia2);

                // Exibe os resultados no ListBox
                foreach (var item in resultado)
                {
                    lstResultados.Items.Add(item);
                }

                // Mostra uma mensagem com a quantidade de subsequências encontradas
                MessageBox.Show($"Encontrado {resultado.Count} subsequência(s).", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro se algo inesperado acontecer
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Algoritmo principal: encontra todas as LCS usando Programação Dinâmica + Backtracking
        private List<string> ObterTodasSubsequencias(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;

            // Matriz DP que armazena os tamanhos das LCS parciais
            int[,] dp = new int[m + 1, n + 1];

            // Preenche a matriz DP comparando todos os prefixos de s1 e s2
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (s1[i] == s2[j])
                        dp[i + 1, j + 1] = dp[i, j] + 1; // Match: incrementa valor anterior na diagonal
                    else
                        dp[i + 1, j + 1] = Math.Max(dp[i, j + 1], dp[i + 1, j]); // Desempate: pega valor maior entre cima e esquerda
                }
            }

            // Conjunto para evitar duplicatas de subsequências
            var resultado = new HashSet<string>();

            // Inicia o backtracking a partir do fim das strings
            Backtrack(dp, s1, s2, m, n, "", resultado);

            // Retorna os resultados ordenados
            return resultado.OrderBy(x => x).ToList();
        }

        // Algoritmo recursivo que reconstrói todas as subsequências possíveis (backtracking)
        private void Backtrack(int[,] dp, string s1, string s2, int i, int j, string caminho, HashSet<string> resultado)
        {
            // Caso base: chegou ao início de alguma das strings
            if (i == 0 || j == 0)
            {
                // Adiciona a string ao conjunto invertendo-a (pois é construída de trás pra frente)
                resultado.Add(new string(caminho.Reverse().ToArray()));
                return;
            }

            // Se os caracteres atuais forem iguais, move-se na diagonal (LCS comum)
            if (s1[i - 1] == s2[j - 1])
            {
                Backtrack(dp, s1, s2, i - 1, j - 1, caminho + s1[i - 1], resultado);
            }
            else
            {
                // Caminha para as direções possíveis com base no maior valor da matriz
                if (dp[i - 1, j] >= dp[i, j - 1])
                    Backtrack(dp, s1, s2, i - 1, j, caminho, resultado);

                if (dp[i, j - 1] >= dp[i - 1, j])
                    Backtrack(dp, s1, s2, i, j - 1, caminho, resultado);
            }
        }

        // Evento do botão "Voltar" — retorna para a tela principal (MainWindow)
        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            // Cria e mostra a janela principal
            MainWindow main = new MainWindow();
            main.Show();

            // Fecha a janela atual
            Window currentWindow = Window.GetWindow(this);
            currentWindow?.Close();
        }
    }
}
