using System;
using System.Linq;
using System.Text;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;

namespace litui
{
    /// <summary>
    /// Provides methods which can help in debugging.
    /// </summary>
    internal static class Debug
    {
        /// <summary>
        /// Gets the XPath to the element until the desktop or the given root element.
        /// Warning: This is quite a heavy operation
        /// </summary>
        public static string GetXPathToElement(AutomationElement element, AutomationElement rootElement = null)
        {
            var treeWalker = element.Automation.TreeWalkerFactory.GetControlViewWalker();
            string xpath= GetXPathToElement(element, treeWalker, rootElement);
            while (xpath.Contains("///"))
            {
                xpath = xpath.Replace("///", "//");
            }
            return xpath;
        }

        private static string GetXPathToElement(AutomationElement element, ITreeWalker treeWalker, AutomationElement rootElement = null)
        {
            var parent = treeWalker.GetParent(element);
            if (parent == null || (rootElement != null && parent.Equals(rootElement)))
            {
                return String.Empty;
            }
            string currentItemText = "/";
            //element.Properties.ControlType ControlType 可能不支持
            // Get the index
            if (element.Properties.ControlType.IsSupported)
            {
                var allChildren = parent.FindAllChildren(cf => cf.ByControlType(element.Properties.ControlType.Value));
                currentItemText = $"{element.Properties.ControlType.Value}";
                if (allChildren.Length > 1)
                {
                    // There is more than one matching child, find out the index
                    var indexInParent = 1; // Index starts with 1
                    foreach (var child in allChildren)
                    {
                        if (child.Equals(element))
                        {
                            break;
                        }
                        indexInParent++;
                    }
                    currentItemText += $"[{indexInParent}]";
                }
            }
            return $"{GetXPathToElement(parent, treeWalker, rootElement)}/{currentItemText}";
        }
    }
}
