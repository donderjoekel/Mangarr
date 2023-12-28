using FluentResults;
using Mandarr.Frontend.Api;
using Mandarr.Shared.Models;
using Mandarr.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace Mandarr.Frontend.Pages.Settings.Sources;

public partial class ContentItem
{
    [Parameter] public ProviderModel? Item { get; set; }
    [Inject] public BackendApi BackendApi { get; set; }

    private bool _isUpdating;

    private string Title => Item!.Name;
    private string Url => Item!.Url;
    private bool Enabled => Item!.Enabled;

    private async Task ToggleEnabledAsync()
    {
        _isUpdating = true;
        await InvokeAsync(StateHasChanged);

        if (Enabled)
        {
            Result<ProviderDisableResponse> result = await BackendApi.DisableProvider(Item!.Identifier);

            if (result.IsFailed)
            {
                // TODO: Log error
            }
            else
            {
                Item = result.Value.Data;
            }
        }
        else
        {
            Result<ProviderEnableResponse> result = await BackendApi.EnableProvider(Item!.Identifier);

            if (result.IsFailed)
            {
                // TODO: Log error
            }
            else
            {
                Item = result.Value.Data;
            }
        }

        _isUpdating = false;
        await InvokeAsync(StateHasChanged);
    }
}
