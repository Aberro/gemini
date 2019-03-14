using System;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace Gemini.Framework.Results
{
    public class ShowDialogResult<TWindow> : OpenResultBase<TWindow>
        where TWindow : IWindow
    {
        private readonly Func<TWindow> _windowLocator = () => IoC.Get<TWindow>();

        public ShowDialogResult()
        {
        }

        public ShowDialogResult(TWindow window)
        {
            _windowLocator = () => window;
        }

        [Import]
        public IWindowManager WindowManager { get; set; }

        public override async void Execute(CoroutineExecutionContext context)
        {
            TWindow window = _windowLocator();

            if (_setData != null)
                _setData(window);

            if (_onConfigure != null)
                _onConfigure(window);

            bool result = (await WindowManager.ShowDialogAsync(window)).GetValueOrDefault();

            if (_onShutDown != null)
                _onShutDown(window);

            OnCompleted(null, !result);
        }
    }
}
