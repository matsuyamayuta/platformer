using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageFloor : MonoBehaviour
{
    [SerializeField] GameObject floorObj;
    [SerializeField] GameObject player;
    [SerializeField] GameObject parentFloorGameObject;

    private GameObject circleObj;

    public float spawnpoint = 10;
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
                float y = Random.Range(-5, -2);
                Instantiate(floorObj, new Vector3(spawnpoint + 10, y, 0), Quaternion.identity, parentFloorGameObject.transform);
                int n = Random.Range(0, 5);

                if (n != 0)
                {
                    circleObj = GameObject.Find("CircleObj");
                    circleObj.GetComponent<ManageCircle>().CreateCircle(spawnpoint,y,n);
                }
                spawnpoint += 20;
            }
        }
        
    }
}
