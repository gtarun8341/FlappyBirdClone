using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            Score.instance.updateScore();
        }
    }
}
