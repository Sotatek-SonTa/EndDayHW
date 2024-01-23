using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRotate : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        worldPosition = RotateManager.Instance.MouseWorldPos;
        Vector2 direction = new Vector2(worldPosition.x - transform.position.x, worldPosition.y - transform.position.y);
        Debug.Log(direction);
        transform.up = direction;
    }
}
