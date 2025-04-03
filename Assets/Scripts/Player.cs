using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
	
    void Start()
    {
    }

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * input * Time.deltaTime * speed);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -6.5f, 6.5f), transform.position.y, 0);
    }
}
