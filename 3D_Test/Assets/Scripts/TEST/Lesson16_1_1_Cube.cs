using Unity.VisualScripting;
using UnityEngine;

public class Lesson16_1_1_Cube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int Life = 3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Bullet")
        {
            if (--Life <= 0)
            {
                GameObject.Destroy(gameObject);
            }
        }
    }
}
