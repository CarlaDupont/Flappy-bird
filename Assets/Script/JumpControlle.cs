using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpController : MonoBehaviour
{
    public float jumpForce = 10f; // Force de saut du personnage
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Détecte si le joueur appuie sur la barre d'espace
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Applique une force verticale au Rigidbody2D pour faire sauter le personnage
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}