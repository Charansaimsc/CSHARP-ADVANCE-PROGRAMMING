using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor processor;
    private string testFile;

    [SetUp]
    public void Setup()
    {
        processor = new FileProcessor();
        testFile = "testfile.txt";
    }

    [TearDown]
    public void Cleanup()
    {
        if (File.Exists(testFile))
        {
            File.Delete(testFile);
        }
    }

    [Test]
    public void WriteAndRead_File_Content_ShouldMatch()
    {
        string content = "Hello NUnit";

        processor.WriteToFile(testFile, content);
        string result = processor.ReadFromFile(testFile);

        Assert.AreEqual(content, result);
    }


    [Test]
    public void WriteToFile_FileShouldExist()
    {
        processor.WriteToFile(testFile, "File exists test");

        Assert.IsTrue(File.Exists(testFile));
    }


    [Test]
    public void ReadFromFile_FileDoesNotExist_ShouldThrowException()
    {
        Assert.Throws<FileNotFoundException>(() =>
        {
            processor.ReadFromFile("missingfile.txt");
        });
    }
}
