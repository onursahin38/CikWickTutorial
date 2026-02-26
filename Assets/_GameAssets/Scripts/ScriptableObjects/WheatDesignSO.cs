using UnityEngine;

[CreateAssetMenu(fileName ="WheatDesignSO" , menuName = "ScriptableObjects/WheatDesignSO")]
public class WheatDesignSO : ScriptableObject
{  
    [SerializeField] private float _increaseDecreaseMultiplier;
    [SerializeField] private float _resetBoostDuration;
    [SerializeField] private Sprite _activeSprite;
     [SerializeField] private Sprite _passiveSprite;
      [SerializeField] private Sprite _activeWheatSprite;
       [SerializeField] private Sprite _passiveWheatSprite;

    public float IncraseDecreaseMultiplier => _increaseDecreaseMultiplier;
    public float ResetBoostDuration => _resetBoostDuration;

    public Sprite ActiveSprite => _activeSprite;
    public Sprite PassiveeSprite => _passiveSprite;

    public Sprite ActiveWheatSprite => _activeWheatSprite;
    public Sprite PassiveeWheatSprite => _passiveWheatSprite;




}
