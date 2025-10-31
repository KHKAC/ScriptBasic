using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class JsonData
{
    public string name;
    public int age;
    public float height;
    public bool man;
    public string description;
    public string[] tools;
}
public class JsonExample : MonoBehaviour
{
    const string FILE_PATH = @"C:\Save\JsonExample.json";
    void Start()
    {
        // JsonData[] jsonData = new JsonData[2];
        // jsonData[0] = new JsonData();
        // jsonData[1] = new JsonData();
        int len = 2;
        JsonData[] jsonData = new JsonData[len];
        for (int i = 0; i < len; i++)
        {
            jsonData[i] = new JsonData();
        }
        
        jsonData[0].name = "Coder Zero";
        jsonData[0].age = 48;
        jsonData[0].height = 172.5f;
        jsonData[0].man = true;
        jsonData[0].description = null;
        jsonData[0].tools = new string[3];
        jsonData[0].tools[0] = "Unity";
        jsonData[0].tools[0] = "Visual Studio";
        jsonData[0].tools[0] = "Photoshop";

        jsonData[1].name = "Coder Zero";
        jsonData[1].age = 48;
        jsonData[1].height = 172.5f;
        jsonData[1].man = true;
        jsonData[1].description = null;
        jsonData[1].tools = new string[2];
        jsonData[1].tools[0] = "3D Max";
        jsonData[1].tools[1] = "Photoshop";

        // Serialize
        string toJsonZero = JsonUtility.ToJson(jsonData[0]);
        Debug.Log(toJsonZero);
        string toJsonOne = JsonUtility.ToJson(jsonData[1]);
        Debug.Log(toJsonOne);

        // Deserialize
        JsonData fromJson = JsonUtility.FromJson<JsonData>(toJsonZero);
        Debug.Log(fromJson.name);

        // Save File
        File.WriteAllText(FILE_PATH, toJsonOne);
        
        // Load File
        string readJson = File.ReadAllText(FILE_PATH);
        Debug.Log(readJson);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
