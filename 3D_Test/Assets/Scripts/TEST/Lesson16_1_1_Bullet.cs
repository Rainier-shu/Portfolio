using Unity.VisualScripting;
using UnityEngine;

public class Lesson16_1_1_Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject Gun;
    void Start()
    {
        Gun = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Time.deltaTime * 10 * Vector3.forward);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Plane")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
