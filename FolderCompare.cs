using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace FolderCompareWinForms
{
    public class FolderCompare
    {
        public static string FolderA = "";
        public static string FolderB = "";
        public static string FolderExport = "";
        public static bool CheckFolderA = false;
        public static bool CheckFolderB = false;
        public static bool checkExisting = false;

        public static async Task CompareAsync()
        {
            await Task.Run(() => Compare());
        }

        public static void Compare()
        {
            var form = FolderCompareWin.GetInstance();
            if (FolderA == "" || FolderB == "" || FolderExport == "")
            {
                MessageBox.Show("Please select folders and export path.");
                form.UpdateLogMessage("Please select folders and export path.");
                return;
            }
            if (FolderA == FolderB || FolderA == FolderExport || FolderB == FolderExport)
            {
                MessageBox.Show("Please select different folders.");
                form.UpdateLogMessage("Please select different folders.");
                return;
            }

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                CompareAndCopy(FolderA, FolderB, FolderExport, CheckFolderA, CheckFolderB, checkExisting);
            
                stopwatch.Stop();

                var elapsedTime = stopwatch.Elapsed;
                form.UpdateLogMessage("Comparing and copying Sucess!");
                form.UpdateLogMessage("time: " + FormatElapsedTime(elapsedTime));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                form.UpdateLogMessage("Error: \n" + ex.Message);
                return;
            }

        }

        static void CompareAndCopy(string sourceDir, string targetDir, string destDir, bool copyIfNotInSource, bool copyIfNotInTarget, bool replaceExistingFiles)
        {
            var form = FolderCompareWin.GetInstance();
            DirectoryInfo dir1 = new DirectoryInfo(sourceDir);
            DirectoryInfo dir2 = new DirectoryInfo(targetDir);

            if (!Directory.Exists(destDir))
            {
                Directory.CreateDirectory(destDir);
            }

            Parallel.ForEach(dir1.GetFiles("*", SearchOption.AllDirectories), file =>
            {
                string relativePath = file.FullName.Substring(dir1.FullName.Length + 1);
                string file2Path = Path.Combine(dir2.FullName, relativePath);

                try
                {
                    if (File.Exists(file2Path))
                    {
                        if (!FileContentsAreEqual(file.FullName, file2Path))
                        {
                            CopyFile(file2Path, destDir, relativePath, replaceExistingFiles);
                        }
                    }
                    else if (copyIfNotInTarget)
                    {
                        CopyFile(file.FullName, destDir, relativePath, replaceExistingFiles);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in process file: \n" + ex.Message);
                    form.UpdateLogMessage("Error in process file: \n" + ex.Message);
                }
            });

            if (copyIfNotInSource)
            {
                Parallel.ForEach(dir2.GetFiles("*", SearchOption.AllDirectories), file =>
                {
                    string relativePath = file.FullName.Substring(dir2.FullName.Length + 1);
                    string file1Path = Path.Combine(dir1.FullName, relativePath);

                    try
                    {
                        if (!File.Exists(file1Path))
                        {
                            CopyFile(file.FullName, destDir, relativePath, replaceExistingFiles);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in process file: \n" + ex.Message);
                        form.UpdateLogMessage("Error in process file: \n" + ex.Message);
                    }
                });
            }
        }

        private static void CopyFile(string sourceFilePath, string destDir, string relativePath, bool replaceExistingFiles)
        {
            var form = FolderCompareWin.GetInstance();
            string destFilePath = Path.Combine(destDir, relativePath);
            string destFileDir = Path.GetDirectoryName(destFilePath);

            if (!Directory.Exists(destFileDir))
            {
                Directory.CreateDirectory(destFileDir);
            }

            if (!File.Exists(destFilePath) || replaceExistingFiles)
            {
                File.Copy(sourceFilePath, destFilePath, replaceExistingFiles);
            }
            form.UpdateLogMessage("File Copy: " + relativePath);
        }

        private static bool FileContentsAreEqual(string file1Path, string file2Path)
        {
            FileInfo file1Info = new FileInfo(file1Path);
            FileInfo file2Info = new FileInfo(file2Path);

            if (file1Info.Length != file2Info.Length)
            {
                return false;
            }

            using (var md5 = MD5.Create())
            using (var file1Stream = File.OpenRead(file1Path))
            using (var file2Stream = File.OpenRead(file2Path))
            {
                byte[] file1Hash = md5.ComputeHash(file1Stream);
                byte[] file2Hash = md5.ComputeHash(file2Stream);

                return StructuralComparisons.StructuralEqualityComparer.Equals(file1Hash, file2Hash);
            }
        }

        private static string FormatElapsedTime(TimeSpan timeSpan)
        {
            // Formata o tempo decorrido em um formato mais legível
            return string.Format("{0} hours, {1} minutes, {2} seconds, {3} milliseconds",
                                 timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
        }
    }
}
