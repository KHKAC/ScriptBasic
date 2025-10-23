using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    void Start()
    {
        var dict = new Dictionary<int, string>();
        dict.Add(101, "1번째");
        dict.Add(102, "2번째");
        dict.Add(103, "3번째");
        dict.Add(104, "4번째");

        foreach (var item in dict)
        {
            //Debug.Log($"{item.Key}, {item.Value}");
        }

        foreach (var key in dict.Keys)
        {
            //Debug.Log(key);
        }
        foreach (var Value in dict.Values)
        {
            //Debug.Log(Value);
        }
        Debug.Log($"{dict[101]}");
        if (dict.TryGetValue(101, out string newValue) == false);
        {
            dict.Add(101, "새로운거");
        }
        Debug.Log(dict[101]);
        dict[109] = "이건 들어간다.";
        Debug.Log(dict[109]);
    }
}
