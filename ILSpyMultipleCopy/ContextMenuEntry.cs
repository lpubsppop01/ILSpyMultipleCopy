using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ICSharpCode.ILSpy;

namespace Lpubsppop01.ILSpyMultipleCopy.Plugin
{
    [ExportContextMenuEntry(Header = "Copy text", Category = "ILSpyMultipleCopy", Order = 5.0001)]
    public class ContextMenuEntry : IContextMenuEntry
    {
        public void Execute(TextViewContext context)
        {
            if (context.SelectedTreeNodes == null) return;
            var buf = new StringBuilder();
            foreach (var node in context.SelectedTreeNodes)
            {
                if (node.Text is string text)
                {
                    buf.AppendLine(text);
                }
            }
            Clipboard.SetText(buf.ToString());
        }

        public bool IsEnabled(TextViewContext context)
        {
            return IsTargetContext(context);
        }

        public bool IsVisible(TextViewContext context)
        {
            return IsTargetContext(context);
        }

        static bool IsTargetContext(TextViewContext context)
        {
            try
            {
                if (context.SelectedTreeNodes == null || context.SelectedTreeNodes.Length == 0)
                {
                    return false;
                }
            }
            catch (Exception)
            {
            }
            return true;
        }
    }
}
