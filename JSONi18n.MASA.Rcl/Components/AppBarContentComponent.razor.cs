using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace JSONi18n.MASA.Rcl.Components;

public partial class AppBarContentComponent
{
    [Parameter] public string? AvatarUrl { get; set; } = "https://cdn.masastack.com/stack/images/website/masa-blazor/doddgu.png";
    [Parameter] public string? AvatarTitle { get; set; } = "Hello";
    [Parameter] public string? AvatarSubtitle { get; set; } = "World";
    [Parameter] public string? EditFieldInnerIcon { get; set; } = "mdi-magnify";
    [Parameter] public string? RightButtonIcon { get; set; } = "mdi-plus";
    [Parameter] public string? BadgeColor { get; set; } = "primary";

    [Parameter] public EventCallback<MouseEventArgs> OnAvatarClick { get; set; }
    [Parameter] public EventCallback<MouseEventArgs> OnEditFieldClick { get; set; }
    //[Parameter] public EventCallback<MouseEventArgs> OnShortEditFieldClick { get; set; }
    [Parameter] public EventCallback<MouseEventArgs> OnRightButtonClick { get; set; }

    //protected override void OnInitialized( )
    //{
    //    base.OnInitialized();
    //}

    //public async Task HandleOnAvatarClickedAsync(ExMouseEventArgs args)
    //{
    //    if(OnAvatarClick.HasDelegate)
    //        await OnAvatarClick.InvokeAsync(args);
    //}

    //public async Task HandleOnShortEditFieldClickedAsync(ExMouseEventArgs args)
    //{
    //    if(OnRightButtonClick.HasDelegate)
    //        await OnEditFieldClick.InvokeAsync(args);
    //}

    //public async Task HandleOnRightButtonClickedAsync(ExMouseEventArgs args)
    //{
    //    if(OnRightButtonClick.HasDelegate)
    //        await OnRightButtonClick.InvokeAsync(args);
    //}
}
