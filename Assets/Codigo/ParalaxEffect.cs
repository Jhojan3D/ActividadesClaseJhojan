using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    [SerializeField] private Renderer bGRender;
    public float speed;

    private void Update()
    {
        bGRender.material.mainTextureOffset = new Vector2(0,Time.time *speed);
    }

}
