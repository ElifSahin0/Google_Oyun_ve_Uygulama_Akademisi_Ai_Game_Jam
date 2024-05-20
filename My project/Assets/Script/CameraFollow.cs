using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Kameran�n takip edece�i hedef (karakter)

    void Update()
    {
        if (target != null)
        {
            // Kameray� hedefin pozisyonuna ta��
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
    }
}
