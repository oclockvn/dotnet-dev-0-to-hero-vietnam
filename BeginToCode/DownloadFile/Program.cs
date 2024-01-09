using System.Net;

namespace DownloadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileUrl = "https://raw.githubusercontent.com/oclockvn/yellow-course/master/YellowCourse.sln";
            string downloadFolderPath = $"download/files/{DateTime.Now.Year}/{DateTime.Now.Month:D2}";
            string filename = Path.GetFileName(fileUrl);

            if (!Directory.Exists(downloadFolderPath))
            {
                Directory.CreateDirectory(downloadFolderPath);
            }

            // Combine the folder path and filename to get the full destination path
            string destinationPath = Path.Combine(downloadFolderPath, filename);

            // Download the file using WebClient and save it to the specified destination path
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    byte[] fileBytes = webClient.DownloadData(fileUrl);

                    // Save the byte array to the specified destination path
                    File.WriteAllBytes(destinationPath, fileBytes);

                    Console.WriteLine($"File downloaded successfully to: {destinationPath}");
                }
                catch (WebException ex)
                {
                    Console.WriteLine($"Error downloading file: {ex.Message}");
                }
            }
        }
    }
}
