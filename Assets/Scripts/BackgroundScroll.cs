using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Material mat;

    void Start()
    {
        // MeshRenderer 컴포넌트에서 Material을 가져와 변수에 저장합니다.
        mat = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        // 시간에 따라 지속적으로 증가하는 offset 값을 계산합니다.
        float offset = Time.time * scrollSpeed;
        
        // URP Lit 셰이더의 표면(Base Map) 오프셋 X값을 계산한 값으로 업데이트합니다.
        mat.SetTextureOffset("_BaseMap", new Vector2(offset, 0));
    }

}
