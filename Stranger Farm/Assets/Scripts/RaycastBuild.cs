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

    public List <Transform> ObjToMove;
    public GameObject cerca;
    public GameObject cercaQuina;
    public LayerMask mask;
    int lastPositionX, lastPositionY, lastPositionZ;
    Vector3 mousePos;

    bool cercaPadrao = true;
    bool cercaQuinaPadrao = false;

    bool cercaVer = false;
    bool cercaQuinaRotate = true;
    bool cercaQuinaRotate1 = false;
    bool cercaQuinaRotate2 = false;
    int rotateCer = 0;

    private void Update()
    {
        mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
        {
            int posX = (int)Mathf.Round(hit.point.x);
            int posZ = (int)Mathf.Round(hit.point.z);

            if (cercaPadrao == true && posX != lastPositionX || cercaPadrao == true && posZ != lastPositionZ)
            {
                lastPositionX = posX;
                lastPositionZ = posZ;
                ObjToMove[0].position = new Vector3(posX, 0.77f, posZ);
            }
            if (cercaQuinaPadrao == true && posX != lastPositionX || cercaQuinaPadrao == true && posZ != lastPositionZ)
            {
                lastPositionX = posX;
                lastPositionZ = posZ;
                ObjToMove[1].position = new Vector3(posX, 0.77f, posZ);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                cercaVer = !cercaVer;
                cercaPadrao = true;
                cercaQuinaPadrao = false;
            }

            if (Input.GetMouseButtonDown(0) && cercaVer == false)
            {
                Instantiate(cerca, ObjToMove[0].position, Quaternion.Euler(-90f, 0f, 0f));                  
            }

            if (Input.GetMouseButtonDown(0) && cercaVer == true)
            {
                Instantiate(cerca, ObjToMove[0].position, Quaternion.Euler(-90f, -90f, 0f));
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                cercaPadrao = false;
                cercaQuinaPadrao = true;
                rotateCer -= 90;
            }

            if (Input.GetMouseButtonDown(0) && cercaQuinaPadrao == true)
            {
                Instantiate(cercaQuina, ObjToMove[1].position, Quaternion.Euler(-90f, rotateCer, 0f));
            }

        }
        
    }
}
