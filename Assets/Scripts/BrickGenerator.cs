using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
    public GameObject brickPrefab;
    public Vector3 startPos = new Vector3(0, 0, 0);
    public Vector2 gridSize = new Vector2(3, 3);
    public Vector2 brickSize = new Vector2(1f, 0.5f);
    public Vector2 spacing = new Vector2(0.2f, 0.2f);
    public int brickCount = 0;
	
    private Ball ball;
	
	void Start()
    {
        GenerateBricks();
        ball = FindFirstObjectByType<Ball>();
    }
	
	void Update()
    {
    }
	
	void OnDrawGimzmoSelected()
    {
        Gizmos.color = Color.red;
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                Vector3 position = startPos + new Vector3(
                    x * (brickSize.x + spacing.x),
                    y * (brickSize.y + spacing.y), 0);
                Gizmos.DrawWireCube(position, brickSize);
            }
        }
    }
	
    void GenerateBricks()
    {
        for(int x=0;x<gridSize.x;x++) 
        {
            for(int y=0;y<gridSize.y;y++)
            {
                Vector3 position = startPos+ new Vector3(
                    x * (brickSize.x + spacing.x),
                    y * (brickSize.y + spacing.y), 0);
                GameObject brick = Instantiate(brickPrefab,position, Quaternion.identity);
                brick.transform.localScale = brickSize;
            }

        }
        brickCount = (int)(gridSize.x * gridSize.y);
    }

    public void BrickBreaked()
    {
        if(--brickCount==0) NextPhase();
    }

    void NextPhase()
    {
        ball.SpeedUp();
        gridSize.y++;
        startPos.y -= brickSize.y + spacing.y;
        GenerateBricks();
    }
}
