using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XLua;


public static class XLuaConfig
{

    [CSObjectWrapEditor.GenPath]
    public static string common_path = Application.dataPath + "/XLua/Gen/";

    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>() {
        typeof(System.Type),
        typeof(System.Object),
        typeof(System.Array),
        typeof(System.Func<int>),
        typeof(System.Action<string>),
        typeof(System.Action<int, string>),
        typeof(System.Action<int, Dictionary<int, System.Object>>),
        typeof(System.Action<string, System.Object, System.Object, System.Object>),
        typeof(System.DateTime),
        typeof(System.TimeSpan),

        typeof(System.Collections.Generic.Dictionary<int, System.Object>),
        typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>),
        typeof(System.Collections.Generic.List<int>),
        typeof(System.Collections.Generic.List<string>),
        typeof(System.Collections.Generic.List<System.Object>),
        typeof(System.Collections.Generic.List<UnityEngine.Object>),
        typeof(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry>),

        typeof(System.Collections.IEnumerable),
        typeof(System.Collections.IEnumerator),
        

        typeof(UnityEngine.Vector2),
        typeof(UnityEngine.Vector3),
        typeof(UnityEngine.Vector4),
        typeof(UnityEngine.Color),
        typeof(UnityEngine.Color32),
        typeof(UnityEngine.Quaternion),
        typeof(UnityEngine.Object),
        typeof(UnityEngine.GameObject),
        typeof(UnityEngine.Component),
        typeof(UnityEngine.Transform),
        typeof(UnityEngine.RectTransform),
        typeof(UnityEngine.Animator),
        typeof(UnityEngine.AnimationClip),
        typeof(UnityEngine.AudioSource),
        typeof(UnityEngine.AudioClip),
        typeof(UnityEngine.Resources),
        typeof(UnityEngine.AssetBundle),
        typeof(UnityEngine.Application),
        typeof(UnityEngine.Camera),
        typeof(UnityEngine.Canvas),
        typeof(UnityEngine.Physics),
        typeof(UnityEngine.Ray),
        typeof(UnityEngine.Ray2D),
        typeof(UnityEngine.RaycastHit),
        typeof(UnityEngine.RaycastHit2D),
        typeof(UnityEngine.Collision),
        typeof(UnityEngine.Collision2D),
        typeof(UnityEngine.Rigidbody),
        typeof(UnityEngine.Rigidbody2D),
        typeof(UnityEngine.Event),
        typeof(UnityEngine.Input),
        typeof(UnityEngine.Touch),
        typeof(UnityEngine.ParticleSystem),
        typeof(UnityEngine.RenderTexture),
        typeof(UnityEngine.AnimationEvent),
        typeof(UnityEngine.AccelerationEvent),
        typeof(UnityEngine.Shader),
        typeof(UnityEngine.ShaderVariantCollection),
        typeof(UnityEngine.QualitySettings),

        typeof(UnityEngine.Events.UnityEventBase),
        typeof(UnityEngine.Events.UnityEvent),
        typeof(UnityEngine.Events.UnityEvent<bool>),
        typeof(UnityEngine.Events.UnityEvent<int>),
        typeof(UnityEngine.Events.UnityEvent<float>),
        typeof(UnityEngine.Events.UnityEvent<string>),
        typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector2>),
        typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector3>),
        typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>),

        typeof(UnityEngine.EventSystems.EventSystem),
        typeof(UnityEngine.EventSystems.RaycastResult),
        typeof(UnityEngine.EventSystems.BaseInput),
        typeof(UnityEngine.EventSystems.BaseRaycaster),
        typeof(UnityEngine.EventSystems.EventTrigger),
        typeof(UnityEngine.EventSystems.EventTrigger.Entry),
        typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent),
        typeof(UnityEngine.EventSystems.BaseEventData),
        typeof(UnityEngine.EventSystems.PointerEventData),
        typeof(UnityEngine.EventSystems.AxisEventData),

        typeof(UnityEngine.SceneManagement.SceneManager),
        typeof(UnityEngine.SceneManagement.SceneUtility),

        typeof(UnityEngine.UI.Text),
        typeof(UnityEngine.UI.Image),
        typeof(UnityEngine.UI.Button),
        typeof(UnityEngine.UI.ScrollRect),
        typeof(UnityEngine.UI.Scrollbar),

        typeof(UnityEngine.AI.NavMesh),
        typeof(UnityEngine.AI.NavMeshAgent),
        typeof(UnityEngine.AI.NavMeshPath),
        typeof(UnityEngine.AI.NavMeshObstacle), 

        typeof(UnityEngine.Playables.PlayableExtensions),
        typeof(UnityEngine.Playables.Playable),

        typeof(UnityEngine.AnimatorOverrideController),
    };


    //C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>() {
        typeof(System.Action),
        typeof(System.Action<bool>),
        typeof(System.Action<int>),
        typeof(System.Action<float>),
        typeof(System.Action<string>),
        typeof(System.Func<bool>),
        typeof(System.Func<UnityEngine.UI.ILayoutElement,System.Single>),
        
        typeof(UnityEngine.Events.UnityAction),
        typeof(UnityEngine.Events.UnityAction<bool>),
        typeof(UnityEngine.Events.UnityAction<int>),
        typeof(UnityEngine.Events.UnityAction<float>),
        typeof(UnityEngine.Events.UnityAction<string>),
        typeof(UnityEngine.Events.UnityAction<Vector2>),
        typeof(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>),

        typeof(UnityEngine.Application.AdvertisingIdentifierCallback),
        typeof(UnityEngine.Application.LogCallback),
        typeof(UnityEngine.AudioClip.PCMReaderCallback),
        typeof(UnityEngine.AudioClip.PCMSetPositionCallback),
        typeof(UnityEngine.AudioSettings.AudioConfigurationChangeHandler),
        typeof(UnityEngine.Camera.CameraCallback),
        typeof(UnityEngine.Canvas.WillRenderCanvases),
        typeof(UnityEngine.CullingGroup.StateChanged),
        typeof(UnityEngine.Display.DisplaysUpdatedDelegate),
        typeof(UnityEngine.Font.FontTextureRebuildCallback),
        typeof(UnityEngine.GUI.WindowFunction),
        typeof(UnityEngine.RectTransform.ReapplyDrivenProperties),
        typeof(UnityEngine.UI.InputField.OnValidateInput),

		typeof(UnityEngine.Video.VideoPlayer.EventHandler),

        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>),
        typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>),

    };

    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
        new List<string>(){"UnityEngine.AnimatorControllerParameter", "name"},  // name is read only in ios/android, so add it in black list
        new List<string>(){"UnityEngine.AnimationClip", "averageDuration"},
        new List<string>(){"UnityEngine.AnimationClip", "averageAngularSpeed"},
        new List<string>(){"UnityEngine.AnimationClip", "averageSpeed"},
        new List<string>(){"UnityEngine.AnimationClip", "apparentSpeed"},
        new List<string>(){"UnityEngine.AnimationClip", "isLooping"},
        new List<string>(){"UnityEngine.AnimationClip", "isAnimatorMotion"},
        new List<string>(){"UnityEngine.AnimationClip", "isHumanMotion"},
        new List<string>(){"UnityEngine.AudioSettings", "GetSpatializerPluginNames"}, 
		new List<string>(){"UnityEngine.AudioSettings", "SetSpatializerPluginName", typeof(string).FullName}, 
        new List<string>(){"UnityEngine.Caching", "SetNoBackupFlag", typeof(UnityEngine.CachedAssetBundle).FullName},
        new List<string>(){"UnityEngine.Caching", "ResetNoBackupFlag", typeof(UnityEngine.CachedAssetBundle).FullName},
        new List<string>(){"UnityEngine.Caching", "SetNoBackupFlag", typeof(string).FullName, typeof(Hash128).FullName},
        new List<string>(){"UnityEngine.Caching", "SetNoBackupFlag", typeof(string).FullName, typeof(int).FullName},
        new List<string>(){"UnityEngine.Caching", "ResetNoBackupFlag", typeof(string).FullName, typeof(Hash128).FullName},
        new List<string>(){"UnityEngine.Caching", "ResetNoBackupFlag", typeof(string).FullName, typeof(int).FullName},
        new List<string>(){"UnityEngine.Light", "areaSize"},
        new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
        new List<string>(){"UnityEngine.WWW", "movie"},
        new List<string>(){"UnityEngine.WWW", "GetMovieTexture"}, 
        new List<string>(){"UnityEngine.Physics", "Raycast", typeof(Ray).FullName},
        new List<string>(){"UnityEngine.Physics", "Raycast", typeof(Ray).FullName, typeof(float).FullName, typeof(int).FullName},
        new List<string>(){"UnityEngine.UI.Graphic", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
        new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue", typeof(string).FullName},
        new List<string>(){"UnityEngine.Texture", "imageContentsHash"},
        new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
        new List<string>(){"UnityEngine.Application", "ExternalEval", typeof(string).FullName},
        new List<string>(){"UnityEngine.GameObject", "networkView"},
        new List<string>(){"UnityEngine.Component", "networkView"},
        new List<string>(){"UnityEngine.Input", "IsJoystickPreconfigured", typeof(string).FullName},
        new List<string>(){"UnityEngine.Resources", "LoadAssetAtPath", typeof(string).FullName, typeof(Type).FullName},
        new List<string>(){"UnityEngine.GUIStyleState", "scaledBackgrounds"},
        new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
        new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},  
        

    };

    [ReflectionUse]
    public static List<Type> ReflectionUseGenerate
    {
        get
        {
            string[] modlist = new string[] { 
                "UnityEngine",
                "UnityEngine.CoreModule",
                "UnityEngine.AssetBundleModule",

                "UnityEngine.UI",
                "UnityEngine.UIModule",

                "UnityEngine.AudioModule",

                "UnityEngine.AnimationModule",
                "UnityEngine.DirectorModule",
                "UnityEngine.Timeline",

                "UnityEngine.ScreenCaptureModule",
                
                "UnityEngine.AIModule",
                

                "UnityEngine.ParticleSystemModule",

                "UnityEngine.Physics2DModule",
                "UnityEngine.PhysicsModule",

                "UnityEngine.TextRenderingModule",

                "UnityEngine.TerrainModule",
                "UnityEngine.TerrainPhysicsModule",

                "UnityEngine.UnityWebRequestModule",
                "UnityEngine.UnityWebRequestWWWModule",

                "UnityEngine.VideoModule",

                //"UnityEngine.SpriteMaskModule",
                //"UnityEngine.AccessibilityModule",
                //"UnityEngine.ClothModule",
                //"UnityEngine.GridModule",
                //"UnityEngine.IMGUIModule",
                //"UnityEngine.InputModule",
                //"UnityEngine.JSONSerializeModule",
                //"UnityEngine.ParticlesLegacyModule",
                //"UnityEngine.SharedInternalsModule",
                //"UnityEngine.SpriteShapeModule",
                //"UnityEngine.UIElementsModule",
                //"UnityEngine.WebModule"
            };

            List<Type> remains = new List<Type>();
            foreach (string mod in modlist)
            {
                Assembly assembly = Assembly.Load(mod);
                Type[] types = assembly.GetExportedTypes();

                foreach (Type t in types)
                {
                    if (t.IsDefined(typeof(ObsoleteAttribute), true) ||
                        t.IsNotPublic ||
                        (t.IsAbstract && !t.IsSealed))
                        continue;

                    remains.Add(t);
                }
            }
            return remains;
        }
    }
    
    
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharpGenerate
    { 
        get
        {
            List<Type> exports = new List<Type>();

            string[] modlist = new string[] { 
                "UnityEngine",
                "UnityEngine.CoreModule",
                "UnityEngine.AssetBundleModule",

                "UnityEngine.UI",
                "UnityEngine.UIModule",

                "UnityEngine.AudioModule",

                "UnityEngine.AnimationModule",
                "UnityEngine.DirectorModule",
                "UnityEngine.Timeline",

                "UnityEngine.ScreenCaptureModule",
                
                "UnityEngine.AIModule",
                "UnityEngine.ParticleSystemModule",
                
                "UnityEngine.Physics2DModule",
                "UnityEngine.PhysicsModule",

                "UnityEngine.TextRenderingModule",

                "UnityEngine.UnityWebRequestModule",
                "UnityEngine.UnityWebRequestWWWModule",

                "UnityEngine.VideoModule"
                
            };

            foreach (string mod in modlist)
            {
                Assembly assembly = Assembly.Load(mod);
                Type[] types = assembly.GetExportedTypes();
                foreach (Type t in types)
                {
                    if (filterType(t))
                        exports.Add(t);
                }
            }
            return exports;
        }
    }
    static bool filterType(Type t)
    {
        if (t.IsDefined(typeof(ObsoleteAttribute), true))
            return false;

        if (t.IsNotPublic)
            return false;

        if (t.IsAbstract)
            return false;

        if (t.IsInterface)
            return false;

        if (t.IsClass)
            return false;

        if (t.IsEnum)
            return false;

        if (t.FullName.Contains("UnityEngine.Experimental") ||
            t.FullName.Contains("UnityEngine.Network") ||
            t.FullName.Contains("UnityEngine.WSA") ||
            t.FullName.Contains("UnityEngine.Windows") ||
            t.FullName.Contains("UnityEngine.iOS") ||
            t.FullName.Contains("UnityEngine.tvOS"))
            return false;

        if (t.IsValueType)
            return true;

        return false;
    }
    
     
   
    
}
