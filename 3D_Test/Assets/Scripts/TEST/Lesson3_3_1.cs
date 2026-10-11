using UnityEngine;

public class Lesson3_3_1 : MonoBehaviour
{
    public Lesson3_3_2 AnotherSC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        #region 同挂载对象的另一脚本失活
        Lesson3_3_2 item1;
        if (TryGetComponent<Lesson3_3_2>(out item1))
        {
            item1.enabled = false;
        }
        #endregion

        #region 失活另一个GameObject挂载的脚本
        AnotherSC.enabled = false;
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}
