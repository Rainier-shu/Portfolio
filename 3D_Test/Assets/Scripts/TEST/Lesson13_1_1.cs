using UnityEngine;

public class Lesson13_1_1 : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Camera;
    public Transform Camera2;
    private Transform Head;
    private Transform Gun;
    public float VerticalSpeed = 1;
    public float HorizontalSpeed = 1;
    public float MouseXSpeed = 1;
    public float MouseScrollWheelSpeed = 1;
    public float RotateAroundXSpeend = 1;
    private float MinGunRotation;
    private float MaxGunRotation;
    private Vector3 CameraPositionOffset;
    private Vector3 Camera2PositionOffset;
    //public Vector3 CameraLookAtOffset = new Vector3(0, 0, 2);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Head = this.transform.Find("Head");
        Gun = Head.transform.Find("Cylinder");
        MinGunRotation = Gun.transform.localEulerAngles.z - 20;
        MaxGunRotation = Gun.transform.localEulerAngles.z + 20;
        //CameraPositionOffset = new Vector3(3, 2, -5);
        Camera2PositionOffset = Camera2.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        #region 相机位置以及看向+炮台旋转防多操作
        if (Input.GetMouseButton(1))
        {
            Camera.RotateAround(this.transform.position, Vector3.up, RotateAroundXSpeend * Input.GetAxis("Mouse X") * Time.deltaTime);
            // 记录相对偏移，一定要在移动前记录才能获取初始间距
            // 若移动后记录，Camera.transform.position - this.transform.position就无法代表原始间隔
            CameraPositionOffset = Camera.transform.position - this.transform.position;
        }
        else
        {
            //炮台旋转
            Head.Rotate(Vector3.up, Input.GetAxis("Mouse X") * MouseXSpeed * Time.deltaTime);
        }
        #endregion

        #region 本体旋转与移动
        //本体旋转与移动
        this.transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * HorizontalSpeed * Time.deltaTime);
        this.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * VerticalSpeed * Time.deltaTime);
        #endregion

        #region 鼠标滚轮控制炮管上下
        float mouseScrollWheel = Input.GetAxis("Mouse ScrollWheel");
        Gun.Rotate(Vector3.forward, mouseScrollWheel * MouseScrollWheelSpeed);
        float curRotation = Gun.transform.localEulerAngles.z;
        float needZ = 0;
        if (curRotation >= MaxGunRotation)
        {
            needZ = MaxGunRotation;
        }
        else if (curRotation <= MinGunRotation)
        {
            needZ = MinGunRotation;
        }

        if (needZ != 0)
        {
            Gun.transform.localEulerAngles = new Vector3(Gun.transform.localEulerAngles.x, Gun.transform.localEulerAngles.y, needZ);
        }
        #endregion

        //固定相机位置
        Camera.position = Gun.transform.position;
        Camera2.position = transform.position + Camera2PositionOffset;

        //相机总看此对象(现总从炮口看向前方)
        Camera.transform.LookAt(this.Gun.transform.TransformPoint(Vector3.up * 10));

        #region 发射子弹
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = GameObject.Instantiate(Bullet);
            b.name = "Bullet";
            b.transform.position = Camera.transform.TransformPoint(Vector3.forward * 3);
            b.transform.eulerAngles = Camera.transform.eulerAngles;
            b.AddComponent<Lesson16_1_1_Bullet>();
        }
        #endregion
    }
}
