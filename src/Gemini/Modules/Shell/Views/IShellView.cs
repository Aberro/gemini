using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Gemini.Framework;

namespace Gemini.Modules.Shell.Views
{
    public interface IShellView
    {
        void LoadLayout(Stream stream, Action<ITool> addToolCallback, Func<IDocument, CancellationToken, Task> addDocumentCallback,
                        Dictionary<string, ILayoutItem> itemsState);

        void SaveLayout(Stream stream);

        void UpdateFloatingWindows();
    }
}
