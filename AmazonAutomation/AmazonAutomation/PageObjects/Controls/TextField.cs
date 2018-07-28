using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AmazonAutomation.PageObjects
{
    public class TextField : Control
    {
        public new string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                this.Click();
                this.Element.Clear();
                this.Element.SendKeys(value);
            }
        }

        public TextField(By by) : base(by)
        {
        }

        public TextField(By parentBy, By by) : base(parentBy, by)
        {
        }
    }
}
