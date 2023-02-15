using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using Demo_TS_WinUI.Contracts.ViewModels;
using Demo_TS_WinUI.Core.Contracts.Services;
using Demo_TS_WinUI.Core.Models;

namespace Demo_TS_WinUI.ViewModels;

public class DataGridViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DataGridViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
