namespace TextParser
{
    internal class FileController
    {
        public static IEnumerable<string> GetAllLinesFromFile(string path)
        {            
            return File.ReadLines(path);
        }

        public static void WriteLinesToFile(string path, IEnumerable<string> lines)
        {
            File.WriteAllLines(path, lines);
        }

        public static bool FileExist(string path)
        {
            return File.Exists(path);
        }

        public static List<string> GetFiles(string path)
        {
            return Directory.GetFiles(path)
                            .Select(fileName => Path.GetFileName(fileName))
                            .ToList();
        }
    }
}
