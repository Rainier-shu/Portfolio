using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public GameObject LookAtObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 1.缩放
        //相对于世界坐标系(只能获取，不能修改)
        //print(transform.lossyScale);
        //相对于父坐标系
        //print(transform.localScale);
        #endregion

        //注意
        //1.缩放同样只能xyz同时修改
        //2.缩放没有API直接使用
        //transform.localScale = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        #region 2.看向
        //看向一个点 相对世界坐标系
        //transform.LookAt(Vector3.zero);
        //看向一个可变坐标系
        transform.LookAt(LookAtObj.transform);
        #endregion
    }
}
