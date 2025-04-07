using Fantasy.Frontend.Repositories;
using Fantasy.Frontend.Shared.Resources;
using Fantasy.Shared.Entites;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Fantasy.Frontend.Pages.Countries;

public partial class CountriesIndex
{
    [Inject] private IRepository Repository { get; set; } = null!;
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;

    private List<Country>? Countries { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var responseHttp = await Repository.GetAsync<List<Country>>("api/countries");
        Countries = responseHttp.Response;
    }
}