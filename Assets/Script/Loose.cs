using UnityEngine;

public class BirdController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {

            Time.timeScale = 0f;
            Debug.Log("Perdu !");
        }
    }
}
