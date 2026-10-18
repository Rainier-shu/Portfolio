using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 时间缩放比例
        //时间停止
        //Time.timeScale = 0;
        //正常时间
        //Time.timeScale = 1;
        //2倍速
        Time.timeScale = 2;
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 帧间隔时间
        //主要用来计算位移
        //路程=速度*时间
        //根据需求 选择参与计算的间隔时间

        //帧间隔时间：最近的一帧用了多长时间(秒)
        //受scale影响
        //print($"帧间隔时间:{Time.deltaTime}");

        //不受scale影响
        //print($"不受scale影响的帧间隔时间:{Time.unscaledDeltaTime}");
        #endregion

        #region 游戏时间：游戏从开始到现在过了多久
        //主要用于在单机游戏中计时
        //受scale影响
        //print($"游戏时间:{Time.time}");

        //不受scale影响
        //print($"不受scale影响的游戏时间:{Time.unscaledTime}");
        #endregion

        #region 帧数
        //游戏开始到现在跑了多少帧(次循环)
        //print(Time.frameCount);
        #endregion
    }

    private void FixedUpdate()
    {
        #region 物理帧间隔时间
        //不受scale影响
        print($"物理帧间隔时间{Time.fixedDeltaTime}");

        //受scale影响
        print($"不受scale影响的物理帧间隔时间{Time.fixedUnscaledDeltaTime}");
        #endregion

        //在Edit->Project Settings->Time->Fixed Timestep可以设置物理帧间隔
        //Time.timeScale可以用来调节游戏时间运行速度的倍率，设置为0时在一定情况下可以用于暂停游戏;
        //Time.deltaTime可以搭配速度用来计算各游戏对象的位移
        //帧同步功能会用到Time.frameCount
    }
}
