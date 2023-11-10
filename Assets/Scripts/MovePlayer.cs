using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed = 7.0f; //speedの変数宣言
    private int jumpPower = 600;
    private Rigidbody2D rb;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            PlayerJump(jumpPower);
        }
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    public void PlayerJump(int jumpPower)
    {
        animator.SetTrigger("jump-trigger");
        rb.AddForce(transform.up * jumpPower);
    }

    public void GameReset()
    {

    }
}
