using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Happy,
    Sad
}

public class Player
{
    public int Attack;
    public int Speed;
}

[System.Serializable]
public class Boss
{
    public int Attack;
    public int Speed;
}

public class Lesson2 : MonoBehaviour
{
    #region 知识与示例
    //保护或私有成员默认不能被反射显示在Inspector窗口
    protected string Item1;

    //但加上此特性后可以
    [SerializeField]
    protected string Item11;

    //共有类型默认可显示
    public string Item2;

    //但加上了此特性后不会显示
    [HideInInspector]
    public string Item21;

    //大部分类型都可以显示
    public int[] Item3;

    public List<int> Item4;

    public Type Item6;

    //但总有例外
    public Dictionary<int, int> Item5;

    //自定义类默认无法显示
    public Player Item7;

    //但是在定义时加上[System.Serializable]特性后即可显示
    public Boss Item8;

    //此特性可以限制属性的范围
    [Range(1, 10)]
    public double Item9;

    //
    [ContextMenuItem("重置10", "ResetItem10")]
    public int Item10;
    public void ResetItem10()
    {
        Item10 = 100;
    }

    public int Item12;

    [ContextMenu("重置12")]
    public void ResetItem12()
    {
        Item12 = 99;
    }
    #endregion

    #region 注意
    //1.Inspector窗口中的变量关联的就是对象的成员变量，运行时改变他们就是在改变成员变量
    //2.拖拽到GameObject对象后，再改变脚本中变量的默认值，界面上不会改变
    //3.运行中修改的信息不会保存
    #endregion

    [HideInInspector]
    public string Item101;

    [SerializeField]
    private string Item102;

    //自己的理解：脚本信息本身在Inspector窗口上有默认的规则(通过反射体现)；特性算是对对象的特殊解释，其同样能被反射机制获取并作用到Inspector窗口；
}
