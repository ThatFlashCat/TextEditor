using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Text.Json;

namespace Blazored.TextEditor.Events
{
    public class TextChangeEventArgs
    {
        public object ContentDelta { get;  }
        public object OldContentDelta { get; }
        public string Source { get; }
        
        public TextChangeEventArgs(object[] argsData)
        {
            ContentDelta = argsData[0];
            OldContentDelta = argsData[1];
            Source = argsData[2].ToString();
        }
    }
}