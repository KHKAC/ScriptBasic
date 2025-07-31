using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSample : MonoBehaviour
{
    void Start()
    {
        float a = 1f;
        float b = 2f;
        float c = a + b;
        //Debug.Log($"c = {a}, d = {b}, c + d = {a + b}");
        //Debug.LogFormat("c = {0}, d = {1}, c + d = {2}", a, b, a + b);

        string talkFormat = string.Empty;
        string talk2 = string.Empty;
        string hName = "Iron Man";
        int hAge = 55;
        talkFormat = "I am {0}. I am {1} years old.";
        talk2 = $"I am {hName}. I am {hAge} years old.";
        //Debug.LogFormat("I am {0}, I am {1} years old", hName, hAge);
        //Debug.Log($"I am {hName}, I am {hAge} years old");
        SelfIntro(talkFormat, talk2, hName, hAge);

        hName = "Super Man";
        hAge = 100;
        talk2 = $"I am {hName}. I am {hAge} years old.";
        //Debug.LogFormat("I am {0}, I am {1} years old", hName, hAge);
        //Debug.Log($"I am {hName}, I am {hAge} years old");
        SelfIntro(talkFormat, talk2, hName, hAge);

        hName = "Thor";
        hAge = 4000;
        talkFormat = "I am {0}. I am {0}.";
        talk2 = $"I am {hName}. I am {hName}";
        //Debug.LogFormat("I am {0}, I am {0}", hName, hAge);
        //Debug.Log($"I am {hName}, I am {hName}");
        SelfIntro(talkFormat, talk2, hName, hAge);
    }

    void SelfIntro(string talkFormat, string talk2, string hName, int hAge)
    {
        Debug.LogFormat(talkFormat, hName, hAge);
        Debug.Log(talk2);
    }
}
