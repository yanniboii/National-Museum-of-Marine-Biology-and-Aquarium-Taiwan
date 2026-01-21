using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem target;

    [SerializeField]
    private float duration = 5f;

    private float timer;
    private bool hasTriggered;

    void Start()
    {
        timer = duration;

        if (target != null)
        {
            target.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
    }

    void Update()
    {
        if (hasTriggered)
            return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            hasTriggered = true;
            target.Play();
        }
    }
}

/*
Chat. (2026). Unity ParticleSystem Play/Stop lifecycle behavior.
OpenAI. https://openai.com
*/
