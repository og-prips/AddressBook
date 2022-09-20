using Microsoft.VisualBasic.ApplicationServices;

namespace AddressBook
{
    public class FileHandler
    {
        // Get path-string for local documents folder
        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AddressBook";
        private string _fileName = "Users.txt";

        // Checks for existing directory specified in this class, if not exists -> create
        public FileHandler()
        {
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);

                if (!File.Exists($"{_folderPath}\\{_fileName}"))
                {
                    FileStream userFile = File.Create($"{_folderPath}\\{_fileName}");
                    userFile.Close();
                }
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

        /// <summary>
        /// Return all rows from file to a List
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllRowsFromFile()
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

        /// <summary>
        /// Return all rows where searchcritera matches at the specified index
        /// </summary>
        /// <param name="searchCritera">Text to search for</param>
        /// <param name="index">The index of the value to search for in file</param>
        /// <returns></returns>
        public List<string> GetRowFromSearchCritera(string searchCritera, int index)
        {
            string filePath = $"{_folderPath}\\{_fileName}";
            string row;
            List<string> matches = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((row = sr.ReadLine()) != null)
                {
                    row.ToLower();
                    string[] values = row.ToLower().Split(',');

                    if (values[index].Contains(searchCritera))
                    {
                        matches.Add(row);
                    }
                }
            }

            return matches;
        }

        /// <summary>
        /// Updates the row where specified UserID matches with a string of new text
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="newText"></param>
        public void UpdateRow(Guid userID, string newText)
        {
            List<string> updatedRows = new List<string>();
            string filePath = $"{_folderPath}\\{_fileName}";
            string[] rows = File.ReadAllLines(filePath);
            int rowToUpdate = 0;

            foreach (string row in rows)
            {
                string[] values = row.Split(',');

                if (values[0].Contains(userID.ToString()))
                {
                    break;
                }
                else
                {
                    rowToUpdate++;
                }
            }

            rows[rowToUpdate] = newText;

            foreach (string row in rows)
            {
                if (!string.IsNullOrEmpty(row))
                {
                    updatedRows.Add(row);
                }
            }

            File.WriteAllLines(filePath, updatedRows);
        }
    }
}