using System.Diagnostics.CodeAnalysis;
using AngleSharp.Dom;

namespace Mangarr.Stack.Sources.Extensions;

public static class AngleSharpExtensions
{
    public static bool TryGetParentElement<TElement>(
        this IElement element,
        [NotNullWhen(true)] out TElement? parentElement
    )
        where TElement : IElement
    {
        while (element.ParentElement != null)
        {
            if (element.ParentElement is TElement parent)
            {
                parentElement = parent;
                return true;
            }

            element = element.ParentElement;
        }

        parentElement = default;
        return false;
    }
}
