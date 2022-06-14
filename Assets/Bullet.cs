using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �e�̃��[���h���W���擾
        Vector3 pos = transform.position;

        // ��ɂ܂��������
        pos.z += 0.05f;

        // �e�̈ړ�
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        // ��苗���i�񂾂���ł���
        if (pos.z >= 20)
        {
            Destroy(this.gameObject);
        }
    }
    //�����蔻��p�֐�
    private void OnTriggerEnter(Collider other)
    {
        //�������������I�u�W�F�N�g�̃^�O��Enemy��������
        if(other.gameObject.tag == "Enemy")
        {
            //���������I�u�W�F�N�g��Enemy�X�N���v�g���Ăяo����Damage�֐������s������
            other.GetComponent<Enemy>().Damage();
        }
    }
}
