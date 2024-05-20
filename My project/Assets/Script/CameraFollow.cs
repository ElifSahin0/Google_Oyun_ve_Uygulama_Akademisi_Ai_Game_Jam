using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Kameranýn takip edeceði hedef (karakter)

    void Update()
    {
        if (target != null)
        {
            // Kamerayý hedefin pozisyonuna taþý
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
    }
}
