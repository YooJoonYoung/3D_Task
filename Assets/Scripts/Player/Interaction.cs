using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    public float checkRate = 0.05f; //��ȣ�ۿ� �ֱ�
    private float lastCheckTime; //��ȣ�ۿ� Ȯ�νð�
    public float maxCheckDistance; //��ȣ�ۿ� �ִ�Ÿ�
    public LayerMask layerMask;

    public GameObject curInteractGameObject; //��ȣ�ۿ��Ұ��ӿ�����Ʈ
    private IInteractable curInteractable;

    public TextMeshProUGUI promptText;
    private Camera camera;

    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastCheckTime > checkRate)
        {
            lastCheckTime = Time.time;

            Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maxCheckDistance, layerMask))
            {
                if (hit.collider.gameObject != curInteractGameObject)
                {
                    curInteractGameObject = hit.collider.gameObject;
                    curInteractable = hit.collider.GetComponent<IInteractable>();
                    SetPromptText();
                }
            }
            else
            {
                curInteractGameObject = null;
                curInteractable = null;
                promptText.gameObject.SetActive(false);
            }
        }
    }

    private void SetPromptText() //��ȣ�ۿ� ���� ������Ʈ������ ������Ʈ �ؽ�Ʈ Ȱ��ȭ
    {
        promptText.gameObject.SetActive(true);
        promptText.text = curInteractable.GetInteractPrompt();
    }

    public void OnInteractInput(InputAction.CallbackContext context) //��ȣ�ۿ� �Է� �Լ�
    {
        if (context.phase == InputActionPhase.Started && curInteractable != null)
        {
            curInteractable.OnInteract(); //����
            curInteractGameObject = null;
            curInteractable = null;
            promptText.gameObject.SetActive(false); //�ؽ�Ʈ �����
        }
    }
}