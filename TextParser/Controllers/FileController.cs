namespace TextParser
{
    internal class FileController
    {
        public IEnumerable<string> GetAllLinesFromFile(string path)
        {            
            return File.ReadLines(path);
        }

        public void WriteLinesToFile(string path, IEnumerable<string> lines)
        {
            File.WriteAllLines(path, lines);
        }
    }
}
