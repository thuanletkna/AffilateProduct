// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AffilateSource.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using AffilateSource.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using AffilateSource.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    public partial class CKEditorBlazor : InputTextArea
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\Shared\CKEditorBlazor.razor"
       
    string _id;

    [Parameter]
    public string Id
    {
        get => _id ?? $"CKEditor_{uid}";
        set => _id = value;
    }

    [Parameter]
    public string UrlToPostImage { get; set; }

    [Parameter]
    public string Height { get; set; }


    readonly string uid = Guid.NewGuid().ToString().ToLower().Replace("-", "");

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await JSRuntime.InvokeVoidAsync("CKEditorInterop.init", Id, UrlToPostImage, DotNetObjectReference.Create(this));

        await base.OnAfterRenderAsync(firstRender);
    }

    [JSInvokable]
    public Task EditorDataChanged(string data)
    {
        CurrentValue = data;
        StateHasChanged();
        return Task.CompletedTask;
    }

    protected override void Dispose(bool disposing)
    {
        JSRuntime.InvokeVoidAsync("CKEditorInterop.destroy", Id);
        base.Dispose(disposing);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
