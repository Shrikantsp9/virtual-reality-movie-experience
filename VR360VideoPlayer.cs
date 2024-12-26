// VR360VideoPlayer.cs
using UnityEngine;
using UnityEngine.Video;

namespace VRSetup
{
    public class VR360VideoPlayer : MonoBehaviour
    {
        public VideoPlayer videoPlayer;  // The VideoPlayer component
        public Material sphereMaterial;  // The material of the sphere where the video will be projected
        public string videoPath = "Assets/Video/Your360Movie.mp4"; // Path to your 360-degree video

        void Start()
        {
            InitializeVideoPlayer();
        }

        void Update()
        {
            UpdateVideoTexture();
        }

        // Initialize the VideoPlayer and set up the video texture
        private void InitializeVideoPlayer()
        {
            videoPlayer.url = videoPath;
            videoPlayer.renderMode = VideoRenderMode.APIOnly; // We will manually apply the texture to the sphere
            videoPlayer.Play();
        }

        // Update the texture of the sphere with the video content
        private void UpdateVideoTexture()
        {
            if (videoPlayer.isPrepared)
            {
                sphereMaterial.mainTexture = videoPlayer.texture;  // Set the video as the texture for the sphere
            }
        }
    }
}
