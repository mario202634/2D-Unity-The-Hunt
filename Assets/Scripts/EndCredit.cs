using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndCredit : MonoBehaviour
{
    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;


    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(15);//the scene that you want to load after the video has ended.
    }
}