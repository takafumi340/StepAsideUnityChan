using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    //カメラのオブジェクトを入れる
    private GameObject maincamera;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のMain Cameraオブジェクトを取得する
        this.maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //画面外に出たアイテムを削除する
        if (maincamera.transform.position.z > this.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
