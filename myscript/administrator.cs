using Oculus.Platform.Models;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class administrator : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject light_obj;

    [SerializeField]
    private GameObject[] warp_point;

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private string[] scene_list;

    [SerializeField]
    private Text now_scene_name;

    [SerializeField]
    private int scene_number=0;
    private int warp_point_number=0;
    private Scene nowscene;
    //[SerializeField]
    //private GameObject map;

    private void Start()
    {
        nowscene = SceneManager.GetActiveScene();
        now_scene_name.text = nowscene.name;
    }

    public void SwitchLight()
    {
        light_obj.SetActive(!light_obj.activeSelf);
    }

    public void ReloadScene()
    {
        Scene nowscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(nowscene.name);
    }

    public void SkipScene()
    {
        //nowscene = SceneManager.GetActiveScene();
        ////iはカウント用の変数
        //for (int i = 0; i > scene_list.Length; i++)
        //{
        //    if (SceneManager.GetActiveScene().name == scene_list[i])
        //    {
        //        scene_number = i;
        //        break;
        //    }
        //}

        scene_number += 1;

        if (scene_number == 3)
        {
            scene_number = 0;
        }

        SceneManager.LoadScene(scene_list[scene_number]);
    }

    public void Warp()
    {
        player.transform.position = warp_point[warp_point_number].transform.position;
        warp_point_number++;
        if (warp_point_number > warp_point.Length) warp_point_number = 0;
    }

    public void Delete_Enemy()
    {
        Destroy(enemy.gameObject);
    }

    public void Show_Map()
    {
        
    }

}
