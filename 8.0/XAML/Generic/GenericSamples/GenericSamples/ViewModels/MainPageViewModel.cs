using GenericSamples.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.ViewModels;

internal class MainPageViewModel
{
    #region Properties

    public Type Type { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public static IList<MainPageViewModel> All { get; private set; }

    #endregion

    #region Constructor

    static MainPageViewModel()
    {
        All = new List<MainPageViewModel>()
        {
            new MainPageViewModel()
            {
                Type=typeof(SinglePrimitiveTypeArgumentPage),
                Title="Single primitive type argument",
                Description="A single primitive type argument can be specified as a prefixed string argument using the x:TypeArguments directive."
            },
            new MainPageViewModel()
            {
                Type=typeof(SingleObjectTypeArgumentPage),
                Title="Single object type argument",
                Description="A single object type argument can be specified as a prefixed string argument using the x:TypeArguments directive."
            },
            new MainPageViewModel()
            {
                Type=typeof(MultipleTypeArgumentsPage),
                Title="Multiple type arguments",
                Description="Multiple type arguments can be specified as prefixed string arguments, delimited by a comma, using the x:TypeArguments directive."
            },
        };
    }

    #endregion
}
