#pragma checksum "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "560e19d4f34866c50b6ee479f2f50b514e8d220e"
// <auto-generated/>
#pragma warning disable 1591
namespace CustomerList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using CustomerList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using CustomerList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/megry/Development/CustomerList/CustomerList/_Imports.razor"
using CustomerList.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TaskList")]
    public partial class TaskList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Task List</h3>\n\n");
#nullable restore
#line 5 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
 if (taskList.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "progress my-2");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "progress-bar");
            __builder.AddAttribute(7, "role", "progressbar");
            __builder.AddAttribute(8, "style", "width:" + " " + (
#nullable restore
#line 9 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                             percentDone

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(9, "aria-valuemin", "0");
            __builder.AddAttribute(10, "aria-valuemax", "100");
            __builder.AddContent(11, 
#nullable restore
#line 11 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                                   percentDone

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
#nullable restore
#line 13 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "class", "form-inline my-2");
            __builder.AddAttribute(18, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                                           newTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                                                                   AddTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-contorl mx-2");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                                                      newTask.Task

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTask.Task = __value, newTask.Task))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTask.Task));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.AddMarkupContent(28, "<button type=\"submit\" class=\"btn btn-outline-primary\">Add Task</button>\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n\n");
            __builder.OpenElement(30, "ul");
            __builder.AddMarkupContent(31, "\n");
#nullable restore
#line 21 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
     foreach (var task in taskList)
     {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
         if (task.IsComplete)
         {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "            ");
            __builder.OpenElement(33, "li");
            __builder.AddAttribute(34, "class", "list-group-item list-group-item-secondary my-1");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                          (()=>task.IsComplete= !task.IsComplete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "del");
            __builder.AddContent(38, 
#nullable restore
#line 27 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                      task.Task

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n");
#nullable restore
#line 29 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.OpenElement(42, "li");
            __builder.AddAttribute(43, "class", "list-group-item list-group-item-success my-1");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                          (()=>task.IsComplete= !task.IsComplete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "\n                ");
            __builder.OpenElement(46, "del");
            __builder.AddContent(47, 
#nullable restore
#line 34 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
                      task.Task

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
#nullable restore
#line 36 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
         
     }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/megry/Development/CustomerList/CustomerList/Pages/TaskList.razor"
       
    public List<TaskModel> taskList = new List<TaskModel>();
    private TaskModel newTask = new TaskModel();

    private int percentDone
    {
        get
        {
            return (taskList.Count(x => x.IsComplete) * 100) / taskList.Count;
        }
    }

    private void AddTask()
    {
        taskList.Add(newTask);
        newTask = new TaskModel();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
