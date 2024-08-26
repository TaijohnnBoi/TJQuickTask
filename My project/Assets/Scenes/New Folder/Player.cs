using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Text WINTEXT;
   

    public GameObject player;

    Vector2 velocity;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector2.zero;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");
        Debug.Log(velocity);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Win");
        {
            WINTEXT.gameObject.SetActive(true);
        }
    }
}
