using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class CharacterIKHand : MonoBehaviour
{
    protected Animator animator;
    public float handIKOffsetX;
    public Vector3 handIKOffset;
    public Vector3 ChestRaycastOffset;
    public bool activeHandIK;
    public float raycastLengthMultiplier;
    public bool CanVault;
    private bool vaulting;
    private MoveInput moveInput;

    private void Awake()
    {
        animator = GetComponentInParent<Animator>();
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
        moveInput = GetComponent<MoveInput>();
    }

    private void Update()
    {

        
        
        vaulting = moveInput.getVaultProgress();
      
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (animator)
        {
            GameObject temp;
            Vector3 lHand = animator.GetBoneTransform(HumanBodyBones.LeftHand).position + handIKOffset;
            Vector3 rHand = animator.GetBoneTransform(HumanBodyBones.RightHand).position + handIKOffset;
            Vector3 chest = animator.GetBoneTransform(HumanBodyBones.Chest).position;
            Vector3 UAL = animator.GetBoneTransform(HumanBodyBones.LeftUpperArm).position;
            Vector3 UAR = animator.GetBoneTransform(HumanBodyBones.RightUpperArm).position;


            if (activeHandIK)
            {

                lHand = GetHitPoint(chest + ChestRaycastOffset, chest + ChestRaycastOffset + transform.forward);
                rHand = GetHitPoint(chest + ChestRaycastOffset, chest + ChestRaycastOffset + transform.forward);
                temp = GetHitObject(chest + ChestRaycastOffset, chest + ChestRaycastOffset + transform.forward * raycastLengthMultiplier);
                
                if (temp != null)
                {
                    CanVault = true;
                    if (vaulting)
                    {
                        lHand = new Vector3(UAL.x - handIKOffsetX, temp.transform.position.y + temp.transform.lossyScale.y / 2f, lHand.z);
                        rHand = new Vector3(UAR.x + handIKOffsetX, temp.transform.position.y + temp.transform.lossyScale.y / 2f, rHand.z);
                        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);
                        animator.SetIKPosition(AvatarIKGoal.LeftHand, lHand);
                        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1.0f);
                        animator.SetIKPosition(AvatarIKGoal.RightHand, rHand);
                        if (CanVault)
                        {
                            transform.position = new Vector3((lHand.x - rHand.x) / 2f, (lHand.y - rHand.y) / 2f, (lHand.z - rHand.z) / 2f);
                            CanVault = false;
                        }
                    }
                }
                else
                {
                    CanVault = false;
                    animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0f);
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0f);
                }           

            }
            else
            {
                animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0f);
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0f);

            }
        }
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
    private GameObject GetHitObject(Vector3 start, Vector3 end)
    {
        RaycastHit hit;
        var line = Physics.Linecast(start, end, out hit);

        if (line)
        {
            return hit.collider.gameObject;
        }
        else
        {
            return null;
        }

    }

}
