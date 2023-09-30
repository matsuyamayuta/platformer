using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCircle : MonoBehaviour
{

    [SerializeField] GameObject circleObj;
    [SerializeField] GameObject parentCircleGameObject;

    private GameObject floorObj;
    private float spawnpoint;

    public List<GameObject> CircleList = new List<GameObject>();// プレイファブを入れるリスト
    // Start is called before the first frame update
    void Start()
    {
        floorObj = GameObject.Find("FloorObj");
        spawnpoint = floorObj.GetComponent<ManageFloor>().spawnpoint;
    }

    // Update is called once per frame
    void Update()
    {
        spawnpoint = floorObj.GetComponent<ManageFloor>().spawnpoint;
        for(int i=0; i<CircleList.Count; i++)
        {
            if (CircleList[i].transform.position.x < spawnpoint-50)
            {
                Destroy(CircleList[i]);
                CircleList.Remove(CircleList[i]);
            }
        }
    }

    public void CreateCircle(float x, float y, int n)
    {
        for(int i = 0; i < n; i++)
        {
            GameObject obj = Instantiate(circleObj, new Vector3(x+(i*2)-10, y+2, 0), Quaternion.identity, parentCircleGameObject.transform) as GameObject;
            CircleList.Add(obj);
        }
    }
}
