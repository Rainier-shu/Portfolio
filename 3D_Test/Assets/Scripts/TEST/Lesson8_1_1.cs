using UnityEngine;

public class Lesson8_1_1 : MonoBehaviour
{
    public GameObject MainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //让主摄像机一直看此脚本挂载的对象
        MainCamera.transform.LookAt(this.transform);
    }
}
