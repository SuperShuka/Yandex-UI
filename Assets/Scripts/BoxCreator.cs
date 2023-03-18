using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCreator : MonoBehaviour
{
    [SerializeField] private CoinBox _coinBoxPrefab;
    [SerializeField] private Resources _resources;
    [SerializeField] private int _numberOfGoldToCreate = 3;
    [SerializeField] private float _speed = 3f;
    public Material CoinBoxMaterial;

    public void Create()
    {
        for (int i = 0; i < _numberOfGoldToCreate; i++)
        {
            CoinBox newBox = Instantiate(_coinBoxPrefab, transform.position, Quaternion.identity);
            newBox.GetComponent<Renderer>().material = CoinBoxMaterial;
            
            Vector3 velocity = Vector3.up;
            float xAngle = Random.Range(60, 30);
            float yAngle = Random.Range(0, 360);

            velocity = Quaternion.Euler(xAngle, 0, 0) * velocity;
            velocity = Quaternion.Euler(0, yAngle, 0) * velocity;
            
            newBox.Setup(velocity * _speed, _resources);
        }
    }
}
