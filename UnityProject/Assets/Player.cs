using UnityEngine;

public class Player : MonoBehaviour
{
    #region 宣告
    [Header("血量")]
    public float Hp = 100;
    [Header("攻擊力")]
    public float Atk = 0;
    [Header("殭屍")]
    public Zombie zb;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;
    #endregion

    public void Attack()
    {
        Atk = Random.Range(30f, 36f);
        print("<color=darkblue>玩家受到傷害: </color>" + Atk);
    }

    public void Hurt()
    {
        Hp -= Atk;
        print("<color=darkblue>玩家剩下血量: </color>" + Hp);

    }

    public void Dead()
    {
        print("<color=darkblue>玩家死亡</color>");
    }

    private void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            Attack();
            Hurt();
            if (Hp <= 0)
            {
                Dead();
            }
        }

    }

}
