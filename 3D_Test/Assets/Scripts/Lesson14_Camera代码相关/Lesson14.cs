using UnityEngine;
using UnityEngine.InputSystem;

public class Lesson14 : MonoBehaviour
{
    public Transform Circle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 知识点一 重要静态成员
        //1.获取摄像机
        //获取主摄像机(获取的是tag为MainCamera的对象；若有多个则无法确定是哪个)
        if (Camera.main)
        {
            print(Camera.main.name);
        }
        else
        {
            print("没有主摄像机");
        }
        //获取摄像机的数量
        print(Camera.allCamerasCount);
        //得到所有摄像机
        Camera[] cameras = Camera.allCameras;
        print(cameras.Length);

        //2.渲染相关委托
        //摄像机剔除前处理的委托函数
        Camera.onPreCull += (c) =>
        {

        };
        //摄像机渲染前处理的委托函数
        Camera.onPreRender += (c) =>
        {

        };
        //摄像机渲染后处理的委托函数
        Camera.onPostRender += (c) =>
        {

        };
        #endregion

        #region 知识点二 重要成员
        //1.界面上的参数都能在Camera中获取到
        Camera.main.allowMSAA = false;

        //2.世界坐标转屏幕坐标
        //转换后x/y代表此对象在当前摄像机屏幕中的坐标，z代表此对象距离当前摄像机的深度
        //常用来处理 头顶血条 相关的功能
        print(Camera.main.WorldToScreenPoint(this.transform.position));
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //3.屏幕坐标转世界坐标
        //透视摄像机中鼠标移动距离与世界x/y坐标变动的比例取决于指定深度下摄像机可视的横截面
        //深度越大，上述比例越大；当深度为0时，上述比例恒定为0，故移动到哪里都只是一个点
        //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));

        //Input.mousePosition的值默认z为0，故要赋值后才能得到有效的转换
        Vector3 mouse = Input.mousePosition;
        mouse.z = 5;
        Circle.position = Camera.main.ScreenToWorldPoint(mouse);
    }
}
