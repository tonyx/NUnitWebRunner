using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Core;

namespace NunitWebRunner.runner
{
    public interface CustomTestRunner
    {
        List<TestResult> RunTests();
    }
}