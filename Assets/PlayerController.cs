using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("PlayerController 所在物体没有 Rigidbody！");
        }
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A/D 或 左/右箭头
        float v = Input.GetAxis("Vertical");   // W/S 或 上/下箭头

        
        rb.linearVelocity = new Vector3(h * moveSpeed, rb.linearVelocity.y, v * moveSpeed);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}