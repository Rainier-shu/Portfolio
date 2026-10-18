using NUnit.Framework.Constraints;
using UnityEngine;

public class Lesson6_ : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region Transform主要用来干什么
        //游戏对象(GameObject)位移、旋转、缩放、父子关系、坐标转换等相关操作都由它处理
        #endregion

        #region Vector3基础
        //Vector3主要是用来表示三维坐标系的 一个点/一个向量
        Vector3 vcr1 = new Vector3();
        vcr1.x = 10;
        vcr1.y = 10;
        vcr1.z = 10;

        //Vector3两参构造,此时z默认为0
        Vector3 vcr2 = new Vector3(10, 10);
        //Vector3三参构造,用的最多
        Vector3 vcr3 = new Vector3(10, 10, 10);
        //Vector是构造体,其声明时x/y/z默认为0
        //Vector3 vcr4;

        //基本计算
        Vector3 vcr5_1 = new Vector3(1, 1, 1);
        Vector3 vcr5_2 = new Vector3(2, 2, 2);

        print(vcr5_1 + vcr5_2); //加
        print(vcr5_1 - vcr5_2); //减
        print(vcr5_1 * 4); //乘
        print(vcr5_2 / 2); //除

        //常用静态变量
        print(Vector3.zero); //原点 0,0,0
        print(Vector3.up); //上 0,1,0
        print(Vector3.down); //下 0,-1,0
        print(Vector3.left); //左 -1,0,0
        print(Vector3.right); //右 1,0,0
        print(Vector3.forward); //前 0,0,1
        print(Vector3.back); //后 0,0,-1

        //常用方法-两点的距离计算
        print(Vector3.Distance(vcr5_1, vcr5_2));
        #endregion

        #region 位置
        //相对于世界坐标轴的位置
        print(transform.position);
        //相对于父对象坐标轴的位置(一般和Inspector界面上显示的一样)
        print(transform.localPosition);

        //游戏对象的位置赋值只能整体赋值,不能单独改x y z某一个值
        transform.localPosition = new Vector3(10, 10, 10);

        //单x赋值方式
        transform.localPosition = new Vector3(10, transform.localPosition.y, transform.localPosition.z);
        //提取 使用Vector3可以单独赋值的原理来进行
        Vector3 vcr6 = transform.localPosition;
        vcr6.x = 10;
        transform.localPosition = vcr6;

        //游戏对象当前的朝向
        //面朝向
        print(transform.forward);
        //头顶朝向
        print(transform.up);
        //右手边
        print(transform.right);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
