using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float rotationSpeed = 50.0f;

    void Update()
    {
        // Qキーで視点を左に回転
        if (Input.GetKey(KeyCode.E))
        {
            // 回転軸はワールド座標のY軸
            transform.RotateAround(player.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // Eキーで視点を右に回転
        if (Input.GetKey(KeyCode.Q))
        {
            // 回転軸はワールド座標のY軸
            transform.RotateAround(player.transform.position, Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // ,キーで視点を上に回転
        if (Input.GetKey(KeyCode.Comma))
        {
            // 回転軸はカメラ自身のX軸
            transform.RotateAround(player.transform.position, transform.right, -rotationSpeed * Time.deltaTime);
        }

        // .キーで視点を下に回転
        if (Input.GetKey(KeyCode.Period))
        {
            // 回転軸はカメラ自身のX軸
            transform.RotateAround(player.transform.position, transform.right, rotationSpeed * Time.deltaTime);
        }
    }
}
