using UnityEngine;
namespace Namespace1
{
    // 유니티에서 Component로 사용하려면 MonoBehaviour를 상속받아야한다.
    public class NamespaceExample
    {
        public static void DebugLog(string message)
        {
            Debug.Log($"msg = {message}");
        }
    }
}
