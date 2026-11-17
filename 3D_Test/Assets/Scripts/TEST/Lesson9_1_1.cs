using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public static class TransformExtensions
{
    /// <summary>
    /// 以子对象的名称长度进行升序排序
    /// </summary>
    /// <param name="t"></param>
    public static void SortChildObjectsByNameLength(this Transform t)
    {
        //获取全部子对象
        List<Transform> children = new List<Transform>();

        for (int i = 0; i < t.childCount; i++)
        {
            children.Add(t.GetChild(i));
        }

        //以名称长度升序排列
        children.Sort((a, b) => a.name.Length.CompareTo(b.name.Length));

        //设置顺序
        for (int i = 0; i < children.Count; i++)
        {
            children[i].SetSiblingIndex(i);
        }
    }

    /// <summary>
    /// 依据名称获取任意层子对象的Transform
    /// </summary>
    /// <param name="t"></param>
    /// <param name="childName"></param>
    /// <returns></returns>
    public static Transform GetChildForever(this Transform t, string childName)
    {
        if (t.childCount < 0)
            return null;

        Transform res;

        for (int i = 0; i < t.childCount; i++)
        {
            Transform child = t.GetChild(i);
            if (child.name == childName)
            {
                res = child;
            }
            else
            {
                res = child.GetChildForever(childName);
            }

            if (res != null)
            {
                return res;
            }
        }

        return null;
    }
}

public class Lesson9_1_1 : MonoBehaviour
{

    public string ChildName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.SortChildObjectsByNameLength();

        #region 找任意层子对象
        Transform child = this.transform.GetChildForever(ChildName);
        if (child != null)
        {
            print(child.name);
        }
        else
        {
            print($"没有找到名为{ChildName}的子对象");
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
