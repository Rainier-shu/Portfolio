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
        //transform
        //以下两种写法等价
        print(this.transform);
        print(this.gameObject.transform);
        #endregion

        #region GameObject中的静态方法
        //创建自带集合体
        GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj1.name = "Lesson4生成的立方体";

        //查找单个对象
        //对象名与tag找的共同点
        //1.都无法找到失活的对象
        //2.当有多个满足条件的对象存在时，无法确定找到的对象是哪个
        //3.这些方法需要单遍历，查找效率较差
        //通过对象名找
        GameObject obj2 = GameObject.Find("Lesson4_Test");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("通过对象名没有找到对象");
        }
        //通过tag找
        //这两个方法名称不一致，效果一致
        //GameObject obj3 = GameObject.FindWithTag("player");
        GameObject obj3 = GameObject.FindGameObjectWithTag("Player");
        if (obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("通过tag没有找到对象");
        }
        //目前获取其它对象的方法有2种
        //1.public的mono属性，从Inspector拖取
        //2.通过对象名或tag查找

        //查找多个对象
        //只能通过tag来找
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print($"Tag为Player的对象有{objs.Length}个");

        //GameObject的父类Object提供的其它查找对象方法
        //此Object类的命名控件在UnityEngine,不是C#中万物之父的那个Object;此方法双遍历，效率更差
        Lesson4 obj4 = GameObject.FindAnyObjectByType<Lesson4>();
        if (obj4 != null)
        {
            print(obj4.name);
            print(obj4.gameObject.name);
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
