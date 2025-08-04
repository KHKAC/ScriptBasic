using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; // 이름이 같은 것들을 사용할 때 아예 지정해버려서 헷갈리지 않게 하는 방법

public class EnumScript : MonoBehaviour
{
    // Direction(enum 이름) 뒤에 : <T>를 붙여서 타입 지정 가능 <- 자주 사용 X
    enum Direction { North, East, South, West };

    void Start()
    {
        Direction myDirection = Direction.North;
        int dir = (int)myDirection;
        int len = System.Enum.GetValues(typeof(Direction)).Length;
        // System에 있는 Random 이용
        var rand1 = new System.Random();
        // myDirection = (Direction)(rand1.Next() % len);
        // UnityEngine에 있는 Random 이용
        var rand2 = Random.Range(0, len - 1);
        myDirection = (Direction)rand2;
        Debug.Log(myDirection);

        // var returnDir = ReverseDirection(myDirection);
        var returnDir = ReDirection((int)myDirection);
        Debug.Log(returnDir);

        var wrongDir = ReverseDirection((Direction)8);
        Debug.Log(wrongDir);
    }

    int ReDirection(int dir)
    {
        switch ((Direction)dir)
        {
            case Direction.North:
                dir = (int)Direction.South;
                break;
            case Direction.South:
                dir = (int)Direction.North;
                break;
            case Direction.East:
                dir = (int)Direction.West;
                break;
            case Direction.West:
                dir = (int)Direction.East;
                break;
            default :
                Debug.Log("Wrong Direction");
                break;
        }

        return dir;
    }

    Direction ReverseDirection(Direction dir)
    {
        /*
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;
        */

        switch (dir)
        {
            case Direction.North:
                dir = Direction.South;
                break;
            case Direction.South:
                dir = Direction.North;
                break;
            case Direction.East:
                dir = Direction.West;
                break;
            case Direction.West:
                dir = Direction.East;
                break;
            default :
                Debug.Log("Wrong Direction");
                break;
        }

        return dir;
    }
}
