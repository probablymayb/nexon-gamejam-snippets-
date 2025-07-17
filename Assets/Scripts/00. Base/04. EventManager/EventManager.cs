using System;

/// <summary>
/// �̺�Ʈ �Ŵ���: ���� �� ��� �̺�Ʈ�� �߾ӿ��� �����ϴ� �ý���
/// 
/// ����:
/// 1. �̺�Ʈ ����: EventManager.Instance.onPlayerHpChanged += �޼����;
/// 2. �̺�Ʈ �߻�: EventManager.Instance.PlayerHpChanged(��);
/// 3. ���� ����: EventManager.Instance.onPlayerHpChanged -= �޼����; (OnDestroy���� �ʼ�!)
/// 
/// ����: UI, ����, ����Ʈ ���� ���� ���������� ���� ����
///  ����: �ݵ�� OnDestroy���� ���� �����ϱ�! (�޸� ���� ����)
/// </summary>
public class EventManager : Singleton<EventManager>
{
    #region �÷��̾� ���� �̺�Ʈ

    /// <summary>
    /// �÷��̾� HP�� ����� �� �߻��ϴ� �̺�Ʈ
    /// 
    ///��� ����:
    /// - HP UI ������Ʈ
    /// - ü�� ���� �� ȭ�� ������
    /// - ü�� ȸ�� ����Ʈ
    /// 
    ///  ���� ���:
    /// EventManager.Instance.onPlayerHpChanged += UpdateHPUI;
    /// 
    ///  �߻� ���:
    /// EventManager.Instance.PlayerHpChanged(newHpValue);
    /// </summary>
    public event Action<int> onPlayerHpChanged;

    /// <summary>
    /// �÷��̾� HP ���� �̺�Ʈ�� �߻���Ű�� �޼���
    /// </summary>
    /// <param name="newHp">���ο� HP ��</param>
    public void PlayerHpChanged(int newHp)
    {
        onPlayerHpChanged?.Invoke(newHp);
    }

    #endregion

    #region ���� ���� �̺�Ʈ

    /// <summary>
    /// ������ ���� QTE �̺�Ʈ�� ���۵� �� �߻�
    /// 
    /// ��� ����:
    /// - QTE UI ǥ��
    /// - ī�޶� ����ŷ
    /// - ����� ���� ���
    /// 
    /// ���� ���:
    /// EventManager.Instance.onBossLightningQTE += StartQTE;
    /// 
    /// �߻� ���:
    /// EventManager.Instance.BossLightningQTE(2.0f); // 2�� ����
    /// </summary>
    public event Action<float> onBossLightningQTE;

    /// <summary>
    /// ���� ���� QTE �̺�Ʈ�� �߻���Ű�� �޼���
    /// </summary>
    /// <param name="duration">QTE ���� �ð� (��)</param>
    public void BossLightningQTE(float duration)
    {
        onBossLightningQTE?.Invoke(duration);
    }

    /// <summary>
    /// QTE �Ϸ� �� �߻��ϴ� �̺�Ʈ (����/���� ��� ����)
    /// 
    /// ��� ����:
    /// - ������: ���� ����, �߰� ����
    /// - ���н�: �÷��̾� ������, ���� ��ȭ
    /// 
    /// ���� ���:
    /// EventManager.Instance.onQTECompleted += OnQTEResult;
    /// 
    /// �߻� ���:
    /// EventManager.Instance.QTECompleted(true);  // ����
    /// EventManager.Instance.QTECompleted(false); // ����
    /// </summary>
    public event Action<bool> onQTECompleted;

    /// <summary>
    /// QTE �Ϸ� �̺�Ʈ�� �߻���Ű�� �޼���
    /// </summary>
    /// <param name="isSuccess">QTE ���� ���� (true: ����, false: ����)</param>
    public void QTECompleted(bool isSuccess)
    {
        onQTECompleted?.Invoke(isSuccess);
    }

    #endregion

    #region ������� �߰� �̺�Ʈ (�ʿ�� �ּ� �����ϰ� ���)

    /*
    /// <summary>
    /// ���� ���� �̺�Ʈ - ���� UI ������Ʈ��
    /// </summary>
    public event Action<int> onScoreChanged;
    public void ScoreChanged(int newScore) { onScoreChanged?.Invoke(newScore); }
    
    /// <summary>
    /// �� óġ �̺�Ʈ - ų ī��Ʈ, �޺� �ý��ۿ�
    /// </summary>
    public event Action<int> onEnemyKilled;
    public void EnemyKilled(int killCount) { onEnemyKilled?.Invoke(killCount); }
    
    /// <summary>
    /// ���� ���� �̺�Ʈ - BGM ���, UI �ʱ�ȭ��
    /// </summary>
    public event Action onGameStart;
    public void GameStart() { onGameStart?.Invoke(); }
    
    /// <summary>
    /// ���� ���� �̺�Ʈ - ��� ȭ��, ���� �����
    /// </summary>
    public event Action onGameOver;
    public void GameOver() { onGameOver?.Invoke(); }
    
    /// <summary>
    /// ������ ���� �̺�Ʈ - �κ��丮, ȿ������
    /// </summary>
    public event Action<string> onItemCollected;
    public void ItemCollected(string itemName) { onItemCollected?.Invoke(itemName); }
    */

    #endregion
}