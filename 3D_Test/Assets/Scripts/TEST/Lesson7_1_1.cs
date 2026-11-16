using UnityEngine;

public class Lesson7_1_1 : MonoBehaviour
{
    public GameObject Tank;

    public GameObject Head;

    public GameObject Cylinder;

    public int HeadRotateChangeCount = 500;

    public int CylinderRotateChangeCount = 300;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        #region 坦克展览
        #region 展览旋转
        Tank.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime, Space.Self);
        #endregion

        #region 炮台左右转动
        if ((Time.frameCount / HeadRotateChangeCount) % 2 == 0)
        {
            Head.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime, Space.Self);
        }
        else
        {
            Head.transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime, Space.Self);
        }
        #endregion

        #region 炮管上下转动
        if ((Time.frameCount / CylinderRotateChangeCount) % 2 == 0)
        {
            Cylinder.transform.Rotate(new Vector3(0, 0, 10) * Time.deltaTime, Space.Self);
        }
        else
        {
            Cylinder.transform.Rotate(new Vector3(0, 0, -10) * Time.deltaTime, Space.Self);
        }
        #endregion
        #endregion
    }
}
