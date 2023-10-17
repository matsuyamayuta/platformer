using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageFloor : MonoBehaviour
{
    [SerializeField] GameObject floorObj;
    [SerializeField] GameObject player;
    [SerializeField] GameObject parentFloorGameObject;

    private GameObject circleObj;
    private GameObject enemyObj;

    public float spawnpoint = 10; // 床の生成間隔
    bool start = false;

    // Start is called before the first frame update
    void Start()
    {
        start = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (start)
        {
            if (player.transform.position.x > spawnpoint - 30)
            {
                int n = Random.Range(0, 7); // ポイント生成数
                int e = Random.Range(5, 7); // 敵生成数 
                float  floorY = Random.Range(-5, -2); // 床の高さ
                Instantiate(floorObj, new Vector3(spawnpoint + 10, floorY, 0), Quaternion.identity, parentFloorGameObject.transform);
                if(spawnpoint >= 30)
                {
                    if (n != 0)
                    {
                        circleObj = GameObject.Find("CircleObj");
                        circleObj.GetComponent<ManageCircle>().CreateCircle(spawnpoint + 10, floorY + 1.5f, n);
                    }
                    else
                    {
                        enemyObj = GameObject.Find("EnemyObj");
                        enemyObj.GetComponent<ManageEnemy>().CreateEnemy(spawnpoint + 10, floorY + 1.5f, e);
                    }
                }
                spawnpoint += 20;
            }
        }
        
    }
}
