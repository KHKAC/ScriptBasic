using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackQueue : MonoBehaviour
{
    void Start()
    {
        /*
        Stack<string> stack = new Stack<string>();
        stack.Push("1 번째");
        stack.Push("2 번째");
        stack.Push("3 번째");

        foreach (var item in stack)
        {
            Debug.Log(item);
        }

        Debug.Log(stack.Peek().ToString());

        stack.Pop();

        foreach (var item in stack)
        {
            Debug.Log(item);
        }
        */

        var queue = new Queue<string>();

        queue.Enqueue("1 번째");
        queue.Enqueue("2 번째");
        queue.Enqueue("3 번째");

        foreach (var item in queue)
        {
            Debug.Log(item);
        }

        Debug.Log($"Peek : {queue.Peek()}");

        queue.Dequeue();

        foreach (var item in queue)
        {
            Debug.Log(item);
        }
    }

}
