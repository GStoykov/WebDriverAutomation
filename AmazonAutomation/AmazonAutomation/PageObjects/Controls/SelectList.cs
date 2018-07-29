using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAutomation.PageObjects
{
   public class SelectList : Control
    {
        public SelectElement Select
        {
            get
            {
                return new SelectElement(base.Element);
            }
        }

        public new string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                this.Select.SelectByText(value);
            }
        }

        public SelectList(By by) : base(by)
        {
        }

        public SelectList(By parentBy, By by) : base(parentBy, by)
        {
        }
    }
}
