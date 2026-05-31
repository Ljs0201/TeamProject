using UnityEngine;
using TMPro; // TextMeshPro를 사용할 경우 필수

public class StageManager : MonoBehaviour
{
    // 메인 화면에 있는 스테이지 글자 오브젝트를 연결할 곳
    public TextMeshProUGUI stageText;

    // 맵 팝업창 오브젝트 (입장 후 자동으로 닫히게 하기 위함)
    public GameObject mapPopup;

    // 이 함수가 버튼을 눌렀을 때 실행될 핵심 기능입니다!
    public void ChangeStage(string stageName)
    {
        // 1. 메인 화면의 텍스트를 전달받은 스테이지 이름으로 변경
        stageText.text = "스테이지 " + stageName;

        // 2. 스테이지를 골랐으니 맵 선택 팝업창은 자동으로 닫기
        if (mapPopup != null)
        {
            mapPopup.SetActive(false);
        }
    }
}