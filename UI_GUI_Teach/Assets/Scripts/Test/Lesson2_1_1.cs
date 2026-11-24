using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson2_1_1 : MonoBehaviour
{
    public Rect startRect;
    public Rect exitRect;
    public Rect setRect;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (GUI.Button(startRect, "开始游戏"))
        {
            SceneManager.LoadScene("Lesson2");
        }

        GUI.Button(exitRect, "退出游戏");

        GUI.Button(setRect, "设置");
    }
}
