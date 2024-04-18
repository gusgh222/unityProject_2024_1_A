using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Tween : MonoBehaviour
{
    Sequence sequence;
    Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        // 주석 Ctrl k + c      Ctrl  k + u
        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 1));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 1));


        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce);
        //transform.DOShakeRotation(0.5f, new Vector3(0, 0, 90), 10, 90);

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(TweenEnd);  //트원이 완료되면 TweenEnd 함수 호출

        sequence = DOTween.Sequence();     //Tween을 이어서 순서대로 실행 시켜주는 단위
        sequence.Append(transform.DOMoveX(5, 1));   //Tween 실행
        sequence.SetLoops(-1, LoopType.Yoyo);       //TweenE요요형태 반복
        
    }


    void TweenEnd()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
        }
    }
}
