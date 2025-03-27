using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        Debug.Log("Square Start");
    }

    void Update()
    {
        // 가로축의 이동값을 받는다 (좌우방향키)
        float input = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * input * Time.deltaTime * speed);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -6.5f, 6.5f), transform.position.y, 0);
    }
}
