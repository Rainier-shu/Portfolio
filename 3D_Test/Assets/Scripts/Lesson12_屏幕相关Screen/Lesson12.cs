using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Lesson12 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 1.静态属性
        #region 常用
        //当前屏幕分辨率，一般指设备分辨率
        Resolution r = Screen.currentResolution;
        print($"当前屏幕分辨率的宽:{r.width};当前屏幕分辨率的高:{r.height}");

        //屏幕窗口当前的宽高
        //这指的是当前窗口的宽高数值，不是设备分辨率
        //使用场景一般更多
        print(Screen.width);
        print(Screen.height);

        //屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        #endregion

        #region 不常用
        //运行时是否全屏模式，老属性，只粗分全屏与窗口
        Screen.fullScreen = true;

        //窗口模式，新属性，细化了窗口类型
        //独占全屏FullScreenMode.ExclusiveFullScreen(真全屏，独占，可改分辨率)
        //全屏窗口FullScreenMode.FullScreenWindow(无边框窗口，分辨率一般与显示器一致)
        //最大化窗口FullScreenMode.MaximizedWindow(最大化窗口，还有标题栏)
        //窗口模式FullScreenMode.Windowed(普通窗口，可拖动、调整大小)
        Screen.fullScreenMode = FullScreenMode.Windowed;

        //移动设备屏幕转向相关
        //允许自动旋转时的可用转向(一般只在ScreenOrientation.AutoRotation才有效)
        //允许自动旋转为左横向(Home在左)
        Screen.autorotateToLandscapeLeft = true;
        //允许自动旋转为右横向(Home在右)
        Screen.autorotateToLandscapeRight = true;
        //允许自动旋转到纵向(Home在下)
        Screen.autorotateToPortrait = true;
        //允许自动旋转到纵向倒着看(Home在上)
        Screen.autorotateToPortraitUpsideDown = true;

        //指定屏幕显示方向策略
        Screen.orientation = ScreenOrientation.AutoRotation;
        #endregion
        #endregion

        #region 2.静态方法
        //设置分辨率 一般移动设备不使用
        //参数分别为:宽/高/是否全屏
        Screen.SetResolution(1920, 1080, false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
