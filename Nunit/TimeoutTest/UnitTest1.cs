using NUnit.Framework;

[TestFixture]
public class TaskRunnerTests
{
    private TaskRunner runner;

    [SetUp]
    public void Setup()
    {
        runner = new TaskRunner();
    }

    [Test]
    [Timeout(2000)] 
    public void LongRunningTask_ShouldFail_IfExceedsTimeout()
    {
        string result = runner.LongRunningTask();

        Assert.AreEqual("Completed", result);
    }
}
