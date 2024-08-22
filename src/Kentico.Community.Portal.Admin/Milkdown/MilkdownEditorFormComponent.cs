using Kentico.Xperience.Admin.Base.Forms;
using Kentico.Community.Portal.Admin;

[assembly: RegisterFormComponent(
    identifier: MilkdownEditorFormComponent.IDENTIFIER,
    componentType: typeof(MilkdownEditorFormComponent),
    name: "Milkdown editor")]

namespace Kentico.Community.Portal.Admin;

public class MilkdownEditorFormComponent : FormComponent<MilkdownEditorFormComponentClientProperties, string>
{
    public const string IDENTIFIER = "Kentico.Community.Portal.MilkdownEditorFormComponent";

    public override string ClientComponentName => "@kentico-community/portal-web-admin/MilkdownEditor";

    protected override Task ConfigureClientProperties(MilkdownEditorFormComponentClientProperties clientProperties)
    {
        base.ConfigureClientProperties(clientProperties);

        return Task.CompletedTask;
    }
}

public class MilkdownEditorFormComponentClientProperties : FormComponentClientProperties<string>
{
}
