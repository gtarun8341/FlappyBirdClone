using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.65f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left *speed * Time.deltaTime;
    }
}
