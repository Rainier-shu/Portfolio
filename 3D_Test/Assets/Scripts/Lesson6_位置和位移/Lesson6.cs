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
        #region 位移
        //自己计算
        //路程=方向*速度*时间
        //向自己面朝向的方向以1单元/s的速度移动(游戏时间)
        //transform.position += transform.forward * 1 * Time.deltaTime;
        //向世界坐标的z轴正方向以1单元/s的速度移动(游戏时间)
        //transform.position += Vector3.forward * 1 * Time.deltaTime;

        //Api计算
        //此方法第二个参数默认为自身坐标系
        //基于自身坐标系，往其面朝向移动(向本地Z轴正方向移动)
        //transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        //基于世界坐标系，往其面朝向移动(向世界Z轴正方向移动)
        //transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.World);
        //基于自身坐标系，往自身坐标系相对世界坐标系的方向移动(移动轨迹难料，基本不会用)
        //transform.Translate(transform.forward * 1 * Time.deltaTime, Space.Self);
        //基于世界坐标系，往自身坐标系相对世界坐标系的方向移动(向自身面朝向移动)
        transform.Translate(transform.forward* 1 * Time.deltaTime, Space.World);
        #endregion
    }
}
