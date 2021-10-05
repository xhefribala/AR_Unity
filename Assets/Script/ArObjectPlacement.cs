using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;



public class ArObjectPlacement : MonoBehaviour
{
    public ARSessionOrigin ar_session_origin;
    public List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    public GameObject cube;
    public GameObject instantiateCube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Detect the user touch (user taps on the screen)
        // 2. Project Recast
        // 3. Instantiate of virtual box where raycast meets the detected plane
        // 1.


        //GetMouseButton = left click in pc or Tap in smartphones

        if (Input.GetMouseButton(0))
        {

            // project raycast
            bool collision = ar_session_origin.GetComponent<ARRaycastManager>().Raycast(Input.mousePosition, raycastHits,UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon);

            // ray cast hits the detected plane
            if (collision){

                if (instantiateCube == null)
                {
                    // we instantiate  cube object in that scene if that cube object hasn't been instantiated yet
                    instantiateCube = Instantiate(cube);

                    // remobve all plane visualizer added till now
                    foreach (var plane in ar_session_origin.GetComponent<ARPlaneManager>().trackables)
                    {
                        plane.gameObject.SetActive(false);
                    }

                    ar_session_origin.GetComponent<ARPlaneManager>().enabled = false;
                }

                //only the 1st touch will be considered in case of a multi touch in screen
                instantiateCube.transform.position = raycastHits[0].pose.position;
                
            }

        }
        
    }
}
