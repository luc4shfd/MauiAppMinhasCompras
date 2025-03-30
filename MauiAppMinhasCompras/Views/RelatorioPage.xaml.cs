using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class RelatorioPage: ContentPage
{
    public RelatorioPage()
    {
        InitializeComponent();
    }

    private async void OnFiltrarClicked(object sender, EventArgs e)
    {
        DateTime dataInicial = DataInicialPicker.Date;
        DateTime dataFinal = DataFinalPicker.Date;

        var produtos = await App.Db.GetProdutosAsync();
        var produtosFiltrados = produtos
            .Where(p => p.DataCadastro >= dataInicial && p.DataCadastro <= dataFinal)
            .ToList();

        ProdutosListView.ItemsSource = produtosFiltrados;
    }


}