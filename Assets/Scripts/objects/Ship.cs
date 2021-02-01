using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 1f;
    public float radius = 1f;
    public Transform earthTransform;
    
    private Vector2 _pointToMoveAround;
    private float _currentAngle;
    

    // Start is called before the first frame update
    void Start()
    {
        _pointToMoveAround = earthTransform.position;
		_currentAngle += speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        _currentAngle += speed * Time.deltaTime;
        Vector2 offset = new Vector2 (Mathf.Sin (_currentAngle), Mathf.Cos (_currentAngle)) * radius;
        transform.position = _pointToMoveAround + offset;
    }

}
