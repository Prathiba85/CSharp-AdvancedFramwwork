using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EaFrameWork.Extensions
{
    public static class WebElemntExtension
    {
        public static void SelectDropDownByText(this IWebElement element , String text)
        {
            var Select = new SelectElement (element);
            Select.SelectByText (text);

        }

        public static void SelectDropDownByValue(this IWebElement element, string value)
        {
            var Select = new SelectElement (element);
            Select.SelectByValue(value);
        }

        public static void SelectDropDownByValue(this IWebElement element, int index)
        {
            var Select = new SelectElement(element);
            Select.SelectByIndex(index);
        }

        public static void ClearAndEnterText(this IWebElement element,string value)
        {
            element.Clear ();
            element.SendKeys(value);

        }
    }
}
