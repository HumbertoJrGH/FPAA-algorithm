// Importações de bibliotecas necessárias para funcionamento da interface WPF
using System.Windows;                     // Elementos da janela principal

// Importação da pasta Views, onde estão os componentes visuais (UserControls e Janelas)
using TrabalhoFinalFPA.Views;

namespace TrabalhoFinalFPA
{
    /// <summary>
    /// Código por trás (code-behind) da MainWindow, responsável pela lógica da janela inicial
    /// </summary>
    public partial class MainWindow : Window
    {
        // Construtor da janela principal
        public MainWindow()
        {
            InitializeComponent(); // Inicializa os componentes visuais definidos no XAML
        }

        // Evento disparado ao clicar no botão "Programação Dinâmica"
        private void IniciarAnalise_Click(object sender, RoutedEventArgs e)
        {
            // Cria uma instância da tela DataInputView (entrada de dados para o algoritmo de PD)
            var inputView = new DataInputView();

            // Substitui todo o conteúdo da janela atual pelo UserControl de entrada
            // Isso cria uma navegação direta sem abrir uma nova janela
            this.Content = inputView;
        }

        // Evento disparado ao clicar no botão "Backtracking"
        private void AbrirBacktracking_Click(object sender, RoutedEventArgs e)
        {
            // Cria uma instância da janela específica para a versão com backtracking
            var BackTrackingView = new BacktrackingWindow();

            // Substitui o conteúdo da janela principal pela nova janela do algoritmo
            // Apesar do nome "Window", é presumido aqui que BacktrackingWindow herda de UserControl
            // Se for realmente uma Window (janela), o correto seria usar .Show()
            this.Content = BackTrackingView;
        }
    }
}
