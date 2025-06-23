using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TrabalhoFinalFPA.Views
{
    /// <summary>
    /// ResultadoView — Apenas Programação Dinâmica (Tamanho da LCS)
    /// </summary>
    public partial class ResultadoView : UserControl
    {
        private readonly List<(string helena, string marcus)> _entradas;

        public ResultadoView(List<(string helena, string marcus)> entradas)
        {
            InitializeComponent();
            _entradas = entradas;
            GerarResultados();
        }

        private void GerarResultados()
        {
            // Limpa abas existentes
            ResultadosTab.Items.Clear();

            for (int i = 0; i < _entradas.Count; i++)
            {
                var (helena, marcus) = _entradas[i];

                // Calcula o tamanho da LCS
                int tamanhoLCS = CalcularTamanhoLCS(helena, marcus);

                // Cria conteúdo da aba
                var stack = new StackPanel
                {
                    Margin = new Thickness(10)
                };

                // Sequência de Helena
                stack.Children.Add(new TextBlock
                {
                    Text = $"Sequência de Helena: {helena}",
                    FontSize = 16,
                    Foreground = Brushes.White,
                    Margin = new Thickness(0, 0, 0, 5)
                });

                // Sequência de Marcus
                stack.Children.Add(new TextBlock
                {
                    Text = $"Sequência de Marcus: {marcus}",
                    FontSize = 16,
                    Foreground = Brushes.White,
                    Margin = new Thickness(0, 0, 0, 15)
                });

                // Resultado do tamanho da LCS
                stack.Children.Add(new TextBlock
                {
                    Text = $"Tamanho da LCS: {tamanhoLCS}",
                    FontSize = 20,
                    FontWeight = FontWeights.Bold,
                    Foreground = Brushes.LightGreen,
                    Margin = new Thickness(0, 0, 0, 5)
                });

                // ScrollViewer para habilitar rolagem
                var scroll = new ScrollViewer
                {
                    Content = stack,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto
                };

                // Cria a aba no TabControl
                var tabItem = new TabItem
                {
                    Header = $"Conjunto {i + 1}",
                    Content = scroll
                };

                ResultadosTab.Items.Add(tabItem);
            }
        }

        // Função que calcula SOMENTE o tamanho da LCS com Programação Dinâmica
        private int CalcularTamanhoLCS(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (s1[i] == s2[j])
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                    else
                        dp[i + 1, j + 1] = Math.Max(dp[i, j + 1], dp[i + 1, j]);
                }
            }

            return dp[m, n];
        }

        // Botão Voltar
        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();

            Window currentWindow = Window.GetWindow(this);
            currentWindow?.Close();
        }
    }
}
