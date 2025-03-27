using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        Debug.Log("º®¤§¤Ç¤·ÆÄ°í¤Ó¤§¤Ê¤±");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
