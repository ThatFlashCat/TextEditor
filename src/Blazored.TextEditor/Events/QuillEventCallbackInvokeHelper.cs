using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazored.TextEditor.Events
{
    internal class QuillEventCallbackInvokeHelper
    {
        private readonly Func<string, object[], Task> action;

        public QuillEventCallbackInvokeHelper(Func<string, object[], Task> action)
        {
            this.action = action;
        }

        [JSInvokable]
        public Task QuillEventCallbackCaller(string eventName, object[] arguments)
        {
            return action.Invoke(eventName, arguments);
        }
    }
}