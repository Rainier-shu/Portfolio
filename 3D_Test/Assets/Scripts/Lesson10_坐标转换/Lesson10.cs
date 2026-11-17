using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 1.世界坐标系转本地坐标系
        //可以用来判断一个对象对另一个对象的相对位置

        //点转换
        //受缩放影响
        print($"世界转本地_点转换:{this.transform.InverseTransformPoint(Vector3.forward)}");

        //方向(向量)转换
        //不受缩放影响
        print($"世界转本地_向量转换(不受缩放影响):{this.transform.InverseTransformDirection(Vector3.forward)}");
        //受缩放影响
        print($"世界转本地_向量转换(受缩放影响):{this.transform.InverseTransformVector(Vector3.forward)}");
        #endregion

        #region 2.本地坐标系转世界坐标系
        //当需要依据某个对象本地坐标指定位置/方向来生成暂时对象时很有用

        //点转换
        //受缩放影响
        print($"本地转世界_点转换:{this.transform.TransformPoint(Vector3.forward)}");

        //方向(向量)转换
        //不受缩放影响
        print($"本地转世界_方向转换(不受缩放影响):{this.transform.TransformDirection(Vector3.forward)}");
        //受缩放影响
        print($"本地转世界_方向转换(受缩放影响):{this.transform.TransformVector(Vector3.forward)}");
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
