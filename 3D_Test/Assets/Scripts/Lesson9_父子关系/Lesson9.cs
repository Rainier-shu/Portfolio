using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 获取和设置父对象
        //获取父对象的信息
        //print(this.transform.parent.name);
        //移除父对象
        //this.transform.parent = null;
        //设置父对象，会保留世界坐标下的信息
        //this.transform.parent = GameObject.Find("Father2").transform;

        //通过API设置父对象
        //第一个参数:父对象的transform
        //第二个参数:是否保留世界坐标下的 位置 角度 缩放 信息，默认为true
        //this.transform.SetParent(null);
        //this.transform.SetParent(GameObject.Find("Father3").transform);
        //false时不保留世界坐标下信息，会将世界坐标信息直接复制到本地(相对于父对象)坐标下
        //this.transform.SetParent(GameObject.Find("Father3").transform, false);
        #endregion

        #region 2.抛妻弃子
        //和所有子对象断绝关系(但只有一层，不能断绝儿子与孙子的关系)
        //this.transform.DetachChildren();
        #endregion

        #region 3.获取子对象
        //通过名字获取子对象的信息(但只有一层，不能获取孙子的信息)
        //transform.Find可以获取到失活的对象，GameObject系列的查找则不能
        //此方法(Find)由于查找范围变窄，效率上比GameObject.Find好点；(但必需知道父亲是谁 才能找)
        print(this.transform.Find("Cube (1)").name);
        print(this.transform.Find("Cube_1"));

        //遍历子对象
        //获取子对象数量
        print(this.transform.childCount);
        //依据索引获取子对象的transform(注：索引溢出会报错！！)
        this.transform.GetChild(0);

        for (int i = 0; i < this.transform.childCount; i++)
        {
            print($"儿子{i}的名字:{this.transform.GetChild(i).name}");
        }
        #endregion

        #region 4.儿子的操作
        //判断 一个对象 是否为 另一个对象 的子对象
        if (son.IsChildOf(this.transform))
        {
            print($"{son.name}是我的儿子");
        }
        else
        {
            print($"{son.name}不是我的儿子");
        }

        //获取子对象的儿子编号
        print(son.GetSiblingIndex());
        //设置子对象为第一个儿子
        //son.SetAsFirstSibling();
        //设置子对象为最后一个儿子
        //son.SetAsLastSibling();

        //设置子对象为指定个儿子
        //son.SetSiblingIndex(1);
        //注意：当索引溢出时不会报错，但此子对象会被设置为最后一个儿子
        //son.SetSiblingIndex(-1);
        son.SetSiblingIndex(15);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
