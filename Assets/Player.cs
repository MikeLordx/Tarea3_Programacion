using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Light _light;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.collider.tag == "spheres")
                {
                    Debug.Log("I hit a sphere");
                    _light.GetComponent<Light>().cullingMask = 8;
                }
                if (hit.collider.tag == "cubes")
                {
                    Debug.Log("I hit a cube");
                    _light.GetComponent<Light>().cullingMask = 80;
                }
                if (hit.collider.tag == "capsules")
                {
                    Debug.Log("I hit a capsule");
                    _light.GetComponent<Light>().cullingMask = 150;
                }
            }
        }
    }
}
