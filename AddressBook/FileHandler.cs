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

        public List<string> ReadAllRowsFromFile(string searchCritera)
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

                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        if (values[i+1].Contains(searchCritera))
                        {
                            matches.Add(row);
                            break;
                        }
                    }

                    //break;
                }
            }

            return matches;
        }

        public void UpdateRow(User user)
        {
            string filePath = $"{_folderPath}\\{_fileName}";
            string[] rows = File.ReadAllLines(filePath);
            string newText = $"{user.UserID.ToString()},{user.Name},{user.StreetAddress},{user.PostalCode},{user.County},{user.PhoneNumber},{user.Email}";
            int rowToUpdate = 0;

            foreach (string row in rows)
            {
                string[] values = row.Split(',');

                if (values[0].Contains(user.UserID.ToString()))
                {
                    break;
                }
                else
                {
                    rowToUpdate++;
                }
            }

            rows[rowToUpdate] = newText;

            File.WriteAllLines(filePath, rows);

            //using (StreamReader sr = new StreamReader())
            //{
            //    string row;

            //    while ((row = sr.ReadLine()) != null)
            //    {
            //        string[] values = row.Split(',');
            //        if (values[0] == user.UserID.ToString())
            //        {

            //        }
            //    }
            //}
        }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}