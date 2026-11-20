using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    public Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 1.面板参数
        //见 入门知识 笔记
        #endregion

        #region 2.代码控制
        //以代码改变其成员变量
        light.intensity = 1.2f;
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
