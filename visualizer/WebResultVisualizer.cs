using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using NUnit.Core;

namespace NunitWebRunner.visualizer
{
    class WebResultVisualizer : TestResultVisualizer
    {
        private Panel panel;
        private HtmlGenericControl _htmlBRControl;

        public WebResultVisualizer(Panel panel)
        {
            this.panel = panel;
        } 

        public void AddTestResult(TestResult res)
        {
            Label testName = LabelByContent(res.Name); new Label();
            Label resultState = LabelByContent(res.ResultState.ToString());
            Label message = LabelByContent(res.Message);

            panel.Controls.Add(testName);
            panel.Controls.Add(LabelByContent(" "));
            panel.Controls.Add(resultState);
            panel.Controls.Add(LabelByContent(" "));
            panel.Controls.Add(message);
            panel.Controls.Add(ImageResult(res.ResultState));
            _htmlBRControl = new HtmlGenericControl("br");
            panel.Controls.Add(_htmlBRControl);
        }

        public void VisualizeTestResults(List<TestResult> testResults)
        {
            foreach (TestResult res in testResults)
            {
                AddTestResult(res);
            }
        }

        private Label LabelByContent(string content)
        {
            Label label = new Label();
            label.Text = content;
            return label;
        }

        private Image ImageResult(ResultState resState)
        {
            Image image = new Image();
            if (resState.Equals(ResultState.Success))
            {
                image.ImageUrl = "~/img/passed.png";
            }
            else if (resState.Equals(ResultState.Ignored))
            {
                image.ImageUrl = "~/img/Ignored.png";
            }
            else
            {
                image.ImageUrl = "~/img/failed.png";
            }
            return image;
        }
    }
}