using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CoinBox : MonoBehaviour
{
    [SerializeField] private HitEffect _hitEffectPrefab;
    [SerializeField] private Rigidbody _rigidbody;
    private bool _isCollected = false;
    
    private Resources _resources;

    public void Setup(Vector3 velocity, Resources resources)
    {
        _rigidbody.velocity = velocity;
        _resources = resources;
    }

    public void Collect()
    {
        if (!_isCollected)
        {
            _resources.CollectCoins(1, transform.position);
            _isCollected = true;
            GetComponent<Animator>().SetTrigger("Disappear");
            Destroy(gameObject, 0.5f);
        }
    }

}
