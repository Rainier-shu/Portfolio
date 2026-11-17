using UnityEngine;
using UnityEngine.InputSystem;

public class Lesson11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region 注意:输入相关内容一定是写在Update中的
        #endregion

        #region 1.鼠标在屏幕中的位置
        //屏幕的原点在左下角
        //往左为x轴正方向，往上为y轴正方向
        //由于屏幕本身就是2d的，所以z轴永远为0
        //print(Input.mousePosition);
        #endregion

        #region 2.检测鼠标输入
        //鼠标检测使用场景举例
        //1.发射子弹
        //2.控制摄像机转动

        //左键0；右键1；中键2；
        //检测鼠标按下的一瞬间，只在这瞬间进入一次
        if (Input.GetMouseButtonDown(0))
        {
            print("按下了鼠标左键");
        }

        //检测鼠标松开(抬起)的一瞬间
        if (Input.GetMouseButtonUp(2))
        {
            print("松开了鼠标中间");
        }

        //检测鼠标的按下抬起；按住不放会一直进入
        if (Input.GetMouseButton(1))
        {
            print("右键按下");
        }

        //获取鼠标中键滚动状态
        //返回值为Vector2；中键滚动时会改变其中的y值
        //-1往下滚；0没有滚；1往上滚
        //print(Input.mouseScrollDelta);
        #endregion

        #region 3.检测键盘输入
        //使用场景举例
        //1.依据按键释放技能
        //2.依据按键切换武器

        //键盘按键按下的一瞬间进入
        //使用KeyCode检测输入，常用
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("按下了w");
        }

        //键盘按键松开(抬起)的一瞬间进入
        //使用字符串检测输入，很少用
        //字符串必需为小写，否则会报错
        if (Input.GetKeyUp("w"))
        {
            print("松开了w");
        }

        //键盘按下抬起都进入；长按则一直进入
        if (Input.GetKey(KeyCode.Q))
        {
            print("Q按下");
        }
        #endregion

        #region 4.检测默认轴输入
        //用于控制玩家 旋转 位移 等等

        //字符串参数对应Project Settings->Input Manager->Axes的配置
        //Input.GetAxis:适用于需要渐变/平滑的场景
        //按键A~D:-1~1
        //print(Input.GetAxis("Horizontal"));

        //按键S/W:-1~1
        //print(Input.GetAxis("Vertical"));

        //鼠标横向移动(不动为0，往左为负数，往右为正数，不受-1~1限制)
        //print(Input.GetAxis("Mouse X"));

        //鼠标纵向移动(不动为0，往下为负数，往上为正数，不受-1~1限制)
        //print(Input.GetAxis("Mouse Y"));

        //Input.GetAxisRaw:返回-1,0,1；用法与Input.GetAxis基本一致
        //键盘返回为-1,0,1
        print("键盘AD:" + Input.GetAxisRaw("Horizontal"));
        //鼠标返回依旧有小数且不限制范围，但比GetAxis少一些因素计算，相对延迟会低点
        print("鼠标纵向移动:" + Input.GetAxisRaw("Mouse Y"));
        #endregion
    }
}
