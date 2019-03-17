using System.Collections.Generic;
using ICSharpCode.AvalonEdit.Highlighting;

namespace Gemini.Modules.CodeEditor
{
    public interface ILanguageDefinition
    {
        string Name { get; }
        IEnumerable<string> FileExtensions { get; set; }
        IHighlightingDefinition SyntaxHighlighting { get; }
        string CustomSyntaxHighlightingFileName { get; set; }
    }

    public class ExcludeLanguageDefinition
    {
        public ILanguageDefinition ExcludedLanguageDefinition { get; }
        public ExcludeLanguageDefinition(ILanguageDefinition defitionToExclude)
        {
            ExcludedLanguageDefinition = defitionToExclude;
        }
    }
}
