/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns;

public class SplashScreen : MonoBehaviour
{
    public GameObject SpriteLogo;
    public AudioClip audiologo;
    public enum SplashStates
    {
        FADE_IN = 0,
        PLAY_AUDIO,
        FADE_OUT,
    }

    private FSM m_fsm = new FSM();
    // Start is called before the first frame update
    void Start()
    {
        m_fsm.Add((int)SplashStates.FADE_IN, new Fade(m_fsm, this));

        m_fsm.Add((int)SplashStates.PLAY_AUDIO, new PlayAudio(m_fsm, this));

        m_fsm.Add((int)SplashStates.FADE_OUT, new Fade(m_fsm, this, Fade.FadeType.FADE_OUT));

        m_fsm.SetCurrentState(m_fsm.GetState((int)SplashStates.FADE_IN));
    }

    // Update is called once per frame
    void Update()
    {

        if (m_fsm != null)
        {
            m_fsm.Update();
        }
    }

    public class Fade : State
    {
        public float Duration { get; set; } = 2.0f;
        private float deltaTime = 0.0f;
        private FadeType m_fadeType;
        private SpriteRenderer m_spriteRenderer;
        private SplashScreen m_splash;
        public enum FadeType
        {
            FADE_IN,
            FADE_OUT,
        }

        public Fade(FSM fsm, SplashScreen splash, FadeType fadeType = FadeType.FADE_IN) : base(fsm)
        {
            m_splash = splash;
            m_spriteRenderer =
            splash.SpriteLogo.GetComponent<SpriteRenderer>();
            m_fadeType = fadeType;
        }

        public override void Enter()
        {
            deltaTime = Time.deltaTime;
            base.Enter();
            switch (m_fadeType)
            {
                case FadeType.FADE_IN:
                    Debug.Log("Entering: FadeIn State");
                    break;

                case FadeType.FADE_OUT:
                    Debug.Log("Entering: FadeOut State");
                    break;
            }
        }

        public override void Update()
        {
            deltaTime += Time.deltaTime;
            if (deltaTime > Duration)
            {
                switch (m_fadeType)
                {
                    case FadeType.FADE_IN:
                        int nextid =
                        (int)SplashScreen.SplashStates.PLAY_AUDIO;
                        State nextState = m_fsm.GetState(nextid);
                        m_fsm.SetCurrentState(nextState);
                        break;

                    case FadeType.FADE_OUT:
                        m_splash.Exit();
                        break;
                }
            }
            if (m_spriteRenderer != null)
            {
                switch (m_fadeType)
                {
                    case FadeType.FADE_IN:
                        m_spriteRenderer.material.color = new Color(1.0f, 1.0f, 1.0f, deltaTime / Duration);
                        break;

                    case FadeType.FADE_OUT:
                        m_spriteRenderer.material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f - deltaTime / Duration);
                        break;
                }
            }
        }
    }

    public class PlayAudio : State

    {
        public float Duration { get; set; } = 1.0f;
        private float deltaTime = 0.0f;
        private SplashScreen m_splash;
        public PlayAudio(FSM fsm, SplashScreen splash) : base(fsm)
        {
            m_splash = splash;
        }

        public override void Enter()
        {
            deltaTime = Time.deltaTime;
            m_splash.GetComponent<AudioSource>().PlayOneShot(m_splash.audiologo);
            base.Enter();
            Debug.Log("Entering: PlayAudio State");
        }

        public override void Update()
        {
            deltaTime += Time.deltaTime;
            if (deltaTime > 1.0f)
            {
                int nextId = (int)SplashScreen.SplashStates.FADE_OUT;
                State nextState = m_fsm.GetState(nextId);
                m_fsm.SetCurrentState(nextState);
            }
        }
    }

    public void Exit()

    {
        Debug.Log("Splash screen with FSM has exited.");
        m_fsm = null;
    }
}*/