using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        #region DriveInfo
        //drives
        //DriveInfo[] drives = DriveInfo.GetDrives();
        //foreach (DriveInfo drive in drives)
        //{
        //    Console.WriteLine(drive.Name);
        //}


        #endregion

        #region directory operations
        //var parentFolder = "C:/Users/Admino/OneDrive/Desktop/";
        //var newFolder = "newFolder";
        //string path = Path.Combine(parentFolder, newFolder);
        //Main methods : CreateDirectory, GetCurrentDirectory, GetFiles, Delete
        //DirectoryInfo directoryInfo = new DirectoryInfo(path);
        //Console.WriteLine(Directory.GetCurrentDirectory());  
        //if (!directoryInfo.Exists)
        //{
        //    directoryInfo.Create();
        //}


        //FileInfo[] fileInfos = directoryInfo.GetFiles() ;
        //foreach (var file_ in fileInfos)
        //{



        //}
        #endregion

        #region file operations
        // Main actions : Copy, Create, Delete, Move         
        // FileInfo
        //var currentFolder = "C:/Users/Admino/OneDrive/Desktop/";
        //var fileName = "yeniTxt.txt";
        //var destFolder = @"C:\\Users\\Admino\\OneDrive\\Desktop\\newFolder";
        ////
        //var fullDestFolder = Path.Combine(destFolder, fileName);
        //var fullCurrentFolder = Path.Combine(currentFolder, fileName);

        //FileInfo fileInfo = new FileInfo(fullCurrentFolder);
        //fileInfo.CopyTo(fullDestFolder);
        //fileInfo.MoveTo(fullDestFolder);
        //fileInfo.Delete();



        //File.Move(@"C:\Users\Admino\OneDrive\Desktop\Yeni Metin Belgesi.txt", @"C:\Users\Admino\OneDrive\Desktop\lastt\Yeni Metin Belgesi.txt");
        #endregion

        #region path
        // Main Methods : GetFileName(), GetDirectoryName(), GetFileNameWithoutExtension(), GetExtension(), GetFullPath("file"), Exists("folder")

        //Path.Combine();
        //var isTrue = Path.Exists(@"C:\\Users\\Admino\\OneDrive\\Desktop\\newFolder\\yeniTxt.txt");
        
        //Console.WriteLine(isTrue);
        #endregion
    }
}