using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Button _menuButton;

    [SerializeField] private Transform _buttonsAnimationStartPoint;
    [SerializeField] private List<Button> _buttons;
    [SerializeField] private List<TMP_Text> _buttonsTitles;
    [SerializeField] private List<Transform> _buttonsAnimationEndPoints;

    private bool _isMenuButtonClicked;

    private void Start()
    {
        _menuButton.onClick.AddListener(delegate { MenuButtonClick(); });
        ButtonsAnimationIdleState();

        for (int i = 0; i < _buttons.Count; i++)
        {
            var _currentButton = _buttons[i];
            var _currentObject = PlaneHandler.instance._ObjectsToPlace[i];
            var _currentIndex = i;
            _buttons[i].onClick.AddListener(delegate { SetObject(_currentObject, _currentIndex); });
        }
    }

    private void MenuButtonClick()
    {
        if (!_isMenuButtonClicked)
            ShowButtons();
        else if (_isMenuButtonClicked)
            HideButtons();

        _isMenuButtonClicked = !_isMenuButtonClicked;
    }

    private void ButtonsAnimationIdleState()
    {
        for (int i = 0; i < _buttonsTitles.Count; i++)
            _buttonsTitles[i].DOFade(0, 0f)
            .OnComplete(() =>
            {
                for (int i = 0; i < _buttons.Count; i++)
                    _buttons[i].gameObject.SetActive(false);
            });
    }

    private void ShowButtons()
    {
        for (int i = 0; i < _buttons.Count; i++)
        {
            _buttons[i].gameObject.SetActive(true);
            _buttons[i].transform.DOMove(new Vector3(_buttonsAnimationEndPoints[i].position.x, _buttonsAnimationEndPoints[i].position.y, _buttonsAnimationEndPoints[i].position.z), 0.5f)
            .OnPlay(() =>
            {
                for (int i = 0; i < _buttons.Count; i++)
                {
                    _buttons[i].transform.DOScaleX(1f, 0.5f);
                    _buttons[i].transform.DOScaleY(1f, 0.5f);
                }

                for (int i = 0; i < _buttonsTitles.Count; i++)
                    _buttonsTitles[i].DOFade(1, 1f);
            });
        }
    }

    private void HideButtons()
    {
        for (int i = 0; i < _buttonsTitles.Count; i++)
            _buttonsTitles[i].DOFade(0, 1f).OnPlay(() =>
            {
                for (int i = 0; i < _buttons.Count; i++)
                    _buttons[i].transform.DOMove(new Vector3(_buttonsAnimationStartPoint.position.x, _buttonsAnimationStartPoint.position.y, _buttonsAnimationStartPoint.position.z), 0.5f).OnPlay(() => {
                        for (int i = 0; i < _buttons.Count; i++)
                        {
                            _buttons[i].transform.DOScaleX(0.5f,0.5f);
                            _buttons[i].transform.DOScaleY(0.5f,0.5f);
                        }
})
                    .OnComplete(() =>
                    {
                        for (int i = 0; i < _buttons.Count; i++)
                            _buttons[i].gameObject.SetActive(false);
                    });
            });
    }

    private void SetObject(ObjectsTransformHandler _objectToPlace, int _index)
    {
        PlaneHandler.instance.SetObjectToPlaceIndex(_index);
    }
}