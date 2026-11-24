using Unity.VisualScripting;
using UnityEngine;

public class ManyLesson_SettingScene : MonoBehaviour
{
    public Rect rect1;
    public Rect rect2;
    bool isSel1;
    bool isSel2;
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
        isSel1 = GUI.Toggle(rect1, isSel1, "背景音乐");
        isSel2 = GUI.Toggle(rect2, isSel2, "音效");
    }
}
