namespace BlazorBuilds.Components.Common.Extensions;

public static class UtilityExtensions
{
    public static async ValueTask WhenTrue(this bool boolValue, Func<ValueTask> do_whenTrue)
    {
        if (boolValue) await do_whenTrue();
    }
}