// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AffilateSource.Client.Pages.Home
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
#nullable restore
#line 2 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\Pages\Home\HomeLayout.razor"
using AffilateSource.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\Client\Pages\Home\HomeLayout.razor"
using AffilateSource.Shared.ViewModel.Post;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class HomeLayout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PostApiServices postApi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
