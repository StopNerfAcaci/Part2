using UnityEngine;
using UnityEngine.UI;
public class LevelMatch : LevelCondition
{
    private BoardController m_board;
    public override void Setup(float value, Text txt, BoardController board)
    {
        base.Setup(value, txt);

        m_board = board;

        m_board.OnMatchEvent += OnMatch;

        UpdateText();
    }

    private void OnMatch()
    {
        if (m_conditionCompleted) return;
        UpdateText();
        if(m_board.IsWinGame() || m_board.IsLoseGame())
        {
            OnConditionComplete();
            return;
        }
    }

    protected override void OnDestroy()
    {
        if (m_board != null) m_board.OnMoveEvent -= OnMatch;

        base.OnDestroy();
    }
}