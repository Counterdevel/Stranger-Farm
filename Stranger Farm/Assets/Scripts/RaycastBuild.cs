using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastBuild : MonoBehaviour
{
    public static RaycastBuild Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    public Transform ObjToMove;
    public GameObject cerca;
    public GameObject cercaQuina;
    public LayerMask mask;
    int lastPositionX, lastPositionY, lastPositionZ;
    Vector3 mousePos;

    bool cercaRotate = true;

    private void Update()
    {
        mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
        {
            int posX = (int)Mathf.Round(hit.point.x);
            int posZ = (int)Mathf.Round(hit.point.z);

            if (posX != lastPositionX || posZ != lastPositionZ)
            {
                lastPositionX = posX;
                lastPositionZ = posZ;
                ObjToMove.position = new Vector3(posX, 0.77f, posZ);
            }

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(cerca, ObjToMove.position, Quaternion.Euler(-90f, 0f, 0f));                  
            }

            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Instantiate(cerca, ObjToMove.position, Quaternion.Euler(-90f, -90f, 0f));
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(cercaQuina, ObjToMove.position, Quaternion.Euler(-90f, 0f, 0f));
            }

        }
        
    }
}
