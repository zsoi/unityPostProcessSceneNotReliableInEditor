# unityPostProcessSceneNotReliableInEditor
Repro project showing that using the [PostProcessScene] attribute in the editor does yield different results than in a built player

# Report

PostProcessScene attribute behaviour difference between runtime/editor

1. What happened
New game objects created inside a PostProcessScene method are not placed in the right scene in the editor. But it works for deployed players. This is unreliable behavior.

2. How we can reproduce it using the example you attached
- Open the scene "Scenes/SampleScene.unity" in the editor
- Press "play"
- The scene will now additively load 4 other scenes. Check log output, there should be 5 error messages stating "Hey! I'm SingletonPerScene am I am in scene SampleScene"
- Now build a development player
- Run the player
- The on-screen error console there should the 5 distinct messages stating "Hey! I'm SingletonPerScene am I am in scene SampleScene", "Hey! I'm SingletonPerScene am I am in scene SceneAdd01", "Hey! I'm SingletonPerScene am I am in scene SceneAdd02", ...

TL;DR using the PostProcessScene attribute to modify individual scene files does not work in the editor, as it does not have knowledge about which scene it has to post-process. During build, apparently only one scene is ever active, so it works.
