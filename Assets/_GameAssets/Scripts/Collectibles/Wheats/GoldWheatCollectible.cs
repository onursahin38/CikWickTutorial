using UnityEngine;
using UnityEngine.UI;

public class GoldWheatCollectible : MonoBehaviour , ICollectible
{
     [SerializeField] private WheatDesignSO _wheatDesignSO;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private PlayerStateUI _playerStateUI;

    private RectTransform _playerBoosterTransform;
    private Image _playerBoosterImage;

    private void Awake()
    {
        _playerBoosterTransform = _playerStateUI .GetBoosterSpeedTransform;
        _playerBoosterImage = _playerBoosterTransform.GetComponent <Image>();
    }



    public void Collect()
    {
        _playerController.SetMovementSpeed(_wheatDesignSO.IncraseDecreaseMultiplier,_wheatDesignSO.ResetBoostDuration);

         _playerStateUI.PlayBoosterUIAnimations(_playerBoosterTransform, _playerBoosterImage,
         _playerStateUI.GetGoldBoosterWheatImage,_wheatDesignSO.ActiveSprite,_wheatDesignSO.PassiveeSprite,
         _wheatDesignSO.ActiveWheatSprite, _wheatDesignSO.PassiveeWheatSprite,_wheatDesignSO.ResetBoostDuration);
        
        Destroy(gameObject);    
        
    }



}
