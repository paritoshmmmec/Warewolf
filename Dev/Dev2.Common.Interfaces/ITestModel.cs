using System.Collections.Generic;

namespace Dev2.Common.Interfaces
{
    public interface ITestModel
    {
        string TestName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        List<ITestInput> Inputs { get; set; }
        List<ITestOutput> OutPuts { get; set; }
        bool Error { get; set; }
        bool IsNewTest { get; set; }
        bool IsTestSelected { get; set; }
    }

    public interface ITestInput
    {
        string Variable { get; set; }
        string Value { get; set; }
        bool EmptyIsNull { get; set; }
    }

    public interface ITestOutput
    {
        string Variable { get; set; }
        string Value { get; set; }
    }
}