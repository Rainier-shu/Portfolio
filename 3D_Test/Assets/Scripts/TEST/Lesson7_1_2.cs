using UnityEngine;

public class Lesson7_1_2 : MonoBehaviour
{
    public GameObject EarthOrbit; // 地球公转轨道
    public GameObject Earth;      // 地球本体
    public GameObject MoonOrbit;  // 月亮公转轨道
    public GameObject Moon;       // 月亮本体

    void Update()
    {
        // 1. 太阳自转
        transform.Rotate(Vector3.up, 10 * Time.deltaTime, Space.World);

        // 2. 地球公转 (让空物体转，地球作为子物体自然跟着绕太阳转)
        EarthOrbit.transform.Rotate(Vector3.up, 10 * Time.deltaTime, Space.World);
        // 3. 地球自转
        Earth.transform.Rotate(Vector3.up, 10 * Time.deltaTime, Space.Self);

        // 4. 月亮公转 (让空物体转，月亮作为子物体自然跟着地球转)
        MoonOrbit.transform.Rotate(Vector3.up, 20 * Time.deltaTime, Space.World);
        // 5. 月亮自转
        Moon.transform.Rotate(Vector3.up, 10 * Time.deltaTime, Space.Self);
    }
}