public class StringTooShortException : Exception
{
    public StringTooShortException(string message) : base(message)
    {
    }
}
class FileEdit
{
    public FileEdit(string fileName)
    {
        this.writer = new StreamWriter(fileName);
    }
    private StreamWriter writer;
    public void Close()
    {
        writer.Close();
    }
    public void Input(string inputString)
    {
        if (inputString.Length < 3)
        {
            throw new StringTooShortException("Строка слишком мала");
        }
        else
        {
            this.writer.Write(inputString[2]);
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        string fileName = Console.ReadLine();
        string inputString = Console.ReadLine();
        FileEdit FileEd = new FileEdit(fileName);
        try
        {
            FileEd.Input(inputString);
        }
        catch
        {
            Console.WriteLine("Строка слишком мала");
        }
        finally
        {
            FileEd.Close();
        }
    }
}
