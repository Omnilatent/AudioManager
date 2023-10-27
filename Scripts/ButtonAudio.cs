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
            if (buttonSound == null)
            {
                AudioManager.Instance.PlayButtonTapSfx();
            }
            else
            {
                AudioManager.Instance.PlaySfx(buttonSound);
            }
        }
    }
}