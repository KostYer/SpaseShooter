using System;
using UnityEngine;
using UnityEngine.UI;

namespace Modules.Game.UI
{
    public class GamePlayUIView : MonoBehaviour, IGamePlayUIView
    {
        [SerializeField]
        Text m_ScoresTextField = default;

        [SerializeField]
        Text m_HighScoreTextField = default;

        [SerializeField]
        Text m_FinalTextField = default;

        //[SerializeField]
        //Text m_LivesTextField = default;

        [SerializeField]
        GameObject m_GamePlayPanel = default;

        [SerializeField]
        GameObject m_GameOverPanel = default;

        [SerializeField]
        Button m_RestartButton = default;
        [SerializeField]
        Button m_QuitButton = default;

        public event Action OnRestartRequest;
        public event Action OnQuitRequest;
        private int score;

        void Awake()
        {
            m_RestartButton.onClick.AddListener(() =>
            {
                OnRestartRequest?.Invoke();
            });



        }

        public void SetScore(int score)
        {
            m_ScoresTextField.text = $"Score: {score}";
            this.score = score;
        }

        //public void SetLivesCount(int total, int count)
        //{
        //    m_LivesTextField.text = $"Life: {count} / {total}";
        //}
        
        public void ShowGamePlayUI()
        {
            m_GamePlayPanel.SetActive(true);
            m_GameOverPanel.SetActive(false);
        }

        public void ShowGameOverScreen()
        {
            m_GamePlayPanel.SetActive(false);
            m_GameOverPanel.SetActive(true);
        }

        public void OnGameOver(int score, int highScore)
        {
            m_HighScoreTextField.text = $"High Score: {highScore}";
            m_FinalTextField.text = $"Your Score: {score}";
        }

         

        

    }
}
