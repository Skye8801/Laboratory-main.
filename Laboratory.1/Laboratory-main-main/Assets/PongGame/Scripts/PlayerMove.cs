using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovePongGame : MonoBehaviour
{

    [SerializeField] private float MovementSpeed;
    [SerializeField] private bool IsAI;
    [SerializeField] private GameObject ball;

    private Rigidbody2D rb;
    Vector2 playerMove;
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(IsAI)
        {
            AIControll();
        }
        else
        {
            PlayerControll();
        }
    }

    private void PlayerControll()
    {
        playerMove = new Vector2(0, Input.GetAxisRaw("Vertical"));
    }

    private void AIControll()
    {
        if(ball.transform.position.y > transform.position.y + 0.5f)
        {
            playerMove = new Vector2(0, 1);
        }
        else if(ball.transform.position.y < transform.position.y + 0.5f)
        {
            playerMove = new Vector2 (0, -1);
        }
        else
        {
            playerMove = new Vector2 (0, 0);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = playerMove * MovementSpeed;
    }

}
