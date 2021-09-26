using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Camera cam;
    [SerializeField] Animator _playerRightAnimator;
    [SerializeField] Animator _playerLeftAnimator; 

    void Start() {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // if we left click
        if(Input.GetMouseButtonDown(0)) {
            _playerRightAnimator.Play("Attack");
            //_playerRightAnimator.SetInteger("attackindex",1);
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100)) {
                
            }
        }

        // if we right click
        if(Input.GetMouseButtonDown(1)) {
            _playerLeftAnimator.Play("Magic Attack");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)) {

                //Fire projectile
            }
        }
    }
}
