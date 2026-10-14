using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject engelPrefab; // Üreteceðimiz engelin þablonu
    public float spawnRate = 2f;   // Kaç saniyede bir engel çýkacak?
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime; // Zamaný say

        // Eðer geçen zaman 'spawnRate' deðerini (2 saniye) geçerse
        if (timer >= spawnRate)
        {
            // Spawner'ýn olduðu yerde yeni bir engel yarat
            Instantiate(engelPrefab, transform.position, Quaternion.identity);
            timer = 0f; // Zamanlayýcýyý sýfýrla
        }
    }
}