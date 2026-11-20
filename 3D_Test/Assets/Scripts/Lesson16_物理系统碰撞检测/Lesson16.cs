using Unity.VisualScripting;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //注意：碰撞和触发响应函数 属于 特殊的生命周期函数，也是通过反射调用
        //这些函数总是在FixedUpdate物理帧更新后执行，其调用频率与物理帧更新函数一致
        //从这个角度看，它们属于一种特殊的生命周期函数
    }

    // Update is called once per frame
    void Update()
    {

    }

    #region 知识点一 物理碰撞检测响应函数
    //碰撞触发接触时执行
    void OnCollisionEnter(Collision col)
    {
        //Collision入参包含了碰到自己的对象的相关信息

        //关键参数
        //1.碰到对象的碰撞器
        //col.collider

        //2.碰到的对象
        //col.gameObject

        //3.碰到对象的transform信息
        //col.transform

        //4.碰到对象的接触点相关信息
        //接触点数量
        //col.contactCount
        //接触点
        //ContactPoint[] ConPos = col.contacts;

        print($"{this.name}被{col.gameObject.name}撞到了");
    }

    //碰撞结束分离时执行
    void OnCollisionExit(Collision col)
    {
        print($"{this.name}与{col.gameObject.name}分离了");
    }

    //碰撞接触摩擦时不断执行
    void OnCollisionStay(Collision col)
    {
        print($"{this.name}正与{col.gameObject.name}接触摩擦");
    }
    #endregion

    #region 知识点二 触发器检测响应函数
    //触发开始的时候执行
    void OnTriggerEnter(Collider other)
    {
        print($"{this.name}被{other.gameObject.name}触发了");
    }

    //水乳交融状态结束的时候执行
    void OnTriggerExit(Collider other)
    {
        print($"{this.name}与{other.gameObject.name}结束了水乳交融");
    }

    //处于 水乳交融 状态时不断执行
    void OnTriggerStay(Collider other)
    {
        print($"{this.name}正在与{other.gameObject.name}水乳交融");
    }
    #endregion
}
