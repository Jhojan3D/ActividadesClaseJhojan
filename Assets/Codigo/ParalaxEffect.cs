using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    private Renderer bGRender;
    public float speed;

    private void Start()
    {
        bGRender = GetComponent<Renderer>();
    }

    private void Update()
    {
        bGRender.material.mainTextureOffset = new Vector2(0,Time.time *speed);
    }

}
