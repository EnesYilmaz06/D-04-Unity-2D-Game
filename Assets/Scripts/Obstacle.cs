using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f; // Engelin sola kayma hýzý

    void Update()
    {
        // Engeli her saniye 'speed' hýzýnda sola kaydýr
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Engel ekranýn solundan tamamen çýkýnca kendini yok et (Oyun kasmasýn diye)
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}