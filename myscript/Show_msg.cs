using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Show_msg : MonoBehaviour
{
    private Text text;
    [SerializeField]private float time = 35;
    


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        Invoke("show", time);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        GetComponent<Text>().text = time.ToString("F2");
    }

    void show()
    {
        SceneManager.LoadScene("game");
    }
}
