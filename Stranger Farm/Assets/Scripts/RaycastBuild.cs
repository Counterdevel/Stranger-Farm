using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastBuild : MonoBehaviour
{
    public Transform ObjToMove;
    public GameObject cercaHor;
    public GameObject cercaVer;
    public GameObject cercaQuina;
    public LayerMask mask;
    int lastPositionX, lastPositionY, lastPositionZ;
    Vector3 mousePos;

    private void Update()
    {
        mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
        {
            int posX = (int)Mathf.Round(hit.point.x);
            int posY = (int)Mathf.Round(hit.point.y);
            int posZ = (int)Mathf.Round(hit.point.z);

            if(posX != lastPositionX || posY != lastPositionY || posZ != lastPositionZ)
            {
                lastPositionX = posX;
                lastPositionY = posY;
                lastPositionZ = posZ;
                ObjToMove.position = new Vector3(posX, posY + .5f, posZ);
            }

            if(Input.GetMouseButtonDown(0))
            {
                Instantiate(cercaHor, ObjToMove.position, Quaternion.Euler(-90f, 0f, 0f));
            }
            if(Input.GetMouseButtonDown(1))
            {
                Instantiate(cercaHor, ObjToMove.position, Quaternion.Euler(-90f, -90f, 0f));
            }
            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(cercaQuina, ObjToMove.position, Quaternion.Euler(-90f, 0f, 0f));
            }
        }
    }
}
