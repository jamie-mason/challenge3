using DitzelGames.FastIK;
using UnityEngine;
using UnityEngine.PlayerLoop;
using static UnityEditor.PlayerSettings;

public class CharacterIK : MonoBehaviour
{
    protected Animator animator;
    public Vector3 footIKOffset;
    public bool activeFootIK;
    private CharacterIKHand characterIKHand;
    private MoveInput moveInput;


    private void Awake()
    {
        animator = GetComponentInParent<Animator>();
        characterIKHand = GetComponentInParent<CharacterIKHand>();
        moveInput = GetComponentInParent<MoveInput>();

        activeFootIK = true;
    }
    
    private void OnAnimatorIK(int layerIndex)
    {
        if (animator)
        {
            Vector3 p_leftFoot = animator.GetBoneTransform(HumanBodyBones.LeftFoot).position + footIKOffset;
            Vector3 p_rightFoot = animator.GetBoneTransform(HumanBodyBones.RightFoot).position + footIKOffset;
            Vector3 lHand = animator.GetBoneTransform(HumanBodyBones.LeftHand).position;
            Vector3 rHand = animator.GetBoneTransform(HumanBodyBones.RightHand).position;

            if (activeFootIK)
            {
                p_leftFoot = GetHitPoint(p_leftFoot + Vector3.up, p_leftFoot + Vector3.up * 0.5f);
                p_rightFoot = GetHitPoint(p_rightFoot + Vector3.up, p_rightFoot + Vector3.up * 0.5f);

                transform.localPosition = new Vector3 (Mathf.Abs(lHand.x - rHand.x) / 2.0f, Mathf.Abs(p_leftFoot.y - p_rightFoot.y) / 2, 0f);

                animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1.0f);
                animator.SetIKPosition(AvatarIKGoal.LeftFoot, p_leftFoot);
                animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1.0f);
                animator.SetIKPosition(AvatarIKGoal.RightFoot, p_rightFoot);
            }
            else
            {
                animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 0f);
                animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 0f);

            }


        }


    }
    public Animator GetAnimator()
    {
        return animator;
    }
    private Vector3 GetHitPoint(Vector3 start, Vector3 end)
    {
        RaycastHit hit;
        var line = Physics.Linecast(start, end, out hit);

        if (line)
        {
            return hit.point;
        }
        else
        {
            return end;
        }

    }
    

}
