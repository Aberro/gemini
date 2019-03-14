using System.ComponentModel.Composition;
using System.Threading;
using Caliburn.Micro;
using Gemini.Demo.Modules.SampleBrowser.ViewModels;
using Gemini.Framework;

namespace Gemini.Demo.Modules.SampleBrowser
{
    [Export(typeof(IModule))]
    public class Module : ModuleBase
    {
        public override void PostInitialize()
        {
            Shell.OpenDocumentAsync(IoC.Get<SampleBrowserViewModel>(), CancellationToken.None);
        }
    }
}
