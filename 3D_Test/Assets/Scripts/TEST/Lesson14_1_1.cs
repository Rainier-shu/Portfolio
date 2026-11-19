using UnityEngine;

public class Lesson14_1_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //打印当前对象的屏幕坐标
        print(Camera.main.WorldToScreenPoint(this.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        //点击左键时在对应深度为10的屏幕位置创建一个cube
        if (Input.GetMouseButtonDown(0))
        {
            GameObject a = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 mousept = Input.mousePosition;
            mousept.z = 10;
            a.transform.position = Camera.main.ScreenToWorldPoint(mousept);
        }
    }
}
