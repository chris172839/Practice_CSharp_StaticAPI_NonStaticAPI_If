using UnityEngine;

public class Zombie : MonoBehaviour
{
    #region 宣告
    [Header("血量")]
    public float Hp = 100;
    [Header("攻擊力")]
    public float Atk = 0;
    [Header("玩家")]
    public Player player;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;
    #endregion

    public void Attack()
    {
        Atk = Random.Range(30f, 40f);
        print("<color=red>殭屍受到傷害: </color>" + Atk);
    }

    public void Hurt()
    {
        Hp -= Atk;
        print("<color=red>殭屍剩下血量: </color>" + Hp);

    }

    public void Dead()
    {
        print("<color=red>殭屍死亡</color>");
    }

    private void Update()
    {
        if (Input.GetKeyDown("a"))
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