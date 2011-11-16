﻿using Gallio.Common;
using Gallio.Model.Schema;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Microsoft.VisualStudio.TestPlatform.Gallio
{
    public class CachingTestCaseFactory : ITestCaseFactory
    {
        private readonly ITestCaseFactory testCaseFactory;
        private KeyedMemoizer<string, TestCase> testCases;

        public CachingTestCaseFactory(ITestCaseFactory testCaseFactory)
        {
            this.testCaseFactory = testCaseFactory;
            testCases = new KeyedMemoizer<string, TestCase>();
        }

        public TestCase GetTestCase(TestData testData)
        {
            return testCases.Memoize(testData.Id, () => testCaseFactory.GetTestCase(testData));
        }
    }
}