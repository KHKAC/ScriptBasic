using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

class Marvel 
{ 
    public string Name { get; set; } 
} 

class MarvelPsychic : Marvel 
{ 
    public string HeroType { get; set; } 
} 

public class LinqDataTypeChange : MonoBehaviour
{
    void Start()
    {
        Marvel[] marvels = new Marvel[]
        {
            new MarvelPsychic {Name = "Iron Man", HeroType = "Suit Hero"},
            new MarvelPsychic {Name = "Spider Man", HeroType = "Suit Hero"},
            new MarvelPsychic {Name = "Thor", HeroType = "God"},
            new MarvelPsychic {Name = "Thanos", HeroType = "Villain"}
        };

        var query = from MarvelPsychic marvelPsychic in marvels
                    where marvelPsychic.HeroType == "Suit Hero"
                    select marvelPsychic;
        
        foreach (Marvel marvel in query)
        {
            Debug.Log(marvel.Name);
        }
    }
}
