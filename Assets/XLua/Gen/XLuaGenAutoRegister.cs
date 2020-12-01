#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(System.Type), SystemTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Array), SystemArrayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.DateTime), SystemDateTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.TimeSpan), SystemTimeSpanWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.Dictionary<int, object>), SystemCollectionsGenericDictionary_2_SystemInt32SystemObject_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>), SystemCollectionsGenericDictionary_2_SystemInt32UnityEngineObject_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<string>), SystemCollectionsGenericList_1_SystemString_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<object>), SystemCollectionsGenericList_1_SystemObject_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<UnityEngine.Object>), SystemCollectionsGenericList_1_UnityEngineObject_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry>), SystemCollectionsGenericList_1_UnityEngineEventSystemsEventTriggerEntry_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.IEnumerable), SystemCollectionsIEnumerableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color32), UnityEngineColor32Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioSource), UnityEngineAudioSourceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngineAssetBundleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Camera), UnityEngineCameraWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Canvas), UnityEngineCanvasWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), UnityEngineRaycastHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit2D), UnityEngineRaycastHit2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collision), UnityEngineCollisionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collision2D), UnityEngineCollision2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rigidbody), UnityEngineRigidbodyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rigidbody2D), UnityEngineRigidbody2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Event), UnityEngineEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Touch), UnityEngineTouchWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderTexture), UnityEngineRenderTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationEvent), UnityEngineAnimationEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AccelerationEvent), UnityEngineAccelerationEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Shader), UnityEngineShaderWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.ShaderVariantCollection), UnityEngineShaderVariantCollectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.QualitySettings), UnityEngineQualitySettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEventBase), UnityEngineEventsUnityEventBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent), UnityEngineEventsUnityEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<bool>), UnityEngineEventsUnityEvent_1_SystemBoolean_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<int>), UnityEngineEventsUnityEvent_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<float>), UnityEngineEventsUnityEvent_1_SystemSingle_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<string>), UnityEngineEventsUnityEvent_1_SystemString_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector2>), UnityEngineEventsUnityEvent_1_UnityEngineVector2_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector3>), UnityEngineEventsUnityEvent_1_UnityEngineVector3_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>), UnityEngineEventsUnityEvent_1_UnityEngineEventSystemsBaseEventData_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventSystem), UnityEngineEventSystemsEventSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.RaycastResult), UnityEngineEventSystemsRaycastResultWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseInput), UnityEngineEventSystemsBaseInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseRaycaster), UnityEngineEventSystemsBaseRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger), UnityEngineEventSystemsEventTriggerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.Entry), UnityEngineEventSystemsEventTriggerEntryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent), UnityEngineEventSystemsEventTriggerTriggerEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseEventData), UnityEngineEventSystemsBaseEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData), UnityEngineEventSystemsPointerEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.AxisEventData), UnityEngineEventSystemsAxisEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneManager), UnityEngineSceneManagementSceneManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneUtility), UnityEngineSceneManagementSceneUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), UnityEngineUIScrollRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar), UnityEngineUIScrollbarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMesh), UnityEngineAINavMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshAgent), UnityEngineAINavMeshAgentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshPath), UnityEngineAINavMeshPathWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshObstacle), UnityEngineAINavMeshObstacleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.PlayableExtensions), UnityEnginePlayablesPlayableExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.Playable), UnityEnginePlayablesPlayableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorOverrideController), UnityEngineAnimatorOverrideControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.jvalue), UnityEnginejvalueWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoundingSphere), UnityEngineBoundingSphereWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CullingGroupEvent), UnityEngineCullingGroupEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ExposedPropertyResolver), UnityEngineExposedPropertyResolverWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rendering.GPUFence), UnityEngineRenderingGPUFenceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GradientColorKey), UnityEngineGradientColorKeyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GradientAlphaKey), UnityEngineGradientAlphaKeyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LocationInfo), UnityEngineLocationInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LOD), UnityEngineLODWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FrustumPlanes), UnityEngineFrustumPlanesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Matrix4x4), UnityEngineMatrix4x4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Random.State), UnityEngineRandomStateWrap.__Register);
        
        }
        
        static void wrapInit2(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.ShaderVariantCollection.ShaderVariant), UnityEngineShaderVariantCollectionShaderVariantWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SortingLayer), UnityEngineSortingLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rendering.SphericalHarmonicsL2), UnityEngineRenderingSphericalHarmonicsL2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CustomRenderTextureUpdateZone), UnityEngineCustomRenderTextureUpdateZoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Hash128), UnityEngineHash128Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.PlayableOutputHandle), UnityEnginePlayablesPlayableOutputHandleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.Scene), UnityEngineSceneManagementSceneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.DrivenRectTransformTracker), UnityEngineDrivenRectTransformTrackerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoundsInt), UnityEngineBoundsIntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoundsInt.PositionEnumerator), UnityEngineBoundsIntPositionEnumeratorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CachedAssetBundle), UnityEngineCachedAssetBundleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Cache), UnityEngineCacheWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.FrameTiming), UnityEngineFrameTimingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resolution), UnityEngineResolutionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderBuffer), UnityEngineRenderBufferWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderTargetSetup), UnityEngineRenderTargetSetupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LightBakingOutput), UnityEngineLightBakingOutputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rendering.RenderTargetIdentifier), UnityEngineRenderingRenderTargetIdentifierWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo), UnityEngineRenderingReflectionProbeBlendInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngineInternal.MathfInternal), UnityEngineInternalMathfInternalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.BoneWeight), UnityEngineBoneWeightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CombineInstance), UnityEngineCombineInstanceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Plane), UnityEnginePlaneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Pose), UnityEnginePoseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.PropertyName), UnityEnginePropertyNameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RangeInt), UnityEngineRangeIntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectInt), UnityEngineRectIntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectInt.PositionEnumerator), UnityEngineRectIntPositionEnumeratorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderTextureDescriptor), UnityEngineRenderTextureDescriptorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2Int), UnityEngineVector2IntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3Int), UnityEngineVector3IntWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.FrameData), UnityEnginePlayablesFrameDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.PlayableBinding), UnityEnginePlayablesPlayableBindingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.PlayableGraph), UnityEnginePlayablesPlayableGraphWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.PlayableHandle), UnityEnginePlayablesPlayableHandleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.PlayableOutput), UnityEnginePlayablesPlayableOutputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Playables.ScriptPlayableOutput), UnityEnginePlayablesScriptPlayableOutputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ColorBlock), UnityEngineUIColorBlockWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls.Resources), UnityEngineUIDefaultControlsResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Navigation), UnityEngineUINavigationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.SpriteState), UnityEngineUISpriteStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioConfiguration), UnityEngineAudioConfigurationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WebCamDevice), UnityEngineWebCamDeviceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Audio.AudioPlayableOutput), UnityEngineAudioAudioPlayableOutputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Audio.AudioClipPlayable), UnityEngineAudioAudioClipPlayableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Audio.AudioMixerPlayable), UnityEngineAudioAudioMixerPlayableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorClipInfo), UnityEngineAnimatorClipInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorStateInfo), UnityEngineAnimatorStateInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimatorTransitionInfo), UnityEngineAnimatorTransitionInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MatchTargetWeightMask), UnityEngineMatchTargetWeightMaskWrap.__Register);
        
        }
        
        static void wrapInit3(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animations.AnimatorControllerPlayable), UnityEngineAnimationsAnimatorControllerPlayableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkeletonBone), UnityEngineSkeletonBoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanLimit), UnityEngineHumanLimitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanBone), UnityEngineHumanBoneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanDescription), UnityEngineHumanDescriptionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.HumanPose), UnityEngineHumanPoseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animations.AnimationClipPlayable), UnityEngineAnimationsAnimationClipPlayableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animations.AnimationLayerMixerPlayable), UnityEngineAnimationsAnimationLayerMixerPlayableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animations.AnimationMixerPlayable), UnityEngineAnimationsAnimationMixerPlayableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animations.AnimationPlayableOutput), UnityEngineAnimationsAnimationPlayableOutputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshHit), UnityEngineAINavMeshHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshTriangulation), UnityEngineAINavMeshTriangulationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshDataInstance), UnityEngineAINavMeshDataInstanceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshLinkData), UnityEngineAINavMeshLinkDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshLinkInstance), UnityEngineAINavMeshLinkInstanceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshQueryFilter), UnityEngineAINavMeshQueryFilterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.OffMeshLinkData), UnityEngineAIOffMeshLinkDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildSettings), UnityEngineAINavMeshBuildSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildDebugSettings), UnityEngineAINavMeshBuildDebugSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildSource), UnityEngineAINavMeshBuildSourceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildMarkup), UnityEngineAINavMeshBuildMarkupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.Burst), UnityEngineParticleSystemBurstWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MinMaxCurve), UnityEngineParticleSystemMinMaxCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MinMaxGradient), UnityEngineParticleSystemMinMaxGradientWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MainModule), UnityEngineParticleSystemMainModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.EmissionModule), UnityEngineParticleSystemEmissionModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ShapeModule), UnityEngineParticleSystemShapeModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.VelocityOverLifetimeModule), UnityEngineParticleSystemVelocityOverLifetimeModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule), UnityEngineParticleSystemLimitVelocityOverLifetimeModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.InheritVelocityModule), UnityEngineParticleSystemInheritVelocityModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ForceOverLifetimeModule), UnityEngineParticleSystemForceOverLifetimeModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ColorOverLifetimeModule), UnityEngineParticleSystemColorOverLifetimeModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ColorBySpeedModule), UnityEngineParticleSystemColorBySpeedModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.SizeOverLifetimeModule), UnityEngineParticleSystemSizeOverLifetimeModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.SizeBySpeedModule), UnityEngineParticleSystemSizeBySpeedModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.RotationOverLifetimeModule), UnityEngineParticleSystemRotationOverLifetimeModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.RotationBySpeedModule), UnityEngineParticleSystemRotationBySpeedModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ExternalForcesModule), UnityEngineParticleSystemExternalForcesModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.NoiseModule), UnityEngineParticleSystemNoiseModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.CollisionModule), UnityEngineParticleSystemCollisionModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.TriggerModule), UnityEngineParticleSystemTriggerModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.SubEmittersModule), UnityEngineParticleSystemSubEmittersModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.TextureSheetAnimationModule), UnityEngineParticleSystemTextureSheetAnimationModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.LightsModule), UnityEngineParticleSystemLightsModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.TrailModule), UnityEngineParticleSystemTrailModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.CustomDataModule), UnityEngineParticleSystemCustomDataModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.Particle), UnityEngineParticleSystemParticleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.EmitParams), UnityEngineParticleSystemEmitParamsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleCollisionEvent), UnityEngineParticleCollisionEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ColliderDistance2D), UnityEngineColliderDistance2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ContactFilter2D), UnityEngineContactFilter2DWrap.__Register);
        
        }
        
        static void wrapInit4(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.ContactPoint2D), UnityEngineContactPoint2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointAngleLimits2D), UnityEngineJointAngleLimits2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointTranslationLimits2D), UnityEngineJointTranslationLimits2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointMotor2D), UnityEngineJointMotor2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointSuspension2D), UnityEngineJointSuspension2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ContactPoint), UnityEngineContactPointWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WheelFrictionCurve), UnityEngineWheelFrictionCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SoftJointLimit), UnityEngineSoftJointLimitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SoftJointLimitSpring), UnityEngineSoftJointLimitSpringWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointDrive), UnityEngineJointDriveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointMotor), UnityEngineJointMotorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointSpring), UnityEngineJointSpringWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.JointLimits), UnityEngineJointLimitsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.CharacterInfo), UnityEngineCharacterInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UICharInfo), UnityEngineUICharInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UILineInfo), UnityEngineUILineInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UIVertex), UnityEngineUIVertexWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextGenerationSettings), UnityEngineTextGenerationSettingsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaBehaviour), LuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.LuaBehaviour), XLuaTestLuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Pedding), XLuaTestPeddingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyStruct), XLuaTestMyStructWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyEnum), XLuaTestMyEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.NoGc), XLuaTestNoGcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.BaseTest), XLuaTestBaseTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Parent), XLuaTestFoo1ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Parent), XLuaTestFoo2ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Child), XLuaTestFoo1ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Child), XLuaTestFoo2ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo), XLuaTestFooWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.FooExtension), XLuaTestFooExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass), TutorialDerivedClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass.TestEnumInner), TutorialDerivedClassTestEnumInnerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ICalc), TutorialICalcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClassExtensions), TutorialDerivedClassExtensionsWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            wrapInit2(luaenv, translator);
            
            wrapInit3(luaenv, translator);
            
            wrapInit4(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.InvokeLua.ICalc), XLuaTestInvokeLuaICalcBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.IExchanger), XLuaTestIExchangerBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Tutorial.CSCallLua.ItfD), TutorialCSCallLuaItfDBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
		delegate void __GEN_DELEGATE0( UnityEngine.Renderer renderer);
		
		delegate void __GEN_DELEGATE1( UnityEngine.UI.VertexHelper obj,  UnityEngine.Vector3 position,  UnityEngine.Color32 color,  UnityEngine.Vector2 uv0,  UnityEngine.Vector2 uv1,  UnityEngine.Vector2 uv2,  UnityEngine.Vector2 uv3,  UnityEngine.Vector3 normal,  UnityEngine.Vector4 tangent);
		
		delegate UnityEngine.Timeline.GroupTrack __GEN_DELEGATE2( UnityEngine.Timeline.TrackAsset asset);
		
		delegate void __GEN_DELEGATE3( UnityEngine.Timeline.TrackAsset asset,  UnityEngine.Timeline.GroupTrack group);
		
		delegate int __GEN_DELEGATE4( UnityEngine.ParticleSystem ps);
		
		delegate int __GEN_DELEGATE5( UnityEngine.ParticleSystem ps,  UnityEngine.GameObject go,  System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents);
		
		delegate int __GEN_DELEGATE6( UnityEngine.ParticleSystem ps,  UnityEngine.ParticleSystemTriggerEventType type);
		
		delegate int __GEN_DELEGATE7( UnityEngine.ParticleSystem ps,  UnityEngine.ParticleSystemTriggerEventType type,  System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
		
		delegate void __GEN_DELEGATE8( UnityEngine.ParticleSystem ps,  UnityEngine.ParticleSystemTriggerEventType type,  System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles,  int offset,  int count);
		
		delegate void __GEN_DELEGATE9( UnityEngine.ParticleSystem ps,  UnityEngine.ParticleSystemTriggerEventType type,  System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
		
		delegate void __GEN_DELEGATE10( UnityEngine.Terrain terrain);
		
		delegate void __GEN_DELEGATE11( UnityEngine.Terrain terrain,  int x,  int y,  int width,  int height);
		
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(UnityEngine.Renderer), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(UnityEngine.RendererExtensions.UpdateGIMaterials)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.VertexHelper), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE1(UnityEngine.Experimental.UI.VertexHelperExtension.AddVert)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Timeline.TrackAsset), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE2(UnityEngine.Timeline.TrackAssetExtensions.GetGroup)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE3(UnityEngine.Timeline.TrackAssetExtensions.SetGroup)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.ParticleSystem), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE4(UnityEngine.ParticlePhysicsExtensions.GetSafeCollisionEventSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE5(UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE6(UnityEngine.ParticlePhysicsExtensions.GetSafeTriggerParticlesSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE7(UnityEngine.ParticlePhysicsExtensions.GetTriggerParticles)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE8(UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE9(UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Terrain), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE10(UnityEngine.TerrainExtensions.UpdateGIMaterials)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE11(UnityEngine.TerrainExtensions.UpdateGIMaterials)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
