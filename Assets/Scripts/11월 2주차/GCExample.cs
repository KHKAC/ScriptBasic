using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GCExample : MonoBehaviour
{
    public TMP_Text scoreBoard;
    int score;
    int oldScore;
    void ConcatExample(int[] intArray)
    {
        string line = intArray[0].ToString();
        for (int i = 1; i < intArray.Length; i++)
        {
            line += "," + intArray[i].ToString();
        }
    }

    void Update()
    {
        // if로 조건을 만들어서 조건에 맞을 때만 업데이트
        if (score != oldScore)
        {
            string scoreText = "Score" + score.ToString();
            scoreBoard.text = scoreText;
            oldScore = score;
        }
    }
    float[] RandomList(int numEl)
    {
        var result = new float[numEl];
        for (int i = 0; i < numEl; i++)
        {
            result[i] = Random.value;
        }
        return result;
    }
    void RandomList(float[] arrayTofill)
    {
        for(int i = 0; i < arrayTofill.Length; i++)
        {
            arrayTofill[i] = Random.value;
        }
    }
}
