using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHP = 5;
    [SerializeField] private int currentHP;

    public int CurrentHP => currentHP;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamag(int dmg)
    {
        currentHP -= dmg;
        if (currentHP <= 0)
        {
            currentHP = 0;
            GameManager.Instance.GmaeOver();
        }
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP) currentHP = maxHP;
    }






}
