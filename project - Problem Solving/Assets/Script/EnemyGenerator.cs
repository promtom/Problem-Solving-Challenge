using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //https://docs.unity3d.com/ScriptReference/Vector2.html
    [Header("Area")]
    public Vector2 mapSize;
    public Vector2 offsetArea;

    [Header("Enemy")]
    public List<Sprite> enemyTypes = new List<Sprite>();
    public GameObject enemyPrefab;
    public int enemyCount;
    public Vector2 offsetEnemy;

    private List<GameObject> spawnedEnemy;
    private List<Vector2> spawnPoint = new List<Vector2>();

    // Start is called before the first frame update
    void Start()
    {
        //sizeEnemy = enemyPrefab.GetComponent<SpriteRenderer>().size;
        //mengambil ukuran dari prefab
        spawnedEnemy = new List<GameObject>(0);
        spawnPoint.Add(new Vector2(0, 0)); //add to list
        for (int i = 0; i < enemyCount; i++)
        {
            Tracing(i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void EnemyOffset()
    {
        //total size = ukuran ditambah jarak dikali ukuran area - 1
        //Vector2 totalSize = (sizeEnemy + offsetEnemy) * (size - Vector2.one);
    }

    private void Tracing(int i)
    {
        for (int j = 0; j <= i;)
        {
            float posX = Random.Range((-mapSize.x / 2) + offsetArea.x, (mapSize.x / 2) - offsetArea.x);
            float posY = Random.Range((-mapSize.y / 2) + offsetArea.y, (mapSize.y / 2) - offsetArea.y);
            
            if (spawnPoint[j].x != posX && spawnPoint[j].y != posY)
            {
                TranceEnemy(posX, posY);
                j++; break;
            }
        }
    }

    private void TranceEnemy(float posX, float posY)
    {
        GameObject newEnemy = Instantiate
        (
            enemyPrefab,
            transform
        );
        newEnemy.transform.position = new Vector2(posX, posY);
        spawnedEnemy.Add(newEnemy); //add to list
        spawnPoint.Add(new Vector2(posX, posY)); //add to list
    }

    public void ReTrance(float oldX, float oldY)
    {
        while (true)
        {
            float posX = Random.Range((-mapSize.x / 2) + offsetArea.x, (mapSize.x / 2) - offsetArea.x);
            float posY = Random.Range((-mapSize.y / 2) + offsetArea.y, (mapSize.y / 2) - offsetArea.y);
            if (posX != oldX && posY != oldY)
            {
                TranceEnemy(posX, posY);
                break;
            }
        }
    }

}
