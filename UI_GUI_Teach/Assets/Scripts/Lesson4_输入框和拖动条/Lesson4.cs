using Unity.VisualScripting;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //此类用于输入框的字符串成员需要非null初始化，否则会报空引用错误
    string inputStr = "";

    string passwordStr = "";

    float nowValue;

    void OnGUI()
    {
        #region 知识点一 输入框
        #region 普通输入
        //第2、3参数分别代表：输入框内容、输入最大长度
        inputStr = GUI.TextField(new Rect(0, 0, 100, 20), inputStr, 10);
        #endregion

        #region 密码输入
        //第3、4参数分别代表：替换符、输入最大长度
        passwordStr = GUI.PasswordField(new Rect(0, 40, 100, 20), passwordStr, '*', 10);
        #endregion
        #endregion

        #region 知识点二 拖动条
        #region 水平拖动条
        //第2、3、4参数分别代表：当前值、最小值、最大值
        nowValue = GUI.HorizontalSlider(new Rect(0, 120, 100, 20), nowValue, 0, 10);
        #endregion

        #region 竖直拖动条
        #endregion
        nowValue = GUI.VerticalSlider(new Rect(0, 160, 20, 100), nowValue, 0, 10);
        #endregion
    }
}
