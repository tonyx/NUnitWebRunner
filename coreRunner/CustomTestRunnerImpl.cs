using System.Collections.Generic;
using System.Reflection;
using NUnit.Core;
using NunitWebRunner.coreRunner;

namespace NunitWebRunner.runner
{
    class CustomTestRunnerImpl : CustomTestRunner
    {
        public List<TestResult> RunTests()
        {
            MyEventListener eventListener = new MyEventListener();
            CoreExtensions.Host.InitializeService();
            SimpleTestRunner runner = new SimpleTestRunner();

            TestPackage package = new TestPackage("TemplateTestClass");

            string loc = Assembly.GetExecutingAssembly().Location;
            package.Assemblies.Add(loc);

            if (runner.Load(package))
            {
                runner.Run(eventListener, TestFilter.Empty, true, LoggingThreshold.All);
            }
            return eventListener.ListResults;
        }
    }
}