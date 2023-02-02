using UnityEngine;
using UnityEngine.UI;

namespace Omnilatent.AudioUtils
{
    public class ButtonAudio : MonoBehaviour
    {
        [SerializeField] AudioClip buttonSound;

        private void Start()
        {
            var button = GetComponent<Button>();
            if (button != null) { button.onClick.AddListener(Play); }
        }

        public void Play()
        {
            if (AudioManager.Instance != null)
            {
                AudioManager.Instance.PlayButtonTapSfx();
            }
        }
    }
}