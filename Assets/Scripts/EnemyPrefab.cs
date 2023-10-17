using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefab : MonoBehaviour
{
    private GameObject   floorObj;
    private float spawnpoint;
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
        if (transform.position.x < spawnpoint - 50)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("GameOvar");
            UnityEditor.EditorApplication.isPlaying = false;   // UnityEditorの実行を停止する処理
            Application.Quit();                                // ゲームを終了する処理
            //Destroy(gameObject);
        }
    }
}
