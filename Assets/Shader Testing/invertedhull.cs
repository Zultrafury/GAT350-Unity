using UnityEngine;

namespace Scenes
{
    public class invertedhull : MonoBehaviour
    {
        public Material linemat;

        public float thickness = 0.1f;

        private static readonly int Thickness = Shader.PropertyToID("_Thickness");

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            GameObject obj = new GameObject("Outline");
            obj.transform.position = transform.root.position;
            obj.transform.localScale = transform.root.localScale;
            obj.transform.rotation = transform.root.rotation;
            obj.transform.parent = transform;
            linemat.SetFloat(Thickness,thickness);
            obj.AddComponent<MeshRenderer>().material = linemat;
            obj.AddComponent<MeshFilter>().mesh = gameObject.GetComponent<MeshFilter>().mesh;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
