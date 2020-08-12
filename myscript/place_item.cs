using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place_item : MonoBehaviour
{
    //生成するゲームオブジェクト達
    [SerializeField]
    private GameObject[] item;

    //何回生成を実行するか
    [SerializeField]
    private int run_times;

    //最大x座標と最大z座標
    [SerializeField]
    private int location_x_min;
    [SerializeField]
    private int location_z_min;
    [SerializeField]
    private int location_x_max;
    [SerializeField]
    private int location_z_max;

    //生成したオブジェクトを格納するバッファのようなもの
    private GameObject buf;
    //ゲームオブジェクトを識別する番号
    private int index = 0;

    //乱数用のx座標とｚ座標
    private float x;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        //実行ループ
        for(int i = 0; i < run_times; i++)
        {
            Debug.Log(Time.deltaTime);
            //インデックス用乱数生成
            index = Random.Range(0, item.Length-1);
            //座標用乱数生成
            x = Random.Range(location_x_min, location_x_max);
            z = Random.Range(location_z_min, location_z_max);

            //オブジェクト生成
            buf = Instantiate(item[index], new Vector3(x, 1, z), Quaternion.Euler(Random.Range(10,90),Random.Range(0,360),0));

            //ペアレント化
            buf.transform.parent = this.gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
