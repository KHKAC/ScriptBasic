using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    void Start()
    {
        string msg1 = "message";
        string msg2 = null;
        string msg3 = "";
        string msg4 = string.Empty;
        string name = "Coder Zero";
        //name[6] = 'B';
        string str = name.Replace('Z', 'B');
        //Debug.Log(name + ", " + str);
        char[] charArrays = name.ToCharArray();
        //Debug.Log(charArrays[1]);
        char[] cArray = { 'A', 'B', 'c', ' ', 'D' };
        string s = new string(cArray);
        //Debug.Log(s);

        var sb = new StringBuilder();
        sb.Append(name);
        sb.Clear();
        sb.Append("Coder One");
        sb.Append(" Two");
        Debug.Log(sb.ToString());

        sb.Insert(6, "C");
        Debug.Log(sb);
        sb.Remove(6, 3);
        Debug.Log(sb);
        sb.Replace('C', 'I');
        Debug.Log(sb);
        sb.Replace('o', 'O', 0, 11);
        Debug.Log(sb);
    }

    void Update()
    {
        
    }
}
