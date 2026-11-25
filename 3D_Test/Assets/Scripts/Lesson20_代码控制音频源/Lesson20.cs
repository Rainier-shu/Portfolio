using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Lesson20 : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject obj;
    public AudioClip ac;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        #region 知识点三 如何动态控制音效播放
        //1.直接在要播放音效的对象上挂载脚本 控制播放(就像此脚本知识点一的示例一样)

        //2.实例化挂载了音效脚本的游戏对象(音效脚本需配置唤醒时播放)
        //由于需要管理游戏对象的销毁等内容，用的比较少
        //GameObject.Instantiate(obj);

        //3.用一个AudioSource来控制播放不同的音效
        //一个GameObject可以挂载多个AudioSource
        //挂载多个AudioSource时，一定要能区分它们，控制它们的播放、停止
        AudioSource aus = this.gameObject.AddComponent<AudioSource>();
        aus.clip = ac;
        aus.Play();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点一 代码控制播放停止
        if (Input.GetKeyDown(KeyCode.P))
        {
            //播放音频
            //audioSource.Play();
            //延迟播放音频，单位为秒
            audioSource.PlayDelayed(3);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //停止音频
            //再Play时会从头播放
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //暂停音频
            audioSource.Pause();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //取消暂停音频
            //在暂停播放后的执行效果与Play一致
            audioSource.UnPause();
        }
        #endregion

        #region 知识点二 如何检测音效播放完毕
        //如果需要在一个音频播放完毕后 执行某个逻辑
        //可以在Update中不停检测isPlaying属性来实现(配合一个开始播放标记可保证准确性)
        if (audioSource.isPlaying)
        {
            print("播放中");
        }
        else
        {
            print("未处于播放中");
        }
        #endregion
    }
}
