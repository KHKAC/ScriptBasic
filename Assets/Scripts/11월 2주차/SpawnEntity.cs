using UnityEngine;

[CreateAssetMenu(fileName = "Entity", menuName = "Scriptable Object/Entity", order = 1)]
public class SpawnEntity : ScriptableObject
{
    public string name;
    public Vector3[] positions;
}
