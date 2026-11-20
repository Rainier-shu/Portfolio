using UnityEngine;

public class Lesson15_1_1 : MonoBehaviour
{
    //public Light PointLight;
    //private bool IsPointNeedStronger;
    public Light DireLight;
    public float DireChangeSpeed;
    private float DireChange;
    //private bool IsDireNeedStronger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DireChange = Time.deltaTime * DireChangeSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        print(Time.deltaTime * DireChangeSpeed);
        if (DireLight.intensity >= 1)
        {
            DireChange = -Time.deltaTime * DireChangeSpeed;
        }
        else if (DireLight.intensity <= 0)
        {
            DireChange = Time.deltaTime * DireChangeSpeed;
        }
        DireLight.intensity += DireChange;
    }
}
