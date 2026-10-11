using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public Lesson3 AnotherGB;
    void Start()
    {
        #region 基本信息
        //依附GameObject的名称
        print(gameObject.name);

        //依附GameObject的transform的位置、旋转、缩放信息
        print(transform.position);
        print(transform.eulerAngles);
        print(transform.lossyScale);

        //别的GameObject的信息
        print(AnotherGB.gameObject.name);
        print(AnotherGB.transform.position);

        //脚本激活状态
        enabled = false;
        #endregion

        #region 核心信息

        #region 当前对象
        //获取依附GameObject上的单个脚本
        Lesson3_2 item = this.GetComponent("Lesson3_2") as Lesson3_2;
        print(item);

        item = GetComponent(typeof(Lesson3_2)) as Lesson3_2;
        print(item);

        item = GetComponent<Lesson3_2>();
        print(item);
        //只要我们能获取到一个GameObject对象或依附其的一个脚本，就能获取其所有脚本
        item = this.gameObject.GetComponent<Lesson3_2>();

        //获取依附对象的多个脚本
        Lesson3[] item2 = GetComponents<Lesson3>();
        print(item2.Length);

        List<Lesson3> item3 = new List<Lesson3>();
        GetComponents<Lesson3>(item3);
        print(item3.Count);
        #endregion

        #region 子对象和父对象
        //得到子对象挂载的脚本(默认也会找自己身上是否有对应的挂载)
        //此方法有一个bool类型的参数，代表是否找失活子对象上的脚本，默认为false
        //得到子对象单个挂载的脚本
        var item4 = GetComponentInChildren<Lesson3_2>(true);
        print(item4);

        //得到子对象多个挂载的脚本
        Lesson3_2[] item5 = GetComponentsInChildren<Lesson3_2>();
        print(item5.Length);
        List<Lesson3_2> item6 = new List<Lesson3_2>();
        GetComponentsInChildren<Lesson3_2>(true, item6);
        print(item6.Count);

        //得到父对象挂载的脚本(默认也会找自己身上是否有对应的挂载)
        var item7 = GetComponentInParent<Lesson3_2>();
        print(item7);

        Lesson3_2[] item8 = GetComponentsInParent<Lesson3_2>();
        print(item8.Length);
        //依旧有List写法，此处省略
        #endregion

        #region 尝试获取脚本
        Lesson3 item9;
        if (TryGetComponent<Lesson3>(out item9))
        {
            //逻辑处理
        }
        #endregion
        #endregion
    }
}
