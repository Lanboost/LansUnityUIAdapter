#region Assembly UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine
{
	public class Animator : Behaviour
	{
		public Animator() { }

		//
		// Summary:
		//     Controls the behaviour of the Animator component when a GameObject is disabled.
		public bool keepAnimatorControllerStateOnDisable { get; set; }
		//
		// Summary:
		//     The rotation of the body center of mass.
		public Quaternion bodyRotation { get; set; }
		//
		// Summary:
		//     The position of the body center of mass.
		public Vector3 bodyPosition { get; set; }
		//
		// Summary:
		//     Returns true if the object has a transform hierarchy.
		public bool hasTransformHierarchy { get; }
		public bool animatePhysics { get; set; }
		//
		// Summary:
		//     When linearVelocityBlending is set to true, the root motion velocity and angular
		//     velocity will be blended linearly.
		[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
		public bool linearVelocityBlending { get; set; }
		//
		// Summary:
		//     Should root motion be applied?
		public bool applyRootMotion { get; set; }
		//
		// Summary:
		//     The root rotation, the rotation of the game object.
		public Quaternion rootRotation { get; set; }
		//
		// Summary:
		//     The root position, the position of the game object.
		public Vector3 rootPosition { get; set; }
		//
		// Summary:
		//     Gets the avatar angular velocity for the last evaluated frame.
		public Vector3 angularVelocity { get; }
		//
		// Summary:
		//     Gets the avatar velocity for the last evaluated frame.
		public Vector3 velocity { get; }
		//
		// Summary:
		//     Gets the avatar delta rotation for the last evaluated frame.
		public Quaternion deltaRotation { get; }
		//
		// Summary:
		//     Gets the avatar delta position for the last evaluated frame.
		public Vector3 deltaPosition { get; }
		//
		// Summary:
		//     Returns whether the animator is initialized successfully.
		public bool isInitialized { get; }
		//
		// Summary:
		//     Returns the scale of the current Avatar for a humanoid rig, (1 by default if
		//     the rig is generic).
		public float humanScale { get; }
		//
		// Summary:
		//     Returns true if the current rig has root motion.
		public bool hasRootMotion { get; }
		//
		// Summary:
		//     Returns true if the current rig is humanoid, false if it is generic.
		public bool isHuman { get; }
		//
		// Summary:
		//     Returns true if the current rig is optimizable with AnimatorUtility.OptimizeTransformHierarchy.
		public bool isOptimizable { get; }
		//
		// Summary:
		//     Sets whether the Animator sends events of type AnimationEvent.
		public bool fireEvents { get; set; }
		//
		// Summary:
		//     Automatic stabilization of feet during transition and blending.
		public bool stabilizeFeet { get; set; }
		//
		// Summary:
		//     Returns the number of layers in the controller.
		public int layerCount { get; }
		//
		// Summary:
		//     The current gravity weight based on current animations that are played.
		public float gravityWeight { get; }
		//
		// Summary:
		//     Returns the number of parameters in the controller.
		public int parameterCount { get; }
		public bool logWarnings { get; set; }
		//
		// Summary:
		//     Get right foot bottom height.
		public float rightFeetBottomHeight { get; }
		//
		// Summary:
		//     Get left foot bottom height.
		public float leftFeetBottomHeight { get; }
		//
		// Summary:
		//     Additional layers affects the center of mass.
		public bool layersAffectMassCenter { get; set; }
		//
		// Summary:
		//     End time of the recorded clip relative to when StartRecording was called.
		public float recorderStopTime { get; set; }
		//
		// Summary:
		//     Returns true if Animator has any playables assigned to it.
		public bool hasBoundPlayables { get; }
		//
		// Summary:
		//     Sets the playback position in the recording buffer.
		public float playbackTime { get; set; }
		//
		// Summary:
		//     Returns the rotation of the target specified by SetTarget.
		public Quaternion targetRotation { get; }
		//
		// Summary:
		//     Returns the position of the target specified by SetTarget.
		public Vector3 targetPosition { get; }
		//
		// Summary:
		//     The playback speed of the Animator. 1 is normal playback speed.
		public float speed { get; set; }
		//
		// Summary:
		//     If automatic matching is active.
		public bool isMatchingTarget { get; }
		//
		// Summary:
		//     Get the current position of the pivot.
		public Vector3 pivotPosition { get; }
		//
		// Summary:
		//     Blends pivot point between body center of mass and feet pivot.
		public float feetPivotActive { get; set; }
		//
		// Summary:
		//     Gets the pivot weight.
		public float pivotWeight { get; }
		//
		// Summary:
		//     Start time of the first frame of the buffer relative to the frame at which StartRecording
		//     was called.
		/*
		public float recorderStartTime { get; set; }
		[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
		//
		// Summary:
		//     Returns the number of AnimatorClipInfo in the current state.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     The number of AnimatorClipInfo in the current state.
		public int GetCurrentAnimatorClipInfoCount(int layerIndex);
		//
		// Summary:
		//     Returns an AnimatorStateInfo with the information on the current state.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     An AnimatorStateInfo with the information on the current state.
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
		//
		// Summary:
		//     Returns the value of the given float parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		// Returns:
		//     The value of the parameter.
		public float GetFloat(string name);
		//
		// Summary:
		//     Returns the value of the given float parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		// Returns:
		//     The value of the parameter.
		public float GetFloat(int id);
		//
		// Summary:
		//     Gets the position of an IK hint.
		//
		// Parameters:
		//   hint:
		//     The AvatarIKHint that is queried.
		//
		// Returns:
		//     Return the current position of this IK hint in world space.
		public Vector3 GetIKHintPosition(AvatarIKHint hint);
		//
		// Summary:
		//     Gets the translative weight of an IK Hint (0 = at the original animation before
		//     IK, 1 = at the hint).
		//
		// Parameters:
		//   hint:
		//     The AvatarIKHint that is queried.
		//
		// Returns:
		//     Return translative weight.
		public float GetIKHintPositionWeight(AvatarIKHint hint);
		//
		// Summary:
		//     Gets the position of an IK goal.
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is queried.
		//
		// Returns:
		//     Return the current position of this IK goal in world space.
		public Vector3 GetIKPosition(AvatarIKGoal goal);
		//
		// Summary:
		//     Gets the translative weight of an IK goal (0 = at the original animation before
		//     IK, 1 = at the goal).
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is queried.
		public float GetIKPositionWeight(AvatarIKGoal goal);
		//
		// Summary:
		//     Gets the rotation of an IK goal.
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is is queried.
		public Quaternion GetIKRotation(AvatarIKGoal goal);
		//
		// Summary:
		//     Gets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation
		//     at the IK goal).
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is queried.
		public float GetIKRotationWeight(AvatarIKGoal goal);
		//
		// Summary:
		//     Returns the value of the given integer parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		// Returns:
		//     The value of the parameter.
		public int GetInteger(int id);
		//
		// Summary:
		//     Returns the value of the given integer parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		// Returns:
		//     The value of the parameter.
		public int GetInteger(string name);
		//
		// Summary:
		//     Returns the index of the layer with the given name.
		//
		// Parameters:
		//   layerName:
		//     The layer name.
		//
		// Returns:
		//     The layer index.
		public int GetLayerIndex(string layerName);
		//
		// Summary:
		//     Returns the layer name.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     The layer name.
		public string GetLayerName(int layerIndex);
		//
		// Summary:
		//     Returns the weight of the layer at the specified index.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     The layer weight.
		public float GetLayerWeight(int layerIndex);
		//
		// Summary:
		//     Gets the list of AnimatorClipInfo currently played by the next state.
		//
		// Parameters:
		//   layerIndex:
		//     The layer's index.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("GetNextAnimationClipState is obsolete. Use GetNextAnimatorClipInfo instead (UnityUpgradable) -> GetNextAnimatorClipInfo(*)", true)]
		public AnimationInfo[] GetNextAnimationClipState(int layerIndex);
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
		//
		// Summary:
		//     Returns an array of all the AnimatorClipInfo in the next state of the given layer.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     An array of all the AnimatorClipInfo in the next state.
		[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = true)]
		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
		//
		// Summary:
		//     Returns the number of AnimatorClipInfo in the next state.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     The number of AnimatorClipInfo in the next state.
		public int GetNextAnimatorClipInfoCount(int layerIndex);
		//
		// Summary:
		//     Returns an AnimatorStateInfo with the information on the next state.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     An AnimatorStateInfo with the information on the next state.
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
		//
		// Summary:
		//     See AnimatorController.parameters.
		//
		// Parameters:
		//   index:
		public AnimatorControllerParameter GetParameter(int index);
		//
		// Summary:
		//     Gets the value of a quaternion parameter.
		//
		// Parameters:
		//   id:
		//     The id of the parameter. The id is generated using Animator::StringToHash.
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(int id);
		//
		// Summary:
		//     Gets the value of a quaternion parameter.
		//
		// Parameters:
		//   name:
		//     The name of the parameter.
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(string name);
		//
		// Summary:
		//     Gets the value of a vector parameter.
		//
		// Parameters:
		//   name:
		//     The name of the parameter.
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(string name);
		//
		// Summary:
		//     Gets the value of a vector parameter.
		//
		// Parameters:
		//   id:
		//     The id of the parameter. The id is generated using Animator::StringToHash.
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(int id);
		//
		// Summary:
		//     Returns true if the state exists in this layer, false otherwise.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		//   stateID:
		//     The state ID.
		//
		// Returns:
		//     True if the state exists in this layer, false otherwise.
		public bool HasState(int layerIndex, int stateID);
		//
		// Summary:
		//     Interrupts the automatic target matching.
		//
		// Parameters:
		//   completeMatch:
		public void InterruptMatchTarget([Internal.DefaultValue("true")] bool completeMatch);
		//
		// Summary:
		//     Interrupts the automatic target matching.
		//
		// Parameters:
		//   completeMatch:
		public void InterruptMatchTarget();
		//
		// Summary:
		//     Returns true if the transform is controlled by the Animator\.
		//
		// Parameters:
		//   transform:
		//     The transform that is queried.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", true)]
		public bool IsControlled(Transform transform);
		//
		// Summary:
		//     Returns true if there is a transition on the given layer, false otherwise.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		// Returns:
		//     True if there is a transition on the given layer, false otherwise.
		public bool IsInTransition(int layerIndex);
		//
		// Summary:
		//     Returns true if the parameter is controlled by a curve, false otherwise.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		// Returns:
		//     True if the parameter is controlled by a curve, false otherwise.
		public bool IsParameterControlledByCurve(string name);
		//
		// Summary:
		//     Returns true if the parameter is controlled by a curve, false otherwise.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		// Returns:
		//     True if the parameter is controlled by a curve, false otherwise.
		public bool IsParameterControlledByCurve(int id);
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [Internal.DefaultValue("1")] float targetNormalizedTime, [Internal.DefaultValue("true")] bool completeMatch);
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime);
		//
		// Summary:
		//     Automatically adjust the GameObject position and rotation.
		//
		// Parameters:
		//   matchPosition:
		//     The position we want the body part to reach.
		//
		//   matchRotation:
		//     The rotation in which we want the body part to be.
		//
		//   targetBodyPart:
		//     The body part that is involved in the match.
		//
		//   weightMask:
		//     Structure that contains weights for matching position and rotation.
		//
		//   startNormalizedTime:
		//     Start time within the animation clip (0 - beginning of clip, 1 - end of clip).
		//
		//   targetNormalizedTime:
		//     End time within the animation clip (0 - beginning of clip, 1 - end of clip),
		//     values greater than 1 can be set to trigger a match after a certain number of
		//     loops. Ex: 2.3 means at 30% of 2nd loop.
		//
		//   completeMatch:
		//     Allows you to specify what should happen if the MatchTarget function is interrupted.
		//     A value of true causes the GameObject to immediately move to the matchPosition
		//     if interrupted. A value of false causes the GameObject to stay at its current
		//     position if interrupted.
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [Internal.DefaultValue("1")] float targetNormalizedTime);
		public void Play(string stateName, int layer);
		//
		// Summary:
		//     Plays a state.
		//
		// Parameters:
		//   stateName:
		//     The state name.
		//
		//   stateNameHash:
		//     The state hash name. If stateNameHash is 0, it changes the current state time.
		//
		//   layer:
		//     The layer index. If layer is -1, it plays the first state with the given state
		//     name or hash.
		//
		//   normalizedTime:
		//     The time offset between zero and one.
		public void Play(string stateName, [Internal.DefaultValue("-1")] int layer, [Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime);
		//
		// Summary:
		//     Plays a state.
		//
		// Parameters:
		//   stateName:
		//     The state name.
		//
		//   stateNameHash:
		//     The state hash name. If stateNameHash is 0, it changes the current state time.
		//
		//   layer:
		//     The layer index. If layer is -1, it plays the first state with the given state
		//     name or hash.
		//
		//   normalizedTime:
		//     The time offset between zero and one.
		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public void Play(int stateNameHash, [Internal.DefaultValue("-1")] int layer, [Internal.DefaultValue("float.NegativeInfinity")] float normalizedTime);
		public void Play(string stateName);
		public void Play(int stateNameHash, int layer);
		public void Play(int stateNameHash);
		//
		// Summary:
		//     Plays a state.
		//
		// Parameters:
		//   stateName:
		//     The state name.
		//
		//   stateNameHash:
		//     The state hash name. If stateNameHash is 0, it changes the current state time.
		//
		//   layer:
		//     The layer index. If layer is -1, it plays the first state with the given state
		//     name or hash.
		//
		//   fixedTime:
		//     The time offset (in seconds).
		public void PlayInFixedTime(string stateName, [Internal.DefaultValue("-1")] int layer, [Internal.DefaultValue("float.NegativeInfinity")] float fixedTime);
		public void PlayInFixedTime(string stateName);
		public void PlayInFixedTime(int stateNameHash, int layer);
		public void PlayInFixedTime(int stateNameHash);
		//
		// Summary:
		//     Plays a state.
		//
		// Parameters:
		//   stateName:
		//     The state name.
		//
		//   stateNameHash:
		//     The state hash name. If stateNameHash is 0, it changes the current state time.
		//
		//   layer:
		//     The layer index. If layer is -1, it plays the first state with the given state
		//     name or hash.
		//
		//   fixedTime:
		//     The time offset (in seconds).
		[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = true)]
		public void PlayInFixedTime(int stateNameHash, [Internal.DefaultValue("-1")] int layer, [Internal.DefaultValue("float.NegativeInfinity")] float fixedTime);
		public void PlayInFixedTime(string stateName, int layer);
		//
		// Summary:
		//     Rebind all the animated properties and mesh data with the Animator.
		public void Rebind();
		//
		// Summary:
		//     Resets the value of the given trigger parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		public void ResetTrigger(int id);
		//
		// Summary:
		//     Resets the value of the given trigger parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		*/
		public void ResetTrigger(string name) { //TODO
		}
		/*
		//
		// Summary:
		//     Sets local rotation of a human bone during a IK pass.
		//
		// Parameters:
		//   humanBoneId:
		//     The human bone Id.
		//
		//   rotation:
		//     The local rotation.
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation);
		//
		// Summary:
		//     Sets the value of the given boolean parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		public void SetBool(string name, bool value);
		//
		// Summary:
		//     Sets the value of the given boolean parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		public void SetBool(int id, bool value);
		//
		// Summary:
		//     Send float values to the Animator to affect transitions.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		//
		//   dampTime:
		//     The damper total time.
		//
		//   deltaTime:
		//     The delta time to give to the damper.
		public void SetFloat(int id, float value, float dampTime, float deltaTime);
		//
		// Summary:
		//     Send float values to the Animator to affect transitions.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		//
		//   dampTime:
		//     The damper total time.
		//
		//   deltaTime:
		//     The delta time to give to the damper.
		public void SetFloat(int id, float value);
		//
		// Summary:
		//     Send float values to the Animator to affect transitions.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		//
		//   dampTime:
		//     The damper total time.
		//
		//   deltaTime:
		//     The delta time to give to the damper.
		public void SetFloat(string name, float value);
		//
		// Summary:
		//     Send float values to the Animator to affect transitions.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		//
		//   dampTime:
		//     The damper total time.
		//
		//   deltaTime:
		//     The delta time to give to the damper.
		public void SetFloat(string name, float value, float dampTime, float deltaTime);
		//
		// Summary:
		//     Sets the position of an IK hint.
		//
		// Parameters:
		//   hint:
		//     The AvatarIKHint that is set.
		//
		//   hintPosition:
		//     The position in world space.
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition);
		//
		// Summary:
		//     Sets the translative weight of an IK hint (0 = at the original animation before
		//     IK, 1 = at the hint).
		//
		// Parameters:
		//   hint:
		//     The AvatarIKHint that is set.
		//
		//   value:
		//     The translative weight.
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value);
		//
		// Summary:
		//     Sets the position of an IK goal.
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is set.
		//
		//   goalPosition:
		//     The position in world space.
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition);
		//
		// Summary:
		//     Sets the translative weight of an IK goal (0 = at the original animation before
		//     IK, 1 = at the goal).
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is set.
		//
		//   value:
		//     The translative weight.
		public void SetIKPositionWeight(AvatarIKGoal goal, float value);
		//
		// Summary:
		//     Sets the rotation of an IK goal.
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is set.
		//
		//   goalRotation:
		//     The rotation in world space.
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation);
		//
		// Summary:
		//     Sets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation
		//     at the IK goal).
		//
		// Parameters:
		//   goal:
		//     The AvatarIKGoal that is set.
		//
		//   value:
		//     The rotational weight.
		public void SetIKRotationWeight(AvatarIKGoal goal, float value);
		//
		// Summary:
		//     Sets the value of the given integer parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		public void SetInteger(int id, int value);
		//
		// Summary:
		//     Sets the value of the given integer parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		//
		//   value:
		//     The new parameter value.
		public void SetInteger(string name, int value);
		//
		// Summary:
		//     Sets the weight of the layer at the given index.
		//
		// Parameters:
		//   layerIndex:
		//     The layer index.
		//
		//   weight:
		//     The new layer weight.
		public void SetLayerWeight(int layerIndex, float weight);
		//
		// Summary:
		//     Sets the look at position.
		//
		// Parameters:
		//   lookAtPosition:
		//     The position to lookAt.
		public void SetLookAtPosition(Vector3 lookAtPosition);
		//
		// Summary:
		//     Set look at weights.
		//
		// Parameters:
		//   weight:
		//     (0-1) the global weight of the LookAt, multiplier for other parameters.
		//
		//   bodyWeight:
		//     (0-1) determines how much the body is involved in the LookAt.
		//
		//   headWeight:
		//     (0-1) determines how much the head is involved in the LookAt.
		//
		//   eyesWeight:
		//     (0-1) determines how much the eyes are involved in the LookAt.
		//
		//   clampWeight:
		//     (0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means
		//     he's completely clamped (look at becomes impossible), and 0.5 means he'll be
		//     able to move on half of the possible range (180 degrees).
		public void SetLookAtWeight(float weight, [Internal.DefaultValue("0.0f")] float bodyWeight, [Internal.DefaultValue("1.0f")] float headWeight, [Internal.DefaultValue("0.0f")] float eyesWeight, [Internal.DefaultValue("0.5f")] float clampWeight);
		//
		// Summary:
		//     Set look at weights.
		//
		// Parameters:
		//   weight:
		//     (0-1) the global weight of the LookAt, multiplier for other parameters.
		//
		//   bodyWeight:
		//     (0-1) determines how much the body is involved in the LookAt.
		//
		//   headWeight:
		//     (0-1) determines how much the head is involved in the LookAt.
		//
		//   eyesWeight:
		//     (0-1) determines how much the eyes are involved in the LookAt.
		//
		//   clampWeight:
		//     (0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means
		//     he's completely clamped (look at becomes impossible), and 0.5 means he'll be
		//     able to move on half of the possible range (180 degrees).
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight);
		//
		// Summary:
		//     Set look at weights.
		//
		// Parameters:
		//   weight:
		//     (0-1) the global weight of the LookAt, multiplier for other parameters.
		//
		//   bodyWeight:
		//     (0-1) determines how much the body is involved in the LookAt.
		//
		//   headWeight:
		//     (0-1) determines how much the head is involved in the LookAt.
		//
		//   eyesWeight:
		//     (0-1) determines how much the eyes are involved in the LookAt.
		//
		//   clampWeight:
		//     (0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means
		//     he's completely clamped (look at becomes impossible), and 0.5 means he'll be
		//     able to move on half of the possible range (180 degrees).
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight);
		//
		// Summary:
		//     Set look at weights.
		//
		// Parameters:
		//   weight:
		//     (0-1) the global weight of the LookAt, multiplier for other parameters.
		//
		//   bodyWeight:
		//     (0-1) determines how much the body is involved in the LookAt.
		//
		//   headWeight:
		//     (0-1) determines how much the head is involved in the LookAt.
		//
		//   eyesWeight:
		//     (0-1) determines how much the eyes are involved in the LookAt.
		//
		//   clampWeight:
		//     (0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means
		//     he's completely clamped (look at becomes impossible), and 0.5 means he'll be
		//     able to move on half of the possible range (180 degrees).
		public void SetLookAtWeight(float weight, float bodyWeight);
		//
		// Summary:
		//     Set look at weights.
		//
		// Parameters:
		//   weight:
		//     (0-1) the global weight of the LookAt, multiplier for other parameters.
		//
		//   bodyWeight:
		//     (0-1) determines how much the body is involved in the LookAt.
		//
		//   headWeight:
		//     (0-1) determines how much the head is involved in the LookAt.
		//
		//   eyesWeight:
		//     (0-1) determines how much the eyes are involved in the LookAt.
		//
		//   clampWeight:
		//     (0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means
		//     he's completely clamped (look at becomes impossible), and 0.5 means he'll be
		//     able to move on half of the possible range (180 degrees).
		public void SetLookAtWeight(float weight);
		//
		// Summary:
		//     Sets the value of a quaternion parameter.
		//
		// Parameters:
		//   id:
		//     Of the parameter. The id is generated using Animator::StringToHash.
		//
		//   value:
		//     The new value for the parameter.
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(int id, Quaternion value);
		//
		// Summary:
		//     Sets the value of a quaternion parameter.
		//
		// Parameters:
		//   name:
		//     The name of the parameter.
		//
		//   value:
		//     The new value for the parameter.
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(string name, Quaternion value);
		//
		// Summary:
		//     Sets an AvatarTarget and a targetNormalizedTime for the current state.
		//
		// Parameters:
		//   targetIndex:
		//     The avatar body part that is queried.
		//
		//   targetNormalizedTime:
		//     The current state Time that is queried.
		public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime);
		//
		// Summary:
		//     Sets the value of the given trigger parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		public void SetTrigger(int id);
		//
		// Summary:
		//     Sets the value of the given trigger parameter.
		//
		// Parameters:
		//   name:
		//     The parameter name.
		//
		//   id:
		//     The parameter ID.
		*/
		public void SetTrigger(string name) {
			//TODO throw new NotImplementedException();
		}
		/*
		//
		// Summary:
		//     Sets the value of a vector parameter.
		//
		// Parameters:
		//   name:
		//     The name of the parameter.
		//
		//   value:
		//     The new value for the parameter.
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(string name, Vector3 value);
		//
		// Summary:
		//     Sets the value of a vector parameter.
		//
		// Parameters:
		//   id:
		//     The id of the parameter. The id is generated using Animator::StringToHash.
		//
		//   value:
		//     The new value for the parameter.
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(int id, Vector3 value);
		//
		// Summary:
		//     Sets the animator in playback mode.
		public void StartPlayback();
		//
		// Summary:
		//     Sets the animator in recording mode, and allocates a circular buffer of size
		//     frameCount.
		//
		// Parameters:
		//   frameCount:
		//     The number of frames (updates) that will be recorded. If frameCount is 0, the
		//     recording will continue until the user calls StopRecording. The maximum value
		//     for frameCount is 10000.
		public void StartRecording(int frameCount);
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Stop is obsolete. Use Animator.enabled = false instead", true)]
		public void Stop();
		//
		// Summary:
		//     Stops the animator playback mode. When playback stops, the avatar resumes getting
		//     control from game logic.
		public void StopPlayback();
		//
		// Summary:
		//     Stops animator record mode.
		public void StopRecording();
		//
		// Summary:
		//     Evaluates the animator based on deltaTime.
		//
		// Parameters:
		//   deltaTime:
		//     The time delta.
		[NativeMethod("UpdateWithDelta")]
		public void Update(float deltaTime);
		//
		// Summary:
		//     Forces a write of the default values stored in the animator.
		[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = true)]
		public void WriteDefaultValues();
		*/
	}
}