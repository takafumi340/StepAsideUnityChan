using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    //�J�����̃I�u�W�F�N�g������
    private GameObject maincamera;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������Main Camera�I�u�W�F�N�g���擾����
        this.maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //��ʊO�ɏo���A�C�e�����폜����
        if (maincamera.transform.position.z > this.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
