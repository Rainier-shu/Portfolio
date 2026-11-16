using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 1.角度相关
        //相对于世界坐标的角度
        print(transform.eulerAngles);
        //相对于父对象的角度
        print(transform.localEulerAngles);

        //注意：角度也要一起设置，不能xyz单独设置
        //transform.eulerAngles = new Vector3(10, 10, 10);
        //想改变面板上的值，需改变相对于父对象的角度
        //transform.localEulerAngles = new Vector3(10, 10, 10);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 2.旋转相关
        //自己计算，与位移一致，不再赘述

        //API计算
        //自转
        //第一个参数：旋转的角度
        //第二个参数：相对坐标轴；默认为相对自身坐标轴
        //transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        //transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime, Space.World);

        //相对于某个轴旋转
        //第一个参数：轴
        //第二个参数：旋转多少
        //第三个参数：相对坐标轴；默认为相对自身坐标轴
        //transform.Rotate(Vector3.right, 10 * Time.deltaTime, Space.World);
        //transform.Rotate(Vector3.right, 10 * Time.deltaTime);

        //相对于某个点旋转
        //transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
        //transform.RotateAround(Vector3.zero, Vector3.right, 10 * Time.deltaTime);
        transform.RotateAround(Vector3.zero, transform.up, 10 * Time.deltaTime);
        #endregion
    }
}
