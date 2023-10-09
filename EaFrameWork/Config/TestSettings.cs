using OpenQA.Selenium.DevTools.V115.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EaFrameWork.Driver.DriverFixture;

namespace EaFrameWork.Config
{
    public class TestSettings
    {
        public BrowserType BrosweType {get; set;}
        public Uri ApplicaitonUrl { get; set; }
        public float? TimeoutInterval { get; set; }


    }
}
