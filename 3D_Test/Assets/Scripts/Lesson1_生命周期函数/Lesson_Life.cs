using Unity.VisualScripting;
using UnityEngine;

public class Life : MonoBehaviour
{
    /// <summary>
    /// 当对象(自己这个类对象)被创建时调用
    /// 一个对象只会调用一次
    /// </summary>
    void Awake()
    {
        //通用日志方法
        //Debug.Log("1234");

        //MonoBehaviour继承类专用方法
        print("Awake");
    }

    /// <summary>
    /// 脚本每次激活时调用
    /// </summary>
    void OnEnable()
    {
        print("OnEnable");
    }

    /// <summary>
    /// 在脚本第一次激活后于该帧更新之前调用
    /// 一个对象只会调用一次
    /// </summary>
    void Start()
    {
        print("Start");
    }

    /// <summary>
    /// 固定间隔时间执行，可以在Edit-Project Setting-Time中设置
    /// 用于物理帧更新
    /// </summary>
    void FixedUpdate()
    {
        print("FixedUpdate");
    }

    /// <summary>
    /// 每帧执行
    /// 用于逻辑值帧更新
    /// </summary>
    void Update()
    {
        print("Update");
    }

    /// <summary>
    /// 于Update之后，每帧执行
    /// 一般用于摄像头更新
    /// </summary>
    void LateUpdate()
    {
        print("LateUpdate");
    }

    /// <summary>
    /// 脚本每次失活时调用
    /// </summary>
    void OnDisable()
    {
        print("OnDisable");
    }

    /// <summary>
    /// 依附的GameObject对象被删除时调用
    /// 一个对象只会调用一次
    /// </summary>
    void OnDestroy()
    {
        print("OnDestroy");
    }
}
