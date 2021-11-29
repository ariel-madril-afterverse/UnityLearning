using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateRandomObjects : MonoBehaviour
{
    [SerializeField]
    private Transform _prefab;

    [SerializeField]
    private int _amount;

    [SerializeField]
    private float _radius;

    [SerializeField]
    private bool _assignRandomColors;
    
    private void OnEnable()
    {
        var block = new MaterialPropertyBlock();
        
        for (var i = 0; i < _amount; i++)
        {
            var instance = Instantiate(_prefab, transform);
            instance.position = Random.insideUnitSphere * _radius;
            instance.rotation = Random.rotation;

            if (_assignRandomColors)
            {
                var renderer = instance.GetComponentInChildren<Renderer>();
                block.SetColor("_Color", Random.ColorHSV());
                renderer.SetPropertyBlock(block);
            }
        }
    }

    private void OnDisable()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
