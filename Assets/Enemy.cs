using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy�̗͕̑ϐ�
    private int enemyHp;
    // Start is called before the first frame update
    void Start()
    {
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHp <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
        }
    }
    
    public void Damage()
    {
        // Enemy�̗̑͂�1���炷
        enemyHp = enemyHp - 1;

    }
}
