using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyObj;
    [SerializeField] GameObject parentEnemyGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateEnemy(float x, float y, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Instantiate(enemyObj, new Vector3(x+(i*1.2f), y, 0), Quaternion.identity, parentEnemyGameObject.transform);
        }
    }
}
