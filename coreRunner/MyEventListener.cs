using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Core;

namespace NunitWebRunner.coreRunner
{
    public class MyEventListener : EventListener
    {
        private List<TestResult> listResults;

        public List<TestResult> ListResults
        {
            get { return listResults; }
        }

        public MyEventListener()
        {
            listResults = new List<TestResult>();
        }

        public void RunStarted(string name, int testCount)
        {
        }

        public void RunFinished(TestResult result)
        {
        }

        public void RunFinished(Exception exception)
        {
        }

        public void TestStarted(TestName testName)
        {
            Console.Out.WriteLine("started " + testName);
        }

        public void TestFinished(TestResult result)
        {
            this.listResults.Add(result);
        }

        public void SuiteStarted(TestName testName)
        {
        }

        public void SuiteFinished(TestResult result)
        {
        }

        public void UnhandledException(Exception exception)
        {
        }

        public void TestOutput(TestOutput testOutput)
        {
        }
    }
}