using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Lesson6_1_1 : MonoBehaviour
{
    public GameObject Tank;
    public GameObject Use;
    public int layers = 5;
    public float cubeSize = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 1.创建金字塔
        for (int k = 0; k < layers; k++) // k = 层数（从顶层0开始）
        {
            int count = k + 1; // 每行/列的数量
            float offset = count / 2f - 0.5f; // 居中偏移

            for (int i = 0; i < count; i++) // X 轴
            {
                for (int j = 0; j < count; j++) // Z 轴
                {
                    // 1. 实例化或创建几何体
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                    // 2. 直接通过 transform 控制缩放
                    cube.transform.localScale = Vector3.one * cubeSize;

                    // 3. 计算并直接通过 transform 控制位置
                    float x = (i - offset) * cubeSize;
                    float z = (j - offset) * cubeSize;
                    float y = -k * cubeSize;

                    // 注意：如果希望以脚本所在对象为基准，使用 localPosition
                    cube.transform.position = new Vector3(x, y, z);
                }
            }
        }
        #endregion

        #region 2.translate移动理解
        //这四个方法,哪些才能让对象朝自己的面朝向移动? 为何?(可以画图说明)
        //相对世界坐标向前移动(否)
        //this.transform.Translate(Vector3.forward, Space.World);
        //相对自身坐标向前移动(是)
        //this.transform.Translate(Vector3.forward, Space.Self);
        //相对自身坐标向 自身前方移动 (双相对,否)
        //this.transform.Translate(this.transform.forward, Space.Self);
        //相对世界坐标向 自身前方移动 (是)
        //this.transform.Translate(this.transform.forward, Space.World);
        #endregion

        //预设Tank移动-1
        Use = Instantiate(Tank);

    }

    // Update is called once per frame
    void Update()
    {
        //预设Tank移动-2
        Use.transform.Translate(Use.transform.forward * 1 * Time.deltaTime, Space.World);
    }
}
