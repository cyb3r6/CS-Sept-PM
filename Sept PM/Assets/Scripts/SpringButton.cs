using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SpringButton : MonoBehaviour
{
    public Light light;
    private bool enable;
    public GameObject videoPlane;
    private VideoPlayer video;

    private void Start()
    {
        video = videoPlane.GetComponent<VideoPlayer>();
        enable = false;

        videoPlane.SetActive(enable);

        video.loopPointReached += EndVideo;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SpringButton")
        {
            light.enabled = !light.enabled;
            enable = !enable;


            videoPlane.SetActive(enable);

            if(enable == false)
            {
                video.Pause();
            }
            else
            {
                video.Play();
            }

            

        }
    }

    void EndVideo(VideoPlayer vp)
    {
        vp.Stop();
        videoPlane.SetActive(false);
    }
}
