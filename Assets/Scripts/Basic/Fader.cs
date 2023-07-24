using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private Coroutine _fadeInJob;

    private void Awake()
    {
        _fadeInJob = StartCoroutine(FadeIn(0.1f));
    }

    private void StopFadeIn()
    {
        StopCoroutine(_fadeInJob);
    }

    //public void StartFadeIn()
    //{
        //Coroutine fadeInJob = StartCoroutine(FadeIn());
    //}

    private IEnumerator FadeIn(float delayTime)
    {
        yield return null;

        if (Color.black == _renderer.color)
        {
            StopFadeIn();
        }
        Color color = _renderer.color;
        WaitForSeconds delay = new(delayTime);

        for (int i = 0; i < 255; i++)
        {
            color.a = 1f - (1f / 255 * i);
            _renderer.color = color;

            yield return delay;
            //todo
        }
    }
}
