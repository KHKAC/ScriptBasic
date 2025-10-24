using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

class Avengers
{
    public string Name { get; set; }
    public string[] Weapon { get; set; }
}

public class LINQExample : MonoBehaviour
{
    List<Avengers> aList = new List<Avengers>
    {
        new Avengers{Name = "Iron Man", Weapon = new string[] { "Mk.01", "Mk.44", "Mk.85" }},
        new Avengers{Name = "Thor", Weapon = new string[] { "Mjolnir", "Storm Breaker" }},
        new Avengers{Name = "Captain America", Weapon = new string[] { "Mjolnir", "Shield" }}
    };

    void Start()
    {
        string[] avengers = { "Iron Man", "Captain America", "Thor", "Hulk", "Black Panther", "Spider Man" };

        #region linq 1
        //Order By
        IEnumerable<string> query = from hero in avengers
                                    orderby hero.Length
                                    select hero;
        // DebugLog(query);

        query = from hero in avengers
                orderby hero.Substring(0, 1) descending
                select hero;
        // DebugLog(query);

        query = from hero in avengers
                orderby hero.Length, hero.Substring(0, 1)
                select hero;
        // DebugLog(query);

        query = from hero in avengers
                orderby hero.Length, hero.Substring(0, 1) descending
                select hero;
        // DebugLog(query);
        #endregion
        #region linq 2
        // Distinct
        string[] avengers1 = { "Iron Man", "Iron Man", "Captain America", "Thor" };
        query = from hero in avengers1.Distinct()
                select hero;
        // DebugLog(query);

        // Except
        string[] avengers21 = { "Iron Man", "Captain America", "Thor" };
        string[] avengers22 = { "Iron Man", "Hulk", "Captain America" };
        query = from hero in avengers21.Except(avengers22)
                select hero;
        // DebugLog(query);

        // Intersect
        query = from hero in avengers21.Intersect(avengers22)
                select hero;
        // DebugLog(query);

        query = from hero in avengers21.Union(avengers22)
                select hero;
        // DebugLog(query);
        #endregion
        #region where
        query = from hero in avengers
                where hero.Length > 4
                select hero;
        // DebugLog(query);
        #endregion
        #region 수량자
        // All
        query = from hero in aList
                where hero.Weapon.All(item => item.Length == 5)
                select hero.Name;
        DebugLog(query);

        // Any
        query = from hero in aList
                where hero.Weapon.Any(item => item.StartsWith("M"))
                select hero.Name;
        DebugLog(query);

        // Contains
        query = from hero in aList
                where hero.Weapon.Contains("Mjolnir")
                select hero.Name;
        DebugLog(query);
        #endregion

    }

    void DebugLog(IEnumerable<string> query)
    {
        Debug.Log("----------Start----------");
        foreach (var item in query)
        {
            Debug.Log(item);
        }
    }

}
