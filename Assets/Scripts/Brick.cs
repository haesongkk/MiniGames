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
        Debug.Log("�����Ǥ��İ�Ӥ��ʤ�");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
