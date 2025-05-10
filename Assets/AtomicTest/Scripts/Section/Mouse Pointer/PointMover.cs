using UnityEngine;


public class MousePointer: MonoBehaviour
{
    private Vector3 _mousePosition;
    private Ray _ray;
    private RaycastHit _hit;
    private Vector3 _position;
    private Vector3 _pointPosition;

    private void Awake()
    {
        _pointPosition = transform.position;
    }

    private void Update()
    {
        _mousePosition = Input.mousePosition;
        _mousePosition.z = Camera.main.nearClipPlane;
        _ray = Camera.main.ScreenPointToRay(_mousePosition);
        
        if (Physics.Raycast(_ray, out _hit, Mathf.Infinity, 3 << LayerMask.NameToLayer("Ground")))
        {
            _position = new Vector3 (_hit.point.x, _pointPosition.y, _hit.point.z);
        }
    }

    private void FixedUpdate()
    {
        transform.position = _position;
    }
}