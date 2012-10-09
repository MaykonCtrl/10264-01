using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace _003_ObservableCollection
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((ListPessoa) Resources["Pessoas"])[0].Nome = ((ListPessoa) Resources["Pessoas"])[0].Nome.ToLower();
            foreach (var item in (ListPessoa) Resources["Pessoas"])
            {
                Debug.Print(item.Nome);
            }
        }
    }

    public class Pessoa 
    {
        public Pessoa(int codigo = 0, string nome= "")
        {
            Codigo = codigo;
            Nome = nome;
        }

        private bool naotem { get; set; }

        public int Codigo { get; set; }
        public String Nome { get; set; }
    }

    class ListPessoa : ObservableCollection<Pessoa>
    {
        public ListPessoa() 
        {
            Add(new Pessoa(1, "ADÃO"));
            Add(new Pessoa(2, "EVA"));
            Add(new Pessoa(3, "CAIM"));
            Add(new Pessoa(4, "ABEL"));
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            Debug.Print(e.Action.ToString());
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            
            Debug.Print("o conteúdo da propriedade {0} mudou", e.PropertyName);
        }
    }
}
