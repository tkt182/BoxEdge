using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject point, point02, point03, point04, point05, point06;
    private TrailRenderer trail, trail02, trail03, trail04, trail05, trail06;
    private bool animationStatus;

    // Start is called before the first frame update
    void Start()
    {
        trail = point.GetComponent<TrailRenderer>();
        trail02 = point02.GetComponent<TrailRenderer>();
        trail03 = point03.GetComponent<TrailRenderer>();
        trail04 = point04.GetComponent<TrailRenderer>();
        trail05 = point05.GetComponent<TrailRenderer>();
        trail06 = point06.GetComponent<TrailRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableTrailRender()
    {
        trail.Clear();
        trail.enabled = false;

        trail02.Clear();
        trail02.enabled = false;

        trail03.Clear();
        trail03.enabled = false;

        trail04.Clear();
        trail04.enabled = false;

        trail05.Clear();
        trail05.enabled = false;

        trail06.Clear();
        trail06.enabled = false;

        Debug.Log("Disable");
    }

    void EnableTrailRender_Frame0()
    {
        trail.Clear();
        trail.enabled = true;

        trail03.Clear();
        trail03.enabled = true;

        trail04.Clear(); 
        trail04.enabled = true;
 
        Debug.Log("Enable");
    }

    void EnableTrailRender_Frame70()
    {
        trail02.Clear();
        trail02.enabled = true;

        trail05.Clear();
        trail05.enabled = true;

        trail06.Clear();
        trail06.enabled = true;
    }
}
