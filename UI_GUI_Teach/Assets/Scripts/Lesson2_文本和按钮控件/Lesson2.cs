using Unity.VisualScripting;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public Texture tex;
    public GUIContent content;
    public GUIContent btnContent;
    public GUIStyle style;
    public GUIStyle btnStyle;
    public Rect texRect;
    public Rect contentRect;
    public Rect btnRect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 知识点一 GUI控件绘制的共同点
        //1.它们都是GUI公共类中提供的静态函数
        //2.它们的参数都大同小异
        //位置参数：Rect参数、x/y位置、w/h尺寸(GUI控件的原点为左上角，向右为x轴正方向，向下为y轴正方向)
        //显示文本：string参数
        //图片信息：Texture参数
        //综合信息：GUIContent参数
        //自定义样式：GUIStyle参数
        //3.每一种控件都有多种重载，都是各个参数的排列组合
        //必备的参数内容为：位置信息 与 显示信息
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        #region 知识点二 文本控件
        //基本使用
        //显示文本
        GUI.Label(new Rect(0, 0, 100, 20), "普通文本");
        //显示图片(不会改变图片原始的宽高比)
        GUI.Label(texRect, tex);
        //综合使用(总是图片在左，文本在右)
        GUI.Label(contentRect, content);
        //可以获取当前鼠标或者键盘选中的GUI控件对应的tooltip信息
        Debug.Log(GUI.tooltip);
        //自定义样式
        //常用参数：
        //Normal：Text Color(文本颜色)、Background(背景图)
        //独立：Font(字体)、Font Size(字体大小)、Font Style(字体风格)
        //Alignment(对齐方式)、Word Warp(语句换行)
        //还有很多参数，可到Unity官方文档了解参数的功能
        GUI.Label(new Rect(0, 100, 100, 20), "普通文本", style);
        #endregion

        #region 知识点三 按钮控件
        //基本上与文本控件都一致
        //基础使用
        //综合使用
        //自定义样式
        //比其文本，按钮更重视Normal(正常)/Hover(悬停)/Active(激活)中背景图/文本颜色的配置
        //GUI.Button返回按钮是否被点击
        //只有在按钮范围内按下鼠标后抬起才会返回true
        //if (GUI.Button(btnRect, btnContent, btnStyle))
        //{
        //    print("按钮被点击了");
        //}
        //只要在按钮范围内按下鼠标就会返回true，长按则不断返回
        if (GUI.RepeatButton(btnRect, btnContent, btnStyle))
        {
            print("长按按钮被点击了");
        }
        #endregion
    }
}
