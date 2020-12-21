using System;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;

namespace Blazored.TextEditor.Events
{
    public class EditorChangeEventArgs
    {
        public string EventName { get; }
        public object UnderlyingEventData { get; }

        public EditorChangeEventArgs(object[] argsData)
        {
            EventName = argsData[0].ToString();
            if (EventName == "text-change")
            {
                UnderlyingEventData = new TextChangeEventArgs(argsData.Skip(1).ToArray());
            }
            else
            {
                UnderlyingEventData = new SelectionChangeEventArgs(argsData.Skip(1).ToArray());
            }
        }
    }
}