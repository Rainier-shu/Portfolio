using UnityEngine;

public class Lesson4_2_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Tank;

    public GameObject ActionGO;

    public enum Action
    {
        ChangeName,
        Disabled,
        Destroy,
        DestroyImmediate
    }

    public Action ActNow;

    void Start()
    {
        GameObject tank = Instantiate(Tank);
        tank.name = "新实例化的坦克";

        //让某一脚本Lesson4_2_2失活
        //Lesson4_2_2 les2 = GameObject.FindAnyObjectByType<Lesson4_2_2>();
        //les2.enabled = false;

        //让指定游戏对象挂载的脚本Lesson4_2_2失活
        //GameObject les4_2_2 = GameObject.Find("Lesson4_2_2");
        //Lesson4_2_2 les2 = les4_2_2.GetComponent<Lesson4_2_2>();
        //les2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //让Lesson4_2_2对象实现不同效果
        if (ActionGO != null)
        {
            switch (ActNow)
            {
                case Action.ChangeName:
                    ActionGO.name += "改尾缀";
                    break;
                case Action.Disabled:
                    ActionGO.SetActive(false);
                    break;
                case Action.Destroy:
                    Destroy(ActionGO, 5);
                    break;
                case Action.DestroyImmediate:
                    DestroyImmediate(ActionGO);
                    break;
            }
        }
    }
}
