// MovieManager.cs
using UnityEngine;
using VRSetup;

namespace Managers
{
    public class MovieManager : MonoBehaviour
    {
        public VR360VideoPlayer videoPlayer; // Reference to the VR360VideoPlayer
        public GameObject environment;  // Reference to the environment that can be changed

        void Start()
        {
            // Set up initial environment or movie
            Debug.Log("Initializing VR Movie Experience");
        }

        // You can add methods to switch scenes or videos dynamically
        public void SwitchVideo(string newVideoPath)
        {
            videoPlayer.videoPath = newVideoPath;
            videoPlayer.InitializeVideoPlayer();
        }

        public void ChangeEnvironment(GameObject newEnvironment)
        {
            environment.SetActive(false); // Deactivate current environment
            newEnvironment.SetActive(true); // Activate the new environment
        }
    }
}
