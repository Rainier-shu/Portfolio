using UnityEngine;

public class Lesson10_1_1 : MonoBehaviour
{
    [ContextMenu("生成空对象")]
    /// <summary>
    /// 在当前挂载对象的(-1, 0, 1)位置生成空对象
    /// </summary>
    public void CreateEmptyObjInSpecifiedLocation()
    {
        Func(new Vector3(-1, 0, 1));
    }

    [ContextMenu("生成球体")]
    /// <summary>
    /// 在当前挂载对象相对的三个位置生成球体
    /// </summary>
    public void CreateSphereInSpecifiedLocation()
    {
        Func(Vector3.forward, PrimitiveType.Sphere);
        Func(Vector3.forward * 2, PrimitiveType.Sphere);
        Func(Vector3.forward * 3, PrimitiveType.Sphere);
    }

    public void Func(Vector3 v, PrimitiveType? type = null)
    {
        Vector3 curTrans = this.transform.TransformPoint(v);

        GameObject obj;
        if (type != null)
        {
            obj = GameObject.CreatePrimitive(type.Value);
        }
        else
        {
            obj = new GameObject("Empty");
        }

        obj.transform.position = curTrans;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
