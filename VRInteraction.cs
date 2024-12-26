// VRInteraction.cs
using UnityEngine;

namespace VRSetup
{
    public class VRInteraction : MonoBehaviour
    {
        public string interactButton = "Fire1";  // Default button for interaction (can change based on your VR hardware)
        public GameObject interactableObject;  // Object to interact with (e.g., a button or another object in the scene)

        void Update()
        {
            if (Input.GetButtonDown(interactButton))
            {
                InteractWithObject();
            }
        }

        private void InteractWithObject()
        {
            if (interactableObject != null)
            {
                Debug.Log("Interacting with object: " + interactableObject.name);
                // Example: Change the color of the object on interaction
                interactableObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
        }
    }
}
