using UnityEngine;

public class Brick : MonoBehaviour
{
    private BrickGenerator generator;

	void Start()
    {
        generator = FindFirstObjectByType<BrickGenerator>();
    }

	void Update()
    {
        
    }
	
	void OnDestroy()
    {
        generator.BrickBreaked();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
