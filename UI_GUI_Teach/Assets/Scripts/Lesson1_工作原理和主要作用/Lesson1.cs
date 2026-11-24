using Unity.VisualScripting;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 知识点一 GUI是什么
        //全称 即时模式游戏用户交互界面(IMGUI)
        //在Unity中一般简称为GUI
        //它是一个代码驱动的UI系统
        #endregion

        #region 知识点二 GUI的主要作用
        //1.作为程序员的调试工具，创建游戏内调试工具
        //2.为脚本组件创建自定义检视面板
        //3.创建新的编辑器窗口和工具以拓展Unity本身(一般用作内置游戏工具)

        //注意：不要用它为玩家制作UI功能
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region 知识点三 GUI的工作原理
    //在继承MonoBehaviour的脚本中的特殊函数里调用GUI提供的方法(类似生命周期函数)
    void OnGUI()
    {
        //GUI相关代码
    }
    //注意：
    //1.此方法每帧都执行，相对于专门绘制GUI界面的方法
    //2.一般仅在里面执行GUI界面绘制以及相关操作
    //3.此函数运行在OnDisable前，LateUpdate后
    //4.只要是继承Mono的脚本，都可以在OnGUI中绘制GUI
    #endregion
}
