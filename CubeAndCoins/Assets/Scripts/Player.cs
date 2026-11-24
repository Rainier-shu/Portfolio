using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// 主摄像机相对玩家偏差
    /// </summary>
    public Vector3 MainCameraPositionOffset;

    /// <summary>
    /// 玩家前后位移的速度
    /// </summary>
    public float PlayerTranslateSpeed;

    /// <summary>
    /// 玩家左右转向的速度
    /// </summary>
    public float PlayerRotateSpeed;

    /// <summary>
    /// 是否获取金币
    /// </summary>
    private bool IsGetCoin;

    /// <summary>
    /// 此对象的刚体
    /// </summary>
    private Rigidbody RigidBody;

    /// <summary>
    /// 主摄像机
    /// </summary>
    private Camera MainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainCamera = Camera.main;
        RigidBody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //A/D转向;W/S位移
        this.transform.Rotate(Input.GetAxis("Horizontal") * Vector3.up * PlayerRotateSpeed * Time.deltaTime);
        this.transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * PlayerTranslateSpeed * Time.deltaTime);

        //主摄像机始终距离玩家一定距离 且 一直看向玩家
        MainCamera.transform.position = this.transform.TransformPoint(MainCameraPositionOffset);
        MainCamera.transform.LookAt(this.transform);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Coin")
        {
            IsGetCoin = true;
            GameObject.Destroy(col.gameObject);
        }
        else if (col.tag == "Door" && IsGetCoin)
        {
            RigidBody.AddForce(Vector3.up * 15, ForceMode.VelocityChange);
        }
    }
}
