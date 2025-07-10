using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    [SerializeField]float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("이 커피는 너무 뜨거워서 철도 녹이겠다!");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("이 커피는 너무 차가워서 액화 질소인줄 알겠다!");
        }
        else
        {
            print("이제야 좀 먹을만하네!");
        }
    }
}
