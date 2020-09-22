using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.Experimental.VFX;

public class VFXController : MonoBehaviour
{

    private VisualEffect visualEffect;
    public static readonly string SPAWN_RATE_NAME = "spawn rate";

    private GameObject timeController;
    private bool currentStatus;
    private int spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        timeController = GameObject.Find("TimeController");
        currentStatus = timeController.GetComponent<TimeController>().currentStatus();
        visualEffect = GetComponent<VisualEffect>();
        spawnRate = 100;
        visualEffect.SendEvent("OnPlay");

    }

    // Update is called once per frame
    void Update()
    {
        //　マウスの右ボタンを押したら停止
        if (Input.GetKey(KeyCode.O))
        {
            Debug.Log("パーティクルストップ");
            visualEffect.SendEvent("OnStop");
            //　マウスの中ボタンを押したら生成
        }
        else if (Input.GetKey(KeyCode.P))
        {
            Debug.Log("パーティクル生成");
            visualEffect.SendEvent("OnPlay");
            //visualEffect.Play();
        }

        bool tmpStatus = timeController.GetComponent<TimeController>().currentStatus();
        // フラグが変更された直後に初期化
        if (currentStatus != tmpStatus)
        {
            spawnRate = 100;
            currentStatus = tmpStatus;
        }
        if (currentStatus) { if (spawnRate > 0) { spawnRate -= 1;  } }
        if (!currentStatus) { spawnRate = 0; }
        visualEffect.SetInt(SPAWN_RATE_NAME, spawnRate);

        /*
        bool tmpStatus = timeController.GetComponent<TimeController>().currentStatus();
        if(currentStatus != tmpStatus)
        {
            currentStatus = tmpStatus;
            Debug.Log(currentStatus);
            if (currentStatus) {
                visualEffect.SetInt(SPAWN_RATE_NAME, 100);
                //visualEffect.SendEvent("OnStop");
            }
            if (!currentStatus) {
                visualEffect.SetInt(SPAWN_RATE_NAME, 0);
            }
        }
        */

    }
}
