using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Rigidbody2D PlayerRB;
    public int DeathSceneIndex;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            
            SceneManager.LoadScene(DeathSceneIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            
            SceneManager.LoadScene(DeathSceneIndex);
        }
    }
}
