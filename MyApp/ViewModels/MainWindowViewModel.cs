using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MyApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<string> Periods { get; } = new();

    [ObservableProperty]
    private string? selectedPeriod;

    public MainWindowViewModel()
    {
        LoadData();
    }

    private async void LoadData()
    {
        try
        {
            using var client = new HttpClient();

            var data = await client.GetFromJsonAsync<List<PeriodItem>>(
                "http://localhost:5000/api/periods");

            if (data == null)
                return;

            Periods.Clear();

            foreach (var item in data)
            {
                Periods.Add(item.Name);
            }

            if (Periods.Count > 0)
            {
                SelectedPeriod = Periods[0];
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class PeriodItem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}
