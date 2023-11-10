using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rbody;              // Rigidbody2Dを定義
    public float speed = 7.0f;                 // 横に移動する速度
    Animator animator;
    private float jumpPower = 300;
    private bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2Dのコンポーネントを取得
        rbody = GetComponent<Rigidbody2D>();

        // animatorコンポーネントを取得
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    /*
        void jump() {
            // 上に力を加える
            rbody.AddForce(Vector2.up * 300);
        }
    */

    // Updateではキー入力を取得してFixedUpdateへ渡す
    void Update()
    {
        // spaceを押したらジャンプ関数へ
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            animator.SetTrigger("jump_trigger");
            rbody.velocity = new Vector2(rbody.velocity.x, 0);   // 垂直方向の速度をリセット
            rbody.AddForce(transform.up * jumpPower);
            canJump = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true; // 地面に着地したらトリガーをリセット
            animator.ResetTrigger("jump_trigger");
        }
    }

    void FixedUpdate()
    {
        // リジッドボディに一定の速度を入れる（横移動の速度、リジッドボディのyの速度）
        // rbody.velocity = new Vector2(speed, rbody.velocity.y);
    }

}
