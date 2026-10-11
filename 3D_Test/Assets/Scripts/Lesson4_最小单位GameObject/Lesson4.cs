using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region GameObject中的成员变量
        //名字
        print(this.gameObject.name);
        gameObject.name = "Lesson4_已改名";
        print(gameObject.name);
        //是否激活
        print(gameObject.activeSelf);
        //是否静态
        print(gameObject.isStatic);
        //层级
        print(gameObject.layer);
        //标签
        print(gameObject.tag);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
