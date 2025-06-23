// Importações necessárias para criação de interfaces, controle de eventos e validação de texto
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;           // Controles visuais como TextBox, StackPanel, etc.
using System.Windows.Media;
using System.Text.RegularExpressions;    // Usado para validar o padrão das strings inseridas

namespace TrabalhoFinalFPA.Views
{
    /// <summary>
    /// Lógica da tela de entrada de dados (DataInputView.xaml)
    /// Permite ao usuário informar até 10 pares de sequências de letras minúsculas.
    /// </summary>
    public partial class DataInputView : UserControl
    {
        // Constante que define o número máximo de conjuntos permitidos
        private const int MaxConjuntos = 10;

        // Construtor da tela
        public DataInputView()
        {
            InitializeComponent(); // Carrega os elementos do XAML associado

            // Adiciona um evento ao campo de texto que define a quantidade de conjuntos
            ConjuntosTextBox.TextChanged += ConjuntosTextBox_TextChanged;
        }

        // Evento disparado sempre que o valor do campo "ConjuntosTextBox" for alterado
        private void ConjuntosTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Verifica se o número inserido é válido (entre 1 e 10)
            if (int.TryParse(ConjuntosTextBox.Text, out int count) && count >= 1 && count <= MaxConjuntos)
            {
                GerarCamposDeEntrada(count); // Gera os campos para os pares informados
            }
            else
            {
                ParesStackPanel.Children.Clear(); // Remove campos caso o valor seja inválido
            }
        }

        // Gera dinamicamente os campos de entrada para os pares de sequência
        private void GerarCamposDeEntrada(int quantidade)
        {
            // Limpa qualquer conteúdo anterior no painel
            ParesStackPanel.Children.Clear();

            for (int i = 0; i < quantidade; i++)
            {
                // Cria um grupo vertical para cada par de entradas
                var grupo = new StackPanel
                {
                    Margin = new Thickness(0, 10, 0, 10)
                };

                // Título do conjunto
                var titulo = new TextBlock
                {
                    Text = $"Conjunto {i + 1}",
                    Foreground = Brushes.LightGray,
                    FontSize = 16,
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(0, 0, 0, 5)
                };
                grupo.Children.Add(titulo);

                // Label e TextBox para Helena
                var labelHelena = new TextBlock
                {
                    Text = "Helena:",
                    Foreground = Brushes.White,
                    FontSize = 14,
                    FontWeight = FontWeights.SemiBold,
                    Margin = new Thickness(0, 5, 0, 2)
                };
                var helenaBox = new TextBox
                {
                    Tag = "Helena",
                    Margin = new Thickness(0, 0, 0, 8),
                    FontSize = 14,
                    Width = 500,
                    Foreground = Brushes.Black, // 🔥 Texto preto
                    Background = Brushes.White, // Opcional, pode deixar mais visível
                    Text = ""
                };

                // Label e TextBox para Marcus
                var labelMarcus = new TextBlock
                {
                    Text = "Marcus:",
                    Foreground = Brushes.White,
                    FontSize = 14,
                    FontWeight = FontWeights.SemiBold,
                    Margin = new Thickness(0, 5, 0, 2)
                };
                var marcusBox = new TextBox
                {
                    Tag = "Marcus",
                    Margin = new Thickness(0, 0, 0, 8),
                    FontSize = 14,
                    Width = 500,
                    Foreground = Brushes.Black, // 🔥 Texto preto
                    Background = Brushes.White, // Opcional, pode deixar mais visível
                    Text = ""
                };

                // Adiciona os elementos no grupo
                grupo.Children.Add(labelHelena);
                grupo.Children.Add(helenaBox);
                grupo.Children.Add(labelMarcus);
                grupo.Children.Add(marcusBox);

                // Adiciona o grupo ao StackPanel principal
                ParesStackPanel.Children.Add(grupo);
            }
        }

        // Evento disparado ao clicar no botão "Calcular LCS"
        private void CalcularLCS_Click(object sender, RoutedEventArgs e)
        {
            var entradas = new List<(string helena, string marcus)>();

            // Expressão regular para validar: apenas letras minúsculas entre 1 e 80 caracteres
            var regex = new Regex("^[a-z]{1,80}$");

            // Percorre cada grupo de entrada no StackPanel
            foreach (StackPanel grupo in ParesStackPanel.Children)
            {
                TextBox helenaBox = null;
                TextBox marcusBox = null;

                // Procura os TextBox com Tag "Helena" e "Marcus"
                foreach (var item in grupo.Children)
                {
                    if (item is TextBox box)
                    {
                        if (box.Tag?.ToString() == "Helena")
                            helenaBox = box;
                        else if (box.Tag?.ToString() == "Marcus")
                            marcusBox = box;
                    }
                }

                // Verifica se encontrou os campos (defensivo)
                if (helenaBox == null || marcusBox == null)
                {
                    MessageBox.Show("Erro interno ao ler os campos. Verifique se os campos foram corretamente gerados.",
                        "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var helena = helenaBox.Text.Trim();
                var marcus = marcusBox.Text.Trim();

                // Validação das strings usando regex
                if (!regex.IsMatch(helena) || !regex.IsMatch(marcus))
                {
                    MessageBox.Show("Todas as sequências devem conter apenas letras minúsculas e ter entre 1 e 80 caracteres.",
                        "Erro de Validação", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return; // Interrompe o processo se algum dado for inválido
                }

                // Adiciona o par válido na lista
                entradas.Add((helena, marcus));
            }

            // Cria a tela de resultados e substitui o conteúdo atual da janela
            var resultadoView = new ResultadoView(entradas);
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Content = resultadoView;
        }
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