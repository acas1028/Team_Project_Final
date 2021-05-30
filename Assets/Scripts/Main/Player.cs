using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    CharacterController characterController;
    Animator animator;

    public Transform cameraTransform;
    public Camera cam;

    //public bool isGround;

    public float gravity;
    public float jumpPower;

    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();

        moveSpeed = 5.0f;
        rotationSpeed = 360.0f;
        gravity = 9.81f;
        jumpPower = 100.0f;

        GameManager.Instance.interactCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //moveDirection = transform.TransformDirection(moveDirection);
        
        //if (characterController.isGrounded)
        //{
        //    isGround = false;
        //}

        if (moveDirection.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(transform.forward, moveDirection,
                rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, moveDirection));
            transform.LookAt(transform.position + forward);
            animator.SetBool("Walk_Anim", true);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = 15.0f;
                animator.SetBool("Walk_Anim", false);
                animator.SetBool("Roll_Anim", true);
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                moveSpeed = 5.0f;
                animator.SetBool("Roll_Anim", false);
                animator.SetBool("Walk_Anim", true);
            }
        }
        else
            animator.SetBool("Walk_Anim", false);

        //if (!isGround)
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        moveDirection.y = jumpPower;
        //        isGround = true;
        //        Debug.Log("Jump");
        //    }
        //}
        moveDirection.y -= gravity * 35.0f * Time.deltaTime;

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BW_Object")

        {
            if (GameManager.Instance.count <= 1)
            {
                if (other.GetComponent<CircleObject>().isLighting != GameManager.Instance.answerStage[0] && other.name != "Sphere1")
                {
                    other.gameObject.SetActive(false);
                    GameManager.Instance.destroyCount++;
                }
                else if (other.GetComponent<CircleObject>().isLighting != GameManager.Instance.answerStage[0] && other.name != "Sphere1")
                {
                    GameManager.Instance.life--;
                }

                if (other.name == "Sphere1")
                {
                    other.GetComponent<CircleObject>().Change();
                }
            }
            else
                other.GetComponent<CircleObject>().Change();
        }

        if (other.tag == "AnswerObject")
        {
            GameManager.Instance.interactCheck = true;
            GameManager.Instance.CheckAnswer();
        }

        if (other.tag == "Last")
        {
            if (GameManager.Instance.checkStage[0] == 1)
            {
                for (int i = 0; i < 25; i++)
                {
                    GameManager.Instance.answerStage[i]=2;
                }
            }
            else if (GameManager.Instance.checkStage[0] == 2)
            {
                for (int i = 0; i < 25; i++)
                {
                    GameManager.Instance.answerStage[i] = 1;
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "AnswerObject")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (GameManager.Instance.CheckAnswer())
                {
                    GameManager.Instance.count--;
                    GameManager.Instance.SetAnswer();
                }
                else
                {
                    GameManager.Instance.life--;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "AnswerObject")
        {
            GameManager.Instance.interactCheck = false;
        }
    }
}
