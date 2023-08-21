using UnityEngine;

[CreateAssetMenu(menuName = "Config/Player Config",fileName = "Player Config", order = 0)]
public class PlayerConfig : ScriptableObject
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _moveSpeed;

    public int MaxHealth => _maxHealth;
    public float MoveSpeed => _moveSpeed;
}
