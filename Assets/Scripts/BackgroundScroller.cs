using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 3f;
    public float startX = 20f;
    public float endX = -20f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= endX)
        {
            // Sýnýrý ne kadar aþtýðýný (taþtýðýný) hesapla
            float tasmaMiktari = transform.position.x - endX;

            // Iþýnlanacaðý noktaya bu taþma payýný ekleyerek boþluk kalmasýný engelle
            Vector3 resetPos = new Vector3(startX + tasmaMiktari, transform.position.y, transform.position.z);
            transform.position = resetPos;
        }
    }
}