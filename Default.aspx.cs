using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using NUnit.Core;
using NUnit.Framework;
using NunitWebRunner.coreRunner;
using NunitWebRunner.runner;
using NunitWebRunner.visualizer;

namespace NunitWebRunner
{
    public partial class _Default : System.Web.UI.Page
    {
        private TestResultVisualizer testResultVisualizer;
        private CustomTestRunner testRunner;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            testRunner = new CustomTestRunnerImpl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            testResultVisualizer = new WebResultVisualizer(this.Panel2);
            List<TestResult> testResults = testRunner.RunTests();
            testResultVisualizer.VisualizeTestResults(testResults);
        }
    }
}
