using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Core;

namespace NunitWebRunner.visualizer
{
    public interface TestResultVisualizer
    {
        void AddTestResult(TestResult testResult);
        void VisualizeTestResults(List<TestResult> testResultList );
    }
}