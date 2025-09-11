using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatSample : MonoBehaviour
{
    void Start()
    {
        // int i를 밖에 잡을 수 있지만 단순 반복문에서는 오히려 방해가 될 가능성이 있으므로 반복문 안에 만든다.
        // for (int i = 0; i < 5; i++)
        // {
        //     for (int j = 0; j < 4; j++)
        //     {
        //         Debug.Log($"i = {i}, j = {j}");
        //     }
        // }
        // 위의 이중 for문 과는 다른 결과 값이 나옴
        // for (int i = 0, j = 0; i < 5 && j < 4; i++, j++)
        // {
        //     Debug.Log($"i = {i}, j = {j}");
        // }
        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log(i.ToString());
        // }

        //int[] numbers = new int[] { 1, 2, 34, 5 };
        int[,] numbers = new int[,] { { 1, 2 }, { 34, 56 }, { 7, 89 } };
        // for (int i = 0; i < numbers.GetLength(0); i++)
        // {
        //     for (int j = 0; j < numbers.GetLength(1); j++)
        //     {
        //         Debug.Log($"{numbers[i, j]}");
        //     }
        // }
        // 가독성 및 코드의 복잡성을 따져봤을 때 다중차원 배열을 반복문으로 돌릴때 foreach를 사용하는 것이 좋다.
        foreach (int number in numbers)
        {
            // Debug.Log($"{number}");
        }

        int n = 6;
        while (n < 5)
        {
            Debug.Log($"while : {n}");
            n++;
        }
        n = 6;
        do
        {
            Debug.Log($"do while : {n}");
            n++;
        } while (n < 5);
    }
}
