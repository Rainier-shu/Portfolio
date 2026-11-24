using UnityEngine;
using UnityEngine.SceneManagement;

public class ManyLesson_StartScene : MonoBehaviour
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
            SceneManager.LoadScene("GameScene");
        }

        GUI.Button(exitRect, "退出游戏");

        if (GUI.Button(setRect, "设置"))
        {
            SceneManager.LoadScene("SettingScene");
        }
    }
}
