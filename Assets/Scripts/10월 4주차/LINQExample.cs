using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

class Avengers
{
        public string Name { get; set; }
        public string[] Weapon { get; set; }
        public int CategoryID { get; set; }
}

class Category
{
        public int ID { get; set; }
        public string CategoryName { get; set; }
}

public class LINQExample : MonoBehaviour
{
List<Avengers> aList = new List<Avengers>
{
new Avengers{Name = "Iron Man", Weapon = new string[] { "Mk.01", "Mk.44", "Mk.85" }},
new Avengers{Name = "Thor", Weapon = new string[] { "Mjolnir", "Storm Breaker" }},
new Avengers{Name = "Captain America", Weapon = new string[] { "Mjolnir", "Shield" }}
};

List<Avengers> aList2 = new List<Avengers>
{
new Avengers {Name = "Iron Man", CategoryID = 0},
new Avengers {Name = "Captain America", CategoryID = 0},
new Avengers {Name = "Thor", CategoryID = 1},
new Avengers {Name = "Loki", CategoryID = 1},
};

List<Category> categories = new List<Category>
{
new Category {ID = 0, CategoryName = "Human"},
new Category {ID = 1, CategoryName = "Asgardian"}
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
                // DebugLog(query);

                // Any
                query = from hero in aList
                        where hero.Weapon.Any(item => item.StartsWith("M"))
                        select hero.Name;
                // DebugLog(query);

                // Contains
                query = from hero in aList
                        where hero.Weapon.Contains("Mjolnir")
                        select hero.Name;
                // DebugLog(query);
                #endregion
                #region Selection
                query = from hero in avengers
                        select hero.Substring(0, 1);
                // DebugLog(query);
                #endregion
                #region Join
                var avengerGroups = from category in categories
                                    join avenger in aList2 on category.ID equals avenger.CategoryID
                                    into avengerGroup
                                    select avengerGroup;
                foreach (var avengerGroup in avengerGroups)
                {
                        Debug.Log("Group");
                        foreach (Avengers avenger in avengerGroup)
                        {
                                Debug.Log($"{avenger.Name,20}");
                        }
                }
                #endregion

                List<int> numbers = new List<int> { 3, 2, 4, 66, 13 };
                IEnumerable<IGrouping<int, int>> q2 = from number in numbers
                                                      group number by number % 2;
                foreach (var group in q2)
                {
                        Debug.Log(group.Key == 0 ? "Even:" : "Odd:");
                        foreach (int i in group)
                        {
                                Debug.Log(i);
                        }
                }
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
