using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCaseSample : MonoBehaviour
{
    enum Avengers{ IronMan, SpiderMan, Hulk};

    void Start()
    {
        Avengers avengers = Avengers.IronMan;
        // switch (avengers)
        // {
        //     case Avengers.IronMan:
        //         Debug.Log("Iron Man");
        //         break;
        //     case Avengers.SpiderMan:
        //         Debug.Log("Spider Man");
        //         break;
        //     case Avengers.Hulk:
        //         Debug.Log("Hulk");
        //         break;
        //     default:
        //         Debug.Log("Avengers");
        //         break;
        // }

        string str = avengers switch
        {
            Avengers.IronMan => "Iron Man",
            Avengers.SpiderMan => "Spider Man",
            Avengers.Hulk => "Hulk",
            _ => "Avengers"
        };
        Debug.Log(str);
    }

}
