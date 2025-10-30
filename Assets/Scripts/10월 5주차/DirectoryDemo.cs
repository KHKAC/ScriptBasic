using UnityEngine;
using System;
using System.IO;
using System.Linq;

public class DirectoryDemo : MonoBehaviour
{
    public string m_SourceDirectory = @"C:\Current";
    public string archiveDirectory = @"C:\Archive";
    
    void Start()
    {
        /*
        try
        {
            var txtFiles = Directory.EnumerateFiles(m_SourceDirectory, "*.txt");

            foreach (string currentFile in txtFiles)
            {
                string fileName = currentFile.Substring(m_SourceDirectory.Length + 1);
                Directory.Move(currentFile, Path.Combine(m_ArchiveDirectory, fileName));
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
        */
        var files = from retrievedFile in Directory.EnumerateFiles(archiveDirectory, "*.txt", SearchOption.AllDirectories)
                    from line in File.ReadLines(retrievedFile)
                    where line.Contains("Example")
                    select new
                    {
                        File = retrievedFile,
                        Line = line
                    };

        foreach (var f in files)
        {
            Debug.Log($"{f.File} contains {f.Line}");
        }
        Debug.Log($"{files.Count()} lines found");
    }
}