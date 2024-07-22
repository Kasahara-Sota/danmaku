using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// �Q�[�����Ǘ�����R���|�[�l���g
/// ���C�t�Ɠ��_�A������ UI �𐧌䂷��
/// �Q�[�����Ɉ�������݂����邱�ƁB
/// </summary>
public class GameManager: MonoBehaviour
{
    /// <summary>�ő僉�C�t</summary>
    [SerializeField] int _maxLife = 100;
    /// <summary>�������C�t</summary>
    [SerializeField,Range(0,100)] int _initialLife = 0;
    /// <summary>���C�t�Q�[�W</summary>
    [SerializeField] Slider _lifeGauge = default;
    /// <summary>�X�R�A��\������e�L�X�g</summary>
    [SerializeField] Text _scoreText = default;
    /// <summary>���Ԍo�߂ɂ��X�R�A���Z�̔{��</summary>
    [SerializeField] float _multiTimeScore;
    static float _score = 0;
    int _life = 0;
    void Start()
    {
        _life = _initialLife;
        Debug.Log(_score);
        AddLife(0);
        AddScore(0);
    }
    private void FixedUpdate()
    {
        
        if(_life>0)
        {
            float score = Time.deltaTime * _multiTimeScore;
            AddScore(score);
        }
        else
        {
            SceneManager.LoadScene("Result");
        }
    }
    /// <summary>
    /// ���_��ǉ����A�\�����X�V����B
    /// </summary>
    /// <param name="score">���Z���������_�B���̒l��n���ƌ��_����B���_�\���̍X�V���������������� 0 ��n���B</param>
    public void AddScore(float score)
    {
        _score += score;
        if(_scoreText!=null) 
        _scoreText.text = "SCORE:" + _score.ToString("00000000");
    }

    /// <summary>
    /// ���C�t���񕜂��A�\�����X�V����B
    /// </summary>
    /// <param name="life">�񕜂��������C�t�B���̒l��n���ƃ��C�t������B���C�t�\���̍X�V���������������� 0 ��n���B</param>
    public void AddLife(int life)
    {
        _life += life;
        if(_lifeGauge!=null)
        _lifeGauge.value = (float)_life / _maxLife;
    }
}
