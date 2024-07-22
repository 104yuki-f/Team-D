using UnityEngine;

public class Walk : MonoBehaviour
{
    private Animator animator;
    private Transform playerCamera; // カメラのTransformを参照するための変数
    float walkSpeed = 5.0f;
    float runSpeed = 10.0f;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        playerCamera = Camera.main.transform; // メインカメラのTransformを取得
    }

    // Update is called once per frame
    void Update()
    {
        bool is_walking = false;
        bool is_running = false;
        float speed = walkSpeed;

        // Shiftキーが押されているかを確認
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            is_running = true;
            speed = runSpeed;
        }

        // キャラクターの移動処理
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
            is_walking = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
            is_walking = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * transform.right * Time.deltaTime;
            is_walking = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
            is_walking = true;
        }

        // 回転処理
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(0, -0.3f, 0);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0, 0.3f, 0);
        }

        // アニメーションの更新
        animator.SetBool("is_walking", is_walking);
        animator.SetBool("is_running", is_running);
    }
}
