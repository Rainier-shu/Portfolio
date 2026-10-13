using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject MyObj;
    public GameObject MyObj2;

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

        //实例化对象的方法
        //根据一个GameObject创建出一个一模一样的对象
        //此方法来自于Unity的Object，可以不需要GameObject，直接调用
        GameObject obj5 = GameObject.Instantiate(MyObj);

        //删除对象的方法
        //注意：Destroy方法一般情况下会在下一帧时从场景与内存中移除指定的对象(类似于给对象打了移除标识)
        GameObject.Destroy(MyObj2);
        //第二个参数代表延迟删除的秒数
        //Destroy(obj5, 3);
        //此方法不仅可以删除游戏对象，还可以删除脚本对象
        Destroy(this);

        //立即把对象从内存中移除
        //如果没有特殊需求，建议使用上边的Destroy，这会降低卡顿的几率
        DestroyImmediate(obj5);

        //过场景不移除
        //默认情况下，在切换场景时，场景中的对象都会被自动删除
        //一般传依附的游戏对象
        DontDestroyOnLoad(this.gameObject);
        #endregion

        #region GameObject中的成员方法
        //创建空物体
        //第一个参数为对象名；第二个参数为变长的Type，代表添加的脚本；
        GameObject obj6 = new GameObject();
        GameObject obj7 = new GameObject("新建的空对象");
        GameObject obj8 = new GameObject("新建后加脚本的空对象", typeof(Life), typeof(Lesson2));

        //动态为游戏对象添加脚本
        //返回值为添加上的具体脚本
        Life sc1 = obj6.AddComponent(typeof(Life)) as Life;
        Lesson2 sc2 = obj6.AddComponent<Lesson2>();
        sc2.enabled = false;
        print(sc1.tag);

        //GameObject得到脚本的方法与Mono类一模一样，此处不再复述
        Life sc3 = obj6.GetComponent<Life>();
        sc3.tag = "Player";

        //标签比较
        //以下两种比较方式一模一样
        if (this.gameObject.CompareTag("Player"))
        {
            print("当前游戏对象的标签为Player");
        }
        if (this.gameObject.tag == "Player")
        {
            print("当前游戏对象的标签为Player");
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
