using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMovementHelper : MonoBehaviour
{
    // private XROrigin xROrigin;
    // private CharacterController characterController;
    // private CharacterController driver;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     xROrigin = GetComponent<XROrigin>();
    //     characterController = GetComponent<CharacterController>();
    //     driver = GetComponent<CharacterControllerDriver>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     UpdateCharacterController();
    // }

        /// <summary>
        /// Updates the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
        /// based on the camera's position.
        /// </summary>
        // protected virtual void UpdateCharacterController()
        // {
        //     if (XROrigin == null || CharacterController == null)
        //         return;

        //     var height = Mathf.Clamp(XROrigin.CameraInOriginSpaceHeight, driver.MinHeight, driver.MaxHeight);

        //     Vector3 center = XROrigin.CameraInOriginSpacePos;
        //     center.y = height / 2f + CharacterController.skinWidth;

        //     CharacterController.height = height;
        //     CharacterController.center = center;
        // }
}
