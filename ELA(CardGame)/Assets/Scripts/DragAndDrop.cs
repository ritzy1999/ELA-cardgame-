using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    private bool _mouseState;
    private GameObject target, last_target;
    public Vector3 screenSpace;
    public Vector3 offset;
    
    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo;
            target = GetClickedObject(out hitInfo);
            if (target != null) 
            {
                Debug.Log(target.name);
                _mouseState = true;
                screenSpace = Camera.main.WorldToScreenPoint(target.transform.position);
                offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            _mouseState = false;
        }
        if (_mouseState && target.tag != "Borders")
        {
            var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
            
            var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
            
            target.transform.position = curPosition;
        }
    }


    GameObject GetClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            target = hit.collider.gameObject;
        }

        return target;
    }
}