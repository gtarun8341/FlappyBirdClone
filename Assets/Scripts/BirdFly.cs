using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
public class BirdFly : MonoBehaviour
{
    [SerializeField] float velocity = 1.5f;
    [SerializeField] float rotationSpeed = 1f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame){
            rb.linearVelocity = Vector2.up * velocity;
        }
    }
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.linearVelocity.y * rotationSpeed);
    }
        void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
