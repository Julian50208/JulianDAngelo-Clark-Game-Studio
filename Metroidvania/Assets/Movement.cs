using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    public int jumpamount;
    [SerializeField] private int maxjumps;
    [SerializeField] private float speed;
    [SerializeField] private float jumppower;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D)) { body.velocity = new Vector2(speed, body.velocity.y); }
        if (Input.GetKey(KeyCode.A)) { body.velocity = new Vector2((speed * -1), body.velocity.y); }
        if ((Input.GetKeyUp(KeyCode.A)) || Input.GetKeyUp(KeyCode.D)) { body.velocity = new Vector2(0, body.velocity.y); }
       // horizontal movement
        if (Input.GetKeyDown(KeyCode.Space) && jumpamount != 0){ body.velocity = new Vector3(body.velocity.x, jumppower); jumpamount -= 1;  }// Jump script.
        if (jumpamount > maxjumps) { jumpamount = maxjumps; };

        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor") { jumpamount = maxjumps; }
    }
}
