using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f; // Zýplama gücümüz (Inspector'dan deðiþtirilebilir)
    private Rigidbody2D rb;
    private bool isGrounded = true; // Yerde miyiz? (Havada sonsuz zýplamayý önlemek için)

    void Start()
    {
        // Oyun baþladýðýnda Karakterin Rigidbody2D bileþenini bul ve 'rb' deðiþkenine ata
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Eðer Boþluk (Space) tuþuna basýlýrsa VE karakter yerdeyse
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Yukarý doðru anlýk bir kuvvet (Impulse) uygula
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false; // Artýk havadayýz
        }
    }

    // Karakterin çarpýþma algýlayýcýsý (Collider) baþka bir þeye deðdiðinde çalýþýr
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Eðer çarptýðýmýz nesnenin adý "Zemin" ise
        if (collision.gameObject.name == "Zemin")
        {
            isGrounded = true; // Tekrar yere deðdik, zýplamaya izin ver
        }
    }
}