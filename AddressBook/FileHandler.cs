namespace AddressBook
{
    public class FileHandler
    {
        // Get path-string for local documents folder
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AddressBook";
        private string _fileName = "Users.txt";

        public FileHandler()
        {
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        /// <summary>
        /// Save string of text to file specified in this class
        /// </summary>
        /// <param name="text">string of text to be saved</param>
        public void SaveToFile(string text)
        {
            string filePath = $"{_folderPath}\\{_fileName}";

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.Write(text);
            }
        }

        /// <summary>
        /// Save array of text to a file specified in this class with a separator between each string
        /// </summary>
        /// <param name="text"></param>
        /// <param name="separator"></param>
        public void SaveToFile(string[] text, char separator)
        {
            string lastString = text.Last();

            foreach (string s in text)
            {
                if (s.Equals(lastString))
                {
                    SaveToFile($"{s}\n");
                } 
                else
                {
                    SaveToFile($"{s}{separator}");
                }
            }
        }

        public List<string> ReadAllRowsFromFile()
        {
            string filePath = $"{_folderPath}\\{_fileName}";
            string row;
            List<string> rows = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((row = sr.ReadLine()) != null)
                {
                    rows.Add(row);
                }
            }

            return rows;
        }
    }
}