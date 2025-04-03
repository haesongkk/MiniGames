using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
	
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }
	
	void Update()
    {
    }
	
	void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone"))
        {
            Debug.LogWarning("공이 떨어졌습니다.");
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }
	
    void LaunchBall()
    {
        float rad = Random.Range(45f, 135f) * Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
        rb.linearVelocity = direction * speed;
    }

    public void SpeedUp()
    {
        speed *= 1.5f;
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
        Debug.Log("스피드업! 현재속도 : " + speed);
    }

    
}
