using Gallio.Model.Schema;
using Gallio.Runner.Reports.Schema;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TestPlatform.Gallio
{
    public interface ITestResultFactory
    {
        TestResult BuildTestResult(TestData testData, TestStepRun testStepRun, TestCase testCase);
    }
}