using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Rigidbody rigidBody;
    void Start()
    {
        #region 知识点一 刚体自带添加力的方法
        //给刚体加力的目标就是
        //让其有一个速度，朝着某一个方向移动

        //1.首先应该获取刚体组件
        rigidBody = this.gameObject.GetComponent<Rigidbody>();

        //2.添加力
        //相对世界坐标
        //加力过后对象是否移动是由阻力决定的
        //rigidBody.AddForce(Vector3.forward * 10);
        //超自己面朝向移动
        //rigidBody.AddForce(this.transform.forward * 10);
        //相对本地坐标
        //rigidBody.AddRelativeForce(Vector3.forward * 10);

        //3.添加扭矩力 让其旋转
        //相对世界坐标
        //rigidBody.AddTorque(Vector3.up * 10);
        //相对本地坐标
        //rigidBody.AddRelativeTorque(Vector3.up * 10);

        //4.直接改变速度
        //直线 相对世界坐标
        //rigidBody.linearVelocity = Vector3.forward;
        //旋转 相对世界坐标
        //rigidBody.angularVelocity = Vector3.up;

        //5.模拟爆炸效果
        //希望产生爆炸效果的对象的刚体需执行此方法才能有效(非全局影响)
        //参数从左到右分别代表：威力、爆炸中心、爆炸范围
        //rigidBody.AddExplosionForce(100, Vector3.zero, 10);
        #endregion

        #region 知识点二 力的几种模式
        //实际就是施加力方法的第二个参数，通过调整计算方式来改变力造成的影响
        //力本身对Unity没有意义，速度与位移是更好的参考
        //rigidBody.AddForce(Vector3.forward * 10, ForceMode.VelocityChange);

        //与动量定理有关
        //Ft = mv
        //F：力
        //t：时间(实际就是物理帧间隔)
        //m：质量
        //v：速度
        //v=Ft/m

        //1.ForceMode.Acceleration
        //施加一个持续的加速度，忽略质量(可当公式里的质量为1)

        //2.ForceMode.Force
        //施加一个持续的力，默认的模式，不忽略任何元素

        //3.ForceMode.Impulse
        //施加一个冲量，相当于把时间设置为1(一个固定单位)；由于v=I(冲量)/m，故受质量影响

        //4.ForceMode.VelocityChange
        //施加一个速度，忽略时间与质量(可当公式里的时间与质量都为1)
        #endregion

        #region 知识点三 力场脚本
        //可以为对象加Constant Force脚本来施加常量力
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //若希望即使有阻力，对象也能一直动，就在Update加力
        //rigidBody.AddForce(Vector3.forward * 10);

        #region 补充 刚体的休眠
        //Unity为了节约资源，当刚体挂载的对象稳定后，此对象可能不会响应场景非关键参数的改变
        //若希望避免这种奇怪现象
        //当刚体休眠时
        if (rigidBody.IsSleeping())
        {
            //唤醒它
            rigidBody.WakeUp();
        }
        #endregion
    }

    //当前让物体产生的位移方式
    //1.Translate等直接改变位置的方式
    //2.AddForce等施加力的方式
    //3.直接更改linearVelocity速度
    //4.添加配置立场脚本(其本质应该也是施加力)
}
