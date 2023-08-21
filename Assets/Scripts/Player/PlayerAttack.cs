using Photon.Pun;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform _weaponMuzzle;
    [SerializeField] private Projectile _projectilePrefab;
    [SerializeField] private float _attackTime;
    
    public void PerformAttack()
    {
        if (_attackTime <= 0)
        {
            PhotonNetwork.Instantiate(_projectilePrefab.name, _weaponMuzzle.position, _weaponMuzzle.rotation);
        }
        else
        {
            _attackTime -= Time.deltaTime;
        }
    }
    
}
