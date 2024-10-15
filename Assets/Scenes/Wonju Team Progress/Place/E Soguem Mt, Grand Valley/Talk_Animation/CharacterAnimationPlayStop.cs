using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationPlayStop : MonoBehaviour
{
    private Animator myAnim;
    private bool isTalking = true; // �⺻���� true�� ����
    public AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myAnim.SetBool("Talk", isTalking); // �ʱ� �ִϸ��̼� ���� ����
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = 1.0f;
        myAudioSource.Play(); // ó�� ���� �� BGM ����� ���
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // ���콺 ���� ��ư Ŭ�� ��
        {
            isTalking = !isTalking; // ���� ��ȯ
            myAnim.SetBool("Talk", isTalking); // �ִϸ��̼� ���� ������Ʈ

            if (isTalking)
            {
                if (!myAudioSource.isPlaying) // �Ҹ��� ��� ������ ���� ���� ���
                {
                    myAudioSource.Play(); // Talking ������ �� �Ҹ� ���
                }
            }
            else
            {
                myAudioSource.Pause(); // Talking ���°� �ƴ� �� �Ҹ� �Ͻ� ����
            }
        }

        // �Ҹ��� ������ �ִϸ��̼� ���¸� ����
        if (!myAudioSource.isPlaying && isTalking)
        {
            isTalking = false; // Talking ���¸� false�� ����
            myAnim.SetBool("Talk", isTalking); // �ִϸ��̼� ���� ������Ʈ
        }
    }
}
