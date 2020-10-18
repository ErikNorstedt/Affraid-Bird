using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 targetPos;
    private float Xincrement = 0.04f;
    public float jumpSpeed;
    public float maxLeft;
    public float maxRight;

    public LinearTimer Linearref;
    
    public Rigidbody2D RB;
    public Collider2D CC;
    public bool lockvar;
    private float locking;
    public Animator anim;
    public GameObject effect;

    public void start()
    {

    }

    private void Update()
    {
        locking = Linearref.timeLeft;
        
        if (locking == 0)
        {
            lockvar = true;
        }
        else if (locking > 0)
        {
            lockvar = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RB.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Impulse);
                // feathers
                Instantiate(effect, transform.position, Quaternion.identity);
                anim.SetTrigger("Flap");

               
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x > maxLeft)
            {
                targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
                transform.position = targetPos;
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < maxRight)
            {
                targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
                transform.position = targetPos;
            }
        }
    }
}
