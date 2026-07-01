using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Follower : MonoBehaviour
{
    public Transform target;
    public float desiredDistance = 3f;
    public float moveSpeed = 2f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (target == null) return;

        Vector3 direction = target.position - transform.position;
        float distance = direction.magnitude;
        float score = Mathf.Abs(distance - desiredDistance);
        Debug.Log(score);

        Vector3 moveDirection = direction.normalized;

        if (distance > desiredDistance)
        {
            rb.linearVelocity = moveDirection * moveSpeed;
        }
        else
        {
            rb.linearVelocity = -moveDirection * moveSpeed;
        }
    }
}