using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileInfoDemo : MonoBehaviour
{
    public string filePath = Path.GetTempFileName();
    private FileInfo fileInfori1;

    void Start()
    {
        fileInfori1 = new FileInfo(filePath);

        using (StreamWriter sw = fileInfori1.CreateText())
        {
            sw.WriteLine("Hello");
            sw.WriteLine("And");
            sw.WriteLine("Welcome");
        }
               
        using (StreamReader sr = fileInfori1.OpenText())
        {
            var s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Debug.Log(s);
            }
        }

        try
        {
            string filePath2 = Path.GetTempFileName();
            var fileInfo2 = new FileInfo(filePath2);
            fileInfo2.Delete();                        
            fileInfori1.CopyTo(filePath2);
            Debug.Log($"{filePath} was copied to {filePath2}.");
            fileInfo2.Delete();
            Debug.Log($"{filePath2} was successfully deleted.");
        }
        catch (Exception e)
        {
            Debug.Log($"The process failed: {e.ToString()}");
        }
    }
}
