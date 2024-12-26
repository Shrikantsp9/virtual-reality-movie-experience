// VideoUtils.cs
using UnityEngine;
using UnityEngine.Video;

namespace Utilities
{
    public static class VideoUtils
    {
        // Utility function to check if the video is playing
        public static bool IsVideoPlaying(VideoPlayer videoPlayer)
        {
            return videoPlayer.isPlaying;
        }

        // Function to pause video playback
        public static void PauseVideo(VideoPlayer videoPlayer)
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
        }

        // Function to resume video playback
        public static void ResumeVideo(VideoPlayer videoPlayer)
        {
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        }
    }
}
