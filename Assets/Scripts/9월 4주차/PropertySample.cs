using UnityEngine;

public class PropertySample : MonoBehaviour
{
    [SerializeField] ClassSample cs = null;
    void Start()
    {
        if (cs != null)
        {
            Debug.Log($"Property Sample: {cs.Property}");
            cs.Property = 33;
            //cs.SetProperty(333);

            //cs.Pty2 = 3223;
            Debug.Log($"PS : {cs.Pty2}");
            cs[0] = 34;
            Debug.Log($"Indexer = {cs[0]}");
        }
    }
}
