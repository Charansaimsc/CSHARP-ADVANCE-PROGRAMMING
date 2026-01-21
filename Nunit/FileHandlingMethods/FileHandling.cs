/*Create a class FileProcessor with the following methods:
● WriteToFile(string filename, string content): Writes content to a file.
● ReadFromFile(string filename): Reads content from a file.
Write unit tests to check if:
The content is written and read correctly.
The file exists after writing.
Handling of IOException when the file does not exist*/

using System.IO;

public class FileProcessor
{
    public void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    public string ReadFromFile(string filename)
    {
        return File.ReadAllText(filename);
    }
}
