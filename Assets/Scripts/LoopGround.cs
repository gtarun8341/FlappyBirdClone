using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float width = 6f;
    private SpriteRenderer spriteRenderer;
    private Vector2 startSize;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(spriteRenderer.size.x,spriteRenderer.size.y);
    }

    void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + speed * Time.deltaTime,spriteRenderer.size.y);
        if(spriteRenderer.size.x> width){
            spriteRenderer.size = startSize;
        }
    }
}
