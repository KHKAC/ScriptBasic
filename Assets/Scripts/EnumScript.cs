using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

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
        var rand2 = Random.Range(0, 3);
        myDirection = (Direction)rand2;
        Debug.Log(myDirection);

        var returnDir = ReverseDirection(myDirection);
        Debug.Log(returnDir);

    }

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
