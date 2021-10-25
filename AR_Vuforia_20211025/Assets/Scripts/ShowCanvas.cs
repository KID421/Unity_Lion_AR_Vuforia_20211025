using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// ��ܵe��
    /// </summary>
    public class ShowCanvas : MonoBehaviour
    {
        [Header("�e���s�դ���")]
        public CanvasGroup group;

        /// <summary>
        /// �}�l�H�J
        /// </summary>
        public void StartFade(float increase)
        {
            StartCoroutine(FadeCanvas(increase));
        }

        /// <summary>
        /// �e���H�J�G�C�j 0.1 �� �K�[ 0.1 �z���װ���Q��
        /// </summary>
        /// <param name="increase">�n�W�[�o�ȡA0.1 �H�J�A-0.1 �H�X</param>
        private IEnumerator FadeCanvas(float increase)
        {
            for (int i = 0; i < 10; i++)
            {
                group.alpha += increase;
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}