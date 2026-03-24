using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    void Start()
    {
        int playerHp = 100;

        // 1. 일반 정보 로그 (흰색 텍스트)
        Debug.Log("게임이 정상적으로 시작되었습니다.");
        Debug.Log($"플레이어의 체력이 {playerHp}로 설정되었습니다."); // $ 표시를 붙이면 변수값을 문장 안에 쉽게 넣을 수 있습니다.

        // 2. 경고 로그 (노란색 느낌표 아이콘)
        Debug.LogWarning("주의: 입력된 HP 값이 비정상적이라 기본값으로 맞췄습니다.");

        // 3. 에러/오류 로그 (빨간색 엑스표 아이콘)
        Debug.LogError("치명적 오류: 플레이어 데이터를 불러오지 못했습니다. 즉시 확인하세요!");
    }
}
