﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoStartConfirmTests.TestHelpers
{
    public class STATestMethodAttribute : TestMethodAttribute
    {
        private readonly TestMethodAttribute? _testMethodAttribute;

        public STATestMethodAttribute(TestMethodAttribute? testMethodAttribute)
        {
            _testMethodAttribute = testMethodAttribute;
        }

        public override TestResult[] Execute(ITestMethod testMethod)
        {
            if (Thread.CurrentThread.GetApartmentState() == ApartmentState.STA)
                return Invoke(testMethod);

            TestResult[]? result = null;
            var thread = new Thread(() => result = Invoke(testMethod));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            return result!;
        }

        private TestResult[] Invoke(ITestMethod testMethod)
        {
            if (_testMethodAttribute != null)
                return _testMethodAttribute.Execute(testMethod);

            return new[] { testMethod.Invoke(null) };
        }
    }
}
