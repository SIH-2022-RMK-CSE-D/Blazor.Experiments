using Blazor.Experiments.Components.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Linq.Expressions;

namespace Blazor.Experiments.Markdown;

public partial class Editor
{
    private FieldIdentifier _fieldIdentifier;
    private string _fieldCssClasses => CascadedEditContext?.FieldCssClass(_fieldIdentifier) ?? "";

    protected string PreviewClassName => new CssBuilder().AddClass("container").AddClass(PreviewClass).AddClass("p-4").Build();

    [CascadingParameter]
    private EditContext CascadedEditContext { get; set; }

    [Parameter]
    public string TextAreaClass { get; set; }

    [Parameter]
    public string TextAreaStyles { get; set; }

    [Parameter]
    public string PreviewClass { get; set; }

    [Parameter]
    public string PreviewStyles { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public bool ShowPreview { get; set; } = true;

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    [Parameter]
    public Expression<Func<string>> ValueExpression { get; set; }

    [Parameter]
    public RenderFragment ToolbarContent { get; set; }

    protected override void OnInitialized()
    {
        _fieldIdentifier = FieldIdentifier.Create(ValueExpression);
    }

    public async Task HandleInput(ChangeEventArgs args)
    {
        await ValueChanged.InvokeAsync(args.Value.ToString());
        CascadedEditContext?.NotifyFieldChanged(_fieldIdentifier);
    }
}
