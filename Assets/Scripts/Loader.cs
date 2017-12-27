using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{

    public float LoadDuration;

    // Use this for initialization
    void Start()
    {
        Timer = LoadDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                LoadMenu();
            }
        } 
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("main");
    }

    private float Timer;
}
