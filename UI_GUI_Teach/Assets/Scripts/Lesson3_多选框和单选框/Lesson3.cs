using Unity.VisualScripting;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public GUIStyle style;
    bool isSel;
    bool isSel1;
    int isSelIndex = 1;
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
        #region 知识点一 多选框
        #region 普通样式
        isSel = GUI.Toggle(new Rect(0, 0, 100, 20), isSel, "效果开关");
        #endregion

        #region 自定义样式 显示问题
        //修改固定宽高 FixedWidth/FixedHeight 来调整背景图大小(配置值为零时自动使用Rect的值)
        //修改从Padding来调整文本等内容的内边距(图与文本对不齐可修改Alignment)
        //Normal为未选中的配置，On Normal为选中时的配置
        isSel1 = GUI.Toggle(new Rect(0, 20, 100, 20), isSel1, "音效开关", style);
        #endregion
        #endregion

        #region 知识点二 单选框
        //单选框是基于多选框实现的
        //关键：用一个int变量来实现同时只有一个被选中的效果
        if (GUI.Toggle(new Rect(0, 80, 100, 20), isSelIndex == 1, "选项一"))
        {
            isSelIndex = 1;
        }
        if (GUI.Toggle(new Rect(0, 120, 100, 20), isSelIndex == 2, "选项二"))
        {
            isSelIndex = 2;
        }
        if (GUI.Toggle(new Rect(0, 160, 100, 20), isSelIndex == 3, "选项三"))
        {
            isSelIndex = 3;
        }
        #endregion
    }
}
