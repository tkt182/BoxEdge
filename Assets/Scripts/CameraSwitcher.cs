using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CameraSwitcher : MonoBehaviour
{
    private GameObject mainCamera;
    private GameObject subCamera;
    private bool subCameraActive;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        subCamera = GameObject.Find("Sub Camera");

        // set sub camera disable
        ChangeSubCameraStatus();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            ChangeSubCameraStatus();
        }
    }

    void ChangeSubCameraStatus()
    {
        subCamera.SetActive(!subCamera.activeSelf);
    }
}
