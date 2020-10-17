using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Keybinds : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float Xincrement;
    public float jumpSpeed;
    public float speed;

    public Rigidbody2D RB;

    public void start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
            transform.position = targetPos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
            transform.position = targetPos;
        }
    }
}
