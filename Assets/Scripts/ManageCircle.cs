using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCircle : MonoBehaviour
{

    [SerializeField] GameObject circleObj;
    [SerializeField] GameObject parentCircleGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateCircle(float x, float y, int n)
    {
        for(int i = 0; i < n; i++)
        {
            Instantiate(circleObj, new Vector3(x+(i*2)-10, y+2, 0), Quaternion.identity, parentCircleGameObject.transform);
        }
    }
}
